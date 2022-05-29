import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ThongTinHoSoBenhAn } from '@app/_models/EMR_MAIN/XemBenhAn/xemBenhAn';
import { Command } from '@app/_models/UTILS/Command';
import { EmrService } from '@app/_services/emr.service';
import { SharedService } from '@app/_services/shared.service';
import { environment } from '@environments/environment';
import { ToastrService } from 'ngx-toastr';
import {NhanVienService} from '@app/_services/NhanVien.service';

@Component({
    selector: 'KhamBenh_NgoaiTruYHCT',
    templateUrl: 'KhamBenh_NgoaiTruYHCT.component.html'
})
export class KhamBenh_NgoaiTruYHCT implements OnInit {
    ThongTinHoSoBenhAn: ThongTinHoSoBenhAn

    constructor(
        private emrService: EmrService,
        private nhanVienSerivce: NhanVienService,
        private sharedService: SharedService,
        private http: HttpClient,
        private toastr: ToastrService,
    ) {}

    ListNhanVien = []


  async ngOnInit() {
        this.ThongTinHoSoBenhAn = this.emrService.ThongTinHoSoBenhAn;
        this.ThongTinHoSoBenhAn.BenhAn.RoiHanKhaNangSinhDuc = 2;

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
        console.log(`KhamBenh_NgoaiTruYHCT đã nhận được lệnh ${command}`);
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