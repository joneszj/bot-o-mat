import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ToolsService {
  sortOnPropertyValue = <T>(entity: T[], property: string): T[] => entity.sort((a, b) => (a[property] > b[property]) ? 1 : -1);
}
