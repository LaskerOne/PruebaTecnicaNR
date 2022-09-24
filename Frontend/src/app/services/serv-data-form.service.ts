import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { modDataForm } from '../models/modDataForm';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServDataFormService {
private urlApp = "https://localhost:44390/";
private urlApi = "api/UsersBCcont/";
private updForm = new BehaviorSubject<modDataForm>({} as any)
list: modDataForm[];


  constructor(private http: HttpClient) { }

  saveUser(user: modDataForm): Observable<modDataForm> {
    return this.http.post<modDataForm >(this.urlApp+this.urlApi, user)
  }

  getUsersSer() {
    this.http.get(this.urlApp+this.urlApi).toPromise().then(
                  data => {
                    this.list = data as modDataForm[];
                  });
  }

  deleteUser(id: number): Observable<modDataForm> {
    return this.http.delete<modDataForm>(this.urlApp+this.urlApi + id);
  }

  updateRegister(id: number, modelData: modDataForm): Observable<modDataForm>{
    return this.http.put<modDataForm>(this.urlApp+this.urlApi + id, modelData);

  }

  updateUser(user) {
    this.updForm.next(user);
  }

  getRegisterToUpdate(): Observable<modDataForm> {
    return this.updForm.asObservable();
  }

  getCountMujeres() {
    return this.http.get(this.urlApp + this.urlApi);
  }
}
