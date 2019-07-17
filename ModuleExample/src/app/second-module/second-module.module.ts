import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Com2Component } from './com2/com2.component';
import { Com1Component } from './com1/com1.component';



@NgModule({
  declarations: [Com2Component, Com1Component],
  imports: [CommonModule],
  exports: [Com1Component,Com2Component],
})
export class SecondModuleModule { }
