import { Component, ViewChild } from '@angular/core';
import { PhonebookEntry } from 'src/app/classes/phonebook/phonebook';
import { APIResponseObject } from 'src/app/classes/APIResponseObject';
import { PhonebookService } from 'src/app/services/phonebook/phonebook.service';
import { MatTableDataSource } from '@angular/material/table';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatPaginator } from '@angular/material/paginator';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {

  displayedColumns: string[] = ['name', 'phoneNumber'];
  newEntry = new PhonebookEntry();
  existingRecords = new MatTableDataSource();
  hasLoaded = false;

  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;

  constructor(private phonebookService: PhonebookService, private snackBar: MatSnackBar) { }


  ngOnInit() {
    //Getting all of the records on page init
    this.getAllRecords();
    
  }

  ngOnChanges() {

  }


  //Gets all the phone book records
  getAllRecords() {
    let parent: HomeComponent = this

    this.phonebookService.getAllPhonebookRecords().then(function (result: APIResponseObject) {
      if (result.successResponse) {
        parent.existingRecords = new MatTableDataSource(result.successResponse);
        //Pagination
        parent.existingRecords.paginator = parent.paginator;
        parent.hasLoaded = true;
      } else {
        console.log(result.errorResponse)
        parent.snackBar.open(result.errorMessage, 'Dismiss', { duration: 3000 })
      }
    })
  }

  //Saves new entry, purges the working object on success
  saveNewEntry() {
    let parent: HomeComponent = this

    if (this.newEntry.name != null && this.newEntry.phoneNumber != null) {
      this.phonebookService.addNewEntry(this.newEntry).then(function (result: APIResponseObject) {
        if (result.successResponse) {
          parent.snackBar.open(result.successResponse, 'Dismiss', { duration: 3000 });
          parent.newEntry = new PhonebookEntry();
          parent.getAllRecords();
        } else {
          console.log(result.errorResponse)
          parent.snackBar.open(result.errorMessage, 'Dismiss', { duration: 3000 });
        }
      })
    }
  }

  //I opted for front-end searching so that the data only has to be loaded once and a user can filter from there
  //(could look at a Linq query if the loading time gets way too long), search applies to name and number.
  applyFilter(filterValue: string) {
    this.existingRecords.filter = filterValue.trim().toLowerCase();
  }
}
