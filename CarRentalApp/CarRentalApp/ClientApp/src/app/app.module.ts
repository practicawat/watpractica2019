import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { CarComponentComponent } from './car-component/car-component.component';
import { CarListUserComponent } from './car-list-user/car-list-user.component';
import { CarTableComponent } from './components/car-table/car-table.component';
import { ConfirmationDeleteComponent } from './confirmation-delete/confirmation-delete.component';


@NgModule({
  declarations: [
    AppComponent,
    CarComponentComponent,
    CarListUserComponent,
    CarTableComponent
    CarComponentComponent,
    ConfirmationDeleteComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
