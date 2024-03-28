import {Component, OnDestroy, OnInit} from '@angular/core';
import {Subscription} from "rxjs";
import { SushiService } from '../../../features/sushi/services/sushi.service.service';


@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent implements OnInit, OnDestroy {
  public mainCategories: any[] = [];
  private getMainCategoriesSubscription?: Subscription;

  constructor(private sushiService: SushiService) {
  }

  ngOnInit(): void {
    this.getMainCategories();
  }

  ngOnDestroy(): void {
    this.getMainCategoriesSubscription?.unsubscribe();
  }

  getMainCategories(): void {
    this.getMainCategoriesSubscription = this.sushiService.getMainCategories()
      .subscribe({
        next: (data: any) => {
          this.mainCategories = data;
          console.log("Main categories:")
          console.log(data)
        },
        error: err => {
          console.error(err)
        }
      })
  }
}
