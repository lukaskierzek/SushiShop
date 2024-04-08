import {Injectable} from '@angular/core';
import {ISushi} from "../models/interface-sushi.model";
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class SushiService {

  constructor(private http: HttpClient) {
  }

  getIngredients(): Observable<any> {
    return this.http.get<any>("https://localhost:7103/Ingredient/ingredient");
  }

  getSushi(): Observable<ISushi[]> {
    return this.http.get<ISushi[]>("https://localhost:7103/SushiShop/sushiAll");
  }

  getSushiByMainCategory(mainCategory: string): Observable<ISushi[]> {
    return this.http.get<ISushi[]>(`https://localhost:7103/SushiShop/sushi?mainCategory=${mainCategory}`);
  }

  getSushiById(id: string | null | undefined): Observable<ISushi[]> {
    return this.http.get<ISushi[]>(`https://localhost:7103/SushiShop/sushi/${id}`);
  }

  hideSushi(s: ISushi): Observable<void> {
    return this.http.put<void>(`https://localhost:7103/SushiShop/sushi/${s.id}`,
      {
        "id": s.id,
        "name": s.name,
        "actualPrice": s.actualPrice,
        "oldPrice": s.oldPrice,
        "description": s.description,
        "mainCategory": s.mainCategory,
        "imageUrl": s.imageUrl,
        "ingredients": [],
        "subCategories": [],
        "isDeleted": 1
      }
    );
  }

  showSushi(s: ISushi): Observable<void> {
    return this.http.put<void>(`https://localhost:7103/SushiShop/sushi/${s.id}`,
      {
        "id": s.id,
        "name": s.name,
        "actualPrice": s.actualPrice,
        "oldPrice": s.oldPrice,
        "description": s.description,
        "mainCategory": s.mainCategory,
        "imageUrl": s.imageUrl,
        "ingredients": [],
        "subCategories": [],
        "isDeleted": 0
      }
    );
  }

  putSushi(s: any): Observable<void> {
    s.ingredients = s.ingredients.filter((e: { isChecked: boolean; }) => { return e.isChecked });
    return this.http.put<void>(`https://localhost:7103/SushiShop/sushi/${s.id}`,
      {
        "id": s.id,
        "name": s.sushiName,
        "actualPrice": s.actualPrice,
        "oldPrice": s.oldPrice,
        "description": s.description,
        "mainCategory": s.mainCategory,
        "imageUrl": s.imageUrl,
        "ingredients": s.ingredients,
        "subCategories": [],
        "isDeleted": 0
      });
  }
}
