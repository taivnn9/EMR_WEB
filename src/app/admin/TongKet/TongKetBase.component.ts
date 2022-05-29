import { AfterViewInit, Component, ComponentFactoryResolver, OnInit, ViewChild, ViewContainerRef } from '@angular/core';
import { LoaiBenhAnEMR } from '@app/_models/EMR_MAIN/TrangBia/TrangBia';
import { EmrService } from '@app/_services/emr.service';
import { TongKet_DaLieu } from './TongKet_DaLieu.component';
import { TongKet_NoiTruYHCT } from './TongKet_NoiTruYHCT.component';
import { TongKet_NoiKhoa } from './TongKet_NoiKhoa.component';
import { TongKet_BenhAnSanKhoa } from './TongKet_BenhAnSanKhoa.component';
import { TongKet_ThanNhanTao } from './TongKet_ThanNhanTao.component';

@Component({
    selector: 'TongKetBaseComponent',
    template: `<ng-template #dynamicInsert></ng-template>`
})
export class TongKetBaseComponent implements OnInit, AfterViewInit {
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
                    const componentFactoryNoiTruYHCT = this.factoryResolver.resolveComponentFactory(TongKet_NoiTruYHCT);

                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    const dynamicComponentNoiTruYHCT = <TongKet_NoiTruYHCT> this.dynamicInsert.createComponent(componentFactoryNoiTruYHCT).instance;
                    // dynamicComponent.value = 10;
                    break;
                case LoaiBenhAnEMR.NoiKhoa:
                    const componentFactory_NoiKhoa = this.factoryResolver.resolveComponentFactory(TongKet_NoiKhoa);
                    this.dynamicInsert.clear();
                    const dynamicComponentNoiKhoa = <TongKet_NoiKhoa>this.dynamicInsert.createComponent(componentFactory_NoiKhoa).instance;
                    break;
                case LoaiBenhAnEMR.SanKhoa:
                    const componentFactorySK = this.factoryResolver.resolveComponentFactory(TongKet_BenhAnSanKhoa);

                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    const dynamicComponentSK = <TongKet_BenhAnSanKhoa> this.dynamicInsert.createComponent(componentFactorySK).instance;
                    // dynamicComponent.value = 10;
                    break;
                case LoaiBenhAnEMR.DaLieu:
                    const componentFactoryDaLieu = this.factoryResolver.resolveComponentFactory(TongKet_DaLieu);

                    console.log(this.dynamicInsert);
                    this.dynamicInsert.clear();
                    // this.dynamicInsert.createComponent(componentFactory);
                    const dynamicComponentDaLieu = <TongKet_DaLieu> this.dynamicInsert.createComponent(componentFactoryDaLieu).instance;
                    // dynamicComponent.value = 10;
                    break;

                case LoaiBenhAnEMR.ThanNhanTao:
                    const componentFactoryThanNhanTao = this.factoryResolver.resolveComponentFactory(TongKet_ThanNhanTao);
                    this.dynamicInsert.clear();
                    const dynamicComponentThanNhanTao = <TongKet_ThanNhanTao> this.dynamicInsert.createComponent(componentFactoryThanNhanTao).instance;
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
