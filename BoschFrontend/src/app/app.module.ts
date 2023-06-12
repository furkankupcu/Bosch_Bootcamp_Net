import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { HomepageComponent } from './components/homepage/homepage.component';
import { CreateOrderComponent } from './components/create-order/create-order.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HeaderComponent } from './core/header/header.component';
import { ChartComponent } from './core/chart/chart.component';
import { HttpClientModule } from '@angular/common/http';
import { AddsubcomponentComponent } from './components/addsubcomponent/addsubcomponent.component';
import { FormsModule, NgModel } from '@angular/forms';


@NgModule({
  declarations: [
    HomepageComponent,
    CreateOrderComponent,
    HeaderComponent,
    ChartComponent,
    AddsubcomponentComponent,
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    {provide:"baseUrl",useValue:"https://localhost:7154/api",multi:true}
  ],
  bootstrap: [HeaderComponent]
})
export class AppModule { }
