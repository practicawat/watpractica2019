import { Component, OnInit } from '@angular/core';
import { CarService } from 'src/app/services/cars.service';
import { findLast } from '@angular/compiler/src/directive_resolver';
import { ThrowStmt } from '@angular/compiler';
export class PageState{
  constructor(
    public firstButton: number,
    public secondButton: number,
    public thirdButton: number,
    public fourthButton: number,
    public fifthButton: number,

    public isFirstButtonSelected :boolean,
    public isSecondButtonSelected :boolean,
    public isThirdButtonSelected :boolean,
    public isFourthButtonSelected :boolean,
    public isFifthButtonSelected :boolean,

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
  public firstClassManager = {}
  public secondClassManager = {}
  public thirdClassManager = {}
  public fourthClassManager = {}
  public fifthClassManager = {}




  constructor(private _carService: CarService) {
   this.pageState = new PageState(
     1,2,3,4,5,true,false,false,false,false)
    this.initiatePageManagers();
   }


  ngOnInit() {
    this._carService.getAllCars()
      .subscribe(data=>{ 
        this.cars = data
        this.showCars = this.cars.slice(0,3)
      })
      this.currentPage = 1;
      
  }


  initiatePageManagers = () =>{
    this.firstClassManager = {
      "btn" : true,
      "btn-primary" : this.pageState.isFirstButtonSelected,
      "btn-default" : !this.pageState.isFirstButtonSelected,
    }
    this.secondClassManager = {
      "btn" : true,
      "btn-primary" : this.pageState.isSecondButtonSelected,
      "btn-default" : !this.pageState.isSecondButtonSelected,
    }
    this.thirdClassManager = {
      "btn" : true,
      "btn-primary" : this.pageState.isThirdButtonSelected,
      "btn-default" : !this.pageState.isThirdButtonSelected,
    }
    this.fourthClassManager = {
      "btn" : true,
      "btn-primary" : this.pageState.isFourthButtonSelected,
      "btn-default" : !this.pageState.isFourthButtonSelected,
    }
    this.fifthClassManager = {
      "btn" : true,
      "btn-primary" : this.pageState.isFifthButtonSelected,
      "btn-default" : !this.pageState.isFifthButtonSelected,
    }
  }


  testData = (event) =>{
    console.log(this.cars);
    console.log(Object.keys(this.cars).length);
    console.log(this.pageState.firstButton);
  }

  left = (event) =>{
    if(this.pageState.firstButton>1)
    {
      this.pageState.firstButton--;
      this.pageState.secondButton--;
      this.pageState.thirdButton--;
      this.pageState.fourthButton--;
      this.pageState.fifthButton--;

      if(this.pageState.isFifthButtonSelected === true)
      {
        this.pageState.isFifthButtonSelected = !this.pageState.isFifthButtonSelected;
      }
      else
      {
        this.pageState.isFourthButtonSelected=this.pageState.isFifthButtonSelected;
        this.pageState.isThirdButtonSelected=this.pageState.isFourthButtonSelected;
        this.pageState.isSecondButtonSelected=this.pageState.isThirdButtonSelected;
        this.pageState.isFirstButtonSelected=this.pageState.isSecondButtonSelected;
        this.pageState.isSecondButtonSelected = false;

      }
    }
  }

  right = (event) =>{
    if(this.pageState.fifthButton<10)
    {
      this.pageState.firstButton++;
      this.pageState.secondButton++;
      this.pageState.thirdButton++;
      this.pageState.fourthButton++;
      this.pageState.fifthButton++;

      if(this.pageState.isFirstButtonSelected === true)
      {
        console.log("ftuff");
        this.pageState.isFirstButtonSelected = false ;
      }
      else
      {

      }
    }
  }


  changePage = (event) =>{
    var target = event.target || event.srcElement || event.currentTarget

    console.log(target.attributes)
    if(target.attributes.id.value ==="first"){
      this.pageState.isFirstButtonSelected = true;
      this.pageState.isSecondButtonSelected = false;
      this.pageState.isThirdButtonSelected = false;
      this.pageState.isFourthButtonSelected = false;
      this.pageState.isFifthButtonSelected = false;
      if(this.pageState.firstButton == 1){
        this.showCars = this.cars.slice(0,3);
      }
      else
        this.showCars = this.cars.slice(this.currentPage*3,this.currentPage*3+3);
      this.initiatePageManagers()
    }
    if(target.attributes.id.value ==="second"){
      this.pageState.isFirstButtonSelected = false;
      this.pageState.isSecondButtonSelected = true;
      this.pageState.isThirdButtonSelected = false;
      this.pageState.isFourthButtonSelected = false;
      this.pageState.isFifthButtonSelected = false;
      this.showCars = this.cars.slice(this.currentPage*3,this.currentPage*3+3);
      this.initiatePageManagers()
    }
    if(target.attributes.id.value ==="third"){
      this.pageState.isFirstButtonSelected = false;
      this.pageState.isSecondButtonSelected = false;
      this.pageState.isThirdButtonSelected = true;
      this.pageState.isFourthButtonSelected = false;
      this.pageState.isFifthButtonSelected = false;
      this.showCars = this.cars.slice(this.currentPage*3,this.currentPage*3+3);
      this.initiatePageManagers()
    }
    if(target.attributes.id.value ==="fourth"){
      this.pageState.isFirstButtonSelected = false;
      this.pageState.isSecondButtonSelected = false;
      this.pageState.isThirdButtonSelected = false;
      this.pageState.isFourthButtonSelected = true;
      this.pageState.isFifthButtonSelected = false;
      this.showCars = this.cars.slice(this.currentPage*3,this.currentPage*3+3);
      this.initiatePageManagers()
    }
    if(target.attributes.id.value ==="fifth"){
      this.pageState.isFirstButtonSelected = false;
      this.pageState.isSecondButtonSelected = false;
      this.pageState.isThirdButtonSelected = false;
      this.pageState.isFourthButtonSelected = false;
      this.pageState.isFifthButtonSelected = true;
      this.showCars = this.cars.slice(this.currentPage*3,this.currentPage*3+3);
      this.initiatePageManagers()
  }

}}