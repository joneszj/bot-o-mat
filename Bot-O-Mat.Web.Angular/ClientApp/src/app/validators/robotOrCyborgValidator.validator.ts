import { ValidatorFn, FormGroup, ValidationErrors, AbstractControl } from "@angular/forms";
import { BotTypeEnum } from "../enums/botTypes.enum";

const isCyborg = (botType: AbstractControl) => botType.value === BotTypeEnum.Cyborg.toString();
const isRobot = (botType: AbstractControl) => botType.value === BotTypeEnum.Robot.toString();

export const robotOrCyborgValidator: ValidatorFn = (formGroup: FormGroup): ValidationErrors | null => {
  const botType = formGroup.get('botTypeSelect');
  const robotType = formGroup.get('robotTypeSelect');
  const cyborgGender = formGroup.get('cyborgGenderSelect');

  if (isRobot(botType) && robotType.value) return null;
  else if (isRobot(botType) && !robotType.value) return { invalidRobotType: true };
  else if (isCyborg(botType) && cyborgGender.value) return null;
  else return { invalidCyborgGender: true }
};
