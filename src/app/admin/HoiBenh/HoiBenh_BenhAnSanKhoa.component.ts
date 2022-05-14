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
    selector: 'HoiBenh_BenhAnSanKhoa',
    templateUrl: 'HoiBenh_BenhAnSanKhoa.component.html' 
})
export class HoiBenh_BenhAnSanKhoa implements OnInit {

    ThongTinHoSoBenhAn: ThongTinHoSoBenhAn
    TreSoSinh_LoaiThai_Don:any
    TreSoSinh_LoaiThai_Da:any
    GioiTinh_Trai:any
    GioiTinh_Gai:any
    TreSoSinh_Song:any
    TreSoSinh_Chet:any
    TreSoSinh_DiTat_Co:any
    TreSoSinh_DiTat_Ko:any

    constructor(
        private emrService: EmrService,
        private sharedService: SharedService,
        private overlayService: OverlayService
    ) {}

    ngOnInit(): void {
        debugger
        this.ThongTinHoSoBenhAn = this.emrService.ThongTinHoSoBenhAn;
        this.TreSoSinh_LoaiThai_Don = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.TreSoSinh_LoaiThai == 1 ? true : false;
        this.TreSoSinh_LoaiThai_Da = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.TreSoSinh_LoaiThai == 0 ? true : false;
        this.GioiTinh_Trai = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.TreSoSinh_GioiTinh == 1 ? true : false;
        this.GioiTinh_Gai = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.TreSoSinh_GioiTinh == 0 ? true : false;
        this.TreSoSinh_Song = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.TreSoSinh_SongChet == 1 ? true : false;
        this.TreSoSinh_Chet = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.TreSoSinh_SongChet == 0 ? true : false;
        this.TreSoSinh_DiTat_Co = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.TreSoSinh_DiTat == 1 ? true : false;
        this.TreSoSinh_DiTat_Ko = this.emrService.ThongTinHoSoBenhAn.ThongTinDieuTri.TreSoSinh_DiTat == 0 ? true : false;
    }

    
    doCommand(command: number) {
        console.log(`HoiBenh_BenhAnSanKhoa đã nhận được lệnh ${command}`);
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