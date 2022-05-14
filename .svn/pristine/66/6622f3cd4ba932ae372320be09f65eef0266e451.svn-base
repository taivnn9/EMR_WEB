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
    public class VTTH_Mau : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        [MoTaDuLieu("Số thứ tự")]
        public int No { get; set; }
        [MoTaDuLieu("Tên danh mục")]
        public string Ten { get; set; }
        [MoTaDuLieu("Đơn vị")]
        public string DV { get; set; }
        private double? _S { get; set; }
        [MoTaDuLieu("Số lượng sử dụng ")]
        public double? S
        {
            get { return _S; }
            set
            {
                _S = value;
                OnPropertyChanged("Su");
            }
        }
        
        [MoTaDuLieu("Tổng")]
        public double? Su
        {
            get
            {
               if(S != null )
                {
                    return (Common.ConDB_double(S));
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
        public VTTH_Mau()
        {
            Ten = "";
            DV = "";
        }
        public VTTH_Mau Clone()
        {
            VTTH_Mau other = (VTTH_Mau)this.MemberwiseClone();
            return other;
        }
    }
    public class BangKeThuocTrongGayMe : ThongTinKy
    {
        public BangKeThuocTrongGayMe()
        {
            TableName = "BangKeThuocTrongGayMe";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTTGM;
            TenMauPhieu = DanhMucPhieu.BKTTGM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Cách phẫu thuật")]
        public string CachPhauThuat { get; set; }
        [MoTaDuLieu("Ngày phẫu thuật")]
        public DateTime? NgayLamPhauThuat { get; set; }
        
        [MoTaDuLieu("Danh sách danh mục")]
        public ObservableCollection<VTTH_Mau> lstDCVT { get; set; }
        [MoTaDuLieu("Cách vô cảm")]
        public string CachVoCam { get; set; }
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
        [MoTaDuLieu("Bác sỹ gây mê")]
        public string BacSy { get; set; }
        [MoTaDuLieu("mã Bác sỹ gây mê")]
        public string MaBacSy { get; set; }
        [MoTaDuLieu("KTV gây mê")]
        public string KTVGayMe { get; set; }
        [MoTaDuLieu("Mã KTV gây mê")]
        public string MaKTVGayMe { get; set; }
        [MoTaDuLieu("Phẫu thuật viên chính")]
        public string PhauThuatVienChinh { get; set; }
        [MoTaDuLieu("Mã Phẫu thuật viên chính")]
        public string MaPhauThuatVienChinh { get; set; }
        [MoTaDuLieu("Người thống kê")]
        public string NguoiThongKe { get; set; }
        [MoTaDuLieu("Mã Người thống kê")]
        public string MaNguoiThongKe { get; set; }

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
    public class BangKeThuocTrongGayMeFunc
    {
        public const string TableName = "BangKeThuocTrongGayMe";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKeThuocTrongGayMe> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKeThuocTrongGayMe> list = new List<BangKeThuocTrongGayMe>();
            try
            {

                string sql = @"SELECT * FROM BangKeThuocTrongGayMe where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BangKeThuocTrongGayMe data = new BangKeThuocTrongGayMe();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                        data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                        data.DiaChi = DataReader["DiaChi"].ToString();
                        data.CanNang = DataReader["CanNang"].ToString();
                        data.ChanDoan = DataReader["ChanDoan"].ToString();
                        data.CachPhauThuat = DataReader["CachPhauThuat"].ToString();
                        data.NgayLamPhauThuat = Common.ConDB_DateTime(DataReader["NgayLamPhauThuat"]); 
                        data.lstDCVT = JsonConvert.DeserializeObject<ObservableCollection<VTTH_Mau>>(DataReader["lstDCVT"].ToString());
                        data.CachVoCam = DataReader["CachVoCam"].ToString();
                        data.BHYT = DataReader["BHYT"].ToString();
                        data.BacSy = DataReader["BacSy"].ToString();
                        data.MaBacSy = DataReader["MaBacSy"].ToString();
                        data.KTVGayMe = DataReader["KTVGayMe"].ToString();
                        data.MaKTVGayMe = DataReader["MaKTVGayMe"].ToString();
                        data.PhauThuatVienChinh = DataReader["PhauThuatVienChinh"].ToString();
                        data.MaPhauThuatVienChinh = DataReader["MaPhauThuatVienChinh"].ToString();
                        data.NguoiThongKe = DataReader["NguoiThongKe"].ToString();
                        data.MaNguoiThongKe = DataReader["MaNguoiThongKe"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKeThuocTrongGayMe objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO BangKeThuocTrongGayMe (
                                    MaQuanLy,
                                    MaBenhNhan,
                                    DiaChi,
                                    CanNang,
                                    ChanDoan,
                                    CachPhauThuat,
                                    NgayLamPhauThuat,
                                    lstDCVT,
                                    CachVoCam,
                                    BHYT,
                                    BacSy,
                                    MaBacSy,
                                    KTVGayMe,
                                    MaKTVGayMe,
                                    PhauThuatVienChinh,
                                    MaPhauThuatVienChinh,
                                    NguoiThongKe,
                                    MaNguoiThongKe,
                                    NgaySua,
                                    NguoiSua,
                                    NgayTao,
                                    NguoiTao 
                                ) VALUES (
                                    :MaQuanLy,
                                    :MaBenhNhan,
                                    :DiaChi,
                                    :CanNang,
                                    :ChanDoan,
                                    :CachPhauThuat,
                                    :NgayLamPhauThuat,
                                    :lstDCVT,
                                    :CachVoCam,
                                    :BHYT,
                                    :BacSy,
                                    :MaBacSy,
                                    :KTVGayMe,
                                    :MaKTVGayMe,
                                    :PhauThuatVienChinh,
                                    :MaPhauThuatVienChinh,
                                    :NguoiThongKe,
                                    :MaNguoiThongKe,
                                    :NgaySua,
                                    :NguoiSua,
                                    :NgayTao,
                                    :NguoiTao 
                                ) RETURNING ID INTO :ID";
            }

            else
            {
                sql = @"UPDATE BangKeThuocTrongGayMe SET  
                                            MaQuanLy=:MaQuanLy,
                                            MaBenhNhan=:MaBenhNhan,
                                            DiaChi=:DiaChi,
                                            CanNang=:CanNang,
                                            ChanDoan=:ChanDoan,
                                            CachPhauThuat=:CachPhauThuat,
                                            NgayLamPhauThuat=:NgayLamPhauThuat,
                                            lstDCVT=:lstDCVT,
                                            CachVoCam=:CachVoCam,
                                            BHYT=:BHYT,
                                            BacSy=:BacSy,
                                            MaBacSy=:MaBacSy,
                                            KTVGayMe=:KTVGayMe,
                                            MaKTVGayMe=:MaKTVGayMe,
                                            PhauThuatVienChinh=:PhauThuatVienChinh,
                                            MaPhauThuatVienChinh=:MaPhauThuatVienChinh,
                                            NguoiThongKe=:NguoiThongKe,
                                            MaNguoiThongKe=:MaNguoiThongKe,
                                            NgaySua=:NgaySua,
                                            NguoiSua=:NguoiSua  
                                        WHERE ID = :ID";

            }

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", objData.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", objData.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("DiaChi", objData.DiaChi));
            Command.Parameters.Add(new MDB.MDBParameter("CanNang", objData.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", objData.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("CachPhauThuat", objData.CachPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("NgayLamPhauThuat", objData.NgayLamPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("lstDCVT", JsonConvert.SerializeObject(objData.lstDCVT)));
            Command.Parameters.Add(new MDB.MDBParameter("CachVoCam", objData.CachVoCam));
            Command.Parameters.Add(new MDB.MDBParameter("BHYT", objData.BHYT));
            Command.Parameters.Add(new MDB.MDBParameter("BacSy", objData.BacSy));
            Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", objData.MaBacSy));
            Command.Parameters.Add(new MDB.MDBParameter("KTVGayMe", objData.KTVGayMe));
            Command.Parameters.Add(new MDB.MDBParameter("MaKTVGayMe", objData.MaKTVGayMe));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienChinh", objData.PhauThuatVienChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienChinh", objData.MaPhauThuatVienChinh));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiThongKe", objData.NguoiThongKe));
            Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThongKe", objData.MaNguoiThongKe));
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
            string sql = "DELETE FROM BangKeThuocTrongGayMe WHERE ID = :ID";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("ID", ID));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql2 = @"SELECT D.*, '' SoNhapVien, '' MaBenhAn , ''  SoVaoVien, '' TenBenhNhan,
                        '' TUOI, '' SoYTe, '' BENHVIEN,
                        '' GioiTinh
            FROM
                BangKeThuocTrongGayMe D
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
            List<VTTH_Mau> lstDCVT = new List<VTTH_Mau>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                lstDCVT = JsonConvert.DeserializeObject < ObservableCollection <VTTH_Mau>> (Common.ConDBNull(ds.Tables[0].Rows[0]["lstDCVT"])).ToList();
            }
           ds.Tables.Add(ListToDatatable.ToDataTable(lstDCVT));
            return ds;
        }
    }
}
