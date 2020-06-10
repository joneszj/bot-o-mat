import { Component } from '@angular/core';
import { ActorService } from '../../../services/actorService.service';
import { ActorType } from '../../../models/actorType';
import { Gender } from '../../../models/Gender';
import { RobotType } from '../../../models/robotType';

@Component({
  selector: 'app-create-bot',
  templateUrl: './createBot.component.html',
  styleUrls: ['./createBot.component.css']
})

export class CreateBotComponent {
  actorTypes: ActorType[];
  cyborGenders: Gender[];
  robotTypes: RobotType[];
  botTypeSelected: false;

  constructor(private actorService: ActorService) { }

  ngOnInit() {
    this.actorService.GetActorTypes().subscribe(actorTypes => this.actorTypes = actorTypes);
    this.actorService.GetRobotTypes().subscribe(robotTypes => this.robotTypes = robotTypes);
    this.actorService.GetCyborgGenders().subscribe(genders => this.cyborGenders = genders);
  }
}
