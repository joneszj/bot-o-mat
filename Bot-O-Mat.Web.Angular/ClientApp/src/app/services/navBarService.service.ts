import { Injectable } from '@angular/core';
import { Link } from '../models/link';

@Injectable({
  providedIn: 'root'
})
export class NavBarService {
  readonly ErrandLeaderboardLink: Link = {
    URL: "/errand-leaderboard",
    Label: "Errand Leaderboard",
    Order: 0
  }
  readonly KillCountLeaderboardLink: Link = {
    URL: "/killcount",
    Label: "Kill Count Leaderboard",
    Order: 1
  }
  readonly GraveyardLink: Link = {
    URL: "/graveyard",
    Label: "Graveyard",
    Order: 2
  }
  readonly FactoryLink: Link = {
    URL: "/factory",
    Label: "Unit Factory",
    Order: 3
  }
}
