import { Injectable, Injector } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BB_Injector } from '../model/injector';

@Injectable({
  providedIn: 'root'
})

export class InjectorServiceService {

  private apiUrl = 'https://localhost:7154/api/Injectors';

  constructor( private http: HttpClient ) { }
  getDropdownData(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}
