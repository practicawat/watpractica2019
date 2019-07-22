import { Component, OnInit } from '@angular/core';
import { CarService } from '../services/cars.service'
import { CityService } from '../services/cities.service'

import { Car } from '../models/car';
import { City } from '../models/city';
import { SearchedCar } from '../models/searchedCar';
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
  public searchedCar: SearchedCar; 

  constructor(private _carService: CarService, private _cityService: CityService) { }

  ngOnInit() {
    
    this._carService.getAllCars().subscribe(data => this.cars = data);
    
    this._carService.getRandomCars().subscribe(data => this.randomCars = data);

    this._cityService.getAllCities().subscribe(data => this.city = data);

    this.searchedCar = new SearchedCar(" ", " ", "  ", " ", " ", "  ", " ", false);  

    this.hours = ["00:00 AM", "01:00 AM", "02:00 AM", "03:00 AM", "04:00 AM", "05:00 AM", "06:00 AM", "07:00 AM", "08:00 AM", "09:00 AM", "10:00 AM", "11:00 AM", "12:00 AM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM ", "6:00 PM", "7:00 PM", "8:00 PM", "9:00 PM", "10:00 PM", "11:00 PM"];
  }

  testData = (event) => {
    console.log(this.cars);
  }

  selectChangeHandler(event: any) {
    this.searchedCar.selectedCity = event.target.value;
  }

  selectPickupHourHandler(event: any) {
    this.searchedCar.selectedPickupHour = event.target.value;
  }

  selectReturnHourHandler(event: any) {
    this.searchedCar.selectedReturnHour = event.target.value;
  }

  selectPickupPeriodHandler(event: any) {
    this.searchedCar.selectedPickupPeriod = event.target.value;
  }

  selectReturnPeriodHandler(event: any) {
    this.searchedCar.selectedReturnPeriod = event.target.value;
  }

  verifyChecked(input: HTMLInputElement) {
    input.checked == true ? this.searchedCar.isChecked = true : this.searchedCar.isChecked = false;
  }

  concatenateDateAndTime(event: any) {
    this.searchedCar.concatenatePickup = this.searchedCar.selectedPickupPeriod + " " + this.searchedCar.selectedPickupHour;
    this.searchedCar.concatenateReturn = this.searchedCar.selectedReturnPeriod + this.searchedCar.selectedReturnHour;
  }
}
