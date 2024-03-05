import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface MainCategory {
  id: number,
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
    this.getMainCategories();
  }

  getMainCategories() {
    this.http.get('https://localhost:7103/sushi-shop/all-main-category').subscribe(
      (data: any) => {
        this.mainCategory = data;
        console.log(this.mainCategory);
      }
    );
  }

  title = 'sushishopangular.client';
}
