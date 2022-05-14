import { Routes } from '@angular/router';
import { AuthGuard } from '@app/_helpers';
import { environment } from '@environments/environment';
import { HanhChinhBaseComponent } from './HanhChinh/HanhChinhBase.component';
import { HoiBenhBaseComponent } from './HoiBenh/HoiBenhBase.component';
import { KhamBenhBaseComponent } from './KhamBenh/KhamBenhBase.component';
import { TongKetBaseComponent } from './TongKet/TongKetBase.component';

export const EmrRoutes: Routes = [

    { 
        path: '', 
        component: HanhChinhBaseComponent,
        canActivate: [AuthGuard]
    },
    { 
        path: environment.ROUTE_HANH_CHINH, 
        component: HanhChinhBaseComponent,
        canActivate: [AuthGuard]
    },
    { 
        path: environment.ROUTE_HOI_BENH, 
        component: HoiBenhBaseComponent,
        canActivate: [AuthGuard]
    },
    { 
        path: environment.ROUTE_KHAM_BENH, 
        component: KhamBenhBaseComponent,
        canActivate: [AuthGuard]
    },
    { 
        path: environment.ROUTE_TONG_KET, 
        component: TongKetBaseComponent,
        canActivate: [AuthGuard]
    },
    { 
        path: '**', 
        component: HanhChinhBaseComponent,
        canActivate: [AuthGuard]
    },
    // {
    //     path: 'tai-khoan',
    //     component: ProfileComponent,
    //     canActivate: [AuthGuard]
    // },
    // {
    //     path: 'he-thong',
    //     component: HomeComponent,
    //     canActivate: [AuthGuard],
    //     data: { roles: [Role.Admin] }
    // },
];
