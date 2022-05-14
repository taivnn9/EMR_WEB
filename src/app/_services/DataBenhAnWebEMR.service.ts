import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { environment } from '@environments/environment';

@Injectable({ providedIn: 'root' })
export class DataBenhAnWebEMRService {
    noAuthHeader = { headers: new HttpHeaders({ 'NoAuth': 'True' }) };

    constructor(private http: HttpClient) {}

    GetKetQuaCLSHisPro(maBenhAn: string){
        const userLogin: string = environment.UserLogin;
        const passLogin: string = environment.PassLogin;

        return this.http.post<any>(`${environment.URL_EMR}/api/EMRWeb/DataBenhAnWebEMR/GetKetQuaCLSHisPro?userLogin=${userLogin}&passLogin=${passLogin}&maBenhAn=${maBenhAn}`, null);
    }
    
    GetPhieuDieuTriHisPro(maBenhAn: string){
        const userLogin: string = environment.UserLogin;
        const passLogin: string = environment.PassLogin;

        return this.http.post<any>(`${environment.URL_EMR}/api/EMRWeb/DataBenhAnWebEMR/GetPhieuDieuTriHisPro?userLogin=${userLogin}&passLogin=${passLogin}&maBenhAn=${maBenhAn}`, null);
    }
    
}