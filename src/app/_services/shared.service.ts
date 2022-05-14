import { Injectable } from '@angular/core';
import { CommandData } from '@app/_models/UTILS/CommandData';
import { Subject } from 'rxjs';

@Injectable()
export class SharedService {

  // Observable string sources
  private commandAnnouncedSource = new Subject<string>();
  private commandConfirmedSource = new Subject<string>();
  private commandPrintSource = new Subject<any>();
  private commandSaveSource = new Subject<any>();

  // Observable string streams
  commandAnnounced$ = this.commandAnnouncedSource.asObservable();
  commandConfirmed$ = this.commandConfirmedSource.asObservable();
  commandPrint$ = this.commandPrintSource.asObservable();
  commandSave$ = this.commandSaveSource.asObservable();


  // Service message commands

  announceCommand(command: string) {
    this.commandAnnouncedSource.next(command);
  }

  confirmCommand(message: string) {
    this.commandConfirmedSource.next(message);
  }

  confirmPrint(data: CommandData){
    this.commandPrintSource.next(data);
  }

  confirmPSave(data: CommandData){
    this.commandSaveSource.next(data);
  }
}
