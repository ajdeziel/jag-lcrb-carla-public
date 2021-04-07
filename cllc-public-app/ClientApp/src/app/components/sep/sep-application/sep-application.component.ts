import { Component, OnInit, ViewChild } from '@angular/core';
import { AppState } from '@app/app-state/models/app-state';
import { faCheck } from '@fortawesome/free-solid-svg-icons';
import { Store } from '@ngrx/store';
import { Observable, of } from 'rxjs';
import { ApplicantComponent } from './applicant/applicant.component';
import { EligibilityComponent } from './eligibility/eligibility.component';
import { EventComponent } from './event/event.component';
import { LiquorComponent } from './liquor/liquor.component';
import { SummaryComponent } from './summary/summary.component';
import { Account } from '@models/account.model';
import { ActivatedRoute } from '@angular/router';
import { IndexDBService } from '@services/index-db.service';

@Component({
  selector: 'app-sep-application',
  templateUrl: './sep-application.component.html',
  styleUrls: ['./sep-application.component.scss']
})
export class SepApplicationComponent implements OnInit {
  faCheck = faCheck;
  securityScreeningEnabled: boolean;
  applicationId: string;
  isFree: boolean = false;
  hasLGApproval: boolean = false;

  @ViewChild("applicant")
  accountProfileComponent: ApplicantComponent;
  @ViewChild("eligibility")
  licenseeChangesComponent: EligibilityComponent;
  @ViewChild("event") applicationComponent: EventComponent;
  @ViewChild("liquor") dynamicApplicationComponent: LiquorComponent;
  stepType: "summary";
  application: any;
  steps = ["applicant", "eligibility", "event", "liquor", "summary"];
  account: Account;
  step: string;
  get selectedIndex(): number {
    let index = 0;
    if(this.step){
      index = this.steps.indexOf(this.step);
      if(index === -1){
        index = 0
      }
    }
    
    return index;
  }

  constructor(private store: Store<AppState>,
    private db: IndexDBService,
    private route: ActivatedRoute) {
    this.store.select(state => state.currentAccountState.currentAccount)
      .subscribe(account => this.account = account);
    this.route.paramMap.subscribe(pmap => {
      // if the id is 'new' set it to null ( this will dictate whether the save is a create or an update)
      this.applicationId = pmap.get('id') === 'new'? null : pmap.get('id');
      this.step = pmap.get('step');
    });
  }

  ngOnInit() {
    if (this.applicationId) {
      this.db.getSepApplication(parseInt(this.applicationId, 10))
        .then(app => {
          this.application = app;
        }, err => {
          console.error(err);
        });
    }

  }

  canactivate(): Observable<boolean> {
    let result: Observable<boolean> = of(true);
    return result;
  }

  selectionChange(event) {
  }

}