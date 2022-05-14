using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiMoDeChiHuy : ThongTinKy
    {
        public PhieuTheoDoiMoDeChiHuy()
        {
            TableName = "PhieuTheoDoiMoDeChiHuy";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDMDCH;
            TenMauPhieu = DanhMucPhieu.PTDMDCH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuTheoDoiMoDeChiHuy { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string DungDichTruyen { get; set; }
        public string ThuocPhaTruyen { get; set; }
        public List<PhieuTheoDoiMoDeChiHuyChiTiet> ChiTiet { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuTheoDoiMoDeChiHuyFunc
    {
        public const string TableName = "PhieuTheoDoiMoDeChiHuy";
        public const string TablePrimaryKeyName = "IDPhieuTheoDoiMoDeChiHuy";
        public const string MaPhieu = "PTDMDCH";
        public static List<PhieuTheoDoiMoDeChiHuy> Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<PhieuTheoDoiMoDeChiHuy> listResult = new List<PhieuTheoDoiMoDeChiHuy>();
            try
            {
                string sql = @"SELECT *
                                FROM PhieuTheoDoiMoDeChiHuy
                                WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var res = new PhieuTheoDoiMoDeChiHuy();
                    res.IDPhieuTheoDoiMoDeChiHuy = (decimal)DataReader["IDPhieuTheoDoiMoDeChiHuy"];
                    res.MaQuanLy = (decimal)DataReader["MaQuanLy"];
                    res.ChanDoan = DataReader["ChanDoan"].ToString();
                    res.DungDichTruyen = DataReader["DungDichTruyen"].ToString();
                    res.ThuocPhaTruyen = DataReader["ThuocPhaTruyen"].ToString();
                    res.ChiTiet = JsonConvert.DeserializeObject<List<PhieuTheoDoiMoDeChiHuyChiTiet>>(DataReader["ChiTiet"].ToString());
                    listResult.Add(res);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return listResult;
        }

        public static DataSet SelectByID(MDB.MDBConnection MyConnection, decimal IDPhieuTheoDoiMoDeChiHuy)
        {
            var ds = new DataSet();
            try
            {
                string sql = @"SELECT *
                                 FROM PhieuTheoDoiMoDeChiHuy where IDPhieuTheoDoiMoDeChiHuy = :IDPhieuTheoDoiMoDeChiHuy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieuTheoDoiMoDeChiHuy", IDPhieuTheoDoiMoDeChiHuy));
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                ;
                adt.Fill(ds, "TBL");

                return ds;
                //string sql = @"SELECT *
                //                FROM PhieuTheoDoiMoDeChiHuy
                //                WHERE IDPhieuTheoDoiMoDeChiHuy = :IDPhieuTheoDoiMoDeChiHuy";
                //MDB.MDBCommand Command = new MDB.MDBCommand(sql, XemBenhAn.MyConnection);
                //Command.Parameters.Add(new MDB.MDBParameter("IDPhieuTheoDoiMoDeChiHuy", IDPhieuTheoDoiMoDeChiHuy));
                //MDB.MDBDataReader DataReader = Command.ExecuteReader();
                //while (DataReader.Read())
                //{
                //    res.IDPhieuTheoDoiMoDeChiHuy = (decimal)DataReader["IDPhieuTheoDoiMoDeChiHuy"];
                //    res.MaQuanLy = (decimal)DataReader["MaQuanLy"];
                //    res.ChanDoan = DataReader["ChanDoan"].ToString();
                //    res.DungDichTruyen = DataReader["DungDichTruyen"].ToString();
                //    res.ThuocPhaTruyen = DataReader["ThuocPhaTruyen"].ToString();
                //    res.ChiTiet = JsonConvert.DeserializeObject<List<PhieuTheoDoiMoDeChiHuyChiTiet>>(DataReader["ChiTiet"].ToString());
                //    return res;
                //}
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return ds;
        }

        public static bool Insert(MDB.MDBConnection MyConnection, PhieuTheoDoiMoDeChiHuy data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTheoDoiMoDeChiHuy(
                IDPhieuTheoDoiMoDeChiHuy, MaQuanLy, ChanDoan, DungDichTruyen, ThuocPhaTruyen, ChiTiet) 
                VALUES (
                :IDPhieuTheoDoiMoDeChiHuy, :MaQuanLy, :ChanDoan, :DungDichTruyen, :ThuocPhaTruyen, :ChiTiet)
                RETURNING IDPhieuTheoDoiMoDeChiHuy INTO :IDPhieuTheoDoiMoDeChiHuy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuTheoDoiMoDeChiHuy", data.IDPhieuTheoDoiMoDeChiHuy));
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter(":DungDichTruyen", data.DungDichTruyen));
                Command.Parameters.Add(new MDB.MDBParameter(":ThuocPhaTruyen", data.ThuocPhaTruyen));
                Command.Parameters.Add(new MDB.MDBParameter(":ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
            return false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, PhieuTheoDoiMoDeChiHuy data)
        {
            try
            {
                string sql = @"UPDATE PhieuTheoDoiMoDeChiHuy SET 
                MaQuanLy = :MaQuanLy, 
                ChanDoan = :ChanDoan, 
                DungDichTruyen = :DungDichTruyen, 
                ThuocPhaTruyen = :ThuocPhaTruyen, 
                ChiTiet = :ChiTiet               
                WHERE IDPhieuTheoDoiMoDeChiHuy = " + data.IDPhieuTheoDoiMoDeChiHuy;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter(":DungDichTruyen", data.DungDichTruyen));
                Command.Parameters.Add(new MDB.MDBParameter(":ThuocPhaTruyen", data.ThuocPhaTruyen));
                Command.Parameters.Add(new MDB.MDBParameter(":ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, decimal IDPhieuTheoDoiMoDeChiHuy)
        {
            try
            {
                if (IDPhieuTheoDoiMoDeChiHuy != 0)
                {
                    string sql = @"DELETE FROM PhieuTheoDoiMoDeChiHuy WHERE IDPhieuTheoDoiMoDeChiHuy = :IDPhieuTheoDoiMoDeChiHuy";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuTheoDoiMoDeChiHuy", IDPhieuTheoDoiMoDeChiHuy));
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
        /*
        //tungnd
        public static void Print(HanhChinhBenhNhan hcbn, ThongTinDieuTri ttdt, List<PhieuTheoDoiMoDeChiHuy> lstPrints, bool preview = true)
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
                    Report.thongTinKy.LoaiVanBan = EMR.KyDienTu.LoaiVanBanKyDienTu.BangKeKhac;

                    //int i = 0;
                    var lstLeafs = SelectByID(root.IDPhieuTheoDoiMoDeChiHuy);

                    List<PhieuTheoDoiMoDeChiHuyChiTiet> lstDetail = DATABASE.Other.PhieuTheoDoiMoDeChiHuyChiTietFunc.Select(root.IDPhieuTheoDoiMoDeChiHuy);

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
                    rptPhieuTheoDoiMoDeChiHuy temp = new rptPhieuTheoDoiMoDeChiHuy(hcbn, ttdt, lstLeafs, lstDetail);
                    if (preview)
                    {
                        Report.Print(null, temp, true
                            , ((int)EMR.KyDienTu.LoaiVanBanKyDienTu.BangKeKhac).ToString().PadLeft(2, '0')
                            , TableName
                            , TablePrimaryKeyName
                            , Convert.ToInt64(root.IDPhieuTheoDoiMoDeChiHuy)
                            , root.MaSoKyTen);
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
        */
    }

    public class PhieuTheoDoiMoDeChiHuyChiTiet
    {
        public DateTime Gio { get; set; }
        public string SoGiot { get; set; }
        public string ConCoTC { get; set; }
        public string TimThai { get; set; }
        public string DoXoaMoCTC { get; set; }
        public string DoLot { get; set; }
        public string MaNguoiTheoDoi { get; set; }
        public string TenNguoiTheoDoi { get; set; }
    }
}