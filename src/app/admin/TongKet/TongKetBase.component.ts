import { AfterViewInit, Component, ComponentFactoryResolver, OnInit, ViewChild, ViewContainerRef } from '@angular/core';
import { LoaiBenhAnEMR } from '@app/_models/EMR_MAIN/TrangBia/TrangBia';
import { EmrService } from '@app/_services/emr.service';
import { TongKet_DaLieu } from './TongKet_DaLieu.component';
import { TongKet_NoiTruYHCT } from './TongKet_NoiTruYHCT.component';
import { TongKet_NoiKhoa } from './TongKet_NoiKhoa.component';
import { TongKet_BenhAnSanKhoa } from './TongKet_BenhAnSanKhoa.component';
import { TongKet_RangHamMat } from './TongKet_RangHamMat.component';
import { TongKet_ThanNhanTao } from './TongKet_ThanNhanTao.component';
import { TongKet_Bong } from './TongKet_Bong.component';
import { TongKet_NgoaiTruYHCT } from './TongKet_NgoaiTruYHCT.component';
import { Subscription } from 'rxjs';
import { SharedService } from '@app/_services/shared.service';

@Component({
    selector: 'TongKetBaseComponent',
    template: `<ng-template #dynamicInsert></ng-template>`
})
export class TongKetBaseComponent implements OnInit, AfterViewInit {
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
        setTimeout(() => {

            switch (+this.emrService.ThongTinHoSoBenhAn.LoaiBenhAnEMR) {
                case LoaiBenhAnEMR.NoiTruYHCT:
                    const componentFactoryNoiTruYHCT = this.factoryResolver.resolveComponentFactory(TongKet_NoiTruYHCT);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    this.dynamicComponent = <TongKet_NoiTruYHCT>this.dynamicInsert.createComponent(componentFactoryNoiTruYHCT).instance;
                    // dynamicComponent.value = 10;
                    break;
                case LoaiBenhAnEMR.NoiKhoa:
                    const componentFactory_NoiKhoa = this.factoryResolver.resolveComponentFactory(TongKet_NoiKhoa);
                    this.dynamicInsert.clear();
                    this.dynamicComponent = <TongKet_NoiKhoa>this.dynamicInsert.createComponent(componentFactory_NoiKhoa).instance;
                    break;
                case LoaiBenhAnEMR.SanKhoa:
                    const componentFactorySK = this.factoryResolver.resolveComponentFactory(TongKet_BenhAnSanKhoa);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    const dynamicComponentSK = <TongKet_BenhAnSanKhoa> this.dynamicInsert.createComponent(componentFactorySK).instance;
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    this.dynamicComponent = <TongKet_BenhAnSanKhoa>this.dynamicInsert.createComponent(componentFactorySK).instance;
                    // dynamicComponent.value = 10;
                    break;
                case LoaiBenhAnEMR.DaLieu:
                    const componentFactoryDaLieu = this.factoryResolver.resolveComponentFactory(TongKet_DaLieu);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    const dynamicComponentDaLieu = <TongKet_DaLieu> this.dynamicInsert.createComponent(componentFactoryDaLieu).instance;
                    break;
                case LoaiBenhAnEMR.RangHamMat:
                    const componentFactoryRHM = this.factoryResolver.resolveComponentFactory(TongKet_RangHamMat);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    const dynamicComponentRHM = <TongKet_RangHamMat> this.dynamicInsert.createComponent(componentFactoryRHM).instance;
                    // this.dynamicInsert.createComponent(componentFactory);
                    this.dynamicComponent = <TongKet_DaLieu>this.dynamicInsert.createComponent(componentFactoryDaLieu).instance;
                    // dynamicComponent.value = 10;
                    break;
                case LoaiBenhAnEMR.Bong:                  
                    const componentFactoryBong = this.factoryResolver.resolveComponentFactory(TongKet_Bong);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    this.dynamicComponent = <TongKet_Bong>this.dynamicInsert.createComponent(componentFactoryBong).instance;
                    // dynamicComponent.value = 10;
                    break;

                case LoaiBenhAnEMR.ThanNhanTao:
                    const componentFactoryThanNhanTao = this.factoryResolver.resolveComponentFactory(TongKet_ThanNhanTao);
                    this.dynamicInsert.clear();
                    this.dynamicComponent = <TongKet_ThanNhanTao> this.dynamicInsert.createComponent(componentFactoryThanNhanTao).instance;
                case LoaiBenhAnEMR.NgoaiTruYHCT:
                    const componentFactoryNgoaiTruYHCT = this.factoryResolver.resolveComponentFactory(TongKet_NgoaiTruYHCT);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // tslint:disable-next-line:max-line-length
                    this.dynamicComponent = <TongKet_NgoaiTruYHCT> this.dynamicInsert.createComponent(componentFactoryNgoaiTruYHCT).instance;
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
