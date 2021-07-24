import { Component, EventEmitter, Inject, Input, OnInit, Output } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Choice } from 'src/app/models/choice';
import { Question } from 'src/app/models/question';
import { QuestionAddEditModel } from 'src/app/models/question-add-edit-model';

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.scss']
})
export class QuestionComponent implements OnInit {

  @Input() question: Question;
  @Input() edit: Boolean;
  @Output() removeItem: EventEmitter<Question> = new EventEmitter<Question>();

  constructor(private dialogRef: MatDialogRef<QuestionComponent>,
		@Inject(MAT_DIALOG_DATA) public data: QuestionAddEditModel) { }

  ngOnInit(): void {
  }

  remove() {
    this.removeItem.emit(this.question);
  }

  addRow() {
    let choice = new Choice();
    this.question.choices.push(choice);
  }

  removeOption(choice: Choice) {
    const index = this.question.choices.indexOf(choice);
    if (index !== -1) {
      this.question.choices.splice(index, 1);
    }
  }
  
	onCancel(): void {
		this.dialogRef.close();
	}
}
