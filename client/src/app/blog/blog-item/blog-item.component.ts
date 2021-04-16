import {Component, Input, OnInit} from '@angular/core';
import {IPost} from '../../shared/models/post';

@Component({
  selector: 'app-blog-item',
  templateUrl: './blog-item.component.html',
  styleUrls: ['./blog-item.component.scss']
})
export class BlogItemComponent implements OnInit {
  @Input() post: IPost;
  constructor() { }

  ngOnInit(): void {
  }

}
