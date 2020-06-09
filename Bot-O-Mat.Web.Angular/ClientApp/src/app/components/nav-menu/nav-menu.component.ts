import { Component } from '@angular/core';
import { APIService } from '../../services/APIService.service';
import { Link } from '../../models/link';
import { NavBarService } from '../../services/navBarService.service';
import { ToolsService } from '../../services/toolsService.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  appLinks: Link[];
  apiLinks: Link[];

  constructor(
    apiService: APIService,
    navBarService: NavBarService,
    toolsService: ToolsService
  ) {
    this.appLinks = toolsService.sortOnPropertyValue<Link>(this.onlyLinkPropertyTypes(navBarService), 'Order');
    this.apiLinks = toolsService.sortOnPropertyValue<Link>(this.onlyLinkPropertyTypes(apiService), 'Label');
  }

  onlyLinkPropertyTypes = (obj: NavBarService | APIService) => Object.values(obj).filter(e => Link.isLink(e));
}
