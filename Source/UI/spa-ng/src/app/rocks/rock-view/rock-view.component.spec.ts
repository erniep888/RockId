import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RockViewComponent } from './rock-view.component';

describe('RockViewComponent', () => {
  let component: RockViewComponent;
  let fixture: ComponentFixture<RockViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RockViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RockViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
