import {Component, OnDestroy, OnInit} from '@angular/core';
import {SushiService} from "../services/sushi.service.service";
import {ActivatedRoute, ParamMap} from "@angular/router";
import {Subscription} from "rxjs";
import {ISushi} from "../models/interface-sushi.model";
import {FormBuilder} from "@angular/forms";

@Component({
  selector: 'app-edit-sushi',
  templateUrl: './edit-sushi.component.html',
  styleUrl: './edit-sushi.component.css'
})
export class EditSushiComponent implements OnInit, OnDestroy {
  sushiId: string | null | undefined;
  public sushiById: any = [];
  private getSushiByIdSubscription?: Subscription;
  private putSushiSubscription?: Subscription;

  constructor(private sushiService: SushiService, private route: ActivatedRoute, private formBuilder: FormBuilder) {
  }

  editSushiForm = this.formBuilder.group({
    id: [''],
    sushiName: [''],
    actualPrice: [''],
    oldPrice: [''],
    description: [''],
    mainCategory: [''],
    imageUrl: [''],
  })

  ngOnInit(): void {
    this.route.paramMap.subscribe((params: ParamMap) => {
      this.sushiId = params.get('id');
      this.getSushiById(this.sushiId);


    })

  }

  ngOnDestroy(): void {
    this.getSushiByIdSubscription?.unsubscribe();
    this.putSushiSubscription?.unsubscribe();
  }

  getSushiById(id: string | null): void {
    this.getSushiByIdSubscription = this.sushiService.getSushiById(id)
      .subscribe({
        next: (data: ISushi[]): void => {
          this.sushiById = data;
          console.log("Sushi by id:");
          console.log(data);
          console.log("this.sushiById:");
          console.log(this.sushiById);

          this.editSushiForm.get('id')?.setValue(this.sushiById.id)
          this.editSushiForm.get('sushiName')?.setValue(this.sushiById.name)
          this.editSushiForm.get('actualPrice')?.setValue(this.sushiById.actualPrice)
          this.editSushiForm.get('oldPrice')?.setValue(this.sushiById.oldPrice)
          this.editSushiForm.get('description')?.setValue(this.sushiById.description)
          this.editSushiForm.get('mainCategory')?.setValue(this.sushiById.mainCategory)
          this.editSushiForm.get('imageUrl')?.setValue(this.sushiById.imageUrl)
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
