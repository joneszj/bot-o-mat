import { Component, Input } from '@angular/core';
import { Errand } from '../../../models/errand';
import { ErrandService } from '../../../services/errandService.service';
import { FormGroup, FormArray, FormControl } from '@angular/forms';

@Component({
  selector: 'app-errand-checklist',
  templateUrl: './listErrandCheckboxes.component.html'
})

export class ErrandListCheckboxesComponent {
  @Input() botTypeSelected;
  @Input() botName;
  @Input() formGroup: FormGroup;
  errands: Errand[];

  constructor(private errandService: ErrandService) { }

  ngOnInit() {
    this.errandService.GetErrands().subscribe(errands => {
      this.errands = errands;
      // TODO: I dont like how this inputs the parent formGroup as a dependancy. it makes it too coupled
      // perhaps set as output, and register in parent so that this coupling is loose
      this.errands.forEach((e, i) => (this.formGroup.controls.errandTasks as FormArray).push(new FormControl(false)));
    });
  }

  selectedErrands() {
    return this.formGroup.value.errandTasks
      .map((v, i) => (v ? this.errands[i].value : null))
      .filter(v => v !== null);
  }
}
