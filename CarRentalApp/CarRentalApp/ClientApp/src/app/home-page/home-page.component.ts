import { Component, OnInit } from '@angular/core';
import { CarService } from '../services/cars.service'
import { CityService } from '../services/cities.service'

import { Car } from '../models/car';
import { City } from '../models/city';
@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {
  public cars = [];
  public randomCars: Car[]=[];
  public city: City[] = [];
  public hours = [];

  constructor(private _carService: CarService, private _cityService: CityService) { }

  ngOnInit() {
    
    this._carService.getAllCars().subscribe(data => this.cars = data);
    
    this._carService.getRandomCars().subscribe(data => this.randomCars = data);

    this._cityService.getAllCities().subscribe(data => this.city = data);

    this.hours = ["00:00","01:00","02:00","03:00","04:00","05:00","06:00","07:00","08:00","09:00","10:00","11:00","12:00","13:00","14:00","15:00","16:00","17:00","18:00","19:00","20:00","21:00","22:00","23:00"];
  }

  testData = (event) => {
    console.log(this.cars);
  }
   
}
