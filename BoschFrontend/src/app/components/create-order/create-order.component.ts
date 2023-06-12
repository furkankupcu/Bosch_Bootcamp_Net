import { Component, Injector, OnInit } from '@angular/core';
import { HttpClientService } from 'src/app/services/common/http-client.service';
import { Subcomponentypes } from 'src/app/model/subcomponentypes';
import { Observable } from 'rxjs';
import { NgModel } from '@angular/forms';
import { NgModule } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-create-order',
  templateUrl: './create-order.component.html',
  styleUrls: ['./create-order.component.css'],
})


export class CreateOrderComponent implements OnInit{
  modelNumber = "";

  constructor(private httpClientService : HttpClientService){
    
  }

  ngOnInit(): void {
  
  this.httpClientService.get<number>({controller:"Orders", action:"newOrderId"}).subscribe(data => this.newOrderId = data);
  //this.httpClientService.get({controller:"SubcomponentTypess",action:"byStationId"},"1").subscribe()
  //this.httpClientService.delete({controller:"Injectors"}, "6").subscribe();
  }
  counter = 5;
  newOrderId= 0;
  increment() {
    this.counter += 5;
  }

  decrease() {
    this.counter -= 5;
    if (this.counter < 5) {
      this.counter = 5;
    }
  }

  createOrder(){ 
    this.httpClientService.postOrder(this.counter,this.modelNumber,1,
      { count : this.counter,
        modelNumber: this.modelNumber,
        orderId : 1}).subscribe();
  }
}
