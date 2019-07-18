import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { CarComponentComponent } from './car-component/car-component.component';
import { AddNewCarComponent } from './add-new-car/add-new-car.component';
import { EditCarComponent } from './edit-car/edit-car.component';

import { CarListUserComponent } from './car-list-user/car-list-user.component';
import { CarTableComponent } from './components/car-table/car-table.component';


@NgModule({
  declarations: [
    AppComponent,
    CarComponentComponent,
    AddNewCarComponent,
    EditCarComponent,
    CarListUserComponent,
    CarTableComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
