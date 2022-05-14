
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDieuTriKhoaLaser : ThongTinKy
    {
        public PhieuDieuTriKhoaLaser()
        {
            TableName = "PhieuDieuTriKhoaLaser";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDTKL;
            TenMauPhieu = DanhMucPhieu.PDTKL.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public string BoMe { get; set; }
        public string DienThoai { get; set; }
        public DateTime? Ngay { get; set; }

        public bool[] DieuTri_1_Array { get; } = new bool[] { false, false };
        public int DieuTri_1
        {
            get
            {
                return Array.IndexOf(DieuTri_1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_1_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_1_Array[i] = true;
                    else DieuTri_1_Array[i] = false;
                }
            }
        }
        public string DieuTri_1_Text { get; set; }
        public bool[] DieuTri_2_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_2
        {
            get
            {
                return Array.IndexOf(DieuTri_2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_2_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_2_Array[i] = true;
                    else DieuTri_2_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_3_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_3
        {
            get
            {
                return Array.IndexOf(DieuTri_3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_3_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_3_Array[i] = true;
                    else DieuTri_3_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_4_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_4
        {
            get
            {
                return Array.IndexOf(DieuTri_4_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_4_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_4_Array[i] = true;
                    else DieuTri_4_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_5_Array { get; } = new bool[] { false, false };
        public int DieuTri_5
        {
            get
            {
                return Array.IndexOf(DieuTri_5_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_5_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_5_Array[i] = true;
                    else DieuTri_5_Array[i] = false;
                }
            }
        }
        public string DieuTri_5_Text { get; set; }
        public bool[] DieuTri_6_Array { get; } = new bool[] { false, false,false };
        public int DieuTri_6
        {
            get
            {
                return Array.IndexOf(DieuTri_6_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_6_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_6_Array[i] = true;
                    else DieuTri_6_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_7_Array { get; } = new bool[] { false, false,false };
        public int DieuTri_7
        {
            get
            {
                return Array.IndexOf(DieuTri_7_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_7_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_7_Array[i] = true;
                    else DieuTri_7_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_8_Array { get; } = new bool[] { false, false };
        public int DieuTri_8
        {
            get
            {
                return Array.IndexOf(DieuTri_8_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_8_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_8_Array[i] = true;
                    else DieuTri_8_Array[i] = false;
                }
            }
        }
        public string DieuTri_8_Text { get; set; }

        public bool[] DieuTri_9_Array { get; } = new bool[] { false, false };
        public int DieuTri_9
        {
            get
            {
                return Array.IndexOf(DieuTri_9_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_9_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_9_Array[i] = true;
                    else DieuTri_9_Array[i] = false;
                }
            }
        }
        public string DieuTri_9_Text { get; set; }
        public string DieuTri_10_Text { get; set; }
        public bool[] DieuTri_11_Array { get; } = new bool[] { false, false };
        public int DieuTri_11
        {
            get
            {
                return Array.IndexOf(DieuTri_11_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_11_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_11_Array[i] = true;
                    else DieuTri_11_Array[i] = false;
                }
            }
        }
        public string DieuTri_11_Text { get; set; }
        public bool[] DieuTri_12_Array { get; } = new bool[] { false, false,false, false, false,false };
        public int DieuTri_12
        {
            get
            {
                return Array.IndexOf(DieuTri_12_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_12_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_12_Array[i] = true;
                    else DieuTri_12_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_13_Array { get; } = new bool[] { false, false, false, false, false , false};
        public int DieuTri_13
        {
            get
            {
                return Array.IndexOf(DieuTri_13_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_13_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_13_Array[i] = true;
                    else DieuTri_13_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_14_Array { get; } = new bool[] { false, false,false };
        public int DieuTri_14
        {
            get
            {
                return Array.IndexOf(DieuTri_14_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_14_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_14_Array[i] = true;
                    else DieuTri_14_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_15_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_15
        {
            get
            {
                return Array.IndexOf(DieuTri_15_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_15_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_15_Array[i] = true;
                    else DieuTri_15_Array[i] = false;
                }
            }
        }
        public string DieuTri_16_Text { get; set; }
        public int DieuTri_17_1 { get; set; }
        public int DieuTri_17_2 { get; set; }
        public int DieuTri_17_3 { get; set; }
        public int DieuTri_17_4 { get; set; }
        public int DieuTri_17_5 { get; set; }
        public int DieuTri_17_6 { get; set; }
        public int DieuTri_17_7 { get; set; }
        public int DieuTri_17_8 { get; set; }
        public int DieuTri_17_9 { get; set; }
        public int DieuTri_17_10 { get; set; }
        public int DieuTri_17_11 { get; set; }
        public bool[] DieuTri_18_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_18
        {
            get
            {
                return Array.IndexOf(DieuTri_18_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_18_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_18_Array[i] = true;
                    else DieuTri_18_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_19_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_19
        {
            get
            {
                return Array.IndexOf(DieuTri_19_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_19_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_19_Array[i] = true;
                    else DieuTri_19_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_20_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_20
        {
            get
            {
                return Array.IndexOf(DieuTri_20_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_20_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_20_Array[i] = true;
                    else DieuTri_20_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_21_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_21
        {
            get
            {
                return Array.IndexOf(DieuTri_21_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_21_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_21_Array[i] = true;
                    else DieuTri_21_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_22_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_22
        {
            get
            {
                return Array.IndexOf(DieuTri_22_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_22_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_22_Array[i] = true;
                    else DieuTri_22_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_23_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_23
        {
            get
            {
                return Array.IndexOf(DieuTri_23_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_23_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_23_Array[i] = true;
                    else DieuTri_23_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_24_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_24
        {
            get
            {
                return Array.IndexOf(DieuTri_24_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_24_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_24_Array[i] = true;
                    else DieuTri_24_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_25_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_25
        {
            get
            {
                return Array.IndexOf(DieuTri_25_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_25_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_25_Array[i] = true;
                    else DieuTri_25_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_26_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_26
        {
            get
            {
                return Array.IndexOf(DieuTri_26_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_26_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_26_Array[i] = true;
                    else DieuTri_26_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_27_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_27
        {
            get
            {
                return Array.IndexOf(DieuTri_27_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_27_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_27_Array[i] = true;
                    else DieuTri_27_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_28_Array { get; } = new bool[] { false, false, false };
        public int DieuTri_28
        {
            get
            {
                return Array.IndexOf(DieuTri_28_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_28_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_28_Array[i] = true;
                    else DieuTri_28_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_29_1_Array { get; } = new bool[] { false, false };
        public int DieuTri_29_1
        {
            get
            {
                return Array.IndexOf(DieuTri_29_1_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_29_1_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_29_1_Array[i] = true;
                    else DieuTri_29_1_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_29_2_Array { get; } = new bool[] { false, false };
        public int DieuTri_29_2
        {
            get
            {
                return Array.IndexOf(DieuTri_29_2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_29_2_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_29_2_Array[i] = true;
                    else DieuTri_29_2_Array[i] = false;
                }
            }
        }
        public bool[] DieuTri_29_3_Array { get; } = new bool[] { false, false };
        public int DieuTri_29_3
        {
            get
            {
                return Array.IndexOf(DieuTri_29_3_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DieuTri_29_3_Array.Length; i++)
                {
                    if (i == (value - 1)) DieuTri_29_3_Array[i] = true;
                    else DieuTri_29_3_Array[i] = false;
                }
            }
        }
        public string DieuTri_29_Text { get; set; }
        public string DieuTri_30_Text { get; set; }
        public ObservableCollection<ThongSoDieuTriKhoaLaser> ListDieuTri { get; set; }

        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
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


    public class ThongSoDieuTriKhoaLaser
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public string Lan { get; set; }
        public DateTime Ngay { get; set; }
        public string ViTri { get; set; }
        public string DienTich { get; set; }
        public string TienTrien { get; set; }
        public string BienChung { get; set; }
        public string ThongSoDieuTri1 { get; set; }
        public string ThongSoDieuTri2 { get; set; }
        public string ThongSoDieuTri3 { get; set; }

    }

    public class PhieuDieuTriKhoaLaserFunc
    {
        public const string TableName = "PhieuDieuTriKhoaLaser";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuDieuTriKhoaLaser> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDieuTriKhoaLaser> list = new List<PhieuDieuTriKhoaLaser>();
            try
            {
                string sql = @"SELECT * FROM PhieuDieuTriKhoaLaser where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDieuTriKhoaLaser data = new PhieuDieuTriKhoaLaser();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;

                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.BoMe = DataReader["BoMe"].ToString();

                    data.DieuTri_1 = DataReader.GetInt("DieuTri_1");
                    data.DieuTri_1_Text = DataReader["DieuTri_1_Text"].ToString();
                    data.DieuTri_2 = DataReader.GetInt("DieuTri_2");
                    data.DieuTri_3 = DataReader.GetInt("DieuTri_3");
                    data.DieuTri_4 = DataReader.GetInt("DieuTri_4");
                    data.DieuTri_5 = DataReader.GetInt("DieuTri_5");
                    data.DieuTri_5_Text = DataReader["DieuTri_5_Text"].ToString();
                    data.DieuTri_6 = DataReader.GetInt("DieuTri_6");
                    data.DieuTri_7 = DataReader.GetInt("DieuTri_7");
                    data.DieuTri_8 = DataReader.GetInt("DieuTri_8");
                    data.DieuTri_8_Text = DataReader["DieuTri_8_Text"].ToString();
                    data.DieuTri_9 = DataReader.GetInt("DieuTri_9");
                    data.DieuTri_9_Text = DataReader["DieuTri_9_Text"].ToString();

                    data.DieuTri_10_Text = DataReader["DieuTri_10_Text"].ToString();
                    data.DieuTri_11 = DataReader.GetInt("DieuTri_11");
                    data.DieuTri_11_Text = DataReader["DieuTri_11_Text"].ToString();
                    data.DieuTri_12 = DataReader.GetInt("DieuTri_12");
                    data.DieuTri_13 = DataReader.GetInt("DieuTri_13");
                    data.DieuTri_14 = DataReader.GetInt("DieuTri_14");
                    data.DieuTri_15 = DataReader.GetInt("DieuTri_15");
                    data.DieuTri_16_Text = DataReader["DieuTri_16_Text"].ToString();
                    data.DieuTri_17_1 = DataReader.GetInt("DieuTri_17_1");
                    data.DieuTri_17_2 = DataReader.GetInt("DieuTri_17_2");
                    data.DieuTri_17_3 = DataReader.GetInt("DieuTri_17_3");
                    data.DieuTri_17_4 = DataReader.GetInt("DieuTri_17_4");
                    data.DieuTri_17_5 = DataReader.GetInt("DieuTri_17_5");
                    data.DieuTri_17_6 = DataReader.GetInt("DieuTri_17_6");
                    data.DieuTri_17_7 = DataReader.GetInt("DieuTri_17_7");
                    data.DieuTri_17_8 = DataReader.GetInt("DieuTri_17_8");
                    data.DieuTri_17_9 = DataReader.GetInt("DieuTri_17_9");
                    data.DieuTri_17_10 = DataReader.GetInt("DieuTri_17_10");
                    data.DieuTri_17_11 = DataReader.GetInt("DieuTri_17_11");
                    data.DieuTri_18 = DataReader.GetInt("DieuTri_18");
                    data.DieuTri_19 = DataReader.GetInt("DieuTri_19");
                    data.DieuTri_20 = DataReader.GetInt("DieuTri_20");
                    data.DieuTri_21 = DataReader.GetInt("DieuTri_21");
                    data.DieuTri_22 = DataReader.GetInt("DieuTri_22");
                    data.DieuTri_23 = DataReader.GetInt("DieuTri_23");
                    data.DieuTri_24 = DataReader.GetInt("DieuTri_24");
                    data.DieuTri_25 = DataReader.GetInt("DieuTri_25");
                    data.DieuTri_26 = DataReader.GetInt("DieuTri_26");
                    data.DieuTri_27 = DataReader.GetInt("DieuTri_27");
                    data.DieuTri_28 = DataReader.GetInt("DieuTri_28");
                    data.DieuTri_29_1 = DataReader.GetInt("DieuTri_29_1");
                    data.DieuTri_29_2 = DataReader.GetInt("DieuTri_29_2");
                    data.DieuTri_29_3 = DataReader.GetInt("DieuTri_29_3");
                    data.DieuTri_29_Text = DataReader["DieuTri_29_Text"].ToString();
                    data.DieuTri_30_Text = DataReader["DieuTri_30_Text"].ToString();

                    data.Ngay = Convert.ToDateTime(DataReader["Ngay"] == DBNull.Value ? DateTime.Now : DataReader["Ngay"]);

                    data.ListDieuTri = GetThongSoDieuTri(_OracleConnection, data.ID);

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuDieuTriKhoaLaser WHERE ID =" + IDBienBan;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuDieuTriKhoaLaser P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("MaBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["MaBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year + "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            DataTable DT = new DataTable("DT");
            DT.Columns.Add("Lan", typeof(string));
            DT.Columns.Add("Ngay", typeof(DateTime));
            DT.Columns.Add("ViTri", typeof(string));
            DT.Columns.Add("DienTich", typeof(string));
            DT.Columns.Add("TienTrien", typeof(string));
            DT.Columns.Add("BienChung", typeof(string));
            DT.Columns.Add("ThongSoDieuTri1", typeof(string));
            DT.Columns.Add("ThongSoDieuTri2", typeof(string));
            DT.Columns.Add("ThongSoDieuTri3", typeof(string));


            ObservableCollection<ThongSoDieuTriKhoaLaser> ListDieuTri = GetThongSoDieuTri(MyConnection, IDBienBan);
            if (ListDieuTri != null)
            {
                foreach (ThongSoDieuTriKhoaLaser _data in ListDieuTri)
                {
                    DT.Rows.Add(_data.Lan, _data.Ngay, _data.ViTri, _data.DienTich, _data.TienTrien, _data.BienChung, _data.ThongSoDieuTri1, _data.ThongSoDieuTri2, _data.ThongSoDieuTri3);
                }
            }
            ds.Tables.Add(DT);
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDieuTriKhoaLaser ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDieuTriKhoaLaser
                (
                    MaQuanLy,
                    DiaChi,
                    NgheNghiep,
                    BoMe,
                    DienThoai,
                    Ngay,
                    DieuTri_1,
                    DieuTri_1_Text,
                    DieuTri_2,
                    DieuTri_3,
                    DieuTri_4,
                    DieuTri_5,
                    DieuTri_5_Text,
                    DieuTri_6,
                    DieuTri_7,
                    DieuTri_8,
                    DieuTri_8_Text,
                    DieuTri_9,
                    DieuTri_9_Text,
                    DieuTri_10_Text,
                    DieuTri_11,
                    DieuTri_11_Text,
                    DieuTri_12,
                    DieuTri_13,
                    DieuTri_14,
                    DieuTri_15,
                    DieuTri_16_Text,
                    DieuTri_17_1,
                    DieuTri_17_2,
                    DieuTri_17_3,
                    DieuTri_17_4,
                    DieuTri_17_5,
                    DieuTri_17_6,
                    DieuTri_17_7,
                    DieuTri_17_8,
                    DieuTri_17_9,
                    DieuTri_17_10,
                    DieuTri_17_11,
                    DieuTri_18,
                    DieuTri_19,
                    DieuTri_20,
                    DieuTri_21,
                    DieuTri_22,
                    DieuTri_23,
                    DieuTri_24,
                    DieuTri_25,
                    DieuTri_26,
                    DieuTri_27,
                    DieuTri_28,
                    DieuTri_29_1,
                    DieuTri_29_2,
                    DieuTri_29_3,
                    DieuTri_29_Text,
                    DieuTri_30_Text,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :DiaChi,
                    :NgheNghiep,
                    :BoMe,
                    :DienThoai,
                    :Ngay,
                    :DieuTri_1,
                    :DieuTri_1_Text,
                    :DieuTri_2,
                    :DieuTri_3,
                    :DieuTri_4,
                    :DieuTri_5,
                    :DieuTri_5_Text,
                    :DieuTri_6,
                    :DieuTri_7,
                    :DieuTri_8,
                    :DieuTri_8_Text,
                    :DieuTri_9,
                    :DieuTri_9_Text,
                    :DieuTri_10_Text,
                    :DieuTri_11,
                    :DieuTri_11_Text,
                    :DieuTri_12,
                    :DieuTri_13,
                    :DieuTri_14,
                    :DieuTri_15,
                    :DieuTri_16_Text,
                    :DieuTri_17_1,
                    :DieuTri_17_2,
                    :DieuTri_17_3,
                    :DieuTri_17_4,
                    :DieuTri_17_5,
                    :DieuTri_17_6,
                    :DieuTri_17_7,
                    :DieuTri_17_8,
                    :DieuTri_17_9,
                    :DieuTri_17_10,
                    :DieuTri_17_11,
                    :DieuTri_18,
                    :DieuTri_19,
                    :DieuTri_20,
                    :DieuTri_21,
                    :DieuTri_22,
                    :DieuTri_23,
                    :DieuTri_24,
                    :DieuTri_25,
                    :DieuTri_26,
                    :DieuTri_27,
                    :DieuTri_28,
                    :DieuTri_29_1,
                    :DieuTri_29_2,
                    :DieuTri_29_3,
                    :DieuTri_29_Text,
                    :DieuTri_30_Text,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuDieuTriKhoaLaser SET 
                    MaQuanLy = :MaQuanLy,
                    DiaChi = :DiaChi,
                    NgheNghiep = :NgheNghiep,
                    BoMe = :BoMe,
                    DienThoai = :DienThoai,
                    Ngay = :Ngay,
                    DieuTri_1 = :DieuTri_1,
                    DieuTri_1_Text = :DieuTri_1_Text,
                    DieuTri_2 = :DieuTri_2,
                    DieuTri_3 = :DieuTri_3,
                    DieuTri_4 = :DieuTri_4,
                    DieuTri_5 = :DieuTri_5,
                    DieuTri_5_Text = :DieuTri_5_Text,
                    DieuTri_6 = :DieuTri_6,
                    DieuTri_7 = :DieuTri_7,
                    DieuTri_8 = :DieuTri_8,
                    DieuTri_8_Text = :DieuTri_8_Text,
                    DieuTri_9 = :DieuTri_9,
                    DieuTri_9_Text = :DieuTri_9_Text,
                    DieuTri_10_Text = :DieuTri_10_Text,
                    DieuTri_11 = :DieuTri_11,
                    DieuTri_11_Text = :DieuTri_11_Text,
                    DieuTri_12 = :DieuTri_12,
                    DieuTri_13 = :DieuTri_13,
                    DieuTri_14 = :DieuTri_14,
                    DieuTri_15 = :DieuTri_15,
                    DieuTri_16_Text = :DieuTri_16_Text,
                    DieuTri_17_1 = :DieuTri_17_1,
                    DieuTri_17_2 = :DieuTri_17_2,
                    DieuTri_17_3 = :DieuTri_17_3,
                    DieuTri_17_4 = :DieuTri_17_4,
                    DieuTri_17_5 = :DieuTri_17_5,
                    DieuTri_17_6 = :DieuTri_17_6,
                    DieuTri_17_7 = :DieuTri_17_7,
                    DieuTri_17_8 = :DieuTri_17_8,
                    DieuTri_17_9 = :DieuTri_17_9,
                    DieuTri_17_10 = :DieuTri_17_10,
                    DieuTri_17_11 = :DieuTri_17_11,
                    DieuTri_18 = :DieuTri_18,
                    DieuTri_19 = :DieuTri_19,
                    DieuTri_20 = :DieuTri_20,
                    DieuTri_21 = :DieuTri_21,
                    DieuTri_22 = :DieuTri_22,
                    DieuTri_23 = :DieuTri_23,
                    DieuTri_24 = :DieuTri_24,
                    DieuTri_25 = :DieuTri_25,
                    DieuTri_26 = :DieuTri_26,
                    DieuTri_27 = :DieuTri_27,
                    DieuTri_28 = :DieuTri_28,
                    DieuTri_29_1 = :DieuTri_29_1,
                    DieuTri_29_2 = :DieuTri_29_2,
                    DieuTri_29_3 = :DieuTri_29_3,
                    DieuTri_29_Text = :DieuTri_29_Text,
                    DieuTri_30_Text = :DieuTri_30_Text,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("BoMe", ketQua.BoMe));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", ketQua.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay", ketQua.Ngay));

                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_1", ketQua.DieuTri_1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_2", ketQua.DieuTri_2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_3", ketQua.DieuTri_3));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_4", ketQua.DieuTri_4));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_5", ketQua.DieuTri_5));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_6", ketQua.DieuTri_6));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_7", ketQua.DieuTri_7));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_8", ketQua.DieuTri_8));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_9", ketQua.DieuTri_9));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_11", ketQua.DieuTri_11));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_12", ketQua.DieuTri_12));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_13", ketQua.DieuTri_13));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_14", ketQua.DieuTri_14));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_15", ketQua.DieuTri_15));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17_1", ketQua.DieuTri_17_1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17_2", ketQua.DieuTri_17_2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17_3", ketQua.DieuTri_17_3));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17_4", ketQua.DieuTri_17_4));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17_5", ketQua.DieuTri_17_5));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17_6", ketQua.DieuTri_17_6));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17_7", ketQua.DieuTri_17_7));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17_8", ketQua.DieuTri_17_8));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17_9", ketQua.DieuTri_17_9));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17_10", ketQua.DieuTri_17_10));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_17_11", ketQua.DieuTri_17_11));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_18", ketQua.DieuTri_18));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_19", ketQua.DieuTri_19));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_20", ketQua.DieuTri_20));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_21", ketQua.DieuTri_21));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_22", ketQua.DieuTri_22));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_23", ketQua.DieuTri_23));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_24", ketQua.DieuTri_24));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_25", ketQua.DieuTri_25));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_26", ketQua.DieuTri_26));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_27", ketQua.DieuTri_27));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_28", ketQua.DieuTri_28));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_29_1", ketQua.DieuTri_29_1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_29_2", ketQua.DieuTri_29_2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_29_3", ketQua.DieuTri_29_3));

                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_1_Text", ketQua.DieuTri_1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_5_Text", ketQua.DieuTri_5_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_8_Text", ketQua.DieuTri_8_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_9_Text", ketQua.DieuTri_9_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_10_Text", ketQua.DieuTri_10_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_11_Text", ketQua.DieuTri_11_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_16_Text", ketQua.DieuTri_16_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_29_Text", ketQua.DieuTri_29_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_30_Text", ketQua.DieuTri_30_Text));


                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }

        public static ObservableCollection<ThongSoDieuTriKhoaLaser> GetThongSoDieuTri(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<ThongSoDieuTriKhoaLaser> ThongSoDieuTriKhoaLasers = new ObservableCollection<ThongSoDieuTriKhoaLaser>();
            try
            {
                string sql = @"SELECT * FROM ThongSoDieuTriKhoaLaser where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ThongSoDieuTriKhoaLaser data = new ThongSoDieuTriKhoaLaser();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.Lan = DataReader["Lan"].ToString();
                    data.Ngay = Convert.ToDateTime(DataReader["Ngay"] == DBNull.Value ? DateTime.Now : DataReader["Ngay"]);
                    data.ViTri = DataReader["ViTri"].ToString();
                    data.DienTich = DataReader["DienTich"].ToString();
                    data.TienTrien = DataReader["TienTrien"].ToString();
                    data.BienChung = DataReader["BienChung"].ToString();
                    data.ThongSoDieuTri1 = DataReader["ThongSoDieuTri1"].ToString();
                    data.ThongSoDieuTri2 = DataReader["ThongSoDieuTri2"].ToString();
                    data.ThongSoDieuTri3 = DataReader["ThongSoDieuTri3"].ToString();

                    ThongSoDieuTriKhoaLasers.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return ThongSoDieuTriKhoaLasers;
        }
        public static bool DeleteThongSoDieuTri(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM ThongSoDieuTriKhoaLaser WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool InsertOrUpdateThongSoDieuTri(MDB.MDBConnection MyConnection, ThongSoDieuTriKhoaLaser _ThongSoDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO ThongSoDieuTriKhoaLaser
                (
                    ID_Phieu,
                    Lan,
                    Ngay,
                    ViTri,
                    DienTich,
                    TienTrien,
                    BienChung,
                    ThongSoDieuTri1,
                    ThongSoDieuTri2,
                    ThongSoDieuTri3)  VALUES
                 (
				    :ID_Phieu,
                    :Lan,
                    :Ngay,
                    :ViTri,
                    :DienTich,
                    :TienTrien,
                    :BienChung,
                    :ThongSoDieuTri1,
                    :ThongSoDieuTri2,
                    :ThongSoDieuTri3
                 )";
                if (_ThongSoDieuTri.ID != 0)
                {
                    sql = @"UPDATE ThongSoDieuTriKhoaLaser SET 
                    ID_Phieu = :ID_Phieu,
                    Lan = :Lan,
                    Ngay = :Ngay,
                    ViTri = :ViTri,
                    DienTich = :DienTich,
                    TienTrien = :TienTrien,
                    BienChung = :BienChung,
                    ThongSoDieuTri1 = :ThongSoDieuTri1,
                    ThongSoDieuTri2 = :ThongSoDieuTri2,
                    ThongSoDieuTri3 = :ThongSoDieuTri3
                    WHERE ID = " + _ThongSoDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _ThongSoDieuTri.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("Lan", _ThongSoDieuTri.Lan));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay", _ThongSoDieuTri.Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("ViTri", _ThongSoDieuTri.ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("DienTich", _ThongSoDieuTri.DienTich));
                Command.Parameters.Add(new MDB.MDBParameter("TienTrien", _ThongSoDieuTri.TienTrien));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung", _ThongSoDieuTri.BienChung));
                Command.Parameters.Add(new MDB.MDBParameter("ThongSoDieuTri1", _ThongSoDieuTri.ThongSoDieuTri1));
                Command.Parameters.Add(new MDB.MDBParameter("ThongSoDieuTri2", _ThongSoDieuTri.ThongSoDieuTri2));
                Command.Parameters.Add(new MDB.MDBParameter("ThongSoDieuTri3", _ThongSoDieuTri.ThongSoDieuTri3));

                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
    }
}
