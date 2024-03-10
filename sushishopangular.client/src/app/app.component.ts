import {HttpClient} from '@angular/common/http';
import {Component, OnInit} from '@angular/core';

interface ISushi {
  id: number,
  name: string,
  actualPrice: number,
  oldPrice: number
  description: string,
  mainCategory: string,
  imageURL: string,
  ingredients: IIngredietent[],
  subCategories: any,
}

interface IIngredietent {
  id: number,
  name: string,
  amount: number
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  public sushi: ISushi[] = [];
  private getSushiURL: string = "https://localhost:7103/sushi-shop/sushi";

  constructor(private http: HttpClient) {
  }

  ngOnInit() {
    this.getSushi();
  }

  getSushi() {
    this.http.get<ISushi[]>(this.getSushiURL).subscribe({
      next: (data: ISushi[]) => {
        this.sushi = data;
        console.log(this.sushi);
      },
      error: (error) => {
        console.error(error)
      }
    });
  }

  title = 'sushishopangular.client';
}
