import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IdentifyRockComponent } from './identify-rock.component';

describe('IdentifyRockComponent', () => {
  let component: IdentifyRockComponent;
  let fixture: ComponentFixture<IdentifyRockComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IdentifyRockComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IdentifyRockComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
