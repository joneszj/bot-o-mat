import { Component } from "@angular/core";
import { SignalRNotificationService } from "../../signalR/hub";

declare const $;

@Component({
  selector: "app-signalr",
  templateUrl: "signalR.comonent.html"
})
export class SignalRNotificationComponent {
  constructor(private _signalRNotification: SignalRNotificationService) { }

  ngOnInit() {
    this._signalRNotification.initialize();
    this._signalRNotification.Notification.subscribe(data => {
      $.notify(data.message, { position: "right bottom", className: data.severityLevel.toLowerCase() })
    });
  }
}
