import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListSushiComponent } from './list-sushi.component';

describe('ListSushiComponent', () => {
  let component: ListSushiComponent;
  let fixture: ComponentFixture<ListSushiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ListSushiComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ListSushiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
