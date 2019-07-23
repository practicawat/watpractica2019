import { TestBed } from '@angular/core/testing';

import { SearchedCarService } from './searched-car.service';

describe('SearchedCarService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SearchedCarService = TestBed.get(SearchedCarService);
    expect(service).toBeTruthy();
  });
});
