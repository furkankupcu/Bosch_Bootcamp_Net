import { Component, OnInit } from '@angular/core';
import { ChartData } from 'chart.js';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { HttpClientService } from 'src/app/services/common/http-client.service';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent implements OnInit{ 

  constructor(private httpClientService : HttpClientService){}
  

  ngOnInit(): void{
  }

  chartOptions = {
    data: [{
      type: "column",
      dataPoints: [
        this.updateChartData
      ]
    }]                
  };

  updateChartData(){
      return this.httpClientService.get<number>({controller:"Injectors", action:"ModelCount"}).subscribe();
  }
  
  
  
  
}
