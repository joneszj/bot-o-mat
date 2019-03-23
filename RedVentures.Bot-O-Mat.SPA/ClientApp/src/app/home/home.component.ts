import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public LeaderBoard: LeaderBoard;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<LeaderBoard>(`${environment.apiUrl}LeaderBoard`).subscribe(result => {
      this.LeaderBoard = result;
    }, error => console.error(error));
  }
}

interface LeaderBoard {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
