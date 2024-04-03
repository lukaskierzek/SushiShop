import {ComponentFixture, TestBed} from '@angular/core/testing';

import {EditSushiComponent} from './edit-sushi.component';

describe('EditSushiComponent', () => {
  let component: EditSushiComponent;
  let fixture: ComponentFixture<EditSushiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditSushiComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(EditSushiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
