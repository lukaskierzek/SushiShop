import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class NavbarService {

  constructor(private http: HttpClient) { }

  getMainCategories(): Observable<any> {
    return this.http.get<any>("https://localhost:7103/MainCategory/main-category");
  }
}
