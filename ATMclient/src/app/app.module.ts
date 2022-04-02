import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule} from '@angular/common';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { HomeComponent } from './home/home.component';
import { NavComponent } from './nav/nav.component';
import { AtmBalanceComponent } from './atm/atm-balance/atm-balance.component';
import { AtmOperationsComponent } from './atm/atm-operations/atm-operations.component';
import { AtmWithdrawComponent } from './atm/atm-withdraw/atm-withdraw.component';

@NgModule({
  declarations: [		
    AppComponent,
      HomeComponent,
      NavComponent,
      AtmBalanceComponent,
      AtmOperationsComponent,
      AtmWithdrawComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    CommonModule,
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right'
   })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
