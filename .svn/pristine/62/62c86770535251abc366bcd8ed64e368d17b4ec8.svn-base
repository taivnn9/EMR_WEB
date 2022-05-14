using DevExpress.XtraReports.UI;
using EMR.KyDienTu;
using EMR_MAIN.InBenhAn;
using EMR_MAIN.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;
using Newtonsoft.Json;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuLocMau : ThongTinKy
    {
        public PhieuLocMau()
        {
            TableName = "PHIEULOCMAU";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PLM;
            TenMauPhieu = DanhMucPhieu.PLM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuLocMau { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public decimal SoPhieu { get; set; }
        public string CaLocMau { get; set; }
        public string Thang { get; set; }
        public string Nam { get; set; }
        public string TongSoLanLocMau { get; set; }
        public string Thuoc { get; set; }
        public string Dam { get; set; }
        public string Sat { get; set; }
        public string Khac { get; set; }
        public string XetNghiem { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongTongKet { get; set; }
        public string TenDieuDuongTongKet { get; set; }

        //dang.tung
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuLocMauFunc
    {
        public const string TableName = "PhieuLocMau";
        public const string TablePrimaryKeyName = "IDPhieuLocMau";
        public static List<PhieuLocMau> Select(MDB.MDBConnection _OracleConnection, decimal MaQuanLy)
        {
            List<PhieuLocMau> listResult = new List<PhieuLocMau>();
            try
            {
                string sql = @"SELECT *
                    FROM PhieuLocMau
                    WHERE MaQuanLy = :MaQuanLy
                    ORDER BY LPAD(Thang, (SELECT MAX(LENGTH(Thang)) FROM PhieuLocMau)) DESC,
                    LPAD(Nam, (SELECT MAX(LENGTH(Nam)) FROM PhieuLocMau)) DESC";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var res = new PhieuLocMau();
                    res.IDPhieuLocMau = (decimal)DataReader["IDPhieuLocMau"];
                    res.MaQuanLy = (decimal)DataReader["MaQuanLy"];
                    res.SoPhieu = (decimal)DataReader["SoPhieu"];
                    res.CaLocMau = DataReader["CaLocMau"].ToString();
                    res.Thang = DataReader["Thang"].ToString();
                    res.Nam = DataReader["Nam"].ToString();
                    res.TongSoLanLocMau = DataReader["TongSoLanLocMau"].ToString();
                    res.Thuoc = DataReader["Thuoc"].ToString();
                    res.Dam = DataReader["Dam"].ToString();
                    res.Sat = DataReader["Sat"].ToString();
                    res.Khac = DataReader["Khac"].ToString();
                    res.XetNghiem = DataReader["XetNghiem"].ToString();
                    res.MaDieuDuongTongKet = DataReader["MaDieuDuongTongKet"].ToString();
                    res.TenDieuDuongTongKet = DataReader["TenDieuDuongTongKet"].ToString();
                    listResult.Add(res);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return listResult;
        }
        public static PhieuLocMau SelectByID(MDB.MDBConnection _OracleConnection, decimal IDPhieuLocMau)
        {
            PhieuLocMau res = new PhieuLocMau();
            try
            {
                string sql = @"SELECT *
                    FROM PhieuLocMau
                    WHERE IDPhieuLocMau = :IDPhieuLocMau";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieuLocMau", IDPhieuLocMau));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    res.IDPhieuLocMau = (decimal)DataReader["IDPhieuLocMau"];
                    res.MaQuanLy = (decimal)DataReader["MaQuanLy"];
                    res.SoPhieu = (decimal)DataReader["SoPhieu"];
                    res.CaLocMau = DataReader["CaLocMau"].ToString();
                    res.Thang = DataReader["Thang"].ToString();
                    res.Nam = DataReader["Nam"].ToString();
                    res.TongSoLanLocMau = DataReader["TongSoLanLocMau"].ToString();
                    res.Thuoc = DataReader["Thuoc"].ToString();
                    res.Dam = DataReader["Dam"].ToString();
                    res.Sat = DataReader["Sat"].ToString();
                    res.Khac = DataReader["Khac"].ToString();
                    res.XetNghiem = DataReader["XetNghiem"].ToString();
                    res.MaDieuDuongTongKet = DataReader["MaDieuDuongTongKet"].ToString();
                    res.TenDieuDuongTongKet = DataReader["TenDieuDuongTongKet"].ToString();
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return res;
        }
        public static bool Insert(MDB.MDBConnection _OracleConnection, PhieuLocMau data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuLocMau(
                    IDPhieuLocMau, MaQuanLy, SoPhieu, CaLocMau, Thang, Nam, TongSoLanLocMau, Thuoc, Dam, Sat, Khac, XetNghiem, MaDieuDuongTongKet, TenDieuDuongTongKet) 
                    VALUES (
                    :IDPhieuLocMau, :MaQuanLy, :SoPhieu, :CaLocMau, :Thang, :Nam, :TongSoLanLocMau, :Thuoc, :Dam, :Sat, :Khac, :XetNghiem, :MaDieuDuongTongKet, :TenDieuDuongTongKet)
                    RETURNING IDPhieuLocMau INTO :IDPhieuLocMau";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuLocMau", data.IDPhieuLocMau));
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":SoPhieu", data.SoPhieu));
                Command.Parameters.Add(new MDB.MDBParameter(":CaLocMau", data.CaLocMau));
                Command.Parameters.Add(new MDB.MDBParameter(":Thang", data.Thang));
                Command.Parameters.Add(new MDB.MDBParameter(":Nam", data.Nam));
                Command.Parameters.Add(new MDB.MDBParameter(":TongSoLanLocMau", data.TongSoLanLocMau));
                Command.Parameters.Add(new MDB.MDBParameter(":Thuoc", data.Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter(":Dam", data.Dam));
                Command.Parameters.Add(new MDB.MDBParameter(":Sat", data.Sat));
                Command.Parameters.Add(new MDB.MDBParameter(":Khac", data.Khac));
                Command.Parameters.Add(new MDB.MDBParameter(":XetNghiem", data.XetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter(":MaDieuDuongTongKet", data.MaDieuDuongTongKet));
                Command.Parameters.Add(new MDB.MDBParameter(":TenDieuDuongTongKet", data.TenDieuDuongTongKet));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Update(MDB.MDBConnection _OracleConnection, PhieuLocMau data)
        {
            try
            {
                string sql = @"UPDATE PhieuLocMau SET 
                        MaQuanLy = :MaQuanLy, 
                        SoPhieu = :SoPhieu, 
                        CaLocMau = :CaLocMau, 
                        Thang = :Thang, 
                        Nam = :Nam, 
                        TongSoLanLocMau = :TongSoLanLocMau, 
                        Thuoc = :Thuoc, 
                        Dam = :Dam, 
                        Sat = :Sat, 
                        Khac = :Khac, 
                        XetNghiem = :XetNghiem, 
                        MaDieuDuongTongKet = :MaDieuDuongTongKet, 
                        TenDieuDuongTongKet = :TenDieuDuongTongKet
                        WHERE IDPhieuLocMau = " + data.IDPhieuLocMau;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":SoPhieu", data.SoPhieu));
                Command.Parameters.Add(new MDB.MDBParameter(":CaLocMau", data.CaLocMau));
                Command.Parameters.Add(new MDB.MDBParameter(":Thang", data.Thang));
                Command.Parameters.Add(new MDB.MDBParameter(":Nam", data.Nam));
                Command.Parameters.Add(new MDB.MDBParameter(":TongSoLanLocMau", data.TongSoLanLocMau));
                Command.Parameters.Add(new MDB.MDBParameter(":Thuoc", data.Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter(":Dam", data.Dam));
                Command.Parameters.Add(new MDB.MDBParameter(":Sat", data.Sat));
                Command.Parameters.Add(new MDB.MDBParameter(":Khac", data.Khac));
                Command.Parameters.Add(new MDB.MDBParameter(":XetNghiem", data.XetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter(":MaDieuDuongTongKet", data.MaDieuDuongTongKet));
                Command.Parameters.Add(new MDB.MDBParameter(":TenDieuDuongTongKet", data.TenDieuDuongTongKet));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection _OracleConnection, decimal IDPhieuLocMau)
        {
            try
            {
                if (IDPhieuLocMau != 0)
                {
                    string sql = @"DELETE FROM PhieuLocMau WHERE IDPhieuLocMau = :IDPhieuLocMau";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuLocMau", IDPhieuLocMau));
                    int n = Command.ExecuteNonQuery();
                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool HasSoPhieu(MDB.MDBConnection _OracleConnection, decimal MaQuanLy, decimal SoPhieu)
        {
            try
            {
                string sql = @"DELETE FROM PhieuLocMau WHERE MaQuanLy =: MaQuanLy AND SoPhieu =: SoPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":SoPhieu", SoPhieu));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static decimal GetSoPhieuLatest(MDB.MDBConnection _OracleConnection, decimal MaQuanLy)
        {
            try
            {
                string sql = string.Format("SELECT * FROM ({0}) WHERE ROWNUM = 1",
                    "SELECT SoPhieu FROM PhieuLocMau WHERE MaQuanLy = :MaQuanLy ORDER BY SoPhieu DESC");
                MDB.MDBCommand cmd = new MDB.MDBCommand(sql, _OracleConnection);
                cmd.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                var latestID = cmd.ExecuteScalar();
                return (decimal)latestID;
            }
            catch { return 1; }
        }
        //tungnd
        public static void Print(HanhChinhBenhNhan hcbn, ThongTinDieuTri ttdt, List<PhieuLocMau> lstPrints, ControlAPIPhieuLocMau ctrAPICloud, MDB.MDBConnection _OracleConnection, bool preview = true)
        {
            try
            {
                if (lstPrints == null)
                {
                    return;
                }
                foreach (var root in lstPrints)
                {
                    //Report.lstKy = new List<Inventec.Common.SignLibrary.DTO.SignerConfigDTO> { };
                    Report.thongTinKy = new EMR.KyDienTu.ThongTinKy();
                    int maKy = Report.GetMaKyPhieu(XemBenhAn.MyConnection, "PLM");
                    Report.thongTinKy.LoaiVanBan = (EMR.KyDienTu.LoaiVanBanKyDienTu) maKy;

                    //int i = 0;
                    PhieuLocMau lstLeafs = new PhieuLocMau();
#if CLOUD
                    string response = ctrAPICloud.FncAPICLOUD("GETDATA", root.IDPhieuLocMau.ToString());
                    if (!response.Equals("FAILED"))
                    {
                        lstLeafs = (PhieuLocMau)JsonConvert.DeserializeObject(response.Trim(), typeof(PhieuLocMau));
                    }
                    else
                    {
                        // MessageBox.Show("Error: GetData không thành công");
                    }
#else
                    lstLeafs = SelectByID(_OracleConnection, root.IDPhieuLocMau);
#endif

                    List<PhieuLocMauChiTiet> lstDetail = new List<PhieuLocMauChiTiet>();
#if CLOUD
                    string res = ctrAPICloud.FncAPICLOUD("GETLISTDATADETAIL", root.IDPhieuLocMau.ToString());
                    if (!res.Equals("FAILED"))
                    {
                        lstDetail = (List<PhieuLocMauChiTiet>)JsonConvert.DeserializeObject(res.Trim(), typeof(List<PhieuLocMauChiTiet>));
                    }
                    else
                    {
                        // MessageBox.Show("Error: GetData không thành công");
                    }
#else
                    lstDetail = DATABASE.Other.PhieuLocMauChiTietFunc.Select(_OracleConnection, root.IDPhieuLocMau);
#endif

                    //foreach (ThongTinTruyenDich tttd in lstLeafs)
                    //{
                    //    string NguoiThucHien = tttd.MaNVNguoiThucHien;
                    //    if (NguoiThucHien != "")
                    //    {
                    //        i = i + 1;
                    //        Report.lstKy.Add((new Inventec.Common.SignLibrary.DTO.SignerConfigDTO() { Loginname = NguoiThucHien, NumOrder = i }));
                    //    }
                    //}
                    DataSet ds = new DataSet();
                    rptPhieuLocMau temp = new rptPhieuLocMau(hcbn, ttdt, lstLeafs, lstDetail);
                    if (preview)
                    {
                        Report.Print(null, temp, true
                            , maKy.ToString().PadLeft(2, '0')
                            , TableName
                            , TablePrimaryKeyName
                            , Convert.ToInt64(root.IDPhieuLocMau)
                            , root.MaSoKy);
                    }
                    else
                    {
                        new ReportPrintTool(temp).Print();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}