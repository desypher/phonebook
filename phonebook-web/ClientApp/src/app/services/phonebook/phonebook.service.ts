import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GlobalsService } from '../../services/globals/globals.service';

@Injectable({
  providedIn: 'root'
})
export class PhonebookService {

  constructor(private http: HttpClient, private globals: GlobalsService) { }

  getAllPhonebookRecords() {
    return this.http.post(this.globals.getAPIUrl() + "api/Phonebook/getAllPhonebookRecords", null).toPromise();
  }

  addNewEntry(entry) {
    return this.http.post(this.globals.getAPIUrl() + "api/Phonebook/addNewEntry", entry).toPromise();
  }
}
