import { Component } from "@angular/core";
import { SignalRNotificationService } from "../../signalR/hub";

@Component({
  selector: "app-signalr",
  templateUrl: "signalR.comonent.html"
})
export class SignalRNotificationComponent {
  constructor(private _signalRNotification: SignalRNotificationService) { }
  declare $: any;

  ngOnInit() {
    this._signalRNotification.initialize();
    this._signalRNotification.Notification.subscribe(data => {
      $.notify(data.message, { position: "right bottom", className: data.severityLevel.toLowerCase() })

      //this.alerts.push(data);
      //setTimeout(() => {
      //  this.alerts.shift();
      //}, 4000);
    });
  }
}
