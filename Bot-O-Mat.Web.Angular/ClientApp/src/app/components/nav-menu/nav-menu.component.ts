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
    this.appLinks = toolsService.sortOnPropertyValue<Link>(Object.values(navBarService), 'Order').filter(e => Link.isLink(e));
    this.apiLinks = toolsService.sortOnPropertyValue<Link>(Object.values(apiService), 'Label').filter(e => Link.isLink(e));
  }
}
