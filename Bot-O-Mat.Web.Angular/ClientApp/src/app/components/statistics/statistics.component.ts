// TODO: this entire component should be refactored and cleaned to be more dry and strongly typed

import { Component } from "@angular/core";
import { StatisticsService } from "../../services/statistics.service";
import { forkJoin } from "rxjs";
import { GraveyardRecord } from "../../models/graveyard";

// TODO: make count and color pallettes dynamic
// TODO: make counts dynamic
const count = 5;
const colors = ['#2287e6', '#6022e6', '#e622d2', '#e62222', '#f2c46d'];
const colors2 = ['#e62222', '#e67a22', '#dfe622', '#36e622', '#22e6df'];
const donutOptions = {
  cutoutPercentage: 60,
  legend: { position: 'bottom', padding: 5, labels: { pointStyle: 'circle', usePointStyle: true } }
};
declare const Chart;

@Component({
  selector: "app-stats",
  templateUrl: "statistics.component.html"
})
export class StatisticsComponent {
  currentLeaderboard;
  currentKillboard;
  graveyard;
  graveyardTable;

  constructor(private _statisticsService: StatisticsService) { }

  ngOnInit() {
    this.fetchData();
    setInterval(this.fetchData, 5000)
  }

  private buildLeaderboard = (obj) => {
    if (obj.leaderBoardRecord && obj.leaderBoardRecord.length > count) obj.leaderBoardRecord = obj.leaderBoardRecord.slice(0, count);
    if (this.currentLeaderboard !== JSON.stringify(obj.leaderBoardRecord)) {
      this.currentLeaderboard = JSON.stringify(obj.leaderBoardRecord);
      new Chart(document.getElementById("chDonut1"), {
        type: 'doughnut',
        data: {
          labels: obj.leaderBoardRecord.map(e => e.name),
          datasets: [
            {
              backgroundColor: colors.slice(0, count),
              borderWidth: 0,
              data: obj.leaderBoardRecord.map(e => e.completedErrandCount)
            }
          ]
        },
        options: donutOptions
      });
    }
  }
  private buildKillboard = (obj) => {
    if (obj.killBoardRecord && obj.killBoardRecord.length > count) obj.killBoardRecord = obj.killBoardRecord.slice(0, count);
    if (this.currentKillboard !== JSON.stringify(obj.killBoardRecord)) {
      this.currentKillboard = JSON.stringify(obj.killBoardRecord);
      new Chart(document.getElementById("chDonut2"), {
        type: 'doughnut',
        data: {
          labels: obj.killBoardRecord.map(e => e.name),
          datasets: [
            {
              backgroundColor: colors2.slice(0, count),
              borderWidth: 0,
              data: obj.killBoardRecord.map(e => e.killCount)
            }
          ]
        },
        options: donutOptions
      });
    }
  }
  private buildGraveyard = (obj) => {
    if (obj.graveyardRecords.length > count) obj.graveyardRecords = obj.graveyardRecords.slice(0, count);
    if (this.graveyard !== JSON.stringify(obj.graveyardRecords)) {
      this.graveyard = JSON.stringify(obj.graveyardRecords);
      this.graveyardTable = (obj.graveyardRecords as GraveyardRecord[]).map(e => {
        return {
          botId: e.id,
          botName: e.name,
          destroyedBy: (e.id === e.killedBy.id) ? "...itself" : e.killedBy.name,
          destroyedById: e.killedBy.id,
          destroyedDate: e.dateFallen
        }
      })
    }
  }
  private fetchData = () => {
    forkJoin([
      this._statisticsService.GetErrandsLeaderboard(),
      this._statisticsService.GetKillsLeaderboard(),
      this._statisticsService.GetGraveyard()
    ]).subscribe(responses => {
      this.buildLeaderboard(responses[0]);
      this.buildKillboard(responses[1]);
      this.buildGraveyard(responses[2]);
    })
  }
}
