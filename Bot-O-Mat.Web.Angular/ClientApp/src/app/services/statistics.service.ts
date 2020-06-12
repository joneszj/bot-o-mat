import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { APIService } from './APIService.service';
import { Errand } from '../models/errand';
import { LeaderBoardRecord } from '../models/leaderboard';
import { KillBoardRecord } from '../models/killboard';
import { GraveyardRecord } from '../models/graveyard';

@Injectable({
  providedIn: 'root'
})
export class StatisticsService extends APIService {
  statsPath = "statistics";

  constructor(private http: HttpClient) {
    super();
  }

  GetErrandsLeaderboard = (): Observable<LeaderBoardRecord[]> => this.http.get<LeaderBoardRecord[]>(`${this.fullApiPath}/${this.statsPath}/leaderBoard`);
  GetKillsLeaderboard = (): Observable<KillBoardRecord[]> => this.http.get<KillBoardRecord[]>(`${this.fullApiPath}/${this.statsPath}/killBoard`);
  GetGraveyard = (): Observable<GraveyardRecord[]> => this.http.get<GraveyardRecord[]>(`${this.fullApiPath}/${this.statsPath}/graveyard`);
}
