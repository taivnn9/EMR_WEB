import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from '@environments/environment';
import { EmrService } from '@app/_services/emr.service';

@Injectable()
export class CommonInterceptor implements HttpInterceptor {
    constructor(
        private emrService: EmrService,
    ) { }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        // add auth header with jwt if user is logged in and request is to api url

        const isLoggedIn = this.emrService.DaKhoiTao()

        if (isLoggedIn) {
            // console.log(request.headers);
            // const IdBenhAn = this.emrService.GetIdBenhAn()
            if (request.headers.get('noauth') || request.headers.get('nolog')) {
                return next.handle(request.clone());
            }else{
                request = request.clone({
                    // setHeaders: {
                    //     Authorization: `Bearer ${this.emrService.GetIdBenhAn()}`
                    // },
                    setParams : {
                        token: this.emrService.GetIdBenhAn()
                    }
                });
            } 
            // else if (request.url.includes(environment.URL_MYBOX)) {  // MYBOX
            //     request = request.clone({
            //         setHeaders: {
            //             Authorization: `Bearer ${token}`
            //         }
            //     });
            // } else if (request.url.includes(environment.URL_EHR)) { // EHR
            //     const base64 = this.ehrService.getBasicAuth()
            //     request = request.clone({
            //         setHeaders: {
            //             Authorization: `Basic ${base64}`
            //         }
            //     });
            // }
        }


        return next.handle(request);
    }
}