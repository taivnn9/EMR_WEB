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
import { Common } from '@app/_models/EMR_MAIN/common';


@Component({
    selector: 'HanhChinh_Base',
    templateUrl: 'HanhChinh_Base.component.html'
})
export class HanhChinh_Base implements OnInit {
    ThongTinHoSoBenhAn: ThongTinHoSoBenhAn;
    diachi: string;
    // subscription: Subscription

    constructor(
        private emrService: EmrService,
        private sharedService: SharedService,
        private http: HttpClient,
        private toastr: ToastrService,
        private nhanVienService: NhanVienService
    ) {
        // this.subscription = sharedService.commandAnnounced$.subscribe(
        //     command => {
        //         this.sharedService.confirmCommand(`HanhChinh_NoiTruYHCT Recived ${command}`);
        //     });
    }

    ListNhanVien = []
    async ngOnInit() {

        this.ThongTinHoSoBenhAn = this.emrService.ThongTinHoSoBenhAn;
        this.diachi = (new Common).GetDiaChi(this.ThongTinHoSoBenhAn.HanhChinhBenhNhan);
        console.log(this.diachi);
        console.log(this.ThongTinHoSoBenhAn);

        await this.nhanVienService.ListNhanVien().toPromise().then(
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
                this.toastr.error(error, 'L???i');
        });

    }

    doCommand(command: number) {
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
        // G???i tr??? l???i th??ng tin h??? s?? b???nh ??n ????? Admin component l??u l???i
        this.sharedService.confirmPSave({
            Type: environment.HANH_CHINH,
            Data: this.ThongTinHoSoBenhAn,
            Sender: environment.ROUTE_HANH_CHINH
        });
    }

    print() {
        console.log(`print()`, this.ThongTinHoSoBenhAn);
        // G???i tr??? l???i th??ng tin h??? s?? b???nh ??n ????? Admin component in ra
        this.sharedService.confirmPrint({
            Type: environment.HANH_CHINH,
            Data: this.ThongTinHoSoBenhAn,
            Sender: environment.ROUTE_HANH_CHINH
        });
    }
}
