import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateOrderComponent } from './components/create-order/create-order.component';
import { HomepageComponent } from './components/homepage/homepage.component';
import { AddsubcomponentComponent } from './components/addsubcomponent/addsubcomponent.component';

const routes: Routes = [
  { 
    path: "createOrder",
    component : CreateOrderComponent
  },

  {
    path:"",
    component : HomepageComponent
  },
  {
    path:"addSubcomponent",
    component: AddsubcomponentComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
