import { Component } from '@angular/core';
import { take } from 'rxjs/operators';
import { Account } from './_models/account';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ATM';
  
  constructor(private accountService: AccountService){}
  
  ngOnInit() {
    this.setCurrentAccount();
      
 }  
 
 setCurrentAccount() {
  const account: Account = JSON.parse(localStorage.getItem('account'));
  this.accountService.setCurrentAccount(account);
}


}
