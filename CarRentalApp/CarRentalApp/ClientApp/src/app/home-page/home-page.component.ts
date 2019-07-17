import { Component, OnInit } from '@angular/core';
import { Car } from '../models/car';
import {CarService} from '../services/cars.service'

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {

  cars: Array<Car>;
  constructor(private carService: CarService) { }

  ngOnInit() {
    this.carService.getAllCars().subscribe(cars => {
      console.log(cars)
      this.cars = cars;
    });
  }

}
