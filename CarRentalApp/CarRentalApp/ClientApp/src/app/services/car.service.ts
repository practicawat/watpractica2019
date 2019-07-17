import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ICar } from '../models/car';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class CarService {

  private getUrl : string = "http://localhost:53647/api/Cars/"
  constructor(private http: HttpClient) {
}
    getCars = (): Observable<ICar[]>=>{
        return this.http.get<ICar[]>(this.getUrl); 
    }
}



