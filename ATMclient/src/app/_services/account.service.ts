import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { map } from 'rxjs/operators';
import { Account } from '../_models/account';
import { ReplaySubject } from 'rxjs';
import { Operation } from '../_models/operation';


@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = environment.apiUrl;
  private currentAccountSource = new ReplaySubject<Account>(1);
  currentAccount$ = this.currentAccountSource.asObservable();




constructor(private http: HttpClient) { }

login(model:any) {
  return this.http.post(this.baseUrl + 'account/login', model).pipe(
    map((response:Account) => {
    const account = response;
    if (account) {
      localStorage.setItem('account', JSON.stringify(account));
      this.currentAccountSource.next(account);

     } 
   })
  )
 }

 setCurrentAccount(account: Account) {
  this.currentAccountSource.next(account);
} 


 logout() {
  localStorage.removeItem('account');
  this.currentAccountSource.next(null);
 }

  getOperations(account: Account) {
     return this.http.post<Operation[]>(this.baseUrl + 'account/operations', account);
}


  addOperation(operation: Operation) {
    return this.http.post(this.baseUrl + 'account/add', operation);
}


}
