import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ATM';
  cardTypes: any;
 
  constructor (private http: HttpClient) {}
  
  ngOnInit() {
    this.getCardTypes();
  
 }

  getCardTypes() {
    this.http.get('https://localhost:5001/api/atm').subscribe(response => {
       this.cardTypes = response;
       }, error => {
       console.log(error);
    })
   
}

}
