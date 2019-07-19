import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DynamicsDataService } from '../../../services/dynamics-data.service';
import { Store } from '@ngrx/store';
import { AppState } from '../../../app-state/models/app-state';
import { LegalEntity } from '@models/legal-entity.model';
import { Account } from '@models/account.model';
import { MatTableDataSource, MatDialog, MatSnackBar } from '@angular/material';
import { Subscription } from 'rxjs';
import { LegalEntityDataService } from '@services/legal-entity-data.service';
import { DirectorAndOfficerPersonDialogComponent } from '../directors-and-officers/directors-and-officers.component';

@Component({
  selector: 'app-key-personnel',
  templateUrl: './key-personnel.component.html',
  styleUrls: ['./key-personnel.component.scss']
})
export class KeyPersonnelComponent implements OnInit {
  @Input() accountId: string;
  @Input() parentLegalEntityId: string;
  @Input() businessType: string;

  adoxioLegalEntityList: LegalEntity[] = [];
  dataSource = new MatTableDataSource<LegalEntity>();
  displayedColumns = ['firstName', 'lastName', 'email', 'position', 'dateofappointment', 'edit', 'delete'];
  busy: Promise<any>;
  busyObsv: Subscription;
  subscriptions: Subscription[] = [];

  constructor(private legalEntityDataservice: LegalEntityDataService,
    public dialog: MatDialog,
    private store: Store<AppState>,
    private dynamicsDataService: DynamicsDataService,
    private route: ActivatedRoute,
    public snackBar: MatSnackBar) { }

  ngOnInit() {
    this.getDirectorsAndOfficers();
  }

  getDirectorsAndOfficers() {
    this.busyObsv = this.legalEntityDataservice.getLegalEntitiesbyPosition(this.parentLegalEntityId, 'key-personnel')
      .subscribe((data) => {
        data.forEach(d => {
          const positionList: string[] = [];
          if (d.isDirector) {
            positionList.push('Director');
          }
          if (d.isOfficer) {
            positionList.push('Officer');
          }
          if (d.isOwner) {
            positionList.push('Owner');
          }
          if (d.isSeniorManagement) {
            positionList.push('Senior Manager');
          }
          d.position = positionList.join(', ');
        });
        this.dataSource.data = data;
      });
  }

  formDataToModelData(formData: any): LegalEntity {
    const adoxioLegalEntity: LegalEntity = new LegalEntity();
    adoxioLegalEntity.isShareholder = false;
    adoxioLegalEntity.parentLegalEntityId = this.parentLegalEntityId;
    adoxioLegalEntity.id = formData.id;
    adoxioLegalEntity.isKeyPersonnel = true;
    adoxioLegalEntity.isindividual = true;
    adoxioLegalEntity.firstname = formData.firstname;
    adoxioLegalEntity.lastname = formData.lastname;
    adoxioLegalEntity.name = formData.firstname + ' ' + formData.lastname;
    adoxioLegalEntity.email = formData.email;
    //adoxioLegalEntity.dateofappointment = formData.dateofappointment; // adoxio_dateofappointment
    adoxioLegalEntity.legalentitytype = this.businessType;

    if (this.accountId) {
      adoxioLegalEntity.account = <Account>{};
      adoxioLegalEntity.account.id = this.accountId;
    }
    return adoxioLegalEntity;
  }

  // Open Person shareholder dialog
  openPersonDialog(person: LegalEntity) {
    // set dialogConfig settings
    const dialogConfig = {
      disableClose: true,
      autoFocus: true,
      width: '500px',
      data: {
        person: person,
        businessType: this.businessType
      }
    };

    // open dialog, get reference and process returned data from dialog
    const dialogRef = this.dialog.open(DirectorAndOfficerPersonDialogComponent, dialogConfig);
    dialogRef.afterClosed().subscribe(
      formData => {
        if (formData) {
          const adoxioLegalEntity = this.formDataToModelData(formData);
          let save = this.legalEntityDataservice.createChildLegalEntity(adoxioLegalEntity);
          if (formData.id) {
            save = this.legalEntityDataservice.updateLegalEntity(adoxioLegalEntity, formData.id);
          }
          this.busyObsv = save.subscribe(
            res => {
              this.snackBar.open('Key Personnel have been saved', 'Success',
                { duration: 2500, panelClass: ['green-snackbar'] });
              this.getDirectorsAndOfficers();
            },
            err => {
              this.snackBar.open('Error saving Key Personnel', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
              this.handleError(err);
            });
        }
      }
    );

  }

  deleteIndividual(person: LegalEntity) {
    if (confirm('Delete person?')) {
      this.legalEntityDataservice.deleteLegalEntity(person.id).subscribe(data => {
        this.getDirectorsAndOfficers();
      });
    }
  }

  private handleError(error: Response | any) {
    let errMsg: string;
    if (error instanceof Response) {
      const body = error || '';
      const err = body || JSON.stringify(body);
      errMsg = `${error.status} - ${error.statusText || ''} ${err}`;
    } else {
      errMsg = error.message ? error.message : error.toString();
    }
    console.error(errMsg);
  }

}
