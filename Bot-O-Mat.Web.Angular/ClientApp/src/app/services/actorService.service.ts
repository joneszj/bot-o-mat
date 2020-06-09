import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActorType } from '../models/actorType';
import { RobotType } from '../models/robotType';
import { Gender } from '../models/Gender';
import { APIService } from './APIService.service';

@Injectable({
  providedIn: 'root'
})
export class ActorService extends APIService {
  constructor(private http: HttpClient) { }

  GetActorTypes = (): Observable<ActorType[]> => this.http.get<ActorType[]>(`${this.fullApiPath}/actors/types`);
  GetRobotTypes = (): Observable<RobotType[]> => this.http.get<RobotType[]>(`${this.fullApiPath}/robots/types`);
  GetCyborgGenders = (): Observable<Gender[]> => this.http.get<Gender[]>(`${this.fullApiPath}/cyborgs/genders`);
}
