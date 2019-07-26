import { Component, OnInit } from '@angular/core';
import { CarService } from '../services/cars.service';
import { Car } from '../models/car';
import { Images } from '../models/Images';

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
  public showCars = [];
  constructor(private _carService: CarService) { }

  clickAction(event) {
    let newCar: someCar;
    let images : Images[];


 

    alert("You just updated the car!");
    var brand = ((document.getElementById("brand") as HTMLInputElement).value);
    var model = ((document.getElementById("model") as HTMLInputElement).value);
    var licensePlate = ((document.getElementById("licP") as HTMLInputElement).value);
    var nrOfSeats = Number(((document.getElementById("seatnb") as HTMLInputElement).value));
   var nrOfDoors = Number((document.getElementById("doornb") as HTMLInputElement).value);
    var gearbox = ((document.getElementById("gearbox") as HTMLInputElement).checked);
    var pricePerDay = Number((document.getElementById("price") as HTMLInputElement).value);
    newCar = new someCar(brand, model, licensePlate, nrOfDoors, nrOfSeats, gearbox, pricePerDay,images);


   // console.log(newCar)

    this._carService.updateCar(newCar).subscribe(newCar => this.cars.push(newCar));


    //console.log("The car is:" + this.cars);

  }

  ngOnInit() {
    this._carService.getAllCars()
      .subscribe(data => {
        this.cars = data
        this.showCars = this.cars
      })
  }

}
