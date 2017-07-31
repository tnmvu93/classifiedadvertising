import { Injectable }           from '@angular/core';
import { Headers, Http }        from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { User }                 from './user';

@Injectable()
export class UserService {

    private headers = new Headers({'Content-Type': 'application/json'});
    private usersUrl = 'http://localhost:50895/api/users';

    constructor(private http: Http) { }

    getUsers(): Promise<User[]> {
        return this.http.get(this.usersUrl)
                    .toPromise()
                    .then(response => response.json().data as User[])
                    .catch(this.handleError);
    }

    getUser(id: number): Promise<User> {
        const url = `${this.usersUrl}/${id}`;
        return this.http.get(url)
                    .toPromise()
                    .then(response => response.json().data as User)
                    .catch(this.handleError);
    }

    create(email: string, name: string): Promise<User> {
        return this.http
            .post(this.usersUrl
                , JSON.stringify({email: email, name: name})
                , { headers: this.headers })
            .toPromise()
            .then(response => response.json().data as User)
            .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        console.error('An error occurred: ', error);
        return Promise.reject(error.message || error);
    }
}