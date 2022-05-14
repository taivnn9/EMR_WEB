import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { EmrService } from "@app/_services/emr.service";
import { environment } from "@environments/environment";

@Component({
    templateUrl: 'KhoiTao.html',
    styleUrls: ['KhoiTao.scss']
})
export class KhoiTaoComponent implements OnInit {

    IDBenhAn: any
    constructor(
        private router: Router,
        private activeRoute: ActivatedRoute,
        private emrService: EmrService
    ) {
        this.activeRoute.queryParams.subscribe(params => {

            if (params && params[`${environment.IDBenhAn}`]) {
                debugger
                localStorage.clear();
                this.IDBenhAn = params[`${environment.IDBenhAn}`]
            }

        });
    }
    async ngOnInit() {
        if(this.IDBenhAn != null){
            this.emrService.SetIdBenhAn(this.IDBenhAn);
            await this.emrService.SetDataBenhAn();
            this.router.navigate([`/${environment.ROUTE_QUAN_TRI}`]);
        }
    }
}