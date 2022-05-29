
import { AfterViewInit, Component, ComponentFactoryResolver, OnInit, ViewChild, ViewContainerRef } from '@angular/core';
import { LoaiBenhAnEMR } from '@app/_models/EMR_MAIN/TrangBia/TrangBia';
// import { ERMADO } from '@app/_models/ERMADO';
import { EmrService } from '@app/_services/emr.service';
import { HoiBenh_DaLieu } from './HoiBenh_DaLieu.component';
import { HoiBenh_NoiTruYHCT } from './HoiBenh_NoiTruYHCT.component';
import { HoiBenh_NoiKhoa } from './HoiBenh_NoiKhoa.component';
import { HoiBenh_BenhAnSanKhoa } from './HoiBenh_BenhAnSanKhoa.component';
import { HoiBenh_ThanNhanTao } from './HoiBenh_ThanNhanTao.component';
import { HoiBenh_Bong } from './HoiBenh_Bong.component';
import { HoiBenh_NgoaiTruYHCT } from './HoiBenh_NgoaiTruYHCT.component';


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
        setTimeout(() => {

            switch (+this.emrService.ThongTinHoSoBenhAn.LoaiBenhAnEMR) {
                case LoaiBenhAnEMR.NoiTruYHCT:
                    const componentFactory_NoiTruYHCT = this.factoryResolver.resolveComponentFactory(HoiBenh_NoiTruYHCT);

                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    const dynamicComponent_NoiTruYHCT = <HoiBenh_NoiTruYHCT> this.dynamicInsert.createComponent(componentFactory_NoiTruYHCT).instance;
                    // dynamicComponent.value = 10;
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
                    // this.dynamicInsert.createComponent(componentFactory);
                    const dynamicComponentSK = <HoiBenh_BenhAnSanKhoa> this.dynamicInsert.createComponent(componentFactorySK).instance;
                    // dynamicComponent.value = 10;
                    break;
                case LoaiBenhAnEMR.DaLieu:
                    const componentFactory_DaLieu = this.factoryResolver.resolveComponentFactory(HoiBenh_DaLieu);
                    this.dynamicInsert.clear();
                    const dynamicComponent_DaLieu = <HoiBenh_DaLieu> this.dynamicInsert.createComponent(componentFactory_DaLieu).instance;
                    break;
                case LoaiBenhAnEMR.ThanNhanTao:
                    const componentFactory_ThanNhanTao = this.factoryResolver.resolveComponentFactory(HoiBenh_ThanNhanTao);
                    this.dynamicInsert.clear();
                    const dynamicComponent_ThanNhanTao = <HoiBenh_ThanNhanTao> this.dynamicInsert.createComponent(componentFactory_ThanNhanTao).instance;
                    break;
                case LoaiBenhAnEMR.Bong:
                    const componentFactoryBong = this.factoryResolver.resolveComponentFactory(HoiBenh_Bong);
                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    const dynamicComponentBong = <HoiBenh_Bong> this.dynamicInsert.createComponent(componentFactoryBong).instance;
                    // dynamicComponent.value = 10;
                    break;
                case LoaiBenhAnEMR.NgoaiTruYHCT:
                    const componentFactory_NgoaiTruYHCT = this.factoryResolver.resolveComponentFactory(HoiBenh_NgoaiTruYHCT);

                    this.dynamicInsert.clear();
                    // @ts-ignore
                    // tslint:disable-next-line:max-line-length
                    const dynamicComponent_NgoaiTruYHCT = <HoiBenh_NgoaiTruYHCT>this.dynamicInsert.createComponent(componentFactory_NgoaiTruYHCT).instance;
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
