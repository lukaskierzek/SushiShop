import {Component, OnDestroy, OnInit} from '@angular/core';
import {ISushi} from "../models/interface-sushi.model";
import {Subscription} from "rxjs";
import {SushiService} from "../services/sushi.service.service";
import {IsDeleted} from "../models/is-deleted.models";
import {Router} from "@angular/router";

@Component({
  selector: 'app-list-sushi',
  templateUrl: './list-sushi.component.html',
  styleUrl: './list-sushi.component.css'
})
export class ListSushiComponent implements OnInit, OnDestroy {
  public sushi: ISushi[] = [];
  isHidden = IsDeleted;
  private getSushiSubscription?: Subscription;
  private hideSushiSubscription?: Subscription;
  private showSushiSubscription?: Subscription;

  constructor(private sushiService: SushiService, private router: Router) {
  }

  ngOnDestroy(): void {
    this.getSushiSubscription?.unsubscribe();
    this.hideSushiSubscription?.unsubscribe();
    this.showSushiSubscription?.unsubscribe();
  }

  ngOnInit(): void {
    this.getSushi();
  }

  getSushi(): void {
    this.getSushiSubscription = this.sushiService.getSushi().subscribe({
      next: (data: ISushi[]) => {
        this.sushi = data;
        console.log("Sushi list:")
        console.log(this.sushi);
      },
      error: (error) => {
        console.error(error)
      }
    });
  }

  onHideClick(s: ISushi): void {
    let result: boolean = confirm('Hide the sushi?')
    if (result) {
      this.sushiService.hideSushi(s)
        .subscribe({
          next: value => {
            alert('Hidden! The page will reload!');
            window.location.reload();
          },
          error: err => {
            console.error(err);
            alert('Something wrong!');
          }
        })
    }
  }

  onShowClick(s: ISushi) {
    let result: boolean = confirm('Show the sushi?')
    if (result) {
      this.sushiService.showSushi(s)
        .subscribe({
          next: value => {
            alert('Shown! The page will reload!');
            window.location.reload();
          },
          error: err => {
            console.error(err);
            alert('Something wrong!');
          }
        })
    }
  }
}
