import { Injectable } from '@angular/core';
import { environment as env } from '../../environments/environment';
import { Link } from '../models/link';

@Injectable({
  providedIn: 'root'
})
export class APIService {
  private baseURL = env.baseAPIURL;
  private apiPath = '/api';
  protected fullApiPath: string;

  constructor() {
    this.fullApiPath = `${this.baseURL}${this.apiPath}`;
  }

  readonly HealthCheckURILink: Link = {
    URL: `${this.baseURL}/healthchecks-ui`,
    Label: "Health-Check UI"
  }
  readonly SwaggerURILink: Link = {
    URL: `${this.baseURL}/swagger`,
    Label: "Swagger"
  }
  readonly WhoIsURILink: Link = {
    URL: `${this.baseURL}/who-is`,
    Label: "WhoIs"
  }
  readonly LogsURILink: Link = {
    URL: `${this.baseURL}/logs`,
    Label: "Logs"
  }
}
