import { Component, OnInit }  from '@angular/core';

import { User }               from './user';
import { UserService }        from './user.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {
  users: User[];

  constructor(
    private userService: UserService
  ) { }

  getUsers(): void {
    this.userService
        .getUsers()
        .then(users => this.users = users);
  }

  add(email: string, name: string): void {
    email = email.trim();
    name = name.trim();
    if (!name || !email) { return; }
    this.userService.create(email, name)
        .then(user => {
          this.users.push(user);
        });
  }

  ngOnInit() {
    this.getUsers();
  }

}
