import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Car } from '../models/car';


@Injectable({ providedIn: 'root' })
export class CarService {
  private readonly profileUrl: string = "api/Cars";
  private readonly profileUrlRandom: string = "api/Cars/GetRandomCars";

  constructor(protected http: HttpClient) { }



  getAllCars(): Observable<Car[]> {
    return this.http.get<Car[]>(this.profileUrl);
  }

  getRandomCars(): Observable<Car[]> {
    return this.http.get<Car[]>(this.profileUrlRandom);
  }

  addNewCar(newCar: Car) {
    return this.http.post<Car>(this.profileUrl, newCar);
  } 

}
