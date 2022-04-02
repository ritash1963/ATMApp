import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { take } from 'rxjs/operators';
import { Account } from 'src/app/_models/account';
import { AccountService } from 'src/app/_services/account.service';

@Component({
  selector: 'app-atm-balance',
  templateUrl: './atm-balance.component.html',
  styleUrls: ['./atm-balance.component.css']
})
export class AtmBalanceComponent implements OnInit {
  currentAccount:Account;

  constructor(private accountService: AccountService, private toastr: ToastrService) { }

  ngOnInit() {
    this.getBalance();
  }

  getBalance() {
    this.accountService.currentAccount$.pipe(take(1)).subscribe(account => this.currentAccount = account);
    // console.log(this.currentAccount.balance); 
   }

}