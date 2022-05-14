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
    public class VTTHGayme_Mau : INotifyPropertyChanged
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
        public VTTHGayme_Mau()
        {
            Ten = "";
            DV = "";
        }
        public VTTHGayme_Mau Clone()
        {
            VTTHGayme_Mau other = (VTTHGayme_Mau)this.MemberwiseClone();
            return other;
        }
    }
    public class VTTHXetNghiem_Mau : INotifyPropertyChanged
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
                if (S != null)
                {
                    return (Common.ConDB_double(S));
                }
                else
                {
                    return null;
                }
            }
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public VTTHXetNghiem_Mau()
        {
            Ten = "";
            DV = "";
        }
        public VTTHXetNghiem_Mau Clone()
        {
            VTTHXetNghiem_Mau other = (VTTHXetNghiem_Mau)this.MemberwiseClone();
            return other;
        }
    }
    public class BangKeVTTHTrongGayMe : ThongTinKy
    {
        public BangKeVTTHTrongGayMe()
        {
            TableName = "BangKeVTTHTrongGayMe";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKVTTHTGM;
            TenMauPhieu = DanhMucPhieu.BKVTTHTGM.Description();
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
        public ObservableCollection<VTTHGayme_Mau> lstDCVT { get; set; }
        [MoTaDuLieu("Danh sách xét nghiệm")]
        public ObservableCollection<VTTHXetNghiem_Mau> lstXN { get; set; }
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
        [MoTaDuLieu("Phẫu thuật viên")]
        public string PhauThuatVien { get; set; }
        [MoTaDuLieu("mã Phẫu thuật viên")]
        public string MaPhauThuatVien { get; set; }
        [MoTaDuLieu("Dụng cụ viên")]
        public string DungCuVien { get; set; }
        [MoTaDuLieu("Mã dụng cụ viên")]
        public string MaDungCuVien { get; set; }
        [MoTaDuLieu("bác sỹ gây mê chính")]
        public string BacSyGMChinh { get; set; }
        [MoTaDuLieu("Mã bác sỹ gây mê chính")]
        public string MaBacSyGMChinh { get; set; }
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
    public class BangKeVTTHTrongGayMeFunc
    {
        public const string TableName = "BangKeVTTHTrongGayMe";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKeVTTHTrongGayMe> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKeVTTHTrongGayMe> list = new List<BangKeVTTHTrongGayMe>();
            try
            {

                string sql = @"SELECT * FROM BangKeVTTHTrongGayMe where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BangKeVTTHTrongGayMe data = new BangKeVTTHTrongGayMe();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                        data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                        data.DiaChi = DataReader["DiaChi"].ToString();
                        data.CanNang = DataReader["CanNang"].ToString();
                        data.ChanDoan = DataReader["ChanDoan"].ToString();
                        data.CachPhauThuat = DataReader["CachPhauThuat"].ToString();
                        data.NgayLamPhauThuat = Common.ConDB_DateTime(DataReader["NgayLamPhauThuat"]); 
                        data.lstDCVT = JsonConvert.DeserializeObject<ObservableCollection<VTTHGayme_Mau>>(DataReader["lstDCVT"].ToString());
                        data.lstXN = JsonConvert.DeserializeObject<ObservableCollection<VTTHXetNghiem_Mau>>(DataReader["lstXN"].ToString());
                        data.CachVoCam = DataReader["CachVoCam"].ToString();
                        data.BHYT = DataReader["BHYT"].ToString();
                        data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                        data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                        data.DungCuVien = DataReader["DungCuVien"].ToString();
                        data.MaDungCuVien = DataReader["MaDungCuVien"].ToString();
                        data.BacSyGMChinh = DataReader["BacSyGMChinh"].ToString();
                        data.MaBacSyGMChinh = DataReader["MaBacSyGMChinh"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKeVTTHTrongGayMe objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO BangKeVTTHTrongGayMe (
                                    MaQuanLy,
                                    MaBenhNhan,
                                    DiaChi,
                                    CanNang,
                                    ChanDoan,
                                    CachPhauThuat,
                                    NgayLamPhauThuat,
                                    lstDCVT,
                                    lstXN,
                                    CachVoCam,
                                    BHYT,
                                    PhauThuatVien,
                                    MaPhauThuatVien,
                                    DungCuVien,
                                    MaDungCuVien,
                                    BacSyGMChinh,
                                    MaBacSyGMChinh,
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
                                    :lstXN,
                                    :CachVoCam,
                                    :BHYT,
                                    :PhauThuatVien,
                                    :MaPhauThuatVien,
                                    :DungCuVien,
                                    :MaDungCuVien,
                                    :BacSyGMChinh,
                                    :MaBacSyGMChinh,
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
                sql = @"UPDATE BangKeVTTHTrongGayMe SET  
                                            MaQuanLy=:MaQuanLy,
                                            MaBenhNhan=:MaBenhNhan,
                                            DiaChi=:DiaChi,
                                            CanNang=:CanNang,
                                            ChanDoan=:ChanDoan,
                                            CachPhauThuat=:CachPhauThuat,
                                            NgayLamPhauThuat=:NgayLamPhauThuat,
                                            lstDCVT=:lstDCVT,
                                            lstXN=:lstXN,
                                            CachVoCam=:CachVoCam,
                                            BHYT=:BHYT,
                                            PhauThuatVien=:PhauThuatVien,
                                            MaPhauThuatVien=:MaPhauThuatVien,
                                            DungCuVien=:DungCuVien,
                                            MaDungCuVien=:MaDungCuVien,
                                            BacSyGMChinh=:BacSyGMChinh,
                                            MaBacSyGMChinh=:MaBacSyGMChinh,
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
            Command.Parameters.Add(new MDB.MDBParameter("lstXN", JsonConvert.SerializeObject(objData.lstXN)));
            Command.Parameters.Add(new MDB.MDBParameter("CachVoCam", objData.CachVoCam));
            Command.Parameters.Add(new MDB.MDBParameter("BHYT", objData.BHYT));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", objData.PhauThuatVien));
            Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", objData.MaPhauThuatVien));
            Command.Parameters.Add(new MDB.MDBParameter("DungCuVien", objData.DungCuVien));
            Command.Parameters.Add(new MDB.MDBParameter("MaDungCuVien", objData.MaDungCuVien));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyGMChinh", objData.BacSyGMChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGMChinh", objData.MaBacSyGMChinh));
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
            string sql = "DELETE FROM BangKeVTTHTrongGayMe WHERE ID = :ID";
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
                BangKeVTTHTrongGayMe D
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
            List<VTTHGayme_Mau> lstDCVT = new List<VTTHGayme_Mau>();
            List<VTTHXetNghiem_Mau> lstXN = new List<VTTHXetNghiem_Mau>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                lstDCVT = JsonConvert.DeserializeObject < ObservableCollection <VTTHGayme_Mau>> (Common.ConDBNull(ds.Tables[0].Rows[0]["lstDCVT"])).ToList();
                lstXN = JsonConvert.DeserializeObject<ObservableCollection<VTTHXetNghiem_Mau>>(Common.ConDBNull(ds.Tables[0].Rows[0]["lstXN"])).ToList();
            }
            ds.Tables.Add(ListToDatatable.ToDataTable(lstDCVT));
            ds.Tables.Add(ListToDatatable.ToDataTable(lstXN));
            return ds;
        }
    }
}
