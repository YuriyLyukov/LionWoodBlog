import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {IPost} from '../shared/models/post';
import {IAuthor} from '../shared/models/topauthors';

@Injectable({
  providedIn: 'root'
})
export class HomeService {
  baseUrl = 'https://localhost:5001/api/v1/';
  constructor(private http: HttpClient) {}
  getCountOfAllPosts(): Observable<number> {
    return this.http.get<number>(this.baseUrl + 'countpost');
  }
  getCountOfAllAuthors(): Observable<number> {
    return this.http.get<number>(this.baseUrl + 'countauthor');
  }
  getAvgDesc(): Observable<number> {
    return this.http.get<number>(this.baseUrl + 'countavgdesc');
  }
  getTopAuthors(): Observable<IAuthor[]> {
    return this.http.get<IAuthor[]>(this.baseUrl + 'topauthors');
  }
}
