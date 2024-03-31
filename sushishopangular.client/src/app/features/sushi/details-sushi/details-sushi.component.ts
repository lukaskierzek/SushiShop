import {Component, OnDestroy, OnInit} from '@angular/core';
import {SushiService} from "../services/sushi.service.service";
import {ActivatedRoute, ParamMap} from "@angular/router";
import {Subscription} from "rxjs";
import {ISushi} from "../models/interface-sushi.model";

@Component({
  selector: 'app-details-sushi',
  templateUrl: './details-sushi.component.html',
  styleUrl: './details-sushi.component.css'
})
export class DetailsSushiComponent implements OnInit, OnDestroy {
  sushiId: string | null | undefined;
  public sushiById: any = [];

  private getSushiByIdSubscription?: Subscription;

  constructor(private sushiService: SushiService, private route: ActivatedRoute) {
  }

  ngOnDestroy(): void {
    this.getSushiByIdSubscription?.unsubscribe();
  }

  ngOnInit(): void {
    this.route.paramMap.subscribe((params: ParamMap) => {
      this.sushiId = params.get('id');
      this.getSushiById(this.sushiId);
    })
  }

  getSushiById(id: string | null): void {
    this.getSushiByIdSubscription = this.sushiService.getSushiById(id)
      .subscribe({
        next: (data: ISushi[]) => {
          this.sushiById = data;
          console.log("Sushi by id:")
          console.log(data)
        },
        error: err => {
          console.error(err)
        }
      })
  }
}
