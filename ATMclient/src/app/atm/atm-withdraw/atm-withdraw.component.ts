import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Route, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { take } from 'rxjs/operators';
import { Account } from 'src/app/_models/account';
import { Operation } from 'src/app/_models/operation';
import { AccountService } from 'src/app/_services/account.service';

@Component({
  selector: 'app-atm-withdraw',
  templateUrl: './atm-withdraw.component.html',
  styleUrls: ['./atm-withdraw.component.css']
})
export class AtmWithdrawComponent implements OnInit {
  operationForm:FormGroup;
  accountId:number;
  account:Account;
  operation:Operation;

  constructor(private router: Router, private fb: FormBuilder ,
                  private accountService: AccountService,private toastr: ToastrService) { }

  ngOnInit() {
    let currentAccount: Account;
    this.accountService.currentAccount$.pipe(take(1)).subscribe(account => currentAccount = account);
    this.accountId = currentAccount.id;
    this.initializeForm();
  }

  initializeForm() {
    this.operationForm = this.fb.group({
    operationType: [1],
    operationSum: [100,[Validators.required,Validators.min(100),Validators.max(1000)]],
    commissions: [0],
    creDate: ['2022/04/01 00:00:00'],
    accountId: [this.accountId],
    documentType: [2],
    documentRef: ['11112222']
    })
  }

  withdraw(){
    console.log(this.operationForm.value);
    if (this.operationForm.valid) {
      this.operation = Object.assign({}, this.operationForm.value);
      this.accountService.addOperation(this.operation).subscribe(() => {
        this.toastr.success('Withdraw is successful');
      }, error => {
        this.toastr.error('Error to withdraw this sum');
        console.log(error);
      });
    }
  }

  cancel() {
    console.log(this.operationForm.value);
    this.router.navigateByUrl('/');
  }
 

}
