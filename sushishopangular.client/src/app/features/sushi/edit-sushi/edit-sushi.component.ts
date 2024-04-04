import {Component, OnDestroy, OnInit} from '@angular/core';
import {SushiService} from "../services/sushi.service.service";
import {ActivatedRoute, ParamMap} from "@angular/router";
import {Subscription} from "rxjs";
import {ISushi} from "../models/interface-sushi.model";
import {FormArray, FormBuilder, FormControl, FormGroup} from "@angular/forms";
import {NavbarService} from "../../../core/components/services/navbar.service";

@Component({
  selector: 'app-edit-sushi',
  templateUrl: './edit-sushi.component.html',
  styleUrl: './edit-sushi.component.css'
})
export class EditSushiComponent implements OnInit, OnDestroy {
  sushiId: string | null | undefined;
  public sushiById: any = [];
  public mainCategories: any = [];
  private getSushiByIdSubscription?: Subscription;
  private putSushiSubscription?: Subscription;
  private getMaincategoriesSubscription?: Subscription;

  constructor(private sushiService: SushiService, private route: ActivatedRoute, private navbarService: NavbarService, private fb: FormBuilder) {
  }

  editSushiForm = this.fb.group({
    id: [''],
    sushiName: [''],
    actualPrice: [''],
    oldPrice: [''],
    description: [''],
    mainCategory: [''],
    imageUrl: [''],
    ingredients: this.fb.array([])

  })


  ngOnInit(): void {
    this.route.paramMap.subscribe((params: ParamMap) => {
      this.sushiId = params.get('id');
      this.getSushiById(this.sushiId);
    })
    this.getMainCategories();
  }

  ngOnDestroy(): void {
    this.getSushiByIdSubscription?.unsubscribe();
    this.putSushiSubscription?.unsubscribe();
    this.getMaincategoriesSubscription?.unsubscribe();
  }

  getMainCategories(): void {
    this.getMaincategoriesSubscription = this.navbarService.getMainCategories()
      .subscribe({
        next: (data: any[]) => {
          this.mainCategories = data;
          console.log("Main categories:");
          console.log(this.mainCategories);
        },
        error: err => {
          console.error(err);
        }
      });
  }

  get Ingredient(): FormArray {
    return this.editSushiForm.get('ingredients') as FormArray;
  }

  addIngredient() {
    this.Ingredient.push(this.patchIngredients('', 0));
  }

  patchIngredients(name: string, amount: number){
    return this.fb.group({
      name: [name],
      amount: [amount]
    })
  }

  removeIngredient(i: number) {
    this.Ingredient.removeAt(i);
  }

  getSushiById(id: string | null): void {
    const controls = <FormArray>this.editSushiForm.get('ingredients');
    this.getSushiByIdSubscription = this.sushiService.getSushiById(id)
      .subscribe({
        next: (data: ISushi[]): void => {
          this.sushiById = data;
          console.log("Sushi by id:");
          console.log(data);
          console.log("this.sushiById:");
          console.log(this.sushiById);

          this.editSushiForm.get('id')?.setValue(this.sushiById.id);
          this.editSushiForm.get('sushiName')?.setValue(this.sushiById.name);
          this.editSushiForm.get('actualPrice')?.setValue(this.sushiById.actualPrice);
          this.editSushiForm.get('oldPrice')?.setValue(this.sushiById.oldPrice);
          this.editSushiForm.get('description')?.setValue(this.sushiById.description);
          this.editSushiForm.get('mainCategory')?.setValue(this.sushiById.mainCategory);
          this.editSushiForm.get('imageUrl')?.setValue(this.sushiById.imageUrl);

          this.sushiById.ingredients.forEach((x: any): void => {
            controls.push(this.patchIngredients(x.name, x.amount))
          })
        },
        error: err => {
          console.error(err);
        }
      })
  }

  submitEditSushi() {
    let resul: boolean = confirm("Update sushi?")
    if (resul) {
      this.putSushiSubscription = this.sushiService.putSushi(this.editSushiForm.value)
        .subscribe({
          next: value => {
            alert('Updated! The page will reload!')
            window.location.reload();
          },
          error: err => {
            console.error(err)
            alert('Something wrong!');
          }
        })
    }
  }
}
