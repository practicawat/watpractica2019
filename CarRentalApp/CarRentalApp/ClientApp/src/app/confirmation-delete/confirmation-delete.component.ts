import { Component, OnInit } from '@angular/core';
import { CarService } from 'src/app/services/cars.service';



@Component({
  selector: 'confirmation-delete',
  templateUrl: './confirmation-delete.component.html',
  styleUrls: ['./confirmation-delete.component.css']
})
export class ConfirmationDeleteComponent implements OnInit {
  public cars = [];

  constructor(private _carService: CarService) {
  }

  ngOnInit() {
    this._carService.getAllCars()
      .subscribe(data => this.cars = data);

  }

  testData = (event) => {
    console.log(this.cars);
  }

  clickAction(event) {
    alert("Butonul a fost apasat!");
    var licensePlate = ((HTMLDocument.arguments.carPlate as HTMLLabelElement).getAttributeNode);


    this._carService.deleteCar(this.cars[0])
      .subscribe();

    
  }

  clickActionDeleteNo(event) {
    alert("A fost apasat nu!");
  }

}
