import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { APIService } from './APIService.service';
import { Errand } from '../models/errand';

@Injectable({
  providedIn: 'root'
})
export class ErrandService extends APIService {
  constructor(private http: HttpClient) {
    super();
  }

  GetErrands = (): Observable<Errand[]> => this.http.get<Errand[]>(`${this.fullApiPath}/errand`);
}
