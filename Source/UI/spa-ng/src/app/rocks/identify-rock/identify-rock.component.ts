import { Component, OnInit } from '@angular/core';
import { QarpService } from './qarp.service';
import Qarp from './qarp';

@Component({
  selector: 'app-identify-rock',
  templateUrl: './identify-rock.component.html',
  styleUrls: ['./identify-rock.component.css']
})
export class IdentifyRockComponent implements OnInit {

  private currentQuestion: Qarp

  constructor(private qarpService: QarpService) { }

  ngOnInit() {    
    this.getNextQuestion();
  }

  getNextQuestion(): void{
    this.qarpService.getNextQuestion().then((results) => {
      this.currentQuestion = results.nextQuestion;
    });
  }
}
