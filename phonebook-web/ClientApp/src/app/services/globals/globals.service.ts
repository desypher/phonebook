import { Injectable } from '@angular/core';
import { HttpHeaders } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';

@Injectable({
  providedIn: 'root'
})
export class GlobalsService {

  constructor() { }

  public getAPIUrl() {
    return "https://localhost:44380/";
  }
}
