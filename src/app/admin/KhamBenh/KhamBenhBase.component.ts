import { AfterViewInit, Component, ComponentFactoryResolver, OnInit, ViewChild, ViewContainerRef } from '@angular/core';
import { LoaiBenhAnEMR } from '@app/_models/EMR_MAIN/TrangBia/TrangBia';
// import { ERMADO } from '@app/_models/ERMADO';
import { EmrService } from '@app/_services/emr.service';
import { KhamBenh_DaLieu } from './KhamBenh_DaLieu.component';
import { KhamBenh_NoiTruYHCT } from './KhamBenh_NoiTruYHCT.component';
import { KhamBenh_NoiKhoa } from './KhamBenh_NoiKhoa.component';
import { KhamBenh_BenhAnSanKhoa } from './KhamBenh_BenhAnSanKhoa.component';

import { KhamBenh_RangHamMat } from './KhamBenh_RangHamMat.component';
import { KhamBenh_ThanNhanTao } from './KhamBenh_ThanNhanTao.component';
import {HoiBenh_ThanNhanTao} from "@app/admin/HoiBenh/HoiBenh_ThanNhanTao.component";
import { KhamBenh_Bong } from './KhamBenh_Bong.component';
import { KhamBenh_Tim } from './KhamBenh_Tim.component';
import { KhamBenh_NgoaiTruYHCT } from './KhamBenh_NgoaiTruYHCT.component';
import { SharedService } from '@app/_services/shared.service';
import { Subscription } from 'rxjs';

@Component({
    selector: 'KhamBenhBaseComponent',
    template: `<ng-template #dynamicInsert></ng-template>`
})
export class KhamBenhBaseComponent implements OnInit, AfterViewInit {
    @ViewChild('dynamicInsert', { read: ViewContainerRef })
    dynamicInsert: ViewContainerRef;

    dynamicComponent: any;
    subscription: Subscription;
    constructor(
        private factoryResolver: ComponentFactoryResolver,
        private emrService: EmrService,
        private sharedService: SharedService,
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
    ngAfterViewInit(): void {
        debugger
        setTimeout(() => {
            switch (+this.emrService.ThongTinHoSoBenhAn.LoaiBenhAnEMR) {
                case LoaiBenhAnEMR.NoiTruYHCT:
                    const componentFactoryNoiTruYHCT = this.factoryResolver.resolveComponentFactory(KhamBenh_NoiTruYHCT);
                    this.dynamicInsert.clear();
                    this.dynamicComponent = <KhamBenh_NoiTruYHCT>this.dynamicInsert.createComponent(componentFactoryNoiTruYHCT).instance;
                    break;
                case LoaiBenhAnEMR.NoiKhoa:
                    const componentFactory_NoiKhoa = this.factoryResolver.resolveComponentFactory(KhamBenh_NoiKhoa);
                    this.dynamicInsert.clear();
                    this.dynamicComponent = <KhamBenh_NoiKhoa>this.dynamicInsert.createComponent(componentFactory_NoiKhoa).instance;
                    break;
                case LoaiBenhAnEMR.SanKhoa:
                    const componentFactorySK = this.factoryResolver.resolveComponentFactory(KhamBenh_BenhAnSanKhoa);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    const dynamicComponentSK = <KhamBenh_BenhAnSanKhoa> this.dynamicInsert.createComponent(componentFactorySK).instance;
                    // this.dynamicInsert.createComponent(componentFactory);
                    this.dynamicComponent = <KhamBenh_BenhAnSanKhoa>this.dynamicInsert.createComponent(componentFactorySK).instance;
                    // dynamicComponent.value = 10;
                    break;
                case LoaiBenhAnEMR.DaLieu:
                    const componentFactoryDaLieu = this.factoryResolver.resolveComponentFactory(KhamBenh_DaLieu);
                    this.dynamicInsert.clear();
                    this.dynamicComponent = <KhamBenh_DaLieu>this.dynamicInsert.createComponent(componentFactoryDaLieu).instance;
                    break;
                case LoaiBenhAnEMR.Bong:
                    const componentFactoryBong = this.factoryResolver.resolveComponentFactory(KhamBenh_Bong);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    this.dynamicComponent = <KhamBenh_Bong>this.dynamicInsert.createComponent(componentFactoryBong).instance;
                    // dynamicComponent.value = 10;
                    break;
                case LoaiBenhAnEMR.Tim:
                    const componentFactoryTim = this.factoryResolver.resolveComponentFactory(KhamBenh_Tim);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    this.dynamicComponent = <KhamBenh_Tim>this.dynamicInsert.createComponent(componentFactoryTim).instance;
                    // dynamicComponent.value = 10;
                case LoaiBenhAnEMR.NgoaiTruYHCT:
                    const componentFactoryNgoaiTru = this.factoryResolver.resolveComponentFactory(KhamBenh_NgoaiTruYHCT);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // tslint:disable-next-line:max-line-length
                    this.dynamicComponent = <KhamBenh_NgoaiTruYHCT> this.dynamicInsert.createComponent(componentFactoryNgoaiTru).instance;
                    break;
                case LoaiBenhAnEMR.ThanNhanTao:
                    const componentFactoryThanNhanTao = this.factoryResolver.resolveComponentFactory(KhamBenh_ThanNhanTao);
                    this.dynamicInsert.clear();
                    this.dynamicComponent = <KhamBenh_ThanNhanTao> this.dynamicInsert.createComponent(componentFactoryThanNhanTao).instance;
                    break;
                case LoaiBenhAnEMR.RangHamMat:
                    debugger
                    const componentFactoryRHM = this.factoryResolver.resolveComponentFactory(KhamBenh_RangHamMat);
                    this.dynamicInsert.clear();
                    const dynamicComponentRHM = <KhamBenh_RangHamMat> this.dynamicInsert.createComponent(componentFactoryRHM).instance;
                    break;
                default:
                    break;
            }
        }, 0);
    }

    ngOnInit() {
        // Call data
    }
}
