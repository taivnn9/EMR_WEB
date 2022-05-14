import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { EmrService } from '@app/_services/emr.service';

import { environment } from '@environments/environment';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {
    constructor(
        private router: Router,
        private emrService: EmrService
    ) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        let path = state.url;
        console.log(path);
        
        if(path.includes(environment.ROUTE_QUAN_TRI)){
            const DaKhoiTao = this.emrService.DaKhoiTao()
            // debugger
            // const currentUser = this.ehrService.currentUserValue;
            if (DaKhoiTao) {
                // check if route is restricted by role
                // if (route.data.roles && route.data.roles.indexOf(currentUser.role) === -1) {
                //     // role not authorised so redirect to home page
                //     this.router.navigate(['/']);
                //     return false;
                // }
    
                // authorised so return true
                return true;
            }
        }

        // not logged in so redirect to login page with the return url
        this.router.navigate([`/${environment.ROUTE_LOGIN}`], { queryParams: { returnUrl: state.url } });
        return false;
    }
}