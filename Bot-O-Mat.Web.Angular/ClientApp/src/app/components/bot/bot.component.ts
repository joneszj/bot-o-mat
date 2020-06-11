import { Component } from '@angular/core';
import { ErrandService } from '../../services/errandService.service';
import { PostErrandRequest } from '../../models/postErrand';

@Component({
  selector: 'app-bot',
  templateUrl: './bot.component.html',
})

// TODO: signalR integration
export class BotComponent {
  constructor(private _errandService: ErrandService) { }

  private executeErrands = async (botId, errands) => {
    return new Promise((res, rej) => {
      this._errandService.PostErrands(errands.map(e => new PostErrandRequest(botId, e))).subscribe(errandStatus => {
        res(console.log(errandStatus));
      });
    })
  };
}
