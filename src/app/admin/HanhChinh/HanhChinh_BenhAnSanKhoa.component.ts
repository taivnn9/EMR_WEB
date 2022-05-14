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
    selector: 'HanhChinh_BenhAnSanKhoa',
    templateUrl: 'HanhChinh_BenhAnSanKhoa.component.html'
})
export class HanhChinh_BenhAnSanKhoa implements OnInit {

    ThongTinHoSoBenhAn: ThongTinHoSoBenhAn
    TinhHinhPTCapCuu:any
    TinhHinhPTChuDong:any
    LyDoBienChung_PhauThuat:any
    LyDoBienChung_GayMe:any
    LyDoBienChung_NhiemKhuan:any
    LyDoBienChung_Khac:any
    // subscription: Subscription
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
        debugger
        this.ThongTinHoSoBenhAn = this.emrService.ThongTinHoSoBenhAn;
        this.TinhHinhPTCapCuu = this.emrService.ThongTinHoSoBenhAn.BenhAn.TinhHinhPT == 1 ? true : false;
        this.TinhHinhPTChuDong = this.emrService.ThongTinHoSoBenhAn.BenhAn.TinhHinhPT == 2 ? true : false;
        this.LyDoBienChung_PhauThuat = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.LyDoTaiBienBienChung == 1 ? true : false;
        this.LyDoBienChung_GayMe = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.LyDoTaiBienBienChung == 2 ? true : false;
        this.LyDoBienChung_NhiemKhuan = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.LyDoTaiBienBienChung == 3 ? true : false;
        this.LyDoBienChung_Khac = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.LyDoTaiBienBienChung == 4 ? true : false;
        console.log('show log === ',this.ThongTinHoSoBenhAn);

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
        console.log(`HanhChinh_NoiTruYHCT đã nhận được lệnh ${command}`);
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