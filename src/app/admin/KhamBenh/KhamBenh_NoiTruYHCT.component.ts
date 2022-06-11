import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ThongTinHoSoBenhAn } from '@app/_models/EMR_MAIN/XemBenhAn/xemBenhAn';
import { Command } from '@app/_models/UTILS/Command';
import { EmrService } from '@app/_services/emr.service';
import { NhanVienService } from '@app/_services/NhanVien.service';
import { OverlayService } from '@app/_services/overlay.service';
import { SharedService } from '@app/_services/shared.service';
import { environment } from '@environments/environment';
import { ToastrService } from 'ngx-toastr';

@Component({ 
    selector: 'KhamBenh_NoiTruYHCT',
    templateUrl: 'KhamBenh_NoiTruYHCT.component.html' 
})
export class KhamBenh_NoiTruYHCT implements OnInit {
    ThongTinHoSoBenhAn: ThongTinHoSoBenhAn

    ListNhanVien = []
    constructor(
        private emrService: EmrService,
        private sharedService: SharedService,
        private nhanVienSerivce: NhanVienService,
        private overlayService: OverlayService,
        private toastr: ToastrService,
    ) {}


    async ngOnInit() {
        this.ThongTinHoSoBenhAn = this.emrService.ThongTinHoSoBenhAn;
        
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
        console.log(`KhamBenh_NoiTruYHCT đã nhận được lệnh ${command}`);
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
            Type: environment.KHAM_BENH,
            Data: this.ThongTinHoSoBenhAn,
            Sender: environment.ROUTE_KHAM_BENH
        });
    }

    print() {
        console.log(`print()`, this.ThongTinHoSoBenhAn);
        // Gửi trả lại thông tin hồ sơ bệnh án để Admin component in ra
        this.sharedService.confirmPrint({
            Type: environment.KHAM_BENH,
            Data: this.ThongTinHoSoBenhAn,
            Sender: environment.ROUTE_KHAM_BENH
        });
    }
}