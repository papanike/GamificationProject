using GamificationProject.Data;
using GamificationProject.Interfaces;
using GamificationProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GamificationProject.Server.Services
{
    public class UserService : SimpleDetailedService<User>
    {
        public UserService(IRepository<User> repository, ISessionProvider sessionProvider) : base(repository, sessionProvider)
        {
        }

        public override IEnumerable<User> All()
        {
            return CleanSecureData(base.All());
        }

        public override IEnumerable<User> AllDetailed()
        {
            return CleanSecureData(base.AllDetailed());
        }

        public override User Get(int id)
        {
            return CleanSecureData(base.Get(id));
        }

        public override User GetDetailed(int id)
        {
            return CleanSecureData(base.GetDetailed(id));
        }

        public override IEnumerable<User> Get(Expression<Func<User, bool>> query)
        {
            return CleanSecureData(base.Get(query));
        }

        public override IEnumerable<User> GetDetailed(Expression<Func<User, bool>> query)
        {
            return CleanSecureData(base.GetDetailed(query));
        }

        public override void Insert(User entity)
        {
            PasswordHelper.GenerateHashes(entity, entity.Password);
            base.Insert(entity);
        }

        public override void Update(User entity)
        {
            var existing = this.GetUnsecure(entity.Id);
            if (existing == null) throw new Exception("Entity not found");

            if (string.IsNullOrEmpty(entity.Password))
            {
                entity.PasswordHash = existing.PasswordHash;
                entity.PasswordSalt = existing.PasswordSalt;
            }
            else
            {
                PasswordHelper.GenerateHashes(entity, entity.Password);
            }

            base.Update(entity);
        }

        #region [ Helpers ]

        private User GetUnsecure(int id)
        {
            return base.Get(id);
        }

        private static User CleanSecureData(User user)
        {
            user.PasswordHash = user.PasswordSalt = null;
            return user;
        }

        private static IEnumerable<User> CleanSecureData(IEnumerable<User> users)
        {
            foreach (var item in users)
            {
                yield return CleanSecureData(item);
            }
        }

        #endregion
    }
}
