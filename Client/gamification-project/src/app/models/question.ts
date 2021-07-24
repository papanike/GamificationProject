import { Choice } from './choice';
import { SimpleEntity } from './simple-entity';

export class Question extends SimpleEntity {
	questionName: string;
	difficulty: DifficultyLevel;
	choices: Choice[];
}

export enum DifficultyLevel {
	Easy = 1,
	Normal = 2,
	Hard = 3
}