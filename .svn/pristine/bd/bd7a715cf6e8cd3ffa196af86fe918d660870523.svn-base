using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class DanhGiaTinhTrangDDTren18TTbl : ThongTinKy
    {
        public DanhGiaTinhTrangDDTren18TTbl()
        {
            IDMauPhieu = (int)DanhMucPhieu.PDGTTDD18;
            TenMauPhieu = DanhMucPhieu.PDGTTDD18.Description();
        }

        [MoTaDuLieu("Mã định danh")]
		public long IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        public float? ChieuCao { get; set; }
        public float? CanNangRaVien { get; set; }
        public float? CanNang { get; set; }
        public float? BMI { get; set; }
        public bool[] SLBMIL1Array { get; } = new bool[] { false, false };

        public int SLBMIL1 {
            get
            {
                return Array.IndexOf(SLBMIL1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLBMIL1Array.Length; i++)
                {
                    if (i == (value - 1)) SLBMIL1Array[i] = true;
                    else SLBMIL1Array[i] = false;
                }
            }
        }
        public bool[] SLBMIL2Array { get; } = new bool[] { false, false };

        public int SLBMIL2 {
            get
            {
                return Array.IndexOf(SLBMIL2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLBMIL2Array.Length; i++)
                {
                    if (i == (value - 1)) SLBMIL2Array[i] = true;
                    else SLBMIL2Array[i] = false;
                }
            }
        }
        public bool[] SLSutCanL1Array { get; } = new bool[] { false, false };

        public int SLSutCanL1 {
            get
            {
                return Array.IndexOf(SLSutCanL1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLSutCanL1Array.Length; i++)
                {
                    if (i == (value - 1)) SLSutCanL1Array[i] = true;
                    else SLSutCanL1Array[i] = false;
                }
            }
        }
        public bool[] SLSutCanL2Array { get; } = new bool[] { false, false };

        public int SLSutCanL2 {
            get
            {
                return Array.IndexOf(SLSutCanL2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLSutCanL2Array.Length; i++)
                {
                    if (i == (value - 1)) SLSutCanL2Array[i] = true;
                    else SLSutCanL2Array[i] = false;
                }
            }
        }
        public bool[] SLLuongAnSutL1Array { get; } = new bool[] { false, false };

        public int SLLuongAnSutL1 {
            get
            {
                return Array.IndexOf(SLLuongAnSutL1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLLuongAnSutL1Array.Length; i++)
                {
                    if (i == (value - 1)) SLLuongAnSutL1Array[i] = true;
                    else SLLuongAnSutL1Array[i] = false;
                }
            }
        }
        public bool[] SLLuongAnSutL2Array { get; } = new bool[] { false, false };

        public int SLLuongAnSutL2 {
            get
            {
                return Array.IndexOf(SLLuongAnSutL2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLLuongAnSutL2Array.Length; i++)
                {
                    if (i == (value - 1)) SLLuongAnSutL2Array[i] = true;
                    else SLLuongAnSutL2Array[i] = false;
                }
            }
        }
        public bool[] SLBenhNangL1Array { get; } = new bool[] { false, false };

        public int SLBenhNangL1 {
            get
            {
                return Array.IndexOf(SLBenhNangL1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLBenhNangL1Array.Length; i++)
                {
                    if (i == (value - 1)) SLBenhNangL1Array[i] = true;
                    else SLBenhNangL1Array[i] = false;
                }
            }
        }
        public bool[] SLBenhNangL2Array { get; } = new bool[] { false, false };

        public int SLBenhNangL2 {
            get
            {
                return Array.IndexOf(SLBenhNangL2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLBenhNangL2Array.Length; i++)
                {
                    if (i == (value - 1)) SLBenhNangL2Array[i] = true;
                    else SLBenhNangL2Array[i] = false;
                }
            }
        }
        public bool[] SLKetLuanL1Array { get; } = new bool[] { false, false };

        public int SLKetLuanL1 {
            get
            {
                return Array.IndexOf(SLKetLuanL1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLKetLuanL1Array.Length; i++)
                {
                    if (i == (value - 1)) SLKetLuanL1Array[i] = true;
                    else SLKetLuanL1Array[i] = false;
                }
            }
        }
        public bool[] SLKetLuanL2Array { get; } = new bool[] { false, false };

        public int SLKetLuanL2 {
            get
            {
                return Array.IndexOf(SLKetLuanL2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLKetLuanL2Array.Length; i++)
                {
                    if (i == (value - 1)) SLKetLuanL2Array[i] = true;
                    else SLKetLuanL2Array[i] = false;
                }
            }
        }
        public bool[] SLChiDinhL1Array { get; } = new bool[] { false, false };

        public int SLChiDinhL1 {
            get
            {
                return Array.IndexOf(SLChiDinhL1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLChiDinhL1Array.Length; i++)
                {
                    if (i == (value - 1)) SLChiDinhL1Array[i] = true;
                    else SLChiDinhL1Array[i] = false;
                }
            }
        }
        public bool[] SLChiDinhL2Array { get; } = new bool[] { false, false };

        public int SLChiDinhL2 {
            get
            {
                return Array.IndexOf(SLChiDinhL2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < SLChiDinhL2Array.Length; i++)
                {
                    if (i == (value - 1)) SLChiDinhL2Array[i] = true;
                    else SLChiDinhL2Array[i] = false;
                }
            }
        }
        public bool[] DGBMIL1Array { get; } = new bool[] { false, false, false };

        public int DGBMIL1 {
            get
            {
                return Array.IndexOf(DGBMIL1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DGBMIL1Array.Length; i++)
                {
                    if (i == (value - 1)) DGBMIL1Array[i] = true;
                    else DGBMIL1Array[i] = false;
                }
            }
        }
        public bool[] DGBMIL2Array { get; } = new bool[] { false, false, false };

        public int DGBMIL2 {
            get
            {
                return Array.IndexOf(DGBMIL2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DGBMIL2Array.Length; i++)
                {
                    if (i == (value - 1)) DGBMIL2Array[i] = true;
                    else DGBMIL2Array[i] = false;
                }
            }
        }
        public bool[] DGSutCanL1Array { get; } = new bool[] { false, false, false };

        public int DGSutCanL1 {
            get
            {
                return Array.IndexOf(DGSutCanL1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DGSutCanL1Array.Length; i++)
                {
                    if (i == (value - 1)) DGSutCanL1Array[i] = true;
                    else DGSutCanL1Array[i] = false;
                }
            }
        }
        public bool[] DGSutCanL2Array { get; } = new bool[] { false, false, false };

        public int DGSutCanL2 {
            get
            {
                return Array.IndexOf(DGSutCanL2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DGSutCanL2Array.Length; i++)
                {
                    if (i == (value - 1)) DGSutCanL2Array[i] = true;
                    else DGSutCanL2Array[i] = false;
                }
            }
        }
        public bool[] DGLuongAnL1Array { get; } = new bool[] { false, false, false };

        public int DGLuongAnL1 {
            get
            {
                return Array.IndexOf(DGLuongAnL1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DGLuongAnL1Array.Length; i++)
                {
                    if (i == (value - 1)) DGLuongAnL1Array[i] = true;
                    else DGLuongAnL1Array[i] = false;
                }
            }
        }
        public bool[] DGLuongAnL2Array { get; } = new bool[] { false, false, false };

        public int DGLuongAnL2 {
            get
            {
                return Array.IndexOf(DGLuongAnL2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DGLuongAnL2Array.Length; i++)
                {
                    if (i == (value - 1)) DGLuongAnL2Array[i] = true;
                    else DGLuongAnL2Array[i] = false;
                }
            }
        }
        public bool[] DGbenhLyL1Array { get; } = new bool[] { false, false, false };

        public int DGbenhLyL1 {
            get
            {
                return Array.IndexOf(DGbenhLyL1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DGbenhLyL1Array.Length; i++)
                {
                    if (i == (value - 1)) DGbenhLyL1Array[i] = true;
                    else DGbenhLyL1Array[i] = false;
                }
            }
        }
        public bool[] DGbenhLyL2Array { get; } = new bool[] { false, false, false };

        public int DGbenhLyL2 {
            get
            {
                return Array.IndexOf(DGbenhLyL2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DGbenhLyL2Array.Length; i++)
                {
                    if (i == (value - 1)) DGbenhLyL2Array[i] = true;
                    else DGbenhLyL2Array[i] = false;
                }
            }
        }
        public bool[] DGKetLuanL1Array { get; } = new bool[] { false, false };

        public int DGKetLuanL1 {
            get
            {
                return Array.IndexOf(DGKetLuanL1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DGKetLuanL1Array.Length; i++)
                {
                    if (i == (value - 1)) DGKetLuanL1Array[i] = true;
                    else DGKetLuanL1Array[i] = false;
                }
            }
        }
        public bool[] DGKetLuanL2Array { get; } = new bool[] { false, false };

        public int DGKetLuanL2 {
            get
            {
                return Array.IndexOf(DGKetLuanL2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DGKetLuanL2Array.Length; i++)
                {
                    if (i == (value - 1)) DGKetLuanL2Array[i] = true;
                    else DGKetLuanL2Array[i] = false;
                }
            }
        }
        public bool[] KHDuongNuoiAn1Array { get; } = new bool[] { false };
        public int KHDuongNuoiAn1 
        { 
            get
            {
                return Array.IndexOf(KHDuongNuoiAn1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < KHDuongNuoiAn1Array.Length; i++)
                {
                    if (i == (value - 1)) KHDuongNuoiAn1Array[i] = true;
                    else KHDuongNuoiAn1Array[i] = false;
                }
            } 
        }
        public bool[] KHDuongNuoiAn2Array { get; } = new bool[] { false };
        public int KHDuongNuoiAn2 {
            get
            {
                return Array.IndexOf(KHDuongNuoiAn2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < KHDuongNuoiAn2Array.Length; i++)
                {
                    if (i == (value - 1)) KHDuongNuoiAn2Array[i] = true;
                    else KHDuongNuoiAn2Array[i] = false;
                }
            }
        }
        public bool[] KHDuongNuoiAn3Array { get; } = new bool[] { false };
        public int KHDuongNuoiAn3
        {
            get
            {
                return Array.IndexOf(KHDuongNuoiAn3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < KHDuongNuoiAn3Array.Length; i++)
                {
                    if (i == (value - 1)) KHDuongNuoiAn3Array[i] = true;
                    else KHDuongNuoiAn3Array[i] = false;
                }
            }
        }
        public bool[] HoiChanDDArray { get; } = new bool[] { false, false };

        public int HoiChanDD {
            get
            {
                return Array.IndexOf(HoiChanDDArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < HoiChanDDArray.Length; i++)
                {
                    if (i == (value - 1)) HoiChanDDArray[i] = true;
                    else HoiChanDDArray[i] = false;
                }
            }
        }
        public bool[] KHTaiDanhGiaArray { get; } = new bool[] { false, false };

        public int KHTaiDanhGia {
            get
            {
                return Array.IndexOf(KHTaiDanhGiaArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < KHTaiDanhGiaArray.Length; i++)
                {
                    if (i == (value - 1)) KHTaiDanhGiaArray[i] = true;
                    else KHTaiDanhGiaArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
        public string TenNguoiThucHien { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class DanhGiaTinhTrangDDTren18TFunc
    {
        public const string TableName = "DanhGiaTinhTrangDDTren18T";
        public const string TablePrimaryKeyName = "IDPhieu";
        public static List<DanhGiaTinhTrangDDTren18TTbl> GetListData(MDB.MDBConnection MyConnection, decimal MaQuanly)
        {
            try
            {
                {
                    List<DanhGiaTinhTrangDDTren18TTbl> lstObject = new List<DanhGiaTinhTrangDDTren18TTbl>();
                    string sql = "SELECT * FROM DanhGiaTinhTrangDDTren18T   WHERE MaQuanLy = :MaQuanLy ORDER BY IDPhieu DESC";
                    MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                    command.Parameters.Add(new MDB.MDBParameter("MaQuanly", MaQuanly));
                    MDB.MDBDataReader DataReader = command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        DanhGiaTinhTrangDDTren18TTbl obj = new DanhGiaTinhTrangDDTren18TTbl();
                        obj.IDPhieu = Common.ConDB_Int(DataReader["IDPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Int(DataReader["MaQuanLy"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.MaBenhAn = Common.ConDBNull(DataReader["MaBenhAn"]);
                        obj.ChieuCao = Common.ConDBNull_float(DataReader["ChieuCao"]);
                        obj.CanNangRaVien = Common.ConDBNull_float(DataReader["CanNangRaVien"]);
                        obj.CanNang = Common.ConDBNull_float(DataReader["CanNang"]);
                        obj.BMI = Common.ConDBNull_float(DataReader["BMI"]);
                        obj.SLBMIL1 = Common.ConDB_Int(DataReader["SLBMIL1"]);
                        obj.SLBMIL2 = Common.ConDB_Int(DataReader["SLBMIL2"]);
                        obj.SLSutCanL1 = Common.ConDB_Int(DataReader["SLSutCanL1"]);
                        obj.SLSutCanL2 = Common.ConDB_Int(DataReader["SLSutCanL2"]);
                        obj.SLLuongAnSutL1 = Common.ConDB_Int(DataReader["SLLuongAnSutL1"]);
                        obj.SLLuongAnSutL2 = Common.ConDB_Int(DataReader["SLLuongAnSutL2"]);
                        obj.SLBenhNangL1 = Common.ConDB_Int(DataReader["SLBenhNangL1"]);
                        obj.SLBenhNangL2 = Common.ConDB_Int(DataReader["SLBenhNangL2"]);
                        obj.SLKetLuanL1 = Common.ConDB_Int(DataReader["SLKetLuanL1"]);
                        obj.SLKetLuanL2 = Common.ConDB_Int(DataReader["SLKetLuanL2"]);
                        obj.SLChiDinhL1 = Common.ConDB_Int(DataReader["SLChiDinhL1"]);
                        obj.SLChiDinhL2 = Common.ConDB_Int(DataReader["SLChiDinhL2"]);
                        obj.DGBMIL1 = Common.ConDB_Int(DataReader["DGBMIL1"]);
                        obj.DGBMIL2 = Common.ConDB_Int(DataReader["DGBMIL2"]);
                        obj.DGSutCanL1 = Common.ConDB_Int(DataReader["DGSutCanL1"]);
                        obj.DGSutCanL2 = Common.ConDB_Int(DataReader["DGSutCanL2"]);
                        obj.DGLuongAnL1 = Common.ConDB_Int(DataReader["DGLuongAnL1"]);
                        obj.DGLuongAnL2 = Common.ConDB_Int(DataReader["DGLuongAnL2"]);
                        obj.DGbenhLyL1 = Common.ConDB_Int(DataReader["DGbenhLyL1"]);
                        obj.DGbenhLyL2 = Common.ConDB_Int(DataReader["DGbenhLyL2"]);
                        obj.DGKetLuanL1 = Common.ConDB_Int(DataReader["DGKetLuanL1"]);
                        obj.DGKetLuanL2 = Common.ConDB_Int(DataReader["DGKetLuanL2"]);
                        obj.KHDuongNuoiAn1 = Common.ConDB_Int(DataReader["KHDuongNuoiAn1"]);
                        obj.KHDuongNuoiAn2 = Common.ConDB_Int(DataReader["KHDuongNuoiAn2"]);
                        obj.KHDuongNuoiAn3 = Common.ConDB_Int(DataReader["KHDuongNuoiAn3"]);
                        obj.HoiChanDD = Common.ConDB_Int(DataReader["HoiChanDD"]);
                        obj.KHTaiDanhGia = Common.ConDB_Int(DataReader["KHTaiDanhGia"]);
                        obj.MaNguoiThucHien = Common.ConDBNull(DataReader["MaNguoiThucHien"]);
                        obj.TenNguoiThucHien = Common.ConDBNull(DataReader["TenNguoiThucHien"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                        obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                        obj.Chon = false;
                        lstObject.Add(obj);
                    }

                    return lstObject;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DanhGiaTinhTrangDDTren18TTbl GeData(MDB.MDBConnection MyConnection, decimal MaQuanly)
        {
            try
            {
                {
                    DanhGiaTinhTrangDDTren18TTbl obj = new DanhGiaTinhTrangDDTren18TTbl();
                    string sql = @"SELECT t.*
                    FROM DanhGiaTinhTrangDDTren18T t
                    WHERE t.MaQuanLy = :MaQuanLy";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanly));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        obj.IDPhieu = Common.ConDB_Int(DataReader["IDPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Int(DataReader["MaQuanLy"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.MaBenhAn = Common.ConDBNull(DataReader["MaBenhAn"]);
                        obj.ChieuCao = Common.ConDBNull_float(DataReader["ChieuCao"]);
                        obj.CanNangRaVien = Common.ConDBNull_float(DataReader["CanNangRaVien"]);
                        obj.CanNang = Common.ConDBNull_float(DataReader["CanNang"]);
                        obj.BMI = Common.ConDBNull_float(DataReader["BMI"]);
                        obj.SLBMIL1 = Common.ConDB_Int(DataReader["SLBMIL1"]);
                        obj.SLBMIL2 = Common.ConDB_Int(DataReader["SLBMIL2"]);
                        obj.SLSutCanL1 = Common.ConDB_Int(DataReader["SLSutCanL1"]);
                        obj.SLSutCanL2 = Common.ConDB_Int(DataReader["SLSutCanL2"]);
                        obj.SLLuongAnSutL1 = Common.ConDB_Int(DataReader["SLLuongAnSutL1"]);
                        obj.SLLuongAnSutL2 = Common.ConDB_Int(DataReader["SLLuongAnSutL2"]);
                        obj.SLBenhNangL1 = Common.ConDB_Int(DataReader["SLBenhNangL1"]);
                        obj.SLBenhNangL2 = Common.ConDB_Int(DataReader["SLBenhNangL2"]);
                        obj.SLKetLuanL1 = Common.ConDB_Int(DataReader["SLKetLuanL1"]);
                        obj.SLKetLuanL2 = Common.ConDB_Int(DataReader["SLKetLuanL2"]);
                        obj.SLChiDinhL1 = Common.ConDB_Int(DataReader["SLChiDinhL1"]);
                        obj.SLChiDinhL2 = Common.ConDB_Int(DataReader["SLChiDinhL2"]);
                        obj.DGBMIL1 = Common.ConDB_Int(DataReader["DGBMIL1"]);
                        obj.DGBMIL2 = Common.ConDB_Int(DataReader["DGBMIL2"]);
                        obj.DGSutCanL1 = Common.ConDB_Int(DataReader["DGSutCanL1"]);
                        obj.DGSutCanL2 = Common.ConDB_Int(DataReader["DGSutCanL2"]);
                        obj.DGLuongAnL1 = Common.ConDB_Int(DataReader["DGLuongAnL1"]);
                        obj.DGLuongAnL2 = Common.ConDB_Int(DataReader["DGLuongAnL2"]);
                        obj.DGbenhLyL1 = Common.ConDB_Int(DataReader["DGbenhLyL1"]);
                        obj.DGbenhLyL2 = Common.ConDB_Int(DataReader["DGbenhLyL2"]);
                        obj.DGKetLuanL1 = Common.ConDB_Int(DataReader["DGKetLuanL1"]);
                        obj.DGKetLuanL2 = Common.ConDB_Int(DataReader["DGKetLuanL2"]);
                        obj.KHDuongNuoiAn1 = Common.ConDB_Int(DataReader["KHDuongNuoiAn1"]);
                        obj.KHDuongNuoiAn2 = Common.ConDB_Int(DataReader["KHDuongNuoiAn2"]);
                        obj.KHDuongNuoiAn3 = Common.ConDB_Int(DataReader["KHDuongNuoiAn3"]);
                        obj.HoiChanDD = Common.ConDB_Int(DataReader["HoiChanDD"]);
                        obj.KHTaiDanhGia = Common.ConDB_Int(DataReader["KHTaiDanhGia"]);
                        obj.MaNguoiThucHien = Common.ConDBNull(DataReader["MaNguoiThucHien"]);
                        obj.TenNguoiThucHien = Common.ConDBNull(DataReader["TenNguoiThucHien"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                        obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    }

                    return obj;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDBienBan)
        {
            string sql = @"SELECT P.*, T.SoNhapVien,T.MaBenhAn, 
                H.TUOI,H.SoYTe, H.BENHVIEN, H.NgaySinh, H.NgheNghiep
                  FROM DanhGiaTinhTrangDDTren18T P 
                Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                  where IDPhieu  = :IDPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, DanhGiaTinhTrangDDTren18TTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM DanhGiaTinhTrangDDTren18T WHERE IDPhieu  = :IDPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDPhieu", obj.IDPhieu);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    sql = "update DanhGiaTinhTrangDDTren18T set MaQuanLy= :MaQuanLy,ChanDoan= :ChanDoan,MaBenhNhan= :MaBenhNhan,TenBenhNhan= :TenBenhNhan,GioiTinh= :GioiTinh, Khoa= :Khoa,MaKhoa= :MaKhoa,MaBenhAn= :MaBenhAn,ChieuCao= :ChieuCao,CanNangRaVien= :CanNangRaVien,CanNang= :CanNang,BMI= :BMI,SLBMIL1= :SLBMIL1,SLBMIL2= :SLBMIL2,SLSutCanL1= :SLSutCanL1,SLSutCanL2= :SLSutCanL2,SLLuongAnSutL1= :SLLuongAnSutL1,SLLuongAnSutL2= :SLLuongAnSutL2,SLBenhNangL1= :SLBenhNangL1,SLBenhNangL2= :SLBenhNangL2,SLKetLuanL1= :SLKetLuanL1,SLKetLuanL2= :SLKetLuanL2,SLChiDinhL1= :SLChiDinhL1,SLChiDinhL2= :SLChiDinhL2,DGBMIL1= :DGBMIL1,DGBMIL2= :DGBMIL2,DGSutCanL1= :DGSutCanL1,DGSutCanL2= :DGSutCanL2,DGLuongAnL1= :DGLuongAnL1,DGLuongAnL2= :DGLuongAnL2,DGbenhLyL1= :DGbenhLyL1,DGbenhLyL2= :DGbenhLyL2,DGKetLuanL1= :DGKetLuanL1,DGKetLuanL2= :DGKetLuanL2,KHDuongNuoiAn1= :KHDuongNuoiAn1,KHDuongNuoiAn2= :KHDuongNuoiAn2,KHDuongNuoiAn3= :KHDuongNuoiAn3,HoiChanDD= :HoiChanDD,KHTaiDanhGia= :KHTaiDanhGia,MaNguoiThucHien= :MaNguoiThucHien,TenNguoiThucHien= :TenNguoiThucHien,NgayTao= :NgayTao,NgaySua= :NgaySua";
                    sql = sql + " WHERE IDPhieu  = " + obj.IDPhieu.ToString();
                }
                else
                {
                    sql = @"insert into DanhGiaTinhTrangDDTren18T(MaQuanLy,ChanDoan,MaBenhNhan,TenBenhNhan,GioiTinh,Khoa,MaKhoa,MaBenhAn,ChieuCao,CanNangRaVien,CanNang,BMI,SLBMIL1,SLBMIL2,SLSutCanL1,SLSutCanL2,SLLuongAnSutL1,SLLuongAnSutL2,SLBenhNangL1,SLBenhNangL2,SLKetLuanL1,SLKetLuanL2,SLChiDinhL1,SLChiDinhL2,DGBMIL1,DGBMIL2,DGSutCanL1,DGSutCanL2,DGLuongAnL1,DGLuongAnL2,DGbenhLyL1,DGbenhLyL2,DGKetLuanL1,DGKetLuanL2,KHDuongNuoiAn1,KHDuongNuoiAn2,KHDuongNuoiAn3,HoiChanDD,KHTaiDanhGia,MaNguoiThucHien,TenNguoiThucHien, NgayTao, NgaySua" +
                        ")";
                    sql = sql + @"Values(:MaQuanLy, :ChanDoan, :MaBenhNhan, :TenBenhNhan, :GioiTinh, :Khoa, :MaKhoa, :MaBenhAn, :ChieuCao,:CanNangRaVien, :CanNang, :BMI, :SLBMIL1, :SLBMIL2, :SLSutCanL1, :SLSutCanL2, :SLLuongAnSutL1, :SLLuongAnSutL2, :SLBenhNangL1, :SLBenhNangL2, :SLKetLuanL1, :SLKetLuanL2, :SLChiDinhL1, :SLChiDinhL2, :DGBMIL1, :DGBMIL2, :DGSutCanL1, :DGSutCanL2, :DGLuongAnL1, :DGLuongAnL2, :DGbenhLyL1, :DGbenhLyL2, :DGKetLuanL1, :DGKetLuanL2, :KHDuongNuoiAn1,:KHDuongNuoiAn2,:KHDuongNuoiAn3, :HoiChanDD, :KHTaiDanhGia, :MaNguoiThucHien, :TenNguoiThucHien, :NgayTao, :NgaySua" +
                        ")   RETURNING IDPhieu INTO :IDPhieu";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhAn", obj.MaBenhAn));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNangRaVien", obj.CanNangRaVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBMIL1", obj.SLBMIL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBMIL2", obj.SLBMIL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLSutCanL1", obj.SLSutCanL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLSutCanL2", obj.SLSutCanL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLLuongAnSutL1", obj.SLLuongAnSutL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLLuongAnSutL2", obj.SLLuongAnSutL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBenhNangL1", obj.SLBenhNangL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLBenhNangL2", obj.SLBenhNangL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLKetLuanL1", obj.SLKetLuanL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLKetLuanL2", obj.SLKetLuanL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLChiDinhL1", obj.SLChiDinhL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SLChiDinhL2", obj.SLChiDinhL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGBMIL1", obj.DGBMIL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGBMIL2", obj.DGBMIL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGSutCanL1", obj.DGSutCanL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGSutCanL2", obj.DGSutCanL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGLuongAnL1", obj.DGLuongAnL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGLuongAnL2", obj.DGLuongAnL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGbenhLyL1", obj.DGbenhLyL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGbenhLyL2", obj.DGbenhLyL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGKetLuanL1", obj.DGKetLuanL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DGKetLuanL2", obj.DGKetLuanL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHDuongNuoiAn1", obj.KHDuongNuoiAn1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHDuongNuoiAn2", obj.KHDuongNuoiAn2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHDuongNuoiAn3", obj.KHDuongNuoiAn3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoiChanDD", obj.HoiChanDD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KHTaiDanhGia", obj.KHTaiDanhGia));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", obj.MaNguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiThucHien", obj.TenNguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));

                if (!isUpdate)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                }
                nRecord = oracleCommand.ExecuteNonQuery();
                if (nRecord > 0)
                {
                    if (!isUpdate)
                    {
                        long nextval = (long)((oracleCommand.Parameters["IDPhieu"] as MDB.MDBParameter).Value);
                        obj.IDPhieu = nextval;
                    }
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        //20201031 tunght icloud custorm 
        //public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDbienBan)
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, List<decimal> lstIDbienBan)
        {
            try
            {
                string sql = "";
                string strWhere = "";
                MDB.MDBCommand oracleCommand;
                strWhere = " IDPhieu In(";
                if (lstIDbienBan.Count > 0)
                {
                    for (int i = 0; i < lstIDbienBan.Count; i++)
                    {
                        strWhere = strWhere + lstIDbienBan[i].ToString();
                        if (i == (lstIDbienBan.Count - 1))
                        {
                            strWhere = strWhere + ")";
                        }
                        else
                        {
                            strWhere = strWhere + ",";
                        }
                    }
                }
                sql = @"DELETE FROM DanhGiaTinhTrangDDTren18T WHERE  " + strWhere;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
    }
}
