import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Car } from '../models/car';
import { InfoUser } from '../models/infoUser';
import { Config } from 'protractor';
import { SearchedCar } from '../models/searchedCar';


@Injectable({ providedIn: 'root' })
export class CarService {

  private readonly profileUrl: string = "api/Cars";
  private readonly profileUrlRandom: string = "api/Cars/GetRandomCars";

  private readonly profileUrlGet: string = "api/Cars/GetCar";
  private readonly profileUrlUser: string = "api/InfoUser";

  private readonly randomUrl: string = 'http://localhost:64738/api/cars/BV-asd-asd';

  constructor(protected http: HttpClient) { }


  updateCar(newCar: Car): Observable<{}> {
    const urll = `${this.configUrl}/${newCar.licensePlate}`; // UPDATE api/Cars/
    return this.http.put(this.randomUrl, newCar);
  }

  getAllCars(): Observable<Car[]> {
    return this.http.get<Car[]>(this.profileUrl);
  }




  addNewCar(newCar: Car): Observable<Car>{
    return this.http.post<Car>(this.profileUrl, newCar);
  }


  addNewUser(newUser: InfoUser): Observable<InfoUser> {
    return this.http.post<InfoUser>(this.profileUrlUser, newUser);

  }
  configUrl = 'ClientApp/tsconfig.json';

 

  getConfig() {
    return this.http.get(this.configUrl);
  }
  

  

  deleteCar(someCar: Car): Observable<{}> {

    const urll = `${this.configUrl}/${someCar.licensePlate}`; // DELETE api/Cars/
    return this.http.delete(urll);

  }
  
  getRandomCars(): Observable<Car[]> {
    return this.http.get<Car[]>(this.profileUrlRandom);
  }


}
