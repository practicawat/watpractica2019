import { Component, OnInit } from '@angular/core';
import { Car } from '../models/car';
import { CarService } from '../services/cars.service';
@Component({
  selector: 'app-car-component',
  templateUrl: './car-component.component.html',
  styleUrls: ['./car-component.component.css']
})
export class CarComponentComponent implements OnInit {

  cars: Array<Car>;
  constructor(private carService: CarService) { }

  ngOnInit() {
    this.carService.getAllCars().subscribe(cars => {
      console.log(cars)
      this.cars = cars;
    });
  }

}
