import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ByMainCategorySushiComponent } from './by-main-category-sushi.component';

describe('ByMainCategorySushiComponent', () => {
  let component: ByMainCategorySushiComponent;
  let fixture: ComponentFixture<ByMainCategorySushiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ByMainCategorySushiComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ByMainCategorySushiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
