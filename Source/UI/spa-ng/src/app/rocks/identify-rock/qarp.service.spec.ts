import { TestBed } from '@angular/core/testing';

import { QarpService } from './qarp.service';

describe('QarpService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: QarpService = TestBed.get(QarpService);
    expect(service).toBeTruthy();
  });
});
