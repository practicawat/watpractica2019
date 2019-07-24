import { Injectable } from '@angular/core';
import { SearchedCar } from '../models/searchedCar';
import { Observable } from 'rxjs';
import { HttpClient } from "@angular/common/http";
import { Car } from '../models/car';

@Injectable({
  providedIn: 'root'
})
export class SearchedCarService {

  private readonly profileUrl: string = "api/SearchedCar";

  constructor(protected http: HttpClient) { }

  postSearchedInfo(searchedCar : SearchedCar): Observable<Car[]> {
    return this.http.post<Car[]>(this.profileUrl, searchedCar);
  } 
}
