using EMR.KyDienTu;
using EMR_MAIN.Converter;
using MDB;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class TVTTHMCBN_Mau : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        [MoTaDuLieu("Số thứ tự")]
        public int No { get; set; }
        [MoTaDuLieu("Tên danh mục")]
        public string Ten { get; set; }
        [MoTaDuLieu("Đơn vị")]
        public string DV { get; set; }
        private double? _S { get; set; }
        [MoTaDuLieu("Số lượng sử dụng sáng")]
        public double? S
        {
            get { return _S; }
            set
            {
                _S = value;
                OnPropertyChanged("Su");
            }
        }
        private double? _T { get; set; }
        [MoTaDuLieu("Số lượng sử dụng tối")]
        public double? T
        {
            get { return _T; }
            set
            {
                _T = value;
                OnPropertyChanged("Su");
            }
        }
        private double? _C { get; set; }
        [MoTaDuLieu("Số lượng sử dụng chiều")]
        public double? C
        {
            get { return _C; }
            set
            {
                _C = value;
                OnPropertyChanged("Su");
            }
        }
        [MoTaDuLieu("Tổng")]
        public double? Su
        {
            get
            {
               if(S != null || T != null || C != null)
                {
                    return (Common.ConDB_double(S) + Common.ConDB_double(T) + Common.ConDB_double(C));
                }else
                {
                    return null;
                }
            }
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public TVTTHMCBN_Mau()
        {
            Ten = "";
            DV = "";
        }
        public TVTTHMCBN_Mau Clone()
        {
            TVTTHMCBN_Mau other = (TVTTHMCBN_Mau)this.MemberwiseClone();
            return other;
        }
    }
    public class BKSDTVTTHMCBN : ThongTinKy
    {
        public BKSDTVTTHMCBN()
        {
            TableName = "BKSDTVTTHMCBN";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKSDTVTTHMCBN;
            TenMauPhieu = DanhMucPhieu.BKSDTVTTHMCBN.Description();
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
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Ngày ra viện")]
        public DateTime? NgayRaVien { get; set; }
        [MoTaDuLieu("Ngày làm thủ thuật")]
        public DateTime NgayLamThuThuat { get; set; }
        [MoTaDuLieu("Danh sách danh mục")]
        public ObservableCollection<TVTTHMCBN_Mau> lstDCVT { get; set; }
        [MoTaDuLieu("")]
        public DateTime? NgayDung { get; set; }
        public bool[] BHYT_Array { get; } = new bool[] { false, false };
        [MoTaDuLieu("Bảo hiểm y tế")]
        public string BHYT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BHYT_Array.Length; i++)
                    temp += (BHYT_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BHYT_Array[i] = intTemp == 1 ? true : false;
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
        [MoTaDuLieu("Sở y tế")]
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        [MoTaDuLieu("Bệnh viện")]
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
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
        [MoTaDuLieu("Số vào viện")]
        public string SoVaoVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
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
        [MoTaDuLieu("Mã bệnh án")]
        public string MaBenhAn
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhAn;
            }
        }
    }
    public class BKSDTVTTHMCBNFunc
    {
        public const string TableName = "BKSDTVTTHMCBN";
        public const string TablePrimaryKeyName = "ID";
        public static List<BKSDTVTTHMCBN> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BKSDTVTTHMCBN> list = new List<BKSDTVTTHMCBN>();
            try
            {

                string sql = @"SELECT * FROM BKSDTVTTHMCBN where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BKSDTVTTHMCBN data = new BKSDTVTTHMCBN();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MABENHNHAN"]); 
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        data.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        data.NgayRaVien = Common.ConDB_DateTimeNull(DataReader["NgayRaVien"]);
                        data.NgayLamThuThuat = Common.ConDB_DateTime(DataReader["NgayLamThuThuat"]);
                        data.lstDCVT = JsonConvert.DeserializeObject<ObservableCollection<TVTTHMCBN_Mau>>(Common.ConDBNull(DataReader["lstDCVT"]));
                        data.NgayDung = Common.ConDB_DateTimeNull(DataReader["NgayDung"]);
                        data.BHYT = Common.ConDBNull(DataReader["BHYT"]);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BKSDTVTTHMCBN objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO BKSDTVTTHMCBN (
                                    maquanly,MaKhoa,TenKhoa,DiaChi,Giuong,
                                    mabenhnhan,
                                    ChanDoan,
                                    NgayRaVien,
                                    NgayLamThuThuat,
                                    lstDCVT,
                                    NgayDung,
                                    BHYT,
                                    NgayTao,
                                    NguoiTao,
                                    NgaySua,
                                    NguoiSua
                                ) VALUES (
                                    :maquanly,:MaKhoa,:TenKhoa,:DiaChi,:Giuong,
                                    :mabenhnhan,
                                    :ChanDoan,
                                    :NgayRaVien,
                                    :NgayLamThuThuat,
                                    :lstDCVT,
                                    :NgayDung,
                                    :BHYT,
                                    :NgayTao,
                                    :NguoiTao,
                                    :NgaySua,
                                    :NguoiSua
                                ) RETURNING ID INTO :ID";
            }

            else
            {
                sql = @"UPDATE BKSDTVTTHMCBN SET  
                                         maquanly = :maquanly,MaKhoa =:MaKhoa,TenKhoa =:TenKhoa,DiaChi =:DiaChi,Giuong =:Giuong,
                                         mabenhnhan = :mabenhnhan,
                                         ChanDoan = :ChanDoan,
                                         NgayRaVien = :NgayRaVien,
                                         NgayLamThuThuat = :NgayLamThuThuat,
                                         lstDCVT = :lstDCVT,
                                         NgayDung = :NgayDung,
                                         BHYT = :BHYT,
                                         nguoisua = :nguoisua,
                                         ngaysua = :ngaysua 
                                        WHERE ID = :ID";

            }

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", objData.MaKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", objData.TenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("DiaChi", objData.DiaChi));
            Command.Parameters.Add(new MDB.MDBParameter("Giuong", objData.Giuong));
            Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", objData.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", objData.NgayRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("NgayLamThuThuat", objData.NgayLamThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("lstDCVT", JsonConvert.SerializeObject(objData.lstDCVT)));
            Command.Parameters.Add(new MDB.MDBParameter("NgayDung", objData.NgayDung));
            Command.Parameters.Add(new MDB.MDBParameter("BHYT", objData.BHYT));
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
            string sql = "DELETE FROM BKSDTVTTHMCBN WHERE ID = :ID";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("ID", ID));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static BKSDTVTTHMCBN GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM BKSDTVTTHMCBN where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BKSDTVTTHMCBN data = new BKSDTVTTHMCBN();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MABENHNHAN"]);
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.NgayRaVien = Common.ConDB_DateTimeNull(DataReader["NgayRaVien"]);
                        data.NgayLamThuThuat = Common.ConDB_DateTime(DataReader["NgayLamThuThuat"]);
                        data.lstDCVT = JsonConvert.DeserializeObject<ObservableCollection<TVTTHMCBN_Mau>>(Common.ConDBNull(DataReader["lstDCVT"]));
                        data.NgayDung = Common.ConDB_DateTimeNull(DataReader["NgayDung"]);
                        data.BHYT = Common.ConDBNull(DataReader["BHYT"]);
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

                        return data;
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
            return null;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql2 = @"SELECT D.*, '' SoNhapVien, '' MaBenhAn , ''  SoVaoVien, '' TenBenhNhan,
                        '' TUOI, '' SoYTe, '' BENHVIEN,
                        '' GioiTinh
            FROM
                BKSDTVTTHMCBN D
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", ID));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
            List<TVTTHMCBN_Mau> lstDCVT = new List<TVTTHMCBN_Mau>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                lstDCVT = JsonConvert.DeserializeObject < ObservableCollection <TVTTHMCBN_Mau>> (Common.ConDBNull(ds.Tables[0].Rows[0]["lstDCVT"])).ToList();
            }
           ds.Tables.Add(ListToDatatable.ToDataTable(lstDCVT));
            return ds;
        }
    }
}
