import { Injectable } from '@angular/core';
import { SearchedCar } from '../models/searchedCar';
import { Observable } from 'rxjs';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class SearchedCarService {

  private readonly profileUrl: string = "api/SearchedCars";

  constructor(protected http: HttpClient) { }

  postSearchedInfo(searchedCar : SearchedCar): Observable<SearchedCar> {
    return this.http.post<SearchedCar>(this.profileUrl, searchedCar);
  } 
}
