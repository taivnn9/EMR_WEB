using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDieuTriCoKiemSoat : ThongTinKy
    {
        public PhieuDieuTriCoKiemSoat()
        {
            TableName = "PhieuDieuTriCoKiemSoat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDTCKS;
            TenMauPhieu = DanhMucPhieu.PDTCKS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Ngày bắt đầu điều trị")]
        public DateTime? NgayBatDauDieuTri { get; set; }
        [MoTaDuLieu("Đơn vị điều trị")]
        public string DonViDieuTri { get; set; }
        [MoTaDuLieu("Số ĐT, địa chỉ bệnh nhân")]
        public string SDTDiaChiBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên/số ĐT/địa chỉ của CBYT trực tiếp điều trị BN (GSV1)")]
        public string GSV1 { get; set; }
        [MoTaDuLieu("Họ và tên/số ĐT/địa chỉ của người giám sát hỗ trợ điều trị BN (GSV2)")]
        public string GSV2 { get; set; }
        [MoTaDuLieu("Tỉnh")]
        public string Tinh { get; set; }
        [MoTaDuLieu("Huyện")]
        public string Huyen { get; set; }
        [MoTaDuLieu("Xã")]
        public string Xa { get; set; }
        [MoTaDuLieu("Số ĐKDT")]
        public string SoDKDT { get; set; }
        [MoTaDuLieu("Lao phổi có bằng chứng Vk Học,0 -> Không, 1 -> Có")]
        public int LPCBCVKH { get; set; }
        [MoTaDuLieu("Lao phổi không bằng chứng Vk Học,0 -> Không, 1 -> Có")]
        public int LPKCBCVKH { get; set; }
        [MoTaDuLieu("Lao ngoài phổi,0 -> Không, 1 -> Có")]
        public int LNP { get; set; }
        [MoTaDuLieu("Ghi rõ lao ngoài phổi")]
        public string LNP_Text { get; set; }
        [MoTaDuLieu("Phân loại bệnh nhân, mới")]
        public int Moi { get; set; }
        [MoTaDuLieu("Phân loại bệnh nhân, Điều trị lại sau bỏ trị")]
        public int DTLaiSauBoTri { get; set; }
        [MoTaDuLieu("Phân loại bệnh nhân, tái phát")]
        public int TaiPhat { get; set; }
        [MoTaDuLieu("Phân loại bệnh nhân, tiền sử điều trị khác")]
        public int TienSuDieuTriKhac { get; set; }
        [MoTaDuLieu("Phân loại bệnh nhân, thất bại")]
        public int ThatBai { get; set; }
        [MoTaDuLieu("Phân loại bệnh nhân, bệnh nhân không rõ tiền sử điều trị")]
        public int BNKhongRoTienSuDieuTri { get; set; }

        // Giai đoạn tấn công
        //Phác đồ điều trị và liều lượng
        [MoTaDuLieu("Phác đồ : 2RHZE/4RHE")]
        public int PhacDo_1 { get; set; }
        [MoTaDuLieu("Phác đồ : 2RHZE/4RH")]
        public int PhacDo_2 { get; set; }
        [MoTaDuLieu("Phác đồ : 2RHZE/1ORHE")]
        public int PhacDo_3 { get; set; }
        [MoTaDuLieu("Phác đồ : 2RHZE/1ORH")]
        public int PhacDo_4 { get; set; }
        [MoTaDuLieu("Phác đồ khác")]
        public string PhacDoKhac { get; set; }
        // liều lượng thuốc
        [MoTaDuLieu("liều lượng thuốc : RHZE")]
        public string RHZE { get; set; }
        [MoTaDuLieu("liều lượng thuốc : RHZ")]
        public string RHZ { get; set; }
        [MoTaDuLieu("liều lượng thuốc : RH")]
        public string RH { get; set; }
        [MoTaDuLieu("liều lượng thuốc : Z")]
        public string Z { get; set; }
        [MoTaDuLieu("liều lượng thuốc : E")]
        public string E { get; set; }
        [MoTaDuLieu("liều lượng thuốc : H")]
        public string H { get; set; }
        [MoTaDuLieu("liều lượng thuốc : Sg")]
        public string Sg { get; set; }
        [MoTaDuLieu("liều lượng thuốc : liều lượng thuốc khác")]
        public string LieuLuongThuoc_Khac { get; set; }
        [MoTaDuLieu("Cotrimoxazole")]
        public string Cotrimoxazole { get; set; }
        [MoTaDuLieu("ART")]
        public string ART { get; set; }
        [MoTaDuLieu("Khác")]
        public string Khac { get; set; }
        // do nơi nào chuyển đến
        [MoTaDuLieu(" do nơi nào chuyển đến : tự đến")]
        public int TuDien { get; set; }
        [MoTaDuLieu(" do nơi nào chuyển đến : CTCL")]
        public int CTCL { get; set; }
        [MoTaDuLieu(" do nơi nào chuyển đến : Cơ sở tư công")]
        public int CoSoTuCong { get; set; }
        [MoTaDuLieu(" do nơi nào chuyển đến : Cơ sở tư nhân")]
        public int CoSoTuNhan { get; set; }
        [MoTaDuLieu(" do nơi nào chuyển đến : khác")]
        public int NoiChuyenDenKhac { get; set; }
        [MoTaDuLieu(" do nơi nào chuyển đến : khác, ghi rõ")]
        public string NoiChuyenDenKhac_Text { get; set; }
        // soi TT và nuôi cấy
        [MoTaDuLieu(" kết quả soi TT ban đầu")]
        public string KetQuaSoiTT_BanDau { get; set; }
        [MoTaDuLieu(" kết quả nuôi cấy ban đầu")]
        public string KetQuaNoiCay_BanDau { get; set; }
        [MoTaDuLieu(" cân nặng ban đầu")]
        public string CanNang_BanDau { get; set; }
        [MoTaDuLieu(" kết quả soi TT KS1")]
        public string KetQuaSoiTT_KS1 { get; set; }
        [MoTaDuLieu(" kết quả nuôi cấy KS1")]
        public string KetQuaNoiCay_KS1 { get; set; }
        [MoTaDuLieu(" cân nặng KS1")]
        public string CanNang_KS1 { get; set; }
        [MoTaDuLieu(" kết quả soi TT KS2")]
        public string KetQuaSoiTT_KS2 { get; set; }
        [MoTaDuLieu(" kết quả nuôi cấy KS2")]
        public string KetQuaNoiCay_KS2 { get; set; }
        [MoTaDuLieu(" cân nặng KS2")]
        public string CanNang_KS2 { get; set; }
        [MoTaDuLieu(" kết quả soi TT KS3")]
        public string KetQuaSoiTT_KS3 { get; set; }
        [MoTaDuLieu(" kết quả nuôi cấy KS3")]
        public string KetQuaNoiCay_KS3 { get; set; }
        [MoTaDuLieu(" cân nặng KS3")]
        public string CanNang_KS3 { get; set; }
        [MoTaDuLieu(" XQ ban đầu")]
        public string XQ_BanDau { get; set; }
        [MoTaDuLieu(" Xpert, MTB/RIF")]
        public string Xpert { get; set; }
        [MoTaDuLieu(" Hain test")]
        public string HainTest { get; set; }
        // XN theo dõi cuối 2, 5 và 6 với công thức 6 tháng
        [MoTaDuLieu(" Mã trong sổ ĐKĐT, xét nghiệm H")]
        public string MaTrongSoDKDT_XNH { get; set; }
        [MoTaDuLieu(" Mã trong sổ ĐKĐT, Cotrimoxazole")]
        public string MaTrongSoDKDT_Cot { get; set; }
        [MoTaDuLieu(" Mã trong sổ ĐKĐT, ART")]
        public string MaTrongSoDKDT_ART { get; set; }
        [MoTaDuLieu(" Đăng ký phòng khám ngoại trú HIV, mã")]
        public string DKPKNgoaiTruHIV { get; set; }
        [MoTaDuLieu(" Số đăng ký ART")]
        public string SoDKART { get; set; }
        [MoTaDuLieu(" Thông tin bệnh nhân dùng thuốc")]
        public ObservableCollection<ThongTinBenhNhanDungThuoc> ThongTinDungThuocs { get; set; }
        // II. Giai đoạn điều trị
        [MoTaDuLieu(" Liều lượng thuốc E")]
        public string LieuLuongThuoc_E { get; set; }
        [MoTaDuLieu(" Liều lượng thuốc H")]
        public string LieuLuongThuoc_H { get; set; }
        [MoTaDuLieu(" Liều lượng thuốc EH")]
        public string LieuLuongThuoc_EH { get; set; }
        [MoTaDuLieu(" Liều lượng thuốc RH")]
        public string LieuLuongThuoc_RH { get; set; }
        [MoTaDuLieu(" Liều lượng thuốc RHE")]
        public string LieuLuongThuoc_RHE { get; set; }
        [MoTaDuLieu(" Liều lượng thuốc khác")]
        public string LieuLuongThuoc_Khac2 { get; set; }
        [MoTaDuLieu(" Quản lý giai đoạn điều trị thuốc")]
        public ObservableCollection<ThongTinBenhNhanDungThuoc> GiaiDoanDieuTris { get; set; }
        [MoTaDuLieu(" Ngày kết thúc điều trị")]
        public DateTime? NgayKetThucDieuTri { get; set; }
        [MoTaDuLieu(" Kết quả điều trị, 1: khỏi, 2: Hoàn thành điều trị, 3: Thất bại, 4: chết, 5: không theo dõi được, 6: không đánh giá")]
        public int KetQuaDieuTri { get; set; }
        [MoTaDuLieu(" Nhận xét")]
        public string NhanXet { get; set; }
        [MoTaDuLieu(" Họ và tên, số ĐT và địa chỉ người thân khi cần liên hệ")]
        public string HoTenDiaChiNguoiNhan { get; set; }
        [MoTaDuLieu(" Y, bác sỹ đánh giá kết quả điều trị")]
        public string YBacSyDanhGia { get; set; }
        [MoTaDuLieu(" Mã Y, Bác sỹ đánh giá kết quả điều trị")]
        public string MaYBacSyDanhGia { get; set; }
        // bắt buộc
        [MoTaDuLieu("Đã ký", null, 0, 0)]
        public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
        public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
        public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
        public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
        public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }

    }
    public class ThongTinBenhNhanDungThuoc
    {
        [MoTaDuLieu(" Tháng")]
        public string Thang { get; set; }
        [MoTaDuLieu(" Ngày 1")]
        public string N1 { get; set; }
        [MoTaDuLieu(" Ngày 2")]
        public string N2 { get; set; }
        [MoTaDuLieu(" Ngày 3")]
        public string N3 { get; set; }
        [MoTaDuLieu(" Ngày 4")]
        public string N4 { get; set; }
        [MoTaDuLieu(" Ngày 5")]
        public string N5 { get; set; }
        [MoTaDuLieu(" Ngày 6")]
        public string N6 { get; set; }
        [MoTaDuLieu(" Ngày 7")]
        public string N7 { get; set; }
        [MoTaDuLieu(" Ngày 8")]
        public string N8 { get; set; }
        [MoTaDuLieu(" Ngày 9")]
        public string N9 { get; set; }
        [MoTaDuLieu(" Ngày 10")]
        public string N10 { get; set; }
        [MoTaDuLieu(" Ngày 11")]
        public string N11 { get; set; }
        [MoTaDuLieu(" Ngày 12")]
        public string N12 { get; set; }
        [MoTaDuLieu(" Ngày 13")]
        public string N13 { get; set; }
        [MoTaDuLieu(" Ngày 14")]
        public string N14 { get; set; }
        [MoTaDuLieu(" Ngày 15")]
        public string N15 { get; set; }
        [MoTaDuLieu(" Ngày 16")]
        public string N16 { get; set; }
        [MoTaDuLieu(" Ngày 17")]
        public string N17 { get; set; }
        [MoTaDuLieu(" Ngày 18")]
        public string N18 { get; set; }
        [MoTaDuLieu(" Ngày 19")]
        public string N19 { get; set; }
        [MoTaDuLieu(" Ngày 20")]
        public string N20 { get; set; }
        [MoTaDuLieu(" Ngày 21")]
        public string N21 { get; set; }
        [MoTaDuLieu(" Ngày 22")]
        public string N22 { get; set; }
        [MoTaDuLieu(" Ngày 23")]
        public string N23 { get; set; }
        [MoTaDuLieu(" Ngày 24")]
        public string N24 { get; set; }
        [MoTaDuLieu(" Ngày 25")]
        public string N25 { get; set; }
        [MoTaDuLieu(" Ngày 26")]
        public string N26 { get; set; }
        [MoTaDuLieu(" Ngày 27")]
        public string N27 { get; set; }
        [MoTaDuLieu(" Ngày 28")]
        public string N28 { get; set; }
        [MoTaDuLieu(" Ngày 29")]
        public string N29 { get; set; }
        [MoTaDuLieu(" Ngày 30")]
        public string N30 { get; set; }
        [MoTaDuLieu(" Ngày 31")]
        public string N31 { get; set; }

    }
    public class PhieuDieuTriCoKiemSoatFunc
    {
        public const string TableName = "PhieuDieuTriCoKiemSoat";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuDieuTriCoKiemSoat> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDieuTriCoKiemSoat> list = new List<PhieuDieuTriCoKiemSoat>();
            try
            {
                string sql = @"SELECT * FROM PhieuDieuTriCoKiemSoat where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDieuTriCoKiemSoat data = new PhieuDieuTriCoKiemSoat();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgayBatDauDieuTri = DataReader["NgayBatDauDieuTri"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayBatDauDieuTri"]) : null;
                    data.DonViDieuTri = DataReader["DonViDieuTri"].ToString();
                    data.SDTDiaChiBenhNhan = DataReader["SDTDiaChiBenhNhan"].ToString();
                    data.GSV1 = DataReader["GSV1"].ToString();
                    data.GSV2 = DataReader["GSV2"].ToString();
                    data.Tinh = DataReader["Tinh"].ToString();
                    data.Huyen = DataReader["Huyen"].ToString();
                    data.Xa = DataReader["Xa"].ToString();
                    data.SoDKDT = DataReader["SoDKDT"].ToString();
                    data.LPCBCVKH = DataReader.GetInt("LPCBCVKH");
                    data.LPKCBCVKH = DataReader.GetInt("LPKCBCVKH");
                    data.LNP = DataReader.GetInt("LNP");
                    data.LNP_Text = DataReader["LNP_Text"].ToString();
                    data.Moi = DataReader.GetInt("Moi");
                    data.DTLaiSauBoTri = DataReader.GetInt("DTLaiSauBoTri");
                    data.TaiPhat = DataReader.GetInt("TaiPhat");
                    data.TienSuDieuTriKhac = DataReader.GetInt("TienSuDieuTriKhac");
                    data.ThatBai = DataReader.GetInt("ThatBai");
                    data.BNKhongRoTienSuDieuTri = DataReader.GetInt("BNKhongRoTienSuDieuTri");
                    data.PhacDo_1 = DataReader.GetInt("PhacDo_1");
                    data.PhacDo_2 = DataReader.GetInt("PhacDo_2");
                    data.PhacDo_3 = DataReader.GetInt("PhacDo_3");
                    data.PhacDo_4 = DataReader.GetInt("PhacDo_4");
                    data.PhacDoKhac = DataReader["PhacDoKhac"].ToString();
                    data.RHZE = DataReader["RHZE"].ToString();
                    data.RHZ = DataReader["RHZ"].ToString();
                    data.RH = DataReader["RH"].ToString();
                    data.Z = DataReader["Z"].ToString();
                    data.E = DataReader["E"].ToString();
                    data.H = DataReader["H"].ToString();
                    data.Sg = DataReader["Sg"].ToString();
                    data.LieuLuongThuoc_Khac = DataReader["LieuLuongThuoc_Khac"].ToString();
                    data.Cotrimoxazole = DataReader["Cotrimoxazole"].ToString();
                    data.ART = DataReader["ART"].ToString();
                    data.Khac = DataReader["Khac"].ToString();
                    data.TuDien = DataReader.GetInt("TuDien");
                    data.CTCL = DataReader.GetInt("CTCL");
                    data.CoSoTuCong = DataReader.GetInt("CoSoTuCong");
                    data.CoSoTuNhan = DataReader.GetInt("CoSoTuNhan");
                    data.NoiChuyenDenKhac = DataReader.GetInt("NoiChuyenDenKhac");
                    data.NoiChuyenDenKhac_Text = DataReader["NoiChuyenDenKhac_Text"].ToString();
                    data.KetQuaSoiTT_BanDau = DataReader["KetQuaSoiTT_BanDau"].ToString();
                    data.KetQuaNoiCay_BanDau = DataReader["KetQuaNoiCay_BanDau"].ToString();
                    data.CanNang_BanDau = DataReader["CanNang_BanDau"].ToString();
                    data.KetQuaSoiTT_KS1 = DataReader["KetQuaSoiTT_KS1"].ToString();
                    data.KetQuaNoiCay_KS1 = DataReader["KetQuaNoiCay_KS1"].ToString();
                    data.CanNang_KS1 = DataReader["CanNang_KS1"].ToString();
                    data.KetQuaSoiTT_KS2 = DataReader["KetQuaSoiTT_KS2"].ToString();
                    data.KetQuaNoiCay_KS2 = DataReader["KetQuaNoiCay_KS2"].ToString();
                    data.CanNang_KS2 = DataReader["CanNang_KS2"].ToString();
                    data.KetQuaSoiTT_KS3 = DataReader["KetQuaSoiTT_KS3"].ToString();
                    data.KetQuaNoiCay_KS3 = DataReader["KetQuaNoiCay_KS3"].ToString();
                    data.CanNang_KS3 = DataReader["CanNang_KS3"].ToString();
                    data.XQ_BanDau = DataReader["XQ_BanDau"].ToString();
                    data.Xpert = DataReader["Xpert"].ToString();
                    data.HainTest = DataReader["HainTest"].ToString();
                    data.MaTrongSoDKDT_XNH = DataReader["MaTrongSoDKDT_XNH"].ToString();
                    data.MaTrongSoDKDT_Cot = DataReader["MaTrongSoDKDT_Cot"].ToString();
                    data.MaTrongSoDKDT_ART = DataReader["MaTrongSoDKDT_ART"].ToString();
                    data.DKPKNgoaiTruHIV = DataReader["DKPKNgoaiTruHIV"].ToString();
                    data.SoDKART = DataReader["SoDKART"].ToString();
                    data.ThongTinDungThuocs = JsonConvert.DeserializeObject<ObservableCollection<ThongTinBenhNhanDungThuoc>>(DataReader["ThongTinDungThuocs"].ToString());
                    data.LieuLuongThuoc_E = DataReader["LieuLuongThuoc_E"].ToString();
                    data.LieuLuongThuoc_H = DataReader["LieuLuongThuoc_H"].ToString();
                    data.LieuLuongThuoc_EH = DataReader["LieuLuongThuoc_EH"].ToString();
                    data.LieuLuongThuoc_RH = DataReader["LieuLuongThuoc_RH"].ToString();
                    data.LieuLuongThuoc_RHE = DataReader["LieuLuongThuoc_RHE"].ToString();
                    data.LieuLuongThuoc_Khac2 = DataReader["LieuLuongThuoc_Khac2"].ToString();
                    data.GiaiDoanDieuTris = JsonConvert.DeserializeObject<ObservableCollection<ThongTinBenhNhanDungThuoc>>(DataReader["GiaiDoanDieuTris"].ToString());
                    data.NgayKetThucDieuTri = DataReader["NgayKetThucDieuTri"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayKetThucDieuTri"]) : null;
                    data.KetQuaDieuTri = DataReader.GetInt("KetQuaDieuTri");
                    data.NhanXet = DataReader["NhanXet"].ToString();
                    data.HoTenDiaChiNguoiNhan = DataReader["HoTenDiaChiNguoiNhan"].ToString();
                    data.YBacSyDanhGia = DataReader["YBacSyDanhGia"].ToString();
                    data.MaYBacSyDanhGia = DataReader["MaYBacSyDanhGia"].ToString();


                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDieuTriCoKiemSoat ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDieuTriCoKiemSoat
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayBatDauDieuTri,
                    DonViDieuTri,
                    SDTDiaChiBenhNhan,
                    GSV1,
                    GSV2,
                    Tinh,
                    Huyen,
                    Xa,
                    SoDKDT,
                    LPCBCVKH,
                    LPKCBCVKH,
                    LNP,
                    LNP_Text,
                    Moi,
                    DTLaiSauBoTri,
                    TaiPhat,
                    TienSuDieuTriKhac,
                    ThatBai,
                    BNKhongRoTienSuDieuTri,
                    PhacDo_1,
                    PhacDo_2,
                    PhacDo_3,
                    PhacDo_4,
                    PhacDoKhac,
                    RHZE,
                    RHZ,
                    RH,
                    Z,
                    E,
                    H,
                    Sg,
                    LieuLuongThuoc_Khac,
                    Cotrimoxazole,
                    ART,
                    Khac,
                    TuDien,
                    CTCL,
                    CoSoTuCong,
                    CoSoTuNhan,
                    NoiChuyenDenKhac,
                    NoiChuyenDenKhac_Text,
                    KetQuaSoiTT_BanDau,
                    KetQuaNoiCay_BanDau,
                    CanNang_BanDau,
                    KetQuaSoiTT_KS1,
                    KetQuaNoiCay_KS1,
                    CanNang_KS1,
                    KetQuaSoiTT_KS2,
                    KetQuaNoiCay_KS2,
                    CanNang_KS2,
                    KetQuaSoiTT_KS3,
                    KetQuaNoiCay_KS3,
                    CanNang_KS3,
                    XQ_BanDau,
                    Xpert,
                    HainTest,
                    MaTrongSoDKDT_XNH,
                    MaTrongSoDKDT_Cot,
                    MaTrongSoDKDT_ART,
                    DKPKNgoaiTruHIV,
                    SoDKART,
                    ThongTinDungThuocs,
                    LieuLuongThuoc_E,
                    LieuLuongThuoc_H,
                    LieuLuongThuoc_EH,
                    LieuLuongThuoc_RH,
                    LieuLuongThuoc_RHE,
                    LieuLuongThuoc_Khac2,
                    GiaiDoanDieuTris,
                    NgayKetThucDieuTri,
                    KetQuaDieuTri,
                    NhanXet,
                    HoTenDiaChiNguoiNhan,
                    YBacSyDanhGia,
                    MaYBacSyDanhGia,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayBatDauDieuTri,
                    :DonViDieuTri,
                    :SDTDiaChiBenhNhan,
                    :GSV1,
                    :GSV2,
                    :Tinh,
                    :Huyen,
                    :Xa,
                    :SoDKDT,
                    :LPCBCVKH,
                    :LPKCBCVKH,
                    :LNP,
                    :LNP_Text,
                    :Moi,
                    :DTLaiSauBoTri,
                    :TaiPhat,
                    :TienSuDieuTriKhac,
                    :ThatBai,
                    :BNKhongRoTienSuDieuTri,
                    :PhacDo_1,
                    :PhacDo_2,
                    :PhacDo_3,
                    :PhacDo_4,
                    :PhacDoKhac,
                    :RHZE,
                    :RHZ,
                    :RH,
                    :Z,
                    :E,
                    :H,
                    :Sg,
                    :LieuLuongThuoc_Khac,
                    :Cotrimoxazole,
                    :ART,
                    :Khac,
                    :TuDien,
                    :CTCL,
                    :CoSoTuCong,
                    :CoSoTuNhan,
                    :NoiChuyenDenKhac,
                    :NoiChuyenDenKhac_Text,
                    :KetQuaSoiTT_BanDau,
                    :KetQuaNoiCay_BanDau,
                    :CanNang_BanDau,
                    :KetQuaSoiTT_KS1,
                    :KetQuaNoiCay_KS1,
                    :CanNang_KS1,
                    :KetQuaSoiTT_KS2,
                    :KetQuaNoiCay_KS2,
                    :CanNang_KS2,
                    :KetQuaSoiTT_KS3,
                    :KetQuaNoiCay_KS3,
                    :CanNang_KS3,
                    :XQ_BanDau,
                    :Xpert,
                    :HainTest,
                    :MaTrongSoDKDT_XNH,
                    :MaTrongSoDKDT_Cot,
                    :MaTrongSoDKDT_ART,
                    :DKPKNgoaiTruHIV,
                    :SoDKART,
                    :ThongTinDungThuocs,
                    :LieuLuongThuoc_E,
                    :LieuLuongThuoc_H,
                    :LieuLuongThuoc_EH,
                    :LieuLuongThuoc_RH,
                    :LieuLuongThuoc_RHE,
                    :LieuLuongThuoc_Khac2,
                    :GiaiDoanDieuTris,
                    :NgayKetThucDieuTri,
                    :KetQuaDieuTri,
                    :NhanXet,
                    :HoTenDiaChiNguoiNhan,
                    :YBacSyDanhGia,
                    :MaYBacSyDanhGia,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuDieuTriCoKiemSoat SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayBatDauDieuTri=:NgayBatDauDieuTri,
                    DonViDieuTri=:DonViDieuTri,
                    SDTDiaChiBenhNhan=:SDTDiaChiBenhNhan,
                    GSV1=:GSV1,
                    GSV2=:GSV2,
                    Tinh=:Tinh,
                    Huyen=:Huyen,
                    Xa=:Xa,
                    SoDKDT=:SoDKDT,
                    LPCBCVKH=:LPCBCVKH,
                    LPKCBCVKH=:LPKCBCVKH,
                    LNP=:LNP,
                    LNP_Text=:LNP_Text,
                    Moi=:Moi,
                    DTLaiSauBoTri=:DTLaiSauBoTri,
                    TaiPhat=:TaiPhat,
                    TienSuDieuTriKhac=:TienSuDieuTriKhac,
                    ThatBai=:ThatBai,
                    BNKhongRoTienSuDieuTri=:BNKhongRoTienSuDieuTri,
                    PhacDo_1=:PhacDo_1,
                    PhacDo_2=:PhacDo_2,
                    PhacDo_3=:PhacDo_3,
                    PhacDo_4=:PhacDo_4,
                    PhacDoKhac=:PhacDoKhac,
                    RHZE=:RHZE,
                    RHZ=:RHZ,
                    RH=:RH,
                    Z=:Z,
                    E=:E,
                    H=:H,
                    Sg=:Sg,
                    LieuLuongThuoc_Khac=:LieuLuongThuoc_Khac,
                    Cotrimoxazole=:Cotrimoxazole,
                    ART=:ART,
                    Khac=:Khac,
                    TuDien=:TuDien,
                    CTCL=:CTCL,
                    CoSoTuCong=:CoSoTuCong,
                    CoSoTuNhan=:CoSoTuNhan,
                    NoiChuyenDenKhac=:NoiChuyenDenKhac,
                    NoiChuyenDenKhac_Text=:NoiChuyenDenKhac_Text,
                    KetQuaSoiTT_BanDau=:KetQuaSoiTT_BanDau,
                    KetQuaNoiCay_BanDau=:KetQuaNoiCay_BanDau,
                    CanNang_BanDau=:CanNang_BanDau,
                    KetQuaSoiTT_KS1=:KetQuaSoiTT_KS1,
                    KetQuaNoiCay_KS1=:KetQuaNoiCay_KS1,
                    CanNang_KS1=:CanNang_KS1,
                    KetQuaSoiTT_KS2=:KetQuaSoiTT_KS2,
                    KetQuaNoiCay_KS2=:KetQuaNoiCay_KS2,
                    CanNang_KS2=:CanNang_KS2,
                    KetQuaSoiTT_KS3=:KetQuaSoiTT_KS3,
                    KetQuaNoiCay_KS3=:KetQuaNoiCay_KS3,
                    CanNang_KS3=:CanNang_KS3,
                    XQ_BanDau=:XQ_BanDau,
                    Xpert=:Xpert,
                    HainTest=:HainTest,
                    MaTrongSoDKDT_XNH=:MaTrongSoDKDT_XNH,
                    MaTrongSoDKDT_Cot=:MaTrongSoDKDT_Cot,
                    MaTrongSoDKDT_ART=:MaTrongSoDKDT_ART,
                    DKPKNgoaiTruHIV=:DKPKNgoaiTruHIV,
                    SoDKART=:SoDKART,
                    ThongTinDungThuocs=:ThongTinDungThuocs,
                    LieuLuongThuoc_E=:LieuLuongThuoc_E,
                    LieuLuongThuoc_H=:LieuLuongThuoc_H,
                    LieuLuongThuoc_EH=:LieuLuongThuoc_EH,
                    LieuLuongThuoc_RH=:LieuLuongThuoc_RH,
                    LieuLuongThuoc_RHE=:LieuLuongThuoc_RHE,
                    LieuLuongThuoc_Khac2=:LieuLuongThuoc_Khac2,
                    GiaiDoanDieuTris=:GiaiDoanDieuTris,
                    NgayKetThucDieuTri=:NgayKetThucDieuTri,
                    KetQuaDieuTri=:KetQuaDieuTri,
                    NhanXet=:NhanXet,
                    HoTenDiaChiNguoiNhan=:HoTenDiaChiNguoiNhan,
                    YBacSyDanhGia=:YBacSyDanhGia,
                    MaYBacSyDanhGia=:MaYBacSyDanhGia,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBatDauDieuTri", ketQua.NgayBatDauDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DonViDieuTri", ketQua.DonViDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("SDTDiaChiBenhNhan", ketQua.SDTDiaChiBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("GSV1", ketQua.GSV1));
                Command.Parameters.Add(new MDB.MDBParameter("GSV2", ketQua.GSV2));
                Command.Parameters.Add(new MDB.MDBParameter("Tinh", ketQua.Tinh));
                Command.Parameters.Add(new MDB.MDBParameter("Huyen", ketQua.Huyen));
                Command.Parameters.Add(new MDB.MDBParameter("Xa", ketQua.Xa));
                Command.Parameters.Add(new MDB.MDBParameter("SoDKDT", ketQua.SoDKDT));
                Command.Parameters.Add(new MDB.MDBParameter("LPCBCVKH", ketQua.LPCBCVKH));
                Command.Parameters.Add(new MDB.MDBParameter("LPKCBCVKH", ketQua.LPKCBCVKH));
                Command.Parameters.Add(new MDB.MDBParameter("LNP", ketQua.LNP));
                Command.Parameters.Add(new MDB.MDBParameter("LNP_Text", ketQua.LNP_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Moi", ketQua.Moi));
                Command.Parameters.Add(new MDB.MDBParameter("DTLaiSauBoTri", ketQua.DTLaiSauBoTri));
                Command.Parameters.Add(new MDB.MDBParameter("TaiPhat", ketQua.TaiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDieuTriKhac", ketQua.TienSuDieuTriKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThatBai", ketQua.ThatBai));
                Command.Parameters.Add(new MDB.MDBParameter("BNKhongRoTienSuDieuTri", ketQua.BNKhongRoTienSuDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("PhacDo_1", ketQua.PhacDo_1));
                Command.Parameters.Add(new MDB.MDBParameter("PhacDo_2", ketQua.PhacDo_2));
                Command.Parameters.Add(new MDB.MDBParameter("PhacDo_3", ketQua.PhacDo_3));
                Command.Parameters.Add(new MDB.MDBParameter("PhacDo_4", ketQua.PhacDo_4));
                Command.Parameters.Add(new MDB.MDBParameter("PhacDoKhac", ketQua.PhacDoKhac));
                Command.Parameters.Add(new MDB.MDBParameter("RHZE", ketQua.RHZE));
                Command.Parameters.Add(new MDB.MDBParameter("RHZ", ketQua.RHZ));
                Command.Parameters.Add(new MDB.MDBParameter("RH", ketQua.RH));
                Command.Parameters.Add(new MDB.MDBParameter("Z", ketQua.Z));
                Command.Parameters.Add(new MDB.MDBParameter("E", ketQua.E));
                Command.Parameters.Add(new MDB.MDBParameter("H", ketQua.H));
                Command.Parameters.Add(new MDB.MDBParameter("Sg", ketQua.Sg));
                Command.Parameters.Add(new MDB.MDBParameter("LieuLuongThuoc_Khac", ketQua.LieuLuongThuoc_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Cotrimoxazole", ketQua.Cotrimoxazole));
                Command.Parameters.Add(new MDB.MDBParameter("ART", ketQua.ART));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", ketQua.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TuDien", ketQua.TuDien));
                Command.Parameters.Add(new MDB.MDBParameter("CTCL", ketQua.CTCL));
                Command.Parameters.Add(new MDB.MDBParameter("CoSoTuCong", ketQua.CoSoTuCong));
                Command.Parameters.Add(new MDB.MDBParameter("CoSoTuNhan", ketQua.CoSoTuNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NoiChuyenDenKhac", ketQua.NoiChuyenDenKhac));
                Command.Parameters.Add(new MDB.MDBParameter("NoiChuyenDenKhac_Text", ketQua.NoiChuyenDenKhac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaSoiTT_BanDau", ketQua.KetQuaSoiTT_BanDau));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaNoiCay_BanDau", ketQua.KetQuaNoiCay_BanDau));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang_BanDau", ketQua.CanNang_BanDau));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaSoiTT_KS1", ketQua.KetQuaSoiTT_KS1));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaNoiCay_KS1", ketQua.KetQuaNoiCay_KS1));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang_KS1", ketQua.CanNang_KS1));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaSoiTT_KS2", ketQua.KetQuaSoiTT_KS2));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaNoiCay_KS2", ketQua.KetQuaNoiCay_KS2));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang_KS2", ketQua.CanNang_KS2));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaSoiTT_KS3", ketQua.KetQuaSoiTT_KS3));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaNoiCay_KS3", ketQua.KetQuaNoiCay_KS3));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang_KS3", ketQua.CanNang_KS3));
                Command.Parameters.Add(new MDB.MDBParameter("XQ_BanDau", ketQua.XQ_BanDau));
                Command.Parameters.Add(new MDB.MDBParameter("Xpert", ketQua.Xpert));
                Command.Parameters.Add(new MDB.MDBParameter("HainTest", ketQua.HainTest));
                Command.Parameters.Add(new MDB.MDBParameter("MaTrongSoDKDT_XNH", ketQua.MaTrongSoDKDT_XNH));
                Command.Parameters.Add(new MDB.MDBParameter("MaTrongSoDKDT_Cot", ketQua.MaTrongSoDKDT_Cot));
                Command.Parameters.Add(new MDB.MDBParameter("MaTrongSoDKDT_ART", ketQua.MaTrongSoDKDT_ART));
                Command.Parameters.Add(new MDB.MDBParameter("DKPKNgoaiTruHIV", ketQua.DKPKNgoaiTruHIV));
                Command.Parameters.Add(new MDB.MDBParameter("SoDKART", ketQua.SoDKART));
                Command.Parameters.Add(new MDB.MDBParameter("ThongTinDungThuocs", JsonConvert.SerializeObject(ketQua.ThongTinDungThuocs)));
                Command.Parameters.Add(new MDB.MDBParameter("LieuLuongThuoc_E", ketQua.LieuLuongThuoc_E));
                Command.Parameters.Add(new MDB.MDBParameter("LieuLuongThuoc_H", ketQua.LieuLuongThuoc_H));
                Command.Parameters.Add(new MDB.MDBParameter("LieuLuongThuoc_EH", ketQua.LieuLuongThuoc_EH));
                Command.Parameters.Add(new MDB.MDBParameter("LieuLuongThuoc_RH", ketQua.LieuLuongThuoc_RH));
                Command.Parameters.Add(new MDB.MDBParameter("LieuLuongThuoc_RHE", ketQua.LieuLuongThuoc_RHE));
                Command.Parameters.Add(new MDB.MDBParameter("LieuLuongThuoc_Khac2", ketQua.LieuLuongThuoc_Khac2));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoanDieuTris", JsonConvert.SerializeObject(ketQua.GiaiDoanDieuTris)));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKetThucDieuTri", ketQua.NgayKetThucDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", ketQua.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXet", ketQua.NhanXet));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenDiaChiNguoiNhan", ketQua.HoTenDiaChiNguoiNhan));
                Command.Parameters.Add(new MDB.MDBParameter("YBacSyDanhGia", ketQua.YBacSyDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("MaYBacSyDanhGia", ketQua.MaYBacSyDanhGia));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
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
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuDieuTriCoKiemSoat WHERE ID = :ID";
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuDieuTriCoKiemSoat P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ObservableCollection<ThongTinBenhNhanDungThuoc>  ThongTinDungThuocs = JsonConvert.DeserializeObject<ObservableCollection<ThongTinBenhNhanDungThuoc>>(ds.Tables[0].Rows[0]["ThongTinDungThuocs"].ToString());
            ObservableCollection <ThongTinBenhNhanDungThuoc>  GiaiDoanDieuTris = JsonConvert.DeserializeObject<ObservableCollection<ThongTinBenhNhanDungThuoc>>(ds.Tables[0].Rows[0]["GiaiDoanDieuTris"].ToString());
            ds.Tables.Add(Common.ListToDataTable(ThongTinDungThuocs, "CT1"));
            ds.Tables.Add(Common.ListToDataTable(GiaiDoanDieuTris, "CT2"));

            return ds;
        }
    }
}
