
import { AfterViewInit, Component, ComponentFactoryResolver, OnInit, ViewChild, ViewContainerRef } from '@angular/core';
import { LoaiBenhAnEMR } from '@app/_models/EMR_MAIN/TrangBia/TrangBia';
// import { ERMADO } from '@app/_models/ERMADO';
import { EmrService } from '@app/_services/emr.service';
import { HoiBenh_DaLieu } from './HoiBenh_DaLieu.component';
import { HoiBenh_NoiTruYHCT } from './HoiBenh_NoiTruYHCT.component';
import { HoiBenh_NoiKhoa } from './HoiBenh_NoiKhoa.component';
import { HoiBenh_BenhAnSanKhoa } from './HoiBenh_BenhAnSanKhoa.component';
import { HoiBenh_RangHamMat } from './HoiBenh_RangHamMat.component';

@Component({ 
    selector: 'HoiBenhBaseComponent',
    template: `<ng-template #dynamicInsert></ng-template>`
})
export class HoiBenhBaseComponent implements OnInit, AfterViewInit {
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
                    const componentFactory_NoiTruYHCT = this.factoryResolver.resolveComponentFactory(HoiBenh_NoiTruYHCT);
        
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    const dynamicComponent_NoiTruYHCT = <HoiBenh_NoiTruYHCT> this.dynamicInsert.createComponent(componentFactory_NoiTruYHCT).instance;
                    break;
                case LoaiBenhAnEMR.NoiKhoa:
                    const componentFactory_NoiKhoa = this.factoryResolver.resolveComponentFactory(HoiBenh_NoiKhoa);
                    this.dynamicInsert.clear();
                    const dynamicComponentNoiKhoa = <HoiBenh_NoiKhoa> this.dynamicInsert.createComponent(componentFactory_NoiKhoa).instance;
                    break;
                case LoaiBenhAnEMR.SanKhoa:
                    const componentFactorySK = this.factoryResolver.resolveComponentFactory(HoiBenh_BenhAnSanKhoa);
        
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    const dynamicComponentSK = <HoiBenh_BenhAnSanKhoa> this.dynamicInsert.createComponent(componentFactorySK).instance;
                    break;
                case LoaiBenhAnEMR.DaLieu:
                    const componentFactory_DaLieu = this.factoryResolver.resolveComponentFactory(HoiBenh_DaLieu);
                    this.dynamicInsert.clear();
                    const dynamicComponent_DaLieu = <HoiBenh_DaLieu> this.dynamicInsert.createComponent(componentFactory_DaLieu).instance;
                    break;
                case LoaiBenhAnEMR.RangHamMat:
                    debugger
                    const componentFactoryRHM = this.factoryResolver.resolveComponentFactory(HoiBenh_RangHamMat);
                    this.dynamicInsert.clear();
                    const dynamicComponentRHM = <HoiBenh_RangHamMat> this.dynamicInsert.createComponent(componentFactoryRHM).instance;
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