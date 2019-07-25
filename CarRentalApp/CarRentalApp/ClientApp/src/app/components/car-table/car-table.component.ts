import { Component, OnInit } from '@angular/core';
import { CarService } from 'src/app/services/cars.service';
import { SearchedCarService } from 'src/app/services/searched-car.service';
import { findLast } from '@angular/compiler/src/directive_resolver';
import { SearchedCar } from 'src/app/models/searchedCar';
import { isUndefined } from 'util';
import { Router } from '@angular/router';
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
  public showCars = [];
  public pageState :PageState;
  public currentPage : number;
  public leftClassManager = {}
  public middleClassManager = {}
  public rightClassManager = {}
  public searchedCars = [];
  public searchedCar: SearchedCar;



  constructor(private router : Router,private _carService: CarService, private _searchedCarService: SearchedCarService) {
   this.pageState = new PageState(
     1,2,3,true,false,false)
    this.initiatePageManagers();
   }


  ngOnInit() {
    if (isUndefined(history.state.data) || isUndefined(history.state.data.cars)) {
      this._carService.getAllCars()
        .subscribe(data => {
          this.cars = data
          this.showCars = this.cars.slice(0, 3)
        })
    } else {
      this.cars = history.state.data.cars;
      this.showCars = this.cars.slice(0, 3);
    }
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

    console.log(target.attributes)
    if(target.attributes.id.value ==="middle"){
      this.pageState.isFirstButtonSelected = false;
      this.pageState.isMiddleButtonSelected = true;
      this.pageState.isLeftButtonSelected = false;
      this.showCars = this.cars.slice(3,6);
      this.initiatePageManagers()
    }
    if(target.attributes.id.value ==="first"){
      this.pageState.isFirstButtonSelected = true;
      this.pageState.isMiddleButtonSelected = false;
      this.pageState.isLeftButtonSelected = false;
      this.showCars = this.cars.slice(0,3);
      this.initiatePageManagers()
    }
    if(target.attributes.id.value ==="right"){
      this.pageState.isFirstButtonSelected = false;
      this.pageState.isMiddleButtonSelected = false;
      this.pageState.isLeftButtonSelected = true;
      this.showCars = this.cars.slice(6,9);
      this.initiatePageManagers()
    }
  }

}
