import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsSushiComponent } from './details-sushi.component';

describe('DetailsSushiComponent', () => {
  let component: DetailsSushiComponent;
  let fixture: ComponentFixture<DetailsSushiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DetailsSushiComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DetailsSushiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
