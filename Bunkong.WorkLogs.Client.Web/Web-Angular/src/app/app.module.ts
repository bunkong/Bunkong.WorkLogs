import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { WorkLogsComponent } from './work-logs/work-logs.component';
import { MessagesComponent } from './messages/messages.component';
import { NotIncludeTestComponent } from './not-include-test/not-include-test.component';

@NgModule({
  declarations: [
    AppComponent,
    WorkLogsComponent,
    MessagesComponent,
    NotIncludeTestComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
