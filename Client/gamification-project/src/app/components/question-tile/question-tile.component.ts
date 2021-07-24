import { Component, EventEmitter, Inject, Input, OnInit, Output } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Choice } from 'src/app/models/choice';
import { Question } from 'src/app/models/question';
import { QuestionAddEditModel } from 'src/app/models/question-add-edit-model';
import { QuestionComponent } from '../question/question.component';

@Component({
  selector: 'app-question-tile',
  templateUrl: './question-tile.component.html',
  styleUrls: ['./question-tile.component.scss']
})
export class QuestionTileComponent implements OnInit {

  @Input() question: Question;
  @Input() editMode: Boolean;
  @Output() removeItem: EventEmitter<Question> = new EventEmitter<Question>();

  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }

  edit() {
    const model = new QuestionAddEditModel();
    model.id = this.question.id;
    model.isNew = false;
    const dialogRef = this.dialog.open(QuestionComponent, {
      width: '60%',
      data: model
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.question.questionName = result.description;
        this.question.difficulty = result.difficulty;
        this.question.choices = result.choices;
      }
    });
  }

  remove() {
    this.removeItem.emit(this.question);
  }
}
