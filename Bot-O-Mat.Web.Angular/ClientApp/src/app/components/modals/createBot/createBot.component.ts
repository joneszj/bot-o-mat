import { Component, ViewChild } from '@angular/core';
import { ActorService } from '../../../services/actorService.service';
import { ActorType } from '../../../models/actorType';
import { Gender } from '../../../models/Gender';
import { RobotType } from '../../../models/robotType';
import { FormGroup, FormControl, Validators, FormArray } from '@angular/forms';
import { robotOrCyborgValidator } from '../../../validators/robotOrCyborgValidator.validator';
import { minSelectedCheckboxes } from '../../../validators/minSelectedCheckboxes.validaotor';
import { PostCyborgRequest } from '../../../models/postCyborg';
import { BotTypeEnum } from '../../../enums/botTypes.enum';
import { PostRobotRequest } from '../../../models/postRobot';
import { ErrandService } from '../../../services/errandService.service';
import { ErrandListCheckboxesComponent } from '../errands/listErrandCheckboxes.component';
import { PostErrandRequest } from '../../../models/postErrand';

@Component({
  selector: 'app-create-bot',
  templateUrl: './createBot.component.html',
  styleUrls: ['./createBot.component.css']
})

export class CreateBotComponent {
  @ViewChild(ErrandListCheckboxesComponent, null)
  private errandList: ErrandListCheckboxesComponent

  botTypeEnum = BotTypeEnum;
  actorTypes: ActorType[];
  cyborGenders: Gender[];
  robotTypes: RobotType[];
  botTypeSelected: false;
  createBotFormGroup: FormGroup;

  constructor(
    private actorService: ActorService,
    private errandService: ErrandService
  ) { }

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
      botNameInput: new FormControl(null, [Validators.required, Validators.maxLength(20)]),
      robotTypeSelect: new FormControl(null),
      cyborgGenderSelect: new FormControl(null),
      // https://coryrylan.com/blog/creating-a-dynamic-checkbox-list-in-angular
      errandTasks: new FormArray([], minSelectedCheckboxes())
    }, { validators: robotOrCyborgValidator });
  }

  async onSubmit() {
    if (Number(this.createBotFormGroup.get('botTypeSelect').value) === this.botTypeEnum.Robot) {
      const body = new PostRobotRequest(this.createBotFormGroup.get('botNameInput').value, this.createBotFormGroup.get("robotTypeSelect").value)
      this.actorService.PostRobot(body).subscribe(async newRobot => {
        await this.executeErrands(newRobot.id, this.errandList.selectedErrands());
      });
    } else {
      const body = new PostCyborgRequest(this.createBotFormGroup.get('botNameInput').value, this.createBotFormGroup.get("cyborgGenderSelect").value)
      this.actorService.PostCyborg(body).subscribe(async newCyborg => {
        await this.executeErrands(newCyborg.id, this.errandList.selectedErrands());
      });
    }
  }

  private executeErrands = async (botId, errands) => {
    return new Promise((res, rej) => {
      this.errandService.PostErrands(errands.map(e => new PostErrandRequest(botId, e.value))).subscribe(errandStatus => {
        res(console.log(errandStatus));
      });
    })
  };
}
