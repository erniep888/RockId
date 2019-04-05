import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EnvironmentService {

  public apiVersion: string = environment.apiVersion;
  public apiBaseUrl: string = environment.apiBaseUrl;
  
  constructor() { }
}
