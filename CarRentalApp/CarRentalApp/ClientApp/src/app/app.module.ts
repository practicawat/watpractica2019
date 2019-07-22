import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { CarComponentComponent } from './car-component/car-component.component';
import { AddCarRentalPageComponent } from './add-car-rental-page/add-car-rental-page.component';
import { AddNewCarComponent } from './add-new-car/add-new-car.component';
import { EditCarComponent } from './edit-car/edit-car.component';

import { CarListUserComponent } from './car-list-user/car-list-user.component';
import { CarTableComponent } from './components/car-table/car-table.component';
import { ConfirmationDeleteComponent } from './confirmation-delete/confirmation-delete.component';
import { HomePageComponent } from './home-page/home-page.component';



@NgModule({
  declarations: [
    AppComponent,
    CarComponentComponent,
    AddCarRentalPageComponent,
    AddNewCarComponent,
    EditCarComponent,
    CarListUserComponent,
    CarTableComponent,
    CarComponentComponent,
    ConfirmationDeleteComponent,
    HomePageComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
