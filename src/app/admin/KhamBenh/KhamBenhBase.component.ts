import { AfterViewInit, Component, ComponentFactoryResolver, OnInit, ViewChild, ViewContainerRef } from '@angular/core';
import { LoaiBenhAnEMR } from '@app/_models/EMR_MAIN/TrangBia/TrangBia';
// import { ERMADO } from '@app/_models/ERMADO';
import { EmrService } from '@app/_services/emr.service';
import { KhamBenh_DaLieu } from './KhamBenh_DaLieu.component';
import { KhamBenh_NoiTruYHCT } from './KhamBenh_NoiTruYHCT.component';
import { KhamBenh_NoiKhoa } from './KhamBenh_NoiKhoa.component';
import { KhamBenh_BenhAnSanKhoa } from './KhamBenh_BenhAnSanKhoa.component';
import { KhamBenh_RangHamMat } from './KhamBenh_RangHamMat.component';

@Component({ 
    selector: 'KhamBenhBaseComponent',
    template: `<ng-template #dynamicInsert></ng-template>`
})
export class KhamBenhBaseComponent implements OnInit, AfterViewInit {
    @ViewChild('dynamicInsert', { read: ViewContainerRef })
    dynamicInsert: ViewContainerRef;

    constructor(
        private factoryResolver: ComponentFactoryResolver,
        private emrService: EmrService,
    ) { }
    ngAfterViewInit(): void {
        debugger
        setTimeout(() => { 
            switch (+this.emrService.ThongTinHoSoBenhAn.LoaiBenhAnEMR) {
                case LoaiBenhAnEMR.NoiTruYHCT:
                    const componentFactoryNoiTruYHCT = this.factoryResolver.resolveComponentFactory(KhamBenh_NoiTruYHCT);
                    this.dynamicInsert.clear();
                    const dynamicComponentNoiTruYHCT = <KhamBenh_NoiTruYHCT> this.dynamicInsert.createComponent(componentFactoryNoiTruYHCT).instance;
                    break;
                case LoaiBenhAnEMR.NoiKhoa:
                    const componentFactory_NoiKhoa = this.factoryResolver.resolveComponentFactory(KhamBenh_NoiKhoa);
                    this.dynamicInsert.clear();
                    const dynamicComponentNoiKhoa = <KhamBenh_NoiKhoa> this.dynamicInsert.createComponent(componentFactory_NoiKhoa).instance;
                    break;
                case LoaiBenhAnEMR.SanKhoa:
                    const componentFactorySK = this.factoryResolver.resolveComponentFactory(KhamBenh_BenhAnSanKhoa);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    const dynamicComponentSK = <KhamBenh_BenhAnSanKhoa> this.dynamicInsert.createComponent(componentFactorySK).instance;
                    break;
                case LoaiBenhAnEMR.DaLieu:
                    const componentFactoryDaLieu = this.factoryResolver.resolveComponentFactory(KhamBenh_DaLieu);
                    this.dynamicInsert.clear();
                    const dynamicComponentDaLieu = <KhamBenh_DaLieu> this.dynamicInsert.createComponent(componentFactoryDaLieu).instance;
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