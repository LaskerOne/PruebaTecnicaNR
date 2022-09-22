import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { modDataForm } from '../models/modDataForm';

@Injectable({
  providedIn: 'root'
})
export class ServDataFormService {
urlApp = "https://localhost:44390/";
urlApi = "api/UsersBCcont/";
  constructor(private http: HttpClient) { }

  saveUser(user: modDataForm): Observable<modDataForm> {
    return this.http.post<modDataForm >(this.urlApp+this.urlApi, user)
  }
}
