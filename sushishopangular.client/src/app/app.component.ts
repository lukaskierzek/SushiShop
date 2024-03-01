import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface MainCategory {
  name: string,
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  public mainCategory: MainCategory[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getForecasts();
  }

  getForecasts() {
    this.http.get('https://localhost:7103/api/sushiShop/allMainCategory').subscribe(
      (data: any) => {
        this.mainCategory = data;
        console.log(this.mainCategory);
      }
    );
  }

  title = 'sushishopangular.client';
}
