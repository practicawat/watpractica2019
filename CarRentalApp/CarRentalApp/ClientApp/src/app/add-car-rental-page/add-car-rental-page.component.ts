import { Component, OnInit } from '@angular/core';
import { CarService } from 'src/app/services/cars.service';
import { InfoUser } from '../models/infoUser';

export class someUser {
  constructor(
    
   
    public FirstName: string,
    public LastName: string,
    public Email: string,
    public PhoneNumber: number,

  ) { }



}
@Component({
  selector: 'app-add-car-rental-page',
  templateUrl: './add-car-rental-page.component.html',
  styleUrls: ['./add-car-rental-page.component.css']
})
export class AddCarRentalPageComponent implements OnInit {
  public cars = [];
  public users = [];
  public selectedCars = [];

  
  constructor(private _carService: CarService) { }

  clickAction1(event) {
    let newUser: someUser;

    
    var firstName = ((document.getElementById("userFirstName") as HTMLInputElement).value);
    var lastName = ((document.getElementById("userLastName") as HTMLInputElement).value);
    var email = ((document.getElementById("email") as HTMLInputElement).value);
    var phoneNumber = Number((document.getElementById("phoneNumber") as HTMLInputElement).value);
    newUser = new someUser(firstName, lastName, email, phoneNumber);
    alert("You just added a new user!");
    console.log(newUser)
    this._carService.addNewUser(newUser).subscribe(newUser => this.users.push(newUser));
  }


  ngOnInit() {
    this._carService.getAllCars()
      .subscribe(data => this.cars = data);
    this.selectedCars = history.state.data.selectedCars;
  }


}
