import { Component } from '@angular/core';

import { CarService } from '../services/cars.service';
import { Images } from '../models/Images';
import { Car } from '../models/car';
import { FormGroup, FormControl } from '@angular/forms';
import { HttpClient, HttpRequest, HttpEventType, HttpResponse } from '@angular/common/http';

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
  selector: 'app-add-new-car',
  templateUrl: './add-new-car.component.html',
  styleUrls: ['./add-new-car.component.css']
})
export class AddNewCarComponent {
  public cars = [];
  public newCar: someCar;
  newCarForm: FormGroup= new FormGroup({
    brand: new FormControl(''),
    model: new FormControl(''),
    licP: new FormControl(''),
    seatnb: new FormControl(''),
    doornb: new FormControl(''),
    price: new FormControl(''),
    gearbox: new FormControl(''),
    inputGroupFile01: new FormControl(''),
});
  onSubmit(files) {

    const formData = new FormData();
    for (let file of files)
      formData.append(file.name, file);
    const uploadReq = new HttpRequest('POST', `api/Cars/uploads`, formData);
    this.http.request(uploadReq).subscribe();

    var imageList: Images[];
    var myImage = new Images();
    myImage.Img = this.newCarForm.controls['inputGroupFile01'].value;
    //console.log(this.newCarForm.controls['price'].value + ' price');
    //console.log(this.newCarForm.controls['gearbox'].value + ' gearbox');

    imageList = [myImage];
    this.newCar = new someCar(
      this.newCarForm.controls['brand'].value,
      this.newCarForm.controls['model'].value,
      this.newCarForm.controls['licP'].value,
      this.newCarForm.controls['seatnb'].value,
      this.newCarForm.controls['doornb'].value,
      Boolean(this.newCarForm.controls['gearbox'].value),
      this.newCarForm.controls['price'].value,
      imageList
    );

 
  console.log(this.newCar);
  this._carService.addNewCar(this.newCar).subscribe(newCar => this.cars.push(newCar));
    alert("New car added!");
}

  constructor(private _carService: CarService, private http: HttpClient) {
   
  }


  //clickAction(event) {
    

  //  alert("You just added a new car!");
  //  var brand = ((document.getElementById("brand") as HTMLInputElement).value);
  //  var model = ((document.getElementById("brand") as HTMLInputElement).value);
  //  var licensePlate = ((document.getElementById("licP") as HTMLInputElement).value);
  //  var nrOfSeats = Number(((document.getElementById("seatnb") as HTMLInputElement).value));
  //  var nrOfDoors = Number((document.getElementById("doornb") as HTMLInputElement).value);
  //  var gearbox = ((document.getElementById("gearbox") as HTMLInputElement).checked);
  //  var pricePerDay = Number((document.getElementById("price") as HTMLInputElement).value);

  //  let newImageObj: Images = new Images();
  //  newImageObj.Img = ((document.getElementById("inputGroupFile01") as HTMLInputElement).value);;
  //  let imageList: Images[] = new Array(100);
  //  imageList[0] = newImageObj;
  //  newCar = new someCar(brand, model, licensePlate, nrOfDoors, nrOfSeats, gearbox, pricePerDay, imageList);
  

  //  console.log(newCar)

  //  this._carService.addNewCar(newCar).subscribe(newCar => this.cars.push(newCar));

   

     
  //}
  
  ngOnInit() {
    
  }

}
