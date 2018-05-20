import { Component, OnInit } from '@angular/core';
import { MessageService } from '../message.service';

@Component({
  selector: 'app-messages',
  templateUrl: './messages.component.html',
  styleUrls: ['./messages.component.css']
})
export class MessagesComponent implements OnInit {

  constructor(public messageService: MessageService) { }

  ngOnInit() {
  }

}

// import { Component, OnInit } from '@angular/core';

// @Component({
//   selector: 'app-not-include-test',
//   templateUrl: './not-include-test.component.html',
//   styleUrls: ['./not-include-test.component.css']
// })
// export class MessagesComponent implements OnInit {

//   constructor() { }

//   ngOnInit() {
//   }

// }

