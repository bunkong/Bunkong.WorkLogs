import { Injectable } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import { WorkLog } from './workLog';
import { MessageService } from './message.service';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class WorkLogService {
  // URL to web api http://m.bunkong.com/api/worklogs http://localhost:8869/api/worklogs
  private workLogUrl = 'http://m.bunkong.com/api/worklogs';

  constructor(
    private http: HttpClient,
    private messageService: MessageService) { }

  /** GET worklogs from the server */
  getWorkLogs (): Observable<WorkLog[]> {
    return this.http.get<WorkLog[]>(this.workLogUrl, httpOptions)
      .pipe(
        tap(heroes => this.log(`fetched worklogs`)),
        catchError(this.handleError('getWorkLogs', []))
      );
  }
  /*
  this.http.get('http://my.api/data')
      .subscribe(response => console.log(response));
  */

  /**
   * Handle Http operation that failed.
   * Let the app continue.
   * @param operation - name of the operation that failed
   * @param result - optional value to return as the observable result
   */
  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.log(error);
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  /** Log a   message with the MessageService */
  private log(message: string) {
    this.messageService.add('WorkLogService: ' + message);
  }
}
