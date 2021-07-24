import { Question } from "./question";

export class QuestionAddEditModel extends Question {
	isNew: boolean;
	readonly: boolean;
}
