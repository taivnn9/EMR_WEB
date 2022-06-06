import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { EmrService } from "@app/_services/emr.service";
import { environment } from "@environments/environment";
import { ToastrService } from "ngx-toastr";

@Component({
    templateUrl: 'KhoiTao.html',
    styleUrls: ['KhoiTao.scss']
})
export class KhoiTaoComponent implements OnInit {

    IDBenhAn: any
    constructor(
        private router: Router,
        private activeRoute: ActivatedRoute,
        private emrService: EmrService,
        private toastr: ToastrService,
    ) {
        this.activeRoute.queryParams.subscribe(params => {

            if (params && params[`${environment.IDBenhAn}`]) {
                localStorage.clear();
                this.IDBenhAn = params[`${environment.IDBenhAn}`]
                this.emrService.SetIdBenhAn(this.IDBenhAn);
                this.router.navigate([`/${environment.ROUTE_QUAN_TRI}`]);
            }

        });
    }
    async ngOnInit() {
        debugger
        if(this.IDBenhAn != null){
            this.emrService.SetIdBenhAn(this.IDBenhAn);
            await this.emrService.SetDataBenhAn();
            this.router.navigate([`/${environment.ROUTE_QUAN_TRI}`]);
        }
        // if(this.IDBenhAn != null){
        //     this.emrService.SetIdBenhAn(this.IDBenhAn);
        //     this.emrService.GetDataBenhAn().toPromise().then(
        //         (data: any) => {
        //             this.emrService.ThongTinHoSoBenhAn = data.Data;
        //             this.toastr.success(`${data.Data.HoTenBenhNhan}`, `Chào mừng bạn đến với hệ thống quản lý EMR`);
        //             this.router.navigate([`/${environment.ROUTE_QUAN_TRI}`]);
        //         },
        //         error => {
        //             this.toastr.error(`${JSON.stringify(error)}`, `Lỗi khi lấy thông tin bệnh án`);
        //         });

            
        // }
        
    }
}
