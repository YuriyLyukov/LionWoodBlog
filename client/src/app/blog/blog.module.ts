import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BlogComponent } from './blog.component';
import {RouterModule} from '@angular/router';
import { BlogItemComponent } from './blog-item/blog-item.component';
import {PostDetailsComponent} from './post-details/post-details.component';




@NgModule({
  declarations: [BlogComponent, BlogItemComponent, PostDetailsComponent],
  imports: [
    CommonModule,
    RouterModule
  ],
  exports: [BlogComponent]
})
export class BlogModule { }
