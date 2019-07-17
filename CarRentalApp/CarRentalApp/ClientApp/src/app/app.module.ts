import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { CarComponentComponent } from './car-component/car-component.component';
import { ConfirmationDeleteComponent } from './confirmation-delete/confirmation-delete.component';


@NgModule({
  declarations: [
    AppComponent,
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
