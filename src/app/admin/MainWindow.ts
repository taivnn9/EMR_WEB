import { Component, ElementRef, OnInit, TemplateRef, ViewChild } from '@angular/core';
import { first } from 'rxjs/operators';


import { environment } from '@environments/environment';
import { Router } from '@angular/router';
import { Tab } from '@app/_models/UTILS/Tab';
import { SharedService } from '@app/_services/shared.service';
import { Command } from '@app/_models/UTILS/Command';
import { EmrService } from '@app/_services/emr.service';
// import { ERMADO } from '@app/_models/ERMADO';
// import { ThongTinHoSoBenhAn } from '@app/_models/ThongTinHoSoBenhAn';
import { CommandData } from '@app/_models/UTILS/CommandData';
import { ComponentType, ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from 'ngx-spinner';
import { ThongTinHoSoBenhAn } from '@app/_models/EMR_MAIN/XemBenhAn/xemBenhAn';
import { DanhSachMauPhieuComponent } from './ChucNangKhac/DanhSachMauPhieu.component';
import { OverlayService } from '@app/_services/overlay.service';

@Component({
    templateUrl: 'MainWindow.html',
    providers: [SharedService]
})
export class MainWindowComponent implements OnInit {
    env = environment
    loading: boolean = false;
    tenBenhAn: string = '';
    tabs: Tab[] = [];
    commandEnum: typeof Command = Command;

    loaiDataIn: string = ''
    DataBase64Pdf: string = ''
    
    saveEvents: number = 0;
    saveChanges: number = 0;

    printEvents: number = 0;
    printChanges: number = 0;

    @ViewChild('modalHanhchinhPdfReference') modalHanhchinhPdfReference: ElementRef<HTMLElement>;

    OpenModalHanhchinhPdf() {
        let el: HTMLElement = this.modalHanhchinhPdfReference.nativeElement;
        el.click();
    }

    constructor(
        private router: Router,
        private sharedService: SharedService,
        private emrService: EmrService,
        private toastr: ToastrService,
        private spinner: NgxSpinnerService,
        private overlayService: OverlayService,
    ) {
        // Lắng nghe lệnh in gửi trả về từ component con
        this.sharedService.commandPrint$.subscribe(
            (data: CommandData) => {
                // nhận dữ liệu từ component con
                console.log(data);
                // this.showSpinner()
                if(this.printChanges >= this.printEvents){
                    return
                }
                this.printChanges ++;
                this.emrService.PrintWebEMR(data.Data, this.loaiDataIn).toPromise().then(
                    response => {
                        console.log(response);
                        if (response.Success != null && response.Success == true) {
                            this.DataBase64Pdf = response.Data;
                            this.OpenModalHanhchinhPdf();
                        }else{
                            this.toastr.error(``, `Không tồn tại phiếu in ${this.getNameLoaiDataIn()}` );
                        }
                    },
                    error => {
                        this.toastr.error(`${JSON.stringify(error)}`, `Lỗi khi in thông tin ${this.getNameLoaiDataIn()}`, );
                        console.error(error);
                    })

            });

        // Lắng nghe lệnh lưu gửi trả về từ component con
        this.sharedService.commandSave$.subscribe(
            (commandData: CommandData) => {
                console.log(commandData);

                // Chỉ lưu phiếu đang mở
                const href = this.router.url;
                if(!this.router.url.includes(commandData.Sender) ||
                this.saveChanges >= this.saveEvents){
                    return;
                }
                this.saveChanges ++;
                this.save(commandData.Data)
                
            });
    }


    async ngOnInit() {
        // Lấy tên bệnh án
        this.loading = true;
        // await this.emrService.SetDataBenhAn();
        await this.emrService.GetDataBenhAn().toPromise().then(
            (data: any) => {
                this.loading = false;
                this.emrService.ThongTinHoSoBenhAn = data.Data;
                this.toastr.success(``, `Chào mừng bạn đến với hệ thống quản lý EMR`);
            },
            error => {
                this.toastr.error(`${JSON.stringify(error)}`, `Lỗi khi lấy thông tin bệnh án`);
                // console.error(error);
            });


        try {
            console.log(this.emrService.ThongTinHoSoBenhAn.BenhAn.TenMauPhieu);
            this.tenBenhAn = this.emrService.ThongTinHoSoBenhAn.BenhAn.TenMauPhieu;
        } catch (error) {
            this.tenBenhAn = 'BỆNH ÁN';
        }
         
        this.addTabs();

    }
    addTabs() {
        const tab1 = new Tab(1, `/${environment.ROUTE_QUAN_TRI}/${environment.ROUTE_HANH_CHINH}`, 'HÀNH CHÍNH');
        const tab2 = new Tab(2, `/${environment.ROUTE_QUAN_TRI}/${environment.ROUTE_HOI_BENH}`, 'HỎI BỆNH');
        const tab3 = new Tab(1, `/${environment.ROUTE_QUAN_TRI}/${environment.ROUTE_KHAM_BENH}`, 'KHÁM BỆNH');
        const tab4 = new Tab(2, `/${environment.ROUTE_QUAN_TRI}/${environment.ROUTE_TONG_KET}`, 'TỔNG KẾT');
        this.tabs.push(tab1);
        this.tabs.push(tab2);
        this.tabs.push(tab3);
        this.tabs.push(tab4);
    }

    
    announceCommand(command: any) {
        console.log(`MainWindowComponent announceCommand`, command);
        this.sharedService.announceCommand(`${command}`);
    }
    save(ThongTinHoSoBenhAn: ThongTinHoSoBenhAn){
        console.log(`Data gửi đi`, ThongTinHoSoBenhAn);
        
        this.emrService.BenhAnSave(ThongTinHoSoBenhAn).toPromise().then(
            response => {
                console.log(response);
                if (response.Success != undefined && response.Success) {
                    // Cập nhật lại ThongTinHoSoBenhAn vào emr service
                    this.emrService.ThongTinHoSoBenhAn = ThongTinHoSoBenhAn;
                    this.toastr.success(``, `Lưu thông tin ${this.getNameLoaiDataIn()} thành công` );
                } else {
                    this.toastr.error(`${JSON.stringify(response.Error)}`, `Lỗi khi lưu thông tin ${this.getNameLoaiDataIn()}`);
                }
            },
            error => {
                console.error(error);
                this.toastr.error( `${JSON.stringify(error)}`, `Lỗi khi lưu thông tin ${this.getNameLoaiDataIn()}`);
            })
    }
    print(loaiDataIn: string){
        this.loaiDataIn = loaiDataIn;
        this.sharedService.announceCommand(`${this.commandEnum.Print}`);
    }

    getNameLoaiDataIn(): string{
        switch (this.loaiDataIn) {
            case this.env.HANH_CHINH:
                return "Hành chính";
    
            case this.env.HOI_BENH:
                return "Hỏi bệnh";

            case this.env.KHAM_BENH:
                return "Khám bệnh";
            
            default:
                return "Tổng kết";
        }
    }
    isSelected(url: string) {
        const href = this.router.url;
        if (href.includes(url)) {
            return true;
        } else if (href == `/${environment.ROUTE_QUAN_TRI}` && url == `/${environment.ROUTE_QUAN_TRI}/${environment.ROUTE_HANH_CHINH}`) {
            // debugger
            return true;
        }

        return false;
    }

    danhSachMauPhieuComponent = DanhSachMauPhieuComponent

    openModal(TemplateRef: TemplateRef<any> | ComponentType<any> | string) {
        const ref = this.overlayService.open(TemplateRef, null);

        ref.afterClosed$.subscribe(res => {
            if (TemplateRef === this.danhSachMauPhieuComponent) {
                console.log(res.data);
            }
        });
    }
}