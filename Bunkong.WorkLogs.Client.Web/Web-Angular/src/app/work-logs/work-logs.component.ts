import { Component, OnInit } from '@angular/core';
import {WorkLog} from '../workLog';

@Component({
  selector: 'app-work-logs',
  templateUrl: './work-logs.component.html',
  styleUrls: ['./work-logs.component.css']
})
export class WorkLogsComponent implements OnInit {
  workLogs: WorkLog[];

  constructor() { }

  ngOnInit() {
  }

}
