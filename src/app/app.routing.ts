import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from './_helpers';
import { environment } from '@environments/environment';
import { EmrModule } from './admin/emr.module';
import { MainWindowComponent } from './admin/MainWindow';
import { KhoiTaoComponent } from './admin/KhoiTao/KhoiTao.component';


const routes: Routes = [
  {
    path: environment.ROUTE_LOGIN,
    component: KhoiTaoComponent
  },
  {
    path: environment.ROUTE_QUAN_TRI,
    canActivate: [AuthGuard],
    component: MainWindowComponent,
    children: [{
      path: '',
      // loadChildren: './admin/admin.module#AdminModule'
      loadChildren: ()=> EmrModule
    }]
  },
  { 
    path: '**', 
    redirectTo:`/${environment.ROUTE_QUAN_TRI}`,
    pathMatch: 'full' 
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
