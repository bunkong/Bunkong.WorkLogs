import { Component, OnInit } from '@angular/core';
import {WorkLog} from '../workLog';

import {WorkLogService} from '../work-log.service';

@Component({
  selector: 'app-work-logs',
  templateUrl: './work-logs.component.html',
  styleUrls: ['./work-logs.component.css']
})
export class WorkLogsComponent implements OnInit {
  workLogs: WorkLog[];

  constructor(private workLogService: WorkLogService) { }

  ngOnInit() {
    this.getWorkLogs();
  }

  getWorkLogs(): void {
    this.workLogService.getWorkLogs()
    .subscribe(worklogs => this.workLogs = this.workLogs);
  }

}
