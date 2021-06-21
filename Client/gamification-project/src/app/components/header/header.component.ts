import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { User } from 'src/app/models/user';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  private sub: Subscription;

  currentUser: User = null;

  constructor(
    private accountService: AccountService
  ) { }

  ngOnInit() {
    this.sub = this.accountService.user.subscribe(user => {
      this.currentUser = user;
    });
  }

  logout() { }
}
