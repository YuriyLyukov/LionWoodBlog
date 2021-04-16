import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {CoreModule} from './core/core.module';
import {BlogModule} from './blog/blog.module';
import {HttpClientModule} from '@angular/common/http';
import {HomeModule} from './home/home.module';
import {AboutModule} from './about/about.module';
import {CreateModule} from './create/create.module';
import {ContactModule} from './contact/contact.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    CoreModule,
    BlogModule,
    HomeModule,
    AboutModule,
    CreateModule,
    ContactModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
