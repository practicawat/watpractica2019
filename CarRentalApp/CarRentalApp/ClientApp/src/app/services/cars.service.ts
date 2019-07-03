import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Car } from '../models/car';


@Injectable({ providedIn: 'root' })
export class CarService {
  private readonly profileUrl: string = "api/Cars";

  constructor(protected http: HttpClient) { }



  getAllCars(): Observable<Car[]> {
    return this.http.get<Car[]>(this.profileUrl);
  }

  

}
