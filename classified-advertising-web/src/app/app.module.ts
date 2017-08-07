import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRuoting } from './app.routing';

import { AppComponent } from './app.component';
import { UsersComponent } from './users/users.component';
import { AlertComponent } from './alert/alert.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';

import { AuthGuard } from './_guards/_guard';
import { UserService } from './users/user.service';
import { AuthenticationService } from './_services/authentication.service';
import { AlertService } from './alert/alert.service';

@NgModule({
  declarations: [
    AppComponent,
    UsersComponent,
    AlertComponent,
    HomeComponent,
    LoginComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AppRuoting
  ],
  providers: [
    AuthGuard,
    AlertService,
    UserService,
    AuthenticationService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
