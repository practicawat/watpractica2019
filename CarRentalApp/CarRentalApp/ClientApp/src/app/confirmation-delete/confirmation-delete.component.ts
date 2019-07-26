import { Component, OnInit } from '@angular/core';
import { CarService } from 'src/app/services/cars.service';
import { Car } from '../models/car';



@Component({
  selector: 'confirmation-delete',
  templateUrl: './confirmation-delete.component.html',
  styleUrls: ['./confirmation-delete.component.css']
})
export class ConfirmationDeleteComponent implements OnInit {

  public selectedCar: Car

  constructor(private _carService: CarService) {
  }

  ngOnInit() {

      this.selectedCar = history.state.data.selectedCar;
      console.log(this.selectedCar)

  }



  clickAction(event) {
    alert("Butonul a fost apasat!");
   // var licensePlate = ((HTMLDocument.arguments.carPlate as HTMLLabelElement).getAttributeNode);
    console.log(this.selectedCar + '123asdasdsa') 
    debugger
    this._carService.deleteCar(this.selectedCar)
      .subscribe();

    
  }

  clickActionDeleteNo(event) {
    alert("A fost apasat nu!");
  }

}
