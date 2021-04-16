import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {IPost} from '../shared/models/post';

@Injectable({
  providedIn: 'root'
})
export class BlogService {
  baseUrl = 'https://localhost:5001/api/v1/';
  constructor(private http: HttpClient) {}
  getPosts(): Observable<IPost[]> {
    return this.http.get<IPost[]>(this.baseUrl + 'posts');
  }
  getPost(id: number): Observable<IPost>{
    return this.http.get<IPost>(this.baseUrl + 'post/' + id);
  }
}
