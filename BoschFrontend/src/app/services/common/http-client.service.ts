import { Inject,Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpClientService {
  constructor( private httpClient : HttpClient, @Inject("baseUrl") private baseUrl:string ) { }

  private url(requestParameter : Partial<RequestParameters>): string {
    return `${requestParameter.baseUrl? requestParameter.baseUrl : this.baseUrl}/${requestParameter.controller}${requestParameter.action? `/${ requestParameter.action}`:""}`;
  }

  get<T>(requestParameter : Partial<RequestParameters>, id?:string): Observable<T>{
    let url : string ="";
    if(requestParameter.fullEndPoint)
      url = requestParameter.fullEndPoint;
    else 
      url = `${this.url(requestParameter)}${id ?`?id=${id}` : ""}`;
    
    return this.httpClient.get<T>(url,{headers:requestParameter.headers})
  }

  post<T>(requestParameter : Partial<RequestParameters>, body: Partial<T>) : Observable<T> {
    let url : string = "";
    if(requestParameter.fullEndPoint)
      url = requestParameter.fullEndPoint
    else
      url = `${this.url(requestParameter)}`
      return this.httpClient.post<T>(url,body,{headers:requestParameter.headers});
  }

  put<T>(requestParameter : Partial<RequestParameters>, body: Partial<T>) : Observable<T> {
    let url : string = "";
    if(requestParameter.fullEndPoint)
      url = requestParameter.fullEndPoint
    else
      url =  `${this.url(requestParameter)}`;

    return this.httpClient.put<T>(url,body,{headers:requestParameter.headers});
  }

  delete<T>(requestParameter : Partial<RequestParameters>, id : string) : Observable<T> {
    let url : string = "";
    if(requestParameter.fullEndPoint)
      url = requestParameter.fullEndPoint
    else
      url =  `${this.url(requestParameter)}/${id}`;
    
    return this.httpClient.delete<T>(url, {headers : requestParameter.headers})
  }

  postOrder<T>(_orderCount : number, _modelNumber : string,_orderId: number, body: Partial<T>): Observable<T>{
    let newUrl= `https://localhost:7154/api/Injectors/addMultipleInjector?count=${_orderCount}&modelNumber=${_modelNumber}&orderId=${_orderId}`
    return this.httpClient.post<T>(newUrl,body);
  }

  postProcess<T>(_stationId : number,_injectorId: number,_subcomponentId: number,_stationProcesss: number,body: Partial<T>): Observable<T>{
    let newUrl = `https://localhost:7154/api/StationProcesss?stationId=${_stationId}&InjectorId=${_injectorId}&subcomponentId=${_subcomponentId}&processStatus=${_stationProcesss}`
    return this.httpClient.post<T>(newUrl,body);
  }
}

export class RequestParameters{
  controller?:string;
  action?: string;

  headers?: HttpHeaders;
  baseUrl?: string;
  fullEndPoint?: string;
}