import { Component } from '@angular/core';
import { ActorService } from '../../../services/actorService.service';
import { ActorType } from '../../../models/actorType';
import { Gender } from '../../../models/Gender';
import { RobotType } from '../../../models/robotType';
import { FormGroup, FormControl, Validators } from '@angular/forms';

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
  createBotFormGroup: FormGroup;

  constructor(private actorService: ActorService) { }

  ngOnInit() {
    this.actorService.GetActorTypes().subscribe(actorTypes => this.actorTypes = actorTypes);
    this.actorService.GetRobotTypes().subscribe(robotTypes => this.robotTypes = robotTypes);
    this.actorService.GetCyborgGenders().subscribe(genders => this.cyborGenders = genders);

    // note: https://stackoverflow.com/a/51343849
    // formGroups are not designed to be bound to component models
    // use the AbstractControl methods to retrieve values for comsumption, though default values can be set here
    this.createBotFormGroup = new FormGroup({
      // TODO: optional property ?. breaks compilation
      botTypeSelect: new FormControl(null, Validators.required),
      botNameInput: new FormControl(null, [Validators.required, Validators.maxLength(20)])
    });
    this.createBotFormGroup.valueChanges.subscribe(v => console.log(v))
  }

  test = () => {
    console.log(this.createBotFormGroup.getRawValue());
  }
}
