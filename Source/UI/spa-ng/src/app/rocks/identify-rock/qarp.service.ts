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
    this.apiUrl = `${this.environmentService.apiBaseUrl}/api/${this.environmentService.apiVersion}/nextquestion`;
  }

  async getNextQuestion(){
    let params = new HttpParams();
      
    const nextQuestion = await this.dataService.get(`${this.apiUrl}`, params).toPromise();

    return {
      nextQuestion: nextQuestion
    };
  }
}
