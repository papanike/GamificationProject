import { SimpleEntity } from "./simple-entity";

export class UserSessionHistory extends SimpleEntity {
    loggedTime: Date;
    pointsGained: number;
}