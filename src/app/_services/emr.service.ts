import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map } from 'rxjs/operators';

import { environment } from '@environments/environment';
import { ThongTinHoSoBenhAn } from '@app/_models/EMR_MAIN/XemBenhAn/xemBenhAn';

@Injectable({ providedIn: 'root' })
export class EmrService {
    ThongTinHoSoBenhAn: ThongTinHoSoBenhAn
    noAuthHeader = { headers: new HttpHeaders({ 'NoAuth': 'True' }) };

    constructor(private http: HttpClient) {}

    GetDataBenhAnPromise(): Promise<any> {
        return this.GetDataBenhAn().toPromise().then(
            (data: any) => {
                this.ThongTinHoSoBenhAn = data.Data;
            },
            error => {
                console.error(error);
            });
    }
    async SetDataBenhAn(){
        await this.GetDataBenhAn().toPromise().then(
            (data: any) => {
                this.ThongTinHoSoBenhAn = data.Data;
            },
            error => {
                console.error(error);
            });
    }
    DaKhoiTao(): boolean{
        return this.GetIdBenhAn() != null;
    }
    
    GetIdBenhAn(): string{
        return localStorage.getItem(`${environment.IDBenhAn}`)
    }
    
    SetIdBenhAn(IDBenhAn: string){
        localStorage.setItem(`${environment.IDBenhAn}`, IDBenhAn);
    }

    GetDataBenhAn(){
        const IDBenhAn = this.GetIdBenhAn();
        return this.http.get<ThongTinHoSoBenhAn>(`${environment.URL_EMR}/api/EMRWeb/DataBenhAnWebEMR/GetDataBenhAn?IDBenhAn=${IDBenhAn}`);
    }

    
    BenhAnSave(ThongTinHoSoBenhAn: ThongTinHoSoBenhAn){
        const IDBenhAn = this.GetIdBenhAn();
        return this.http.post<any>(`${environment.URL_EMR}/api/BenhAn/Save?IDBenhAn=${IDBenhAn}`, ThongTinHoSoBenhAn);
    }


    PrintWebEMR(ThongTinHoSoBenhAn: ThongTinHoSoBenhAn, loaiDataIn: string){
        const IDBenhAn = this.GetIdBenhAn();
        return this.http.post<any>(`${environment.URL_EMR}/api/BenhAn/PrintWebEMR?IDBenhAn=${IDBenhAn}&loaiDataIn=${loaiDataIn}`, ThongTinHoSoBenhAn);
    }

}