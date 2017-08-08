import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { AlertService } from './../alert/alert.service';
import { UserService } from './../users/user.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  model: any = {};
  loading = false;

  constructor(
    private router: Router,
    private userService: UserService,
    private alertService: AlertService
  ) { }

  register() {
    this.loading = false;
    this.userService.create(this.model)
        .subscribe(
          data => { 
            this.alertService.success('Registration successful', true);
            this.router.navigate(['/login']);
          },
          error => {
            var errorList = JSON.parse(error._body);
            this.alertService.error(errorList[0]);
            this.loading = false;
          }
        )
  }

}
