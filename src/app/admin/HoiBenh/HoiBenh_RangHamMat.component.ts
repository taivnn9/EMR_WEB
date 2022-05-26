import { HttpClient } from '@angular/common/http';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { ThongTinHoSoBenhAn } from '@app/_models/EMR_MAIN/XemBenhAn/xemBenhAn';
import { Command } from '@app/_models/UTILS/Command';
import { EmrService } from '@app/_services/emr.service';
import { OverlayService } from '@app/_services/overlay.service';
import { SharedService } from '@app/_services/shared.service';
import { environment } from '@environments/environment';
import { ComponentType, ToastrService } from 'ngx-toastr';


@Component({ 
    selector: 'HoiBenh_RangHamMat',
    templateUrl: 'HoiBenh_RangHamMat.component.html' 
})
export class HoiBenh_RangHamMat implements OnInit {

    ThongTinHoSoBenhAn: ThongTinHoSoBenhAn
    DacDiemLienQuanBenh_DiUng:any
    DacDiemLienQuanBenh_ThuocLa:any
    DacDiemLienQuanBenh_MaTuy:any
    DacDiemLienQuanBenh_ThuocLao:any
    DacDiemLienQuanBenh_RuouBia:any
    DacDiemLienQuanBenh_Khac:any

    constructor(
        private emrService: EmrService,
        private sharedService: SharedService,
        private overlayService: OverlayService
    ) {}

    ngOnInit(): void {
        debugger
        this.ThongTinHoSoBenhAn = this.emrService.ThongTinHoSoBenhAn;
        this.DacDiemLienQuanBenh_DiUng = this.emrService.ThongTinHoSoBenhAn.BenhAn.DacDiemLienQuanBenh == 'DiUng' ? true : false;
        this.DacDiemLienQuanBenh_ThuocLa = this.emrService.ThongTinHoSoBenhAn.BenhAn.DacDiemLienQuanBenh == 'ThuocLa' ? true : false;
        this.DacDiemLienQuanBenh_MaTuy = this.emrService.ThongTinHoSoBenhAn.BenhAn.DacDiemLienQuanBenh == 'MaTuy' ? true : false;
        this.DacDiemLienQuanBenh_ThuocLao = this.emrService.ThongTinHoSoBenhAn.BenhAn.DacDiemLienQuanBenh == 'ThuocLao' ? true : false;
        this.DacDiemLienQuanBenh_RuouBia = this.emrService.ThongTinHoSoBenhAn.BenhAn.DacDiemLienQuanBenh == 'RuouBia' ? true : false;
        this.DacDiemLienQuanBenh_Khac = this.emrService.ThongTinHoSoBenhAn.BenhAn.DacDiemLienQuanBenh == 'Khac' ? true : false;
    }

    
    doCommand(command: number) {
        console.log(`HoiBenh_RangHamMat đã nhận được lệnh ${command}`);
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


}