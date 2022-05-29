import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ThongTinHoSoBenhAn } from '@app/_models/EMR_MAIN/XemBenhAn/xemBenhAn';
import { Command } from '@app/_models/UTILS/Command';
import { EmrService } from '@app/_services/emr.service';
import { SharedService } from '@app/_services/shared.service';
import { environment } from '@environments/environment';
import { IAngularMyDpOptions, IMyDateModel } from 'angular-mydatepicker';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { NhanVien } from '@app/_models/EMR_MAIN/BenhVien/nhanVien';
import { NhanVienService } from '@app/_services/NhanVien.service';


@Component({
    selector: 'HanhChinh_NgoaiTruYHCT',
    templateUrl: 'HanhChinh_NgoaiTruYHCT.component.html'
})
export class HanhChinh_NgoaiTruYHCT implements OnInit {

    ThongTinHoSoBenhAn: ThongTinHoSoBenhAn
    // subscription: Subscription

    constructor(
        private emrService: EmrService,
        private nhanVienSerivce: NhanVienService,
        private sharedService: SharedService,
        private http: HttpClient,
        private toastr: ToastrService,
    ) {
        // this.subscription = sharedService.commandAnnounced$.subscribe(
        //     command => {
        //         this.sharedService.confirmCommand(`HanhChinh_NoiTruYHCT Recived ${command}`);
        //     });
    }

    ListNhanVien = []

    async ngOnInit() {

        this.ThongTinHoSoBenhAn = this.emrService.ThongTinHoSoBenhAn;
        // console.log(this.ThongTinHoSoBenhAn);

        await this.nhanVienSerivce.ListNhanVien().toPromise().then(
            (data: any) => {
                if (data.Success) {
                    const items = []
                    for (let index = 0; index < data.Data.length; index++) {
                        const element = data.Data[index];
                        const item = {
                            value: element.IdNhanVien,
                            label: element.HoVaTen
                        }
                        items.push(item);
                    }
                    this.ListNhanVien = items
                }
            },
            error => {
                this.toastr.error(error, 'Lỗi');
            });

    }

    doCommand(command: number) {
        console.log(`HanhChinh_NgoaiTruYHCT đã nhận được lệnh ${command}`);
        switch (+command) {
            case Command.Save:
                this.save()
                break;
            case Command.Print:
                this.print()
                break;

            default:
                break;
        }
    }

    async save() {
        console.log(`save()`, this.ThongTinHoSoBenhAn);
        // Gửi trả lại thông tin hồ sơ bệnh án để Admin component lưu lại
        this.sharedService.confirmPSave({
            Type: environment.HANH_CHINH,
            Data: this.ThongTinHoSoBenhAn,
            Sender: environment.ROUTE_HANH_CHINH
        });
    }

    print() {
        console.log(`print()`, this.ThongTinHoSoBenhAn);
        // Gửi trả lại thông tin hồ sơ bệnh án để Admin component in ra
        this.sharedService.confirmPrint({
            Type: environment.HANH_CHINH,
            Data: this.ThongTinHoSoBenhAn,
            Sender: environment.ROUTE_HANH_CHINH
        });
    }
}
