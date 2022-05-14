using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN
{
    public class BenhAnTayChanMiengFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnTayChanMieng a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnTayChanMieng" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnTayChanMieng.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                    @"
                  select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnTayChanMieng a 
                 left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien c on a.bacsydieutri = c.manhanvien
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien e on a.nguoinhanhoso = e.manhanvien
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");


            string sql2 =
                @"   select a.*,c.hovaten BacSyPhauThuatHoVaTen, d.hovaten BacSyGayMeHoVaTen
                  from PhauThuatThuThuat a
                  left join nhanvien c on a.bacsyphauthuat  = c.manhanvien
                  left join nhanvien d on a.bacsygayme= d.manhanvien
                  where a.maquanly = '" + MaQuanLy + "' AND ROWNUM <= 4";
            adt = new MDB.MDBDataAdapter(sql2, MyConnection);
            adt.Fill(ds, "Table2");

            string sql3 =
                         @"   select a.*
            from TienSuSanKhoa a
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);

            adt = new MDB.MDBDataAdapter(sql3, MyConnection);
            adt.Fill(ds, "Table3");
            List<PhauThuatThuThuat> listEkip = PhauThuatThuThuatFunc.GetListPhauThuatThuThuat(MyConnection, MaQuanLy);
            DataTable dt = new DataTable("ListEkip");
            dt.Columns.Add("NgayGioThucHien");
            dt.Columns.Add("PhuongPhapPhauThuat");
            dt.Columns.Add("PhauThuatVien");
            dt.Columns.Add("BacSyGayMe");
            for (int i = 0; i < listEkip.Count; i++)
            {
                PhauThuatThuThuat ekip = listEkip[i];
                DataRow row = dt.NewRow();
                row[0] = "";
                row[1] = "";
                row[2] = "";
                row[3] = "";
                row[0] = ekip.NgayPhauThuatThuThuat;
                if (ekip.PhuongPhapPhauThuatThuThuat != null)
                {
                    row[1] = ekip.PhuongPhapPhauThuatThuThuat;

                }
                else if (ekip.PhuongPhapVoCam != null)
                {
                    row[1] = ekip.PhuongPhapVoCam;
                }
                if (ekip.BacSyPhauThuatHoVaTen != null)
                {
                    row[2] = ekip.BacSyPhauThuatHoVaTen;
                }
                if (ekip.BacSyGayMeHoVaTen != null)
                {
                    row[3] = ekip.BacSyGayMeHoVaTen;
                }
                dt.Rows.Add(row);
            }

            ds.Merge(dt);

            return ds;
        }
        public static BenhAnTayChanMieng Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnTayChanMieng
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnTayChanMieng();
            while (DataReader.Read())
            {
                value.ID = DataReader.GetLong("id");
                value.MaQuanLy = DataReader.GetDecimal("maquanly");
                value.LyDoVaoVien = DataReader.GetString("lydovaovien");
                value.VaoNgayThu = DataReader.GetInt("vaongaythu");
                value.TrieuTrung = DataReader.GetString("trieutrung");
                value.TrieuTrung_GiatMinh_SoLan = DataReader.GetString("trieutrung_giatminh_solan");
                value.BenhLy_DauHieuKhac = DataReader.GetString("benhly_dauhieukhac");
                value.BenhLy_DichTe = DataReader.GetString("benhly_dichte");
                value.DichTe_DiHoc = DataReader.GetInt("dichte_dihoc");
                value.DichTe_DiaChiTruong = DataReader.GetString("dichte_diachitruong");
                value.DichTe = DataReader.GetString("dichte");
                value.DieuTriTuyenTruoc = DataReader.GetString("dieutrituyentruoc");
                value.BenhLy_Khac = DataReader.GetString("benhly_khac");
                value.TienSuBenhBanThan = DataReader.GetString("tiensubenhbanthan");
                value.TienSuBenhGiaDinh = DataReader.GetString("tiensubenhgiadinh");
                value.SinhTruong_ConThuMay = DataReader.GetInt("sinhtruong_conthumay");
                value.TienThaiPara = DataReader.GetString("tienthaipara");
                value.CanNangLucSinh = DataReader.GetInt("cannanglucsinh");
                value.DiTatBamSinh = DataReader.GetString("ditatbamsinh");
                value.PTTinhThan = DataReader.GetString("pttinhthan");
                value.PTVanDong = DataReader.GetString("ptvandong");
                value.CacBenhLyKhac = DataReader.GetString("cacbenhlykhac");
                value.NuoiDuong = DataReader.GetString("nuoiduong");
                value.NuoiDuong_CaiSua = DataReader.GetString("nuoiduong_caisua");
                value.ChamSoc = DataReader.GetInt("chamsoc");
                value.TiemChung = DataReader.GetString("tiemchung");
                value.SinhTruong_Khac = DataReader.GetString("sinhtruong_khac");
                value.ChieuCao = DataReader.GetString("chieucao");
                value.VongNguc = DataReader.GetString("vongnguc");
                value.VongDau = DataReader.GetString("vongdau");
                value.SPO2 = DataReader.GetString("spo2");
                value.TriGiac = DataReader.GetString("trigiac");
                value.TuanHoan_Tim = DataReader.GetInt("tuanhoan_tim");
                value.TuanHoan_TimAmThoi = DataReader.GetString("tuanhoan_timamthoi");
                value.ThoiGianDayMaoMach = DataReader.GetString("thoigiandaymaomach");
                value.DauHieuTinhMach = DataReader.GetInt("dauhieutinhmach");
                value.VaMoHoi = DataReader.GetInt("vamohoi");
                value.DaNoiBong = DataReader.GetInt("danoibong");
                value.DauHieuKhac_Tim = DataReader.GetString("dauhieukhac_tim");
                value.CacCoQuan_HoHap = DataReader.GetString("caccoquan_hohap");
                value.RanPhoi = DataReader.GetString("ranphoi");
                value.DauHieuKhac_HoHap = DataReader.GetString("dauhieukhac_hohap");
                value.GanTo_TieuHoa = DataReader.GetString("ganto_tieuhoa");
                value.DBS_TieuHoa = DataReader.GetString("dbs_tieuhoa");
                value.DauHieuKhac_TieuHoa = DataReader.GetString("dauhieukhac_tieuhoa");
                value.ThanTietNieuSinhDuc = DataReader.GetString("thantietnieusinhduc");
                value.DongTu = DataReader.GetString("dongtu");
                value.PXAS = DataReader.GetString("pxas");
                value.CacCoQuan_ThanKinh = DataReader.GetString("caccoquan_thankinh");
                value.DauHieuKhac_ThanKinh = DataReader.GetString("dauhieukhac_thankinh");
                value.CoXuongKhop = DataReader.GetString("coxuongkhop");
                value.TMHRHMCoQuanKhac = DataReader.GetString("tmhrhmcoquankhac");
                value.CacXNCanLamSang = DataReader.GetString("cacxncanlamsang");
                value.NgayBenh = DataReader.GetInt("ngaybenh");
                value.TTBenhAn = DataReader.GetString("ttbenhan");
                value.DauHieuKhac_TTBenhAn = DataReader.GetString("dauhieukhac_ttbenhan");
                value.ChanDoanBenhChinh = DataReader.GetString("chandoanbenhchinh");
                value.MaICD10 = DataReader.GetString("maicd10");
                value.BenhKem_ChanDoan = DataReader.GetString("benhkem_chandoan");
                value.MaICD10BenhKem = DataReader.GetString("maicd10benhkem");
                value.PhanBiet_ChanDoan = DataReader.GetString("phanbiet_chandoan");
                value.HuongDieuTriArr = DataReader.GetString("HuongDieuTriArr");
                value.TienLuong = DataReader.GetString("tienluong");
                value.HuongDieuTriKhac = DataReader.GetString("huongdieutrikhac");
                value.NgayKhamBenh = DataReader.GetDate("ngaykhambenh");
                value.BacSyLamBenhAn = DataReader.GetString("bacsylambenhan");
                value.MaNVBacSyLamBenhAn = DataReader.GetString("manvbacsylambenhan");
                value.TongKet_KetQuaXetNghiem = DataReader.GetString("tongket_ketquaxetnghiem");
                value.TongKet_QuaTrinhBenhLy = DataReader.GetString("tongket_quatrinhbenhly");
                value.TongKet_DieuTri = DataReader.GetString("tongket_dieutri");
                value.TongKet_TTRaVien = DataReader.GetString("tongket_ttravien");
                value.TongKet_HuongDieuTri = DataReader.GetString("tongket_huongdieutri");
                //
                value.TenThuoc1 = Common.ConDBNull(DataReader["TenThuoc1"]);
                value.TSDU1 = Common.ConDB_Int(DataReader["TSDU1"]);
                value.SoLan1 = Common.ConDBNull(DataReader["SoLan1"]);
                value.BHLS1 = Common.ConDBNull(DataReader["BHLS1"]);
                value.TenThuoc2 = Common.ConDBNull(DataReader["TenThuoc2"]);
                value.TSDU2 = Common.ConDB_Int(DataReader["TSDU2"]);
                value.SoLan2 = Common.ConDBNull(DataReader["SoLan2"]);
                value.BHLS2 = Common.ConDBNull(DataReader["BHLS2"]);
                value.TenThuoc3 = Common.ConDBNull(DataReader["TenThuoc3"]);
                value.TSDU3 = Common.ConDB_Int(DataReader["TSDU3"]);
                value.SoLan3 = Common.ConDBNull(DataReader["SoLan3"]);
                value.BHLS3 = Common.ConDBNull(DataReader["BHLS3"]);
                value.TenThuoc4 = Common.ConDBNull(DataReader["TenThuoc4"]);
                value.TSDU4 = Common.ConDB_Int(DataReader["TSDU4"]);
                value.SoLan4 = Common.ConDBNull(DataReader["SoLan4"]);
                value.BHLS4 = Common.ConDBNull(DataReader["BHLS4"]);
                value.TenThuoc5 = Common.ConDBNull(DataReader["TenThuoc5"]);
                value.TSDU5 = Common.ConDB_Int(DataReader["TSDU5"]);
                value.SoLan5 = Common.ConDBNull(DataReader["SoLan5"]);
                value.BHLS5 = Common.ConDBNull(DataReader["BHLS5"]);
                value.TenThuoc6 = Common.ConDBNull(DataReader["TenThuoc6"]);
                value.TSDU6 = Common.ConDB_Int(DataReader["TSDU6"]);
                value.SoLan6 = Common.ConDBNull(DataReader["SoLan6"]);
                value.BHLS6 = Common.ConDBNull(DataReader["BHLS6"]);
                value.DiTatBamSinh_Co = Common.ConDB_Int(DataReader["DiTatBamSinh_Co"]);
                value.ToanThan_Khac= DataReader.GetString("ToanThan_Khac");
                value.GanTo_TieuHoaCo = Common.ConDB_Int(DataReader["GanTo_TieuHoaCo"]);
                value.QuaTrinhBenhLyVaDienBien = Common.ConDBNull(DataReader["QuaTrinhBenhLyVaDienBien"]);
                value.TomTatKetQuaXetNghiem = Common.ConDBNull(DataReader["TomTatKetQuaXetNghiem"]);
                value.PhuongPhapDieuTri = Common.ConDBNull(DataReader["PhuongPhapDieuTri"]);
                value.TinhTrangNguoiBenhRaVien = Common.ConDBNull(DataReader["TinhTrangNguoiBenhRaVien"]);
                value.HuongDieuTriVaCacCheDoTiepTheo = Common.ConDBNull(DataReader["HuongDieuTriVaCacCheDoTiepTheo"]);
                value.NguoiGiaoHoSo = Common.ConDBNull(DataReader["NguoiGiaoHoSo"]);
                value.NguoiNhanHoSo = Common.ConDBNull(DataReader["NguoiNhanHoSo"]);
                value.BacSyDieuTri = Common.ConDBNull(DataReader["BacSyDieuTri"]);
                value.NgayTongKet = Common.ConDB_DateTime(DataReader["NgayTongKet"]);
                value.HinhVeTonThuongKhiVaoVien = ERMDatabase.FTPImageString + DataReader["HinhVeTonThuongKhiVaoVien"].ToString();
                //
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnTayChanMieng valueData)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnTayChanMieng
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", valueData.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, valueData);
            sql = @"
                   INSERT INTO BenhAnTayChanMieng (
                                            maquanly,
                                            lydovaovien,
                                            vaongaythu,
                                            trieutrung,
                                            trieutrung_giatminh_solan,
                                            benhly_dauhieukhac,
                                            benhly_dichte,
                                            dichte_dihoc,
                                            dichte_diachitruong,
                                            dichte,
                                            dieutrituyentruoc,
                                            benhly_khac,
                                            tiensubenhbanthan,
                                            tiensubenhgiadinh,
                                            sinhtruong_conthumay,
                                            tienthaipara,
                                            cannanglucsinh,
                                            ditatbamsinh,
                                            pttinhthan,
                                            ptvandong,
                                            cacbenhlykhac,
                                            nuoiduong,
                                            nuoiduong_caisua,
                                            chamsoc,
                                            tiemchung,
                                            sinhtruong_khac,
                                            chieucao,
                                            vongnguc,
                                            vongdau,
                                            spo2,
                                            trigiac,
                                            tuanhoan_tim,
                                            tuanhoan_timamthoi,
                                            thoigiandaymaomach,
                                            dauhieutinhmach,
                                            vamohoi,
                                            danoibong,
                                            dauhieukhac_tim,
                                            caccoquan_hohap,
                                            ranphoi,
                                            dauhieukhac_hohap,
                                            ganto_tieuhoa,
                                            dbs_tieuhoa,
                                            dauhieukhac_tieuhoa,
                                            thantietnieusinhduc,
                                            dongtu,
                                            pxas,
                                            caccoquan_thankinh,
                                            dauhieukhac_thankinh,
                                            coxuongkhop,
                                            tmhrhmcoquankhac,
                                            cacxncanlamsang,
                                            ngaybenh,
                                            ttbenhan,
                                            dauhieukhac_ttbenhan,
                                            chandoanbenhchinh,
                                            maicd10,
                                            benhkem_chandoan,
                                            maicd10benhkem,
                                            phanbiet_chandoan,
                                            HuongDieuTriArr,
                                            tienluong,
                                            huongdieutrikhac,
                                            ngaykhambenh,
                                            bacsylambenhan,
                                            manvbacsylambenhan,
                                            tongket_ketquaxetnghiem,
                                            tongket_quatrinhbenhly,
                                            tongket_dieutri,
                                            tongket_ttravien,
                                            tongket_huongdieutri,
                                            TenThuoc1,
                                            TSDU1,
                                            SoLan1,
                                            BHLS1,
                                            TenThuoc2,
                                            TSDU2,
                                            SoLan2,
                                            BHLS2,
                                            TenThuoc3,
                                            TSDU3,
                                            SoLan3,
                                            BHLS3,
                                            TenThuoc4,
                                            TSDU4,
                                            SoLan4,
                                            BHLS4,
                                            TenThuoc5,
                                            TSDU5,
                                            SoLan5,
                                            BHLS5,
                                            TenThuoc6,
                                            TSDU6,
                                            SoLan6,
                                            BHLS6,
                                            DiTatBamSinh_Co,
                                            ToanThan_Khac,
                                            GanTo_TieuHoaCo,
                                            QuaTrinhBenhLyVaDienBien,
                                            TomTatKetQuaXetNghiem,
                                            PhuongPhapDieuTri,
                                            TinhTrangNguoiBenhRaVien,
                                            HuongDieuTriVaCacCheDoTiepTheo,
                                            NguoiGiaoHoSo,
                                            NguoiNhanHoSo,
                                            BacSyDieuTri,
                                            NgayTongKet,
                                            HinhVeTonThuongKhiVaoVien
                                            )
                                   VALUES(
                                    :maquanly,
                                    :lydovaovien,
                                    :vaongaythu,
                                    :trieutrung,
                                    :trieutrung_giatminh_solan,
                                    :benhly_dauhieukhac,
                                    :benhly_dichte,
                                    :dichte_dihoc,
                                    :dichte_diachitruong,
                                    :dichte,
                                    :dieutrituyentruoc,
                                    :benhly_khac,
                                    :tiensubenhbanthan,
                                    :tiensubenhgiadinh,
                                    :sinhtruong_conthumay,
                                    :tienthaipara,
                                    :cannanglucsinh,
                                    :ditatbamsinh,
                                    :pttinhthan,
                                    :ptvandong,
                                    :cacbenhlykhac,
                                    :nuoiduong,
                                    :nuoiduong_caisua,
                                    :chamsoc,
                                    :tiemchung,
                                    :sinhtruong_khac,
                                    :chieucao,
                                    :vongnguc,
                                    :vongdau,
                                    :spo2,
                                    :trigiac,
                                    :tuanhoan_tim,
                                    :tuanhoan_timamthoi,
                                    :thoigiandaymaomach,
                                    :dauhieutinhmach,
                                    :vamohoi,
                                    :danoibong,
                                    :dauhieukhac_tim,
                                    :caccoquan_hohap,
                                    :ranphoi,
                                    :dauhieukhac_hohap,
                                    :ganto_tieuhoa,
                                    :dbs_tieuhoa,
                                    :dauhieukhac_tieuhoa,
                                    :thantietnieusinhduc,
                                    :dongtu,
                                    :pxas,
                                    :caccoquan_thankinh,
                                    :dauhieukhac_thankinh,
                                    :coxuongkhop,
                                    :tmhrhmcoquankhac,
                                    :cacxncanlamsang,
                                    :ngaybenh,
                                    :ttbenhan,
                                    :dauhieukhac_ttbenhan,
                                    :chandoanbenhchinh,
                                    :maicd10,
                                    :benhkem_chandoan,
                                    :maicd10benhkem,
                                    :phanbiet_chandoan,
                                    :HuongDieuTriArr,
                                    :tienluong,
                                    :huongdieutrikhac,
                                    :ngaykhambenh,
                                    :bacsylambenhan,
                                    :manvbacsylambenhan,
                                    :tongket_ketquaxetnghiem,
                                    :tongket_quatrinhbenhly,
                                    :tongket_dieutri,
                                    :tongket_ttravien,
                                    :tongket_huongdieutri,
                                    :TenThuoc1,
                                    :TSDU1,
                                    :SoLan1,
                                    :BHLS1,
                                    :TenThuoc2,
                                    :TSDU2,
                                    :SoLan2,
                                    :BHLS2,
                                    :TenThuoc3,
                                    :TSDU3,
                                    :SoLan3,
                                    :BHLS3,
                                    :TenThuoc4,
                                    :TSDU4,
                                    :SoLan4,
                                    :BHLS4,
                                    :TenThuoc5,
                                    :TSDU5,
                                    :SoLan5,
                                    :BHLS5,
                                    :TenThuoc6,
                                    :TSDU6,
                                    :SoLan6,
                                    :BHLS6,
                                    :DiTatBamSinh_Co,
                                    :ToanThan_Khac,
                                    :GanTo_TieuHoaCo,
                                    :QuaTrinhBenhLyVaDienBien,
                                    :TomTatKetQuaXetNghiem,
                                    :PhuongPhapDieuTri,
                                    :TinhTrangNguoiBenhRaVien,
                                    :HuongDieuTriVaCacCheDoTiepTheo,
                                    :NguoiGiaoHoSo,
                                    :NguoiNhanHoSo,
                                    :BacSyDieuTri,
                                    :NgayTongKet,
                                    :HinhVeTonThuongKhiVaoVien
                                    )
                                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("maquanly", valueData.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("lydovaovien", valueData.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("vaongaythu", valueData.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("trieutrung", valueData.TrieuTrung));
            Command.Parameters.Add(new MDB.MDBParameter("trieutrung_giatminh_solan", valueData.TrieuTrung_GiatMinh_SoLan));
            Command.Parameters.Add(new MDB.MDBParameter("benhly_dauhieukhac", valueData.BenhLy_DauHieuKhac));
            Command.Parameters.Add(new MDB.MDBParameter("benhly_dichte", valueData.BenhLy_DichTe));
            Command.Parameters.Add(new MDB.MDBParameter("dichte_dihoc", valueData.DichTe_DiHoc));
            Command.Parameters.Add(new MDB.MDBParameter("dichte_diachitruong", valueData.DichTe_DiaChiTruong));
            Command.Parameters.Add(new MDB.MDBParameter("dichte", valueData.DichTe));
            Command.Parameters.Add(new MDB.MDBParameter("dieutrituyentruoc", valueData.DieuTriTuyenTruoc));
            Command.Parameters.Add(new MDB.MDBParameter("benhly_khac", valueData.BenhLy_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("tiensubenhbanthan", valueData.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("tiensubenhgiadinh", valueData.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("sinhtruong_conthumay", valueData.SinhTruong_ConThuMay));
            Command.Parameters.Add(new MDB.MDBParameter("tienthaipara", valueData.TienThaiPara));
            Command.Parameters.Add(new MDB.MDBParameter("cannanglucsinh", valueData.CanNangLucSinh));
            Command.Parameters.Add(new MDB.MDBParameter("ditatbamsinh", valueData.DiTatBamSinh));
            Command.Parameters.Add(new MDB.MDBParameter("pttinhthan", valueData.PTTinhThan));
            Command.Parameters.Add(new MDB.MDBParameter("ptvandong", valueData.PTVanDong));
            Command.Parameters.Add(new MDB.MDBParameter("cacbenhlykhac", valueData.CacBenhLyKhac));
            Command.Parameters.Add(new MDB.MDBParameter("nuoiduong", valueData.NuoiDuong));
            Command.Parameters.Add(new MDB.MDBParameter("nuoiduong_caisua", valueData.NuoiDuong_CaiSua));
            Command.Parameters.Add(new MDB.MDBParameter("chamsoc", valueData.ChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("tiemchung", valueData.TiemChung));
            Command.Parameters.Add(new MDB.MDBParameter("sinhtruong_khac", valueData.SinhTruong_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("chieucao", valueData.ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("vongnguc", valueData.VongNguc));
            Command.Parameters.Add(new MDB.MDBParameter("vongdau", valueData.VongDau));
            Command.Parameters.Add(new MDB.MDBParameter("spo2", valueData.SPO2));
            Command.Parameters.Add(new MDB.MDBParameter("trigiac", valueData.TriGiac));
            Command.Parameters.Add(new MDB.MDBParameter("tuanhoan_tim", valueData.TuanHoan_Tim));
            Command.Parameters.Add(new MDB.MDBParameter("tuanhoan_timamthoi", valueData.TuanHoan_TimAmThoi));
            Command.Parameters.Add(new MDB.MDBParameter("thoigiandaymaomach", valueData.ThoiGianDayMaoMach));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieutinhmach", valueData.DauHieuTinhMach));
            Command.Parameters.Add(new MDB.MDBParameter("vamohoi", valueData.VaMoHoi));
            Command.Parameters.Add(new MDB.MDBParameter("danoibong", valueData.DaNoiBong));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieukhac_tim", valueData.DauHieuKhac_Tim));
            Command.Parameters.Add(new MDB.MDBParameter("caccoquan_hohap", valueData.CacCoQuan_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("ranphoi", valueData.RanPhoi));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieukhac_hohap", valueData.DauHieuKhac_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("ganto_tieuhoa", valueData.GanTo_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("dbs_tieuhoa", valueData.DBS_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieukhac_tieuhoa", valueData.DauHieuKhac_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("thantietnieusinhduc", valueData.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("dongtu", valueData.DongTu));
            Command.Parameters.Add(new MDB.MDBParameter("pxas", valueData.PXAS));
            Command.Parameters.Add(new MDB.MDBParameter("caccoquan_thankinh", valueData.CacCoQuan_ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieukhac_thankinh", valueData.DauHieuKhac_ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("coxuongkhop", valueData.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("tmhrhmcoquankhac", valueData.TMHRHMCoQuanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("cacxncanlamsang", valueData.CacXNCanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ngaybenh", valueData.NgayBenh));
            Command.Parameters.Add(new MDB.MDBParameter("ttbenhan", valueData.TTBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieukhac_ttbenhan", valueData.DauHieuKhac_TTBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("chandoanbenhchinh", valueData.ChanDoanBenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("maicd10", valueData.MaICD10));
            Command.Parameters.Add(new MDB.MDBParameter("benhkem_chandoan", valueData.BenhKem_ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("maicd10benhkem", valueData.MaICD10BenhKem));
            Command.Parameters.Add(new MDB.MDBParameter("phanbiet_chandoan", valueData.PhanBiet_ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriArr", valueData.HuongDieuTriArr));
            Command.Parameters.Add(new MDB.MDBParameter("tienluong", valueData.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("huongdieutrikhac", valueData.HuongDieuTriKhac));
            Command.Parameters.Add(new MDB.MDBParameter("ngaykhambenh", valueData.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("bacsylambenhan", valueData.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("manvbacsylambenhan", valueData.MaNVBacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("tongket_ketquaxetnghiem", valueData.TongKet_KetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("tongket_quatrinhbenhly", valueData.TongKet_QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("tongket_dieutri", valueData.TongKet_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("tongket_ttravien", valueData.TongKet_TTRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("tongket_huongdieutri", valueData.TongKet_HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc1", valueData.TenThuoc1));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU1", valueData.TSDU1));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan1", valueData.SoLan1));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS1", valueData.BHLS1));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc2", valueData.TenThuoc2));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU2", valueData.TSDU2));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan2", valueData.SoLan2));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS2", valueData.BHLS2));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc3", valueData.TenThuoc3));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU3", valueData.TSDU3));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan3", valueData.SoLan3));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS3", valueData.BHLS3));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc4", valueData.TenThuoc4));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU4", valueData.TSDU4));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan4", valueData.SoLan4));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS4", valueData.BHLS4));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc5", valueData.TenThuoc5));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU5", valueData.TSDU5));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan5", valueData.SoLan5));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS5", valueData.BHLS5));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc6", valueData.TenThuoc6));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU6", valueData.TSDU6));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan6", valueData.SoLan6));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS6", valueData.BHLS6));
            Command.Parameters.Add(new MDB.MDBParameter("DiTatBamSinh_Co", valueData.DiTatBamSinh_Co));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Khac", valueData.ToanThan_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("GanTo_TieuHoaCo", valueData.GanTo_TieuHoaCo));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", valueData.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", valueData.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", valueData.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", valueData.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", valueData.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", valueData.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", valueData.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", valueData.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", valueData.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVeTonThuongKhiVaoVien", valueData.HinhVeTonThuongKhiVaoVien.Replace(ERMDatabase.FTPImageString, "")));

            Command.BindByName = true;

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnTayChanMieng valueData)
        {
            string sql = @"UPDATE BenhAnTayChanMieng SET 
                                    lydovaovien=:lydovaovien,
                                    vaongaythu=:vaongaythu,
                                    trieutrung=:trieutrung,
                                    trieutrung_giatminh_solan=:trieutrung_giatminh_solan,
                                    benhly_dauhieukhac=:benhly_dauhieukhac,
                                    benhly_dichte=:benhly_dichte,
                                    dichte_dihoc=:dichte_dihoc,
                                    dichte_diachitruong=:dichte_diachitruong,
                                    dichte=:dichte,
                                    dieutrituyentruoc=:dieutrituyentruoc,
                                    benhly_khac=:benhly_khac,
                                    tiensubenhbanthan=:tiensubenhbanthan,
                                    tiensubenhgiadinh=:tiensubenhgiadinh,
                                    sinhtruong_conthumay=:sinhtruong_conthumay,
                                    tienthaipara=:tienthaipara,
                                    cannanglucsinh=:cannanglucsinh,
                                    ditatbamsinh=:ditatbamsinh,
                                    pttinhthan=:pttinhthan,
                                    ptvandong=:ptvandong,
                                    cacbenhlykhac=:cacbenhlykhac,
                                    nuoiduong=:nuoiduong,
                                    nuoiduong_caisua=:nuoiduong_caisua,
                                    chamsoc=:chamsoc,
                                    tiemchung=:tiemchung,
                                    sinhtruong_khac=:sinhtruong_khac,
                                    chieucao=:chieucao,
                                    vongnguc=:vongnguc,
                                    vongdau=:vongdau,
                                    spo2=:spo2,
                                    trigiac=:trigiac,
                                    tuanhoan_tim=:tuanhoan_tim,
                                    tuanhoan_timamthoi=:tuanhoan_timamthoi,
                                    thoigiandaymaomach=:thoigiandaymaomach,
                                    dauhieutinhmach=:dauhieutinhmach,
                                    vamohoi=:vamohoi,
                                    danoibong=:danoibong,
                                    dauhieukhac_tim=:dauhieukhac_tim,
                                    caccoquan_hohap=:caccoquan_hohap,
                                    ranphoi=:ranphoi,
                                    dauhieukhac_hohap=:dauhieukhac_hohap,
                                    ganto_tieuhoa=:ganto_tieuhoa,
                                    dbs_tieuhoa=:dbs_tieuhoa,
                                    dauhieukhac_tieuhoa=:dauhieukhac_tieuhoa,
                                    thantietnieusinhduc=:thantietnieusinhduc,
                                    dongtu=:dongtu,
                                    pxas=:pxas,
                                    caccoquan_thankinh=:caccoquan_thankinh,
                                    dauhieukhac_thankinh=:dauhieukhac_thankinh,
                                    coxuongkhop=:coxuongkhop,
                                    tmhrhmcoquankhac=:tmhrhmcoquankhac,
                                    cacxncanlamsang=:cacxncanlamsang,
                                    ngaybenh=:ngaybenh,
                                    ttbenhan=:ttbenhan,
                                    dauhieukhac_ttbenhan=:dauhieukhac_ttbenhan,
                                    chandoanbenhchinh=:chandoanbenhchinh,
                                    maicd10=:maicd10,
                                    benhkem_chandoan=:benhkem_chandoan,
                                    maicd10benhkem=:maicd10benhkem,
                                    phanbiet_chandoan=:phanbiet_chandoan,
                                    HuongDieuTriArr=:HuongDieuTriArr,
                                    tienluong=:tienluong,
                                    huongdieutrikhac=:huongdieutrikhac,
                                    ngaykhambenh=:ngaykhambenh,
                                    bacsylambenhan=:bacsylambenhan,
                                    manvbacsylambenhan=:manvbacsylambenhan,
                                    tongket_ketquaxetnghiem=:tongket_ketquaxetnghiem,
                                    tongket_quatrinhbenhly=:tongket_quatrinhbenhly,
                                    tongket_dieutri=:tongket_dieutri,
                                    tongket_ttravien=:tongket_ttravien,
                                    tongket_huongdieutri=:tongket_huongdieutri,
                                    TenThuoc1=:TenThuoc1,
                                    TSDU1=:TSDU1,
                                    SoLan1=:SoLan1,
                                    BHLS1=:BHLS1,
                                    TenThuoc2=:TenThuoc2,
                                    TSDU2=:TSDU2,
                                    SoLan2=:SoLan2,
                                    BHLS2=:BHLS2,
                                    TenThuoc3=:TenThuoc3,
                                    TSDU3=:TSDU3,
                                    SoLan3=:SoLan3,
                                    BHLS3=:BHLS3,
                                    TenThuoc4=:TenThuoc4,
                                    TSDU4=:TSDU4,
                                    SoLan4=:SoLan4,
                                    BHLS4=:BHLS4,
                                    TenThuoc5=:TenThuoc5,
                                    TSDU5=:TSDU5,
                                    SoLan5=:SoLan5,
                                    BHLS5=:BHLS5,
                                    TenThuoc6=:TenThuoc6,
                                    TSDU6=:TSDU6,
                                    SoLan6=:SoLan6,
                                    BHLS6=:BHLS6,
                                    DiTatBamSinh_Co=:DiTatBamSinh_Co,
                                    ToanThan_Khac=:ToanThan_Khac,
                                    GanTo_TieuHoaCo=:GanTo_TieuHoaCo,
                                    QuaTrinhBenhLyVaDienBien=:QuaTrinhBenhLyVaDienBien,
                                    TomTatKetQuaXetNghiem=:TomTatKetQuaXetNghiem,
                                    PhuongPhapDieuTri=:PhuongPhapDieuTri,
                                    TinhTrangNguoiBenhRaVien=:TinhTrangNguoiBenhRaVien,
                                    HuongDieuTriVaCacCheDoTiepTheo=:HuongDieuTriVaCacCheDoTiepTheo,
                                    NguoiGiaoHoSo=:NguoiGiaoHoSo,
                                    NguoiNhanHoSo=:NguoiNhanHoSo,
                                    BacSyDieuTri=:BacSyDieuTri,
                                    NgayTongKet=:NgayTongKet,
                                    HinhVeTonThuongKhiVaoVien=:HinhVeTonThuongKhiVaoVien
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("lydovaovien", valueData.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("vaongaythu", valueData.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("trieutrung", valueData.TrieuTrung));
            Command.Parameters.Add(new MDB.MDBParameter("trieutrung_giatminh_solan", valueData.TrieuTrung_GiatMinh_SoLan));
            Command.Parameters.Add(new MDB.MDBParameter("benhly_dauhieukhac", valueData.BenhLy_DauHieuKhac));
            Command.Parameters.Add(new MDB.MDBParameter("benhly_dichte", valueData.BenhLy_DichTe));
            Command.Parameters.Add(new MDB.MDBParameter("dichte_dihoc", valueData.DichTe_DiHoc));
            Command.Parameters.Add(new MDB.MDBParameter("dichte_diachitruong", valueData.DichTe_DiaChiTruong));
            Command.Parameters.Add(new MDB.MDBParameter("dichte", valueData.DichTe));
            Command.Parameters.Add(new MDB.MDBParameter("dieutrituyentruoc", valueData.DieuTriTuyenTruoc));
            Command.Parameters.Add(new MDB.MDBParameter("benhly_khac", valueData.BenhLy_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("tiensubenhbanthan", valueData.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("tiensubenhgiadinh", valueData.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("sinhtruong_conthumay", valueData.SinhTruong_ConThuMay));
            Command.Parameters.Add(new MDB.MDBParameter("tienthaipara", valueData.TienThaiPara));
            Command.Parameters.Add(new MDB.MDBParameter("cannanglucsinh", valueData.CanNangLucSinh));
            Command.Parameters.Add(new MDB.MDBParameter("ditatbamsinh", valueData.DiTatBamSinh));
            Command.Parameters.Add(new MDB.MDBParameter("pttinhthan", valueData.PTTinhThan));
            Command.Parameters.Add(new MDB.MDBParameter("ptvandong", valueData.PTVanDong));
            Command.Parameters.Add(new MDB.MDBParameter("cacbenhlykhac", valueData.CacBenhLyKhac));
            Command.Parameters.Add(new MDB.MDBParameter("nuoiduong", valueData.NuoiDuong));
            Command.Parameters.Add(new MDB.MDBParameter("nuoiduong_caisua", valueData.NuoiDuong_CaiSua));
            Command.Parameters.Add(new MDB.MDBParameter("chamsoc", valueData.ChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("tiemchung", valueData.TiemChung));
            Command.Parameters.Add(new MDB.MDBParameter("sinhtruong_khac", valueData.SinhTruong_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("chieucao", valueData.ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("vongnguc", valueData.VongNguc));
            Command.Parameters.Add(new MDB.MDBParameter("vongdau", valueData.VongDau));
            Command.Parameters.Add(new MDB.MDBParameter("spo2", valueData.SPO2));
            Command.Parameters.Add(new MDB.MDBParameter("trigiac", valueData.TriGiac));
            Command.Parameters.Add(new MDB.MDBParameter("tuanhoan_tim", valueData.TuanHoan_Tim));
            Command.Parameters.Add(new MDB.MDBParameter("tuanhoan_timamthoi", valueData.TuanHoan_TimAmThoi));
            Command.Parameters.Add(new MDB.MDBParameter("thoigiandaymaomach", valueData.ThoiGianDayMaoMach));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieutinhmach", valueData.DauHieuTinhMach));
            Command.Parameters.Add(new MDB.MDBParameter("vamohoi", valueData.VaMoHoi));
            Command.Parameters.Add(new MDB.MDBParameter("danoibong", valueData.DaNoiBong));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieukhac_tim", valueData.DauHieuKhac_Tim));
            Command.Parameters.Add(new MDB.MDBParameter("caccoquan_hohap", valueData.CacCoQuan_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("ranphoi", valueData.RanPhoi));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieukhac_hohap", valueData.DauHieuKhac_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("ganto_tieuhoa", valueData.GanTo_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("dbs_tieuhoa", valueData.DBS_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieukhac_tieuhoa", valueData.DauHieuKhac_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("thantietnieusinhduc", valueData.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("dongtu", valueData.DongTu));
            Command.Parameters.Add(new MDB.MDBParameter("pxas", valueData.PXAS));
            Command.Parameters.Add(new MDB.MDBParameter("caccoquan_thankinh", valueData.CacCoQuan_ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieukhac_thankinh", valueData.DauHieuKhac_ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("coxuongkhop", valueData.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("tmhrhmcoquankhac", valueData.TMHRHMCoQuanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("cacxncanlamsang", valueData.CacXNCanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ngaybenh", valueData.NgayBenh));
            Command.Parameters.Add(new MDB.MDBParameter("ttbenhan", valueData.TTBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("dauhieukhac_ttbenhan", valueData.DauHieuKhac_TTBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("chandoanbenhchinh", valueData.ChanDoanBenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("maicd10", valueData.MaICD10));
            Command.Parameters.Add(new MDB.MDBParameter("benhkem_chandoan", valueData.BenhKem_ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("maicd10benhkem", valueData.MaICD10BenhKem));
            Command.Parameters.Add(new MDB.MDBParameter("phanbiet_chandoan", valueData.PhanBiet_ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriArr", valueData.HuongDieuTriArr));
            Command.Parameters.Add(new MDB.MDBParameter("tienluong", valueData.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("huongdieutrikhac", valueData.HuongDieuTriKhac));
            Command.Parameters.Add(new MDB.MDBParameter("ngaykhambenh", valueData.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("bacsylambenhan", valueData.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("manvbacsylambenhan", valueData.MaNVBacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("tongket_ketquaxetnghiem", valueData.TongKet_KetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("tongket_quatrinhbenhly", valueData.TongKet_QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("tongket_dieutri", valueData.TongKet_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("tongket_ttravien", valueData.TongKet_TTRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("tongket_huongdieutri", valueData.TongKet_HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc1", valueData.TenThuoc1));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU1", valueData.TSDU1));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan1", valueData.SoLan1));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS1", valueData.BHLS1));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc2", valueData.TenThuoc2));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU2", valueData.TSDU2));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan2", valueData.SoLan2));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS2", valueData.BHLS2));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc3", valueData.TenThuoc3));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU3", valueData.TSDU3));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan3", valueData.SoLan3));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS3", valueData.BHLS3));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc4", valueData.TenThuoc4));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU4", valueData.TSDU4));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan4", valueData.SoLan4));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS4", valueData.BHLS4));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc5", valueData.TenThuoc5));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU5", valueData.TSDU5));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan5", valueData.SoLan5));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS5", valueData.BHLS5));
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc6", valueData.TenThuoc6));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU6", valueData.TSDU6));
            Command.Parameters.Add(new MDB.MDBParameter("SoLan6", valueData.SoLan6));
            Command.Parameters.Add(new MDB.MDBParameter("BHLS6", valueData.BHLS6));
            Command.Parameters.Add(new MDB.MDBParameter("DiTatBamSinh_Co", valueData.DiTatBamSinh_Co));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Khac", valueData.ToanThan_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("GanTo_TieuHoaCo", valueData.GanTo_TieuHoaCo));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", valueData.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", valueData.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", valueData.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", valueData.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", valueData.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", valueData.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", valueData.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", valueData.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", valueData.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("HinhVeTonThuongKhiVaoVien", valueData.HinhVeTonThuongKhiVaoVien.Replace(ERMDatabase.FTPImageString == null ? "ImageString" : ERMDatabase.FTPImageString, "")));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", valueData.MaQuanLy));
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnSanKhoa BenhAnSanKhoa)
        {
            string sql = @"DELETE FROM BenhAnTayChanMieng 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnSanKhoa.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
