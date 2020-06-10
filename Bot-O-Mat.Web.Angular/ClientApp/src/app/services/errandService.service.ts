import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { APIService } from './APIService.service';
import { Errand } from '../models/errand';
import { concatMap } from 'rxjs/operators';
import { PostErrandRequest } from '../models/postErrand';

@Injectable({
  providedIn: 'root'
})
export class ErrandService extends APIService {
  constructor(private http: HttpClient) {
    super();
  }

  GetErrands = (): Observable<Errand[]> => this.http.get<Errand[]>(`${this.fullApiPath}/errand`);
  PostErrands = (errands: PostErrandRequest[]) => of(...errands)
    .pipe(concatMap(errand => this.http.post<Errand[]>(`${this.fullApiPath}/errand`, errand)));
}
