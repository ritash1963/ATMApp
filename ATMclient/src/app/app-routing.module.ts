import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AtmBalanceComponent } from './atm/atm-balance/atm-balance.component';
import { AtmOperationsComponent } from './atm/atm-operations/atm-operations.component';
import { AtmWithdrawComponent } from './atm/atm-withdraw/atm-withdraw.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'atm/atmbalance', component: AtmBalanceComponent},
  {path: 'atm/atmoperations', component: AtmOperationsComponent},
  {path: 'atm/atmwithdraw', component: AtmWithdrawComponent},
  {path: '**', component: HomeComponent, pathMatch: 'full'},  
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
