using System;
namespace EMR_MAIN
{
    public class CauHinhVoBenhAnEMR
    {
        public long ID { get; set; }
        public int LoaiHinhKyDienTu { get; set; }
        public int ChoPhepSuaPhieuKhiDongBenhAn { get; set; }//1: enable, 0: disable
        public int ChoPhepMoNhieuBenhAn { get; set; }
        public int CoDinhPhieuTruyenDich { get; set; }
        public int CheckLuuBenhAnNgoaiTru { get; set; }
        public int ChonDHSTTuPhieuDieuTri { get; set; }
        public int CheckQuyenPhauThuatThuThuat { get; set; }
        public int MoTrucTiepPhieu { get; set; }
        public int CheckChuyenVienRaVien { get; set; }
        public int CapNhatDuLieuTuHis { get; set; }
        public int SuDungBenhAnMatCu { get; set; }
        public int? SoLuongPhieuTDCNS { get; set; }
        // 0 -> mặc định chiều dọc, 1 -> chiều ngang
        public int DangReportChuyenDa { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
    public class CauHinhVoBenhAnEMRFunc
    {
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref CauHinhVoBenhAnEMR objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO CAUHINHVOBENHANEMR (
                                    LoaiHinhKyDienTu,
                                    DongBenhAn,
                                    ChoPhepMoNhieuBenhAn,
                                    CoDinhPhieuTruyenDich,
                                    CheckLuuBenhAnNgoaiTru,
                                    ChonDHSTTuPhieuDieuTri,
                                    CheckQuyenPhauThuatThuThuat,
                                    MoTrucTiepPhieu,
                                    CheckChuyenVienRaVien,
                                    CapNhatDuLieuTuHis,
                                    SuDungBenhAnMatCu,
                                    SoLuongPhieuTDCNS,
                                    DangReportChuyenDa,
                                    nguoitao,
                                    ngaytao
                                ) VALUES (
                                    :LoaiHinhKyDienTu,
                                    :DongBenhAn,
                                    :ChoPhepMoNhieuBenhAn,
                                    :CoDinhPhieuTruyenDich,
                                    :CheckLuuBenhAnNgoaiTru,
                                    :ChonDHSTTuPhieuDieuTri,
                                    :CheckQuyenPhauThuatThuThuat,
                                    :MoTrucTiepPhieu,
                                    :CheckChuyenVienRaVien,
                                    :CapNhatDuLieuTuHis,
                                    :SuDungBenhAnMatCu,
                                    :SoLuongPhieuTDCNS,
                                    :DangReportChuyenDa,
                                    :nguoitao,
                                    :ngaytao
                                ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LoaiHinhKyDienTu", objData.LoaiHinhKyDienTu));
                Command.Parameters.Add(new MDB.MDBParameter("DongBenhAn", objData.ChoPhepSuaPhieuKhiDongBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("ChoPhepMoNhieuBenhAn", objData.ChoPhepMoNhieuBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhPhieuTruyenDich", objData.CoDinhPhieuTruyenDich));
                Command.Parameters.Add(new MDB.MDBParameter("CheckLuuBenhAnNgoaiTru", objData.CheckLuuBenhAnNgoaiTru));
                Command.Parameters.Add(new MDB.MDBParameter("ChonDHSTTuPhieuDieuTri", objData.ChonDHSTTuPhieuDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("CheckQuyenPhauThuatThuThuat", objData.CheckQuyenPhauThuatThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MoTrucTiepPhieu", objData.MoTrucTiepPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("CheckChuyenVienRaVien", objData.CheckChuyenVienRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("CapNhatDuLieuTuHis", objData.CapNhatDuLieuTuHis));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungBenhAnMatCu", objData.SuDungBenhAnMatCu));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongPhieuTDCNS", objData.SoLuongPhieuTDCNS));
                Command.Parameters.Add(new MDB.MDBParameter("DangReportChuyenDa", objData.DangReportChuyenDa));
                Command.Parameters.Add(new MDB.MDBParameter("nguoitao", objData.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytao", objData.NgayTao));
                if (objData.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                }
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

                if (n > 0 && objData.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    objData.ID = nextval;
                }
            }

            else
            {
                sql = @"UPDATE CAUHINHVOBENHANEMR SET  
                                         LoaiHinhKyDienTu = :LoaiHinhKyDienTu,
                                         DongBenhAn = :DongBenhAn,
                                         ChoPhepMoNhieuBenhAn = :ChoPhepMoNhieuBenhAn,
                                         CoDinhPhieuTruyenDich = :CoDinhPhieuTruyenDich,
                                         CheckLuuBenhAnNgoaiTru = :CheckLuuBenhAnNgoaiTru,
                                         ChonDHSTTuPhieuDieuTri = :ChonDHSTTuPhieuDieuTri,  
                                         CheckQuyenPhauThuatThuThuat = :CheckQuyenPhauThuatThuThuat,
                                         MoTrucTiepPhieu = :MoTrucTiepPhieu,
                                         CheckChuyenVienRaVien = :CheckChuyenVienRaVien,
                                         CapNhatDuLieuTuHis = :CapNhatDuLieuTuHis,
                                         SuDungBenhAnMatCu = :SuDungBenhAnMatCu,
                                         SoLuongPhieuTDCNS = :SoLuongPhieuTDCNS,
                                         DangReportChuyenDa = :DangReportChuyenDa,
                                         nguoisua = :nguoisua,
                                         ngaysua = :ngaysua 
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LoaiHinhKyDienTu", objData.LoaiHinhKyDienTu));
                Command.Parameters.Add(new MDB.MDBParameter("DongBenhAn", objData.ChoPhepSuaPhieuKhiDongBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("ChoPhepMoNhieuBenhAn", objData.ChoPhepMoNhieuBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhPhieuTruyenDich", objData.CoDinhPhieuTruyenDich));
                Command.Parameters.Add(new MDB.MDBParameter("CheckLuuBenhAnNgoaiTru", objData.CheckLuuBenhAnNgoaiTru));
                Command.Parameters.Add(new MDB.MDBParameter("ChonDHSTTuPhieuDieuTri", objData.ChonDHSTTuPhieuDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("CheckQuyenPhauThuatThuThuat", objData.CheckQuyenPhauThuatThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MoTrucTiepPhieu", objData.MoTrucTiepPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("CheckChuyenVienRaVien", objData.CheckChuyenVienRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("CapNhatDuLieuTuHis", objData.CapNhatDuLieuTuHis));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungBenhAnMatCu", objData.SuDungBenhAnMatCu));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongPhieuTDCNS", objData.SoLuongPhieuTDCNS));
                Command.Parameters.Add(new MDB.MDBParameter("DangReportChuyenDa", objData.DangReportChuyenDa));
                Command.Parameters.Add(new MDB.MDBParameter("nguoisua", objData.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ngaysua", objData.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }

            return n > 0 ? true : false;
        }
        public static CauHinhVoBenhAnEMR GetData(MDB.MDBConnection _OracleConnection)
        {
            try
            {
                string sql = @"SELECT * FROM CAUHINHVOBENHANEMR";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        CauHinhVoBenhAnEMR data = new CauHinhVoBenhAnEMR();
                        data.ID = DataReader.GetLong("ID");
                        data.LoaiHinhKyDienTu = DataReader.GetInt("LoaiHinhKyDienTu");
                        data.ChoPhepSuaPhieuKhiDongBenhAn = DataReader.GetInt("DongBenhAn");
                        data.ChoPhepMoNhieuBenhAn = DataReader.GetInt("ChoPhepMoNhieuBenhAn");
                        data.CoDinhPhieuTruyenDich = DataReader.GetInt("CoDinhPhieuTruyenDich");
                        data.CheckLuuBenhAnNgoaiTru = DataReader.GetInt("CheckLuuBenhAnNgoaiTru");
                        data.ChonDHSTTuPhieuDieuTri = DataReader.GetInt("ChonDHSTTuPhieuDieuTri");
                        data.CheckQuyenPhauThuatThuThuat = DataReader.GetInt("CheckQuyenPhauThuatThuThuat");
                        data.MoTrucTiepPhieu = DataReader.GetInt("MoTrucTiepPhieu");
                        data.CheckChuyenVienRaVien = DataReader.GetInt("CheckChuyenVienRaVien");
                        data.CapNhatDuLieuTuHis = DataReader.GetInt("CapNhatDuLieuTuHis");
                        data.SuDungBenhAnMatCu = DataReader.GetInt("SuDungBenhAnMatCu");
                        int tempInt = 0;
                        if(int.TryParse(DataReader["SoLuongPhieuTDCNS"].ToString(), out tempInt))
                        {
                            data.SoLuongPhieuTDCNS = tempInt;
                        }    
                        else
                            data.SoLuongPhieuTDCNS = null;
                        data.DangReportChuyenDa = DataReader.GetInt("DangReportChuyenDa");
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);

                        return data;
                    }
                    catch (Exception ex) {
                        XuLyLoi.Handle(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }

            return new CauHinhVoBenhAnEMR();
        }
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
    }
}
