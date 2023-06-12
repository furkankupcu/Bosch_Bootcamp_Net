import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddsubcomponentComponent } from './addsubcomponent.component';

describe('AddsubcomponentComponent', () => {
  let component: AddsubcomponentComponent;
  let fixture: ComponentFixture<AddsubcomponentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddsubcomponentComponent]
    });
    fixture = TestBed.createComponent(AddsubcomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
