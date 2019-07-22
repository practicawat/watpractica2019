import { Component, OnInit } from '@angular/core';
import { Car } from '../models/car';
import { CarService } from '../services/cars.service';

@Component({
  selector: 'app-add-new-car',
  templateUrl: './add-new-car.component.html',
  styleUrls: ['./add-new-car.component.css']
})
export class AddNewCarComponent implements OnInit {

  constructor() { }

  clickAction(event) {
    let newCar: Car;
    let carservice: CarService;
    newCar.brand = "brand";
    newCar.model;
    carservice.addNewCar(newCar);
    alert("You just added a new car!");
  }

  ngOnInit() {
  }

}
