import { Component, OnInit } from '@angular/core';
import { CarService } from '../services/cars.service';
import { Car } from '../models/car';
import { Images } from '../models/Images';
import { FormGroup, FormControl } from '@angular/forms';
import { HttpRequest, HttpClient } from '@angular/common/http';

export class someCar implements Car {
  constructor(
    public brand: string,
    public model: string,
    public licensePlate: string,
    public nrOfSeats: number,
    public nrOfDoors: number,
    public hasAutomaticGearbox: boolean,
    public pricePerDay: number,
    public ImageList: Images[]

  ) { }
}

@Component({
  selector: 'app-edit-car',
  templateUrl: './edit-car.component.html',
  styleUrls: ['./edit-car.component.css']
})
export class EditCarComponent implements OnInit {

  public cars = [];
  public currentCar: someCar;
  public showCars = [];
  constructor(private _carService: CarService, private http: HttpClient) {

  }

  
  clickAction(event) {
    

    
    var brand = ((document.getElementById("brand") as HTMLInputElement).value);
    var model = ((document.getElementById("model") as HTMLInputElement).value);
    var licensePlate = ((document.getElementById("licP") as HTMLInputElement).value);
    var nrOfSeats = Number(((document.getElementById("seatnb") as HTMLInputElement).value));
    var nrOfDoors = Number((document.getElementById("doornb") as HTMLInputElement).value);
    var gearbox = ((document.getElementById("gearbox") as HTMLInputElement).checked);
    var pricePerDay = Number((document.getElementById("price") as HTMLInputElement).value);
    var Image = null;
    this.currentCar = new someCar(brand, model, licensePlate, nrOfDoors, nrOfSeats, gearbox, pricePerDay, Image);
    alert("You just updated the car!");


    this._carService.updateCar(this.currentCar).subscribe(newCar => this.cars.push(newCar));
  }

  

  ngOnInit() {
   this._carService.getAllCars()
      .subscribe(data => {
        this.cars = data
        this.currentCar = this.cars[0]
      })
  }

}
