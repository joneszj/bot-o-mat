import { Component, ViewChild } from '@angular/core';
import { ActorService } from '../../../services/actorService.service';
import { ActorType } from '../../../models/actorType';
import { Gender } from '../../../models/Gender';
import { RobotType } from '../../../models/robotType';
import { FormGroup, FormControl, Validators, FormArray } from '@angular/forms';
import { robotOrCyborgValidator } from '../../../validators/robotOrCyborgValidator.validator';
import { minSelectedCheckboxes } from '../../../validators/minSelectedCheckboxes.validaotor';
import { PostCyborgRequest, PostCyborgResponse } from '../../../models/postCyborg';
import { BotTypeEnum } from '../../../enums/botTypes.enum';
import { PostRobotRequest, PostRobotResponse } from '../../../models/postRobot';
import { ErrandListCheckboxesComponent } from '../errands/listErrandCheckboxes.component';
import { Router } from '@angular/router';

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
  isWorking = true;
  constructor(
    private _actorService: ActorService,
    private _router: Router
  ) { }

  ngOnInit() {
    this._actorService.GetActorTypes().subscribe(actorTypes => this.actorTypes = actorTypes);
    this._actorService.GetRobotTypes().subscribe(robotTypes => this.robotTypes = robotTypes);
    this._actorService.GetCyborgGenders().subscribe(genders => this.cyborGenders = genders);

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

    this.isWorking = false;
  }

  async onSubmit() {
    if (this.isRobot()) {
      this.isWorking = true;
      const newRobot = await this.buildRobot(this.createBotFormGroup.get('botNameInput').value, this.createBotFormGroup.get("robotTypeSelect").value);
      document.getElementById('closeModal').click();
      await this._router.navigate(['bot', newRobot.id], { queryParams: { errands: this.errandList.selectedErrands() } });
    } else {
      this.isWorking = true;
      const newCyborg = await this.buildCyborg(this.createBotFormGroup.get('botNameInput').value, this.createBotFormGroup.get("cyborgGenderSelect").value);
      document.getElementById('closeModal').click();
      await this._router.navigate(['bot', newCyborg.id], { queryParams: { errands: this.errandList.selectedErrands() } });
    }
  }

  private isRobot = () => Number(this.createBotFormGroup.get('botTypeSelect').value) === this.botTypeEnum.Robot;
  private buildRobot = (name: string, type: RobotType): Promise<PostRobotResponse> => new Promise((res, rej) => this._actorService.PostRobot(new PostRobotRequest(name, type)).subscribe(newRobot => res(newRobot)))
  private buildCyborg = (name: string, gender: Gender): Promise<PostCyborgResponse> => new Promise((res, rej) => this._actorService.PostCyborg(new PostCyborgRequest(name, gender)).subscribe(newCyborg => res(newCyborg)))
}
