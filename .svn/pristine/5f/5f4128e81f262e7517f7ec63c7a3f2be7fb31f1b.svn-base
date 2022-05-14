import { HttpClient } from '@angular/common/http';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { ThongTinHoSoBenhAn } from '@app/_models/EMR_MAIN/XemBenhAn/xemBenhAn';
import { Command } from '@app/_models/UTILS/Command';
import { EmrService } from '@app/_services/emr.service';
import { NhanVienService } from '@app/_services/NhanVien.service';
import { OverlayService } from '@app/_services/overlay.service';
import { SharedService } from '@app/_services/shared.service';
import { environment } from '@environments/environment';
import { ComponentType, ToastrService } from 'ngx-toastr';
import { KetQuaDichVuHisProComponent } from '../ChucNangKhac/KetQuaDichVuHisPro.component';
import { KetQuaToDieuTriHisProComponent } from '../ChucNangKhac/KetQuaToDieuTriHisPro.component';

@Component({
    selector: 'TongKet_NoiTruYHCT',
    templateUrl: 'TongKet_NoiTruYHCT.component.html'
})
export class TongKet_NoiTruYHCT implements OnInit {
    ThongTinHoSoBenhAn: ThongTinHoSoBenhAn

    constructor(
        private emrService: EmrService,
        private sharedService: SharedService,
        private nhanVienSerivce: NhanVienService,
        private overlayService: OverlayService,
        private toastr: ToastrService,
    ) { }


    ListNhanVien = []

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
            Type: environment.HOI_BENH,
            Data: this.ThongTinHoSoBenhAn,
            Sender: environment.ROUTE_HOI_BENH
        });
    }

    print() {
        console.log(`print()`, this.ThongTinHoSoBenhAn);
        // Gửi trả lại thông tin hồ sơ bệnh án để Admin component in ra
        this.sharedService.confirmPrint({
            Type: environment.HOI_BENH,
            Data: this.ThongTinHoSoBenhAn,
            Sender: environment.ROUTE_HOI_BENH
        });
    }

    ketQuaToDieuTriHisProComponent = KetQuaToDieuTriHisProComponent
    ketQuaDichVuHisProComponent = KetQuaDichVuHisProComponent
    openModal() {
        this.open(this.ketQuaToDieuTriHisProComponent)
    }
    open(content: TemplateRef<any> | ComponentType<any> | string) {
        const ref = this.overlayService.open(content, null);

        ref.afterClosed$.subscribe(res => {
            if (content === this.ketQuaToDieuTriHisProComponent) {
                console.log(res.data);
            }
        });
    }
}