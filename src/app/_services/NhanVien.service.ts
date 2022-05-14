import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '@environments/environment';
import { NhanVien } from '@app/_models/EMR_MAIN/BenhVien/nhanVien';

@Injectable({ providedIn: 'root' })
export class NhanVienService {
    noAuthHeader = { headers: new HttpHeaders({ 'NoAuth': 'True' }) };

    constructor(private http: HttpClient) {}

    
    ListNhanVien(){
        return this.http.get<NhanVien>(`${environment.URL_EMR}/api/Other/NhanVienController/ListNhanVien`);
    }
    
    ListNguoiNhanHoSo(){
        return this.http.get<NhanVien>(`${environment.URL_EMR}/api/Other/NhanVienController/ListNguoiNhanHoSo`);
    }
}