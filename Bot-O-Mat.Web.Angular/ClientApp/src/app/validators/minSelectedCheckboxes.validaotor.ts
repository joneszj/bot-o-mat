import { ValidatorFn, ValidationErrors, FormArray } from "@angular/forms";

export function minSelectedCheckboxes(min = 1) {
  const minSelectedCheckboxes: ValidatorFn = (formArray: FormArray): ValidationErrors | null => {
    const totalSelected = formArray.controls
      .map(control => control.value)
      .reduce((prev, next) => next ? prev + next : prev, 0);
    return totalSelected >= min ? null : { invalidMinimum: true };
  };
  return minSelectedCheckboxes;
}
