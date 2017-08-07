import { RouterModule, Routes }     from '@angular/router';

import { AuthGuard } from './_guards/_guard';
import { HomeComponent }            from './home/home.component';
import { UsersComponent }           from './users/users.component';
import { RegisterComponent }        from './register/register.component';
import { LoginComponent }           from './login/login.component';


const routes: Routes = [
    { path: '', component: HomeComponent, canActivate: [AuthGuard] },
    { path: 'users', component: UsersComponent },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },

    { path: '**', redirectTo: '' }
];


export const AppRuoting = RouterModule.forRoot(routes);