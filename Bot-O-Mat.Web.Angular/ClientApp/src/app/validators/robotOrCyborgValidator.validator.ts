import { ValidatorFn, FormGroup, ValidationErrors, AbstractControl } from "@angular/forms";
import { BotTypeEnum } from "../enums/botTypes.enum";

const botEnum = BotTypeEnum;
const isCyborg = (botType: AbstractControl) => Number(botType.value) === botEnum.Cyborg;
const isRobot = (botType: AbstractControl) => Number(botType.value) === botEnum.Robot;

export const robotOrCyborgValidator: ValidatorFn = (formGroup: FormGroup): ValidationErrors | null => {
  const botType = formGroup.get('botTypeSelect');
  const robotType = formGroup.get('robotTypeSelect');
  const cyborgGender = formGroup.get('cyborgGenderSelect');
  if (isRobot(botType) && robotType.value !== -1) return null;
  else if (isRobot(botType) && Number(robotType.value) === -1) return { invalidRobotType: true };
  else if (isCyborg(botType) && Number(cyborgGender.value) !== -1) return null;
  else return { invalidCyborgGender: true }
};
