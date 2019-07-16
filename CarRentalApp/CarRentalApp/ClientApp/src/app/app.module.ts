import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { CarComponentComponent } from './car-component/car-component.component';
import { AddCarRentalPageComponent } from './add-car-rental-page/add-car-rental-page.component';

@NgModule({
  declarations: [
    AppComponent,
    CarComponentComponent,
    AddCarRentalPageComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
