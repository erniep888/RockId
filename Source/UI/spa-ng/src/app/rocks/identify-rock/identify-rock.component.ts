import { Component, OnInit } from '@angular/core';
import { QarpService } from './qarp.service';
import Qarp from './qarp';

@Component({
  selector: 'app-identify-rock',
  templateUrl: './identify-rock.component.html',
  styleUrls: ['./identify-rock.component.css']
})
export class IdentifyRockComponent implements OnInit {

  private currentQuestion: Qarp;
  private currentAnswers: Qarp[];
  private selectedAnswer: Qarp;

  constructor(private qarpService: QarpService) { }

  ngOnInit() {    
    this.getNextQuestion();
  }

  getNextQuestion(): void{
    let selectedAnswerId: number = (this.selectedAnswer) ? this.selectedAnswer.id : null;
    this.qarpService.getNextQuestion(selectedAnswerId).then((results) => {
      this.currentQuestion = results.nextQuestion;
      this.getCurrentAnswers();
    });
  }

  getCurrentAnswers(): void{
    this.qarpService.getCurrentAnswers(this.currentQuestion.id).then((results) => {
      this.currentAnswers = results.currentAnswers;
    });
  }
}
