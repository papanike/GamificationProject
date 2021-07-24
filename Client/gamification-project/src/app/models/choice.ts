import { SimpleEntity } from "./simple-entity";

export class Choice extends SimpleEntity {
    questionId: number;
    choiceName: string;
    right: boolean;
}

