import { Component, OnInit } from '@angular/core';
import { Car } from '../models/car';
import { CarService } from '../services/cars.service';


export class someCar {
  constructor(
    public brand: string,
    public model: string,
    public licensePlate: string,
    public nrOfSeats: number,
    public nrOfDoors: number,
    public hasAutomaticGearbox: boolean,
    public pricePerDay: number,

  ) { }

    

}

@Component({
  selector: 'app-add-new-car',
  templateUrl: './add-new-car.component.html',
  styleUrls: ['./add-new-car.component.css']
})
export class AddNewCarComponent implements OnInit {
  public cars = [];

constructor(private _carService: CarService) { }


  clickAction(event) {

   let newCar: someCar;
    alert("You just added a new car!");
    var brand = ((document.getElementById("brand") as HTMLInputElement).value);
    var model = ((document.getElementById("brand") as HTMLInputElement).value);
    var licensePlate = ((document.getElementById("licP") as HTMLInputElement).value);
    var nrOfSeats = Number(((document.getElementById("seatnb") as HTMLInputElement).value));
    var nrOfDoors = Number((document.getElementById("doornb") as HTMLInputElement).value);
    var gearbox = ((document.getElementById("gearbox") as HTMLInputElement).checked);
    var pricePerDay = Number((document.getElementById("price") as HTMLInputElement).value);
    newCar = new someCar(brand, model, licensePlate, nrOfDoors, nrOfSeats, gearbox, pricePerDay);
  

    console.log(newCar)

    this._carService.addNewCar(newCar).subscribe(newCar => this.cars.push(newCar));

   
    console.log("The car is:" + this.cars);
     
  }

  ngOnInit() {

  }

}
