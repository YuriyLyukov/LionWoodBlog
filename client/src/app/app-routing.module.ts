import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {BlogComponent} from './blog/blog.component';
import {HomeComponent} from './home/home.component';
import {PostDetailsComponent} from './blog/post-details/post-details.component';
import {AboutComponent} from './about/about.component';
import {CreateComponent} from './create/create.component';
import {ContactComponent} from './contact/contact.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'blog', component: BlogComponent},
  {path: 'blog/:id', component: PostDetailsComponent},
  {path: 'about', component: AboutComponent},
  {path: 'contact', component: ContactComponent},
  {path: 'create', component: CreateComponent},
  {path: '**', redirectTo: '', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
