import { AfterViewInit, Component, ComponentFactoryResolver, OnInit, ViewChild, ViewContainerRef } from '@angular/core';
// import { ERMADO } from '@app/_models/ERMADO';
// import { LoaiBenhAnEMR } from '@app/_models/enum/LoaiBenhAnEMR';
import { HanhChinh_NoiTruYHCT } from './HanhChinh_NoiTruYHCT.component';
import { HanhChinh_BenhAnSanKhoa } from './HanhChinh_BenhAnSanKhoa.component';
import { HanhChinh_ThanNhanTao } from './HanhChinh_ThanNhanTao.component';
import { HanhChinh_NgoaiTruYHCT } from './HanhChinh_NgoaiTruYHCT.component';
import { HanhChinh_Sosinh } from './HanhChinh_Sosinh.component';
import { Subscription } from 'rxjs';
import { SharedService } from '@app/_services/shared.service';
import { Command } from 'protractor';
import { LoaiBenhAnEMR } from '@app/_models/EMR_MAIN/TrangBia/TrangBia';
import { EmrService } from '@app/_services/emr.service';
// import { ThongTinHoSoBenhAn } from '@app/_models/ThongTinHoSoBenhAn';
import { HanhChinh_Base } from './HanhChinh_Base.component';

@Component({
    selector: 'HanhChinhBaseComponent',
    template: `<ng-template #dynamicInsert></ng-template>`
})
export class HanhChinhBaseComponent implements OnInit, AfterViewInit {
    @ViewChild('dynamicInsert', { read: ViewContainerRef })
    dynamicInsert: ViewContainerRef;
    dynamicComponent: any;
    subscription: Subscription;
    constructor(
        private factoryResolver: ComponentFactoryResolver,
        private sharedService: SharedService,
        private emrService: EmrService,
    ) {
        // listener
        this.subscription = sharedService.commandAnnounced$.subscribe(
            command => {
                // Gửi broadcast đã nhận được lệnh
                this.sharedService.confirmCommand(`HanhChinhBase Recived ${command}`);

                // gửi lệnh cho các component đang mở
                if (this.dynamicComponent != null) {
                    this.dynamicComponent.doCommand(command);
                }
            });
    }


    ngOnInit() {
        // Call data
    }

    ngAfterViewInit(): void {
        // debugger
        setTimeout(() => {
            switch (+this.emrService.ThongTinHoSoBenhAn.LoaiBenhAnEMR) {
                case LoaiBenhAnEMR.NoiTruYHCT:
                    const componentFactory = this.factoryResolver.resolveComponentFactory(HanhChinh_NoiTruYHCT);

                    this.dynamicInsert.clear();
                    this.dynamicComponent = <HanhChinh_NoiTruYHCT>this.dynamicInsert.createComponent(componentFactory).instance;
                    break;
                case LoaiBenhAnEMR.NoiKhoa:
                    const componentFactory_NoiKhoa = this.factoryResolver.resolveComponentFactory(HanhChinh_Base);
                    this.dynamicInsert.clear();
                    this.dynamicComponent = <HanhChinh_Base>this.dynamicInsert.createComponent(componentFactory_NoiKhoa).instance;
                    break;
                case LoaiBenhAnEMR.SanKhoa:
                    const componentFactorySK = this.factoryResolver.resolveComponentFactory(HanhChinh_BenhAnSanKhoa);

                    this.dynamicInsert.clear();
                    this.dynamicComponent = <HanhChinh_BenhAnSanKhoa>this.dynamicInsert.createComponent(componentFactorySK).instance;
                    break;
                case LoaiBenhAnEMR.ThanNhanTao:
                    const componentFactory_ThanNhanTao = this.factoryResolver.resolveComponentFactory(HanhChinh_ThanNhanTao);

                    this.dynamicInsert.clear();
                    this.dynamicComponent = <HanhChinh_ThanNhanTao>this.dynamicInsert.createComponent(componentFactory_ThanNhanTao).instance;
                    break;
                case LoaiBenhAnEMR.NgoaiTruYHCT:
                    // tslint:disable-next-line:variable-name
                    const componentFactory_NgoaiTruYHCT = this.factoryResolver.resolveComponentFactory(HanhChinh_NgoaiTruYHCT);

                    this.dynamicInsert.clear();
                    // tslint:disable-next-line:max-line-length
                    this.dynamicComponent = <HanhChinh_NgoaiTruYHCT> this.dynamicInsert.createComponent(componentFactory_NgoaiTruYHCT).instance;
                    break;
                case LoaiBenhAnEMR.SoSinh:
                    const componentFactory_Sosinh = this.factoryResolver.resolveComponentFactory(HanhChinh_Sosinh);
                    this.dynamicInsert.clear();
                    this.dynamicComponent = <HanhChinh_Sosinh> this.dynamicInsert.createComponent(componentFactory_Sosinh).instance;
                    break;
                default:
                    const componentFactory_Default= this.factoryResolver.resolveComponentFactory(HanhChinh_Base);
                    this.dynamicInsert.clear();
                    this.dynamicComponent = <HanhChinh_Base>this.dynamicInsert.createComponent(componentFactory_Default).instance;
                    break;
            }
        }, 0);

    }

}
