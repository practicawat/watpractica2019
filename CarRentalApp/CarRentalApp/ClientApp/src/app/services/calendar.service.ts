
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Rental } from '../models/car';

@Injectable({
  providedIn: 'root'
})
export class CalendarService {

  private readonly profileUrl: string = "api/Rentals";

  constructor(protected http: HttpClient) { }

  getAllRentals(): Observable<Rental[]> {
    return this.http.get<Rental[]>(this.profileUrl);
  }
}
