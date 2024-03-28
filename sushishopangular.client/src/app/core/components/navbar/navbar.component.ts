import {Component, OnDestroy, OnInit} from '@angular/core';
import {Subscription} from "rxjs";
import {NavbarService} from "../services/navbar.service";


@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent implements OnInit, OnDestroy {
  public mainCategories: any[] = [];

  private getMainCategoriesSubscription?: Subscription;

  constructor(private navbarService: NavbarService) {
  }

  ngOnInit(): void {
    this.getMainCategories();
  }

  ngOnDestroy(): void {
    this.getMainCategoriesSubscription?.unsubscribe();
  }

  getMainCategories(): void {
    this.getMainCategoriesSubscription = this.navbarService.getMainCategories()
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
