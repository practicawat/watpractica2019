import { NgModule } from '@angular/core'
import {Routes, RouterModule} from '@angular/router'
import { HomePageComponent } from './home-page/home-page.component';
import { AddCarRentalPageComponent } from './add-car-rental-page/add-car-rental-page.component';
import { AddNewCarComponent } from './add-new-car/add-new-car.component';
import { CarListUserComponent } from './car-list-user/car-list-user.component';
import { ConfirmationDeleteComponent } from './confirmation-delete/confirmation-delete.component';
import { EditCarComponent } from './edit-car/edit-car.component';

const routes : Routes = [
{path: 'home', component: HomePageComponent},
{path: 'add-car-rental-page', component: AddCarRentalPageComponent},
{path: 'add-new-car', component: AddNewCarComponent},
{path: 'car-list-user', component: CarListUserComponent},
{path: 'confirmation-delete', component: ConfirmationDeleteComponent},
{path: 'edit-car', component: EditCarComponent},
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule{}
export const routingComponents = [HomePageComponent,AddCarRentalPageComponent,AddNewCarComponent,CarListUserComponent,ConfirmationDeleteComponent,EditCarComponent]