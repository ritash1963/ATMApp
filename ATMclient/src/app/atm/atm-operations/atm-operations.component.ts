import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { take } from 'rxjs/operators';
import { Account } from 'src/app/_models/account';
import { Operation } from 'src/app/_models/operation';
import { AccountService } from 'src/app/_services/account.service';

@Component({
  selector: 'app-atm-operations',
  templateUrl: './atm-operations.component.html',
  styleUrls: ['./atm-operations.component.css']
})
export class AtmOperationsComponent implements OnInit {
  operations: Operation[];
 
  constructor(private accountService: AccountService, private toastr: ToastrService) { }

  ngOnInit() {
    this.getOperations();
  }

  getOperations() {
     let currentAccount: Account;
     this.accountService.currentAccount$.pipe(take(1)).subscribe(account => currentAccount = account);
         
     this.accountService.getOperations(currentAccount).subscribe(res => {
       console.log(res);
      this.operations = res;
      }, error => {
       console.log(error);
      })
  }
}
