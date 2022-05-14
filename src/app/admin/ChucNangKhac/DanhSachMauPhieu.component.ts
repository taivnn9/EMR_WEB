import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { DanhSachPhieu } from '@app/_models/EMR_MAIN/danhSachPhieu';
import { CustomOverlayRef } from '../../public/overlay/CustomOverlayRef';

@Component({
  selector: 'DanhSachMauPhieu',
  templateUrl: './DanhSachMauPhieu.component.html'
})
export class DanhSachMauPhieuComponent implements OnInit {

  txtTimKiem: string
  cbPhieuDaTao: boolean
  DanhSachPhieu: DanhSachPhieu[] = []
  
  constructor(private fb: FormBuilder, private ref: CustomOverlayRef) {}

  ngOnInit() {}
  

  submit() {
    this.ref.close('this.frmSubscribe.value');
  }

  cancel() {
    this.ref.close(null);
  }

  btnTimKiem(){

  }
}
