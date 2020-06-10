import { Component, Input } from '@angular/core';
import { Errand } from '../../../models/errand';
import { ErrandService } from '../../../services/errandService.service';

@Component({
  selector: 'app-errand-checklist',
  templateUrl: './listErrandCheckboxes.component.html'
})

export class ErrandListCheckboxesComponent {
  @Input() botTypeSelected;
  errands: Errand[];

  constructor(private errandService: ErrandService) { }

  ngOnInit() {
    this.errandService.GetErrands().subscribe(errands => this.errands = errands);
  }
}
