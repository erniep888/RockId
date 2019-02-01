import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { NavbarComponent } from './common/navbar/navbar.component';
import { FooterComponent } from './common/footer/footer.component';
import { PageNotFoundComponent } from './common/page-not-found/page-not-found.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DashboardRowComponent } from './dashboard/dashboard-row/dashboard-row.component';
import { RocksComponent } from './rocks/rocks.component';
import { EventsComponent } from './events/events.component';
import { AdministrationComponent } from './administration/administration.component';
import { RockViewComponent } from './rocks/rock-view/rock-view.component';
import { IdentifyRockComponent } from './rocks/identify-rock/identify-rock.component';
import { BreadcrumbComponent } from './common/breadcrumb/breadcrumb.component';


const appRoutes: Routes = [
  { path: 'dashboard', component: DashboardComponent, data: { breadcrumbTitle: 'Dashboard'} },
  { path: 'rocks', component: RocksComponent, data: { breadcrumbTitle: 'Rocks'} },
  { path: 'rocks/identify-rock', component: IdentifyRockComponent, data: { breadcrumbTitle: 'Identify Rock'} },
  { path: 'events',      component: EventsComponent, data: { breadcrumbTitle: 'Events'} },
  { path: 'administration', component: AdministrationComponent, data: { breadcrumbTitle: 'Administration'} },
  { path: '', redirectTo: '/dashboard',  pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    DashboardComponent,
    DashboardRowComponent,
    RocksComponent,
    EventsComponent,
    AdministrationComponent,
    PageNotFoundComponent,
    RockViewComponent,
    IdentifyRockComponent,
    BreadcrumbComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
