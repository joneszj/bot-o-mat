import { ValidatorFn, FormGroup, ValidationErrors, AbstractControl } from "@angular/forms";
import { BotTypeEnum } from "../enums/botTypes.enum";

const botEnum = BotTypeEnum;
const isCyborg = (botType: AbstractControl) => Number(botType.value) === botEnum.Cyborg;
const isRobot = (botType: AbstractControl) => Number(botType.value) === botEnum.Robot;

export const robotOrCyborgValidator: ValidatorFn = (formGroup: FormGroup): ValidationErrors | null => {
  const botType = formGroup.get('botTypeSelect');
  const robotType = formGroup.get('robotTypeSelect');
  const cyborgGender = formGroup.get('cyborgGenderSelect');
  if (isRobot(botType) && robotType.value !== null) return null;
  else if (isRobot(botType) && !robotType.value !== null) return { invalidRobotType: true };
  else if (isCyborg(botType) && cyborgGender.value !== null) return null;
  else return { invalidCyborgGender: true }
};
