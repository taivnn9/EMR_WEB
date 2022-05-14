using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.Native;
using DevExpress.XtraEditors.Filtering.Templates;
using EMR.KyDienTu;
using EMR_MAIN.ChucNangKhac;
using EMR_MAIN.Converter;
using MDB;
using Newtonsoft.Json;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PTVHDGDSK : ThongTinKy
    {
        public PTVHDGDSK()
        {
            TableName = "PTVHDGDSK";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTVHDGDSK;
            TenMauPhieu = DanhMucPhieu.PTVHDGDSK.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        public string NghenNhiep { get; set; }
        public bool[] TDHVArray { get; } = new bool[] { false, false, false, false, false, false };
        public string TDHV
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TDHVArray.Length; i++)
                    temp += (TDHVArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TDHVArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public bool[] NguoiNhaArray { get; } = new bool[] { false, false };
        public string NguoiNha
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguoiNhaArray.Length; i++)
                    temp += (NguoiNhaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguoiNhaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NDDDMoiArray { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        public string NDDDMoi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NDDDMoiArray.Length; i++)
                    temp += (NDDDMoiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NDDDMoiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] NDDDTrongNVArray { get; } = new bool[] { false, false, false, false , false, false, false, false , false, false, false, false , false, false, false };
        public string NDDDTrongNV
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NDDDTrongNVArray.Length; i++)
                    temp += (NDDDTrongNVArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NDDDTrongNVArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NDDDTruocXVArray { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        public string NDDDTruocXV
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NDDDTruocXVArray.Length; i++)
                    temp += (NDDDTruocXVArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NDDDTruocXVArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string MoiLuuY { get; set; }
        public string LuuYKhacMoi { get; set; }
        public string TrongNVLuuY { get; set; }
        public string LuuYKhacTrongNV { get; set; }
        public string TruocXVLuuY { get; set; }
        public string LuuYKhacTruocXV { get; set; }

        public bool[] ND1Array { get; } = new bool[] { false, false, false, false };
        public string ND1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND1Array.Length; i++)
                    temp += (ND1Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND1Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND2Array { get; } = new bool[] { false, false, false, false };
        public string ND2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND2Array.Length; i++)
                    temp += (ND2Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND2Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND3Array { get; } = new bool[] { false, false, false, false };
        public string ND3
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND3Array.Length; i++)
                    temp += (ND3Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND3Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND4Array { get; } = new bool[] { false, false, false, false };
        public string ND4
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND4Array.Length; i++)
                    temp += (ND4Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND4Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ND5Array { get; } = new bool[] { false, false, false, false };
        public string ND5
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ND5Array.Length; i++)
                    temp += (ND5Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ND5Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh 
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year.ToString() : "";
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
    }
    public class PTVHDGDSKFunc
    {
        public const string TableName = "PTVHDGDSK";
        public const string TablePrimaryKeyName = "ID";
        public static List<PTVHDGDSK> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PTVHDGDSK> list = new List<PTVHDGDSK>();
            try
            {

                string sql = @"SELECT * FROM PTVHDGDSK where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PTVHDGDSK data = new PTVHDGDSK();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MABENHNHAN"]);
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        data.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        data.NghenNhiep = Common.ConDBNull(DataReader["NghenNhiep"]);
                        data.TDHV = Common.ConDBNull(DataReader["TDHV"]);
                        data.NDDDTruocXV = Common.ConDBNull(DataReader["NDDDTruocXV"]);
                         data.NguoiNha = Common.ConDBNull(DataReader["NguoiNha"]);
                        data.NDDDMoi = Common.ConDBNull(DataReader["NDDDMoi"]);
                        data.NguoiNha = Common.ConDBNull(DataReader["NguoiNha"]);
                        data.NDDDTrongNV = Common.ConDBNull(DataReader["NDDDTrongNV"]);
                        data.LuuYKhacMoi = Common.ConDBNull(DataReader["LuuYKhacMoi"]); 
                        data.TruocXVLuuY = Common.ConDBNull(DataReader["TruocXVLuuY"]);
                        data.LuuYKhacTrongNV = Common.ConDBNull(DataReader["LuuYKhacTrongNV"]);
                        data.LuuYKhacTruocXV = Common.ConDBNull(DataReader["LuuYKhacTruocXV"]);
                        data.MoiLuuY = Common.ConDBNull(DataReader["MoiLuuY"]);
                        data.TrongNVLuuY = Common.ConDBNull(DataReader["TrongNVLuuY"]);
                        data.ND1 = Common.ConDBNull(DataReader["ND1"]);
                        data.ND2 = Common.ConDBNull(DataReader["ND2"]);
                        data.ND3 = Common.ConDBNull(DataReader["ND3"]);
                        data.ND4 = Common.ConDBNull(DataReader["ND4"]);
                        data.ND5 = Common.ConDBNull(DataReader["ND5"]);
                        data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.NgayKy = Common.ConDB_DateTime(DataReader["NGAYKY"]);
                        data.ComputerKyTen = Common.ConDBNull(DataReader["COMPUTERKYTEN"]);
                        data.MaSoKy = Common.ConDBNull(DataReader["MASOKYTEN"]);
                        data.TenFileKy = Common.ConDBNull(DataReader["TENFILEKY"]);
                        data.UserNameKy = Common.ConDBNull(DataReader["USERNAMEKY"]);
                        data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                        list.Add(data);
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PTVHDGDSK objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO PTVHDGDSK (
                                    maquanly,MaKhoa,TenKhoa,NghenNhiep,TDHV,
                                    mabenhnhan,
                                    ChanDoan,
                                    NDDDTruocXV,
                                    NDDDMoi,NguoiNha,NDDDTrongNV,LuuYKhacMoi,LuuYKhacTrongNV,TruocXVLuuY,LuuYKhacTruocXV,MoiLuuY,TrongNVLuuY,ND1,ND2,ND3,ND4,ND5,
                                    NgayTao,
                                    NguoiTao,
                                    NgaySua,
                                    NguoiSua
                                ) VALUES (
                                    :maquanly,:MaKhoa,:TenKhoa,:NghenNhiep,:TDHV,
                                    :mabenhnhan,
                                    :ChanDoan,
                                    :NDDDTruocXV,
                                    :NDDDMoi,:NguoiNha,:NDDDTrongNV,:LuuYKhacMoi,:LuuYKhacTrongNV,:TruocXVLuuY,:LuuYKhacTruocXV,:MoiLuuY,:TrongNVLuuY,:ND1,:ND2,:ND3,:ND4,:ND5,
                                    :NgayTao,
                                    :NguoiTao,
                                    :NgaySua,
                                    :NguoiSua
                                ) RETURNING ID INTO :ID";
            }

            else
            {
                sql = @"UPDATE PTVHDGDSK SET  
                                         maquanly = :maquanly,MaKhoa =:MaKhoa,TenKhoa =:TenKhoa,NghenNhiep =:NghenNhiep,TDHV =:TDHV,
                                         mabenhnhan = :mabenhnhan,
                                         ChanDoan = :ChanDoan,
                                         NDDDTruocXV = :NDDDTruocXV,
                                        NDDDMoi=:NDDDMoi,NguoiNha=:NguoiNha,NDDDTrongNV=:NDDDTrongNV,LuuYKhacMoi=:LuuYKhacMoi,LuuYKhacTrongNV =:LuuYKhacTrongNV,TruocXVLuuY=:TruocXVLuuY,LuuYKhacTruocXV=:LuuYKhacTruocXV,TrongNVLuuY=:TrongNVLuuY,MoiLuuY=:MoiLuuY,ND1 =:ND1,ND2 =:ND2,ND3 =:ND3,ND4 =:ND4,ND5 =:ND5,
                                         nguoisua = :nguoisua,
                                         ngaysua = :ngaysua 
                                        WHERE ID = :ID";

            }

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", objData.MaKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", objData.TenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("NghenNhiep", objData.NghenNhiep));
            Command.Parameters.Add(new MDB.MDBParameter("TDHV", objData.TDHV));
            Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", objData.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("NDDDTruocXV", objData.NDDDTruocXV));
            Command.Parameters.Add(new MDB.MDBParameter("NDDDMoi", objData.NDDDMoi));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNha", objData.NguoiNha));
            Command.Parameters.Add(new MDB.MDBParameter("NDDDTrongNV", objData.NDDDTrongNV));
            Command.Parameters.Add(new MDB.MDBParameter("LuuYKhacMoi", objData.LuuYKhacMoi)); 
           Command.Parameters.Add(new MDB.MDBParameter("LuuYKhacTrongNV", objData.LuuYKhacTrongNV));
            Command.Parameters.Add(new MDB.MDBParameter("TruocXVLuuY", objData.TruocXVLuuY));
            Command.Parameters.Add(new MDB.MDBParameter("LuuYKhacTruocXV", objData.LuuYKhacTruocXV));
            Command.Parameters.Add(new MDB.MDBParameter("TrongNVLuuY", objData.TrongNVLuuY));
            Command.Parameters.Add(new MDB.MDBParameter("MoiLuuY", objData.MoiLuuY));
            Command.Parameters.Add(new MDB.MDBParameter("ND1", objData.ND1));
            Command.Parameters.Add(new MDB.MDBParameter("ND2", objData.ND2));
            Command.Parameters.Add(new MDB.MDBParameter("ND3", objData.ND3));
            Command.Parameters.Add(new MDB.MDBParameter("ND4", objData.ND4));
            Command.Parameters.Add(new MDB.MDBParameter("ND5", objData.ND5));
            Command.Parameters.Add(new MDB.MDBParameter("nguoisua", Common.getUserLogin()));
            Command.Parameters.Add(new MDB.MDBParameter("ngaysua", DateTime.Now));
            Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
            if (objData.ID == 0)
            {
                Command.Parameters.Add(new MDB.MDBParameter("nguoitao", Common.getUserLogin()));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytao", DateTime.Now));
            }
            Command.BindByName = true;
            n = Command.ExecuteNonQuery();
            if (n > 0)
            {
                if (objData.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    objData.ID = nextval;
                }
            }
            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql = "DELETE FROM PTVHDGDSK WHERE ID = :ID";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("ID", ID));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql2 = @"SELECT D.*, '' SoYTe, '' BenhVien , '' NamSinh, '' TenBenhNhan
                            , '' GioiTinh
            FROM
                PTVHDGDSK D
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", ID));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);

            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year.ToString() : "";
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
            return ds;
        }
    }
}
