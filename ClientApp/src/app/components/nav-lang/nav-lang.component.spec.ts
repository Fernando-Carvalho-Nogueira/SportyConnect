import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavLangComponent } from './nav-lang.component';

describe('NavLangComponent', () => {
  let component: NavLangComponent;
  let fixture: ComponentFixture<NavLangComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NavLangComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NavLangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
