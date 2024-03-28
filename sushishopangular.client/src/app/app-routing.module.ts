import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {ListSushiComponent} from "./features/sushi/list-sushi/list-sushi.component";
import {
  ByMainCategorySushiComponent
} from "./features/sushi/by-main-category-sushi/by-main-category-sushi.component";

const routes: Routes = [
  {
    path: '',
    component: ByMainCategorySushiComponent
  },
  {
    path: 'sushishop/sushi',
    component: ByMainCategorySushiComponent,
  },
  {
    path: 'sushishop/sushi/all',
    component: ListSushiComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
