import { Component, OnInit } from '@angular/core';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car-table',
  templateUrl: './car-table.component.html',
  styleUrls: ['./car-table.component.css']
})
export class CarTableComponent implements OnInit {
  public cars = [];

  constructor(private _carService: CarService) { }

  ngOnInit() {
    this._carService.getCars()
      .subscribe(data=> this.cars = data);

  }


  testData = (event) =>{
    console.log(this.cars);
  }

}
