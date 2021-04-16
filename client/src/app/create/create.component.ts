import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';
import {Router} from '@angular/router';
import {HttpClient} from '@angular/common/http';
import {ICreatePostRequest} from '../shared/models/createPostRequest';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {
  baseUrl = 'https://localhost:5001/api/v1/';
  postForm: FormGroup;
  constructor(private fb: FormBuilder, private router: Router, private http: HttpClient) { }

  ngOnInit(): void {
    this.createRecipeForm();
  }
  createRecipeForm(): any {
    this.postForm = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(100)]],
      description: ['', [Validators.required, Validators.minLength(10) , Validators.maxLength(1000)]],
      authorName: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(30)]],
      tags: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(100)]]
    });
  }
  get f(): any { return this.postForm.controls; }
  create(values: any): any{
    return this.http.post(this.baseUrl + 'post', values);
  }
  onSubmit(event): any {
    event.preventDefault();
    const newPost: ICreatePostRequest = {
      name: this.postForm.get('name').value,
      description: this.postForm.get('description').value,
      authorName: this.postForm.get('authorName').value,
      tags: this.postForm.get('tags').value
    };
    this.create(newPost).subscribe(() => {
      this.router.navigate(['/blog']);
    });
  }
}
