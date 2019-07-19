import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { City } from '../models/city';

@Injectable({
  providedIn: 'root'
})
export class CityService {

  private readonly profileUrl: string = "api/City";

  constructor(protected http: HttpClient) { }

  getAllCities(): Observable<City[]> {
    return this.http.get<City[]>(this.profileUrl);
  }
}
