import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';

import { User }                 from './user';

@Injectable()
export class UserService {
    
    private usersUrl = 'http://localhost:50895/api/users';
    private jwt() {
        // create authorization header with jwt token
        let currentUser = JSON.parse(localStorage.getItem('currentUser'));
        if (currentUser && currentUser.token) {
            let headers = new Headers({ 'Authorization': 'Bearer ' + currentUser.token });
            return new RequestOptions({ headers: headers });
        }
    }

    constructor(private http: Http) { }

    getAll() {
        return this.http.get(this.usersUrl, this.jwt()).map((response: Response) => response.json());
    }

    getById(id: number) {
        return this.http.get(this.usersUrl + '/' + id, this.jwt()).map((response: Response) => response.json());
    }

    create(user: User) {
        return this.http.post(this.usersUrl, this.jwt()).map((response: Response) => response.json());
    }

    update(user: User) {
        return this.http.put(this.usersUrl + '/' + user.id, user, this.jwt()).map((response: Response) => response.json());
    }
 
    delete(id: number) {
        return this.http.delete(this.usersUrl + '/' + id, this.jwt()).map((response: Response) => response.json());
    }
}