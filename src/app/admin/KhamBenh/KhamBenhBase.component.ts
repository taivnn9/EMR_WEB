import { AfterViewInit, Component, ComponentFactoryResolver, OnInit, ViewChild, ViewContainerRef } from '@angular/core';
import { LoaiBenhAnEMR } from '@app/_models/EMR_MAIN/TrangBia/TrangBia';
// import { ERMADO } from '@app/_models/ERMADO';
import { EmrService } from '@app/_services/emr.service';
import { KhamBenh_DaLieu } from './KhamBenh_DaLieu.component';
import { KhamBenh_NoiTruYHCT } from './KhamBenh_NoiTruYHCT.component';
import { KhamBenh_NoiKhoa } from './KhamBenh_NoiKhoa.component';
import { KhamBenh_BenhAnSanKhoa } from './KhamBenh_BenhAnSanKhoa.component';
import { KhamBenh_Bong } from './KhamBenh_Bong.component';

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
        setTimeout(() => {
            switch (+this.emrService.ThongTinHoSoBenhAn.LoaiBenhAnEMR) {
                case LoaiBenhAnEMR.NoiTruYHCT:
                    const componentFactoryNoiTruYHCT = this.factoryResolver.resolveComponentFactory(KhamBenh_NoiTruYHCT);
                    this.dynamicInsert.clear();
                    const dynamicComponentNoiTruYHCT = <KhamBenh_NoiTruYHCT>this.dynamicInsert.createComponent(componentFactoryNoiTruYHCT).instance;
                    break;
                case LoaiBenhAnEMR.NoiKhoa:
                    const componentFactory_NoiKhoa = this.factoryResolver.resolveComponentFactory(KhamBenh_NoiKhoa);
                    this.dynamicInsert.clear();
                    const dynamicComponentNoiKhoa = <KhamBenh_NoiKhoa>this.dynamicInsert.createComponent(componentFactory_NoiKhoa).instance;
                    break;
                case LoaiBenhAnEMR.SanKhoa:
                    const componentFactorySK = this.factoryResolver.resolveComponentFactory(KhamBenh_BenhAnSanKhoa);

                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    const dynamicComponentSK = <KhamBenh_BenhAnSanKhoa>this.dynamicInsert.createComponent(componentFactorySK).instance;
                    // dynamicComponent.value = 10;
                    break;
                case LoaiBenhAnEMR.DaLieu:
                    const componentFactoryDaLieu = this.factoryResolver.resolveComponentFactory(KhamBenh_DaLieu);
                    this.dynamicInsert.clear();
                    const dynamicComponentDaLieu = <KhamBenh_DaLieu>this.dynamicInsert.createComponent(componentFactoryDaLieu).instance;
                    break;
                case LoaiBenhAnEMR.Bong:
                    const componentFactoryBong = this.factoryResolver.resolveComponentFactory(KhamBenh_Bong);

                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    const dynamicComponentBong = <KhamBenh_Bong>this.dynamicInsert.createComponent(componentFactoryBong).instance;
                    // dynamicComponent.value = 10;
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