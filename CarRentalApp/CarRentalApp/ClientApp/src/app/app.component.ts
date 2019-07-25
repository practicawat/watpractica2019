import { Component, OnInit } from '@angular/core';
import { Car } from './models/car';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'ClientApp';
  public buttons : Array<boolean>;
  public homeButtonClass = {};
  public carListButtonClass = {};
  public contactButtonClass = {};
  public e : Event;

  constructor(private router: Router){
    this.buttons = new Array<boolean>();
    this.buttons.push(true,false,false)

  }
  ngOnInit() {
   
    this.initializeButtonData();
    this.initializeButtonClasses();
    
  }


  initializeButtonData = () =>{
    if(window.location.href.includes('/home')){
      for(var i = 0; i < this.buttons.length ; i++){
        this.buttons[i] = false;
      }
      this.buttons[0] = true;
    }
    if (window.location.href.includes('/car-list-user')){
      for(var i = 0; i < this.buttons.length ; i++){
        this.buttons[i] = false;
      }
      this.buttons[1] = true;
    }

    if(window.location.href.includes('/contact')){
      for(var i = 0; i < this.buttons.length ; i++){
        this.buttons[i] = false;
      }
      this.buttons[2] = true;
    }
  }

  initializeButtonClasses = () =>{
    this.homeButtonClass = {
      "nav-item" : true,
      "active" : this.buttons[0] === true,
    }
  
    this.carListButtonClass = {
      "nav-item" : true,
      "active" : this.buttons[1] === true,
    }
    this.contactButtonClass = {
      "nav-item" : true,
      "active" : this.buttons[2] === true,
    }
  }




}
