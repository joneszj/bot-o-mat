import { Component } from '@angular/core';
import { ErrandService } from '../../services/errandService.service';
import { PostErrandRequest } from '../../models/postErrand';
import { forkJoin } from 'rxjs';
import { Errand } from '../../models/errand';
import { Router, ActivatedRoute } from '@angular/router';
import { ActorService } from '../../services/actorService.service';
import { ActorViewModel, CompletedErrand, FailedErrand } from '../../models/actor';

@Component({
  selector: 'app-bot',
  templateUrl: './bot.component.html',
})
export class BotComponent {
  errandTypes: Errand[];
  bot: ActorViewModel;
  queuedErrands: Errand[];

  constructor(
    private _errandService: ErrandService,
    private _actorService: ActorService,
    private _route: ActivatedRoute) { }

  ngOnInit() {
    const botId = this._route.snapshot.paramMap.get('id');
    const errandIdsToExecute = this._route.snapshot.queryParamMap.getAll('errands');
    // get errand types
    forkJoin([
      this._errandService.GetErrands(),
      this._actorService.GetActor(botId)])
      .subscribe(async responses => {
        this.errandTypes = responses[0];
        this.bot = responses[1];
        this.queuedErrands = this.errandTypes.filter(errand => errandIdsToExecute.map(e => Number(e)).includes(errand.value))
        await this.executeErrands(botId, errandIdsToExecute);
      })
  }

  private executeErrands = async (botId, errands) => {
    return new Promise((res, rej) => {
      this._errandService.PostErrands(errands.map(e => new PostErrandRequest(botId, e))).subscribe(errandStatus => {
        this.queuedErrands.shift();
        if (errandStatus.completedSuccessfully) {
          this.bot.completedErrands.push({
            errandTypeName: errandStatus.errand,
            timeToComplete: errandStatus.elapsedTime
          } as CompletedErrand);
        } else {
          this.bot.failedErrands.push({
            errandTypeName: errandStatus.errand,
            timeToComplete: errandStatus.elapsedTime
          } as FailedErrand)
        }
        res();
      });
    })
  };
}
