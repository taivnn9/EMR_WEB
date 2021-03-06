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
    selector: 'TongKet_DaLieu',
    templateUrl: 'TongKet_DaLieu.component.html'
})
export class TongKet_DaLieu implements OnInit {
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
                this.toastr.error(error, 'Kh??ng l???y ???????c danh s??ch nh??n vi??n');
            });
    }


    doCommand(command: number) {
        console.log(`KhamBenh_NoiTruYHCT ???? nh???n ???????c l???nh ${command}`);
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

            Type: environment.TONG_KET,
            Data: this.ThongTinHoSoBenhAn,
            Sender: environment.ROUTE_TONG_KET
        });
    }

    print() {
        console.log(`print()`, this.ThongTinHoSoBenhAn);
        // G???i tr??? l???i th??ng tin h??? s?? b???nh ??n ????? Admin component in ra
        this.sharedService.confirmPrint({

            Type: environment.TONG_KET,
            Data: this.ThongTinHoSoBenhAn,
            Sender: environment.ROUTE_TONG_KET
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