import {Component, Input, OnInit} from '@angular/core';
import {IPost} from '../../shared/models/post';
import {BlogService} from '../blog.service';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-post-details',
  templateUrl: './post-details.component.html',
  styleUrls: ['./post-details.component.scss']
})
export class PostDetailsComponent implements OnInit {
  @Input() post: IPost;
  constructor(private blogService: BlogService, private activateRoute: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.router.routeReuseStrategy.shouldReuseRoute = () => false;
    this.loadPost();
  }
  loadPost(): any{
    this.blogService.getPost(+this.activateRoute.snapshot.paramMap.get('id')).subscribe(post => {
      this.post = post;
    }, error => {
      console.log(error);
    });
  }
}
