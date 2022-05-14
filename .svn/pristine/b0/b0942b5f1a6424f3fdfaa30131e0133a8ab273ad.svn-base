
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangHoiSucKhoeBNPHQ : ThongTinKy
    {
        public BangHoiSucKhoeBNPHQ()
        {
            TableName = "BangHoiSucKhoeBNPHQ";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BHSKBNPHQ;
            TenMauPhieu = DanhMucPhieu.BHSKBNPHQ.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Ngày làm test")]
        public DateTime? NgayLamTest { get; set; }
        [MoTaDuLieu("Mã người đánh giá")]
        public string MaNguoiDanhGia { get; set; }
        [MoTaDuLieu("Họ tên người đánh giá")]
        public string NguoiDanhGia { get; set; }
        public bool[] CauHoi_1a_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_1a
        {
            get
            {
                return Array.IndexOf(CauHoi_1a_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_1a_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_1a_Array[i] = true;
                    else CauHoi_1a_Array[i] = false;
                }
            }
        }

        public bool[] CauHoi_1b_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_1b
        {
            get
            {
                return Array.IndexOf(CauHoi_1b_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_1b_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_1b_Array[i] = true;
                    else CauHoi_1b_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_1c_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_1c
        {
            get
            {
                return Array.IndexOf(CauHoi_1c_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_1c_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_1c_Array[i] = true;
                    else CauHoi_1c_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_2_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_2
        {
            get
            {
                return Array.IndexOf(CauHoi_2_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_2_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_2_Array[i] = true;
                    else CauHoi_2_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_3a_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_3a
        {
            get
            {
                return Array.IndexOf(CauHoi_3a_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_3a_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_3a_Array[i] = true;
                    else CauHoi_3a_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_3b_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_3b
        {
            get
            {
                return Array.IndexOf(CauHoi_3b_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_3b_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_3b_Array[i] = true;
                    else CauHoi_3b_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_4a_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_4a
        {
            get
            {
                return Array.IndexOf(CauHoi_4a_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_4a_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_4a_Array[i] = true;
                    else CauHoi_4a_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_4b_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_4b
        {
            get
            {
                return Array.IndexOf(CauHoi_4b_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_4b_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_4b_Array[i] = true;
                    else CauHoi_4b_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_4c_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_4c
        {
            get
            {
                return Array.IndexOf(CauHoi_4c_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_4c_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_4c_Array[i] = true;
                    else CauHoi_4c_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_5a_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_5a
        {
            get
            {
                return Array.IndexOf(CauHoi_5a_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_5a_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_5a_Array[i] = true;
                    else CauHoi_5a_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_5b_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_5b
        {
            get
            {
                return Array.IndexOf(CauHoi_5b_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_5b_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_5b_Array[i] = true;
                    else CauHoi_5b_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_5c_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_5c
        {
            get
            {
                return Array.IndexOf(CauHoi_5c_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_5c_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_5c_Array[i] = true;
                    else CauHoi_5c_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_6a_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_6a
        {
            get
            {
                return Array.IndexOf(CauHoi_6a_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_6a_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_6a_Array[i] = true;
                    else CauHoi_6a_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_6b_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_6b
        {
            get
            {
                return Array.IndexOf(CauHoi_6b_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_6b_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_6b_Array[i] = true;
                    else CauHoi_6b_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_6c_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_6c
        {
            get
            {
                return Array.IndexOf(CauHoi_6c_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_6c_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_6c_Array[i] = true;
                    else CauHoi_6c_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_6d_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_6d
        {
            get
            {
                return Array.IndexOf(CauHoi_6d_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_6d_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_6d_Array[i] = true;
                    else CauHoi_6d_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_7_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_7
        {
            get
            {
                return Array.IndexOf(CauHoi_7_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_7_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_7_Array[i] = true;
                    else CauHoi_7_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_8a_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_8a
        {
            get
            {
                return Array.IndexOf(CauHoi_8a_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_8a_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_8a_Array[i] = true;
                    else CauHoi_8a_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_8b_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_8b
        {
            get
            {
                return Array.IndexOf(CauHoi_8b_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_8b_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_8b_Array[i] = true;
                    else CauHoi_8b_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_9a_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_9a
        {
            get
            {
                return Array.IndexOf(CauHoi_9a_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_9a_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_9a_Array[i] = true;
                    else CauHoi_9a_Array[i] = false;
                }
            }
        }
        public bool[] CauHoi_9b_Array { get; } = new bool[] { false, false, false, false };
        public int CauHoi_9b
        {
            get
            {
                return Array.IndexOf(CauHoi_9b_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < CauHoi_9b_Array.Length; i++)
                {
                    if (i == (value - 1)) CauHoi_9b_Array[i] = true;
                    else CauHoi_9b_Array[i] = false;
                }
            }
        }
        public bool[] SuyGiamArray { get; } = new bool[] { false, false, false, false };
        public int SuyGiam
        {
            get
            {
                return Array.IndexOf(SuyGiamArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < SuyGiamArray.Length; i++)
                {
                    if (i == (value - 1)) SuyGiamArray[i] = true;
                    else SuyGiamArray[i] = false;
                }
            }
        }
        public bool[] DanhGia_A_Array { get; } = new bool[] { false, false };
        public int DanhGia_A
        {
            get
            {
                return Array.IndexOf(DanhGia_A_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DanhGia_A_Array.Length; i++)
                {
                    if (i == (value - 1)) DanhGia_A_Array[i] = true;
                    else DanhGia_A_Array[i] = false;
                }
            }
        }
        public bool[] DanhGia_B_Array { get; } = new bool[] { false, false };
        public int DanhGia_B
        {
            get
            {
                return Array.IndexOf(DanhGia_B_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DanhGia_B_Array.Length; i++)
                {
                    if (i == (value - 1)) DanhGia_B_Array[i] = true;
                    else DanhGia_B_Array[i] = false;
                }
            }
        }
        public bool[] DanhGia_C_Array { get; } = new bool[] { false, false };
        public int DanhGia_C
        {
            get
            {
                return Array.IndexOf(DanhGia_C_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DanhGia_C_Array.Length; i++)
                {
                    if (i == (value - 1)) DanhGia_C_Array[i] = true;
                    else DanhGia_C_Array[i] = false;
                }
            }
        }
        public bool[] DanhGia_D_Array { get; } = new bool[] { false, false };
        public int DanhGia_D
        {
            get
            {
                return Array.IndexOf(DanhGia_D_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DanhGia_D_Array.Length; i++)
                {
                    if (i == (value - 1)) DanhGia_D_Array[i] = true;
                    else DanhGia_D_Array[i] = false;
                }
            }
        }
        public bool[] DanhGia_KQ_Array { get; } = new bool[] { false, false };
        public int DanhGia_KQ
        {
            get
            {
                return Array.IndexOf(DanhGia_KQ_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DanhGia_KQ_Array.Length; i++)
                {
                    if (i == (value - 1)) DanhGia_KQ_Array[i] = true;
                    else DanhGia_KQ_Array[i] = false;
                }
            }
        }

        [MoTaDuLieu("Điểm câu hỏi 1a")]
        public string Diem_1a { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 1b")]
        public string Diem_1b { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 1c")]
        public string Diem_1c { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 2")]
        public string Diem_2 { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 3a")]
        public string Diem_3a { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 3b")]
        public string Diem_3b { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 4a")]
        public string Diem_4a { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 4b")]
        public string Diem_4b { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 4c")]
        public string Diem_4c { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 5a")]
        public string Diem_5a { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 5b")]
        public string Diem_5b { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 5c")]
        public string Diem_5c { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 6a")]
        public string Diem_6a { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 6b")]
        public string Diem_6b { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 6c")]
        public string Diem_6c { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 6d")]
        public string Diem_6d { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 7")]
        public string Diem_7 { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 8a")]
        public string Diem_8a { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 8b")]
        public string Diem_8b { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 9a")]
        public string Diem_9a { get; set; }
        [MoTaDuLieu("Điểm câu hỏi 9b")]
        public string Diem_9b { get; set; }
        [MoTaDuLieu("Tổng điểm")]
        public string TongDiem { get; set; }
        [MoTaDuLieu("Tổng số triệu chứng có điểm >1")]
        public string TongSoTrieuChung { get; set; }
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
        [MoTaDuLieu("Mã số ký tên")]
        public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }


    public class BangHoiSucKhoeBNPHQFunc
    {
        public const string TableName = "BangHoiSucKhoeBNPHQ";
        public const string TablePrimaryKeyName = "ID";

        public static List<BangHoiSucKhoeBNPHQ> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangHoiSucKhoeBNPHQ> list = new List<BangHoiSucKhoeBNPHQ>();
            try
            {
                string sql = @"SELECT * FROM BangHoiSucKhoeBNPHQ where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangHoiSucKhoeBNPHQ data = new BangHoiSucKhoeBNPHQ();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.MaNguoiDanhGia = DataReader["MaNguoiDanhGia"].ToString();
                    data.NguoiDanhGia = DataReader["NguoiDanhGia"].ToString();

                    data.CauHoi_1a = DataReader.GetInt("CauHoi_1a");
                    data.CauHoi_1b = DataReader.GetInt("CauHoi_1b");
                    data.CauHoi_1c = DataReader.GetInt("CauHoi_1c");
                    data.CauHoi_2 = DataReader.GetInt("CauHoi_2");
                    data.CauHoi_3a = DataReader.GetInt("CauHoi_3a");
                    data.CauHoi_3b = DataReader.GetInt("CauHoi_3b");
                    data.CauHoi_4a = DataReader.GetInt("CauHoi_4a");
                    data.CauHoi_4b = DataReader.GetInt("CauHoi_4b");
                    data.CauHoi_4c = DataReader.GetInt("CauHoi_4c");
                    data.CauHoi_5a = DataReader.GetInt("CauHoi_5a");
                    data.CauHoi_5b = DataReader.GetInt("CauHoi_5b");
                    data.CauHoi_5c = DataReader.GetInt("CauHoi_5c");
                    data.CauHoi_6a = DataReader.GetInt("CauHoi_6a");
                    data.CauHoi_6b = DataReader.GetInt("CauHoi_6b");
                    data.CauHoi_6c = DataReader.GetInt("CauHoi_6c");
                    data.CauHoi_6d = DataReader.GetInt("CauHoi_6d");
                    data.CauHoi_7 = DataReader.GetInt("CauHoi_7");
                    data.CauHoi_8a = DataReader.GetInt("CauHoi_8a");
                    data.CauHoi_8b = DataReader.GetInt("CauHoi_8b");
                    data.CauHoi_9a = DataReader.GetInt("CauHoi_9a");
                    data.CauHoi_9b = DataReader.GetInt("CauHoi_9b");

                    data.Diem_1a = DataReader["Diem_1a"].ToString();
                    data.Diem_1b = DataReader["Diem_1b"].ToString();
                    data.Diem_1c = DataReader["Diem_1c"].ToString();
                    data.Diem_2 = DataReader["Diem_2"].ToString();
                    data.Diem_3a = DataReader["Diem_3a"].ToString();
                    data.Diem_3b = DataReader["Diem_3b"].ToString();
                    data.Diem_4a = DataReader["Diem_4a"].ToString();
                    data.Diem_4b = DataReader["Diem_4b"].ToString();
                    data.Diem_4c = DataReader["Diem_4c"].ToString();
                    data.Diem_5a = DataReader["Diem_5a"].ToString();
                    data.Diem_5b = DataReader["Diem_5b"].ToString();
                    data.Diem_5c = DataReader["Diem_5c"].ToString();
                    data.Diem_6a = DataReader["Diem_6a"].ToString();
                    data.Diem_6b = DataReader["Diem_6b"].ToString();
                    data.Diem_6c = DataReader["Diem_6c"].ToString();
                    data.Diem_6d = DataReader["Diem_6d"].ToString();
                    data.Diem_7 = DataReader["Diem_7"].ToString();
                    data.Diem_8a = DataReader["Diem_8a"].ToString();
                    data.Diem_8b = DataReader["Diem_8b"].ToString();
                    data.Diem_9a = DataReader["Diem_9a"].ToString();
                    data.Diem_9b = DataReader["Diem_9b"].ToString();

                    data.SuyGiam = DataReader.GetInt("SuyGiam");
                    data.DanhGia_A = DataReader.GetInt("DanhGia_A");
                    data.DanhGia_B = DataReader.GetInt("DanhGia_B");
                    data.DanhGia_C = DataReader.GetInt("DanhGia_C");
                    data.DanhGia_D = DataReader.GetInt("DanhGia_D");
                    data.DanhGia_KQ = DataReader.GetInt("DanhGia_KQ");


                    data.TongDiem = DataReader["TongDiem"].ToString();
                    data.TongSoTrieuChung = DataReader["TongSoTrieuChung"].ToString();

                    data.NgayLamTest = Convert.ToDateTime(DataReader["NgayLamTest"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamTest"]);

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
                sql = @"DELETE FROM BangHoiSucKhoeBNPHQ WHERE ID =" + IDBienBan;
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
                BangHoiSucKhoeBNPHQ P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("ThongTinNgayThang", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["ThongTinNgayThang"] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangHoiSucKhoeBNPHQ ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangHoiSucKhoeBNPHQ
                (
                    MaQuanLy,
                    DiaChi,
                    NgheNghiep,
                    NgayLamTest,
                    ChanDoan,
                    NguoiDanhGia,
                    MaNguoiDanhGia,
                    CauHoi_1a,
                    CauHoi_1b,
                    CauHoi_1c,
                    CauHoi_2,
                    CauHoi_3a,
                    CauHoi_3b,
                    CauHoi_4a,
                    CauHoi_4b,
                    CauHoi_4c,
                    CauHoi_5a,
                    CauHoi_5b,
                    CauHoi_5c,
                    CauHoi_6a,
                    CauHoi_6b,
                    CauHoi_6c,
                    CauHoi_6d,
                    CauHoi_7,
                    CauHoi_8a,
                    CauHoi_8b,
                    CauHoi_9a,
                    CauHoi_9b,
                    Diem_1a,
                    Diem_1b,
                    Diem_1c,
                    Diem_2,
                    Diem_3a,
                    Diem_3b,
                    Diem_4a,
                    Diem_4b,
                    Diem_4c,
                    Diem_5a,
                    Diem_5b,
                    Diem_5c,
                    Diem_6a,
                    Diem_6b,
                    Diem_6c,
                    Diem_6d,
                    Diem_7,
                    Diem_8a,
                    Diem_8b,
                    Diem_9a,
                    Diem_9b,
                    SuyGiam,
                    DanhGia_A,
                    DanhGia_B,
                    DanhGia_C,
                    DanhGia_D,
                    DanhGia_KQ,
                    TongDiem,
                    TongSoTrieuChung,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :DiaChi,
                    :NgheNghiep,
                    :NgayLamTest,
                    :ChanDoan,
                    :NguoiDanhGia,
                    :MaNguoiDanhGia,
                    :CauHoi_1a,
                    :CauHoi_1b,
                    :CauHoi_1c,
                    :CauHoi_2,
                    :CauHoi_3a,
                    :CauHoi_3b,
                    :CauHoi_4a,
                    :CauHoi_4b,
                    :CauHoi_4c,
                    :CauHoi_5a,
                    :CauHoi_5b,
                    :CauHoi_5c,
                    :CauHoi_6a,
                    :CauHoi_6b,
                    :CauHoi_6c,
                    :CauHoi_6d,
                    :CauHoi_7,
                    :CauHoi_8a,
                    :CauHoi_8b,
                    :CauHoi_9a,
                    :CauHoi_9b,
                    :Diem_1a,
                    :Diem_1b,
                    :Diem_1c,
                    :Diem_2,
                    :Diem_3a,
                    :Diem_3b,
                    :Diem_4a,
                    :Diem_4b,
                    :Diem_4c,
                    :Diem_5a,
                    :Diem_5b,
                    :Diem_5c,
                    :Diem_6a,
                    :Diem_6b,
                    :Diem_6c,
                    :Diem_6d,
                    :Diem_7,
                    :Diem_8a,
                    :Diem_8b,
                    :Diem_9a,
                    :Diem_9b,
                    :SuyGiam,
                    :DanhGia_A,
                    :DanhGia_B,
                    :DanhGia_C,
                    :DanhGia_D,
                    :DanhGia_KQ,
                    :TongDiem,
                    :TongSoTrieuChung,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangHoiSucKhoeBNPHQ SET 
                    MaQuanLy = :MaQuanLy,
                    DiaChi = :DiaChi,
                    NgheNghiep = :NgheNghiep,
                    NgayLamTest = :NgayLamTest,
                    ChanDoan = :ChanDoan,
                    NguoiDanhGia = :NguoiDanhGia,
                    MaNguoiDanhGia = :MaNguoiDanhGia,
                    CauHoi_1a = :CauHoi_1a,
                    CauHoi_1b = :CauHoi_1b,
                    CauHoi_1c = :CauHoi_1c,
                    CauHoi_2 = :CauHoi_2,
                    CauHoi_3a = :CauHoi_3a,
                    CauHoi_3b = :CauHoi_3b,
                    CauHoi_4a = :CauHoi_4a,
                    CauHoi_4b = :CauHoi_4b,
                    CauHoi_4c = :CauHoi_4c,
                    CauHoi_5a = :CauHoi_5a,
                    CauHoi_5b = :CauHoi_5b,
                    CauHoi_5c = :CauHoi_5c,
                    CauHoi_6a = :CauHoi_6a,
                    CauHoi_6b = :CauHoi_6b,
                    CauHoi_6c = :CauHoi_6c,
                    CauHoi_6d = :CauHoi_6d,
                    CauHoi_7 = :CauHoi_7,
                    CauHoi_8a = :CauHoi_8a,
                    CauHoi_8b = :CauHoi_8b,
                    CauHoi_9a = :CauHoi_9a,
                    CauHoi_9b = :CauHoi_9b,
                    Diem_1a = :Diem_1a,
                    Diem_1b = :Diem_1b,
                    Diem_1c = :Diem_1c,
                    Diem_2 = :Diem_2,
                    Diem_3a = :Diem_3a,
                    Diem_3b = :Diem_3b,
                    Diem_4a = :Diem_4a,
                    Diem_4b = :Diem_4b,
                    Diem_4c = :Diem_4c,
                    Diem_5a = :Diem_5a,
                    Diem_5b = :Diem_5b,
                    Diem_5c = :Diem_5c,
                    Diem_6a = :Diem_6a,
                    Diem_6b = :Diem_6b,
                    Diem_6c = :Diem_6c,
                    Diem_6d = :Diem_6d,
                    Diem_7 = :Diem_7,
                    Diem_8a = :Diem_8a,
                    Diem_8b = :Diem_8b,
                    Diem_9a = :Diem_9a,
                    Diem_9b = :Diem_9b,
                    SuyGiam = :SuyGiam,
                    DanhGia_A = :DanhGia_A,
                    DanhGia_B = :DanhGia_B,
                    DanhGia_C = :DanhGia_C,
                    DanhGia_D = :DanhGia_D,
                    DanhGia_KQ = :DanhGia_KQ,
                    TongDiem = :TongDiem,
                    TongSoTrieuChung = :TongSoTrieuChung,
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
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamTest", ketQua.NgayLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia", ketQua.NguoiDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia", ketQua.MaNguoiDanhGia));

                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_1a", ketQua.CauHoi_1a));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_1b", ketQua.CauHoi_1b));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_1c", ketQua.CauHoi_1c));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_2", ketQua.CauHoi_2));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_3a", ketQua.CauHoi_3a));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_3b", ketQua.CauHoi_3b));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_4a", ketQua.CauHoi_4a));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_4b", ketQua.CauHoi_4b));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_4c", ketQua.CauHoi_4c));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_5a", ketQua.CauHoi_5a));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_5b", ketQua.CauHoi_5b));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_5c", ketQua.CauHoi_5c));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_6a", ketQua.CauHoi_6a));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_6b", ketQua.CauHoi_6b));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_6c", ketQua.CauHoi_6c));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_6d", ketQua.CauHoi_6d));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_7", ketQua.CauHoi_7));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_8a", ketQua.CauHoi_8a));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_8b", ketQua.CauHoi_8b));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_9a", ketQua.CauHoi_9a));
                Command.Parameters.Add(new MDB.MDBParameter("CauHoi_9b", ketQua.CauHoi_9b));

                Command.Parameters.Add(new MDB.MDBParameter("Diem_1a", ketQua.Diem_1a));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_1b", ketQua.Diem_1b));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_1c", ketQua.Diem_1c));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_2", ketQua.Diem_2));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_3a", ketQua.Diem_3a));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_3b", ketQua.Diem_3b));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_4a", ketQua.Diem_4a));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_4b", ketQua.Diem_4b));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_4c", ketQua.Diem_4c));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_5a", ketQua.Diem_5a));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_5b", ketQua.Diem_5b));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_5c", ketQua.Diem_5c));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_6a", ketQua.Diem_6a));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_6b", ketQua.Diem_6b));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_6c", ketQua.Diem_6c));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_6d", ketQua.Diem_6d));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_7", ketQua.Diem_7));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_8a", ketQua.Diem_8a));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_8b", ketQua.Diem_8b));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_9a", ketQua.Diem_9a));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_9b", ketQua.Diem_9b));

                Command.Parameters.Add(new MDB.MDBParameter("SuyGiam", ketQua.SuyGiam));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_A", ketQua.DanhGia_A));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_B", ketQua.DanhGia_B));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_C", ketQua.DanhGia_C));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_D", ketQua.DanhGia_D));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia_KQ", ketQua.DanhGia_KQ));

                Command.Parameters.Add(new MDB.MDBParameter("TongDiem", ketQua.TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("TongSoTrieuChung", ketQua.TongSoTrieuChung));

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
    }
}
