import { Injectable, EventEmitter } from '@angular/core';
import { environment as env } from '../../environments/environment';

import { HubConnection } from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';

@Injectable()
export class SignalRNotificationService {

  private hubConnection: HubConnection | undefined;
  public Notification: EventEmitter<string> = new EventEmitter<string>();

  constructor() { }

  public initialize(): void {
    this.stopConnection();

    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(env.signalRHubURL)
      .configureLogging(signalR.LogLevel.Information)
      .build();

    this.hubConnection.on("Notify", (data) => {
      console.log(data);
      this.Notification.emit(data);
    });

    this.hubConnection.start().then((data) => {
      console.log(`Now connected: ${data}`);
    }).catch((error) => {
      console.log('Could not connect ' + error);
      setTimeout(() => this.initialize(), 3000);
    });
  }

  stopConnection() {
    if (this.hubConnection) {
      this.hubConnection.stop();
      this.hubConnection = null;
    }
  };
}
