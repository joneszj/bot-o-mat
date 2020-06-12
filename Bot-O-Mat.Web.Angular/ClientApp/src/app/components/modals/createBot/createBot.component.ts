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
import { Router, ActivatedRoute, NavigationEnd } from '@angular/router';
import { ActorViewModel } from '../../../models/actor';
import { forkJoin } from 'rxjs';
import { BotComponent } from '../../bot/bot.component';

@Component({
  selector: 'app-create-bot',
  templateUrl: './createBot.component.html',
  styleUrls: ['./createBot.component.css']
})

export class CreateBotComponent {
  @ViewChild(BotComponent, null)
  private _botComponent: BotComponent
  @ViewChild(ErrandListCheckboxesComponent, null)
  private _errandList: ErrandListCheckboxesComponent


  botTypeEnum = BotTypeEnum;
  actorTypes: ActorType[];
  cyborGenders: Gender[];
  robotTypes: RobotType[];
  actor: ActorViewModel = null;
  botTypeSelected = false;
  createBotFormGroup: FormGroup;
  // indicates a process is running after ngOnInit
  isWorking = false;
  // gaurd to prevent template rendering attempts before ngOnInit is complete
  // as an sync operation in ngOnInit will start template rendering before onInit has completed
  // causing log spam erros of properties no being present
  ngOnInitComplete = false;
  navigationSubscription: any;

  constructor(
    private _actorService: ActorService,
    private _router: Router,
    private _route: ActivatedRoute
  ) { }

  ngOnInit() {
    forkJoin([
      this._actorService.GetActorTypes(),
      this._actorService.GetRobotTypes(),
      this._actorService.GetCyborgGenders()
    ]).subscribe(async resp => {
      this.actorTypes = resp[0];
      this.robotTypes = resp[1];
      this.cyborGenders = resp[2];
      if (this._route.snapshot.paramMap.get('id')) {
        this.actor = await this._actorService.GetActor(this._route.snapshot.paramMap.get('id')).toPromise()
        if (this.actor.type) this.botTypeSelected = true;
        this.createFormControls(this.actor);
      } else this.createFormControls();
      this.ngOnInitComplete = true;
    })
  }

  createFormControls = (actor: ActorViewModel = null) => {
    // note: https://stackoverflow.com/a/51343849
    // formGroups are not designed to be bound to component models
    // use the AbstractControl methods to retrieve values for comsumption, though default values can be set here
    this.createBotFormGroup = new FormGroup({
      // TODO: optional property ?. breaks compilation
      botTypeSelect: new FormControl({
        value: actor === null ? -1 : actor.self.actorType,
        disabled: actor !== null
      }, Validators.required),
      botNameInput: new FormControl({
        value: actor === null ? null : actor.name,
        disabled: actor !== null
      }, [Validators.required, Validators.maxLength(20)]),
      robotTypeSelect: new FormControl({
        value: actor === null ? -1 : actor.self.actorType === BotTypeEnum.Robot ? actor.self.type : actor.self.type,
        disabled: actor !== null
      }),
      cyborgGenderSelect: new FormControl({
        value: actor === null ? -1 : actor.self.actorType === BotTypeEnum.Cyborg ? actor.self.gender : actor.self.gender,
        disabled: actor !== null
      }),
      // https://coryrylan.com/blog/creating-a-dynamic-checkbox-list-in-angular
      errandTasks: new FormArray([], minSelectedCheckboxes())
    }, { validators: robotOrCyborgValidator });
    this.ngOnInitComplete = true;
  }

  async onSubmit() {
    if (!this.actor && this.isRobot()) {
      this.isWorking = true;
      const newRobot = await this.buildRobot(this.createBotFormGroup.get('botNameInput').value, this.createBotFormGroup.get("robotTypeSelect").value);
      this.closeModal();
      await this._router.navigate(['bot', newRobot.id], { queryParams: { errands: this._errandList.selectedErrands() } });
      this.isWorking = false;
    } else if (!this.actor && !this.isRobot()) {
      this.isWorking = true;
      const newCyborg = await this.buildCyborg(this.createBotFormGroup.get('botNameInput').value, this.createBotFormGroup.get("cyborgGenderSelect").value);
      this.closeModal();
      await this._router.navigate(['bot', newCyborg.id], { queryParams: { errands: this._errandList.selectedErrands() } });
      this.isWorking = false;
    } else {
      // existing actor
      this.closeModal();
      // TODO: dirty hack, determine better means to refresh component
      await this._router.navigateByUrl('/', { skipLocationChange: true });
      await this._router.navigate(['bot', this.actor.id], { queryParams: { errands: this._errandList.selectedErrands() } });
      this.isWorking = false;
    }
  }

  private closeModal = () => document.getElementById('closeModal').click();
  private isRobot = () => Number(this.createBotFormGroup.get('botTypeSelect').value) === this.botTypeEnum.Robot;
  private buildRobot = (name: string, type: RobotType): Promise<PostRobotResponse> => new Promise((res, rej) => this._actorService.PostRobot(new PostRobotRequest(name, type)).subscribe(newRobot => res(newRobot)))
  private buildCyborg = (name: string, gender: Gender): Promise<PostCyborgResponse> => new Promise((res, rej) => this._actorService.PostCyborg(new PostCyborgRequest(name, gender)).subscribe(newCyborg => res(newCyborg)))
}
