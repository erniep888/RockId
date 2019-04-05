import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private httpClient: HttpClient) { }

  get(url: string, params?: any): Observable<any> {
    const options = {
      params: params
     };    

    return this.httpClient.get(url, options)
      .pipe(
        map((res: Response) => {
          return res;
        }),
        catchError(this.handleError)
      );
  }

  private handleError(error: any) {
    if (error.error instanceof ErrorEvent) {        
      console.error('Service error occurred:', error.error.message);
    } else {
      console.error(`Service returned code ${error.status}, ` + `body was: ${error.error}`);
    }    
    return throwError(error || 'Service error');
  }
}
