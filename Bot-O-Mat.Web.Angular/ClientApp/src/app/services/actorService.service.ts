import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActorType } from '../models/actorType';
import { RobotType } from '../models/robotType';
import { Gender } from '../models/Gender';
import { APIService } from './APIService.service';
import { PostCyborgRequest, PostCyborgResponse } from '../models/postCyborg';
import { PostRobotRequest, PostRobotResponse } from '../models/postRobot';
import { CyborgViewModel } from '../models/cyborg';
import { ActorViewModel } from '../models/actor';

@Injectable({
  providedIn: 'root'
})
export class ActorService extends APIService {
  constructor(private http: HttpClient) {
    super();
  }

  GetActorTypes = (): Observable<ActorType[]> => this.http.get<ActorType[]>(`${this.fullApiPath}/actor/types`);
  GetRobotTypes = (): Observable<RobotType[]> => this.http.get<RobotType[]>(`${this.fullApiPath}/robot/types`);
  GetCyborgGenders = (): Observable<Gender[]> => this.http.get<Gender[]>(`${this.fullApiPath}/cyborg/genders`);
  GetActor = (id): Observable<ActorViewModel> => this.http.get<ActorViewModel>(`${this.fullApiPath}/actor/${id}`);
  GetCyborg = (id): Observable<CyborgViewModel> => this.http.get<CyborgViewModel>(`${this.fullApiPath}/cyborg/${id}`);
  GetRobot = (id): Observable<CyborgViewModel> => this.http.get<CyborgViewModel>(`${this.fullApiPath}/robot/${id}`);
  PostCyborg = (newCyborg: PostCyborgRequest): Observable<PostCyborgResponse> => this.http.post<PostCyborgResponse>(`${this.fullApiPath}/cyborg`, newCyborg);
  PostRobot = (newRobot: PostRobotRequest): Observable<PostRobotResponse> => this.http.post<PostRobotResponse>(`${this.fullApiPath}/robot`, newRobot);
}
