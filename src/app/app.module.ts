import { APP_INITIALIZER, CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

// used to create fake backend
import { CommonInterceptor, FakeBackendInterceptor } from './_helpers';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app.routing';

import {  ErrorInterceptor } from './_helpers';



import { NgxExtendedPdfViewerModule } from 'ngx-extended-pdf-viewer';
// import { NgOtpInputModule } from  'ng-otp-input';
// import { NgSelectModule } from '@ng-select/ng-select';
import { AngularMyDatePickerModule } from 'angular-mydatepicker';
import { NgxDocViewerModule } from 'ngx-doc-viewer';
import { PdfJsViewerModule } from 'ng2-pdfjs-viewer';
import { OverlayModule } from '@angular/cdk/overlay';

import { SafePipe} from './public';
import { HoiBenhBaseComponent } from './admin/HoiBenh/HoiBenhBase.component';
import { KhamBenhBaseComponent } from './admin/KhamBenh/KhamBenhBase.component';
import { TongKetBaseComponent } from './admin/TongKet/TongKetBase.component';
import { MainWindowComponent } from './admin/MainWindow';
import { HanhChinhBaseComponent } from './admin/HanhChinh/HanhChinhBase.component';
import { HanhChinh_NoiTruYHCT } from './admin/HanhChinh/HanhChinh_NoiTruYHCT.component';
import { HanhChinh_BenhAnSanKhoa } from './admin/HanhChinh/HanhChinh_BenhAnSanKhoa.component';

import { HanhChinh_ThanNhanTao } from './admin/HanhChinh/HanhChinh_ThanNhanTao.component';
import { HoiBenh_ThanNhanTao } from './admin/HoiBenh/HoiBenh_ThanNhanTao.component';
import { KhamBenh_ThanNhanTao } from './admin/KhamBenh/KhamBenh_ThanNhanTao.component';

import { HanhChinh_NgoaiTruYHCT } from './admin/HanhChinh/HanhChinh_NgoaiTruYHCT.component';
import { HoiBenh_NoiTruYHCT } from './admin/HoiBenh/HoiBenh_NoiTruYHCT.component';
import { HoiBenh_BenhAnSanKhoa } from './admin/HoiBenh/HoiBenh_BenhAnSanKhoa.component';
import { HoiBenh_RangHamMat } from './admin/HoiBenh/HoiBenh_RangHamMat.component';
import { KhamBenh_NoiTruYHCT } from './admin/KhamBenh/KhamBenh_NoiTruYHCT.component';
import { KhamBenh_BenhAnSanKhoa } from './admin/KhamBenh/KhamBenh_BenhAnSanKhoa.component';
import { KhamBenh_RangHamMat } from './admin/KhamBenh/KhamBenh_RangHamMat.component';
import { TongKet_NoiTruYHCT } from './admin/TongKet/TongKet_NoiTruYHCT.component';
import { TongKet_BenhAnSanKhoa } from './admin/TongKet/TongKet_BenhAnSanKhoa.component';
import { TongKet_RangHamMat } from './admin/TongKet/TongKet_RangHamMat.component';
import { HoiBenh_NgoaiTruYHCT } from './admin/HoiBenh/HoiBenh_NgoaiTruYHCT.component';
import { KhamBenh_NoiTruYHCT } from './admin/KhamBenh/KhamBenh_NoiTruYHCT.component';
import { KhamBenh_BenhAnSanKhoa } from './admin/KhamBenh/KhamBenh_BenhAnSanKhoa.component';
import { KhamBenh_NgoaiTruYHCT } from './admin/KhamBenh/KhamBenh_NgoaiTruYHCT.component';

import { TongKet_NoiTruYHCT } from './admin/TongKet/TongKet_NoiTruYHCT.component';
import { TongKet_BenhAnSanKhoa } from './admin/TongKet/TongKet_BenhAnSanKhoa.component';
import { TongKet_NgoaiTruYHCT } from './admin/TongKet/TongKet_NgoaiTruYHCT.component';
import { EmrService } from './_services/emr.service';
import { PdfViewerComponent } from './public/pdfviewer/pdfviewer.component';
import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner';
import { NgSelectModule } from './public/ng-select/lib/ng-select.module';
import { DataSourceBackendExampleComponent } from './public/ng-select/examples/data-source-backend-example/data-source-backend-example.component';
import { VirtualScrollExampleComponent } from './public/ng-select/examples/virtual-scroll-example/virtual-scroll-example.component';
import { KhoiTaoComponent } from './admin/KhoiTao/KhoiTao.component';
import { OverlayComponent } from './public/overlay/overlay.component';
import { KetQuaToDieuTriHisProComponent } from './admin/ChucNangKhac/KetQuaToDieuTriHisPro.component';
import { KetQuaDichVuHisProComponent } from './admin/ChucNangKhac/KetQuaDichVuHisPro.component';
import { DanhSachMauPhieuComponent } from './admin/ChucNangKhac/DanhSachMauPhieu.component';
import { HanhChinh_Base } from './admin/HanhChinh/HanhChinh_Base.component';
import { HoiBenh_NoiKhoa } from './admin/HoiBenh/HoiBenh_NoiKhoa.component';
import { KhamBenh_NoiKhoa } from './admin/KhamBenh/KhamBenh_NoiKhoa.component';
import { TongKet_NoiKhoa } from './admin/TongKet/TongKet_NoiKhoa.component';
import { TongKet_DaLieu } from './admin/TongKet/TongKet_DaLieu.component';
import { TongKet_ThanNhanTao } from './admin/TongKet/TongKet_ThanNhanTao.component';
import { KhamBenh_DaLieu } from './admin/KhamBenh/KhamBenh_DaLieu.component';
import { HoiBenh_DaLieu } from './admin/HoiBenh/HoiBenh_DaLieu.component';
import { HoiBenh_Bong } from './admin/HoiBenh/HoiBenh_Bong.component';
import { KhamBenh_Bong } from './admin/KhamBenh/KhamBenh_Bong.component';
import { TongKet_Bong } from './admin/TongKet/TongKet_Bong.component';
import { HoiBenh_Tim } from './admin/HoiBenh/HoiBenh_Tim.component';
import { KhamBenh_Tim } from './admin/KhamBenh/KhamBenh_Tim.component';



@NgModule({
  declarations: [
    AppComponent,
    KhoiTaoComponent,
    SafePipe,

    MainWindowComponent,

    // Hành chính
    HanhChinhBaseComponent,
    HanhChinh_NoiTruYHCT,
    HanhChinh_Base,
    HanhChinh_BenhAnSanKhoa,
    HanhChinh_ThanNhanTao,
    HanhChinh_NgoaiTruYHCT,


    // Hỏi bệnh
    HoiBenhBaseComponent,
    HoiBenh_NoiTruYHCT,
    HoiBenh_NoiKhoa,
    HoiBenh_BenhAnSanKhoa,
    HoiBenh_DaLieu,
    HoiBenh_RangHamMat,
    
    HoiBenh_ThanNhanTao,
    HoiBenh_Bong,
    HoiBenh_Tim,
    HoiBenh_NgoaiTruYHCT,


    // Khám bệnh
    KhamBenhBaseComponent,
    KhamBenh_NoiTruYHCT,
    KhamBenh_NoiKhoa,
    KhamBenh_BenhAnSanKhoa,
    KhamBenh_RangHamMat,
    KhamBenh_DaLieu,
    KhamBenh_ThanNhanTao,
    KhamBenh_Bong,
    KhamBenh_Tim,
    KhamBenh_NgoaiTruYHCT,


    // Tổng kết
    TongKetBaseComponent,
    TongKet_NoiTruYHCT,
    TongKet_NoiKhoa,
    TongKet_BenhAnSanKhoa,
    TongKet_RangHamMat,
    TongKet_DaLieu,
    TongKet_ThanNhanTao,
    TongKet_Bong,
    TongKet_NgoaiTruYHCT,

    
    PdfViewerComponent,
    VirtualScrollExampleComponent,
    DataSourceBackendExampleComponent,
    OverlayComponent,
    // Chuc nang khac
    KetQuaToDieuTriHisProComponent,
    KetQuaDichVuHisProComponent,
    DanhSachMauPhieuComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    AppRoutingModule,
    NgxExtendedPdfViewerModule,
    // NgOtpInputModule,
    NgSelectModule,
    AngularMyDatePickerModule,
    NgxDocViewerModule,
    PdfJsViewerModule,
    ToastrModule.forRoot(),
    NgxSpinnerModule,
    OverlayModule,
  ],
  providers: [

    { provide: HTTP_INTERCEPTORS, useClass: CommonInterceptor, multi: true },
    // { provide: HTTP_INTERCEPTORS, useClass: FakeBackendInterceptor, multi: true },
    // { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },

    // EmrService,
    // {
    //   provide: APP_INITIALIZER,
    //   useFactory: (service: EmrService) => function() { return service.GetDataBenhAnPromise(); },
    //   deps: [EmrService],
    //   multi: true
    // },
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  bootstrap: [AppComponent],
  entryComponents: [OverlayComponent]
})
export class AppModule { }
