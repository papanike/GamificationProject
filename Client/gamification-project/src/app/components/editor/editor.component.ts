import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Choice } from 'src/app/models/choice';
import { DifficultyLevel, Question } from 'src/app/models/question';
import { QuestionAddEditModel } from 'src/app/models/question-add-edit-model';
import { QuestionComponent } from '../question/question.component';

@Component({
  selector: 'app-editor',
  templateUrl: './editor.component.html',
  styleUrls: ['./editor.component.scss']
})
export class EditorComponent implements OnInit {

  questions: Question[] = [];
  constructor(public dialog: MatDialog) { }

  ngOnInit() {
    let q = new Question();
    q.id = 1;
    q.questionName = "How old are you?";
    q.difficulty = DifficultyLevel.Easy;
    let choice1 = new Choice();
    choice1.choiceName = "<18";
    choice1.questionId = 1;
    choice1.right = true;
    choice1.id = 1; 
    let choice2 = new Choice();
    choice2.choiceName = ">=18";
    choice2.questionId = 1;
    choice2.right = true;
    choice2.id = 2;
    q.choices = [];
    q.choices.push(choice1, choice2);
    this.questions.push(q);
  }

  addNew() {
    const model = new QuestionAddEditModel();
    model.isNew = true;
    model.choices = [];

    const dialogRef = this.dialog.open(QuestionComponent, {
      width: '60%',
      data: model
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        const newQuestion = new Question();
        newQuestion.questionName = result.description;
      }
    });
  }

  removeFromList(entity: Question) {
    const index: number = this.questions.indexOf(entity);
    if (index !== -1) {
      this.questions.splice(index, 1);
    }
  }
}
