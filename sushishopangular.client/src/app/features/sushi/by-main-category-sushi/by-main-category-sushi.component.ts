import {Component, OnDestroy, OnInit} from '@angular/core';
import {SushiService} from "../services/sushi.service.service";
import {Subscription} from "rxjs";
import {ActivatedRoute} from "@angular/router";

@Component({
  selector: 'app-by-main-category-sushi',
  templateUrl: './by-main-category-sushi.component.html',
  styleUrl: './by-main-category-sushi.component.css'
})
export class ByMainCategorySushiComponent implements OnInit, OnDestroy {
  public sushiByMainCategory: any[] = [];
  mainCategory: string | undefined;

  private getSushiByMainCategorySubscription?: Subscription;

  constructor(private sushiService: SushiService, private route: ActivatedRoute) {
  }

  ngOnDestroy(): void {
    this.getSushiByMainCategorySubscription?.unsubscribe();
  }

  ngOnInit(): void {
    this.route.queryParams
      .subscribe(params => {
        console.log(`Main categories params:`);
        console.log(params)
        this.mainCategory = params['mainCategory'];
        console.log(`Main category: ${this.mainCategory}` );
        this.getSushiByManCategory(this.mainCategory);
      })
  }

  getSushiByManCategory(mainCategory: string | undefined): void {
    if (mainCategory === undefined)
    { }
    else {
      this.getSushiByMainCategorySubscription = this.sushiService.getSushiByMainCategory(mainCategory)
        .subscribe({
          next: (data: any[]) => {
            this.sushiByMainCategory = data;
            console.log(`Data from get sushi by category '${mainCategory}:`);
            console.log(data);
          },
          error: err => {
            console.error(err)
          }
        })
    }
  }
}
