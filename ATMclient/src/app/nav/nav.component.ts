import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {}
  loggedIn: boolean;

  constructor(private router: Router,private accountService: AccountService,private toastr: ToastrService ) { }

  ngOnInit() {
    this.getCurrentAccount();
  }

  login() {
    this.accountService.login(this.model).subscribe(response => {
      this.router.navigateByUrl('/atm');
         this.loggedIn = true; 
        }, error => {
           console.log(error); 
           this.toastr.error(error.error);
     })  
    }
 
   logout() {
    this.accountService.logout(); 
    this.loggedIn = false;
    this.router.navigateByUrl('/');
    }

    getCurrentAccount() {
      this.accountService.currentAccount$.subscribe(account => {
      this.loggedIn = !!account; 
      }, error => {
        console.log(error);
        this.toastr.error(error.error);
      })
     }
    

}
