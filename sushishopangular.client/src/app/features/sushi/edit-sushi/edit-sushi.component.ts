import {Component, OnDestroy, OnInit} from '@angular/core';
import {SushiService} from "../services/sushi.service.service";
import {ActivatedRoute, ParamMap} from "@angular/router";
import {forkJoin, Subscription} from "rxjs";
import {ISushi} from "../models/interface-sushi.model";
import {FormArray, FormBuilder} from "@angular/forms";
import {NavbarService} from "../../../core/components/services/navbar.service";

@Component({
  selector: 'app-edit-sushi',
  templateUrl: './edit-sushi.component.html',
  styleUrl: './edit-sushi.component.css'
})
export class EditSushiComponent implements OnInit, OnDestroy {
  sushiId: string | null | undefined;

  // TODO: Add interfaces
  public sushiById: any = [];
  public mainCategories: any = [];
  public ingredients: any = [];

  private getSushiByIdSubscription?: Subscription;
  private putSushiSubscription?: Subscription;
  private getMaincategoriesSubscription?: Subscription;
  private getIngredientsSubscription?: Subscription;

  constructor(private sushiService: SushiService,
              private route: ActivatedRoute,
              private navbarService: NavbarService,
              private fb: FormBuilder) {
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
    this.route.paramMap.subscribe((params: ParamMap): void => {
      this.sushiId = params.get('id');
    })

    forkJoin([
      this.sushiService.getIngredients(),
      this.navbarService.getMainCategories()
    ]).subscribe(([ingredients, mainCategories]): void => {
      this.ingredients = ingredients;
      this.mainCategories = mainCategories
      this.getSushiById(this.sushiId);
    })
  }

  ngOnDestroy(): void {
    this.getIngredientsSubscription?.unsubscribe();
    this.getSushiByIdSubscription?.unsubscribe();
    this.putSushiSubscription?.unsubscribe();
    this.getMaincategoriesSubscription?.unsubscribe();
  }

  patchIngredients(id: number, check: boolean, name: string, amount: number) {
    return this.fb.group({
      id: [id],
      isChecked: [check],
      name: [name],
      amount: [amount]
    })
  }


  getSushiById(id: string | null | undefined): void {
    const controls = <FormArray>this.editSushiForm.get('ingredients');
    this.getSushiByIdSubscription = this.sushiService.getSushiById(id)
      .subscribe({
        next: (data: ISushi[]): void => {
          this.sushiById = data;
          console.log("Sushi by id:");
          console.log(data);
          console.log("this.sushiById:");
          console.log(this.sushiById);
          console.log("Ingredients:");
          console.log(this.ingredients);

          this.editSushiForm.get('id')?.setValue(this.sushiById.id);
          this.editSushiForm.get('sushiName')?.setValue(this.sushiById.name);
          this.editSushiForm.get('actualPrice')?.setValue(this.sushiById.actualPrice);
          this.editSushiForm.get('oldPrice')?.setValue(this.sushiById.oldPrice);
          this.editSushiForm.get('description')?.setValue(this.sushiById.description);
          this.editSushiForm.get('mainCategory')?.setValue(this.sushiById.mainCategory);
          this.editSushiForm.get('imageUrl')?.setValue(this.sushiById.imageUrl);

          if (this.sushiById.ingredients.length === 0) {
            this.ingredients.forEach((x: any): void => {
              controls.push(this.patchIngredients(x.id, false, x.name, 0));
            })
          }

          if (this.sushiById.ingredients.length !== 0) {
            this.sushiById.ingredients.forEach((x: any): void => {
              controls.push(this.patchIngredients(x.id, true, x.name, x.amount));
            })
            this.ingredients.forEach((x: any): void => {
              if (!this.sushiById.ingredients.find((e: { id: number; }): boolean => e.id === x.id)) {
                controls.push(this.patchIngredients(x.id, false, x.name, 0));
              }
            })
          }
        },
        error: err => {
          console.error(err);
        }
      })
  }

  submitEditSushi(): void {
    let resul: boolean = confirm("Update sushi?")
    if (resul) {
      this.putSushiSubscription = this.sushiService.putSushi(this.editSushiForm.value)
        .subscribe({
          next: (): void => {
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

  // get Ingredient(): FormArray {
  //   return this.editSushiForm.get('ingredients') as FormArray;
  // }
  //
  // addIngredient(): void {
  //   this.Ingredient.push(this.patchIngredients(0, false, '', 0));
  // }
  //
  // removeIngredient(i: number): void {
  //   this.Ingredient.removeAt(i);
  // }
}
