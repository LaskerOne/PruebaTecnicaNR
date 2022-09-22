import { TestBed } from '@angular/core/testing';

import { ServDataFormService } from './serv-data-form.service';

describe('ServDataFormService', () => {
  let service: ServDataFormService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServDataFormService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
