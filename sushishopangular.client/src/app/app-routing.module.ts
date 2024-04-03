import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {ListSushiComponent} from "./features/sushi/list-sushi/list-sushi.component";
import {ByMainCategorySushiComponent} from "./features/sushi/by-main-category-sushi/by-main-category-sushi.component";
import {DetailsSushiComponent} from "./features/sushi/details-sushi/details-sushi.component";
import {EditSushiComponent} from "./features/sushi/edit-sushi/edit-sushi.component";

const routes: Routes = [
  {
    path: '',
    component: ListSushiComponent
  },
  {
    path: 'sushishop/sushi',
    component: ByMainCategorySushiComponent
  },
  {
    path: 'sushishop/sushi/all',
    component: ListSushiComponent
  },
  {
    path: 'sushishop/sushi/:id',
    component: DetailsSushiComponent
  },
  {
    path: 'sushishop/sushi/:id/edit',
    component: EditSushiComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
