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
    selector: 'HoiBenh_Bong',
    templateUrl: 'HoiBenh_Bong.component.html' 
})
export class HoiBenh_Bong implements OnInit {

    ThongTinHoSoBenhAn: ThongTinHoSoBenhAn

    constructor(
        private emrService: EmrService,
        private sharedService: SharedService,
        private overlayService: OverlayService
    ) {}

    ngOnInit(): void {
        this.ThongTinHoSoBenhAn = this.emrService.ThongTinHoSoBenhAn;
    }

    
    doCommand(command: number) {
        console.log(`HoiBenh_Bong đã nhận được lệnh ${command}`);
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