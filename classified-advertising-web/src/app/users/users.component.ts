import { Component, OnInit }  from '@angular/core';

import { User }               from './user';
import { UserService }        from './user.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {
  model: any = {};
  users: User[];

  constructor(
    private userService: UserService
  ) { }

  getUsers(): void {
    this.userService.getAll()
        .subscribe(data => this.users = data);
  }

  add(email: string, name: string): void {
    if (!name || !email) { return; }
    this.userService.create(this.model)
        .subscribe(user => {
          this.users.push(user);
        });
  }

  ngOnInit() {
    this.getUsers();
  }

}
