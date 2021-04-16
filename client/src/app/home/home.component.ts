import { Component, OnInit } from '@angular/core';
import {NavigationEnd, Router} from '@angular/router';
import {IAuthor} from '../shared/models/topauthors';
import {HomeService} from './home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  countOfAllPosts: number;
  countAuthors: number;
  countAvgDesc: number;
  topAuthors: IAuthor[];
  constructor(private homeService: HomeService, private router: Router) {
    /*router.events.subscribe(e => {
      if (e instanceof NavigationEnd) {
        this.loadInfo();
      }
    });*/
  }
  ngOnInit(): void {
    this.loadInfo();
  }
  loadInfo(): void {
    this.homeService.getCountOfAllPosts().subscribe(response => {
      this.countOfAllPosts = response;
    }, error => {
      console.log(error);
    });
    this.homeService.getCountOfAllAuthors().subscribe(response => {
      this.countAuthors = response;
    }, error => {
      console.log(error);
    });
    this.homeService.getAvgDesc().subscribe(response => {
      this.countAvgDesc = response;
    }, error => {
      console.log(error);
    });
    this.homeService.getTopAuthors().subscribe(response => {
      this.topAuthors = response;
    }, error => {
      console.log(error);
    });
  }

}
