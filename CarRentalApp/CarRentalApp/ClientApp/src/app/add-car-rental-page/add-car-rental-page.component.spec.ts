import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCarRentalPageComponent } from './add-car-rental-page.component';

describe('AddCarRentalPageComponent', () => {
  let component: AddCarRentalPageComponent;
  let fixture: ComponentFixture<AddCarRentalPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddCarRentalPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddCarRentalPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
