import { Component, OnInit } from '@angular/core';
import { CarService } from 'src/app/services/cars.service';
import { findLast } from '@angular/compiler/src/directive_resolver';
export class PageState{
  constructor(
    public firstButton: number,
    public middleButton: number,
    public leftButton: number,

    public isFirstButtonSelected :boolean,
    public isMiddleButtonSelected :boolean,
    public isLeftButtonSelected :boolean,
  ){}
}



@Component({
  selector: 'app-car-table',
  templateUrl: './car-table.component.html',
  styleUrls: ['./car-table.component.css']
})
export class CarTableComponent implements OnInit {
  public cars = [];
  public pageState :PageState;
  public leftClassManager = {}
  public middleClassManager = {}
  public rightClassManager = {}




  constructor(private _carService: CarService) {
   this.pageState = new PageState(
     1,2,3,true,false,false)
    this.initiatePageManagers();
   }


  ngOnInit() {
    this._carService.getAllCars()
      .subscribe(data=> this.cars = data);

  }


  initiatePageManagers = () =>{
    this.leftClassManager = {
      "btn" : true,
      "btn-primary" : this.pageState.isFirstButtonSelected,
      "btn-default" : !this.pageState.isFirstButtonSelected,
    }
    this.middleClassManager = {
      "btn" : true,
      "btn-primary" : this.pageState.isMiddleButtonSelected,
      "btn-default" : !this.pageState.isMiddleButtonSelected,
    }
    this.rightClassManager = {
      "btn" : true,
      "btn-primary" : this.pageState.isLeftButtonSelected,
      "btn-default" : !this.pageState.isLeftButtonSelected,
    }
  }


  testData = (event) =>{
    console.log(this.cars);
    console.log(Object.keys(this.cars).length);
    console.log(this.pageState.firstButton);
  }

  changePage = (event) =>{
    var target = event.target || event.srcElement || event.currentTarget

    console.log(target.attributes.id.value)
    if(target.attributes.id.value ==="middle"){
      this.pageState.isFirstButtonSelected = false;
      this.pageState.isMiddleButtonSelected = true;
      this.pageState.isLeftButtonSelected = false;
      this.initiatePageManagers()
    }
    if(target.attributes.id.value ==="first"){
      this.pageState.isFirstButtonSelected = true;
      this.pageState.isMiddleButtonSelected = false;
      this.pageState.isLeftButtonSelected = false;
      this.initiatePageManagers()
    }
    if(target.attributes.id.value ==="right"){
      this.pageState.isFirstButtonSelected = false;
      this.pageState.isMiddleButtonSelected = false;
      this.pageState.isLeftButtonSelected = true;
      this.initiatePageManagers()
    }
  }

}
