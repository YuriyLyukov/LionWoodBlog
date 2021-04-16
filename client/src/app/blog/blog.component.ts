import { Component, OnInit } from '@angular/core';
import {IPost} from '../shared/models/post';
import {HttpClient} from '@angular/common/http';
import {BlogService} from './blog.service';
import {NavigationEnd, Router} from '@angular/router';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.scss']
})
export class BlogComponent implements OnInit {
  posts: IPost[];
  constructor(private blogService: BlogService, private router: Router) {
    /*router.events.subscribe(e => {
      if (e instanceof NavigationEnd && router.url === '/blog') {
        this.loadPosts();
      }
    });*/
    this.loadPosts();
  }
  ngOnInit(): void {}
  loadPosts(): void{
    this.blogService.getPosts().subscribe(response => {
      this.posts = response;
    }, error => {
      console.log(error);
    });
  }
}
