import { Component, OnInit } from '@angular/core';
import { AppService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'test-client';
  values: string[] = [];

  constructor(private readonly appService: AppService) {}

  ngOnInit(): void {
    this.appService.getValues()
                  .subscribe(values => this.values = values,
                             error => console.log(error));
  }
}
