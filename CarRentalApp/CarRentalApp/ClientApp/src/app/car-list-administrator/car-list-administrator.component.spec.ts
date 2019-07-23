import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CarListAdministratorComponent } from './car-list-administrator.component';

describe('CarListAdministratorComponent', () => {
  let component: CarListAdministratorComponent;
  let fixture: ComponentFixture<CarListAdministratorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CarListAdministratorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CarListAdministratorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
