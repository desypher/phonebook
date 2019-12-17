import { Injectable } from '@angular/core';
import { HttpHeaders } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';

@Injectable({
  providedIn: 'root'
})
export class GlobalsService {

  constructor() { }

  public getAPIUrl() {
    //Change the URL depending on if it's a release or debug

    //Debug URL
    return "https://localhost:44380/";
    //Release URL
    //return "https://localhost:5001/";
  }
}
