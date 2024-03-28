import {Injectable} from '@angular/core';
import {ISushi} from "../models/interface-sushi.model";
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class SushiService {

  constructor(private http: HttpClient) {}

  getSushi(): Observable<ISushi[]> {
    return this.http.get<ISushi[]>("https://localhost:7103/SushiShop/sushiAll");
  }

  getSushiByMainCategory(mainCategory: string): Observable<ISushi[]> {
      return this.http.get<ISushi[]>(`https://localhost:7103/SushiShop/sushi?mainCategory=${mainCategory}`);
  }
}
