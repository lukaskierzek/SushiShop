import { TestBed } from '@angular/core/testing';

import { SushiService } from './sushi.service.service';

describe('SushiServiceService', () => {
  let service: SushiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SushiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
