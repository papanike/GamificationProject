import { SimpleEntity } from "./simple-entity";

export class Alert extends SimpleEntity{
    type: AlertType;
    message: string;
    autoClose: boolean;
    keepAfterRouteChange: boolean;
    fade: boolean;

    constructor(init?:Partial<Alert>) {
        super();
        Object.assign(this, init);
    }
}

export enum AlertType {
    Success,
    Error,
    Info,
    Warning
}