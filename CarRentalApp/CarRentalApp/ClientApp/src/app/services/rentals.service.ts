import { Injectable } from '@angular/core';
import { Rentals } from '../models/rentals';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class RentalsService {

  private readonly profileUrl: string = "api/Rentals";
  constructor(protected http: HttpClient) { }

  getAllRentals(): Observable<Rentals[]> {
    return this.http.get<Rentals[]>(this.profileUrl);
  }

  addNewRental(newRental: Rentals): Observable<Rentals> {
    return this.http.post<Rentals>(this.profileUrl, newRental);
  }
}
