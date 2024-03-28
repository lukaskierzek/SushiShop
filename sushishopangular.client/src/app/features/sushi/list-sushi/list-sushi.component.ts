import {Component, OnDestroy, OnInit} from '@angular/core';
import {ISushi} from "../models/interface-sushi.model";
import {Subscription} from "rxjs";
import {SushiService} from "../services/sushi.service.service";
import {ActivatedRoute} from "@angular/router";

@Component({
  selector: 'app-list-sushi',
  templateUrl: './list-sushi.component.html',
  styleUrl: './list-sushi.component.css'
})
export class ListSushiComponent implements OnInit, OnDestroy {
  public sushi: ISushi[] = [];




  private getSushiSubscription?: Subscription;

  constructor(private sushiService: SushiService) {
  }

  ngOnDestroy(): void {
    this.getSushiSubscription?.unsubscribe();
  }

  ngOnInit(): void {
    this.getSushi();
  }

  getSushi(): void {
    this.getSushiSubscription = this.sushiService.getSushi().subscribe({
      next: (data: ISushi[]) => {
        this.sushi = data;
        console.log(this.sushi);
      },
      error: (error) => {
        console.error(error)
      }
    });
  }
}
