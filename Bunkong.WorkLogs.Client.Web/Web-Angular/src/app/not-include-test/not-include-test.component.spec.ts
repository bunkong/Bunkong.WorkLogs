import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NotIncludeTestComponent } from './not-include-test.component';

describe('NotIncludeTestComponent', () => {
  let component: NotIncludeTestComponent;
  let fixture: ComponentFixture<NotIncludeTestComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NotIncludeTestComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NotIncludeTestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
