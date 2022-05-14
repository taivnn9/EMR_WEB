import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { CustomOverlayRef } from '../../public/overlay/CustomOverlayRef';

@Component({
  selector: 'KetQuaDichVuHisPro',
  templateUrl: './KetQuaDichVuHisPro.component.html'
})
export class KetQuaDichVuHisProComponent implements OnInit {
  cbLoc: boolean
  dtTu: Date
  dtDen: Date
  
  frmSubscribe = this.fb.group({
    name: 'John Doe',
    email: [
      'johndoe@gmail.com',
      Validators.compose([Validators.email, Validators.required])
    ]
  });

  constructor(private fb: FormBuilder, private ref: CustomOverlayRef) {}

  ngOnInit() {}
  
  btLoc(){

  }
  ckAll(){
    
  }
  submit() {
    this.ref.close(this.frmSubscribe.value);
  }

  cancel() {
    this.ref.close(null);
  }
}
