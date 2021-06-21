import { SimpleEntity } from "./simple-entity";
import { UserSessionHistory } from "./user-session-history";

export class User extends SimpleEntity {
    firstName: string;
    lastName: string;
    email: string;
    username: string;
    password: string;
    token: string;
    points: number;
    status: string;
    admin: boolean;
    userSessionHistories: UserSessionHistory[];
}
