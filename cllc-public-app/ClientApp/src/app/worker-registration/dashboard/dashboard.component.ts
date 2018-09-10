import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatTableDataSource } from '@angular/material';
import { UserDataService } from '../../services/user-data.service';
import { User } from '../../models/user.model';
import { Worker } from '../../models/worker.model';
import { WorkerDataService } from '../../services/worker-data.service.';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class WorkerDashboardComponent implements OnInit {
  currentUser: User;
  displayedColumns = ['lastUpdated', 'worker', 'status'];
  dataSource: Worker[] = [];
  isNewUser: boolean;
  dataLoaded = false;
  // @ViewChild(MatPaginator) paginator: MatPaginator;
  constructor(
    private userDataService: UserDataService,
    private workerDataService: WorkerDataService
  ) {
  }

  ngOnInit() {
    this.reloadUser();
  }

  reloadUser() {
    this.userDataService.getCurrentUser()
      .subscribe((data: User) => {
        this.currentUser = data;
        this.isNewUser = this.currentUser.isNewUser;
        this.dataLoaded = true;
        if (this.currentUser && this.currentUser.contactid) {
          this.workerDataService.getWorkerByContactId(this.currentUser.contactid).subscribe(res => {
            this.dataSource = res;
          });
        }
      });
  }

}
