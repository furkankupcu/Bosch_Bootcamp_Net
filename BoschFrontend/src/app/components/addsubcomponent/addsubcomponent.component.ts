import { Component, OnInit } from '@angular/core';
import { HttpClientService } from 'src/app/services/common/http-client.service';

@Component({
  selector: 'app-addsubcomponent',
  templateUrl: './addsubcomponent.component.html',
  styleUrls: ['./addsubcomponent.component.css']
})
export class AddsubcomponentComponent{

  constructor(private httpClientService : HttpClientService){
    
  }

  injectorId = ""
  st1 = " "
  st2 = " "
  st3 = " "
  st4 = " "
  st5 = " "
  st6 = " "

  addSubcomponent(_stationId : number, _subValue: string){
    this.httpClientService.postProcess(_stationId,Number(this.injectorId),Number(_subValue),0,{
      stationId : _stationId,
      InjectorId : Number(this.injectorId),
      subcomponentId : Number(_subValue),
      processStatus : 0
    }).subscribe();
  }
}
