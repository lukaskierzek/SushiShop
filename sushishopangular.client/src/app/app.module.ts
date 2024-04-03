import {HttpClientModule} from '@angular/common/http';
import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';

import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {NgOptimizedImage} from "@angular/common";
import {ListSushiComponent} from './features/sushi/list-sushi/list-sushi.component';
import {ByMainCategorySushiComponent} from './features/sushi/by-main-category-sushi/by-main-category-sushi.component';
import {NavbarComponent} from './core/components/navbar/navbar.component';
import {DetailsSushiComponent} from './features/sushi/details-sushi/details-sushi.component';
import {EditSushiComponent} from './features/sushi/edit-sushi/edit-sushi.component';
import {ReactiveFormsModule} from "@angular/forms";

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    ListSushiComponent,
    ByMainCategorySushiComponent,
    DetailsSushiComponent,
    EditSushiComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    NgOptimizedImage,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
