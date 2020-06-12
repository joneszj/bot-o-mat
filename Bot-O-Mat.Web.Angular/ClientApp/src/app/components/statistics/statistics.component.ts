// TODO: this entire component should be refactored and cleaned to be more dry

import { Component } from "@angular/core";
import { StatisticsService } from "../../services/statistics.service";
import { forkJoin } from "rxjs";

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

  constructor(private _statisticsService: StatisticsService) { }

  ngOnInit() {
    this.fetchData();
    setInterval(this.fetchData, 5000)
  }

  private buildLeaderboard = (obj) => {
    obj.leaderBoardRecord = obj.leaderBoardRecord.slice(0, count);

    // donut 1
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
  private buildKillboard = (obj) => {
    obj.killBoardRecord = obj.killBoardRecord.slice(0, count);

    // donut 1
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
  private buildGraveyard = (obj) => {

  }
  private fetchData = () => {
    forkJoin([
      this._statisticsService.GetErrandsLeaderboard(),
      this._statisticsService.GetKillsLeaderboard(),
      this._statisticsService.GetGraveyard()
    ]).subscribe(responses => {
      if (this.currentLeaderboard !== JSON.stringify(responses[0])) {
        this.currentLeaderboard = JSON.stringify(responses[0]);
        this.buildLeaderboard(responses[0]);
      }
      if (this.currentKillboard !== JSON.stringify(responses[1])) {
        this.currentKillboard = JSON.stringify(responses[1]);
        this.buildKillboard(responses[1]);
      }
      if (this.graveyard !== JSON.stringify(responses[2])) {
        this.graveyard = JSON.stringify(responses[2]);
        this.buildGraveyard(responses[2]);
      }
    })
  }
}
