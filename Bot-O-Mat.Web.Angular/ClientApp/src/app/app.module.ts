import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

// Services
import { APIService } from './services/APIService.service';
import { NavBarService } from './services/navBarService.service';
import { ToolsService } from './services/toolsService.service';
import { ActorService } from './services/actorService.service';
import { ErrandService } from './services/errandService.service';

// Components
import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { CTAComponent } from './components/home/cta.component';
import { AboutComponent } from './components/home/about.component';
import { FooterComponent } from './components/footer/footer.component';
import { CreateBotComponent } from './components/modals/createBot/createBot.component';
import { ErrandListCheckboxesComponent } from './components/modals/errands/listErrandCheckboxes.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CTAComponent,
    AboutComponent,
    FooterComponent,
    CreateBotComponent,
    ErrandListCheckboxesComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' }
    ])
  ],
  providers: [ToolsService, APIService, NavBarService, ActorService, ErrandService],
  bootstrap: [AppComponent]
})
export class AppModule { }
