import { Injectable } from '@angular/core';
import { DataService } from 'src/app/common/services/data.service';
import { EnvironmentService } from 'src/app/common/services/environment.service';
import { HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class QarpService {

  private apiUrl: string;

  constructor(private dataService: DataService, private environmentService: EnvironmentService) { 
    this.apiUrl = `${this.environmentService.apiBaseUrl}/api/${this.environmentService.apiVersion}`;
  }

  async getNextQuestion(selectedAnswerId: number){
    var nextQuestionBaseUrl = `${this.apiUrl}/nextquestion`;
    var nextQuestionUrl = (selectedAnswerId) ? `${nextQuestionBaseUrl}/${selectedAnswerId.toString()}` : nextQuestionBaseUrl;

    const nextQuestion = await this.dataService.get(nextQuestionUrl).toPromise();
    
    return {
      nextQuestion: nextQuestion
    };
  }

  async getCurrentAnswers(currentQuestionId: number){
    const currentAnswers = await this.dataService.get(`${this.apiUrl}/currentanswers/${currentQuestionId.toString()}`).toPromise();

    return {
      currentAnswers: currentAnswers
    };
  }
}
