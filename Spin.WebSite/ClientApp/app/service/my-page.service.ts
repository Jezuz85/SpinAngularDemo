import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

const baseUrl = 'https://localhost:44324';

@Injectable({
    providedIn: 'root'
})
export class MyPageService {
    constructor(private http: HttpClient) { }

    getAll(): Observable<any> {
        return this.http.get(baseUrl +'/SpinHtml');
    } 
}