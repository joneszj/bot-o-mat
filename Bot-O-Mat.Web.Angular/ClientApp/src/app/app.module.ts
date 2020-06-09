import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

// Services
import { APIService } from './services/APIService.service';
import { NavBarService } from './services/navBarService.service';
import { ToolsService } from './services/toolsService.service';

// Components
import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { CTAComponent } from './components/home/cta.component';
import { AboutComponent } from './components/home/about.component';
import { FooterComponent } from './components/footer/footer.component';
import { CreateBotComponent } from './components/modals/createBot/createBot.component';
import { ActorService } from './services/actorService.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CTAComponent,
    AboutComponent,
    FooterComponent,
    CreateBotComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' }
    ])
  ],
  providers: [ToolsService, APIService, NavBarService, ActorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
