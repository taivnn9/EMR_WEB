using DevExpress.XtraReports.UI;
using EMR.KyDienTu;
using EMR_MAIN.ChucNangKhac;
using EMR_MAIN.DATABASE.BenhAn;
using EMR_MAIN.DATABASE.BenhAnFunc;
using EMR_MAIN.HanhChinh;
using EMR_MAIN.HoiBenh;
using EMR_MAIN.InBenhAn;
using EMR_MAIN.KhamBenh;
using EMR_MAIN.TongKet;
using EMR_MAIN.ViewModel;
using MDB;
using Newtonsoft.Json;
using NLog;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Controls;
using System.Windows.Threading;
using static EMR_MAIN.Report;

namespace EMR_MAIN
{
    public class ThongTinHoSoBenhAn
    {
        public  LoaiBenhAnEMR LoaiBenhAnEMR { get; set; }
        public  HanhChinhBenhNhan HanhChinhBenhNhan { get; set; }
        public  ThongTinDieuTri ThongTinDieuTri { get; set; }
        public  object BenhAn { get; set; }
        public  string FTPImage { get; set; }
        public string TokenKy { get; set; }

    }
    public class XemBenhAn
    {
        public static List<emr_loaiphieu> DSLoaiPhieu = null;
        static Logger log = LogManager.GetLogger("Log");
        public static APITokenCloud apiToken = new APITokenCloud();
        public static string[] APICloudGetToken = new string[1] { "wa/qnrhd1r+hqJuCDM0fkE1X0ASvRuOiXM7K9ILx0s3LmknqwvKCWCNfAEu60yULkkM5LX8dAD8ulvoalSrCMZtXM8AabzEhX15ZKlwpM2JmrgcTyEHpgkaW2l/km3yN" };
        //static bool DaConfig = false;
        //quanlytoken=true
        public static string tokenCloud = "";
        public static LibraryTracking.Host HostTracking { get; set; }
        public static long UserIDLogin = 0;
        public static string UserCodeLogin = string.Empty;
        public static string userCode = string.Empty;
        public static decimal patientId = 0;
        public static ThongTinHoSoBenhAn _thongTinHoSoBenhAn;
        public static bool ThuocKhoaHuyetHoc = false;
        
        public static List<ThuocKhangSinh> DanhSachThuocKhangSinh = new List<ThuocKhangSinh>();
        public static List<BedInfo> ListThongTinGiuong = new List<BedInfo>();

        public static decimal VienPhiID = 0;

        public static bool DongBenhAn = false;
        public static bool dongBenhAnFinal = false;

        public static int DefaultPageIndex = 0;
        // Cac bien Static de dung cho nhieu form
        #region Thong tin tu EMR
        public static LoaiBenhAnEMR _LoaiBenhAnEMR;
        public static HanhChinhBenhNhan _HanhChinhBenhNhan;
        public static ThongTinDieuTri _ThongTinDieuTri;
        public static DauSinhTon _DauSinhTonMoi;
        //Thong tin che do an
        public static List<ThongTinCheDoAn> _ListThongTinCheDoAn;

        public static List<ChanDoan> _ListChanDoan;
        public static List<PhuongPhapPTTT> _ListPhuongPhapPTTT;
        public static List<PhauThuatThuThuat_HIS> _ListPTTT_HIS;
        public static List<DauSinhTon> _ListDauHieuSinhTons;
        public static string JsonInput;
        #endregion
        public static object BenhAn;
        public static MDB.MDBConnection MyConnection = null;
        public static List<string> ListPhuongPhapTT = new List<string>(){
                "Phẫu thuật loại đặc biệt",
                "Phẫu thuật loại 1",
                "Phẫu thuật loại 2",
                "Phẫu thuật loại 3",
                "Thủ thuật loại đặc biệt",
                "Thủ thuật loại 1",
                "Thủ thuật loại 2",
                "Thủ thuật loại 3",
            };
        public static List<FileCopy> Images { get; set; }
        public static List<ThongTinPhieu> _TTCauHinhPhieu;
        public static ControlAPINhanVien crtNV = new ControlAPINhanVien();
        public static ControlAPIPhauThuatThuThuat crtPTTT = new ControlAPIPhauThuatThuThuat();
        public static ControlAPIBenhAn crtBA = new ControlAPIBenhAn();
        public static ControlAPIThongTinPhieu crtTTP = new ControlAPIThongTinPhieu();
        public static ControlAPIThongTinDieuTri crtTTDT = new ControlAPIThongTinDieuTri();
        public static bool MoPhieu;
        public static string MaPhieuMo;
        public static List<ChiSoXetNghiemADO> listChiSoXetNghiem = new List<ChiSoXetNghiemADO>();
        public static bool IsHis1;
        public static bool IsHis2
        {
            get
            {
#if HIS2
                return true;
#else
                return false;
#endif
            }
        }
        public static bool IsHisPro = false;
        public static bool DoiVoBenhAnState = false;

        public static bool KetXuatHoSo { get; set; } = false; //16/06/2021 Add by Hòa issues 65347
        public static RoomInfo _roomInfo;
        public static int _CanhBaoVanBanDaKy { get; set; }
        public static List<DATABASE.DanhSachPhieu.MauPhieuNghiepVuKy> _MauPhieuNghiepVuKy { get; set; }//27/10/2021 Add by Hòa 2712 lấy nghiệp vụ ký Business_code về Business_code
        XemBenhAn()
        {
            log.LogConfig();
        }
        public XemBenhAn(MDB.MDBConnection myConnection)
            : this()
        {
            MyConnection = myConnection;
        }
        static void ChekPic(PicDefaults file)
        {
            string key = Guid.NewGuid().ToString();
            var timer = new Stopwatch();
            timer.Start();
            log.Info("Begin ChekPic: '" + key + "'");
            try
            {
                string folder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string tempFolder = folder + @"\PaintLibrary\HinhAnh";
                if (!System.IO.Directory.Exists(tempFolder))
                {
                    System.IO.Directory.CreateDirectory(tempFolder);
                }
                tempFolder = tempFolder.Trim('\\') + "\\";
                string tempFile = tempFolder + file.Description();

                if (!System.IO.File.Exists(tempFile))
                {
                    switch (file)
                    {
                        case PicDefaults.TMH_CoNghiengPhai:
                            System.Drawing.Bitmap bCNP = global::EMR_MAIN.Properties.Resources.TMH_CoNghiengPhai;
                            bCNP.Save(tempFile);
                            break;
                        case PicDefaults.TMH_CoNghiengTrai:
                            System.Drawing.Bitmap bCNT = global::EMR_MAIN.Properties.Resources.TMH_CoNghiengTrai;
                            bCNT.Save(tempFile);
                            break;
                        case PicDefaults.TMH_Hong:
                            System.Drawing.Bitmap bH = global::EMR_MAIN.Properties.Resources.TMH_Hong;
                            bH.Save(tempFile);
                            break;
                        case PicDefaults.TMH_ManNhiPhai:
                            System.Drawing.Bitmap bMNP = global::EMR_MAIN.Properties.Resources.TMH_ManNhiPhai;
                            bMNP.Save(tempFile);
                            break;
                        case PicDefaults.TMH_ManNhiTrai:
                            System.Drawing.Bitmap bMNT = global::EMR_MAIN.Properties.Resources.TMH_ManNhiTrai;
                            bMNT.Save(tempFile);
                            break;
                        case PicDefaults.TMH_MuiSau:
                            System.Drawing.Bitmap bMS = global::EMR_MAIN.Properties.Resources.TMH_MuiSau;
                            bMS.Save(tempFile);
                            break;
                        case PicDefaults.TMH_MuiTruoc:
                            System.Drawing.Bitmap bMT = global::EMR_MAIN.Properties.Resources.TMH_MuiTruoc;
                            bMT.Save(tempFile);
                            break;
                        case PicDefaults.TMH_ThanhQuan:
                            System.Drawing.Bitmap bTQ = global::EMR_MAIN.Properties.Resources.TMH_ThanhQuan;
                            bTQ.Save(tempFile);
                            break;
                        case PicDefaults.HinhAnhDaLieu:
                            System.Drawing.Bitmap bDL = global::EMR_MAIN.Properties.Resources.HinhAnhDaLieu;
                            bDL.Save(tempFile);
                            break;
                        case PicDefaults.HinhVeTonThuongVaoVienPHCN:
                            System.Drawing.Bitmap bPHCN = global::EMR_MAIN.Properties.Resources.HinhVeTonThuongVaoVienPHCN;
                            bPHCN.Save(tempFile);
                            break;
                        case PicDefaults.BA_MatChanThuong_MP:
                            System.Drawing.Bitmap bBA_MatChanThuong_MP = global::EMR_MAIN.Properties.Resources.BA_MatChanThuong_MP;
                            bBA_MatChanThuong_MP.Save(tempFile);
                            break;
                        case PicDefaults.BA_MatChanThuong_MT:
                            System.Drawing.Bitmap bBA_MatChanThuong_MT = global::EMR_MAIN.Properties.Resources.BA_MatChanThuong_MT;
                            bBA_MatChanThuong_MT.Save(tempFile);
                            break;
                        case PicDefaults.BA_MatChanThuong_VongMac_MP:
                            System.Drawing.Bitmap bBA_MatChanThuong_VongMac_MP = global::EMR_MAIN.Properties.Resources.BA_MatChanThuong_VongMac_MP;
                            bBA_MatChanThuong_VongMac_MP.Save(tempFile);
                            break;
                        case PicDefaults.BA_MatChanThuong_VongMac_MT:
                            System.Drawing.Bitmap bBA_MatChanThuong_VongMac_MT = global::EMR_MAIN.Properties.Resources.BA_MatChanThuong_VongMac_MT;
                            bBA_MatChanThuong_VongMac_MT.Save(tempFile);
                            break;
                        case PicDefaults.BA_MatBanPhanTruoc_MP:
                            System.Drawing.Bitmap bBA_MatBanPhanTruoc_MP = global::EMR_MAIN.Properties.Resources.BA_MatBanPhanTruoc_MP;
                            bBA_MatBanPhanTruoc_MP.Save(tempFile);
                            break;
                        case PicDefaults.BA_MatBanPhanTruoc_MT:
                            System.Drawing.Bitmap bBA_MatBanPhanTruoc_MT = global::EMR_MAIN.Properties.Resources.BA_MatBanPhanTruoc_MT;
                            bBA_MatBanPhanTruoc_MT.Save(tempFile);
                            break;
                        case PicDefaults.ThamDoDienSinhLy_RF:
                            System.Drawing.Bitmap bThamDoDienSinhLy_RF = global::EMR_MAIN.Properties.Resources.ThamDoDienSinhLy_RF;
                            bThamDoDienSinhLy_RF.Save(tempFile);
                            break;
                        case PicDefaults.KQDieuTriCanThiepDMV:
                            System.Drawing.Bitmap bKQDieuTriCanThiepDMV = global::EMR_MAIN.Properties.Resources.KQDieuTriCanThiepDMV;
                            bKQDieuTriCanThiepDMV.Save(tempFile);
                            break;
                        case PicDefaults.phieudanhgianguoibenhnhapvien001:
                            System.Drawing.Bitmap phieudanhgianguoibenhnhapvien001 = global::EMR_MAIN.Properties.Resources.phieudanhgianguoibenhnhapvien001;
                            phieudanhgianguoibenhnhapvien001.Save(tempFile);
                            break;
                        case PicDefaults.phieudanhgianguoibenhnhapvien002:
                            System.Drawing.Bitmap phieudanhgianguoibenhnhapvien002 = global::EMR_MAIN.Properties.Resources.phieudanhgianguoibenhnhapvien002;
                            phieudanhgianguoibenhnhapvien002.Save(tempFile);
                            break;
                        case PicDefaults.BenhAnNgoaiTruMat_MatPhai:
                            System.Drawing.Bitmap BenhAnNgoaiTruMat_MatPhai = global::EMR_MAIN.Properties.Resources.BenhAnNgoaiTruMat_MatPhai;
                            BenhAnNgoaiTruMat_MatPhai.Save(tempFile);
                            break;
                        case PicDefaults.BenhAnNgoaiTruMat_MatTrai:
                            System.Drawing.Bitmap BenhAnNgoaiTruMat_MatTrai = global::EMR_MAIN.Properties.Resources.BenhAnNgoaiTruMat_MatTrai;
                            BenhAnNgoaiTruMat_MatTrai.Save(tempFile);
                            break;
                        case PicDefaults.BenhAnNgoaiTruMat_GiacMacPhai:
                            System.Drawing.Bitmap BenhAnNgoaiTruMat_GiacMacPhai = global::EMR_MAIN.Properties.Resources.BenhAnNgoaiTruMat_GiacMacPhai;
                            BenhAnNgoaiTruMat_GiacMacPhai.Save(tempFile);
                            break;
                        case PicDefaults.BenhAnNgoaiTruMat_GiacMacTrai:
                            System.Drawing.Bitmap BenhAnNgoaiTruMat_GiacMacTrai = global::EMR_MAIN.Properties.Resources.BenhAnNgoaiTruMat_GiacMacTrai;
                            BenhAnNgoaiTruMat_GiacMacTrai.Save(tempFile);
                            break;
                        case PicDefaults.DaLieuTW_Phai:
                            System.Drawing.Bitmap DaLieuTW_Phai = global::EMR_MAIN.Properties.Resources.DaLieuTW_Phai;
                            DaLieuTW_Phai.Save(tempFile);
                            break;
                        case PicDefaults.DaLieuTW_Trai:
                            System.Drawing.Bitmap DaLieuTW_Trai = global::EMR_MAIN.Properties.Resources.DaLieuTW_Trai;
                            DaLieuTW_Trai.Save(tempFile);
                            break;
                        case PicDefaults.BAUngThuHacTo:
                            System.Drawing.Bitmap BAUngThuHacTo = global::EMR_MAIN.Properties.Resources.BAUngThuHacTo;
                            BAUngThuHacTo.Save(tempFile);
                            break;
                        case PicDefaults.BenhAnVayNenTheKhop:
                            System.Drawing.Bitmap BenhAnVayNenTheKhop = global::EMR_MAIN.Properties.Resources.BenhAnVayNenTheKhop;
                            BenhAnVayNenTheKhop.Save(tempFile);
                            break;
                        default:
                            System.Drawing.Bitmap bDefault = global::EMR_MAIN.Properties.Resources.Default;
                            bDefault.Save(tempFile);
                            break;
                    }
                }
            }
            catch { }
            finally
            {
                timer.Stop();
                log.Info("End ChekPic: '" + key + "'. Total: " + timer.ElapsedMilliseconds.ToString() + " ms");
            }
        }

        public static void AddImage(FileCopy image)
        {
            if (image == null)
            {
                return;
            }
            string key = Guid.NewGuid().ToString();
            var timer = new Stopwatch();
            timer.Start();
            log.Info("Begin AddImage: '" + key + "'");
            if (XemBenhAn.Images == null)
            {
                XemBenhAn.Images = new List<FileCopy>();
            }
            var v_T = XemBenhAn.Images.Where(x => x.FileName.ToLower() == image.FileName.ToLower()).FirstOrDefault();
            if (v_T == null)
            {
                XemBenhAn.Images.Add(image);
            }
            timer.Stop();
            log.Info("End AddImage: '" + key + "'. Total: " + timer.ElapsedMilliseconds.ToString() + " ms");
        }
        static void InitPic()
        {
            string key = Guid.NewGuid().ToString();
            var timer = new Stopwatch();
            timer.Start();
            log.Info("Begin InitPic: '" + key + "'");
            try
            {
                foreach (var pic in (IList<PicDefaults>)Enum.GetValues(typeof(PicDefaults)))
                {
                    ChekPic(pic);
                }
            }
            catch { }
            finally
            {
                timer.Stop();
                log.Info("End InitPic: '" + key + "'. Total: " + timer.ElapsedMilliseconds.ToString() + " ms");
            }
        }


        static BackgroundWorker bckSyncEMR;
        public static object InitVoBenhAn(LoaiBenhAnEMR loaiBenhAnEMR, HanhChinhBenhNhan hanhChinhBenhNhan, ThongTinDieuTri thongTinDieuTri)
        {

            switch (loaiBenhAnEMR)
            {
                case LoaiBenhAnEMR.NoiKhoa:
                    BenhAnNoiKhoa _BenhAnNoiKhoa = new BenhAnNoiKhoa();
                    _BenhAnNoiKhoa.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnNoiKhoa.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnNoiKhoa.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNoiKhoa.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnNoiKhoa.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnNoiKhoa.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnNoiKhoa;
                case LoaiBenhAnEMR.NhiKhoa:
                    BenhAnNhiKhoa _BenhAnNhiKhoa = new BenhAnNhiKhoa();
                    _BenhAnNhiKhoa.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnNhiKhoa.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnNhiKhoa.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNhiKhoa.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnNhiKhoa.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnNhiKhoa.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnNhiKhoa;
                case LoaiBenhAnEMR.TruyenNhiem:
                    BenhAnTruyenNhiem _BenhAnTruyenNhiem = JsonConvert.DeserializeObject<BenhAnTruyenNhiem>(XemBenhAn.JsonInput);
                    _BenhAnTruyenNhiem.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnTruyenNhiem.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnTruyenNhiem.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnTruyenNhiem.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnTruyenNhiem.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnTruyenNhiem.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnTruyenNhiem;
                case LoaiBenhAnEMR.TruyenNhiemII:
                    BenhAnTruyenNhiemII _BenhAnTruyenNhiemII = JsonConvert.DeserializeObject<BenhAnTruyenNhiemII>(XemBenhAn.JsonInput);
                    _BenhAnTruyenNhiemII.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnTruyenNhiemII.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnTruyenNhiemII.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnTruyenNhiemII.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnTruyenNhiemII.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnTruyenNhiemII.NgayKhamBenh = DateTime.Now;
                    }
                    if (_BenhAnTruyenNhiemII.TienSuDiUngs == null || _BenhAnTruyenNhiemII.TienSuDiUngs.Count == 0)
                    {
                        _BenhAnTruyenNhiemII.TienSuDiUngs = TienSuDiUng.CreateData();
                    }
                    return _BenhAnTruyenNhiemII;
                case LoaiBenhAnEMR.PhuKhoa:
                    BenhAnPhuKhoa _BenhAnPhuKhoa = new BenhAnPhuKhoa();
                    _BenhAnPhuKhoa.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnPhuKhoa.TienSuSanPhuKhoa = new TienSuSanPhuKhoa();
                    _BenhAnPhuKhoa.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnPhuKhoa.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnPhuKhoa.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnPhuKhoa.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnPhuKhoa.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnPhuKhoa;
                case LoaiBenhAnEMR.SanKhoa:
                    BenhAnSanKhoa _BenhAnSanKhoa = new BenhAnSanKhoa();
                    _BenhAnSanKhoa.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnSanKhoa.iDaThai = -1;
                    _BenhAnSanKhoa.iDonThai = -1;
                    _BenhAnSanKhoa.iOiVoID = -1;
                    _BenhAnSanKhoa.iRau = -1;
                    _BenhAnSanKhoa.KinhCuoiCungTuNgay = DateTime.Now;
                    _BenhAnSanKhoa.KinhCuoiCungDenNgay = DateTime.Now;
                    _BenhAnSanKhoa.BatDauChuyenDaTu = DateTime.Now;
                    _BenhAnSanKhoa.OiVoLuc = DateTime.Now;
                    _BenhAnSanKhoa.ThoiGianVaoBuongDe = DateTime.Now;
                    _BenhAnSanKhoa.ThoiGianDe = DateTime.Now;
                    _BenhAnSanKhoa.ThoiGianRauSo = DateTime.Now;
                    if (XemBenhAn.IsHis2)
                    {
                        _BenhAnSanKhoa.ThoiGianVaoBuongDe = null;
                        _BenhAnSanKhoa.ThoiGianDe = null;
                        _BenhAnSanKhoa.ThoiGianRauSo = null;
                    }
                    _BenhAnSanKhoa.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnSanKhoa.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnSanKhoa.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnSanKhoa.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnSanKhoa.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnSanKhoa;
                case LoaiBenhAnEMR.SoSinh:
                    BenhAnSoSinh _BenhAnSoSinh = new BenhAnSoSinh();
                    _BenhAnSoSinh.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnSoSinh.iCachDeID = 0;
                    _BenhAnSoSinh.ThoiGianDe = Convert.ToDateTime(null);
                    _BenhAnSoSinh.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnSoSinh.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnSoSinh.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnSoSinh.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnSoSinh.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnSoSinh;
                case LoaiBenhAnEMR.TamThan:
                    BenhAnTamThan _BenhAnTamThan = new BenhAnTamThan();
                    _BenhAnTamThan.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnTamThan.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnTamThan.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnTamThan.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnTamThan.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnTamThan.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnTamThan;
                case LoaiBenhAnEMR.DaLieu:
                    BenhAnDaLieu _BenhAnDaLieu = new BenhAnDaLieu();
                    _BenhAnDaLieu.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnDaLieu.TinhTrangNguoiBenhRaVien = Converter.EnumHelper<KetQuaDieuTri>.GetEnumDescription(thongTinDieuTri.KetQuaDieuTri.ToString());

                    _BenhAnDaLieu.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnDaLieu.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnDaLieu.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnDaLieu.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnDaLieu.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnDaLieu;
                case LoaiBenhAnEMR.PhucHoiChucNang:
                    BenhAnPhucHoiChucNang _BenhAnPhucHoiChucNang = new BenhAnPhucHoiChucNang();
                    _BenhAnPhucHoiChucNang.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnPhucHoiChucNang.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnPhucHoiChucNang.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnPhucHoiChucNang.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnPhucHoiChucNang.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnPhucHoiChucNang.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnPhucHoiChucNang;
                case LoaiBenhAnEMR.HuyetHocTruyenMau:
                    BenhAnHuyetHocTruyenMau _BenhAnHuyetHocTruyenMau = new BenhAnHuyetHocTruyenMau();
                    _BenhAnHuyetHocTruyenMau.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnHuyetHocTruyenMau.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnHuyetHocTruyenMau.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnHuyetHocTruyenMau.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnHuyetHocTruyenMau.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnHuyetHocTruyenMau.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnHuyetHocTruyenMau;
                case LoaiBenhAnEMR.NgoaiKhoa:
                    BenhAnNgoaiKhoa _BenhAnNgoaiKhoa = new BenhAnNgoaiKhoa();
                    _BenhAnNgoaiKhoa.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnNgoaiKhoa.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnNgoaiKhoa.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiKhoa.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnNgoaiKhoa.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnNgoaiKhoa.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnNgoaiKhoa;
                case LoaiBenhAnEMR.Bong:
                    BenhAnBong _BenhAnBong = new BenhAnBong();
                    _BenhAnBong.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnBong.TinhTrangNguoiBenhRaVien = Converter.EnumHelper<KetQuaDieuTri>.GetEnumDescription(thongTinDieuTri.KetQuaDieuTri.ToString());
                    if (_BenhAnBong.DacDiemLienQuanBenh == null)
                    {
                        _BenhAnBong.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    }
                    if (_BenhAnBong.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnBong.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnBong.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnBong.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnBong;
                case LoaiBenhAnEMR.UngBuou:
                    BenhAnUngBuou _BenhAnUngBuou = new BenhAnUngBuou();
                    _BenhAnUngBuou.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnUngBuou.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnUngBuou.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnUngBuou.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnUngBuou.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnUngBuou.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnUngBuou;
                case LoaiBenhAnEMR.RangHamMat:
                    BenhAnRangHamMat _BenhAnRangHamMat = new BenhAnRangHamMat();
                    _BenhAnRangHamMat.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnRangHamMat.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnRangHamMat.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnRangHamMat.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnRangHamMat.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnRangHamMat.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnRangHamMat;
                case LoaiBenhAnEMR.TaiMuiHong:
                    BenhAnTaiMuiHong _BenhAnTaiMuiHong = new BenhAnTaiMuiHong();
                    _BenhAnTaiMuiHong.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnTaiMuiHong.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnTaiMuiHong.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnTaiMuiHong.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnTaiMuiHong.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnTaiMuiHong.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnTaiMuiHong;
                case LoaiBenhAnEMR.NgoaiTru:
                    BenhAnNgoaiTru _BenhAnNgoaiTru = new BenhAnNgoaiTru();
                    _BenhAnNgoaiTru.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnNgoaiTru.DieuTriNgoaiTru_TuNgay = (thongTinDieuTri.NgayVaoVien != null && !DateTime.MinValue.Equals(thongTinDieuTri.NgayVaoVien)) ? Convert.ToDateTime(thongTinDieuTri.NgayVaoVien) : Convert.ToDateTime(null);
                    _BenhAnNgoaiTru.DieuTriNgoaiTru_DenNgay = (thongTinDieuTri.NgayRaVien != null && !DateTime.MinValue.Equals(thongTinDieuTri.NgayRaVien)) ? Convert.ToDateTime(thongTinDieuTri.NgayRaVien) : DateTime.Now;
                    _BenhAnNgoaiTru.BenhChinh = thongTinDieuTri.BenhChinh_RaVien;
                    _BenhAnNgoaiTru.BenhKemTheo = thongTinDieuTri.BenhKemTheo_RaVien;
                    _BenhAnNgoaiTru.MaICD_BenhChinh = thongTinDieuTri.MaICD_BenhChinh_RaVien;
                    _BenhAnNgoaiTru.MaICD_BenhKemTheo = thongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                    _BenhAnNgoaiTru.ChanDoanKhiRaVien = thongTinDieuTri.BenhChinh_RaVien;
                    _BenhAnNgoaiTru.MAIDC_ChanDoanKhiRaVien = thongTinDieuTri.MaICD_BenhChinh_RaVien;

                    _BenhAnNgoaiTru.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnNgoaiTru.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTru.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnNgoaiTru.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTru.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnNgoaiTru;
                case LoaiBenhAnEMR.NgoaiTruRangHamMat:
                    BenhAnNgoaiTruRangHamMat _BenhAnNgoaiTruRangHamMat = new BenhAnNgoaiTruRangHamMat();
                    _BenhAnNgoaiTruRangHamMat.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnNgoaiTruRangHamMat.DieuTriNgoaiTru_TuNgay = (thongTinDieuTri.NgayVaoVien != null && !DateTime.MinValue.Equals(thongTinDieuTri.NgayVaoVien)) ? Convert.ToDateTime(thongTinDieuTri.NgayVaoVien) : Convert.ToDateTime(null);
                    _BenhAnNgoaiTruRangHamMat.DieuTriNgoaiTru_DenNgay = (thongTinDieuTri.NgayRaVien != null && !DateTime.MinValue.Equals(thongTinDieuTri.NgayRaVien)) ? Convert.ToDateTime(thongTinDieuTri.NgayRaVien) : DateTime.Now;
                    _BenhAnNgoaiTruRangHamMat.BenhChinh = thongTinDieuTri.BenhChinh_RaVien;
                    _BenhAnNgoaiTruRangHamMat.BenhKemTheo = thongTinDieuTri.BenhKemTheo_RaVien;
                    _BenhAnNgoaiTruRangHamMat.MaICD_BenhChinh = thongTinDieuTri.MaICD_BenhChinh_RaVien;
                    _BenhAnNgoaiTruRangHamMat.MaICD_BenhKemTheo = thongTinDieuTri.MaICD_BenhKemTheo_RaVien;


                    _BenhAnNgoaiTruRangHamMat.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();

                    _BenhAnNgoaiTruRangHamMat.NgayKhamBenh = _BenhAnNgoaiTruRangHamMat.NgayKhamBenh == Convert.ToDateTime(null) ? DateTime.Now : _BenhAnNgoaiTruRangHamMat.NgayKhamBenh;
                    _BenhAnNgoaiTruRangHamMat.NgayTongKet = _BenhAnNgoaiTruRangHamMat.NgayTongKet == Convert.ToDateTime(null) ? DateTime.Now : _BenhAnNgoaiTruRangHamMat.NgayTongKet;
                    if (_BenhAnNgoaiTruRangHamMat.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTruRangHamMat.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnNgoaiTruRangHamMat.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTruRangHamMat.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnNgoaiTruRangHamMat;
                case LoaiBenhAnEMR.NgoaiTruTaiMuiHong:
                    BenhAnNgoaiTruTaiMuiHong _BenhAnNgoaiTruTaiMuiHong = new BenhAnNgoaiTruTaiMuiHong();
                    _BenhAnNgoaiTruTaiMuiHong.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnNgoaiTruTaiMuiHong.DieuTriNgoaiTru_TuNgay = (thongTinDieuTri.NgayVaoVien != null && !DateTime.MinValue.Equals(XemBenhAn._ThongTinDieuTri.NgayVaoVien)) ? Convert.ToDateTime(XemBenhAn._ThongTinDieuTri.NgayVaoVien) : Convert.ToDateTime(null);
                    _BenhAnNgoaiTruTaiMuiHong.DieuTriNgoaiTru_DenNgay = (XemBenhAn._ThongTinDieuTri.NgayRaVien != null && !DateTime.MinValue.Equals(XemBenhAn._ThongTinDieuTri.NgayRaVien)) ? Convert.ToDateTime(XemBenhAn._ThongTinDieuTri.NgayRaVien) : DateTime.Now;
                    _BenhAnNgoaiTruTaiMuiHong.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                    _BenhAnNgoaiTruTaiMuiHong.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                    _BenhAnNgoaiTruTaiMuiHong.MaICD_BenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                    _BenhAnNgoaiTruTaiMuiHong.MaICD_BenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;


                    _BenhAnNgoaiTruTaiMuiHong.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();

                    _BenhAnNgoaiTruTaiMuiHong.NgayKhamBenh = _BenhAnNgoaiTruTaiMuiHong.NgayKhamBenh == Convert.ToDateTime(null) ? DateTime.Now : _BenhAnNgoaiTruTaiMuiHong.NgayKhamBenh;
                    _BenhAnNgoaiTruTaiMuiHong.NgayTongKet = _BenhAnNgoaiTruTaiMuiHong.NgayTongKet == Convert.ToDateTime(null) ? DateTime.Now : _BenhAnNgoaiTruTaiMuiHong.NgayTongKet;
                    if (_BenhAnNgoaiTruTaiMuiHong.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTruTaiMuiHong.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnNgoaiTruTaiMuiHong.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTruTaiMuiHong.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnNgoaiTruTaiMuiHong;
                case LoaiBenhAnEMR.XaPhuong:
                    BenhAnXaPhuong _BenhAnXaPhuong = new BenhAnXaPhuong();
                    _BenhAnXaPhuong.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnXaPhuong.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnXaPhuong.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnXaPhuong.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnXaPhuong.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnXaPhuong.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnXaPhuong;
                case LoaiBenhAnEMR.MatLac:
                    BenhAnMatLac _BenhAnMatLac = new BenhAnMatLac();
                    _BenhAnMatLac.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnMatLac.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnMatLac.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnMatLac.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnMatLac.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnMatLac.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnMatLac;
                case LoaiBenhAnEMR.MatTreEm:
                    BenhAnMatTreEm _BenhAnMatTreEm = new BenhAnMatTreEm();
                    _BenhAnMatTreEm.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnMatTreEm.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnMatTreEm.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnMatTreEm.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnMatTreEm.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnMatTreEm.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnMatTreEm;
                case LoaiBenhAnEMR.MatGloCom:
                    BenhAnMatGlocom _BenhAnMatGloCom = new BenhAnMatGlocom();
                    _BenhAnMatGloCom.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnMatGloCom.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnMatGloCom.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnMatGloCom.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnMatGloCom.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnMatGloCom.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnMatGloCom;
                case LoaiBenhAnEMR.MatDayMat:
                    BenhAnMatDayMat _BenhAnMatDayMat = new BenhAnMatDayMat();
                    _BenhAnMatDayMat.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnMatDayMat.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnMatDayMat.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnMatDayMat.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnMatDayMat.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnMatDayMat.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnMatDayMat;
                case LoaiBenhAnEMR.MatChanThuong:
                    BenhAnMatChanThuong _BenhAnMatChanThuong = new BenhAnMatChanThuong();
                    _BenhAnMatChanThuong.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnMatChanThuong.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnMatChanThuong.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnMatChanThuong.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnMatChanThuong.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnMatChanThuong.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnMatChanThuong;
                case LoaiBenhAnEMR.MatBanPhanTruoc:
                    BenhAnMatBanPhanTruoc _BenhAnBanPhanTruoc = new BenhAnMatBanPhanTruoc();
                    _BenhAnBanPhanTruoc.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnBanPhanTruoc.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnBanPhanTruoc.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnBanPhanTruoc.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnBanPhanTruoc.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnBanPhanTruoc.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnBanPhanTruoc;
                case LoaiBenhAnEMR.NoiTruYHCT:
                    BenhAnNoiTruYHCT _BenhAnNoiTruYHCT = new BenhAnNoiTruYHCT();
                    _BenhAnNoiTruYHCT.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnNoiTruYHCT.MachTayTrai_Thon1 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayTrai_Thon1);
                    _BenhAnNoiTruYHCT.MachTayTrai_Thon2 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayTrai_Thon2);
                    _BenhAnNoiTruYHCT.MachTayTrai_Thon3 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayTrai_Thon3);
                    _BenhAnNoiTruYHCT.MachTayTrai_Quan1 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayTrai_Quan1);
                    _BenhAnNoiTruYHCT.MachTayTrai_Quan2 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayTrai_Quan2);
                    _BenhAnNoiTruYHCT.MachTayTrai_Quan3 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayTrai_Quan3);
                    _BenhAnNoiTruYHCT.MachTayTrai_Xich1 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayTrai_Xich1);
                    _BenhAnNoiTruYHCT.MachTayTrai_Xich2 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayTrai_Xich2);
                    _BenhAnNoiTruYHCT.MachTayTrai_Xich3 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayTrai_Xich3);
                    _BenhAnNoiTruYHCT.MachTayPhai_Thon1 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayPhai_Thon1);
                    _BenhAnNoiTruYHCT.MachTayPhai_Thon2 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayPhai_Thon2);
                    _BenhAnNoiTruYHCT.MachTayPhai_Thon3 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayPhai_Thon3);
                    _BenhAnNoiTruYHCT.MachTayPhai_Quan1 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayPhai_Quan1);
                    _BenhAnNoiTruYHCT.MachTayPhai_Quan2 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayPhai_Quan2);
                    _BenhAnNoiTruYHCT.MachTayPhai_Quan3 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayPhai_Quan3);
                    _BenhAnNoiTruYHCT.MachTayPhai_Xich1 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayPhai_Xich1);
                    _BenhAnNoiTruYHCT.MachTayPhai_Xich2 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayPhai_Xich2);
                    _BenhAnNoiTruYHCT.MachTayPhai_Xich3 = Common.ConVSpecial(_BenhAnNoiTruYHCT.MachTayPhai_Xich3);

                    _BenhAnNoiTruYHCT.HOSOKQ_CTSCANNER = XemBenhAn._ThongTinDieuTri.HoSo.CTScanner.ToString();
                    _BenhAnNoiTruYHCT.HOSOKQ_XQUANG = XemBenhAn._ThongTinDieuTri.HoSo.XQuang.ToString();
                    _BenhAnNoiTruYHCT.HOSOKQ_KHAC = XemBenhAn._ThongTinDieuTri.HoSo.Khac.ToString();
                    _BenhAnNoiTruYHCT.HOSOKQ_KHAC_TXT = XemBenhAn._ThongTinDieuTri.HoSo.Khac_Text;
                    _BenhAnNoiTruYHCT.HOSOKQ_TOANBOHOSO = XemBenhAn._ThongTinDieuTri.HoSo.ToanBoHoSo.ToString();

                    if (_BenhAnNoiTruYHCT.DacDiemLienQuanBenh == null) _BenhAnNoiTruYHCT.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnNoiTruYHCT.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNoiTruYHCT.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnNoiTruYHCT.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnNoiTruYHCT.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnNoiTruYHCT;
                case LoaiBenhAnEMR.NgoaiTruYHCT:
                    BenhAnNgoaiTruYHCT _BenhAnNgoaiTruYHCT = new BenhAnNgoaiTruYHCT();
                    _BenhAnNgoaiTruYHCT.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnNgoaiTruYHCT.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();

                    _BenhAnNgoaiTruYHCT.NgayKhamBenh = _BenhAnNgoaiTruYHCT.NgayKhamBenh == Convert.ToDateTime(null) ? DateTime.Now : _BenhAnNgoaiTruYHCT.NgayKhamBenh;
                    _BenhAnNgoaiTruYHCT.NgayTongKet = _BenhAnNgoaiTruYHCT.NgayTongKet == Convert.ToDateTime(null) ? DateTime.Now : _BenhAnNgoaiTruYHCT.NgayTongKet;

                    return _BenhAnNgoaiTruYHCT;
                case LoaiBenhAnEMR.PhaThaiI:
                    BenhAnPhaThaiI _BenhAnPhaThaiI = new BenhAnPhaThaiI();
                    _BenhAnPhaThaiI.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnPhaThaiI.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnPhaThaiI.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnPhaThaiI.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnPhaThaiI.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnPhaThaiI.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnPhaThaiI;
                case LoaiBenhAnEMR.PhaThaiII:
                    BenhAnPhaThaiII _BenhAnPhaThaiII = new BenhAnPhaThaiII();
                    _BenhAnPhaThaiII.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnPhaThaiII.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnPhaThaiII.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnPhaThaiII.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnPhaThaiII.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnPhaThaiII.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnPhaThaiII;
                case LoaiBenhAnEMR.DieuTriBanNgay:
                    BenhAnDieuTriBanNgay _BenhAnDieuTriBanNgay = new BenhAnDieuTriBanNgay();
                    _BenhAnDieuTriBanNgay.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnDieuTriBanNgay.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnDieuTriBanNgay.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnDieuTriBanNgay.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnDieuTriBanNgay.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnDieuTriBanNgay.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnDieuTriBanNgay;
                case LoaiBenhAnEMR.ThanNhanTao:
                    BenhAnThanNhanTao _BenhAnThanNhanTao = new BenhAnThanNhanTao();
                    _BenhAnThanNhanTao.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnThanNhanTao.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnThanNhanTao.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnThanNhanTao.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnThanNhanTao.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnThanNhanTao.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnThanNhanTao;
                case LoaiBenhAnEMR.Mat:
                    BenhAnMat _BenhAnMat = new BenhAnMat();
                    _BenhAnMat.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnMat.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnMat.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnMat.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnMat.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnMat.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnMat;
                case LoaiBenhAnEMR.NgoaiTruMat:
                    BenhAnNgoaiTruMat _BenhAnNgoaiTruMat = new BenhAnNgoaiTruMat();
                    _BenhAnNgoaiTruMat.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnNgoaiTruMat.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnNgoaiTruMat.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTruMat.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnNgoaiTruMat.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTruMat.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnNgoaiTruMat;
                case LoaiBenhAnEMR.Tim:
                    BenhAnTim _BenhAnTim = new BenhAnTim();
                    _BenhAnTim.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnTim.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnTim.YeuToNguyCoMachVanh == null)
                    {
                        _BenhAnTim.YeuToNguyCoMachVanh = new NguyCoMachVanh();
                    }
                    if (_BenhAnTim.BenhNoiKhoa == null)
                    {
                        _BenhAnTim.BenhNoiKhoa = new BenhNoiKhoa();
                    }
                    if (_BenhAnTim.TrieuChungCoNang == null)
                    {
                        _BenhAnTim.TrieuChungCoNang = new TrieuChungCoNang();
                    }
                    if (_BenhAnTim.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnTim.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnTim.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnTim.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnTim;
                case LoaiBenhAnEMR.PhucHoiChucNangYHCT:
                    BenhAnPhucHoiChucNangYHCT _BenhAnPhucHoiChucNangYHCT = new BenhAnPhucHoiChucNangYHCT();
                    _BenhAnPhucHoiChucNangYHCT.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Thon1 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Thon1 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Thon2 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Thon2 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Thon3 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Thon3 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Thon4 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Thon4 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Quan1 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Quan1 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Quan2 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Quan2 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Quan3 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Quan3 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Quan4 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Quan4 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Xich1 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Xich1 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Xich2 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Xich2 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Xich3 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Xich3 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Xich4 = _BenhAnPhucHoiChucNangYHCT.MachTayTrai_Xich4 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Thon1 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Thon1 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Thon2 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Thon2 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Thon3 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Thon3 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Thon4 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Thon4 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Quan1 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Quan1 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Quan2 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Quan2 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Quan3 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Quan3 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Quan4 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Quan4 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Xich1 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Xich1 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Xich2 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Xich2 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Xich3 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Xich3 + 1;
                    _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Xich4 = _BenhAnPhucHoiChucNangYHCT.MachTayPhai_Xich4 + 1;


                    if (_BenhAnPhucHoiChucNangYHCT.DacDiemLienQuanBenh == null)
                        _BenhAnPhucHoiChucNangYHCT.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnPhucHoiChucNangYHCT.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnPhucHoiChucNangYHCT.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnPhucHoiChucNangYHCT.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnPhucHoiChucNangYHCT.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnPhucHoiChucNangYHCT;
                case LoaiBenhAnEMR.LuuCapCuu:
                    BenhAnLuuCapCuu _BenhAnLuuCapCuu = new BenhAnLuuCapCuu();
                    _BenhAnLuuCapCuu.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnLuuCapCuu.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();

                    if (_BenhAnLuuCapCuu.RaVienLuc == DateTime.MinValue)
                    {
                        _BenhAnLuuCapCuu.RaVienLuc = DateTime.Now;
                    }
                    if (_BenhAnLuuCapCuu.ThongTinYLenhs == null)
                    {
                        _BenhAnLuuCapCuu.ThongTinYLenhs = new ObservableCollection<ThongTinYLenh>();
                    }
                    _BenhAnLuuCapCuu.ChanDoanBanDau = thongTinDieuTri.ChanDoanNoiGioiThieu;
                    _BenhAnLuuCapCuu.ChanDoanKhiRaVien = thongTinDieuTri.BenhChinh_RaVien;
                    _BenhAnLuuCapCuu.MAIDC_ChanDoanKhiRaVien = thongTinDieuTri.MaICD_BenhChinh_RaVien;
                    if (_BenhAnLuuCapCuu.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnLuuCapCuu.NgayKhamBenh = DateTime.Now;
                    }
                    if (_BenhAnLuuCapCuu.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnLuuCapCuu.NgayTongKet = DateTime.Now;
                    }
                    return _BenhAnLuuCapCuu;
                case LoaiBenhAnEMR.CMU:
                    BenhAnCMU _BenhAnCMU = new BenhAnCMU();
                    _BenhAnCMU.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnCMU.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnCMU.Tuoi == null)
                    {
                        _BenhAnCMU.Tuoi = hanhChinhBenhNhan.Tuoi;
                    }
                    if (_BenhAnCMU.Gioi == null)
                    {
                        _BenhAnCMU.Gioi = hanhChinhBenhNhan.GioiTinh.Description();
                    }
                    if (_BenhAnCMU.CanNang == null && thongTinDieuTri.DauSinhTon.CanNang != 0)
                    {
                        _BenhAnCMU.CanNang = thongTinDieuTri.DauSinhTon.CanNang;
                    }
                    if (_BenhAnCMU.ChieuCao == null && thongTinDieuTri.DauSinhTon.ChieuCao != 0)
                    {
                        _BenhAnCMU.ChieuCao = thongTinDieuTri.DauSinhTon.ChieuCao;
                    }
                    if (_BenhAnCMU.BMI == null && thongTinDieuTri.DauSinhTon.BMI != 0)
                    {
                        _BenhAnCMU.BMI = thongTinDieuTri.DauSinhTon.BMI;
                    }
                    if (_BenhAnCMU.Mach == null && thongTinDieuTri.DauSinhTon.Mach != 0)
                    {
                        _BenhAnCMU.Mach = thongTinDieuTri.DauSinhTon.Mach;
                    }
                    if (_BenhAnCMU.Mach == null && thongTinDieuTri.DauSinhTon.Mach != 0)
                    {
                        _BenhAnCMU.Mach = thongTinDieuTri.DauSinhTon.Mach;
                    }
                    if (_BenhAnCMU.NhietDo == null && thongTinDieuTri.DauSinhTon.NhietDo != 0)
                    {
                        _BenhAnCMU.NhietDo = thongTinDieuTri.DauSinhTon.NhietDo;
                    }
                    if (_BenhAnCMU.HuyetAp == null && !string.IsNullOrEmpty(thongTinDieuTri.DauSinhTon.HuyetAp))
                    {
                        _BenhAnCMU.HuyetAp = thongTinDieuTri.DauSinhTon.HuyetAp;
                    }
                    if (_BenhAnCMU.NhipTho == null && thongTinDieuTri.DauSinhTon.NhipTho != 0)
                    {
                        _BenhAnCMU.NhipTho = thongTinDieuTri.DauSinhTon.NhipTho;
                    }

                    if (_BenhAnCMU.XetNghiemCMUs == null)
                    {
                        _BenhAnCMU.XetNghiemCMUs = new ObservableCollection<XetNghiemCMU>();
                        _BenhAnCMU.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FVC(L)" });
                        _BenhAnCMU.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FEV1(L)" });
                        _BenhAnCMU.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FEV1/FVC(%)" });
                        _BenhAnCMU.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "MMEF(L/s)" });
                        _BenhAnCMU.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "PEF(L/s)" });
                        _BenhAnCMU.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FEF25(L/s)" });
                        _BenhAnCMU.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FEF50(L/s)" });
                        _BenhAnCMU.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FEF75(L/s)" });
                    }
                    if (_BenhAnCMU.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnCMU.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnCMU;
                case LoaiBenhAnEMR.PhaThaiIII:
                    BenhAnPhaThaiIII _BenhAnPhaThaiIII = new BenhAnPhaThaiIII();
                    _BenhAnPhaThaiIII.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnPhaThaiIII.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnPhaThaiIII.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnPhaThaiIII.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnPhaThaiIII.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnPhaThaiIII.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnPhaThaiIII;
                case LoaiBenhAnEMR.NgoaiTruPhucHoiChucNang:
                    BenhAnNgoaiTruPHCN _BenhAnNgoaiTruPHCN = new BenhAnNgoaiTruPHCN();
                    _BenhAnNgoaiTruPHCN.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnNgoaiTruPHCN.DieuTriNgoaiTru_TuNgay = (thongTinDieuTri.NgayVaoVien != null && !DateTime.MinValue.Equals(thongTinDieuTri.NgayVaoVien)) ? Convert.ToDateTime(thongTinDieuTri.NgayVaoVien) : Convert.ToDateTime(null);
                    _BenhAnNgoaiTruPHCN.DieuTriNgoaiTru_DenNgay = (thongTinDieuTri.NgayRaVien != null && !DateTime.MinValue.Equals(thongTinDieuTri.NgayRaVien)) ? Convert.ToDateTime(thongTinDieuTri.NgayRaVien) : DateTime.Now;
                    _BenhAnNgoaiTruPHCN.BenhChinh = thongTinDieuTri.BenhChinh_RaVien;
                    _BenhAnNgoaiTruPHCN.BenhKemTheo = thongTinDieuTri.BenhKemTheo_RaVien;
                    _BenhAnNgoaiTruPHCN.MaICD_BenhChinh = thongTinDieuTri.MaICD_BenhChinh_RaVien;
                    _BenhAnNgoaiTruPHCN.MaICD_BenhKemTheo = thongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                    _BenhAnNgoaiTruPHCN.ChanDoanKhiRaVien = thongTinDieuTri.BenhChinh_RaVien;
                    _BenhAnNgoaiTruPHCN.MAIDC_ChanDoanKhiRaVien = thongTinDieuTri.MaICD_BenhChinh_RaVien;
                    _BenhAnNgoaiTruPHCN.IDGiamDoc = thongTinDieuTri.MaGiamDocBenhVien;
                    _BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnNgoaiTruPHCN.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTruPHCN.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnNgoaiTruPHCN.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTruPHCN.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnNgoaiTruPHCN;
                    
                case LoaiBenhAnEMR.DaLieuTW:
                    BenhAnDaLieuTW _BenhAnDaLieuTW = new BenhAnDaLieuTW();
                    _BenhAnDaLieuTW.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnDaLieuTW.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnDaLieuTW.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnDaLieuTW.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnDaLieuTW.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnDaLieuTW.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnDaLieuTW;
                case LoaiBenhAnEMR.NgoaiTru_VayNenThuongThuong:
                    BenhAnNgoaiTru_BenhVayNenThongThuong _BenhAnNgoaiTru_BenhVayNenThongThuong = new BenhAnNgoaiTru_BenhVayNenThongThuong();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    if (_BenhAnNgoaiTru_BenhVayNenThongThuong.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTru_BenhVayNenThongThuong.NgayTongKet = DateTime.Now;
                    }
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.Methotrexate = new ThuocToanThan();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.VitaminAAcid = new ThuocToanThan();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.Cyclosporine = new ThuocToanThan();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.Corticosteroid = new ThuocToanThan();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.ChePhamSinhHoc1 = new ThuocToanThan();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.ChePhamSinhHoc2 = new ThuocToanThan();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.ChePhamSinhHoc3 = new ThuocToanThan();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.YHocCoTruyen = new ThuocToanThan();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.ThuocKhac = new ThuocToanThan();

                    _BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_TayPhai = new DiemNAPSI();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_TayTrai = new DiemNAPSI();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_ChanPhai = new DiemNAPSI();
                    _BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_ChanTrai = new DiemNAPSI();

                    return _BenhAnNgoaiTru_BenhVayNenThongThuong;
                case LoaiBenhAnEMR.NgoaiTru_AVayNen:
                    BenhAnNgoaiTruAVayNen _BenhAnNTAVayNen = new BenhAnNgoaiTruAVayNen();
                    _BenhAnNTAVayNen.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnNTAVayNen.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAnNTAVayNen.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNTAVayNen.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnNTAVayNen.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnNTAVayNen.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnNTAVayNen;
                case LoaiBenhAnEMR.NgoaiTru_HoTroSinhSan:
                    BenhAnNgoaiTru_HoTroSinhSan _BenhAnNgoaiTru_HoTroSinhSan = new BenhAnNgoaiTru_HoTroSinhSan();
                    _BenhAnNgoaiTru_HoTroSinhSan.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnNgoaiTru_HoTroSinhSan.TienSuSanKhoaVo = new ObservableCollection<TienSuSanKhoaVo>();
                    _BenhAnNgoaiTru_HoTroSinhSan.PhieuTheoDoiNangNoan = new ObservableCollection<PhieuTheoDoiNangNoan>();
                    _BenhAnNgoaiTru_HoTroSinhSan.PhieuTheoDoiNoiMac = new ObservableCollection<PhieuTheoDoiNoiMac>();
                    if (_BenhAnNgoaiTru_HoTroSinhSan.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTru_HoTroSinhSan.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAnNgoaiTru_HoTroSinhSan.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTru_HoTroSinhSan.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAnNgoaiTru_HoTroSinhSan;
                case LoaiBenhAnEMR.NgoaiTru_BenhAnViemBiCo:
                    BenhAnNgoaiTru_ViemBiCo _BenhAnNgoaiTru_ViemBiCo = new BenhAnNgoaiTru_ViemBiCo();
                    _BenhAnNgoaiTru_ViemBiCo.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnNgoaiTru_ViemBiCo.CoGapCanhTay = new TrieuChungCo();
                    _BenhAnNgoaiTru_ViemBiCo.CoDuoiCanhTay = new TrieuChungCo();
                    _BenhAnNgoaiTru_ViemBiCo.CoGapDui = new TrieuChungCo();
                    _BenhAnNgoaiTru_ViemBiCo.CoDuoiDui = new TrieuChungCo();

                    _BenhAnNgoaiTru_ViemBiCo.TK_CoGapCanhTay = new TrieuChungCo();
                    _BenhAnNgoaiTru_ViemBiCo.TK_CoDuoiCanhTay = new TrieuChungCo();
                    _BenhAnNgoaiTru_ViemBiCo.TK_CoGapDui = new TrieuChungCo();
                    _BenhAnNgoaiTru_ViemBiCo.TK_CoDuoiDui = new TrieuChungCo();

                    _BenhAnNgoaiTru_ViemBiCo.TS_Corticosteroid = new TienSuDieuTri();
                    _BenhAnNgoaiTru_ViemBiCo.TS_CyclophosphamidLieuCao = new TienSuDieuTri();
                    _BenhAnNgoaiTru_ViemBiCo.TS_Azathioprine = new TienSuDieuTri();
                    _BenhAnNgoaiTru_ViemBiCo.TS_Methotrexate = new TienSuDieuTri();
                    _BenhAnNgoaiTru_ViemBiCo.TS_CyclosporineA = new TienSuDieuTri();

                    return _BenhAnNgoaiTru_ViemBiCo;
                case LoaiBenhAnEMR.NgoaiTru_BenhAnLupusBanDoHeThong:
                    BenhAnNgoaiTru_LupusBanDoHeThong _BenhAnNgoaiTru_LupusBanDoHeThong = new BenhAnNgoaiTru_LupusBanDoHeThong();
                    _BenhAnNgoaiTru_LupusBanDoHeThong.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    _BenhAnNgoaiTru_LupusBanDoHeThong.Corticosteroid = new ThuocToanThan();
                    _BenhAnNgoaiTru_LupusBanDoHeThong.KhangSotRet = new ThuocToanThan();
                    _BenhAnNgoaiTru_LupusBanDoHeThong.Cyclophosphamide = new ThuocToanThan();
                    _BenhAnNgoaiTru_LupusBanDoHeThong.CyclophosphamideLieuCao = new ThuocToanThan();
                    _BenhAnNgoaiTru_LupusBanDoHeThong.Azathioprine = new ThuocToanThan();
                    _BenhAnNgoaiTru_LupusBanDoHeThong.Methotrexate = new ThuocToanThan();
                    _BenhAnNgoaiTru_LupusBanDoHeThong.CyclosporineA = new ThuocToanThan();
                    _BenhAnNgoaiTru_LupusBanDoHeThong.ThuocKhac = new ThuocToanThan();

                    return _BenhAnNgoaiTru_LupusBanDoHeThong;
                case LoaiBenhAnEMR.NgoaiTru_VayPhanDoNangLong:
                    BenhAnNgoaiTru_VayPhanDoNangLong _BenhAnNgoaiTru_VayPhanDoNangLong = new BenhAnNgoaiTru_VayPhanDoNangLong();
                    _BenhAnNgoaiTru_VayPhanDoNangLong.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    if (_BenhAnNgoaiTru_VayPhanDoNangLong.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTru_VayPhanDoNangLong.NgayTongKet = DateTime.Now;
                    }
                    return _BenhAnNgoaiTru_VayPhanDoNangLong;
                case LoaiBenhAnEMR.NgoaiTru_LuPusBanDoManTinh:
                    BenhAnNgoaiTru_LuPusBanDoManTinh _LuPusBanDoManTinh = new BenhAnNgoaiTru_LuPusBanDoManTinh();
                    _LuPusBanDoManTinh.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    if (_LuPusBanDoManTinh.NgayTongKet == DateTime.MinValue)
                    {
                        _LuPusBanDoManTinh.NgayTongKet = DateTime.Now;
                    }
                    if (_LuPusBanDoManTinh.SinhThiet_NgayLam == DateTime.MinValue)
                    {
                        _LuPusBanDoManTinh.SinhThiet_NgayLam = DateTime.Now;
                    }
                    if (_LuPusBanDoManTinh.KQKhamMat_Ngay == DateTime.MinValue)
                    {
                        _LuPusBanDoManTinh.KQKhamMat_Ngay = DateTime.Now;
                    }
                    if (_LuPusBanDoManTinh.HB_HenKhamLai == DateTime.MinValue)
                    {
                        _LuPusBanDoManTinh.HB_HenKhamLai = DateTime.Now;
                    }
                    if (_LuPusBanDoManTinh.TK_HenKhamLai == DateTime.MinValue)
                    {
                        _LuPusBanDoManTinh.TK_HenKhamLai = DateTime.Now;
                    }
                    if (_LuPusBanDoManTinh.TK_NgayLuuTru == DateTime.MinValue)
                    {
                        _LuPusBanDoManTinh.TK_NgayLuuTru = DateTime.Now;
                    }
                    if (_LuPusBanDoManTinh.TKKhamMat_Ngay == DateTime.MinValue)
                    {
                        _LuPusBanDoManTinh.TKKhamMat_Ngay = DateTime.Now;
                    }
                    return _LuPusBanDoManTinh;
                case LoaiBenhAnEMR.NgoaiTru_VayNenTheMu:
                    BenhAnNgoaiTru_BenhVayNenTheMu _BenhAnNgoaiTru_BenhVayNenTheMu = new BenhAnNgoaiTru_BenhVayNenTheMu();
                    _BenhAnNgoaiTru_BenhVayNenTheMu.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    if (_BenhAnNgoaiTru_BenhVayNenTheMu.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTru_BenhVayNenTheMu.NgayTongKet = DateTime.Now;
                    }
                    return _BenhAnNgoaiTru_BenhVayNenTheMu;
                case LoaiBenhAnEMR.NgoaiTru_DuhringBrocq:
                    BenhAnNgoaiTruDuhringBrocq _BenhAnNgoaiTruDuhringBrocq = new BenhAnNgoaiTruDuhringBrocq();
                    _BenhAnNgoaiTruDuhringBrocq.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    if (_BenhAnNgoaiTruDuhringBrocq.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTruDuhringBrocq.NgayTongKet = DateTime.Now;
                    }
                    return _BenhAnNgoaiTruDuhringBrocq;
                case LoaiBenhAnEMR.DaiThaoDuong:
                    BenhAnDaiThaoDuong _BenhAnDaiThaoDuong = new BenhAnDaiThaoDuong();
                    _BenhAnDaiThaoDuong.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    if (_BenhAnDaiThaoDuong.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnDaiThaoDuong.NgayTongKet = DateTime.Now;
                    }
                    return _BenhAnDaiThaoDuong;
                case LoaiBenhAnEMR.NgoaiTru_UngThuDaHacTo:
                    BenhAnUngThuHacTo _BenhAnUngThuHacTo = new BenhAnUngThuHacTo();
                    _BenhAnUngThuHacTo.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    if (_BenhAnUngThuHacTo.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnUngThuHacTo.NgayTongKet = DateTime.Now;
                    }
                    return _BenhAnUngThuHacTo;
                case LoaiBenhAnEMR.NgoaiTru_UngThuDaKhongHacTo:
                    BenhAnUngThuKhongHacTo _BenhAnUngThuKhongHacTo = new BenhAnUngThuKhongHacTo();
                    _BenhAnUngThuKhongHacTo.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    if (_BenhAnUngThuKhongHacTo.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnUngThuKhongHacTo.NgayTongKet = DateTime.Now;
                    }
                    return _BenhAnUngThuKhongHacTo;
                case LoaiBenhAnEMR.NgoaiTru_Pemphigus:
                    BenhAnNgoaiTruPemphigus _BenhAnNgoaiTruPemphigus = new BenhAnNgoaiTruPemphigus();
                    _BenhAnNgoaiTruPemphigus.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    if (_BenhAnNgoaiTruPemphigus.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTruPemphigus.NgayTongKet = DateTime.Now;
                    }
                    return _BenhAnNgoaiTruPemphigus;
                case LoaiBenhAnEMR.NgoaiTru_VayNenTheKhop:
                    BenhAnVayNenTheKhop _BenhAnVayNenTheKhop = new BenhAnVayNenTheKhop();
                    _BenhAnVayNenTheKhop.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    if (_BenhAnVayNenTheKhop.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnVayNenTheKhop.NgayTongKet = DateTime.Now;
                    }
                    return _BenhAnVayNenTheKhop;
                case LoaiBenhAnEMR.NgoaiTru_HoiChungTrungLap:
                    BenhAnNgoaiTru_HoiChungTrungLap _BenhAnNgoaiTru_HoiChungTrungLap = new BenhAnNgoaiTru_HoiChungTrungLap();
                    _BenhAnNgoaiTru_HoiChungTrungLap.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    if (_BenhAnNgoaiTru_HoiChungTrungLap.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAnNgoaiTru_HoiChungTrungLap.NgayTongKet = DateTime.Now;
                    }
                    return _BenhAnNgoaiTru_HoiChungTrungLap;
                case LoaiBenhAnEMR.StentDongMachVanh:
                    BenhAnStentDongMachVanh _BenhAnStentDongMachVanh = new BenhAnStentDongMachVanh();
                    _BenhAnStentDongMachVanh.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    
                    return _BenhAnStentDongMachVanh;
                case LoaiBenhAnEMR.ThieuMauCoTimCucBo:
                    BenhAnThieuMauCoTimCucBo _BenhAnThieuMauCoTimCucBo = new BenhAnThieuMauCoTimCucBo();
                    _BenhAnThieuMauCoTimCucBo.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    return _BenhAnThieuMauCoTimCucBo;
                case LoaiBenhAnEMR.NgoaiTru_BenhBasedow:
                    BenhAnBenhBaseDow _BenhAnBenhBaseDow = new BenhAnBenhBaseDow();
                    _BenhAnBenhBaseDow.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    return _BenhAnBenhBaseDow;
                case LoaiBenhAnEMR.ViemGanBManTinh:
                    BenhAnViemGanBManTinh _BenhAnViemGanBManTinh = new BenhAnViemGanBManTinh();
                    _BenhAnViemGanBManTinh.MaQuanLy = thongTinDieuTri.MaQuanLy;

                    return _BenhAnViemGanBManTinh;
                case LoaiBenhAnEMR.PhoiTacNghenManTinh:
                    BenhAnPhoiTacNghenManTinh _BenhAnPhoiTacNghenManTinh = new BenhAnPhoiTacNghenManTinh();
                    _BenhAnPhoiTacNghenManTinh.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    _BenhAnPhoiTacNghenManTinh.DoPheDungs = new ObservableCollection<DoPheDung>();
                    _BenhAnPhoiTacNghenManTinh.DoChucNangHoHaps = new ObservableCollection<DoChucNangHoHap>();
                    return _BenhAnPhoiTacNghenManTinh;
                case LoaiBenhAnEMR.BenhTangHuyetAp:
                    BenhAnTangHuyetAp _BenhAnTangHuyetAp = new BenhAnTangHuyetAp();
                    _BenhAnTangHuyetAp.MaQuanLy = thongTinDieuTri.MaQuanLy;
                    return _BenhAnTangHuyetAp;
                default:
                    return null;
            }
        }
        public static void Show(LoaiBenhAnEMR LoaiBenhAnEMR,            int DefaultPage,            HanhChinhBenhNhan HanhChinhBenhNhan,            ThongTinDieuTri ThongTinDieuTri,            List<ChanDoan> ChanDoan,            List<PhuongPhapPTTT> PhuongPhapPTTT,
            string Json,            string UserCode,            decimal PatientId,            bool DongBenhAnFinal)
        {

            //dunglm tao ThongTinHoSoBenhAn
            _thongTinHoSoBenhAn = new ThongTinHoSoBenhAn();
            _thongTinHoSoBenhAn.HanhChinhBenhNhan = HanhChinhBenhNhan;
            _thongTinHoSoBenhAn.LoaiBenhAnEMR = LoaiBenhAnEMR;
            _thongTinHoSoBenhAn.ThongTinDieuTri = ThongTinDieuTri;
            _thongTinHoSoBenhAn.BenhAn = XemBenhAn.BenhAn;
            _thongTinHoSoBenhAn.FTPImage = "";
            _thongTinHoSoBenhAn.TokenKy = XemBenhAn.TokenKy;
            
            log.LogConfig();
            bckSyncEMR = new BackgroundWorker();
            bckSyncEMR.WorkerReportsProgress = true;
            bckSyncEMR.WorkerSupportsCancellation = true;
            bckSyncEMR.DoWork += BckSyncEMR_DoWork;
            string key = Guid.NewGuid().ToString();
            var timer = new Stopwatch();
            var timerlocal = new Stopwatch();
            timer.Start();
            log.Info("Begin Show EMR: '" + key + "'");
            try
            {
                timerlocal.Start();
                GoogleSpeech.GoogleSpeechInitializeComponent();
                ThongTinDieuTri.IDLoaiBenhAn = (int)LoaiBenhAnEMR;
                DefaultPageIndex = DefaultPage - 1;
#if CLOUD
                try
                {
                    ERMDatabase.URLEMRCloud = ERMDatabase.ReadConfig("URLEMRCloud");
                }
                catch { }
                JsonConvert.DefaultSettings = () => new JsonSerializerSettings
                {
                    FloatParseHandling = FloatParseHandling.Decimal,
                };
                log.Info("Begin open connection EMR: '" + key + "'");
                if (MyConnection == null || MyConnection.State != ConnectionState.Open)
                {
                    if (MyConnection != null)
                    {
                        try
                        {
                            MyConnection.Close();
                            MyConnection.Dispose();
                            MyConnection = null;
                        }
                        catch { }
                    }
                    GC.Collect();
                    MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString);
                    MyConnection.Open();
                }
                log.Info("End open connection EMR: '" + key + "'. Total: " + timerlocal.ElapsedMilliseconds.ToString() + " ms");
#else
                log.Info("Begin open connection EMR: '" + key + "'");
                if (MyConnection == null || MyConnection.State != ConnectionState.Open)
                {
                    if (MyConnection != null)
                    {
                        try
                        {
                            MyConnection.Close();
                            MyConnection.Dispose();
                            MyConnection = null;
                        }
                        catch { }
                    }
                    GC.Collect();
                    MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString);
                    MyConnection.Open();
                }
                log.Info("End open connection EMR: '" + key + "'. Total: " + timerlocal.ElapsedMilliseconds.ToString() + " ms");
#endif
                //https://redmine.vietsens.vn/redmine/issues/47805
                CauHinhVoBenhAnEMR cauHinhVoBenhAnEMR = CauHinhVoBenhAnEMRFunc.GetData(MyConnection);
                if (cauHinhVoBenhAnEMR != null && cauHinhVoBenhAnEMR.ChoPhepMoNhieuBenhAn == 0)
                {
                    try
                    {
                        Process[] localAll = Process.GetProcesses();
                        int countH1 = 0;
                        int countH3 = 0;

                        foreach (Process p in localAll)
                        {

                            //log.Info("\n process:" + p.ToString());
                            if (p.ProcessName.ToLower() == "emr")
                            {
                                countH1++;
                                if (countH1 > 1)
                                {
                                    log.Info("ChoPhepMoNhieuBenhAn = 0 >> Chi duoc mo vo benh an 1 lan tai 1 thoi diem");
                                    return;
                                }
                            }
                            else if (p.ProcessName.ToLower() == "connecttoemr")
                            {
                                countH3++;
                                if (countH3 > 1)
                                {
                                    log.Info("ChoPhepMoNhieuBenhAn = 0 >> Chi duoc mo vo benh an 1 lan tai 1 thoi diem");
                                    return;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.LogError("ChoPhepMoNhieuBenhAn" + ex);
                    }

                }

                if (string.IsNullOrEmpty(MDB.MDBConnection.UserName))
                {
                    MDB.MDBConnection.UserName = UserCode;
                }
                _LoaiBenhAnEMR = LoaiBenhAnEMR;
                // check his pro, mã bệnh án đã tồn tại hay chưa
                try
                {
                    if (LoaiBenhAnEMR == 0 && cauHinhVoBenhAnEMR.MoTrucTiepPhieu == 0)
                    {
                        int checkLoaiBenhAn = 0;
                        // check trên db của emr xem đã tồn tại bệnh án chưa
                        string sql = @"SELECT IDLoaiBenhAn FROM ThongTinDieuTri WHERE MaQuanLy = :MaQuanLy";
                        MDB.MDBCommand OracleCommand = new MDB.MDBCommand(sql, MyConnection);
                        OracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ThongTinDieuTri.MaQuanLy));
                        timer.Restart();
                        log.Info("Start get IDLoaiBenhAn EMR: '" + key + "'");
                        MDB.MDBDataReader OracleDataReader = OracleCommand.ExecuteReader();
                        while (OracleDataReader.Read())
                        {
                            checkLoaiBenhAn = OracleDataReader.GetInt("IDLoaiBenhAn");
                            break;
                        }
                        log.Info("End get IDLoaiBenhAn EMR: '" + key + "'. Total: " + timer.ElapsedMilliseconds + " ms");
                        if (checkLoaiBenhAn == 0)
                        {
                            // mở window chọn bệnh án
                            DanhSachVoBenhAn danhSachVoBenhAn_Window = new DanhSachVoBenhAn();
                            danhSachVoBenhAn_Window.ShowDialog();

                            _LoaiBenhAnEMR = danhSachVoBenhAn_Window.SelectedBenhAnEMR;
                            // Mở vỏ bệnh án
                            MoPhieu = false;
                        }
                        else
                            _LoaiBenhAnEMR = (LoaiBenhAnEMR)checkLoaiBenhAn;
                        if (BenhAn == null)
                        {
                            BenhAn = InitVoBenhAn(_LoaiBenhAnEMR, HanhChinhBenhNhan, ThongTinDieuTri);
                            Json = JsonConvert.SerializeObject(BenhAn);
                            ThongTinDieuTri.IDLoaiBenhAn = (int)_LoaiBenhAnEMR;
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.Error("Lỗi check benh an :", ex.Message);
                }

                MDB.MDBConnection.HostTracking = HostTracking;
                try
                {
                    MDB.MDBConnection.HanhChinhBenhNhan = new LibraryTracking.HanhChinhBenhNhan()
                    {
                        BenhVien = HanhChinhBenhNhan.BenhVien,
                        CapBac = HanhChinhBenhNhan.CapBac,
                        DanToc = HanhChinhBenhNhan.DanToc,
                        DeLanMay = HanhChinhBenhNhan.DeLanMay,
                        DienThoaiLienLac = HanhChinhBenhNhan.DienThoaiLienLac,
                        DoiTuong = HanhChinhBenhNhan.DoiTuong.ToString(),
                        DonVi = HanhChinhBenhNhan.DonVi,
                        GioiTinh = HanhChinhBenhNhan.GioiTinh.ToString(),
                        HoTenDiaChiNguoiNha = HanhChinhBenhNhan.HoTenDiaChiNguoiNha,
                        HoVaTenBo = HanhChinhBenhNhan.HoVaTenBo,
                        HoVaTenMe = HanhChinhBenhNhan.HoVaTenMe,
                        HuyenQuan = HanhChinhBenhNhan.HuyenQuan,
                        MaBenhNhan = HanhChinhBenhNhan.MaBenhNhan,
                        MaDanhToc = HanhChinhBenhNhan.MaDanhToc,
                        MaHuyenQuan = HanhChinhBenhNhan.MaHuyenQuan,
                        MaNgheNghiep = HanhChinhBenhNhan.MaNgheNghiep,
                        MaNgheNghiepBo = HanhChinhBenhNhan.MaNgheNghiepBo,
                        MaNgheNghiepMe = HanhChinhBenhNhan.MaNgheNghiepMe,
                        MaNgoaiKieu = HanhChinhBenhNhan.MaNgoaiKieu,
                        MaNoiDangKyBHYT = HanhChinhBenhNhan.MaNoiDangKyBHYT,
                        MaTinhThanhPho = HanhChinhBenhNhan.MaTinhThanhPho,
                        MaXaPhuong = HanhChinhBenhNhan.MaXaPhuong,
                        MaYTe = HanhChinhBenhNhan.MaYTe,
                        NgayDangKyBHYT = HanhChinhBenhNhan.NgayDangKyBHYT,
                        NgayDuocHuong5Nam = HanhChinhBenhNhan.NgayDuocHuong5Nam,
                        NgayHetHanBHYT = HanhChinhBenhNhan.NgayHetHanBHYT,
                        NgaySinh = HanhChinhBenhNhan.NgaySinh,
                        NgaySinhBo = HanhChinhBenhNhan.NgaySinhBo,
                        NgaySinhMe = HanhChinhBenhNhan.NgaySinhMe,
                        NgheNghiep = HanhChinhBenhNhan.NgheNghiep,
                        NgheNghiepBo = HanhChinhBenhNhan.NgheNghiepBo,
                        NgheNghiepMe = HanhChinhBenhNhan.NgheNghiepMe,
                        NgoaiKieu = HanhChinhBenhNhan.NgoaiKieu,
                        NhomMauMe = HanhChinhBenhNhan.NhomMauMe,
                        NoiLamViec = HanhChinhBenhNhan.NoiLamViec,
                        SoDienThoaiNguoiNha = HanhChinhBenhNhan.SoDienThoaiNguoiNha,
                        SoNha = HanhChinhBenhNhan.SoNha,
                        SoTheBHYT = HanhChinhBenhNhan.SoTheBHYT,
                        SoYTe = HanhChinhBenhNhan.SoYTe,
                        TenBenhNhan = HanhChinhBenhNhan.TenBenhNhan,
                        TenNoiDangKyBHYT = HanhChinhBenhNhan.TenNoiDangKyBHYT,
                        ThonPho = HanhChinhBenhNhan.ThonPho,
                        TienThaiPara = HanhChinhBenhNhan.TienThaiPara,
                        TienThaiParaID = HanhChinhBenhNhan.TienThaiParaID,
                        TinhThanhPho = HanhChinhBenhNhan.TinhThanhPho,
                        TrinhDoVanHoa = HanhChinhBenhNhan.TrinhDoVanHoa,
                        TrinhDoVanHoaBo = HanhChinhBenhNhan.TrinhDoVanHoaBo,
                        TrinhDoVanHoaMe = HanhChinhBenhNhan.TrinhDoVanHoaMe,
                        Tuoi = HanhChinhBenhNhan.Tuoi,
                        XaPhuong = HanhChinhBenhNhan.XaPhuong
                    };
                }
                catch { }

                try
                {
                    timerlocal.Restart();
                    log.Info("Begin GetListNhanVienByKhoa: '" + key + "'");
                    string sData = "";
                    userCode = UserCode;
                    if (string.IsNullOrEmpty(UserCodeLogin))
                        UserCodeLogin = UserCode;
                    patientId = PatientId;
                    dongBenhAnFinal = DongBenhAnFinal;

#if CLOUD
                    string ketquaToken = "";
                    ketquaToken = apiToken.funcCreateToken(XemBenhAn.APICloudGetToken);
                    if (ketquaToken.IsNotNullOrEmpty()) {
                        log.Info("Get token from API CLOUD --- Token: "+ ketquaToken+" --- Time: " + timerlocal.ElapsedMilliseconds.ToString() + " ms");
                    }
                    XemBenhAn.tokenCloud = ketquaToken;
#else

#endif

                    if (ThongTinDieuTri.MaKhoa != null) sData = ThongTinDieuTri.MaKhoa;
#if CLOUD
                    string ketquaAPI1 = crtNV.FncGetData("GETLISTNVBYKHOA", sData,"");
                    NhanVienFunc.ListNhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(ketquaAPI1);
#else
                    NhanVienFunc.GetListNhanVienByKhoa(MyConnection, ThongTinDieuTri.MaKhoa);
                    NhanVienFunc.GetListGiamDoc(MyConnection);
                    NhanVienFunc.GetListNguoiNhanHoSo(MyConnection, ThongTinDieuTri.MaKhoa);
#endif

                    Dispatcher.CurrentDispatcher.BeginInvoke(new Action(() =>
                    log.Info("End GetListNhanVienByKhoa: '" + key + "'. Total: " + timerlocal.ElapsedMilliseconds.ToString() + " ms")));
                }
                catch (Exception ex)
                {
                    Dispatcher.CurrentDispatcher.BeginInvoke(new Action(() => log.Error(ex)));
                    //XuLyLoi.Handle(ex);
                }

                _HanhChinhBenhNhan = HanhChinhBenhNhan;
                if ((_HanhChinhBenhNhan.DanToc != null && "KINH".Equals(_HanhChinhBenhNhan.DanToc.ToUpper().Trim())) || "01".Equals(_HanhChinhBenhNhan.MaDanhToc) || "1".Equals(_HanhChinhBenhNhan.MaDanhToc))
                {
                    _HanhChinhBenhNhan.MaDanhToc = "25";//issues/37416
                }
                if (ThongTinDieuTri.lstChuyenKhoaHis == null) { ThongTinDieuTri.lstChuyenKhoaHis = new List<LichSuChuyenKhoa>(); }
                _ThongTinDieuTri = ThongTinDieuTri;

                //http://redmine.vietsens.vn:8080/redmine/issues/43544
                if (!string.IsNullOrEmpty(_ThongTinDieuTri.MaICD_BenhKemTheo_RaVien))
                {
                    if (_ThongTinDieuTri.MaICD_BenhKemTheo_RaVien.StartsWith(";"))
                    {
                        _ThongTinDieuTri.MaICD_BenhKemTheo_RaVien = _ThongTinDieuTri.MaICD_BenhKemTheo_RaVien.Replace(";", "");
                    }
                }
                // update lại DHST https://redmine.vietsens.vn/redmine/issues/54306
                try
                {
                    if (cauHinhVoBenhAnEMR != null
                        && cauHinhVoBenhAnEMR.ChonDHSTTuPhieuDieuTri == 1)
                    {
                        if(IsHisPro && (_ListDauHieuSinhTons == null || _ListDauHieuSinhTons.Count == 0))
                        {
                            DataDhSTInfo dataDhSTInfo = Report.GetDHSTInfo();
                            if (dataDhSTInfo != null)
                                _ListDauHieuSinhTons = dataDhSTInfo.Data;
                        }
                        if (_ListDauHieuSinhTons != null && _ListDauHieuSinhTons.Count > 0)
                        {
                            List<DauSinhTon> _ListDHSTs = _ListDauHieuSinhTons.FindAll(x => x.IsTracking == true);
                            if (_ListDHSTs != null && _ListDHSTs.Count > 0)
                            {
                                _ListDHSTs = _ListDHSTs.OrderBy(x => x.ExecuteTime).ThenBy(x => x.DhstId).ToList();
                                if (_ListDHSTs != null && _ListDHSTs.Count > 0)
                                {
                                    _ThongTinDieuTri.DauSinhTon.Mach = _ListDHSTs[0].Mach;
                                    _ThongTinDieuTri.DauSinhTon.NhietDo = _ListDHSTs[0].NhietDo;
                                    _ThongTinDieuTri.DauSinhTon.HuyetAp = _ListDHSTs[0].HuyetAp;
                                    _ThongTinDieuTri.DauSinhTon.NhipTho = _ListDHSTs[0].NhipTho;
                                    _ThongTinDieuTri.DauSinhTon.CanNang = _ListDHSTs[0].CanNang;
                                    _ThongTinDieuTri.DauSinhTon.ChieuCao = _ListDHSTs[0].ChieuCao;
                                    _ThongTinDieuTri.DauSinhTon.BMI = _ListDHSTs[0].BMI;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.Info("Loi get dhst moi: " + ex.Message);
                }

                _ListChanDoan = ChanDoan;
                _ListPhuongPhapPTTT = PhuongPhapPTTT;
                JsonInput = Json;

                InitPic();

                List<PhauThuatThuThuat> lst_pttt = new List<PhauThuatThuThuat>();
                timerlocal.Restart();
                log.Info("Begin PhauThuatThuThuatFunc.GetData: '" + key + "'");
                string ketquaAPI = "";
#if CLOUD
                ketquaAPI = crtPTTT.FncGetData("GETDATA", ThongTinDieuTri.MaQuanLy.ToString(), "");
                if (ketquaAPI.IsNotNullOrEmpty())
                {
                    lst_pttt = JsonConvert.DeserializeObject<List<PhauThuatThuThuat>>(ketquaAPI).OrderByDescending(s => s.IDPhauThuatThuThuat).ToList();
                }
#else
                lst_pttt = PhauThuatThuThuatFunc.GetData(ThongTinDieuTri.MaQuanLy.ToString(), MyConnection).OrderByDescending(s => s.IDPhauThuatThuThuat).ToList();
#endif
                log.Info("End PhauThuatThuThuatFunc.GetData: '" + key + "'. Total: " + timerlocal.ElapsedMilliseconds.ToString() + " ms");

                /*
                // Chuyển chức năng này về
                #if CLOUD
                                ketquaAPI = crtBA.FncGetData("LOADEMRPHIEU", "", "");
                                DSLoaiPhieu = JsonConvert.DeserializeObject<List<emr_loaiphieu>>(ketquaAPI);

                #else
                                emr_loaiphieu lp = new emr_loaiphieu();
                                DSLoaiPhieu = lp.Load(XemBenhAn.MyConnection);
                #endif
                */
                bool getDuLieuHis = cauHinhVoBenhAnEMR != null && cauHinhVoBenhAnEMR.CapNhatDuLieuTuHis == 1 ? true : false;
                ExceptionExtend.Log("XemBenhAn", "Sync PTTT, getDuLieuHis: " + getDuLieuHis);
                if (!getDuLieuHis && _ListPTTT_HIS != null && _ListPTTT_HIS.Count() > 0)
                {
                    try
                    {
                        timerlocal.Restart();
                        ExceptionExtend.Log("XemBenhAn", "Begin đồng bộ PTTT: '" + key + "'");
                        foreach (PhauThuatThuThuat_HIS pt in _ListPTTT_HIS)
                        {
                            PhauThuatThuThuat obj = new PhauThuatThuThuat();
                            obj.IDPhauThuatThuThuat = pt.IDPhauThuatThuThuat;
                            obj.NgayPhauThuatThuThuat = pt.NgayPhauThuatThuThuat;
                            obj.NgayPhauThuatThuThuat_Gio = pt.NgayPhauThuatThuThuat_Gio;
                            obj.PhuongPhapPhauThuatThuThuat = pt.PhuongPhapPhauThuatThuThuat ?? "";
                            obj.PhuongPhapVoCam = pt.PhuongPhapVoCam ?? "";
                            obj.BacSyPhauThuat = pt.BacSyPhauThuat;
                            obj.BacSyGayMe = pt.BacSyGayMe;
                            obj.BacSyGayMeHoVaTen = pt.BacSyGayMeHoVaTen;
                            obj.BacSyPhauThuatHoVaTen = pt.BacSyPhauThuatHoVaTen;
                            obj.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy;
                            obj.Loai_VBA = pt.Loai;
                            if (lst_pttt.Count() > 0)
                            {
                                var Qry = from pt_data in lst_pttt
                                          where (pt_data.PhuongPhapPhauThuatThuThuat == obj.PhuongPhapPhauThuatThuThuat 
                                                        && (pt_data.PhuongPhapVoCam == obj.PhuongPhapVoCam) 
                                                        && pt_data.NgayPhauThuatThuThuat.ToString("dd/MM/yyyy") == obj.NgayPhauThuatThuThuat.ToString("dd/MM/yyyy")
                                                        && pt_data.BacSyPhauThuat == obj.BacSyPhauThuat
                                                        && pt_data.NgayPhauThuatThuThuat_Gio == obj.NgayPhauThuatThuThuat_Gio)
                                          select pt_data;
                                if (Qry != null && Qry.Count() > 0)
                                {
                                    if (obj.IDPhauThuatThuThuat == 0)
                                        obj.IDPhauThuatThuThuat = Qry.First().IDPhauThuatThuThuat;
#if CLOUD
                                    crtPTTT.fncSaveDel("UPDATE", JsonConvert.SerializeObject(obj));
#else
                                    PhauThuatThuThuatFunc.Update(XemBenhAn.MyConnection, obj);
#endif
                                }
                                else
                                {
#if CLOUD
                                    crtPTTT.fncSaveDel("INSERT", JsonConvert.SerializeObject(obj));
#else
                                    PhauThuatThuThuatFunc.Insert(XemBenhAn.MyConnection, ref obj);
#endif
                                }
                            }
                            else
                            {
#if CLOUD
                                crtPTTT.fncSaveDel("INSERT", JsonConvert.SerializeObject(obj));
#else
                                PhauThuatThuThuatFunc.Insert(XemBenhAn.MyConnection, ref obj);
#endif
                            }
                        }
                        ExceptionExtend.Log("XemBenhAn", "End đồng bộ PTTT: '" + key + "'. Total: " + timerlocal.ElapsedMilliseconds.ToString() + " ms");
                    }
                    catch (Exception ex)
                    {
                        log.Error("Lỗi pttt:", ex.Message);
                    }
                }
                timerlocal.Restart();
                if (ERMDatabase.KyDienTu_DiaChiACS != "" && ERMDatabase.KyDienTu_DiaChiEMR != "" && ERMDatabase.KyDienTu_TREATMENT_CODE == "")
                {
                    bckSyncEMR.RunWorkerAsync();
                }

                if (HostTracking != null)
                {
                    LibraryTracking.TrackingM tracking = new LibraryTracking.TrackingM()
                    {
                        Computer = System.Environment.MachineName,
                        DuLieu = "",
                        NgayGio = DateTime.Now.ToUniversalTime(),
                        NoiDung = "Mở bệnh án",
                        UserName = UserCode,
                        TableName = "",
                        HanhChinh = MDB.MDBConnection.HanhChinhBenhNhan,
                    };
                    try
                    {
                        timerlocal.Restart();
                        log.Info("Start tracking: '" + key + "'");
                        string json = tracking.ToString();
                        string base64 = LibraryTracking.Database.Base64Encode(json);
                        string host = Newtonsoft.Json.JsonConvert.SerializeObject(HostTracking);
                        string host64 = LibraryTracking.Database.Base64Encode(host);
                        ProcessStartInfo proc = new ProcessStartInfo();
                        proc.UseShellExecute = false;
                        proc.WorkingDirectory = Environment.CurrentDirectory;
                        proc.FileName = "MedilinkTracking.exe";
                        proc.Arguments = base64 + " " + host64;
                        using (Process p = new Process())
                        {
                            p.StartInfo = proc;
                            try
                            {
                                p.Start();
                            }
                            catch //(Exception ex)
                            {
                            }
                            finally
                            {
                                p.Close();
                            }
                        }
                        MDB.MDBConnection.HostTracking = HostTracking;
                    }
                    catch { }
                    finally
                    {
                        timerlocal.Stop();
                        log.Info("End tracking: '" + key + "'. Total: " + timerlocal.ElapsedMilliseconds.ToString() + " ms");
                    }
                }
                // Tunght
                XemBenhAn._TTCauHinhPhieu = new List<ThongTinPhieu>();
                bool isUpdate = false;
                try
                {
#if CLOUD
                    ketquaAPI = crtTTP.FncGetData("SELECT", "","");
                    if (ketquaAPI.IsNotNullOrEmpty())
                    {
                        XemBenhAn._TTCauHinhPhieu = JsonConvert.DeserializeObject<List<ThongTinPhieu>>(ketquaAPI);
                    }
                    if (XemBenhAn._TTCauHinhPhieu != null && XemBenhAn._TTCauHinhPhieu.Count == 0)
                    {
                        
                        isUpdate = crtTTP.fncSaveDel("DELETEDS", ""); 
                        isUpdate = crtTTP.fncSaveDel("DROPSEQ", "");
                        isUpdate = crtTTP.fncSaveDel("RECREATESEQ", "");
                        List<ThongTinPhieu> tmpPhieu = ThongTinPhieuFunc.CreateThongTinPhieu();
                        string sData = "";
                        foreach (ThongTinPhieu item in tmpPhieu)
                        {
                            sData = JsonConvert.SerializeObject(item);
                            crtTTP.fncSaveDel("INSERTORUPDATE", sData);
                        }
                    }

#else
                    XemBenhAn._TTCauHinhPhieu = ThongTinPhieuFunc.Select(XemBenhAn.MyConnection);
                    if (XemBenhAn._TTCauHinhPhieu != null && XemBenhAn._TTCauHinhPhieu.Count == 0)
                    {

                        isUpdate = ThongTinPhieuFunc.DeleteDanhSach(XemBenhAn.MyConnection);
                        isUpdate = ThongTinPhieuFunc.DropSeq(XemBenhAn.MyConnection);
                        isUpdate = ThongTinPhieuFunc.ReCreateSeq(XemBenhAn.MyConnection);
                        List<ThongTinPhieu> tmpPhieu = ThongTinPhieuFunc.CreateThongTinPhieu();
                        foreach (ThongTinPhieu item in tmpPhieu)
                        {
                            ThongTinPhieuFunc.InsertOrUpdate(XemBenhAn.MyConnection, item, ref isUpdate);
                        }
                    }
#endif
                }
                catch
                {
                    XemBenhAn._TTCauHinhPhieu = new List<ThongTinPhieu>();
                }
                finally
                {

                }
                if (MoPhieu)
                {
                    try
                    {
                        if (!ThongTinDieuTriFunc.checkExistThongTinDieuTri(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy))
                        {
                            if (HanhChinhBenhNhanFunc.InsertOrUpdateHanhChinhBenhNhan(XemBenhAn.MyConnection, XemBenhAn._HanhChinhBenhNhan))
                            {
                                ThongTinDieuTriFunc.InsertOrUpdateThongTinDieuTri(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri);
                            }
                        }
                        DanhSachMauPhieu danhSachMauPhieu = new DanhSachMauPhieu(string.IsNullOrEmpty(userCode) ? UserCodeLogin : userCode);
                        if (!string.IsNullOrEmpty(MaPhieuMo))
                        {
                            danhSachMauPhieu.startMauPhieu(MaPhieuMo);
                        }
                    }
                    catch (Exception ex)
                    {
                        log.Error("Lỗi check benh an :", ex.Message);
                    }
                }
                else
                {
                    MauUserControl _MauUserControl = new MauUserControl();
                    log.Info("Khoi Tao control: '" + key + "'. Total: " + timer.ElapsedMilliseconds.ToString() + " ms");
                    MauBaoCao _MauBaoCao = new MauBaoCao();
                    log.Info("Khoi Tao bao cáo: '" + key + "'. Total: " + timer.ElapsedMilliseconds.ToString() + " ms");
                    MainWindow _window = new MainWindow(userCode);
                    timer.Stop();
                    log.Info("Start Show EMR: '" + key + "'. Total: " + timer.ElapsedMilliseconds.ToString() + " ms");
                    //16/06/2021 Add by Hòa issues 65347
                    if (KetXuatHoSo)
                    {
                        try
                        {
                            EMR_MAIN.UserControlERM.TabMenuUC menuUC = new EMR_MAIN.UserControlERM.TabMenuUC(string.IsNullOrEmpty(userCode) ? UserCodeLogin : userCode);
                            menuUC.btnKetXuat_Click(null, null);
                        }
                        catch (Exception ex)
                        {
                            XuLyLoi.Handle(ex);
                        }
                    }
                    //16/06/2021 End by Hòa issues 65347
                    else
                    {
                        _window.ShowDialog();
                    }
                }



            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                log.Info("Lỗi : " + ex.Message + ":" + ex.StackTrace);

            }
            finally
            {
                log.Info("End Show EMR: '" + key + "'.");
            }
        }
        public static string TokenKy = "";

        private static void BckSyncEMR_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ERMDatabase.KyDienTu_DiaChiACS != "" && ERMDatabase.KyDienTu_DiaChiEMR != "" && EMR_MAIN.ERMDatabase.KyDienTu_TREATMENT_CODE == "")
            {
                string key = Guid.NewGuid().ToString();
                var timer = new Stopwatch();
                var timerlocal = new Stopwatch();
                timer.Start();
                log.Info("Start đồng bộ ký: '" + key + "'");
                try
                {
                    log.Info("Start get Token :'" + key + "'");
                    //#if HIS2
                    //                    Inventec.Token.Core.TokenData tokenData = new ChuKySo().Login(ERMDatabase.KyDienTu_DiaChiACS, ERMDatabase.KyDienTu_UserNameHeThongKy, ERMDatabase.KyDienTu_MatKhauHeThongKy, ERMDatabase.KyDienTu_ApplicationCode);
                    //                    TokenKy = tokenData?.TokenCode;
                    //#else
                    if (TokenKy.IsNullOrEmpty())
                    {
                        CommonParam param = new CommonParam();
                        ClientTokenManager clientTokenManager = new ClientTokenManager(ERMDatabase.KyDienTu_ApplicationCode, ERMDatabase.KyDienTu_DiaChiACS);
                        clientTokenManager.UseRegistry(true);
                        var tokenData = clientTokenManager.Init(param);
                        if (tokenData != null)
                        {
                            TokenKy = tokenData != null ? tokenData.TokenCode : "";
                            log.Info("TokenCode : " + TokenKy + ", UserName : " + tokenData != null && tokenData.User != null ? tokenData.User.LoginName : "");
                        }
                    }
                    //else
                    //{
                    //    log.Info("Không lấy được TokenCode cũ, đăng nhập mới và lấy token mới");
                    //    var _TokenKy = new ChuKySo().Login(ERMDatabase.KyDienTu_DiaChiACS, ERMDatabase.KyDienTu_UserNameHeThongKy, ERMDatabase.KyDienTu_MatKhauHeThongKy, ERMDatabase.KyDienTu_ApplicationCode);

                    //}
                    //#endif
                    if (TokenKy.IsNullOrEmpty())
                    {
                        log.Error("Không lấy được token ký");
                    }
                    else
                    {
                        ChuKySo ky = new ChuKySo();
                        string hoBN = "", chuLot = "", tenBN = "";
                        PMS.Access.ThuVien.SplitHoTenBN(XemBenhAn._HanhChinhBenhNhan.TenBenhNhan, ref hoBN, ref chuLot, ref tenBN);
                        EMR_TREATMENT eMR_TREATMENT = ky.GetEMR_TREATMENT(ERMDatabase.KyDienTu_TREATMENT_CODE != "" ? ERMDatabase.KyDienTu_TREATMENT_CODE : XemBenhAn._ThongTinDieuTri.MaBenhAn.ToString(), XemBenhAn._HanhChinhBenhNhan.MaBenhNhan, hoBN, (chuLot.Trim() + " " + tenBN.Trim()).Trim(), XemBenhAn._HanhChinhBenhNhan.NgaySinh, (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh, XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description(), (int)XemBenhAn._HanhChinhBenhNhan.DoiTuong, XemBenhAn._HanhChinhBenhNhan.DoiTuong.Description(), XemBenhAn._ThongTinDieuTri.MaKhoa ?? "1", XemBenhAn._ThongTinDieuTri.Khoa, XemBenhAn._ThongTinDieuTri.NgayVaoVien, XemBenhAn._ThongTinDieuTri.NgayRaVien, XemBenhAn._HanhChinhBenhNhan.CardCode);
                        log.Info("Start UpdateHanhChinh EMR: '" + key + "'");
                        timerlocal.Reset();
                        ky.UpdateHanhChinh(ERMDatabase.KyDienTu_DiaChiEMR, ERMDatabase.KyDienTu_ApplicationCode, eMR_TREATMENT, TokenKy);
                        log.Info("End UpdateHanhChinh EMR: '" + key + "'. Total: " + timerlocal.ElapsedMilliseconds.ToString() + " ms");
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
                finally
                {
                    timerlocal.Stop();
                    log.Info("End  đồng bộ ký: '" + key + "'. Total: " + timerlocal.ElapsedMilliseconds.ToString() + " ms");
                }
            }
        }

        /// <summary>
        /// HIS2
        /// </summary>
        public static void Show(LoaiBenhAnEMR LoaiBenhAnEMR,
                                int DefaultPage,
                                HanhChinhBenhNhan HanhChinhBenhNhan,
                                ThongTinDieuTri ThongTinDieuTri,
                                string Json,
                                List<PhauThuatThuThuat_HIS> pttt = null,
                                List<ChanDoan> lChanDoan = null,
                                List<PhuongPhapPTTT> PhuongPhapPTTT = null,
                                string userCodeLogin = "",
                                DauSinhTon _dauSinhTonMoi = null,
                                string MaPhieu = null,
                                List<ThuocKhangSinh> khangSinhs = null,
                                bool DongBenhAn_s = false,
                                List<ChiSoXetNghiemADO> chiSoXetNghiemADO_s = null,
                                string tokenKy_s = null,
                                List<DauSinhTon> TatCaDauHieuSinhTons = null,
                                RoomInfo roomInfo = null,
                                int CanhBaoVBKy = 0)
        {
            

            _ListPTTT_HIS = pttt;
            _ListDauHieuSinhTons = TatCaDauHieuSinhTons;
            if (_dauSinhTonMoi != null)
            {
                _DauSinhTonMoi = new DauSinhTon();
                _DauSinhTonMoi.Mach = _dauSinhTonMoi.Mach;
                _DauSinhTonMoi.NhietDo = _dauSinhTonMoi.NhietDo;
                _DauSinhTonMoi.HuyetAp = _dauSinhTonMoi.HuyetAp;
                _DauSinhTonMoi.NhipTho = _dauSinhTonMoi.NhipTho;
                _DauSinhTonMoi.CanNang = _dauSinhTonMoi.CanNang;
                _DauSinhTonMoi.ChieuCao = _dauSinhTonMoi.ChieuCao;
                _DauSinhTonMoi.BMI = _dauSinhTonMoi.BMI;
            }
            if (!string.IsNullOrEmpty(ThongTinDieuTri.Giuong)
                && !string.IsNullOrEmpty(ThongTinDieuTri.TenGiuong)
                && !ListThongTinGiuong.Exists(x => x.bedcode == ThongTinDieuTri.Giuong && x.bedname == ThongTinDieuTri.TenGiuong))
            {
                ListThongTinGiuong.Add(new BedInfo { bedcode = ThongTinDieuTri.Giuong, bedname = ThongTinDieuTri.TenGiuong });
            }
            MoPhieu = false;
            MaPhieuMo = "";
            if (!string.IsNullOrEmpty(MaPhieu))
            {
                MoPhieu = true;
                MaPhieuMo = MaPhieu;
            }
            if (khangSinhs != null)
                DanhSachThuocKhangSinh = khangSinhs;
            if (chiSoXetNghiemADO_s != null)
                listChiSoXetNghiem = chiSoXetNghiemADO_s;
            if (!string.IsNullOrEmpty(tokenKy_s))
            {
                TokenKy = tokenKy_s;
                Report.TokenKy = tokenKy_s;
            }
            _roomInfo = roomInfo;
            _CanhBaoVanBanDaKy = CanhBaoVBKy;
#if HIS2
            IsHisPro = false;
            IsHis1 = false;
#else
            IsHisPro = true;
#endif
            //Update lại list PTTT và chỉ số xét nghiệm theo yêu cầu của issue [STT:2124][Code]_VBA_Sửa lại cách lấy dữ liệu của “Phẫu thuật thủ thuật” và “Chỉ số xét nghiệm”
            if(IsHisPro && !string.IsNullOrEmpty(ERMDatabase.KyDienTu_DiaChiMOS))
            {
                DataPTTTCSXN dataPTTTCSXN = Report.GetDataPTTTCSXNInfo(tokenKy_s, ThongTinDieuTri.MaBenhAn);
                if(dataPTTTCSXN != null && dataPTTTCSXN.Success && dataPTTTCSXN.Data != null)
                {
                    _ListPTTT_HIS = dataPTTTCSXN.Data.PhauThuatThuThuat;
                    listChiSoXetNghiem = dataPTTTCSXN.Data.ChiSoXetNghiem;
                }
            }    
            DongBenhAn = DongBenhAn_s;
            Show(LoaiBenhAnEMR, DefaultPage, HanhChinhBenhNhan, ThongTinDieuTri, lChanDoan, PhuongPhapPTTT, Json, userCodeLogin, 0, DongBenhAn_s);
        }

        public static void InsertOrUpdate(MDB.MDBConnection Connection)
        {
            bool daTongKetBenhAn = false, luuThanhCong = false;
            string idDotVaoVien = "";
            #region
            switch (XemBenhAn._LoaiBenhAnEMR)
            {
                case LoaiBenhAnEMR.Bong:
                    BenhAnBong baB = XemBenhAn.BenhAn as BenhAnBong;
                    if (baB != null)
                    {
                        if (baB.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baB.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baB.PhuongPhapDieuTri.IsNotNullOrEmpty() || baB.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty() || baB.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnBongFunc.InsertOrUpdate(Connection, baB);
                        idDotVaoVien = baB.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.DaLieu:
                    BenhAnDaLieu baDL = XemBenhAn.BenhAn as BenhAnDaLieu;
                    if (baDL != null)
                    {
                        if (baDL.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baDL.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baDL.PhuongPhapDieuTri.IsNotNullOrEmpty() || baDL.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty() || baDL.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnDaLieuFunc.InsertOrUpdate(Connection, baDL);
                        idDotVaoVien = baDL.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.HuyetHocTruyenMau:
                    BenhAnHuyetHocTruyenMau baHHTM = XemBenhAn.BenhAn as BenhAnHuyetHocTruyenMau;
                    if (baHHTM != null)
                    {
                        if (baHHTM.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baHHTM.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baHHTM.PhuongPhapDieuTri.IsNotNullOrEmpty() || baHHTM.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty() || baHHTM.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnHuyetHocTruyenMauFunc.InsertOrUpdate(Connection, baHHTM);
                        idDotVaoVien = baHHTM.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.MatBanPhanTruoc:
                    BenhAnMatBanPhanTruoc baMBPTrc = XemBenhAn.BenhAn as BenhAnMatBanPhanTruoc;
                    if (baMBPTrc != null)
                    {
                        if (baMBPTrc.ChanDoanBenhChinh_LamSang.IsNotNullOrEmpty() || baMBPTrc.ChanDoanBenhChinh_NguyenNhan.IsNotNullOrEmpty() || baMBPTrc.QuaTrinhDieuTri_NoiKhoa.IsNotNullOrEmpty() || baMBPTrc.QuaTrinhDieuTri_KetQua.IsNotNullOrEmpty() || baMBPTrc.QuaTrinhDieuTri_BienChung.IsNotNullOrEmpty() || baMBPTrc.HuongDieuTriTiep.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnMatBanPhanTruocFunc.InsertOrUpdate(Connection, baMBPTrc);
                        idDotVaoVien = baMBPTrc.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.MatChanThuong:
                    BenhAnMatChanThuong baMCT = XemBenhAn.BenhAn as BenhAnMatChanThuong;
                    if (baMCT != null)
                    {
                        if (baMCT.ChanDoanBenhChinh_LamSang.IsNotNullOrEmpty() || baMCT.ChanDoanBenhChinh_NguyenNhan.IsNotNullOrEmpty() || baMCT.QuaTrinhDieuTri_NoiKhoa.IsNotNullOrEmpty() || baMCT.HuongDieuTriTiep.IsNotNullOrEmpty() || baMCT.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnMatChanThuongFunc.InsertOrUpdate(Connection, baMCT);
                        idDotVaoVien = baMCT.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.MatDayMat:
                    BenhAnMatDayMat baMDM = XemBenhAn.BenhAn as BenhAnMatDayMat;
                    if (baMDM != null)
                    {
                        if (baMDM.ChanDoanBenhChinh_LamSang.IsNotNullOrEmpty() || baMDM.ChanDoanBenhChinh_NguyenNhan.IsNotNullOrEmpty() || baMDM.QuaTrinhDieuTri_NoiKhoa.IsNotNullOrEmpty() || baMDM.HuongDieuTriTiep.IsNotNullOrEmpty() || baMDM.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnMatDayMatFunc.InsertOrUpdate(Connection, baMDM);
                        idDotVaoVien = baMDM.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.MatGloCom:
                    BenhAnMatGlocom baMGC = XemBenhAn.BenhAn as BenhAnMatGlocom;
                    if (baMGC != null)
                    {
                        if (baMGC.HoSo == null)
                        {
                            if (XemBenhAn._ThongTinDieuTri.HoSo != null)
                            {
                                baMGC.HoSo = XemBenhAn._ThongTinDieuTri.HoSo;
                            }
                            else
                            {
                                baMGC.HoSo = new HoSo();
                                baMGC.HoSo.XQuang = 0;
                                baMGC.HoSo.XetNghiem = 0;
                                baMGC.HoSo.CTScanner = 0;
                                baMGC.HoSo.SieuAm = 0;
                                baMGC.HoSo.Khac = 0;
                                baMGC.HoSo.ToanBoHoSo = 0;
                                baMGC.HoSo.Khac_Text = "";
                            }
                        }
                        if (baMGC.DauSinhTon == null)
                        {
                            if (XemBenhAn._ThongTinDieuTri.DauSinhTon != null)
                            {
                                baMGC.DauSinhTon = XemBenhAn._ThongTinDieuTri.DauSinhTon;
                            }
                            else
                            {
                                baMGC.DauSinhTon = new DauSinhTon();
                                baMGC.DauSinhTon.Mach = 0;
                                baMGC.DauSinhTon.NhietDo = 0;
                                baMGC.DauSinhTon.HuyetAp = "";
                                baMGC.DauSinhTon.NhipTho = 0;
                                baMGC.DauSinhTon.CanNang = 0;
                                baMGC.DauSinhTon.ChieuCao = 0;
                                baMGC.DauSinhTon.BMI = 0;
                            }
                        }

                        if (baMGC.ChanDoanRaVien_MatPhai.IsNotNullOrEmpty() || baMGC.ChanDoanRaVien_MatPhai.IsNotNullOrEmpty() || baMGC.PhuongPhapDieuTri_PhauThuat.IsNotNullOrEmpty() || baMGC.PhuongPhapDieuTri_Laser.IsNotNullOrEmpty() || baMGC.PhuongPhapDieuTri_Thuoc.IsNotNullOrEmpty() || baMGC.TinhTrangRaVien_MatPhai.IsNotNullOrEmpty() || baMGC.TinhTrangRaVien_MatTrai.IsNotNullOrEmpty() || baMGC.HuongDieuTri_TheoDoi.IsNotNullOrEmpty() || baMGC.HuongDieuTri_PhauThuat.IsNotNullOrEmpty() || baMGC.HuongDieuTri_Laser.IsNotNullOrEmpty() || baMGC.HuongDieuTri_Thuoc.IsNotNullOrEmpty() || baMGC.RaVienMP_CoKinh.IsNotNullOrEmpty() || baMGC.RaVienMT_CoKinh.IsNotNullOrEmpty() || baMGC.RaVienMP_KhongKinh.IsNotNullOrEmpty() || baMGC.RaVienMT_KhongKinh.IsNotNullOrEmpty() || baMGC.RaVienNhanApMP.IsNotNullOrEmpty() || baMGC.RaVienNhanApMT.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnMatGlocomFunc.InsertOrUpdate(Connection, baMGC);
                        idDotVaoVien = baMGC.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.MatLac:
                    BenhAnMatLac baML = XemBenhAn.BenhAn as BenhAnMatLac;
                    if (baML != null)
                    {
                        if (baML.ChanDoanBenhChinh_LamSang.IsNotNullOrEmpty() || baML.ChanDoanBenhChinh_NguyenNhan.IsNotNullOrEmpty() || baML.QuaTrinhDieuTri_NoiKhoa.IsNotNullOrEmpty() || baML.HuongDieuTriTiep.IsNotNullOrEmpty() || baML.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baML.ThiLucRaVienKhongKinhMPTongKet.IsNotNullOrEmpty() || baML.ThiLucRaVienKhongKinhMTTongKet.IsNotNullOrEmpty() || baML.ThiLucRaVienCoKinhMPTongKet.IsNotNullOrEmpty() || baML.ThiLucRaVienCoKinhMTTongKet.IsNotNullOrEmpty() || baML.NhanApRaVienMPTongKet.IsNotNullOrEmpty() || baML.NhanApRaVienMTTongKet.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnMatLacFunc.InsertOrUpdate(Connection, baML);
                        idDotVaoVien = baML.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.MatTreEm:
                    BenhAnMatTreEm baMTE = XemBenhAn.BenhAn as BenhAnMatTreEm;
                    if (baMTE != null)
                    {
                        if (baMTE.ChanDoanBenhChinh_LamSang.IsNotNullOrEmpty() || baMTE.ChanDoanBenhChinh_NguyenNhan.IsNotNullOrEmpty() || baMTE.QuaTrinhDieuTri_NoiKhoa.IsNotNullOrEmpty() || baMTE.QuaTrinhDieuTri_KetQua.IsNotNullOrEmpty() || baMTE.QuaTrinhDieuTri_BienChung.IsNotNullOrEmpty() || baMTE.HuongDieuTriTiep.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnMatTreEmFunc.InsertOrUpdate(Connection, baMTE);
                        idDotVaoVien = baMTE.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiKhoa:
                    BenhAnNgoaiKhoa baNgK = XemBenhAn.BenhAn as BenhAnNgoaiKhoa;
                    if (baNgK != null)
                    {
                        if (baNgK.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baNgK.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baNgK.PhuongPhapDieuTri.IsNotNullOrEmpty() || baNgK.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baNgK.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiKhoaFunc.InsertOrUpdate(Connection, baNgK);
                        idDotVaoVien = baNgK.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru:
                    BenhAnNgoaiTru baNgTC = XemBenhAn.BenhAn as BenhAnNgoaiTru;
                    if (baNgTC != null)
                    {
                        if (baNgTC.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baNgTC.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baNgTC.PhuongPhapDieuTri.IsNotNullOrEmpty() || baNgTC.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baNgTC.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty() || baNgTC.ChanDoanKhiRaVien.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTruFunc.InsertOrUpdate(Connection, baNgTC);
                        idDotVaoVien = baNgTC.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTruRangHamMat:
                    BenhAnNgoaiTruRangHamMat baNgTRHM = XemBenhAn.BenhAn as BenhAnNgoaiTruRangHamMat;
                    if (baNgTRHM != null)
                    {
                        if (baNgTRHM.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baNgTRHM.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baNgTRHM.PhuongPhapDieuTri.IsNotNullOrEmpty() || baNgTRHM.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baNgTRHM.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty() || baNgTRHM.BenhChinh.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTruRangHamMatFunc.InsertOrUpdate(Connection, baNgTRHM);
                        idDotVaoVien = baNgTRHM.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTruTaiMuiHong:
                    BenhAnNgoaiTruTaiMuiHong baNgTTMH = XemBenhAn.BenhAn as BenhAnNgoaiTruTaiMuiHong;
                    if (baNgTTMH != null)
                    {
                        if (baNgTTMH.BenhChinh.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTruTaiMuiHongFunc.InsertOrUpdate(Connection, baNgTTMH);
                        idDotVaoVien = baNgTTMH.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTruYHCT:
                    BenhAnNgoaiTruYHCT baNgTYHCT = XemBenhAn.BenhAn as BenhAnNgoaiTruYHCT;
                    if (baNgTYHCT != null)
                    {
                        if (baNgTYHCT.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baNgTYHCT.KetQuaXetNghiemCanLamSang.IsNotNullOrEmpty() || baNgTYHCT.PhuongPhapDieuTriTheoYHCT.IsNotNullOrEmpty() || baNgTYHCT.PhuongPhapDieuTriTheoYHHD.IsNotNullOrEmpty() || baNgTYHCT.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baNgTYHCT.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty() || baNgTYHCT.KetQuaDieuTriID > 0)
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTruYHCTFunc.InsertOrUpdate(Connection, baNgTYHCT);
                        idDotVaoVien = baNgTYHCT.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NoiKhoa:
                    BenhAnNoiKhoa baNoK = XemBenhAn.BenhAn as BenhAnNoiKhoa;
                    if (baNoK != null)
                    {
                        if (baNoK.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baNoK.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baNoK.PhuongPhapDieuTri.IsNotNullOrEmpty() || baNoK.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baNoK.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNoiKhoaFunc.InsertOrUpdate(Connection, baNoK);
                        idDotVaoVien = baNoK.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NoiTruYHCT:
                    BenhAnNoiTruYHCT baNoYHCT = XemBenhAn.BenhAn as BenhAnNoiTruYHCT;
                    if (baNoYHCT != null)
                    {
                        if (baNoYHCT.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baNoYHCT.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baNoYHCT.PhuongPhapDieuTriTheoYHCT.IsNotNullOrEmpty() || baNoYHCT.PhuongPhapDieuTriTheoYHHD.IsNotNullOrEmpty() || baNoYHCT.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baNoYHCT.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty() || baNoYHCT.KetQuaDieuTriID > 0 || baNoYHCT.ChanDoanRaVienTheoYHCT.IsNotNullOrEmpty() || baNoYHCT.ChanDoanRaVienTheoYHHD.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNoiTruYHCTFunc.Insert(Connection, baNoYHCT);
                        idDotVaoVien = baNoYHCT.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.PhaThaiI:
                    BenhAnPhaThaiI baPT1 = XemBenhAn.BenhAn as BenhAnPhaThaiI;
                    if (baPT1 != null)
                    {
                        if (baPT1.RaVeThoiThoiGian.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnPhaThaiIFunc.InsertOrUpdate(Connection, baPT1);
                        idDotVaoVien = baPT1.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.PhaThaiII:
                    BenhAnPhaThaiII baPT2 = XemBenhAn.BenhAn as BenhAnPhaThaiII;
                    if (baPT2 != null)
                    {
                        if (baPT2.RaVeThoiThoiGian.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnPhaThaiIIFunc.InsertOrUpdate(Connection, baPT2);
                        idDotVaoVien = baPT2.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNang:
                    BenhAnPhucHoiChucNang baPHCN = XemBenhAn.BenhAn as BenhAnPhucHoiChucNang;
                    if (baPHCN != null)
                    {
                        if (baPHCN.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baPHCN.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baPHCN.PhuongPhapDieuTri.IsNotNullOrEmpty() || baPHCN.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baPHCN.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnPhucHoiChucNangFunc.InsertOrUpdate(Connection, baPHCN);
                        idDotVaoVien = baPHCN.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.PhuKhoa:
                    BenhAnPhuKhoa baPK = XemBenhAn.BenhAn as BenhAnPhuKhoa;
                    if (baPK != null)
                    {
                        if (baPK.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baPK.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baPK.PhuongPhapDieuTri.IsNotNullOrEmpty() || baPK.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baPK.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnPhuKhoaFunc.InsertOrUpdate(Connection, baPK);
                        idDotVaoVien = baPK.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.RangHamMat:
                    BenhAnRangHamMat baRHM = XemBenhAn.BenhAn as BenhAnRangHamMat;
                    if (baRHM != null)
                    {
                        if (baRHM.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baRHM.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baRHM.PhuongPhapDieuTri.IsNotNullOrEmpty() || baRHM.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baRHM.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnRangHamMatFunc.InsertOrUpdate(Connection, baRHM);
                        idDotVaoVien = baRHM.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.SanKhoa:
                    BenhAnSanKhoa baSK = XemBenhAn.BenhAn as BenhAnSanKhoa;
                    if (baSK != null)
                    {
                        if (baSK.ThoiGianDe.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnSanKhoaFunc.InsertOrUpdate(Connection, baSK);
                        idDotVaoVien = baSK.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.SoSinh:
                    BenhAnSoSinh baSS = XemBenhAn.BenhAn as BenhAnSoSinh;
                    if (baSS != null)
                    {
                        if (baSS.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baSS.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baSS.PhuongPhapDieuTri.IsNotNullOrEmpty() || baSS.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baSS.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnSoSinhFunc.InsertOrUpdate(Connection, baSS);
                        idDotVaoVien = baSS.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.TaiMuiHong:
                    BenhAnTaiMuiHong baTMH = XemBenhAn.BenhAn as BenhAnTaiMuiHong;
                    if (baTMH != null)
                    {
                        if (baTMH.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baTMH.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baTMH.PhuongPhapDieuTri.IsNotNullOrEmpty() || baTMH.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baTMH.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnTaiMuiHongFunc.InsertOrUpdate(Connection, baTMH);
                        idDotVaoVien = baTMH.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.TamThan:
                    BenhAnTamThan baTT = XemBenhAn.BenhAn as BenhAnTamThan;
                    if (baTT != null)
                    {
                        if (baTT.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baTT.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baTT.PhuongPhapDieuTri.IsNotNullOrEmpty() || baTT.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baTT.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnTamThanFunc.InsertOrUpdate(Connection, baTT);
                        idDotVaoVien = baTT.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.TruyenNhiem:
                    BenhAnTruyenNhiem baTN = XemBenhAn.BenhAn as BenhAnTruyenNhiem;
                    if (baTN != null)
                    {
                        if (baTN.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baTN.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baTN.PhuongPhapDieuTri.IsNotNullOrEmpty() || baTN.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baTN.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnTruyenNhiemFunc.InsertOrUpdate(Connection, baTN);
                        idDotVaoVien = baTN.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.TruyenNhiemII:
                    BenhAnTruyenNhiemII baTNII = XemBenhAn.BenhAn as BenhAnTruyenNhiemII;
                    if (baTNII != null)
                    {
                        if (baTNII.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baTNII.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baTNII.PhuongPhapDieuTri.IsNotNullOrEmpty() || baTNII.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baTNII.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnTruyenNhiemIIFunc.InsertOrUpdate(Connection, baTNII);
                        idDotVaoVien = baTNII.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.UngBuou:
                    BenhAnUngBuou baUB = XemBenhAn.BenhAn as BenhAnUngBuou;
                    if (baUB != null)
                    {
                        if (baUB.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baUB.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baUB.PhuongPhapDieuTri.IsNotNullOrEmpty() || baUB.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baUB.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnUngBuouFunc.InsertOrUpdate(Connection, baUB);
                        idDotVaoVien = baUB.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.XaPhuong:
                    BenhAnXaPhuong baXP = XemBenhAn.BenhAn as BenhAnXaPhuong;
                    if (baXP != null)
                    {
                        if (baXP.MaICD_BenhChinh.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnXaPhuongFunc.InsertOrUpdate(Connection, baXP);
                        idDotVaoVien = baXP.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.DieuTriBanNgay:
                    BenhAnDieuTriBanNgay baBanN = XemBenhAn.BenhAn as BenhAnDieuTriBanNgay;
                    if (baBanN != null)
                    {
                        if (baBanN.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baBanN.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baBanN.PhuongPhapDieuTri.IsNotNullOrEmpty() || baBanN.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baBanN.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnDieuTriBanNgayFunc.InsertOrUpdate(Connection, baBanN);
                        idDotVaoVien = baBanN.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.ThanNhanTao:
                    BenhAnThanNhanTao benhAnThanNhanTao = XemBenhAn.BenhAn as BenhAnThanNhanTao;
                    if (benhAnThanNhanTao != null)
                    {
                        if (benhAnThanNhanTao.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || benhAnThanNhanTao.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || benhAnThanNhanTao.PhuongPhapDieuTri.IsNotNullOrEmpty() || benhAnThanNhanTao.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || benhAnThanNhanTao.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnThanNhanTaoFunc.InsertOrUpdate(Connection, benhAnThanNhanTao);
                        idDotVaoVien = benhAnThanNhanTao.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.Mat:
                    BenhAnMat benhAnMat = XemBenhAn.BenhAn as BenhAnMat;
                    if (benhAnMat != null)
                    {
                        if (benhAnMat.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || benhAnMat.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || benhAnMat.PhuongPhapDieuTri.IsNotNullOrEmpty() || benhAnMat.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || benhAnMat.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty() || benhAnMat.ChanDoanBenhChinh_LamSang.IsNotNullOrEmpty() || benhAnMat.ChanDoanBenhChinh_NguyenNhan.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnMatFunc.InsertOrUpdate(Connection, benhAnMat);
                        idDotVaoVien = benhAnMat.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTruMat:
                    BenhAnNgoaiTruMat benhAnNgoaiTruMat = XemBenhAn.BenhAn as BenhAnNgoaiTruMat;
                    if (benhAnNgoaiTruMat != null)
                    {
                        if (benhAnNgoaiTruMat.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || benhAnNgoaiTruMat.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || benhAnNgoaiTruMat.PhuongPhapDieuTri.IsNotNullOrEmpty() || benhAnNgoaiTruMat.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || benhAnNgoaiTruMat.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty() || benhAnNgoaiTruMat.ChanDoanBenhChinh_LamSang.IsNotNullOrEmpty() || benhAnNgoaiTruMat.ChanDoanBenhChinh_NguyenNhan.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTruMatFunc.InsertOrUpdate(Connection, benhAnNgoaiTruMat);
                        idDotVaoVien = benhAnNgoaiTruMat.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.Tim:
                    BenhAnTim benhAnTim = XemBenhAn.BenhAn as BenhAnTim;
                    if (benhAnTim != null)
                    {
                        if (benhAnTim.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || benhAnTim.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || benhAnTim.PhuongPhapDieuTri.IsNotNullOrEmpty() || benhAnTim.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || benhAnTim.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnTimFunc.InsertOrUpdate(Connection, benhAnTim);
                        idDotVaoVien = benhAnTim.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNangYHCT:
                    BenhAnPhucHoiChucNangYHCT benhAnPhucHoiChucNangYHCT = XemBenhAn.BenhAn as BenhAnPhucHoiChucNangYHCT;
                    if (benhAnPhucHoiChucNangYHCT != null)
                    {
                        if (benhAnPhucHoiChucNangYHCT.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || benhAnPhucHoiChucNangYHCT.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || benhAnPhucHoiChucNangYHCT.PhuongPhapDieuTri.IsNotNullOrEmpty() || benhAnPhucHoiChucNangYHCT.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || benhAnPhucHoiChucNangYHCT.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnPhucHoiChucNangYHCTFunc.InsertOrUpdate(Connection, benhAnPhucHoiChucNangYHCT);
                        idDotVaoVien = benhAnPhucHoiChucNangYHCT.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.LuuCapCuu:
                    BenhAnLuuCapCuu benhAnLuuCapCuu = XemBenhAn.BenhAn as BenhAnLuuCapCuu;
                    if (benhAnLuuCapCuu != null)
                    {
                        if (benhAnLuuCapCuu.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || benhAnLuuCapCuu.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || benhAnLuuCapCuu.PhuongPhapDieuTri.IsNotNullOrEmpty() || benhAnLuuCapCuu.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || benhAnLuuCapCuu.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnLuuCapCuuFunc.InsertOrUpdate(Connection, benhAnLuuCapCuu);
                        idDotVaoVien = benhAnLuuCapCuu.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.CMU:
                    BenhAnCMU benhAnCMU = XemBenhAn.BenhAn as BenhAnCMU;
                    if (benhAnCMU != null)
                    {
                        if (benhAnCMU.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || benhAnCMU.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || benhAnCMU.PhuongPhapDieuTri.IsNotNullOrEmpty() || benhAnCMU.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || benhAnCMU.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnCMUFunc.InsertOrUpdate(Connection, benhAnCMU);
                        idDotVaoVien = benhAnCMU.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.PhaThaiIII:
                    BenhAnPhaThaiIII benhAnPhaThaiIII = XemBenhAn.BenhAn as BenhAnPhaThaiIII;
                    if (benhAnPhaThaiIII != null)
                    {
                        if (benhAnPhaThaiIII.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || benhAnPhaThaiIII.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || benhAnPhaThaiIII.PhuongPhapDieuTri.IsNotNullOrEmpty() || benhAnPhaThaiIII.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || benhAnPhaThaiIII.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnPhaThaiIIIFunc.InsertOrUpdate(Connection, benhAnPhaThaiIII);
                        idDotVaoVien = benhAnPhaThaiIII.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.BANgoaTruPK:
                    BANgoaiTruPK BenhAnNgoaiTruPKObj = XemBenhAn.BenhAn as BANgoaiTruPK;
                    if (BenhAnNgoaiTruPKObj != null)
                    {
                        //if (BenhAnNgoaiTruPKObj.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || BenhAnNgoaiTruPKObj.TomTatKetQuaXetNghiem.IsNotNullOrEmpty()
                        //    || BenhAnNgoaiTruPKObj.PhuongPhapDieuTri.IsNotNullOrEmpty() || BenhAnNgoaiTruPKObj.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty()
                        //    || BenhAnNgoaiTruPKObj.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        //{
                        //    daTongKetBenhAn = true;
                        //}
                        luuThanhCong = BANgoaiTruPKFunc.InsertOrUpdate(Connection, BenhAnNgoaiTruPKObj);
                        if (luuThanhCong && BenhAnNgoaiTruPKObj.LstTTChiTiet != null)
                        {
                            for (int i = 0; i < BenhAnNgoaiTruPKObj.LstTTChiTiet.Count; i++)
                            {
                                luuThanhCong = BANgoaiTruPKFunc.InsertOrUpdate_Chittiet(XemBenhAn.MyConnection, BenhAnNgoaiTruPKObj.LstTTChiTiet[i]);

                            }
                        }

                        idDotVaoVien = BenhAnNgoaiTruPKObj.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.TayChanMieng:
                    BenhAnTayChanMieng TayChanMiengObj = XemBenhAn.BenhAn as BenhAnTayChanMieng;
                    if (TayChanMiengObj != null)
                    {
                        luuThanhCong = BenhAnTayChanMiengFunc.InsertOrUpdate(Connection, TayChanMiengObj);
                        idDotVaoVien = TayChanMiengObj.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTruPhucHoiChucNang:
                    BenhAnNgoaiTruPHCN baNgoaiTruPHCN = XemBenhAn.BenhAn as BenhAnNgoaiTruPHCN;
                    if (baNgoaiTruPHCN != null)
                    {
                        if (baNgoaiTruPHCN.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() 
                            || baNgoaiTruPHCN.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() 
                            || baNgoaiTruPHCN.PhuongPhapDieuTri.IsNotNullOrEmpty()
                            || baNgoaiTruPHCN.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty()
                            || baNgoaiTruPHCN.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty()
                            || baNgoaiTruPHCN.ChanDoanKhiRaVien.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTruPHCNFunc.InsertOrUpdate(Connection, baNgoaiTruPHCN);
                        idDotVaoVien = baNgoaiTruPHCN.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.DaLieuTW:
                    BenhAnDaLieuTW baDaLieuTW = XemBenhAn.BenhAn as BenhAnDaLieuTW;
                    if (baDaLieuTW != null)
                    {
                        if (baDaLieuTW.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baDaLieuTW.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baDaLieuTW.PhuongPhapDieuTri.IsNotNullOrEmpty() || baDaLieuTW.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baDaLieuTW.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnDaLieuTWFunc.InsertOrUpdate(Connection, baDaLieuTW);
                        idDotVaoVien = baDaLieuTW.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNangNhi:
                    BenhAnPHCNNhi baPHCNNhi = XemBenhAn.BenhAn as BenhAnPHCNNhi;
                    if (baPHCNNhi != null)
                    {
                        if (baPHCNNhi.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty()
                            || baPHCNNhi.TomTatKetQuaXetNghiem.IsNotNullOrEmpty()
                            || baPHCNNhi.PhuongPhapDieuTri.IsNotNullOrEmpty()
                            || baPHCNNhi.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty()
                            || baPHCNNhi.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnPHCNNhiFunc.InsertOrUpdate(Connection, baPHCNNhi);
                        idDotVaoVien = baPHCNNhi.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.PHCNII:
                    BenhAnPHCNII baPHCNII = XemBenhAn.BenhAn as BenhAnPHCNII;
                    if (baPHCNII != null)
                    {
                        if (baPHCNII.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty()
                            || baPHCNII.TomTatKetQuaXetNghiem.IsNotNullOrEmpty()
                            || baPHCNII.PhuongPhapDieuTri.IsNotNullOrEmpty()
                            || baPHCNII.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty()
                            || baPHCNII.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnPHCNIIFunc.InsertOrUpdate(Connection, baPHCNII);
                        idDotVaoVien = baPHCNII.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenThuongThuong:
                    BenhAnNgoaiTru_BenhVayNenThongThuong baNgoaiTru_BenhVayNenThongThuong = XemBenhAn.BenhAn as BenhAnNgoaiTru_BenhVayNenThongThuong;
                    if (baNgoaiTru_BenhVayNenThongThuong != null)
                    {
                        if (baNgoaiTru_BenhVayNenThongThuong.TK_QuaTrinhBenhLy.IsNotNullOrEmpty()
                            || baNgoaiTru_BenhVayNenThongThuong.TK_TomTatKetQua.IsNotNullOrEmpty()
                            || baNgoaiTru_BenhVayNenThongThuong.TK_PhuongPhapDieuTri.IsNotNullOrEmpty()
                            || baNgoaiTru_BenhVayNenThongThuong.TK_TinhTrangRaVien.IsNotNullOrEmpty()
                            || baNgoaiTru_BenhVayNenThongThuong.TK_HuongDieuTri.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTru_BenhVayNenThongThuongFunc.InsertOrUpdate(Connection, baNgoaiTru_BenhVayNenThongThuong);
                        idDotVaoVien = baNgoaiTru_BenhVayNenThongThuong.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_AVayNen:
                    BenhAnNgoaiTruAVayNen baBenhAnNgoaiTruAVayNen = XemBenhAn.BenhAn as BenhAnNgoaiTruAVayNen;
                    if (baBenhAnNgoaiTruAVayNen != null)
                    {
                        if (baBenhAnNgoaiTruAVayNen.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty()
                            || baBenhAnNgoaiTruAVayNen.TomTatKetQuaXetNghiem.IsNotNullOrEmpty()
                            || baBenhAnNgoaiTruAVayNen.PhuongPhapDieuTri.IsNotNullOrEmpty()
                            || baBenhAnNgoaiTruAVayNen.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty()
                            || baBenhAnNgoaiTruAVayNen.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTruAVayNenFunc.InsertOrUpdate(Connection, baBenhAnNgoaiTruAVayNen);
                        idDotVaoVien = baBenhAnNgoaiTruAVayNen.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_HoTroSinhSan:
                    BenhAnNgoaiTru_HoTroSinhSan baBenhAnNgoaiTru_HoTroSinhSan = XemBenhAn.BenhAn as BenhAnNgoaiTru_HoTroSinhSan;
                    if (baBenhAnNgoaiTru_HoTroSinhSan != null)
                    {
                        if (baBenhAnNgoaiTru_HoTroSinhSan.ChanDoan.IsNotNullOrEmpty()
                            || baBenhAnNgoaiTru_HoTroSinhSan.PhacDoDieuTri.IsNotNullOrEmpty()
                            || baBenhAnNgoaiTru_HoTroSinhSan.KetQuaLABO.IsNotNullOrEmpty()
                            || baBenhAnNgoaiTru_HoTroSinhSan.KetQuaDieuTri.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTru_HoTroSinhSanFunc.InsertOrUpdate(Connection, baBenhAnNgoaiTru_HoTroSinhSan);
                        idDotVaoVien = baBenhAnNgoaiTru_HoTroSinhSan.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhAnViemBiCo:
                    BenhAnNgoaiTru_ViemBiCo baNgoaiTru_ViemBiCo = XemBenhAn.BenhAn as BenhAnNgoaiTru_ViemBiCo;
                    if (baNgoaiTru_ViemBiCo != null)
                    {
                        if (baNgoaiTru_ViemBiCo.QuaTrinhBenhLy.IsNotNullOrEmpty()
                            || baNgoaiTru_ViemBiCo.TomTatKetQua.IsNotNullOrEmpty()
                            || baNgoaiTru_ViemBiCo.PhuongPhapDieuTri.IsNotNullOrEmpty()
                            || baNgoaiTru_ViemBiCo.TinhTrangRaVien.IsNotNullOrEmpty()
                            || baNgoaiTru_ViemBiCo.HuongDieuTri.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTru_ViemBiCoFunc.InsertOrUpdate(Connection, baNgoaiTru_ViemBiCo);
                        idDotVaoVien = baNgoaiTru_ViemBiCo.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhAnLupusBanDoHeThong:
                    BenhAnNgoaiTru_LupusBanDoHeThong baNgoaiTru_LupusBanDoHeThong = XemBenhAn.BenhAn as BenhAnNgoaiTru_LupusBanDoHeThong;
                    if (baNgoaiTru_LupusBanDoHeThong != null)
                    {
                        if (baNgoaiTru_LupusBanDoHeThong.QuaTrinhBenhLy.IsNotNullOrEmpty()
                            || baNgoaiTru_LupusBanDoHeThong.TomTatKetQua.IsNotNullOrEmpty()
                            || baNgoaiTru_LupusBanDoHeThong.PhuongPhapDieuTri.IsNotNullOrEmpty()
                            || baNgoaiTru_LupusBanDoHeThong.TinhTrangRaVien.IsNotNullOrEmpty()
                            || baNgoaiTru_LupusBanDoHeThong.HuongDieuTri.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTru_LupusBanDoHeThongFunc.InsertOrUpdate(Connection, baNgoaiTru_LupusBanDoHeThong);
                        idDotVaoVien = baNgoaiTru_LupusBanDoHeThong.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_PEMPHIGOID:
                    BenhAnNgoaiTruPemphigoid _BenhAnNgoaiTruPemphigoid = XemBenhAn.BenhAn as BenhAnNgoaiTruPemphigoid;
                    if (_BenhAnNgoaiTruPemphigoid != null)
                    {
                        if (_BenhAnNgoaiTruPemphigoid.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty()
                            || _BenhAnNgoaiTruPemphigoid.TomTatKetQuaXetNghiem.IsNotNullOrEmpty()
                            || _BenhAnNgoaiTruPemphigoid.PhuongPhapDieuTri.IsNotNullOrEmpty()
                            || _BenhAnNgoaiTruPemphigoid.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty()
                            || _BenhAnNgoaiTruPemphigoid.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTruPemphigoidFunc.InsertOrUpdate(Connection, _BenhAnNgoaiTruPemphigoid);
                        idDotVaoVien = _BenhAnNgoaiTruPemphigoid.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayPhanDoNangLong:
                    BenhAnNgoaiTru_VayPhanDoNangLong _BenhAnNgoaiTru_VayPhanDoNangLong = XemBenhAn.BenhAn as BenhAnNgoaiTru_VayPhanDoNangLong;
                    if (_BenhAnNgoaiTru_VayPhanDoNangLong != null)
                    {
                        if (_BenhAnNgoaiTru_VayPhanDoNangLong.QuaTrinhBenhLy.IsNotNullOrEmpty()
                            || _BenhAnNgoaiTru_VayPhanDoNangLong.TomTatKetQua.IsNotNullOrEmpty()
                            || _BenhAnNgoaiTru_VayPhanDoNangLong.PhuongPhapDieuTri.IsNotNullOrEmpty()
                            || _BenhAnNgoaiTru_VayPhanDoNangLong.TinhTrangRaVien.IsNotNullOrEmpty()
                            || _BenhAnNgoaiTru_VayPhanDoNangLong.HuongDieuTri.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTru_VayPhanDoNangLongFunc.InsertOrUpdate(Connection, _BenhAnNgoaiTru_VayPhanDoNangLong);
                        idDotVaoVien = _BenhAnNgoaiTru_VayPhanDoNangLong.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_LuPusBanDoManTinh:
                    BenhAnNgoaiTru_LuPusBanDoManTinh _LuPusBanDoManTinh = XemBenhAn.BenhAn as BenhAnNgoaiTru_LuPusBanDoManTinh;
                    if (_LuPusBanDoManTinh != null)
                    {
                        if (_LuPusBanDoManTinh.TK_PhuongPhapDieuTri.IsNotNullOrEmpty()
                            || _LuPusBanDoManTinh.TK_TomTatKetQua.IsNotNullOrEmpty()
                            || _LuPusBanDoManTinh.TK_TinhTrangRaVien.IsNotNullOrEmpty()
                            || _LuPusBanDoManTinh.TK_HuongDieuTri.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTru_LuPusBanDoManTinhFunc.InsertOrUpdate(Connection, _LuPusBanDoManTinh);
                        idDotVaoVien = _LuPusBanDoManTinh.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenTheMu:
                    BenhAnNgoaiTru_BenhVayNenTheMu _BenhAnNgoaiTru_BenhVayNenTheMu = XemBenhAn.BenhAn as BenhAnNgoaiTru_BenhVayNenTheMu;
                    if (_BenhAnNgoaiTru_BenhVayNenTheMu != null)
                    {
                        if (_BenhAnNgoaiTru_BenhVayNenTheMu.QuaTrinhBenhLy.IsNotNullOrEmpty()
                           || _BenhAnNgoaiTru_BenhVayNenTheMu.TomTatKetQua.IsNotNullOrEmpty()
                           || _BenhAnNgoaiTru_BenhVayNenTheMu.PhuongPhapDieuTri.IsNotNullOrEmpty()
                           || _BenhAnNgoaiTru_BenhVayNenTheMu.TinhTrangRaVien.IsNotNullOrEmpty()
                           || _BenhAnNgoaiTru_BenhVayNenTheMu.HuongDieuTri.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTru_BenhVayNenTheMuFunc.InsertOrUpdate(Connection, _BenhAnNgoaiTru_BenhVayNenTheMu);
                        idDotVaoVien = _BenhAnNgoaiTru_BenhVayNenTheMu.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_DuhringBrocq:
                    BenhAnNgoaiTruDuhringBrocq _BenhAnNgoaiTruDuhringBrocq = XemBenhAn.BenhAn as BenhAnNgoaiTruDuhringBrocq;
                    if (_BenhAnNgoaiTruDuhringBrocq != null)
                    {
                        if (_BenhAnNgoaiTruDuhringBrocq.QuaTrinhBenhLy.IsNotNullOrEmpty()
                           || _BenhAnNgoaiTruDuhringBrocq.TomTatKetQua.IsNotNullOrEmpty()
                           || _BenhAnNgoaiTruDuhringBrocq.PhuongPhapDieuTri.IsNotNullOrEmpty()
                           || _BenhAnNgoaiTruDuhringBrocq.TinhTrangRaVien.IsNotNullOrEmpty()
                           || _BenhAnNgoaiTruDuhringBrocq.HuongDieuTri.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNgoaiTruDuhringBrocqFunc.InsertOrUpdate(Connection, _BenhAnNgoaiTruDuhringBrocq);
                        idDotVaoVien = _BenhAnNgoaiTruDuhringBrocq.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.DaiThaoDuong:
                    BenhAnDaiThaoDuong _BenhAnDaiThaoDuong = XemBenhAn.BenhAn as BenhAnDaiThaoDuong;
                    if (_BenhAnDaiThaoDuong != null)
                    {
                        luuThanhCong = BenhAnDaiThaoDuongFunc.InsertOrUpdate(Connection, _BenhAnDaiThaoDuong);
                        idDotVaoVien = _BenhAnDaiThaoDuong.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_UngThuDaHacTo:
                    BenhAnUngThuHacTo _BenhAnUngThuHacTo = XemBenhAn.BenhAn as BenhAnUngThuHacTo;
                    if (_BenhAnUngThuHacTo != null)
                    {
                        luuThanhCong = BenhAnUngThuHacToFunc.InsertOrUpdate(Connection, _BenhAnUngThuHacTo);
                        if((MauUserControl.ucKhamBenh as KhamBenh_BAUngThuDaHacTo) != null)
                            (MauUserControl.ucKhamBenh as KhamBenh_BAUngThuDaHacTo).uploadFile();
                        idDotVaoVien = _BenhAnUngThuHacTo.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_UngThuDaKhongHacTo:
                    BenhAnUngThuKhongHacTo _BenhAnUngThuKhongHacTo = XemBenhAn.BenhAn as BenhAnUngThuKhongHacTo;
                    if (_BenhAnUngThuKhongHacTo != null)
                    {
                        luuThanhCong = BenhAnUngThuKhongHacToFunc.InsertOrUpdate(Connection, _BenhAnUngThuKhongHacTo);
                        if ((MauUserControl.ucKhamBenh as KhamBenh_BAUngThuDaKhongHacTo) != null)
                            (MauUserControl.ucKhamBenh as KhamBenh_BAUngThuDaKhongHacTo).uploadFile();
                        idDotVaoVien = _BenhAnUngThuKhongHacTo.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_Pemphigus:
                    BenhAnNgoaiTruPemphigus _BenhAnNgoaiTruPemphigus = XemBenhAn.BenhAn as BenhAnNgoaiTruPemphigus;
                    if (_BenhAnNgoaiTruPemphigus != null)
                    {
                        luuThanhCong = BenhAnNgoaiTruPemphigusFunc.InsertOrUpdate(Connection, _BenhAnNgoaiTruPemphigus);
                        idDotVaoVien = _BenhAnNgoaiTruPemphigus.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenTheKhop:
                    BenhAnVayNenTheKhop _BenhAnVayNenTheKhop = XemBenhAn.BenhAn as BenhAnVayNenTheKhop;
                    if (_BenhAnVayNenTheKhop != null)
                    {
                        luuThanhCong = BenhAnVayNenTheKhopFunc.InsertOrUpdate(Connection, _BenhAnVayNenTheKhop);
                        if ((MauUserControl.ucHoiBenh as HoiBenh_BAVayNenTheKhop) != null)
                            (MauUserControl.ucHoiBenh as HoiBenh_BAVayNenTheKhop).uploadFile();
                        if ((MauUserControl.ucKhamBenh as KhamBenh_BAVayNenTheKhop) != null)
                            (MauUserControl.ucKhamBenh as KhamBenh_BAVayNenTheKhop).uploadFile();
                        idDotVaoVien = _BenhAnVayNenTheKhop.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_HoiChungTrungLap:
                    BenhAnNgoaiTru_HoiChungTrungLap _BenhAnNgoaiTru_HoiChungTrungLap = XemBenhAn.BenhAn as BenhAnNgoaiTru_HoiChungTrungLap;
                    if (_BenhAnNgoaiTru_HoiChungTrungLap != null)
                    {
                        luuThanhCong = BenhAnNgoaiTru_HoiChungTrungLapFunc.InsertOrUpdate(Connection, _BenhAnNgoaiTru_HoiChungTrungLap);
                        idDotVaoVien = _BenhAnNgoaiTru_HoiChungTrungLap.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.StentDongMachVanh:
                    BenhAnStentDongMachVanh _BenhAnStentDongMachVanh = XemBenhAn.BenhAn as BenhAnStentDongMachVanh;
                    if (_BenhAnStentDongMachVanh != null)
                    {
                        luuThanhCong = BenhAnStentDongMachVanhFunc.InsertOrUpdate(Connection, _BenhAnStentDongMachVanh);
                        idDotVaoVien = _BenhAnStentDongMachVanh.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.ThieuMauCoTimCucBo:
                    BenhAnThieuMauCoTimCucBo _BenhAnThieuMauCoTimCucBo = XemBenhAn.BenhAn as BenhAnThieuMauCoTimCucBo;
                    if (_BenhAnThieuMauCoTimCucBo != null)
                    {
                        luuThanhCong = BenhAnThieuMauCoTimCucBoFunc.InsertOrUpdate(Connection, _BenhAnThieuMauCoTimCucBo);
                        idDotVaoVien = _BenhAnThieuMauCoTimCucBo.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhBasedow:
                    BenhAnBenhBaseDow _BenhAnBenhBaseDow = XemBenhAn.BenhAn as BenhAnBenhBaseDow;
                    if (_BenhAnBenhBaseDow != null)
                    {
                        luuThanhCong = BenhAnBenhBaseDowFunc.InsertOrUpdate(Connection, _BenhAnBenhBaseDow);
                        idDotVaoVien = _BenhAnBenhBaseDow.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.ViemGanBManTinh:
                    BenhAnViemGanBManTinh _BenhAnViemGanBManTinh = XemBenhAn.BenhAn as BenhAnViemGanBManTinh;
                    if (_BenhAnViemGanBManTinh != null)
                    {
                        luuThanhCong = BenhAnViemGanBManTinhFunc.InsertOrUpdate(Connection, _BenhAnViemGanBManTinh);
                        idDotVaoVien = _BenhAnViemGanBManTinh.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.PhoiTacNghenManTinh:
                    BenhAnPhoiTacNghenManTinh _BenhAnPhoiTacNghenManTinh = XemBenhAn.BenhAn as BenhAnPhoiTacNghenManTinh;
                    if (_BenhAnPhoiTacNghenManTinh != null)
                    {
                        luuThanhCong = BenhAnPhoiTacNghenManTinhFunc.InsertOrUpdate(Connection, _BenhAnPhoiTacNghenManTinh);
                        idDotVaoVien = _BenhAnPhoiTacNghenManTinh.MaQuanLy.ToString();
                    }
                    break;
                case LoaiBenhAnEMR.BenhTangHuyetAp:
                    BenhAnTangHuyetAp _BenhAnTangHuyetAp = XemBenhAn.BenhAn as BenhAnTangHuyetAp;
                    if (_BenhAnTangHuyetAp != null)
                    {
                        luuThanhCong = BenhAnTangHuyetApFunc.InsertOrUpdate(Connection, _BenhAnTangHuyetAp);
                        idDotVaoVien = _BenhAnTangHuyetAp.MaQuanLy.ToString();
                    }
                    break;
                default:
                    BenhAnNhiKhoa baNhiK = XemBenhAn.BenhAn as BenhAnNhiKhoa;
                    if (baNhiK != null)
                    {
                        if (baNhiK.QuaTrinhBenhLyVaDienBien.IsNotNullOrEmpty() || baNhiK.TomTatKetQuaXetNghiem.IsNotNullOrEmpty() || baNhiK.PhuongPhapDieuTri.IsNotNullOrEmpty() || baNhiK.TinhTrangNguoiBenhRaVien.IsNotNullOrEmpty() || baNhiK.HuongDieuTriVaCacCheDoTiepTheo.IsNotNullOrEmpty())
                        {
                            daTongKetBenhAn = true;
                        }
                        luuThanhCong = BenhAnNhiKhoaFunc.InsertOrUpdate(Connection, baNhiK);
                        idDotVaoVien = baNhiK.MaQuanLy.ToString();
                    }
                    break;
            }
            XuLyLoi.LogDebug("dangtung - Luu benh an return : " + luuThanhCong);
            #endregion
            if (luuThanhCong)
            {
                if (Images != null && Images.Count > 0)
                {
                    bool luuHAThanhCong = true;
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(ERMDatabase.WebServiceEMR);
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        client.Timeout = new TimeSpan(0, 0, 1000);
                        var url = "api/KetXuat/PostFile";
                        try
                        {
                            foreach (var image in Images)
                            {
                                string test = JsonConvert.SerializeObject(image);
                                HttpResponseMessage response = client.PostAsJsonAsync(url, image).Result;
                                response.EnsureSuccessStatusCode();
                                if (response.IsSuccessStatusCode)
                                {
                                    string result = response.Content.ReadAsStringAsync().Result;
                                    if (result == "false")
                                    {
                                        luuHAThanhCong = false;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            XuLyLoi.LogError(ex);
                        }
                    }
                    if (!luuHAThanhCong)
                    {
                        XuLyLoi.Handle(new Exception("Có phát sinh lỗi trong quá trình lưu hình ảnh"));
                    }
                }
                if (daTongKetBenhAn)
                {
                    //    try
                    //    {
                    //        //ket xuat hl7
                    //        using (var client = new HttpClient())
                    //        {
                    //            try
                    //            {
                    //                MedilinkHL7.SDK.frmExport export = new MedilinkHL7.SDK.frmExport();
                    //                string URL = export.URL;
                    //                string Path = System.IO.Path.GetTempPath().Trim('\\') + "\\HL7Temp";
                    //                client.BaseAddress = new Uri(URL);
                    //                client.DefaultRequestHeaders.Accept.Clear();
                    //                client.Timeout = new TimeSpan(0, 0, 1000);

                    //                HttpResponseMessage resp = client.GetAsync("api/CDA/GetThongTinBenhNhan?IDDotVaoVien=" + idDotVaoVien + "&MaBenhNhan=" + XemBenhAn._HanhChinhBenhNhan.MaBenhNhan).Result;
                    //                if (resp.IsSuccessStatusCode)
                    //                {
                    //                    string responseData = resp.Content.ReadAsStringAsync().Result;
                    //                    if (responseData.IsNotNullOrEmpty())
                    //                    {
                    //                        MedilinkHL7.SDK.ThongTinBenhNhan data = JsonConvert.DeserializeObject<MedilinkHL7.SDK.ThongTinBenhNhan>(responseData);
                    //                        if (data.IsNotNullOrEmpty())
                    //                        {
                    //                            string file = export.WriteXML(data, Path);
                    //                            if (System.IO.File.Exists(file))
                    //                            {
                    //                                byte[] byteFile = File.ReadAllBytes(file);
                    //                                FileCopy fileCopy = new FileCopy();
                    //                                fileCopy.ArrayBytes = byteFile;
                    //                                fileCopy.FileName = System.IO.Path.GetFileName(file);
                    //                                fileCopy.PathFile = Report.SubPathExportPDF;

                    //                                using (var clientC = new HttpClient())
                    //                                {
                    //                                    try
                    //                                    {
                    //                                        client.BaseAddress = new Uri(ERMDatabase.WebServiceEMR);
                    //                                        client.DefaultRequestHeaders.Accept.Clear();
                    //                                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //                                        client.Timeout = new TimeSpan(0, 0, 1000);
                    //                                        var url = "api/KetXuat/PostFile";
                    //                                        HttpResponseMessage response = client.PostAsJsonAsync(url, fileCopy).Result;
                    //                                        response.EnsureSuccessStatusCode();
                    //                                        if (response.IsSuccessStatusCode)
                    //                                        {
                    //                                            string result = response.Content.ReadAsStringAsync().Result;
                    //                                            if (result == "true")
                    //                                            {
                    //                                                //if (File.Exists(file))
                    //                                                //{
                    //                                                //    File.Delete(file);
                    //                                                //}
                    //                                            }
                    //                                        }
                    //                                    }
                    //                                    catch (Exception ex)
                    //                                    {
                    //                                        XuLyLoi.Handle(ex);
                    //                                    }
                    //                                }
                    //                            }
                    //                        }
                    //                    }
                    //                    else
                    //                    {
                    //                        MDB.ExceptionExtend.LogError(new Exception("responseData is null\n" + resp.ToString()));
                    //                    }
                    //                }
                    //                else
                    //                {
                    //                    MDB.ExceptionExtend.LogError(new Exception("resp.IsSuccessStatusCode: " + resp.IsSuccessStatusCode + "\n" + resp.ToString()));
                    //                }
                    //            }
                    //            catch (Exception ex)
                    //            {
                    //                MDB.ExceptionExtend.LogError(ex);
                    //            }
                    //        }
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        MDB.ExceptionExtend.LogError(ex);
                    //    }
                }

                // update thông tin loại bệnh án lên địa chỉ MOS
                try
                {
                    if (!string.IsNullOrEmpty(ERMDatabase.KyDienTu_DiaChiMOS) && !string.IsNullOrEmpty(TokenKy))
                    {
                        ChuKySo ky = new ChuKySo();
                        var result = ky.UpdateLoaiBenhAnEmrCover(ERMDatabase.KyDienTu_DiaChiMOS, ERMDatabase.KyDienTu_ApplicationCode, TokenKy, ERMDatabase.KyDienTu_TREATMENT_CODE, (int)XemBenhAn._LoaiBenhAnEMR);
                        if (result != null && !result.Success)
                        {
                            log.Error("Không gửi được văn bản sang hệ thống ký");
                            string codeError = (result.Param != null && result.Param.BugCodes.Length > 0) ? result.Param.BugCodes[0] : "";
                            string message = (result.Param != null && result.Param.Messages.Length > 0) ? result.Param.Messages[0] : "";
                            XuLyLoi.LogDebug("message - " + message + " : codeError - " + luuThanhCong);
                        }
                        else if (result == null)
                        {
                            log.Error("Không gửi được văn bản sang hệ thống ký: result null");
                        }
                    }
                }
                catch (Exception ex)
                {
                    XuLyLoi.LogError("Error : " + ex.ToString());
                }
            }
        }

        public static DataSet GetDataSet(MDB.MDBConnection Connection)
        {
            string key = Guid.NewGuid().ToString();
            log.LogConfig();
            var timer = new Stopwatch();
            timer.Start();
            log.Info("Begin GetDataSet: '" + key + "'");
            DataSet ds = new DataSet();
            #region
            switch (XemBenhAn._LoaiBenhAnEMR)
            {
                case LoaiBenhAnEMR.Bong:
                    ds = BenhAnBongFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.DaLieu:
                    ds = BenhAnDaLieuFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.HuyetHocTruyenMau:
                    ds = BenhAnHuyetHocTruyenMauFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.MatBanPhanTruoc:
                    ds = BenhAnMatBanPhanTruocFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.MatChanThuong:
                    ds = BenhAnMatChanThuongFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.MatDayMat:
                    ds = BenhAnMatDayMatFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.MatGloCom:
                    ds = BenhAnMatGlocomFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.MatLac:
                    ds = BenhAnMatLacFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.MatTreEm:
                    ds = BenhAnMatTreEmFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiKhoa:
                    ds = BenhAnNgoaiKhoaFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru:
                    ds = BenhAnNgoaiTruFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTruRangHamMat:
                    ds = BenhAnNgoaiTruRangHamMatFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTruTaiMuiHong:
                    ds = BenhAnNgoaiTruTaiMuiHongFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTruYHCT:
                    ds = BenhAnNgoaiTruYHCTFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NoiKhoa:
                    ds = BenhAnNoiKhoaFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NoiTruYHCT:
                    ds = BenhAnNoiTruYHCTFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.PhaThaiI:
                    ds = BenhAnPhaThaiIFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy, XemBenhAn._ThongTinDieuTri.MaBenhNhan);
                    break;
                case LoaiBenhAnEMR.PhaThaiII:
                    ds = BenhAnPhaThaiIIFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy, XemBenhAn._ThongTinDieuTri.MaBenhNhan);
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNang:
                    ds = BenhAnPhucHoiChucNangFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.PhuKhoa:
                    ds = BenhAnPhuKhoaFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.RangHamMat:
                    ds = BenhAnRangHamMatFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.SanKhoa:
                    ds = BenhAnSanKhoaFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.SoSinh:
                    ds = BenhAnSoSinhFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.TaiMuiHong:
                    ds = BenhAnTaiMuiHongFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.TamThan:
                    ds = BenhAnTamThanFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.TruyenNhiem:
                    ds = BenhAnTruyenNhiemFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.TruyenNhiemII:
                    ds = BenhAnTruyenNhiemIIFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.UngBuou:
                    ds = BenhAnUngBuouFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.XaPhuong:
                    ds = BenhAnXaPhuongFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.DieuTriBanNgay:
                    ds = BenhAnDieuTriBanNgayFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.ThanNhanTao:
                    ds = BenhAnThanNhanTaoFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.Mat:
                    ds = BenhAnMatFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTruMat:
                    ds = BenhAnNgoaiTruMatFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.Tim:
                    ds = BenhAnTimFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNangYHCT:
                    ds = BenhAnPhucHoiChucNangYHCTFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.LuuCapCuu:
                    ds = BenhAnLuuCapCuuFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.CMU:
                    ds = BenhAnCMUFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.PhaThaiIII:
                    ds = BenhAnPhaThaiIIIFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.BANgoaTruPK:
                    ds = BANgoaiTruPKFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.TayChanMieng:
                    ds = BenhAnTayChanMiengFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTruPhucHoiChucNang:
                    ds = BenhAnNgoaiTruPHCNFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNangNhi:
                    ds = BenhAnPHCNNhiFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.DaLieuTW:
                    ds = BenhAnDaLieuTWFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.PHCNII:
                    ds = BenhAnPHCNIIFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenThuongThuong:
                    ds = BenhAnNgoaiTru_BenhVayNenThongThuongFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_AVayNen:
                    ds = BenhAnNgoaiTruAVayNenFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_HoTroSinhSan:
                    ds = BenhAnNgoaiTru_HoTroSinhSanFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhAnViemBiCo:
                    ds = BenhAnNgoaiTru_ViemBiCoFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhAnLupusBanDoHeThong:
                    ds = BenhAnNgoaiTru_LupusBanDoHeThongFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_PEMPHIGOID:
                    ds = BenhAnNgoaiTruPemphigoidFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayPhanDoNangLong:
                    ds = BenhAnNgoaiTru_VayPhanDoNangLongFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_LuPusBanDoManTinh:
                    ds = BenhAnNgoaiTru_LuPusBanDoManTinhFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenTheMu:
                    ds = BenhAnNgoaiTru_BenhVayNenTheMuFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_DuhringBrocq:
                    ds = BenhAnNgoaiTruDuhringBrocqFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.DaiThaoDuong:
                    ds = BenhAnDaiThaoDuongFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_UngThuDaHacTo:
                    ds = BenhAnUngThuHacToFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_UngThuDaKhongHacTo:
                    ds = BenhAnUngThuKhongHacToFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_Pemphigus:
                    ds = BenhAnNgoaiTruPemphigusFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenTheKhop:
                    ds = BenhAnVayNenTheKhopFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_HoiChungTrungLap:
                    ds = BenhAnNgoaiTru_HoiChungTrungLapFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.StentDongMachVanh:
                    ds = BenhAnStentDongMachVanhFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.ThieuMauCoTimCucBo:
                    ds = BenhAnThieuMauCoTimCucBoFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhBasedow:
                    ds = BenhAnBenhBaseDowFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.ViemGanBManTinh:
                    ds = BenhAnViemGanBManTinhFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.PhoiTacNghenManTinh:
                    ds = BenhAnPhoiTacNghenManTinhFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                case LoaiBenhAnEMR.BenhTangHuyetAp:
                    ds = BenhAnTangHuyetApFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
                default:
                    ds = BenhAnNhiKhoaFunc.SelectDataSet(Connection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    break;
            }
            #endregion
            timer.Stop();
            log.Info("End GetDataSet: '" + key + "'. Total: " + timer.ElapsedMilliseconds.ToString() + " ms");
            return ds;
        }

    }

    public class MauBaoCao
    {
        #region Mau bao cao theo LoaiBenhAn
        public static XtraReport reportHanhChinh = null;
        public static XtraReport reportHoiBenh = null;
        public static XtraReport reportTongKet = null;
        public static XtraReport reportKhamBenh = null;
        #endregion
        CauHinhVoBenhAnEMR cauHinhVoBenhAnEMR = CauHinhVoBenhAnEMRFunc.GetData(XemBenhAn.MyConnection);
        public MauBaoCao()
        {
            reportHanhChinh = null;
            reportHoiBenh = null;
            reportTongKet = null;
            reportKhamBenh = null;
            #region Chon report theo LoaiBenhAn
            switch (XemBenhAn._LoaiBenhAnEMR)
            {
                case LoaiBenhAnEMR.Bong:
                    reportHanhChinh = new rptBenhAnBong_HanhChinh();
                    reportHoiBenh = new rptBenhAnBong_HoiBenh();
                    reportTongKet = new rptBenhAnBong_TongKet();

                    //reportKhamBenh = new rptBenhAnBong_KhamBenh();
                    break;
                case LoaiBenhAnEMR.DaLieu:
                    reportHanhChinh = new rptBenhAnDaLieu_HanhChinh();
                    reportHoiBenh = new rptBenhAnDaLieu_HoiBenh();
                    reportTongKet = new rptBenhAnDaLieu_TongKet();
                    //reportKhamBenh = new rptBenhAnDaLieu_KhamBenh();
                    break;
                case LoaiBenhAnEMR.HuyetHocTruyenMau:
                    reportHanhChinh = new rptBenhAnHuyetHocTruyenMau_HanhChinh();
                    reportHoiBenh = new rptBenhAnHuyetHocTruyenMau_HoiBenh();
                    reportTongKet = new rptBenhAnHuyetHocTruyenMau_TongKet();
                    //reportKhamBenh = new rptBenhAnHuyetHocTruyenMau_KhamBenh();
                    break;
                case LoaiBenhAnEMR.MatBanPhanTruoc:
                    reportHanhChinh = new rptBenhAnMatBanPhanTruoc_HanhChinh();
                    reportHoiBenh = new rptBenhAnMatBanPhanTruoc_HoiBenh();
                    reportTongKet = new rptBenhAnMatBanPhanTruoc_TongKet();
                    if (cauHinhVoBenhAnEMR.SuDungBenhAnMatCu == 1)
                    {
                        reportHoiBenh = new rptBenhAnMatBanPhanTruoc2_HoiBenh();
                    }
                    //reportKhamBenh = new rptBenhAnMatBanPhanTruoc_KhamBenh();
                    break;
                case LoaiBenhAnEMR.MatChanThuong:
                    reportHanhChinh = new rptBenhAnMatChanThuong_HanhChinh();
                    reportHoiBenh = new rptBenhAnMatChanThuong_HoiBenh();
                    reportTongKet = new rptBenhAnMatChanThuong_TongKet();
                    //reportKhamBenh = new rptBenhAnMatChanThuong_KhamBenh();
                    break;
                case LoaiBenhAnEMR.MatDayMat:
                    reportHanhChinh = new rptBenhAnMatDayMat_HanhChinh();
                    reportHoiBenh = new rptBenhAnMatDayMat_HoiBenh();
                    reportTongKet = new rptBenhAnMatDayMat_TongKet();
                    //reportKhamBenh = new rptBenhAnMatDayMat_KhamBenh();
                    break;
                case LoaiBenhAnEMR.MatGloCom:
                    reportHanhChinh = new rptBenhAnMatGlocom_HanhChinh();
                    reportHoiBenh = new rptBenhAnMatGlocom_HoiBenh();
                    reportTongKet = new rptBenhAnMatGlocom_TongKet();
                    reportKhamBenh = new rptBenhAnMatGlocom_KhamBenh();
                    break;
                case LoaiBenhAnEMR.MatLac:
                    reportHanhChinh = new rptBenhAnMatLac_HanhChinh();
                    reportHoiBenh = new rptBenhAnMatLac_HoiBenh();
                    reportTongKet = new rptBenhAnMatLac_TongKet();
                    //reportKhamBenh = new rptBenhAnMatLac_KhamBenh();
                    break;
                case LoaiBenhAnEMR.MatTreEm:
                    reportHanhChinh = new rptBenhAnMatTreEm_HanhChinh();
                    reportHoiBenh = new rptBenhAnMatTreEm_HoiBenh();
                    reportTongKet = new rptBenhAnMatTreEm_TongKet();
                    if (cauHinhVoBenhAnEMR.SuDungBenhAnMatCu == 1)
                    {
                        reportHoiBenh = new rptBenhAnMatTreEm2_HoiBenh();
                        reportTongKet = new rptBenhAnMatTreEm2_TongKet();
                    } 
                    //reportKhamBenh = new rptBenhAnMatTreEm_KhamBenh();
                    break;
                case LoaiBenhAnEMR.NgoaiKhoa:
                    reportHanhChinh = new rptBenhAnNgoaiKhoa_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiKhoa_HoiBenh();
                    reportTongKet = new rptBenhAnNgoaiKhoa_TongKet();
                    //reportKhamBenh = new rptBenhAnNgoaiKhoa_KhamBenh();
                    break;
                case LoaiBenhAnEMR.NgoaiTru:
                    reportHanhChinh = new rptBenhAnNgoaiTru_HanhChinh();
                    //reportHoiBenh = new rptBenhAnNgoaiTru_HoiBenh();
                    reportTongKet = new rptBenhAnNgoaiTru_TongKet();
                    //reportKhamBenh = new rptBenhAnNgoaiTru_KhamBenh();
                    break;
                case LoaiBenhAnEMR.NgoaiTruRangHamMat:
                    reportHanhChinh = new rptBenhAnNgoaiTruRangHamMat_HanhChinh();
                    //reportHoiBenh = new rptBenhAnNgoaiTruRangHamMat_HoiBenh();
                    reportTongKet = new rptBenhAnNgoaiTruRangHamMat_TongKet();
                    //reportKhamBenh = new rptBenhAnNgoaiTruRangHamMat_KhamBenh();
                    break;
                case LoaiBenhAnEMR.NgoaiTruTaiMuiHong:
                    reportHanhChinh = new rptBenhAnNgoaiTruTaiMuiHong_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruTaiMuiHong_HoiBenh();
                    reportTongKet = new rptBenhAnNgoaiTruTaiMuiHong_TongKet();
                    //reportKhamBenh = new rptBenhAnNgoaiTruTaiMuiHong_KhamBenh();
                    break;
                case LoaiBenhAnEMR.NgoaiTruYHCT:
                    reportHanhChinh = new rptBenhAnNgoaiTruYHCTII_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruYHCT_HoiBenh();
                    reportTongKet = new rptBenhAnNgoaiTruYHCT_TongKet();
                    //reportKhamBenh = new rptBenhAnNgoaiTruYHCT_KhamBenh();
                    break;
                case LoaiBenhAnEMR.NoiKhoa:
                    reportHanhChinh = new rptBenhAnNoiKhoa_HanhChinh();
                    reportHoiBenh = new rptBenhAnNoiKhoa_HoiBenh();
                    reportTongKet = new rptBenhAnNoiKhoa_TongKet();
                    //reportKhamBenh = new rptBenhAnNoiKhoa_KhamBenh();
                    break;
                case LoaiBenhAnEMR.NoiTruYHCT:
                    reportHanhChinh = new rptBenhAnNoiTruYHCT_HanhChinh();
                    reportHoiBenh = new rptBenhAnNoiTruYHCT_HoiBenh();
                    reportTongKet = new rptBenhAnNoiTruYHCT_TongKet();
                    //reportKhamBenh = new rptBenhAnNoiTruYHCT_KhamBenh();
                    break;
                case LoaiBenhAnEMR.PhaThaiI:
                    reportHanhChinh = new rptBenhAnPhaThaiI_HanhChinh();
                    reportHoiBenh = new rptBenhAnPhaThaiI_HoiBenh();
                    reportTongKet = new rptBenhAnPhaThaiI_TongKet();
                    //reportKhamBenh = new rptBenhAnPhaThaiI_KhamBenh();
                    break;
                case LoaiBenhAnEMR.PhaThaiII:
                    reportHanhChinh = new rptBenhAnPhaThaiII_HanhChinh();
                    reportHoiBenh = new rptBenhAnPhaThaiII_HoiBenh();
                    reportTongKet = new rptBenhAnPhaThaiII_TongKet();
                    //reportKhamBenh = new rptBenhAnPhaThaiII_KhamBenh();
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNang:
                    reportHanhChinh = new rptBenhAnPhucHoiChucNang_HanhChinh();
                    reportHoiBenh = new rptBenhAnPhucHoiChucNang_HoiBenh();
                    reportTongKet = new rptBenhAnPhucHoiChucNang_TongKet();
                    //reportKhamBenh = new rptBenhAnPhucHoiChucNang_KhamBenh();
                    break;
                case LoaiBenhAnEMR.PhuKhoa:
                    reportHanhChinh = new rptBenhAnPhuKhoa_HanhChinh();
                    reportHoiBenh = new rptBenhAnPhuKhoa_HoiBenh();
                    reportTongKet = new rptBenhAnPhuKhoa_TongKet();
                    //reportKhamBenh = new rptBenhAnPhuKhoa_KhamBenh();
                    break;
                case LoaiBenhAnEMR.RangHamMat:
                    reportHanhChinh = new rptBenhAnRangHamMat_HanhChinh();
                    reportHoiBenh = new rptBenhAnRangHamMat_HoiBenh();
                    reportTongKet = new rptBenhAnRangHamMat_TongKet();
                    //reportKhamBenh = new rptBenhAnRangHamMat_KhamBenh();
                    break;
                case LoaiBenhAnEMR.SanKhoa:
                    reportHanhChinh = new rptBenhAnSanKhoa_HanhChinh();
                    reportHoiBenh = new rptBenhAnSanKhoa_HoiBenh();
                    reportTongKet = new rptBenhAnSanKhoa_TongKet();
                    //reportKhamBenh = new rptBenhAnSanKhoa_KhamBenh();
                    break;
                case LoaiBenhAnEMR.SoSinh:
                    reportHanhChinh = new rptBenhAnSoSinh_HanhChinh();
                    reportHoiBenh = new rptBenhAnSoSinh_HoiBenh();
                    reportTongKet = new rptBenhAnSoSinh_TongKet();
                    //reportKhamBenh = new rptBenhAnSoSinh_KhamBenh();
                    break;
                case LoaiBenhAnEMR.TaiMuiHong:
                    reportHanhChinh = new rptBenhAnTaiMuiHong_HanhChinh();
                    reportHoiBenh = new rptBenhAnTaiMuiHong_HoiBenh();
                    reportTongKet = new rptBenhAnTaiMuiHong_TongKet();
                    //reportKhamBenh = new rptBenhAnTaiMuiHong_KhamBenh();
                    break;
                case LoaiBenhAnEMR.TamThan:
                    reportHanhChinh = new rptBenhAnTamThan_HanhChinh();
                    reportHoiBenh = new rptBenhAnTamThan_HoiBenh();
                    reportTongKet = new rptBenhAnTamThan_TongKet();
                    //reportKhamBenh = new rptBenhAnTamThan_KhamBenh();
                    break;
                case LoaiBenhAnEMR.TruyenNhiem:
                    reportHanhChinh = new rptBenhAnTruyenNhiem_HanhChinh();
                    reportHoiBenh = new rptBenhAnTruyenNhiem_HoiBenh();
                    reportTongKet = new rptBenhAnTruyenNhiem_TongKet();
                    //reportKhamBenh = new rptBenhAnTruyenNhiem_KhamBenh();
                    break;
                case LoaiBenhAnEMR.TruyenNhiemII:
                    reportHanhChinh = new rptBenhAnTruyenNhiem_HanhChinh();
                    reportHoiBenh = new rptBenhAnTruyenNhiemII_HoiBenh();
                    reportTongKet = new rptBenhAnTruyenNhiem_TongKet();
                    //reportKhamBenh = new rptBenhAnTruyenNhiem_KhamBenh();
                    break;
                case LoaiBenhAnEMR.UngBuou:
                    reportHanhChinh = new rptBenhAnUngBuou_HanhChinh();
                    reportHoiBenh = new rptBenhAnUngBuou_HoiBenh();
                    reportTongKet = new rptBenhAnUngBuou_TongKet();
                    //reportKhamBenh = new rptBenhAnUngBuou_KhamBenh();
                    break;
                case LoaiBenhAnEMR.XaPhuong:
                    reportHanhChinh = new rptBenhAnXaPhuong_HanhChinh();
                    reportHoiBenh = new rptBenhAnXaPhuong_HoiBenh();
                    reportTongKet = new rptBenhAnXaPhuong_TongKet();
                    //reportKhamBenh = new rptBenhAnXaPhuong_KhamBenh();
                    break;
                case LoaiBenhAnEMR.NhiKhoa:
                    reportHanhChinh = new rptBenhAnNhiKhoa_HanhChinh();
                    reportHoiBenh = new rptBenhAnNhiKhoa_HoiBenh();
                    reportTongKet = new rptBenhAnNhiKhoa_TongKet();
                    //reportKhamBenh = new rptBenhAnNhiKhoa_KhamBenh();
                    break;
                case LoaiBenhAnEMR.DieuTriBanNgay:
                    reportHanhChinh = new rptBenhAnDieuTriBanNgay_HanhChinh();
                    reportHoiBenh = new rptBenhAnDieuTriBanNgay_KhamBenh();
                    break;
                case LoaiBenhAnEMR.ThanNhanTao:
                    reportHanhChinh = new rptBenhAnThanNhanTao_HanhChinh();
                    reportHoiBenh = new rptBenhAnThanNhanTao_HoiBenh();
                    reportTongKet = new rptBenhAnThanNhanTao_TongKet();
                    reportKhamBenh = new rptBenhAnThanNhanTao_KhamBenh();
                    break;
                case LoaiBenhAnEMR.Mat:
                    reportHanhChinh = new rptBenhAnMat_HanhChinh();
                    reportHoiBenh = new rptBenhAnMat_HoiBenh();
                    reportTongKet = new rptBenhAnMat_TongKet();
                    reportKhamBenh = new rptBenhAnMat_HoiBenh();
                    break;
                case LoaiBenhAnEMR.NgoaiTruMat:
                    reportHanhChinh = new rptBenhAnNgoaiTruMat_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruMat_HoiBenh();
                    reportTongKet = new rptBenhAnNgoaiTruMat_TongKet();
                    reportKhamBenh = new rptBenhAnNgoaiTruMat_HoiBenh();
                    break;
                case LoaiBenhAnEMR.Tim:
                    reportHanhChinh = new rptBenhAnTim_HanhChinh();
                    reportHoiBenh = new rptBenhAnTim_HoiBenh_KhamBenh();
                    reportKhamBenh = new rptBenhAnTim_HoiBenh_KhamBenh();
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNangYHCT:
                    reportHanhChinh = new rptBenhAnPhucHoiChucNangYHCT_HanhChinh();
                    reportHoiBenh = new rptBenhAnPhucHoiChucNangYHCT_HoiBenh();
                    reportKhamBenh = new rptBenhAnPhucHoiChucNangYHCT_KhamBenh();
                    reportTongKet = new rptBenhAnPhucHoiChucNangYHCT_TongKet();
                    break;
                case LoaiBenhAnEMR.LuuCapCuu:
                    reportHanhChinh = new rptBenhAnLuuCapCuu_HanhChinh();
                    break;
                case LoaiBenhAnEMR.CMU:
                    reportHanhChinh = new rptBenhAnCMU_HanhChinh();
                    reportHoiBenh = new rptBenhAnCMU_HoiBenh();
                    reportKhamBenh = new rptBenhAnCMU_KhamBenh();
                    break;
                case LoaiBenhAnEMR.PhaThaiIII:
                    reportHanhChinh = new rptBenhAnPhaThaiIII_HanhChinh();
                    reportHoiBenh = new rptBenhAnPhaThaiIII_HoiBenh();
                    reportTongKet = new rptBenhAnPhaThaiIII_TongKet();
                    break;
                case LoaiBenhAnEMR.BANgoaTruPK:
                    reportHanhChinh = new rptHanhChinh_BANgoaiTruPK();
                    reportKhamBenh = new rptKhamBenh_BANgoaiTruPK();
                    break;
                case LoaiBenhAnEMR.TayChanMieng:
                    reportHanhChinh = new rptBenhAnTayChanMieng_HanhChinh();
                    reportHoiBenh = new rptBenhAnTayChanMieng_HoiBenh();
                    reportKhamBenh = new rptBenhAnTayChanMieng_KhamBenh();
                    reportTongKet = new rptBenhAnTayChanMieng_TongKet();
                    break;
                // update new benh an here
                case LoaiBenhAnEMR.NgoaiTruPhucHoiChucNang:
                    reportHanhChinh = new rptBenhAnNgoaiTruPHCN_HanhChinh();
                    //reportHoiBenh = new rptBenhAnNgoaiTru_HoiBenh();
                    reportTongKet = new rptBenhAnNgoaiTru_TongKet();
                    //reportKhamBenh = new rptBenhAnNgoaiTru_KhamBenh();
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNangNhi:
                    reportHanhChinh = new rptBenhAnPHCNNhi_HanhChinh();
                    reportHoiBenh = new rptBenhAnPHCNNhi_HoiBenh();
                    reportTongKet = new rptBenhAnPHCNNhi_TongKet();
                    //reportKhamBenh = new rptBenhAnNgoaiTru_KhamBenh();
                    break;
                case LoaiBenhAnEMR.DaLieuTW:
                    reportHanhChinh = new rptBenhAnDaLieuTW_HanhChinh();
                    reportHoiBenh = new rptBenhAnDaLieuTW_HoiBenh();
                    reportTongKet = new rptBenhAnDaLieuTW_TongKet();
                    break;
                case LoaiBenhAnEMR.PHCNII:
                    reportHanhChinh = new rptBenhAnPHCNII_HanhChinh();
                    reportHoiBenh = new rptBenhAnPHCNII_HoiBenh();
                    reportTongKet = new rptBenhAnPHCNII_TongKet();
                    //reportKhamBenh = new rptBenhAnNgoaiTru_KhamBenh();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenThuongThuong:
                    reportHanhChinh = new rptBenhAnNgoaiTruVayNenTheThuongThuong_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruVayNenTheThuongThuong_HoiBenh();
                    reportKhamBenh = new rptBenhAnNgoaiTruVayNenTheThuongThuong_KhamBenh();
                    reportTongKet = new rptBenhAnNgoaiTruVayNenTheThuongThuong_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_AVayNen:
                    reportHanhChinh = new rptBenhAnNgoaiTruAVayNen_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruAVayNen_HoiBenh();
                    reportKhamBenh = new rptBenhAnNgoaiTruAVayNen_KhamBenh();
                    reportTongKet = new rptBenhAnNgoaiTruAVayNen_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_HoTroSinhSan:
                    reportHanhChinh = new rptBenhAnNgoaiTru_HTSS_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTru_HTSS_HoiBenh();
                    reportTongKet = new rptBenhAnNgoaiTru_HTSS_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhAnViemBiCo:
                    reportHanhChinh = new rptBenhAnNgoaiTruViemBiCo_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruViemBiCo_HoiBenh();
                    reportKhamBenh = new rptBenhAnNgoaiTruViemBiCo_KhamBenh();
                    reportTongKet = new rptBenhAnNgoaiTruViemBiCo_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhAnLupusBanDoHeThong:
                    reportHanhChinh = new rptBenhAnNgoaiTruLupusBanDoHeThong_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruLupusBanDoHeThong_HoiBenh();
                    reportKhamBenh = new rptBenhAnNgoaiTruLupusBanDoHeThong_KhamBenh();
                    reportTongKet = new rptBenhAnNgoaiTruLupusBanDoHeThong_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_PEMPHIGOID:
                    reportHanhChinh = new rptBenhAnNgoaiTruPemphigoid_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruPemphigoid_HoiBenh();
                    reportKhamBenh = new rptBenhAnNgoaiTruPemphigoid_KhamBenh();
                    reportTongKet = new rptBenhAnNgoaiTruPemphigoid_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayPhanDoNangLong:
                    reportHanhChinh = new rptBenhAnNgoaiTruVayPhanDoNangLong_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruVayPhanDoNangLong_HoiBenh();
                    reportTongKet = new rptBenhAnNgoaiTruVayPhanDoNangLong_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_LuPusBanDoManTinh:
                    reportHanhChinh = new rptBenhAnNgoaiTruLuPusBanDoManTinh_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruLuPusBanDoManTinh_HoiBenh();
                    reportKhamBenh = new rptBenhAnNgoaiTruLuPusBanDoManTinh_KhamBenh();
                    reportTongKet = new rptBenhAnNgoaiTruLuPusBanDoManTinh_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenTheMu:
                    reportHanhChinh = new rptBenhAnNgoaiTruVayNenTheMu_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruVayNenTheMu_HoiBenh();
                    reportTongKet = new rptBenhAnNgoaiTruVayNenTheMu_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_DuhringBrocq:
                    reportHanhChinh = new rptBenhAnNgoaiTruDuhringBrocq_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruDuhringBrocq_HoiBenh();
                    reportKhamBenh = new rptBenhAnNgoaiTruDuhringBrocq_KhamBenh();
                    reportTongKet = new rptBenhAnNgoaiTruDuhringBrocq_TongKet();
                    break;
                case LoaiBenhAnEMR.DaiThaoDuong:
                    reportHanhChinh = new rptBenhAnDaiThaoDuong_HanhChinh();
                    reportHoiBenh = new rptBenhAnDaiThaoDuong_HoiBenh();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_UngThuDaHacTo:
                    reportHanhChinh = new rptBenhAnUngThuDaHacTo_HanhChinh();
                    reportHoiBenh = new rptBenhAnUngThuDaHacTo_HoiBenh();
                    reportKhamBenh = new rptBenhAnUngThuDaHacTo_KhamBenh();
                    reportTongKet = new rptBenhAnUngThuDaHacTo_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_UngThuDaKhongHacTo:
                    reportHanhChinh = new rptBenhAnUngThuDaKhongHacTo_HanhChinh();
                    reportHoiBenh = new rptBenhAnUngThuDaKhongHacTo_HoiBenh();
                    reportKhamBenh = new rptBenhAnUngThuDaKhongHacTo_KhamBenh();
                    reportTongKet = new rptBenhAnUngThuDaKhongHacTo_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_Pemphigus:
                    reportHanhChinh = new rptBenhAnNgoaiTruPemphigus_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruPemphigus_HoiBenh();
                    reportKhamBenh = new rptBenhAnNgoaiTruPemphigus_KhamBenh();
                    reportTongKet = new rptBenhAnNgoaiTruPemphigus_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenTheKhop:
                    reportHanhChinh = new rptBenhAnNgoaiTruVNTheKhop_HanhChinh();
                    reportHoiBenh = new rptBenhAnNgoaiTruVNTheKhop_HoiBenh();
                    reportKhamBenh = new rptBenhAnNgoaiTruVNTheKhop_KhamBenh();
                    reportTongKet = new rptBenhAnNgoaiTruVNTheKhop_TongKet();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_HoiChungTrungLap:
                    reportHanhChinh = new rptBenhAnHoiChungTrungLap_HanhChinh();
                    reportHoiBenh = new rptBenhAnHoiChungTrungLap_HoiBenh();
                    reportKhamBenh = new rptBenhAnHoiChungTrungLap_KhamBenh();
                    reportTongKet = new rptBenhAnHoiChungTrungLap_TongKet();
                    break;
                case LoaiBenhAnEMR.StentDongMachVanh:
                    reportHanhChinh = new rptBenhAnStentDongMachVanh_HanhChinh();
                    reportHoiBenh = new rptBenhAnStentDongMachVanh_HoiBenh();
                    break;
                case LoaiBenhAnEMR.ThieuMauCoTimCucBo:
                    reportHanhChinh = new rptBenhAnThieuMauCoTimCucBo_HanhChinh();
                    reportHoiBenh = new rptBenhAnThieuMauCoTimCucBo_HoiBenh();
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhBasedow:
                    reportHanhChinh = new rptBenhAnBenhBaseDow_HanhChinh();
                    reportHoiBenh = new rptBenhAnBenhBaseDow_HoiBenh();
                    break;
                case LoaiBenhAnEMR.ViemGanBManTinh:
                    reportHanhChinh = new rptBenhAnViemGanBManTinh_HanhChinh();
                    reportHoiBenh = new rptBenhAnViemGanBManTinh_HoiBenh();
                    break;
                case LoaiBenhAnEMR.PhoiTacNghenManTinh:
                    reportHanhChinh = new rptBenhAnPhoiTacNghenManTinh_HanhChinh();
                    reportHoiBenh = new rptBenhAnPhoiTacNghenManTinh_HoiBenh();
                    break;
                case LoaiBenhAnEMR.BenhTangHuyetAp:
                    reportHanhChinh = new rptBenhAnTangHuyetAp_HanhChinh();
                    reportHoiBenh = new rptBenhAnTangHuyetAp_HoiBenh();
                    break;
                default:
                    break;
            }
            #endregion

            if (reportHanhChinh != null)
                reportHanhChinh.DisplayName = "Hanh_chinh";
            if (reportHoiBenh != null)
                reportHoiBenh.DisplayName = "Hoi_benh";
            if (reportTongKet != null)
                reportTongKet.DisplayName = "Tong_ket";
            if (reportKhamBenh != null)
                reportKhamBenh.DisplayName = "Kham_Benh";
        }
    }

    public class MauUserControl
    {
        static Logger log = LogManager.GetLogger("Log");
        static bool DaConfig = false;
        ControlAPIGetDataBenhAn crtGetDataBenhAn = new ControlAPIGetDataBenhAn();
        //static void LogConfig()
        //{
        //    try
        //    {
        //        if (!DaConfig)
        //        {
        //            var config = new LoggingConfiguration();
        //            var fileTarget = new FileTarget
        //            {
        //                FileName =
        //                    "${basedir}/Log/${date:format=yyyy}${date:format=MM}${date:format=dd}/${logger}.log",
        //                Layout =
        //                    "${date:format=dd/MM/yyyy HH\\:mm\\:ss\\.fff}|${threadid}|${level}|${message}",
        //                ArchiveAboveSize = 1242880,
        //                Encoding = Encoding.UTF8
        //            };
        //            config.AddTarget("file", fileTarget);
        //            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Trace, fileTarget));
        //            LogManager.Configuration = config;
        //            DaConfig = true;
        //        }
        //    }
        //    catch// (Exception ex)
        //    {
        //        //throw ex;
        //    }
        //}

        #region UserControl
        public static UserControl ucHanhChinh { get; set; }
        public static UserControl ucHoiBenh { get; set; }
        public static UserControl ucKhamBenh { get; set; }
        public static UserControl ucTongKet { get; set; }
        #endregion

        public MauUserControl()
        {
            log.LogConfig();
            string key = Guid.NewGuid().ToString();
            ControlAPIThongTinDieuTri crtAPIThongTinDT = new ControlAPIThongTinDieuTri();
            var timer = new Stopwatch();
            var timerlocal = new Stopwatch();
            timer.Start();
            timerlocal.Start();
            ThongTinDieuTri tmp;
            log.Info("*********************************************************Begin get data EMR: '" + key + "'");
            ERMDatabase.FTPImageString = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName), "HinhAnh");
            CauHinhVoBenhAnEMR cauHinhVoBenhAnEMR = CauHinhVoBenhAnEMRFunc.GetData(XemBenhAn.MyConnection);
            try
            {
                log.Info("-----start get thongtindieutri: " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
#if CLOUD

            string ketquaAPI = "";
                ketquaAPI = crtAPIThongTinDT.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(),"");
                tmp = JsonConvert.DeserializeObject<ThongTinDieuTri>(ketquaAPI);
#else

                tmp = ThongTinDieuTriFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                log.Info("-----end get thongtindieutri: " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total: " + timerlocal.ElapsedMilliseconds.ToString() + " ms");
                bool getDuLieuHis = cauHinhVoBenhAnEMR != null && cauHinhVoBenhAnEMR.CapNhatDuLieuTuHis == 1 ? true : false;
                if (tmp.MaQuanLy != 0 && !getDuLieuHis)
                {
                    // TUNGHT is37594 thong tin Trẻ sơ sinh
                    XemBenhAn._ThongTinDieuTri.TreSoSinh_LoaiThai = tmp.TreSoSinh_LoaiThai;
                    XemBenhAn._ThongTinDieuTri.TreSoSinh_GioiTinh = tmp.TreSoSinh_GioiTinh;
                    XemBenhAn._ThongTinDieuTri.TreSoSinh_SongChet = tmp.TreSoSinh_SongChet;
                    XemBenhAn._ThongTinDieuTri.TreSoSinh_DiTat = tmp.TreSoSinh_DiTat;
                    XemBenhAn._ThongTinDieuTri.TreSoSinh_CanNang = tmp.TreSoSinh_CanNang;
                    // mở comment theo yêu cầu của Cảnh
                    XemBenhAn._ThongTinDieuTri.HoSo = tmp.HoSo;

                    XemBenhAn._ThongTinDieuTri.TaiBien = tmp.TaiBien;
                    XemBenhAn._ThongTinDieuTri.BienChung = tmp.BienChung;
                    //XemBenhAn._ThongTinDieuTri.TongSoLanPhauThuat = tmp.TongSoLanPhauThuat;
                    XemBenhAn._ThongTinDieuTri.TongSoNgayDieuTriSauPT = tmp.TongSoNgayDieuTriSauPT;

                    // Lấy lại chẩn đoán thay đổi từ HIS truyền sang: DuyNV, trường hợp uncheck cập nhật dữ liệu từ his, lấy lại từ db
                    if (!string.IsNullOrEmpty(tmp.ChanDoan_NoiChuyenDen))
                        XemBenhAn._ThongTinDieuTri.ChanDoan_NoiChuyenDen = tmp.ChanDoan_NoiChuyenDen;
                    if (!string.IsNullOrEmpty(tmp.MaICD_NoiChuyenDen))
                        XemBenhAn._ThongTinDieuTri.MaICD_NoiChuyenDen = tmp.MaICD_NoiChuyenDen;
                    if (!string.IsNullOrEmpty(tmp.ChanDoan_KKB_CapCuu))
                        XemBenhAn._ThongTinDieuTri.ChanDoan_KKB_CapCuu = tmp.ChanDoan_KKB_CapCuu;
                    if (!string.IsNullOrEmpty(tmp.MaICD_KKB_CapCuu))
                        XemBenhAn._ThongTinDieuTri.MaICD_KKB_CapCuu = tmp.MaICD_KKB_CapCuu;
                    if (!string.IsNullOrEmpty(tmp.ChanDoan_KhiVaoKhoaDieuTri))
                        XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri = tmp.ChanDoan_KhiVaoKhoaDieuTri;
                    if (!string.IsNullOrEmpty(tmp.MaICD_KhiVaoKhoaDieuTri))
                        XemBenhAn._ThongTinDieuTri.MaICD_KhiVaoKhoaDieuTri = tmp.MaICD_KhiVaoKhoaDieuTri;
                    if (!string.IsNullOrEmpty(tmp.BenhChinh_RaVien))
                        XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien = tmp.BenhChinh_RaVien;
                    if (!string.IsNullOrEmpty(tmp.MaICD_BenhChinh_RaVien))
                        XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien = tmp.MaICD_BenhChinh_RaVien;
                    if (!string.IsNullOrEmpty(tmp.NguyenNhan_BenhChinh_RaVien))
                        XemBenhAn._ThongTinDieuTri.NguyenNhan_BenhChinh_RaVien = tmp.NguyenNhan_BenhChinh_RaVien;
                    if (!string.IsNullOrEmpty(tmp.MaICD_NguyenNhan_BenhChinh_RV))
                        XemBenhAn._ThongTinDieuTri.MaICD_NguyenNhan_BenhChinh_RV = tmp.MaICD_NguyenNhan_BenhChinh_RV;
                    if (!string.IsNullOrEmpty(tmp.BenhKemTheo_RaVien))
                        XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien = tmp.BenhKemTheo_RaVien;
                    if (!string.IsNullOrEmpty(tmp.MaICD_BenhKemTheo_RaVien))
                        XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien = tmp.MaICD_BenhKemTheo_RaVien;
                    if (!string.IsNullOrEmpty(tmp.BenhKemTheo_RaVien1))
                        XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien1 = tmp.BenhKemTheo_RaVien1;
                    if (!string.IsNullOrEmpty(tmp.MaICD_BenhKemTheo_RaVien1))
                        XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien1 = tmp.MaICD_BenhKemTheo_RaVien1;
                    if (!string.IsNullOrEmpty(tmp.BenhKemTheo_RaVien2))
                        XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien2 = tmp.BenhKemTheo_RaVien2;
                    if (!string.IsNullOrEmpty(tmp.MaICD_BenhKemTheo_RaVien2))
                        XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien2 = tmp.MaICD_BenhKemTheo_RaVien2;
                    if (!string.IsNullOrEmpty(tmp.ChanDoanTruocPhauThuat))
                        XemBenhAn._ThongTinDieuTri.ChanDoanTruocPhauThuat = tmp.ChanDoanTruocPhauThuat;
                    if (!string.IsNullOrEmpty(tmp.MaICD_ChanDoanTruocPhauThuat))
                        XemBenhAn._ThongTinDieuTri.MaICD_ChanDoanTruocPhauThuat = tmp.MaICD_ChanDoanTruocPhauThuat;
                    if (!string.IsNullOrEmpty(tmp.ChanDoanSauPhauThuat))
                        XemBenhAn._ThongTinDieuTri.ChanDoanSauPhauThuat = tmp.ChanDoanSauPhauThuat;
                    if (!string.IsNullOrEmpty(tmp.MaICD_ChanDoanSauPhauThuat))
                        XemBenhAn._ThongTinDieuTri.MaICD_ChanDoanSauPhauThuat = tmp.MaICD_ChanDoanSauPhauThuat;

                    // fix http://redmine.vietsens.vn/redmine/issues/34756
                    //XemBenhAn._ThongTinDieuTri.ChanDoanTruocPhauThuat = tmp.ChanDoanTruocPhauThuat;
                    //XemBenhAn._ThongTinDieuTri.ChanDoanSauPhauThuat = tmp.ChanDoanSauPhauThuat;
                    XemBenhAn._ThongTinDieuTri.KetQuaDieuTri = tmp.KetQuaDieuTri == XemBenhAn._ThongTinDieuTri.KetQuaDieuTri ? XemBenhAn._ThongTinDieuTri.KetQuaDieuTri : XemBenhAn._ThongTinDieuTri.KetQuaDieuTri;
                    if (!XemBenhAn.IsHis2)
                    {
                        XemBenhAn._ThongTinDieuTri.GiaiPhauBenh = tmp.GiaiPhauBenh;
                    }
                    //https://redmine.vietsens.vn/redmine/issues/54207
                    //XemBenhAn._ThongTinDieuTri.NguyenNhanChinhTuVong = tmp.NguyenNhanChinhTuVong;
                    //XemBenhAn._ThongTinDieuTri.LyDoTuVong = tmp.LyDoTuVong;
                    //XemBenhAn._ThongTinDieuTri.ThoiGianTuVong = tmp.ThoiGianTuVong;
                    //XemBenhAn._ThongTinDieuTri.NgayTuVong = tmp.NgayTuVong;
                    //XemBenhAn._ThongTinDieuTri.KhamNghiemTuThi = tmp.KhamNghiemTuThi;
                    //XemBenhAn._ThongTinDieuTri.ChanDoanGiaiPhauTuThi = tmp.ChanDoanGiaiPhauTuThi;
                    XemBenhAn._ThongTinDieuTri.LyDoTaiBienBienChung = tmp.LyDoTaiBienBienChung;
                    //-------------
                    XemBenhAn._ThongTinDieuTri.YHCT_BatCuong = tmp.YHCT_BatCuong;
                    XemBenhAn._ThongTinDieuTri.YHCT_BenhDanh = tmp.YHCT_BenhDanh;
                    XemBenhAn._ThongTinDieuTri.YHCT_TangPhu = tmp.YHCT_TangPhu;
                    XemBenhAn._ThongTinDieuTri.YHCT_KinhMach = tmp.YHCT_KinhMach;
                    XemBenhAn._ThongTinDieuTri.YHCT_NguyenNhan = tmp.YHCT_NguyenNhan;
                    XemBenhAn._ThongTinDieuTri.YHCT_ChuanDoanaRaVien = tmp.YHCT_ChuanDoanaRaVien;
                    XemBenhAn._ThongTinDieuTri.ChanDoan_YHCT = tmp.ChanDoan_YHCT;
                    XemBenhAn._ThongTinDieuTri.sYHCT_BatCuongID = tmp.sYHCT_DinhViBenhID;
                    XemBenhAn._ThongTinDieuTri.sYHCT_TangPhuID = tmp.sYHCT_DinhViBenhID;
                    XemBenhAn._ThongTinDieuTri.sYHCT_KinhMachID = tmp.sYHCT_DinhViBenhID;
                    XemBenhAn._ThongTinDieuTri.sYHCT_DinhViBenhID = tmp.sYHCT_DinhViBenhID;
                    XemBenhAn._ThongTinDieuTri.sYHCT_NguyenNhanID = tmp.sYHCT_NguyenNhanID;
                    XemBenhAn._ThongTinDieuTri.NgayThangNamTrangBia = DateTime.Now;
                    //
                    if (string.IsNullOrEmpty(XemBenhAn._ThongTinDieuTri.YHHD_BenhKemTheo))
                        XemBenhAn._ThongTinDieuTri.YHHD_BenhKemTheo = tmp.YHHD_BenhKemTheo;// == XemBenhAn._ThongTinDieuTri.YHHD_BenhKemTheo ? XemBenhAn._ThongTinDieuTri.YHHD_BenhKemTheo : XemBenhAn._ThongTinDieuTri.YHHD_BenhKemTheo;
                    //XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien = tmp.BenhKemTheo_RaVien;// == XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien ? XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien : XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                    XemBenhAn._ThongTinDieuTri.TenVienChuyenBenhNhanDen = tmp.TenVienChuyenBenhNhanDen == XemBenhAn._ThongTinDieuTri.TenVienChuyenBenhNhanDen ? XemBenhAn._ThongTinDieuTri.TenVienChuyenBenhNhanDen : XemBenhAn._ThongTinDieuTri.TenVienChuyenBenhNhanDen;
                    if (string.IsNullOrEmpty(XemBenhAn._ThongTinDieuTri.YHHD_BenhChinh))
                        XemBenhAn._ThongTinDieuTri.YHHD_BenhChinh = tmp.YHHD_BenhChinh;
                    if (string.IsNullOrEmpty(XemBenhAn._ThongTinDieuTri.ChanDoanKKBYHHD))
                        XemBenhAn._ThongTinDieuTri.ChanDoanKKBYHHD = tmp.ChanDoanKKBYHHD;
                    if(string.IsNullOrEmpty(XemBenhAn._ThongTinDieuTri.YHHD_NoiDieuTri))
                        XemBenhAn._ThongTinDieuTri.YHHD_NoiDieuTri = tmp.YHHD_NoiDieuTri;
                    if (string.IsNullOrEmpty(XemBenhAn._ThongTinDieuTri.YHCT_NoiDieuTri))
                        XemBenhAn._ThongTinDieuTri.YHCT_NoiDieuTri = tmp.YHCT_NoiDieuTri;
                    XemBenhAn._ThongTinDieuTri.ChanDoanKKBYHCT = tmp.ChanDoanKKBYHCT;
                    XemBenhAn._ThongTinDieuTri.YHCT_ChuanDoanaRaVien = tmp.YHCT_ChuanDoanaRaVien;
                    XemBenhAn._ThongTinDieuTri.NguyenNhan_BenhChinh_RaVien = tmp.NguyenNhan_BenhChinh_RaVien;
                    // fix http://redmine.vietsens.vn/redmine/issues/34756
                    //XemBenhAn._ThongTinDieuTri.ChanDoanTruocPhauThuat = tmp.ChanDoanTruocPhauThuat;
                    //XemBenhAn._ThongTinDieuTri.ChanDoanSauPhauThuat = tmp.ChanDoanSauPhauThuat;
                    XemBenhAn._ThongTinDieuTri.VaoVienDoBenhNayLanThu = tmp.VaoVienDoBenhNayLanThu;
                    
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }

            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.DieuTriBanNgay)
            {
                ucHanhChinh = new HanhChinh_DieuTriBanNgay();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.ThanNhanTao)
            {
                ucHanhChinh = new HanhChinh_ThanNhanTao();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NoiTruYHCT)
            {
                ucHanhChinh = new HanhChinh_NoiTruYHCT();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruYHCT)
            {
                ucHanhChinh = new HanhChinh_NgoaiTruYHCT();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NhiKhoa)
            {
                ucHanhChinh = new HanhChinh_NhiKhoa();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.SoSinh)
            {
                ucHanhChinh = new HanhChinh_Sosinh();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.SanKhoa)
            {
                ucHanhChinh = new HanhChinh_SanKhoa();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.CMU)
            {
                ucHanhChinh = new HanhChinh_CMU();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.BANgoaTruPK)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruPK();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.TayChanMieng)
            {
                ucHanhChinh = new HanhChinh_NhiKhoa();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruPhucHoiChucNang)
            {
                ucHanhChinh = new HanhChinh_NgoaiTruPHCN();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.PhucHoiChucNangNhi)
            {
                ucHanhChinh = new HanhChinh_PHCNNhi();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.DaLieuTW)
            {
                ucHanhChinh = new HanhChinh_DaLieuTW();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.PHCNII)
            {
                ucHanhChinh = new HanhChinh_PHCNII();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayNenThuongThuong)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_AVayNen)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_HoTroSinhSan)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruHoTroSinhSan();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_BenhAnViemBiCo)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_BenhAnLupusBanDoHeThong)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_PEMPHIGOID)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayPhanDoNangLong)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_LuPusBanDoManTinh)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayNenTheMu)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_DuhringBrocq)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_UngThuDaHacTo)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_UngThuDaKhongHacTo)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_Pemphigus)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayNenTheKhop)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_HoiChungTrungLap)
            {
                ucHanhChinh = new HanhChinh_BANgoaiTruDaLieuUserControl();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.StentDongMachVanh)
            {
                ucHanhChinh = new HanhChinh_BenhAnStentDongMachVanh();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.ThieuMauCoTimCucBo)
            {
                ucHanhChinh = new HanhChinh_BenhAnThieuMauCoTimCucBo();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_BenhBasedow)
            {
                ucHanhChinh = new HanhChinh_BenhAnBenhBasedow();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.ViemGanBManTinh)
            {
                ucHanhChinh = new HanhChinh_BenhViemGanSieuViBManTinh();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.PhoiTacNghenManTinh)
            {
                ucHanhChinh = new HanhChinh_BenhAnPhoiTacNghenManTinh();
            }
            else if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.BenhTangHuyetAp)
            {
                ucHanhChinh = new HanhChinh_BenhAnTangHuyetAp();
            }
            else
            {
                ucHanhChinh = new HanhChinh_Base();
            }
            timerlocal.Restart();

            if (XemBenhAn._LoaiBenhAnEMR > 0)
                log.Info("--------start get thongtinbenhan: " + XemBenhAn._LoaiBenhAnEMR.Description() + " " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
            switch (XemBenhAn._LoaiBenhAnEMR)
            {
                case LoaiBenhAnEMR.NoiKhoa:
                    XemBenhAn.BenhAn = LoadBenhAnNoiKhoa();
                    HoiBenh_NoiKhoaUserControl hbNoiKhoa = new HoiBenh_NoiKhoaUserControl();
                    KhamBenh_NoiKhoaUserControl kbNoiKhoa = new KhamBenh_NoiKhoaUserControl();
                    TongKet_NoiKhoaUserControl tkNoiKhoa = new TongKet_NoiKhoaUserControl();
                    ucHoiBenh = hbNoiKhoa;
                    ucKhamBenh = kbNoiKhoa;
                    ucTongKet = tkNoiKhoa;
                    break;
                case LoaiBenhAnEMR.NhiKhoa:
                    XemBenhAn.BenhAn = LoadBenhAnNhiKhoa();
                    HoiBenh_NhiKhoaUserControl hbNhiKhoa = new HoiBenh_NhiKhoaUserControl();
                    KhamBenh_NhiKhoaUserControl kbNhiKhoa = new KhamBenh_NhiKhoaUserControl();
                    TongKet_NhiKhoaUserControl tkNhiKhoa = new TongKet_NhiKhoaUserControl();
                    ucHoiBenh = hbNhiKhoa;
                    ucKhamBenh = kbNhiKhoa;
                    ucTongKet = tkNhiKhoa;
                    break;
                case LoaiBenhAnEMR.TruyenNhiem:
                    XemBenhAn.BenhAn = LoadBenhAnTruyenNhiem();
                    HoiBenh_TruyenNhiemUserControl hbTruyenNhiem = new HoiBenh_TruyenNhiemUserControl();
                    KhamBenh_TruyenNhiemUserControl kbTruyenNhiem = new KhamBenh_TruyenNhiemUserControl();
                    TongKet_TruyenNhiemUserControl tkTruyenNhiem = new TongKet_TruyenNhiemUserControl();
                    ucHoiBenh = hbTruyenNhiem;
                    ucKhamBenh = kbTruyenNhiem;
                    ucTongKet = tkTruyenNhiem;
                    break;
                case LoaiBenhAnEMR.TruyenNhiemII:
                    XemBenhAn.BenhAn = LoadBenhAnTruyenNhiemII();
                    HoiBenh_TruyenNhiemIIUserControl hbTruyenNhiemII = new HoiBenh_TruyenNhiemIIUserControl();
                    KhamBenh_TruyenNhiemUserControl kbTruyenNhiemII = new KhamBenh_TruyenNhiemUserControl();
                    TongKet_TruyenNhiemUserControl tkTruyenNhiemII = new TongKet_TruyenNhiemUserControl();
                    ucHoiBenh = hbTruyenNhiemII;
                    ucKhamBenh = kbTruyenNhiemII;
                    ucTongKet = tkTruyenNhiemII;
                    break;
                case LoaiBenhAnEMR.PhuKhoa:
                    XemBenhAn.BenhAn = LoadBenhAnPhuKhoa();
                    HoiBenh_PhuKhoaUserControl hbPhuKhoa = new HoiBenh_PhuKhoaUserControl();
                    KhamBenh_PhuKhoaUserControl kbPhuKhoa = new KhamBenh_PhuKhoaUserControl();
                    TongKet_PhuKhoaUserControl tkPhuKhoa = new TongKet_PhuKhoaUserControl();
                    ucHoiBenh = hbPhuKhoa;
                    ucKhamBenh = kbPhuKhoa;
                    ucTongKet = tkPhuKhoa;
                    break;
                case LoaiBenhAnEMR.SanKhoa:
                    XemBenhAn.BenhAn = LoadBenhAnSanKhoa();
                    HoiBenh_SanKhoaUserControl hbSanKhoa = new HoiBenh_SanKhoaUserControl();
                    KhamBenh_SanKhoaUserControl kbSanKhoa = new KhamBenh_SanKhoaUserControl();
                    TongKet_SanKhoaUserControl tkSanKhoa = new TongKet_SanKhoaUserControl();
                    ucHoiBenh = hbSanKhoa;
                    ucKhamBenh = kbSanKhoa;
                    ucTongKet = tkSanKhoa;
                    break;
                case LoaiBenhAnEMR.SoSinh:
                    XemBenhAn.BenhAn = LoadBenhAnSoSinh();
                    HoiBenh_SoSinhUserControl hbSoSinh = new HoiBenh_SoSinhUserControl();
                    KhamBenh_SoSinhUserControl kbSoSinh = new KhamBenh_SoSinhUserControl();
                    TongKet_SoSinhUserControl tkSoSinh = new TongKet_SoSinhUserControl();
                    ucHoiBenh = hbSoSinh;
                    ucKhamBenh = kbSoSinh;
                    ucTongKet = tkSoSinh;
                    break;
                case LoaiBenhAnEMR.TamThan:
                    XemBenhAn.BenhAn = LoadBenhAnTamThan();
                    HoiBenh_TamThanUserControl hbTamThan = new HoiBenh_TamThanUserControl();
                    KhamBenh_TamThanUserControl kbTamThan = new KhamBenh_TamThanUserControl();
                    TongKet_TamThanUserControl tkTamThan = new TongKet_TamThanUserControl();
                    ucHoiBenh = hbTamThan;
                    ucKhamBenh = kbTamThan;
                    ucTongKet = tkTamThan;
                    break;
                case LoaiBenhAnEMR.DaLieu:
                    XemBenhAn.BenhAn = LoadBenhAnDaLieu();
                    HoiBenh_DaLieuUserControl hbDaLieu = new HoiBenh_DaLieuUserControl();
                    KhamBenh_DaLieuUserControl kbDaLieu = new KhamBenh_DaLieuUserControl();
                    TongKet_DaLieuUserControl tkDaLieu = new TongKet_DaLieuUserControl();
                    ucHoiBenh = hbDaLieu;
                    ucKhamBenh = kbDaLieu;
                    ucTongKet = tkDaLieu;
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNang:
                    XemBenhAn.BenhAn = LoadBenhAnPHCN();
                    HoiBenh_PhucHoiChucNangUserControl hbPhucHoiChucNang = new HoiBenh_PhucHoiChucNangUserControl();
                    KhamBenh_PhucHoiChucNangUserControl kbPhucHoiChucNang = new KhamBenh_PhucHoiChucNangUserControl();
                    TongKet_PhucHoiChucNangUserControl tkPhucHoiChucNang = new TongKet_PhucHoiChucNangUserControl();
                    ucHoiBenh = hbPhucHoiChucNang;
                    ucKhamBenh = kbPhucHoiChucNang;
                    ucTongKet = tkPhucHoiChucNang;
                    break;
                case LoaiBenhAnEMR.HuyetHocTruyenMau:
                    XemBenhAn.BenhAn = LoadBenhAnHHTM();
                    HoiBenh_HuyetHocTruyenMauUserControl hbHuyetHocTruyenMau = new HoiBenh_HuyetHocTruyenMauUserControl();
                    KhamBenh_HuyetHocTruyenMauUserControl kbHuyetHocTruyenMau = new KhamBenh_HuyetHocTruyenMauUserControl();
                    TongKet_HuyetHocTruyenMauUserControl tkHuyetHocTruyenMau = new TongKet_HuyetHocTruyenMauUserControl();
                    ucHoiBenh = hbHuyetHocTruyenMau;
                    ucKhamBenh = kbHuyetHocTruyenMau;
                    ucTongKet = tkHuyetHocTruyenMau;
                    break;
                case LoaiBenhAnEMR.NgoaiKhoa:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiKhoa();
                    HoiBenh_NgoaiKhoaUserControl hbNgoaiKhoa = new HoiBenh_NgoaiKhoaUserControl();
                    KhamBenh_NgoaiKhoaUserControl kbNgoaiKhoa = new KhamBenh_NgoaiKhoaUserControl();
                    TongKet_NgoaiKhoaUserControl tkNgoaiKhoa = new TongKet_NgoaiKhoaUserControl();
                    ucHoiBenh = hbNgoaiKhoa;
                    ucKhamBenh = kbNgoaiKhoa;
                    ucTongKet = tkNgoaiKhoa;
                    break;
                case LoaiBenhAnEMR.Bong:
                    XemBenhAn.BenhAn = LoadBenhAnBong();
                    HoiBenh_BongUserControl hbBong = new HoiBenh_BongUserControl();
                    KhamBenh_BongUserControl kbBong = new KhamBenh_BongUserControl();
                    TongKet_BongUserControl tkBong = new TongKet_BongUserControl();
                    ucHoiBenh = hbBong;
                    ucKhamBenh = kbBong;
                    ucTongKet = tkBong;
                    break;
                case LoaiBenhAnEMR.UngBuou:
                    XemBenhAn.BenhAn = LoadBenhAnUngBuou();
                    HoiBenh_UngBuouUserControl hbUngBuou = new HoiBenh_UngBuouUserControl();
                    KhamBenh_UngBuouUserControl kbUngBuou = new KhamBenh_UngBuouUserControl();
                    TongKet_UngBuouUserControl tkUngBuou = new TongKet_UngBuouUserControl();
                    ucHoiBenh = hbUngBuou;
                    ucKhamBenh = kbUngBuou;
                    ucTongKet = tkUngBuou;
                    break;
                case LoaiBenhAnEMR.RangHamMat:
                    XemBenhAn.BenhAn = LoadBenhAnRHM();
                    HoiBenh_RangHamMatUserControl hbRangHamMat = new HoiBenh_RangHamMatUserControl();
                    KhamBenh_RangHamMatUserControl kbRangHamMat = new KhamBenh_RangHamMatUserControl();
                    TongKet_RangHamMatUserControl tkRangHamMat = new TongKet_RangHamMatUserControl();
                    ucHoiBenh = hbRangHamMat;
                    ucKhamBenh = kbRangHamMat;
                    ucTongKet = tkRangHamMat;
                    break;
                case LoaiBenhAnEMR.TaiMuiHong:
                    XemBenhAn.BenhAn = LoadBenhAnTMH();
                    HoiBenh_TaiMuiHongUserControl hbTaiMuiHong = new HoiBenh_TaiMuiHongUserControl();
                    KhamBenh_TaiMuiHongUserControl kbTaiMuiHong = new KhamBenh_TaiMuiHongUserControl();
                    TongKet_TaiMuiHongUserControl tkTaiMuiHong = new TongKet_TaiMuiHongUserControl();
                    ucHoiBenh = hbTaiMuiHong;
                    ucKhamBenh = kbTaiMuiHong;
                    ucTongKet = tkTaiMuiHong;
                    break;
                case LoaiBenhAnEMR.NgoaiTru:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTru();
                    HoiBenh_NgoaiTruUserControl hbNgoaiTru = new HoiBenh_NgoaiTruUserControl();
                    KhamBenh_NgoaiTruUserControl kbNgoaiTru = new KhamBenh_NgoaiTruUserControl();
                    TongKet_NgoaiTruUserControl tkNgoaiTru = new TongKet_NgoaiTruUserControl();
                    ucHoiBenh = hbNgoaiTru;
                    ucKhamBenh = kbNgoaiTru;
                    ucTongKet = tkNgoaiTru;
                    break;
                case LoaiBenhAnEMR.NgoaiTruRangHamMat:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTruRHM();
                    HoiBenh_NgoaiTruRangHamMatUserControl hbNgoaiTruRangHamMat = new HoiBenh_NgoaiTruRangHamMatUserControl();
                    KhamBenh_NgoaiTruRangHamMatUserControl kbNgoaiTruRangHamMat = new KhamBenh_NgoaiTruRangHamMatUserControl();
                    TongKet_NgoaiTruRangHamMatUserControl tkNgoaiTruRangHamMat = new TongKet_NgoaiTruRangHamMatUserControl();
                    ucHoiBenh = hbNgoaiTruRangHamMat;
                    ucKhamBenh = kbNgoaiTruRangHamMat;
                    ucTongKet = tkNgoaiTruRangHamMat;
                    break;
                case LoaiBenhAnEMR.NgoaiTruTaiMuiHong:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTruTMH();
                    HoiBenh_NgoaiTruTaiMuiHongUserControl hbNgoaiTruTaiMuiHong = new HoiBenh_NgoaiTruTaiMuiHongUserControl();
                    KhamBenh_NgoaiTruTaiMuiHongUserControl kbNgoaiTruTaiMuiHong = new KhamBenh_NgoaiTruTaiMuiHongUserControl();
                    TongKet_NgoaiTruTaiMuiHongUserControl tkNgoaiTruTaiMuiHong = new TongKet_NgoaiTruTaiMuiHongUserControl();
                    ucHoiBenh = hbNgoaiTruTaiMuiHong;
                    ucKhamBenh = kbNgoaiTruTaiMuiHong;
                    ucTongKet = tkNgoaiTruTaiMuiHong;
                    break;
                case LoaiBenhAnEMR.XaPhuong:
                    XemBenhAn.BenhAn = LoadBenhAnXaPhuong();
                    HoiBenh_XaPhuongUserControl hbXaPhuong = new HoiBenh_XaPhuongUserControl();
                    KhamBenh_XaPhuongUserControl kbXaPhuong = new KhamBenh_XaPhuongUserControl();
                    TongKet_XaPhuongUserControl tkXaPhuong = new TongKet_XaPhuongUserControl();
                    ucHoiBenh = hbXaPhuong;
                    ucKhamBenh = kbXaPhuong;
                    ucTongKet = tkXaPhuong;
                    break;
                case LoaiBenhAnEMR.MatLac:
                    XemBenhAn.BenhAn = LoadBenhAnMatLac();
                    HoiBenh_MatLacUserControl hbMatLac = new HoiBenh_MatLacUserControl();
                    KhamBenh_MatLacUserControl kbMatLac = new KhamBenh_MatLacUserControl();
                    TongKet_MatLacUserControl tkMatLac = new TongKet_MatLacUserControl();
                    ucHoiBenh = hbMatLac;
                    ucKhamBenh = kbMatLac;
                    ucTongKet = tkMatLac;
                    break;
                case LoaiBenhAnEMR.MatTreEm:
                    XemBenhAn.BenhAn = LoadBenhAnMatTreem();
                    HoiBenh_MatTreEmUserControl hbMatTreEm = new HoiBenh_MatTreEmUserControl();
                    KhamBenh_MatTreEmUserControl kbMatTreEm = new KhamBenh_MatTreEmUserControl();
                    TongKet_MatTreEmUserControl tkMatTreEm = new TongKet_MatTreEmUserControl();

                    ucHoiBenh = hbMatTreEm;
                    ucKhamBenh = kbMatTreEm;
                    ucTongKet = tkMatTreEm;
                    if (cauHinhVoBenhAnEMR.SuDungBenhAnMatCu == 1)
                    {
                        KhamBenh_MatTreEm2UserControl kbMatTreEm2 = new KhamBenh_MatTreEm2UserControl();
                        TongKet_MatTreEm2UserControl tkMatTreEm2 = new TongKet_MatTreEm2UserControl();
                        ucKhamBenh = kbMatTreEm2;
                        ucTongKet = tkMatTreEm2;
                    }
                    break;
                case LoaiBenhAnEMR.MatGloCom:
                    XemBenhAn.BenhAn = LoadBenhAnMatGlocom();
                    HoiBenh_MatGlocomUserControl hbMatGlocom = new HoiBenh_MatGlocomUserControl();
                    KhamBenh_MatGlocomUserControl kbMatGlocom = new KhamBenh_MatGlocomUserControl();
                    TongKet_MatGlocomUserControl tkMatGlocom = new TongKet_MatGlocomUserControl();
                    ucHoiBenh = hbMatGlocom;
                    ucKhamBenh = kbMatGlocom;
                    ucTongKet = tkMatGlocom;
                    break;
                case LoaiBenhAnEMR.MatDayMat:
                    XemBenhAn.BenhAn = LoadBenhAnMatDayMat();
                    HoiBenh_MatDayMatUserControl hbMatDayMat = new HoiBenh_MatDayMatUserControl();
                    KhamBenh_MatDayMatUserControl kbMatDayMat = new KhamBenh_MatDayMatUserControl();
                    TongKet_MatDayMatUserControl tkMatDayMat = new TongKet_MatDayMatUserControl();
                    ucHoiBenh = hbMatDayMat;
                    ucKhamBenh = kbMatDayMat;
                    ucTongKet = tkMatDayMat;
                    break;
                case LoaiBenhAnEMR.MatChanThuong:
                    XemBenhAn.BenhAn = LoadBenhAnMatChanThuong();
                    HoiBenh_MatChanThuongUserControl hbMatChanThuong = new HoiBenh_MatChanThuongUserControl();
                    KhamBenh_MatChanThuongUserControl kbMatChanThuong = new KhamBenh_MatChanThuongUserControl();
                    TongKet_MatChanThuongUserControl tkMatChanThuong = new TongKet_MatChanThuongUserControl();
                    ucHoiBenh = hbMatChanThuong;
                    ucKhamBenh = kbMatChanThuong;
                    ucTongKet = tkMatChanThuong;
                    break;
                case LoaiBenhAnEMR.MatBanPhanTruoc:
                    XemBenhAn.BenhAn = LoadBenhAnMatBanPhanTruoc();
                    KhamBenh_MatBanPhanTruoc_TongUserControl hbMatBanPhanTruoc = new KhamBenh_MatBanPhanTruoc_TongUserControl();
                    KhamBenh_MatBanPhanTruoc2UserControl kbMatBanPhanTruoc = new KhamBenh_MatBanPhanTruoc2UserControl();
                    TongKet_MatBanPhanTruocUserControl tkMatBanPhanTruoc = new TongKet_MatBanPhanTruocUserControl();
                    ucHoiBenh = hbMatBanPhanTruoc;
                    ucKhamBenh = kbMatBanPhanTruoc;
                    ucTongKet = tkMatBanPhanTruoc;
                    if (cauHinhVoBenhAnEMR.SuDungBenhAnMatCu == 1)
                    {
                        KhamBenh_MatBanPhanTruoc3UserControl kbMatBanPhanTruoc3 = new KhamBenh_MatBanPhanTruoc3UserControl();
                        ucKhamBenh = kbMatBanPhanTruoc3;
                    }
                    break;
                case LoaiBenhAnEMR.NoiTruYHCT:
                    XemBenhAn.BenhAn = LoadBenhAnNoiTruYHCT();
                    HoiBenh_NoiTruYHCTUserControl hbNoiTruYHCT = new HoiBenh_NoiTruYHCTUserControl();
                    KhamBenh_NoiTruYHCT_TongUserControl kbNoiTruYHCT = new KhamBenh_NoiTruYHCT_TongUserControl();
                    TongKet_NoiTruYHCTUserControl tkNoiTruYHCT = new TongKet_NoiTruYHCTUserControl();
                    ucHoiBenh = hbNoiTruYHCT;
                    ucKhamBenh = kbNoiTruYHCT;
                    ucTongKet = tkNoiTruYHCT;
                    break;
                case LoaiBenhAnEMR.NgoaiTruYHCT:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTruYHCT();
                    HoiBenh_NgoaiTruYHCTUserControl hbNgoaiTruYHCT = new HoiBenh_NgoaiTruYHCTUserControl();
                    KhamBenh_NgoaiTruYHCTUserControl kbNgoaiTruYHCT = new KhamBenh_NgoaiTruYHCTUserControl();
                    TongKet_NgoaiTruYHCTUserControl tkNgoaiTruYHCT = new TongKet_NgoaiTruYHCTUserControl();
                    ucHoiBenh = hbNgoaiTruYHCT;
                    ucKhamBenh = kbNgoaiTruYHCT;
                    ucTongKet = tkNgoaiTruYHCT;
                    break;
                case LoaiBenhAnEMR.PhaThaiI:
                    XemBenhAn.BenhAn = LoadBenhAnPhaThaiI();
                    HoiBenh_PhaThaiIUserControl hbPhaThaiI = new HoiBenh_PhaThaiIUserControl();
                    KhamBenh_PhaThaiIUserControl kbPhaThaiI = new KhamBenh_PhaThaiIUserControl();
                    TongKet_PhaThaiIUserControl tkPhaThaiI = new TongKet_PhaThaiIUserControl();
                    ucHoiBenh = hbPhaThaiI;
                    ucKhamBenh = kbPhaThaiI;
                    ucTongKet = tkPhaThaiI;
                    break;
                case LoaiBenhAnEMR.PhaThaiII:
                    XemBenhAn.BenhAn = LoadBenhAnPhaThaiII();
                    HoiBenh_PhaThaiIIUserControl hbPhaThaiII = new HoiBenh_PhaThaiIIUserControl();
                    KhamBenh_PhaThaiIIUserControl kbPhaThaiII = new KhamBenh_PhaThaiIIUserControl();
                    TongKet_PhaThaiIIUserControl tkPhaThaiII = new TongKet_PhaThaiIIUserControl();
                    ucHoiBenh = hbPhaThaiII;
                    ucKhamBenh = kbPhaThaiII;
                    ucTongKet = tkPhaThaiII;
                    break;
                case LoaiBenhAnEMR.DieuTriBanNgay:
                    XemBenhAn.BenhAn = LoadBenhAnDieuTriBanNgay();
                    KhamBenh_DieuTriBanNgay kbDieuTriBanNgay = new KhamBenh_DieuTriBanNgay();
                    ucKhamBenh = kbDieuTriBanNgay;
                    break;
                case LoaiBenhAnEMR.ThanNhanTao:
                    XemBenhAn.BenhAn = LoadBenhAnThanNhanTao();
                    HoiBenh_ThanNhanTao hbThanNhanTao = new HoiBenh_ThanNhanTao();
                    KhamBenh_ThanNhanTao kbThanNhanTao = new KhamBenh_ThanNhanTao();
                    TongKet_ThanNhanTao tkThanNhanTao = new TongKet_ThanNhanTao();
                    ucHoiBenh = hbThanNhanTao;
                    ucKhamBenh = kbThanNhanTao;
                    ucTongKet = tkThanNhanTao;
                    break;
                case LoaiBenhAnEMR.Mat:
                    XemBenhAn.BenhAn = LoadBenhAnMat();
                    HoiBenh_Mat hbMat = new HoiBenh_Mat();
                    KhamBenh_Mat kbMat = new KhamBenh_Mat();
                    TongKet_Mat tkMat = new TongKet_Mat();
                    ucHoiBenh = hbMat;
                    ucKhamBenh = kbMat;
                    ucTongKet = tkMat;
                    break;
                case LoaiBenhAnEMR.NgoaiTruMat:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTruMat();
                    HoiBenh_NgoaiTruMat hbNgoaiTruMat = new HoiBenh_NgoaiTruMat();
                    KhamBenh_NgoaiTruMat kbNgoaiTruMat = new KhamBenh_NgoaiTruMat();
                    TongKet_NgoaiTruMat tkNgoaiTruMat = new TongKet_NgoaiTruMat();
                    ucHoiBenh = hbNgoaiTruMat;
                    ucKhamBenh = kbNgoaiTruMat;
                    ucTongKet = tkNgoaiTruMat;
                    break;
                case LoaiBenhAnEMR.Tim:
                    XemBenhAn.BenhAn = LoadBenhAnTim();
                    HoiBenh_Tim hbTim = new HoiBenh_Tim();
                    KhamBenh_Tim kbTim = new KhamBenh_Tim();
                    TongKet_NoiKhoaUserControl tkTim = new TongKet_NoiKhoaUserControl();
                    ucHoiBenh = hbTim;
                    ucKhamBenh = kbTim;
                    ucTongKet = tkTim;
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNangYHCT:
                    XemBenhAn.BenhAn = LoadBenhAnPhucHoiChucNangYHCT();
                    ucHoiBenh = new HoiBenh_PhucHoiChucNangUserControl();
                    ucKhamBenh = new KhamBenh_PhucHoiChucNangYHCT();
                    ucTongKet = new TongKet_PhucHoiChucNangYHCTUserControl();
                    break;
                case LoaiBenhAnEMR.LuuCapCuu:
                    XemBenhAn.BenhAn = LoadBenhAnLuuCapCuu();
                    HoiBenh_NgoaiTruUserControl hbLuuCapCuu = new HoiBenh_NgoaiTruUserControl();
                    KhamBenh_LuuCapCuu kbLuuCapCuu = new KhamBenh_LuuCapCuu();
                    TongKet_NgoaiTruUserControl tkLuuCapCuu = new TongKet_NgoaiTruUserControl();
                    ucHoiBenh = hbLuuCapCuu;
                    ucKhamBenh = kbLuuCapCuu;
                    ucTongKet = tkLuuCapCuu;
                    break;
                case LoaiBenhAnEMR.CMU:
                    XemBenhAn.BenhAn = LoadBenhAnCMU();
                    HoiBenh_CMUUserControl hbCMUCapCuu = new HoiBenh_CMUUserControl();
                    KhamBenh_CMU kbCMU = new KhamBenh_CMU();
                    TongKet_NgoaiTruUserControl tkCMU = new TongKet_NgoaiTruUserControl();
                    ucHoiBenh = hbCMUCapCuu;
                    ucKhamBenh = kbCMU;
                    ucTongKet = tkCMU;
                    break;
                case LoaiBenhAnEMR.PhaThaiIII:
                    XemBenhAn.BenhAn = LoadBenhAnPhaThaiIII();
                    HoiBenh_PhaThaiIIIUserControl hbPhaThaiIII = new HoiBenh_PhaThaiIIIUserControl();
                    KhamBenh_PhaThaiIIIUserControl kbPhaThaiIII = new KhamBenh_PhaThaiIIIUserControl();
                    TongKet_PhaThaiIIIUserControl tkPhaThaiIII = new TongKet_PhaThaiIIIUserControl();
                    ucHoiBenh = hbPhaThaiIII;
                    ucKhamBenh = kbPhaThaiIII;
                    ucTongKet = tkPhaThaiIII;
                    break;
                case LoaiBenhAnEMR.BANgoaTruPK:
                    XemBenhAn.BenhAn = LoadBANgoaTruPK();
                    KhamBenh_BANgoaiTruPKyUserControl hbBANgoaTruPK = new KhamBenh_BANgoaiTruPKyUserControl();
                    ucHoiBenh = null;
                    ucKhamBenh = hbBANgoaTruPK;
                    ucTongKet = null;
                    break;
                case LoaiBenhAnEMR.TayChanMieng:
                    XemBenhAn.BenhAn = LoadBenhAnTayChanMieng();
                    HoiBenh_TayChanMieng hbTayChanMieng = new HoiBenh_TayChanMieng();
                    KhamBenh_TayChanMieng kbTayChanMieng = new KhamBenh_TayChanMieng();
                    TongKet_TayChanMieng tkTayChanMieng = new TongKet_TayChanMieng();
                    ucHoiBenh = hbTayChanMieng;
                    ucKhamBenh = kbTayChanMieng;
                    ucTongKet = tkTayChanMieng;
                    break;
                case LoaiBenhAnEMR.NgoaiTruPhucHoiChucNang:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTruPHCN();
                    HoiBenh_NgoaiTruPHCNUserControl hbNgoaiTruPHCN = new HoiBenh_NgoaiTruPHCNUserControl();
                    KhamBenh_NgoaiTruPHCNUserControl kbNgoaiTruPHCN = new KhamBenh_NgoaiTruPHCNUserControl();
                    TongKet_NgoaiTruUserControl tkNgoaiTruPHCN = new TongKet_NgoaiTruUserControl();
                    ucHoiBenh = hbNgoaiTruPHCN;
                    ucKhamBenh = kbNgoaiTruPHCN;
                    ucTongKet = tkNgoaiTruPHCN;
                    break;
                case LoaiBenhAnEMR.PhucHoiChucNangNhi:
                    XemBenhAn.BenhAn = LoadBenhAnPHCNNhi();
                    HoiBenh_PHCNNhiUserControl hbPHCNNhi = new HoiBenh_PHCNNhiUserControl();
                    KhamBenh_PHCNNhiUserControl kbPHCNNhi = new KhamBenh_PHCNNhiUserControl();
                    TongKet_PHCNNhiUserControl tkPHCNNhi = new TongKet_PHCNNhiUserControl();
                    ucHoiBenh = hbPHCNNhi;
                    ucKhamBenh = kbPHCNNhi;
                    ucTongKet = tkPHCNNhi;
                    break;
                case LoaiBenhAnEMR.DaLieuTW:
                    XemBenhAn.BenhAn = LoadBenhAnDaLieuTW();
                    HoiBenh_DaLieuTWUserControl hbDaLieuTW = new HoiBenh_DaLieuTWUserControl();
                    KhamBenh_DaLieuTWUserControl kbDaLieuTW = new KhamBenh_DaLieuTWUserControl();
                    TongKet_DaLieuTWUserControl tkDaLieuTW = new TongKet_DaLieuTWUserControl();
                    ucHoiBenh = hbDaLieuTW;
                    ucKhamBenh = kbDaLieuTW;
                    ucTongKet = tkDaLieuTW;
                    break;
                case LoaiBenhAnEMR.PHCNII:
                    XemBenhAn.BenhAn = LoadBenhAnPHCNII();
                    HoiBenh_PHCNIIUserControl hbPHCNII = new HoiBenh_PHCNIIUserControl();
                    KhamBenh_PHCNIIUserControl kbPHCNII = new KhamBenh_PHCNIIUserControl();
                    TongKet_PHCNIIUserControl tkPHCNII = new TongKet_PHCNIIUserControl();
                    ucHoiBenh = hbPHCNII;
                    ucKhamBenh = kbPHCNII;
                    ucTongKet = tkPHCNII;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenThuongThuong:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTru_VayNenThuongThuong();
                    HoiBenh_VayNenTheThongThuong hbVayNenTheThongThuong = new HoiBenh_VayNenTheThongThuong();
                    KhamBenh_VayNenTheThongThuongUserControl kbVayNenTheThongThuong = new KhamBenh_VayNenTheThongThuongUserControl();
                    TongKet_VayNenTheThongThuongUserControl tkVayNenTheThongThuong = new TongKet_VayNenTheThongThuongUserControl();
                    ucHoiBenh = hbVayNenTheThongThuong;
                    ucKhamBenh = kbVayNenTheThongThuong;
                    ucTongKet = tkVayNenTheThongThuong;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_AVayNen:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTru_AVayNen();
                    HoiBenh_BANgoaiTruAVayNenUserControl hbAVayNen = new HoiBenh_BANgoaiTruAVayNenUserControl();
                    KhamBenh_BANgoaiTruAVayNenUserControl kbAVayNen = new KhamBenh_BANgoaiTruAVayNenUserControl();
                    TongKet_BANgoaiTruAVayNenUserControl tkVAVayNen = new TongKet_BANgoaiTruAVayNenUserControl();
                    ucHoiBenh = hbAVayNen;
                    ucKhamBenh = kbAVayNen;
                    ucTongKet = tkVAVayNen;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_HoTroSinhSan:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTru_HoTroSinhSan();
                    HoiBenh_NgoaiTruTrungTamHoTroSinhSan hbNgoaiTruHTSS = new HoiBenh_NgoaiTruTrungTamHoTroSinhSan();
                    KhamBenh_NgoaiTruTrungTamHoTroSinhSan kbNgoaiTruHTSS = new KhamBenh_NgoaiTruTrungTamHoTroSinhSan();
                    TongKet_NgoaiTruTrungTamHoTroSinhSan tkNgoaiTruHTSS = new TongKet_NgoaiTruTrungTamHoTroSinhSan();
                    ucHoiBenh = hbNgoaiTruHTSS;
                    ucKhamBenh = kbNgoaiTruHTSS;
                    ucTongKet = tkNgoaiTruHTSS;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhAnViemBiCo:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTru_ViemBiCo();
                    HoiBenh_BenhViemBiCo hbViemBiCo = new HoiBenh_BenhViemBiCo();
                    KhamBenh_BenhViemBiCo kbViemBiCo = new KhamBenh_BenhViemBiCo();
                    TongKet_BANgoaiTruDaLieu tkViemBiCo = new TongKet_BANgoaiTruDaLieu();
                    ucHoiBenh = hbViemBiCo;
                    ucKhamBenh = kbViemBiCo;
                    ucTongKet = tkViemBiCo;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhAnLupusBanDoHeThong:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTru_LupusBanDoHeThong();
                    HoiBenh_BenhLupusBanDoHeThong hbLupusBanDoHeThong = new HoiBenh_BenhLupusBanDoHeThong();
                    KhamBenh_BenhLupusBanDoHeThong kbLupusBanDoHeThong = new KhamBenh_BenhLupusBanDoHeThong();
                    TongKet_BANgoaiTruDaLieu tkLupusBanDoHeThong = new TongKet_BANgoaiTruDaLieu();
                    ucHoiBenh = hbLupusBanDoHeThong;
                    ucKhamBenh = kbLupusBanDoHeThong;
                    ucTongKet = tkLupusBanDoHeThong;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_PEMPHIGOID:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTru_PEMPHIGOID();
                    HoiBenh_BANgoaiTruPemphigoidUserControl hbPemphigoid = new HoiBenh_BANgoaiTruPemphigoidUserControl();
                    KhamBenh_BANgoaiTruPemphigoidUserControl kbPemphigoid = new KhamBenh_BANgoaiTruPemphigoidUserControl();
                    TongKet_BANgoaiTruDaLieu tkPemphigoid = new TongKet_BANgoaiTruDaLieu();
                    ucHoiBenh = hbPemphigoid;
                    ucKhamBenh = kbPemphigoid;
                    ucTongKet = tkPemphigoid;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayPhanDoNangLong:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTru_VayPhanDoNangLong();
                    HoiBenh_VayPhanDoNangLong hbVayPhanDoNangLong = new HoiBenh_VayPhanDoNangLong();
                    KhamBenh_VayPhanDoNangLong kbVayPhanDoNangLong = new KhamBenh_VayPhanDoNangLong();
                    TongKet_VayPhanDoNangLong tkVayPhanDoNangLong = new TongKet_VayPhanDoNangLong();
                    ucHoiBenh = hbVayPhanDoNangLong;
                    ucKhamBenh = kbVayPhanDoNangLong;
                    ucTongKet = tkVayPhanDoNangLong;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_LuPusBanDoManTinh:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTru_LuPusBanDoManTinh();
                    HoiBenh_DTNTLuPusBanDoManTinhUserControl hbLuPusBanDoManTinh = new HoiBenh_DTNTLuPusBanDoManTinhUserControl();
                    KhamBenh_DTNTLuPusBanDoManTinhUserControl kbLuPusBanDoManTinh = new KhamBenh_DTNTLuPusBanDoManTinhUserControl();
                    TongKet_DTNTLuPusBanDoManTinhUserControl tkLuPusBanDoManTinh = new TongKet_DTNTLuPusBanDoManTinhUserControl();
                    ucHoiBenh = hbLuPusBanDoManTinh;
                    ucKhamBenh = kbLuPusBanDoManTinh;
                    ucTongKet = tkLuPusBanDoManTinh;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenTheMu:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTru_VayNenTheMu();
                    HoiBenh_VayNenTheMu hbVayNenTheMu = new HoiBenh_VayNenTheMu();
                    KhamBenh_VayNenTheMu kbVayNenTheMu = new KhamBenh_VayNenTheMu();
                    TongKet_BANgoaiTruDaLieu tkVayNenTheMu = new TongKet_BANgoaiTruDaLieu();
                    ucHoiBenh = hbVayNenTheMu;
                    ucKhamBenh = kbVayNenTheMu;
                    ucTongKet = tkVayNenTheMu;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_DuhringBrocq:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTruDuhringBrocq();
                    HoiBenh_BenhDuhringBrocq hbDuhringBrocq = new HoiBenh_BenhDuhringBrocq();
                    KhamBenh_BenhDuhringBrocq kbBenhDuhringBrocq = new KhamBenh_BenhDuhringBrocq();
                    TongKet_BenhDuhringBrocq tkBenhDuhringBrocq = new TongKet_BenhDuhringBrocq();
                    ucHoiBenh = hbDuhringBrocq;
                    ucKhamBenh = kbBenhDuhringBrocq;
                    ucTongKet = tkBenhDuhringBrocq;
                    break;
                case LoaiBenhAnEMR.DaiThaoDuong:
                    XemBenhAn.BenhAn = LoadBenhAnDaiThaoDuong();
                    HoiBenh_DaiThaoDuong hbDaiThaoDuong = new HoiBenh_DaiThaoDuong();
                    KhamBenh_DaiThaoDuong kbDaiThaoDuong = new KhamBenh_DaiThaoDuong();
                    TongKet_NoiKhoaUserControl tkDaiThaoDuong = new TongKet_NoiKhoaUserControl();
                    ucHoiBenh = hbDaiThaoDuong;
                    ucKhamBenh = kbDaiThaoDuong;
                    ucTongKet = tkDaiThaoDuong;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_UngThuDaHacTo:
                    XemBenhAn.BenhAn = LoadBenhAnUngThuHacTo();
                    HoiBenh_BAUngThuDaHacTo hbBenhAnUngThuHacTo = new HoiBenh_BAUngThuDaHacTo();
                    KhamBenh_BAUngThuDaHacTo kbBenhAnUngThuHacTo = new KhamBenh_BAUngThuDaHacTo();
                    TongKet_BAUngThuDaHacTo tkBenhAnUngThuHacTo = new TongKet_BAUngThuDaHacTo();
                    ucHoiBenh = hbBenhAnUngThuHacTo;
                    ucKhamBenh = kbBenhAnUngThuHacTo;
                    ucTongKet = tkBenhAnUngThuHacTo;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_UngThuDaKhongHacTo:
                    XemBenhAn.BenhAn = LoadBenhAnUngThuKhongHacTo();
                    HoiBenh_BAUngThuDaKhongHacTo hbBenhAnUngThuKhongHacTo = new HoiBenh_BAUngThuDaKhongHacTo();
                    KhamBenh_BAUngThuDaKhongHacTo kbBenhAnUngThuKhongHacTo = new KhamBenh_BAUngThuDaKhongHacTo();
                    TongKet_BAUngThuDaHacTo tkBenhAnUngThuKhongHacTo = new TongKet_BAUngThuDaHacTo();
                    ucHoiBenh = hbBenhAnUngThuKhongHacTo;
                    ucKhamBenh = kbBenhAnUngThuKhongHacTo;
                    ucTongKet = tkBenhAnUngThuKhongHacTo;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_Pemphigus:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTruPemphigus();
                    HoiBenh_PemphigusUserControl hbBenhAnNgoaiTruPemphigus = new HoiBenh_PemphigusUserControl();
                    KhamBenh_PemphigusUserControl kbBenhAnNgoaiTruPemphigus = new KhamBenh_PemphigusUserControl();
                    TongKet_Pemphigus tkBenhAnNgoaiTruPemphigus = new TongKet_Pemphigus();
                    ucHoiBenh = hbBenhAnNgoaiTruPemphigus;
                    ucKhamBenh = kbBenhAnNgoaiTruPemphigus;
                    ucTongKet = tkBenhAnNgoaiTruPemphigus;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_VayNenTheKhop:
                    XemBenhAn.BenhAn = LoadBenhAnVayNenTheKhop();
                    HoiBenh_BAVayNenTheKhop hbBenhAnVayNenTheKhop = new HoiBenh_BAVayNenTheKhop();
                    KhamBenh_BAVayNenTheKhop kbBenhAnVayNenTheKhop = new KhamBenh_BAVayNenTheKhop();
                    TongKet_BANgoaiTruDaLieu tkBenhAnVayNenTheKhop = new TongKet_BANgoaiTruDaLieu();
                    ucHoiBenh = hbBenhAnVayNenTheKhop;
                    ucKhamBenh = kbBenhAnVayNenTheKhop;
                    ucTongKet = tkBenhAnVayNenTheKhop;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_HoiChungTrungLap:
                    XemBenhAn.BenhAn = LoadBenhAnNgoaiTru_HoiChungTrungLap();
                    HoiBenh_BenhHoiChungTrungLap hbBenhHoiChungTrungLap = new HoiBenh_BenhHoiChungTrungLap();
                    KhamBenh_BenhHoiChungTrungLap kbBenhHoiChungTrungLap = new KhamBenh_BenhHoiChungTrungLap();
                    TongKet_BANgoaiTruDaLieu tkBenhHoiChungTrungLap = new TongKet_BANgoaiTruDaLieu();
                    ucHoiBenh = hbBenhHoiChungTrungLap;
                    ucKhamBenh = kbBenhHoiChungTrungLap;
                    ucTongKet = tkBenhHoiChungTrungLap;
                    break;
                case LoaiBenhAnEMR.StentDongMachVanh:
                    XemBenhAn.BenhAn = LoadBenhAnStentDongMachVanh();
                    HoiBenh_BenhAnStentDongMachVanh hbBenhAnStentDongMachVanh = new HoiBenh_BenhAnStentDongMachVanh();
                    KhamBenh_NoiKhoaUserControl kbBenhAnStentDongMachVanh = new KhamBenh_NoiKhoaUserControl();
                    TongKet_NoiKhoaUserControl tkBenhAnStentDongMachVanh = new TongKet_NoiKhoaUserControl();
                    ucHoiBenh = hbBenhAnStentDongMachVanh;
                    ucKhamBenh = kbBenhAnStentDongMachVanh;
                    ucTongKet = tkBenhAnStentDongMachVanh;
                    break;
                case LoaiBenhAnEMR.ThieuMauCoTimCucBo:
                    XemBenhAn.BenhAn = LoadBenhAnThieuMauCoTimCucBo();
                    HoiBenh_BenhAnThieuMauCoTimCucBo hbBenhAnThieuMauCoTimCucBo = new HoiBenh_BenhAnThieuMauCoTimCucBo();
                    KhamBenh_NoiKhoaUserControl kbBenhAnThieuMauCoTimCucBo = new KhamBenh_NoiKhoaUserControl();
                    TongKet_NoiKhoaUserControl tkBenhAnThieuMauCoTimCucBo = new TongKet_NoiKhoaUserControl();
                    ucHoiBenh = hbBenhAnThieuMauCoTimCucBo;
                    ucKhamBenh = kbBenhAnThieuMauCoTimCucBo;
                    ucTongKet = tkBenhAnThieuMauCoTimCucBo;
                    break;
                case LoaiBenhAnEMR.NgoaiTru_BenhBasedow:
                    XemBenhAn.BenhAn = LoadBenhAnBenhBasedow();
                    HoiBenh_BenhAnBenhBasedow hbBenhAnBenhBaseDow = new HoiBenh_BenhAnBenhBasedow();
                    KhamBenh_BenhAnBenhBasedow kbBenhAnBenhBaseDow = new KhamBenh_BenhAnBenhBasedow();
                    TongKet_NoiKhoaUserControl tkBenhAnBenhBaseDow = new TongKet_NoiKhoaUserControl();
                    ucHoiBenh = hbBenhAnBenhBaseDow;
                    ucKhamBenh = kbBenhAnBenhBaseDow;
                    ucTongKet = tkBenhAnBenhBaseDow;
                    break;
                case LoaiBenhAnEMR.ViemGanBManTinh:
                    XemBenhAn.BenhAn = LoadBenhAnViemGanBManTinh();
                    HoiBenh_BenhViemGanSieuViBManTinh hbBenhAnViemGanBManTinh = new HoiBenh_BenhViemGanSieuViBManTinh();
                    KhamBenh_BenhViemGanSieuViBManTinh kbBenhAnViemGanBManTinh = new KhamBenh_BenhViemGanSieuViBManTinh();
                    TongKet_NoiKhoaUserControl tkBenhAnViemGanBManTinh = new TongKet_NoiKhoaUserControl();
                    ucHoiBenh = hbBenhAnViemGanBManTinh;
                    ucKhamBenh = kbBenhAnViemGanBManTinh;
                    ucTongKet = tkBenhAnViemGanBManTinh;
                    break;
                case LoaiBenhAnEMR.PhoiTacNghenManTinh:
                    XemBenhAn.BenhAn = LoadBenhAnPhoiTacNghenManTinh();
                    HoiBenh_BenhAnPhoiTacNghenManTinh hbBenhAnPhoiTacNghenManTinh = new HoiBenh_BenhAnPhoiTacNghenManTinh();
                    KhamBenh_BenhAnPhoiTacNghenManTinh kbBenhAnPhoiTacNghenManTinh = new KhamBenh_BenhAnPhoiTacNghenManTinh();
                    TongKet_NoiKhoaUserControl tkBenhAnPhoiTacNghenManTinh = new TongKet_NoiKhoaUserControl();
                    ucHoiBenh = hbBenhAnPhoiTacNghenManTinh;
                    ucKhamBenh = kbBenhAnPhoiTacNghenManTinh;
                    ucTongKet = tkBenhAnPhoiTacNghenManTinh;
                    break;
                case LoaiBenhAnEMR.BenhTangHuyetAp:
                    XemBenhAn.BenhAn = LoadBenhAnTangHuyetAp();
                    HoiBenh_BenhAnTangHuyetAp hbBenhAnTangHuyetAp = new HoiBenh_BenhAnTangHuyetAp();
                    KhamBenh_NoiKhoaUserControl kbBenhAnTangHuyetAp = new KhamBenh_NoiKhoaUserControl();
                    TongKet_NoiKhoaUserControl tkBenhAnTangHuyetAp = new TongKet_NoiKhoaUserControl();
                    ucHoiBenh = hbBenhAnTangHuyetAp;
                    ucKhamBenh = kbBenhAnTangHuyetAp;
                    ucTongKet = tkBenhAnTangHuyetAp;
                    break;
                default:
                    break;
            }
            XemBenhAn._thongTinHoSoBenhAn.BenhAn = JsonConvert.SerializeObject(XemBenhAn.BenhAn);
            string _str = JsonConvert.SerializeObject(XemBenhAn._thongTinHoSoBenhAn);
            timerlocal.Stop();
            if (XemBenhAn._LoaiBenhAnEMR > 0)
                log.Info("-----end get thongtinbenhan: " + XemBenhAn._LoaiBenhAnEMR.Description() + " " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total: " + timerlocal.ElapsedMilliseconds.ToString() + " ms");

            timer.Stop();
            log.Info("*********************************************************End get data EMR: '" + key + "'. Total: " + timer.ElapsedMilliseconds.ToString() + " ms");
        }
        string ketquaAPI = "";
        #region Load BenhAn
        object LoadBenhAnBong()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnBong " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BenhAnBong _BenhAn = JsonConvert.DeserializeObject<BenhAnBong>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnBong BenhAnBongnOnServer = null;

#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null,null);
                        BenhAnBongnOnServer = JsonConvert.DeserializeObject<BenhAnBong>(ketquaAPI);
#else

                        BenhAnBongnOnServer = BenhAnBongFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnBongnOnServer.MaQuanLy != 0) _BenhAn = BenhAnBongnOnServer;
                        else
                        {
                            _BenhAn.TinhTrangNguoiBenhRaVien = Converter.EnumHelper<KetQuaDieuTri>.GetEnumDescription(XemBenhAn._ThongTinDieuTri.KetQuaDieuTri.ToString());
                        }

                        if (_BenhAn.DacDiemLienQuanBenh == null)
                        {
                            _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnBong " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnDaLieu()
        {
            try
            {
                
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnDaLieu " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BenhAnDaLieu _BenhAn = JsonConvert.DeserializeObject<BenhAnDaLieu>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnDaLieu BenhAnDaLieuOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnDaLieuOnServer = JsonConvert.DeserializeObject<BenhAnDaLieu>(ketquaAPI);
#else

                        BenhAnDaLieuOnServer = BenhAnDaLieuFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnDaLieuOnServer.MaQuanLy != 0) _BenhAn = BenhAnDaLieuOnServer;
                        else
                        {
                            _BenhAn.TinhTrangNguoiBenhRaVien = Converter.EnumHelper<KetQuaDieuTri>.GetEnumDescription(XemBenhAn._ThongTinDieuTri.KetQuaDieuTri.ToString());
                        }

                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnDaLieu " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnNoiKhoa()
        {
            try
            {
                
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                {
                    var timer = new Stopwatch();
                    timer.Start();
                    log.Info("++++++++++Start LoadBenhAnNoiKhoa " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    try
                    {
                        BenhAnNoiKhoa _BenhAn = JsonConvert.DeserializeObject<BenhAnNoiKhoa>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNoiKhoa BenhAnNoiKhoanOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNoiKhoanOnServer = JsonConvert.DeserializeObject<BenhAnNoiKhoa>(ketquaAPI);
#else

                        BenhAnNoiKhoanOnServer = BenhAnNoiKhoaFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnNoiKhoanOnServer.MaQuanLy != 0) _BenhAn = BenhAnNoiKhoanOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNoiKhoa " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnNgoaiKhoa()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiKhoa " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {

                        BenhAnNgoaiKhoa _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiKhoa>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiKhoa BenhAnNgoaiKhoanOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiKhoanOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiKhoa>(ketquaAPI);
#else

                        BenhAnNgoaiKhoanOnServer = BenhAnNgoaiKhoaFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnNgoaiKhoanOnServer.MaQuanLy != 0) _BenhAn = BenhAnNgoaiKhoanOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiKhoa " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnHHTM()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnHHTM " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnHuyetHocTruyenMau _BenhAn = JsonConvert.DeserializeObject<BenhAnHuyetHocTruyenMau>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnHuyetHocTruyenMau BenhAnHuyetHocTruyenMaunOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnHuyetHocTruyenMaunOnServer = JsonConvert.DeserializeObject<BenhAnHuyetHocTruyenMau>(ketquaAPI);
#else

                        BenhAnHuyetHocTruyenMaunOnServer = BenhAnHuyetHocTruyenMauFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnHuyetHocTruyenMaunOnServer.MaQuanLy != 0) _BenhAn = BenhAnHuyetHocTruyenMaunOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnHHTM " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnNgoaiTru()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTru " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTru _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTru>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTru BenhAnNgoaiTrunOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTrunOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTru>(ketquaAPI);
#else

                        BenhAnNgoaiTrunOnServer = BenhAnNgoaiTruFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnNgoaiTrunOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnNgoaiTrunOnServer;
                        else
                        {
                            _BenhAn.DieuTriNgoaiTru_TuNgay = (XemBenhAn._ThongTinDieuTri.NgayVaoVien != null && !DateTime.MinValue.Equals(XemBenhAn._ThongTinDieuTri.NgayVaoVien)) ? Convert.ToDateTime(XemBenhAn._ThongTinDieuTri.NgayVaoVien) : Convert.ToDateTime(null);
                            _BenhAn.DieuTriNgoaiTru_DenNgay = (XemBenhAn._ThongTinDieuTri.NgayRaVien != null && !DateTime.MinValue.Equals(XemBenhAn._ThongTinDieuTri.NgayRaVien)) ? Convert.ToDateTime(XemBenhAn._ThongTinDieuTri.NgayRaVien) : DateTime.Now;
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                            _BenhAn.MaICD_BenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.MaICD_BenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                            _BenhAn.ChanDoanKhiRaVien = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.MAIDC_ChanDoanKhiRaVien = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                        }
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTru " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnNgoaiTruRHM()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTruRHM " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                try
                {
                    BenhAnNgoaiTruRangHamMat _BenhAn = null;
                    try
                    {
                        _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTruRangHamMat>(XemBenhAn.JsonInput);
                    }
                    catch { }
                    if (_BenhAn == null)
                    {
                        _BenhAn = new BenhAnNgoaiTruRangHamMat();
                        _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy;
                    }

                    BenhAnNgoaiTruRangHamMat BenhAnNgoaiTruRangHamMatnOnServer = null;
#if CLOUD

                    ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                    BenhAnNgoaiTruRangHamMatnOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTruRangHamMat>(ketquaAPI);
#else

                    BenhAnNgoaiTruRangHamMatnOnServer = BenhAnNgoaiTruRangHamMatFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                    if (BenhAnNgoaiTruRangHamMatnOnServer.MaQuanLy != 0) _BenhAn = BenhAnNgoaiTruRangHamMatnOnServer;
                    else
                    {
                        _BenhAn.DieuTriNgoaiTru_TuNgay = (XemBenhAn._ThongTinDieuTri.NgayVaoVien != null && !DateTime.MinValue.Equals(XemBenhAn._ThongTinDieuTri.NgayVaoVien)) ? Convert.ToDateTime(XemBenhAn._ThongTinDieuTri.NgayVaoVien) : Convert.ToDateTime(null);
                        _BenhAn.DieuTriNgoaiTru_DenNgay = (XemBenhAn._ThongTinDieuTri.NgayRaVien != null && !DateTime.MinValue.Equals(XemBenhAn._ThongTinDieuTri.NgayRaVien)) ? Convert.ToDateTime(XemBenhAn._ThongTinDieuTri.NgayRaVien) : DateTime.Now;
                        _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                        _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                        _BenhAn.MaICD_BenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                        _BenhAn.MaICD_BenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                    }

                    if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                    _BenhAn.NgayKhamBenh = _BenhAn.NgayKhamBenh == Convert.ToDateTime(null) ? DateTime.Now : _BenhAn.NgayKhamBenh;
                    _BenhAn.NgayTongKet = _BenhAn.NgayTongKet == Convert.ToDateTime(null) ? DateTime.Now : _BenhAn.NgayTongKet;
                    if (_BenhAn.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAn.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAn.NgayKhamBenh = DateTime.Now;
                    }
                    return _BenhAn;
                }
                catch (Exception ex)
                {
                    XuLyLoi.Handle(ex);
                }
                finally
                {
                    timer.Stop();
                    log.Info("++++++++++End LoadBenhAnNgoaiTruRHM " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnNgoaiTruTMH()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                {
                    var timer = new Stopwatch();
                    timer.Start();
                    log.Info("++++++++++Start LoadBenhAnNgoaiTruTMH " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    try
                    {
                        //
                        BenhAnNgoaiTruTaiMuiHong _BenhAn = null;
                        try
                        {
                            _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTruTaiMuiHong>(XemBenhAn.JsonInput);
                        }
                        catch { }
                        if (_BenhAn == null)
                        {
                            _BenhAn = new BenhAnNgoaiTruTaiMuiHong();
                            _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy;
                        }

                        BenhAnNgoaiTruTaiMuiHong BenhAnNgoaiTruTaiMuiHongnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTruTaiMuiHongnOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTruTaiMuiHong>(ketquaAPI);
#else

                        BenhAnNgoaiTruTaiMuiHongnOnServer = BenhAnNgoaiTruTaiMuiHongFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnNgoaiTruTaiMuiHongnOnServer.MaQuanLy != 0) _BenhAn = BenhAnNgoaiTruTaiMuiHongnOnServer;
                        else
                        {
                            _BenhAn.DieuTriNgoaiTru_TuNgay = (XemBenhAn._ThongTinDieuTri.NgayVaoVien != null && !DateTime.MinValue.Equals(XemBenhAn._ThongTinDieuTri.NgayVaoVien)) ? Convert.ToDateTime(XemBenhAn._ThongTinDieuTri.NgayVaoVien) : Convert.ToDateTime(null);
                            _BenhAn.DieuTriNgoaiTru_DenNgay = (XemBenhAn._ThongTinDieuTri.NgayRaVien != null && !DateTime.MinValue.Equals(XemBenhAn._ThongTinDieuTri.NgayRaVien)) ? Convert.ToDateTime(XemBenhAn._ThongTinDieuTri.NgayRaVien) : DateTime.Now;
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                            _BenhAn.MaICD_BenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.MaICD_BenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                        }

                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        _BenhAn.NgayKhamBenh = _BenhAn.NgayKhamBenh == Convert.ToDateTime(null) ? DateTime.Now : _BenhAn.NgayKhamBenh;
                        _BenhAn.NgayTongKet = _BenhAn.NgayTongKet == Convert.ToDateTime(null) ? DateTime.Now : _BenhAn.NgayTongKet;
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTruTMH " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnPHCN()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnPHCN " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BenhAnPhucHoiChucNang _BenhAn = JsonConvert.DeserializeObject<BenhAnPhucHoiChucNang>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnPhucHoiChucNang BenhAnPhucHoiChucNangnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnPhucHoiChucNangnOnServer = JsonConvert.DeserializeObject<BenhAnPhucHoiChucNang>(ketquaAPI);
#else

                        BenhAnPhucHoiChucNangnOnServer = BenhAnPhucHoiChucNangFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnPhucHoiChucNangnOnServer.MaQuanLy != 0) _BenhAn = BenhAnPhucHoiChucNangnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnPHCN " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnRHM()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnRHM " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BenhAnRangHamMat _BenhAn = JsonConvert.DeserializeObject<BenhAnRangHamMat>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnRangHamMat BenhAnRangHamMatnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnRangHamMatnOnServer = JsonConvert.DeserializeObject<BenhAnRangHamMat>(ketquaAPI);
#else

                        BenhAnRangHamMatnOnServer = BenhAnRangHamMatFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnRangHamMatnOnServer.MaQuanLy != 0) _BenhAn = BenhAnRangHamMatnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnRHM " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }

        object LoadBenhAnPhuKhoa()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnPhuKhoa " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                try
                {
                    //
                    BenhAnPhuKhoa _BenhAn = null;
                    try
                    {
                        _BenhAn = JsonConvert.DeserializeObject<BenhAnPhuKhoa>(XemBenhAn.JsonInput);
                    }
                    catch { }
                    if (_BenhAn == null)
                    {
                        _BenhAn = new BenhAnPhuKhoa();
                        _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy;
                    }
                    if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }

                    BenhAnPhuKhoa BenhAnPhuKhoanOnServer = null;
#if CLOUD

                    ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                    BenhAnPhuKhoanOnServer = JsonConvert.DeserializeObject<BenhAnPhuKhoa>(ketquaAPI);
#else

                    BenhAnPhuKhoanOnServer = BenhAnPhuKhoaFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                    if (BenhAnPhuKhoanOnServer.MaQuanLy != 0) _BenhAn = BenhAnPhuKhoanOnServer;
                    if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                    if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                    if (_BenhAn.NgayTongKet == DateTime.MinValue)
                    {
                        _BenhAn.NgayTongKet = DateTime.Now;
                    }
                    if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                    {
                        _BenhAn.NgayKhamBenh = DateTime.Now;
                    }
                    if(_BenhAn.TienSuSanPhuKhoa == null) _BenhAn.TienSuSanPhuKhoa = new TienSuSanPhuKhoa();  
                    return _BenhAn;
                }
                catch (Exception ex)
                {
                    XuLyLoi.Handle(ex);
                }
                finally
                {
                    timer.Stop();
                    log.Info("++++++++++End LoadBenhAnPhuKhoa " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnPhaThaiI()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnPhaThaiI " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //.MDBConnection.Open();
                        BenhAnPhaThaiI _BenhAn = JsonConvert.DeserializeObject<BenhAnPhaThaiI>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnPhaThaiI BenhAnPhaThaiInOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnPhaThaiInOnServer = JsonConvert.DeserializeObject<BenhAnPhaThaiI>(ketquaAPI);
#else

                        BenhAnPhaThaiInOnServer = BenhAnPhaThaiIFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnPhaThaiInOnServer.MaQuanLy != 0) _BenhAn = BenhAnPhaThaiInOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnPhaThaiI " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnPhaThaiII()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnPhaThaiII " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BenhAnPhaThaiII _BenhAn = JsonConvert.DeserializeObject<BenhAnPhaThaiII>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnPhaThaiII BenhAnPhaThaiInOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnPhaThaiInOnServer = JsonConvert.DeserializeObject<BenhAnPhaThaiII>(ketquaAPI);
#else

                        BenhAnPhaThaiInOnServer = BenhAnPhaThaiIIFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnPhaThaiII " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnSanKhoa()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnSanKhoa " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BenhAnSanKhoa _BenhAn = JsonConvert.DeserializeObject<BenhAnSanKhoa>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnSanKhoa BenhAnSanKhoanOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnSanKhoanOnServer = JsonConvert.DeserializeObject<BenhAnSanKhoa>(ketquaAPI);
#else

                        BenhAnSanKhoanOnServer = BenhAnSanKhoaFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnSanKhoanOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnSanKhoanOnServer;
                        else
                        {
                            _BenhAn.KinhCuoiCungTuNgay = DateTime.Now;
                            _BenhAn.KinhCuoiCungDenNgay = DateTime.Now;
                            //_BenhAn.BatDauChuyenDaTu = DateTime.Now;
                            //_BenhAn.OiVoLuc = DateTime.Now;
                            if (!XemBenhAn.IsHis2)
                            {
                                _BenhAn.iDaThai = -1;
                                _BenhAn.iDonThai = -1;
                                _BenhAn.iOiVoID = -1;
                                _BenhAn.iRau = -1;
                                _BenhAn.ThoiGianVaoBuongDe = DateTime.Now;
                                _BenhAn.ThoiGianDe = DateTime.Now;
                                _BenhAn.ThoiGianRauSo = DateTime.Now;
                            }
                        }

                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnSanKhoa " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnSoSinh()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnSoSinh " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnSoSinh _BenhAn = JsonConvert.DeserializeObject<BenhAnSoSinh>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnSoSinh BenhAnSoSinhnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnSoSinhnOnServer = JsonConvert.DeserializeObject<BenhAnSoSinh>(ketquaAPI);
#else

                        BenhAnSoSinhnOnServer = BenhAnSoSinhFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnSoSinhnOnServer.MaQuanLy != 0)
                        {
                            _BenhAn = BenhAnSoSinhnOnServer;
                        }
                        else
                        {
                            _BenhAn.iCachDeID = 0;
                            _BenhAn.ThoiGianDe = Convert.ToDateTime(null);
                        }

                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        if (_BenhAn.OiVo == DateTime.MinValue)
                        {
                            _BenhAn.OiVo = DateTime.Now;
                        }
                        if (_BenhAn.ThoiGianDe == DateTime.MinValue)
                        {
                            _BenhAn.ThoiGianDe = DateTime.Now;
                        }

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnSoSinh " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnNhiKhoa()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNhiKhoa " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnNhiKhoa _BenhAn = JsonConvert.DeserializeObject<BenhAnNhiKhoa>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNhiKhoa BenhAnNhiKhoanOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNhiKhoanOnServer = JsonConvert.DeserializeObject<BenhAnNhiKhoa>(ketquaAPI);
#else

                        BenhAnNhiKhoanOnServer = BenhAnNhiKhoaFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnNhiKhoanOnServer.MaQuanLy != 0) _BenhAn = BenhAnNhiKhoanOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNhiKhoa " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnTMH()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnTMH " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnTaiMuiHong _BenhAn = JsonConvert.DeserializeObject<BenhAnTaiMuiHong>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnTaiMuiHong BenhAnTaiMuiHongnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnTaiMuiHongnOnServer = JsonConvert.DeserializeObject<BenhAnTaiMuiHong>(ketquaAPI);
#else

                        BenhAnTaiMuiHongnOnServer = BenhAnTaiMuiHongFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnTaiMuiHongnOnServer.MaQuanLy != 0) _BenhAn = BenhAnTaiMuiHongnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnTMH " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnTamThan()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnTamThan " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnTamThan _BenhAn = null;
                        try
                        {
                            _BenhAn = JsonConvert.DeserializeObject<BenhAnTamThan>(XemBenhAn.JsonInput);
                        }
                        catch { }
                        if (_BenhAn == null)
                        {
                            _BenhAn = new BenhAnTamThan();
                            _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy;
                        }
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        // 
                        BenhAnTamThan BenhAnTamThannOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnTamThannOnServer = JsonConvert.DeserializeObject<BenhAnTamThan>(ketquaAPI);
#else

                        BenhAnTamThannOnServer = BenhAnTamThanFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnTamThannOnServer.MaQuanLy != 0) _BenhAn = BenhAnTamThannOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnTamThan " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnTruyenNhiem()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnTruyenNhiem " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnTruyenNhiem _BenhAn = JsonConvert.DeserializeObject<BenhAnTruyenNhiem>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnTruyenNhiem BenhAnTruyenNhiemnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnTruyenNhiemnOnServer = JsonConvert.DeserializeObject<BenhAnTruyenNhiem>(ketquaAPI);
#else

                        BenhAnTruyenNhiemnOnServer = BenhAnTruyenNhiemFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnTruyenNhiemnOnServer.MaQuanLy != 0) _BenhAn = BenhAnTruyenNhiemnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnTruyenNhiem " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnTruyenNhiemII()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnTruyenNhiemII " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnTruyenNhiemII _BenhAn = JsonConvert.DeserializeObject<BenhAnTruyenNhiemII>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnTruyenNhiemII BenhAnTruyenNhiemIInOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnTruyenNhiemIInOnServer = JsonConvert.DeserializeObject<BenhAnTruyenNhiemII>(ketquaAPI);
#else
                        BenhAnTruyenNhiemIInOnServer = BenhAnTruyenNhiemIIFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (BenhAnTruyenNhiemIInOnServer.MaQuanLy != 0) _BenhAn = BenhAnTruyenNhiemIInOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        if (_BenhAn.TienSuDiUngs == null || _BenhAn.TienSuDiUngs.Count == 0)
                        {
                            _BenhAn.TienSuDiUngs = TienSuDiUng.CreateData();
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnTruyenNhiemII " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnUngBuou()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnUngBuou " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnUngBuou _BenhAn = null;
                        try
                        {
                            _BenhAn = JsonConvert.DeserializeObject<BenhAnUngBuou>(XemBenhAn.JsonInput);
                        }
                        catch { }
                        if (_BenhAn == null)
                        {
                            _BenhAn = new BenhAnUngBuou();
                            _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy;
                        }
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        // 
                        BenhAnUngBuou BenhAnUngBuounOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnUngBuounOnServer = JsonConvert.DeserializeObject<BenhAnUngBuou>(ketquaAPI);
#else

                        BenhAnUngBuounOnServer = BenhAnUngBuouFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnUngBuounOnServer.MaQuanLy != 0) _BenhAn = BenhAnUngBuounOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnUngBuou " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnMatBanPhanTruoc()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnMatBanPhanTruoc " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnMatBanPhanTruoc _BenhAn = JsonConvert.DeserializeObject<BenhAnMatBanPhanTruoc>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnMatBanPhanTruoc BenhAnMatBanPhanTruocnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnMatBanPhanTruocnOnServer = JsonConvert.DeserializeObject<BenhAnMatBanPhanTruoc>(ketquaAPI);
#else

                        BenhAnMatBanPhanTruocnOnServer = BenhAnMatBanPhanTruocFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnMatBanPhanTruocnOnServer.MaQuanLy != 0) _BenhAn = BenhAnMatBanPhanTruocnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnMatBanPhanTruoc " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnMatChanThuong()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnMatChanThuong " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnMatChanThuong _BenhAn = JsonConvert.DeserializeObject<BenhAnMatChanThuong>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }

                        BenhAnMatChanThuong BenhAnMatChanThuongnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnMatChanThuongnOnServer = JsonConvert.DeserializeObject<BenhAnMatChanThuong>(ketquaAPI);
#else

                        BenhAnMatChanThuongnOnServer = BenhAnMatChanThuongFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnMatChanThuongnOnServer.MaQuanLy != 0) _BenhAn = BenhAnMatChanThuongnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnMatChanThuong " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnMatDayMat()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnMatDayMat " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnMatDayMat _BenhAn = JsonConvert.DeserializeObject<BenhAnMatDayMat>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnMatDayMat BenhAnMatDayMatnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnMatDayMatnOnServer = JsonConvert.DeserializeObject<BenhAnMatDayMat>(ketquaAPI);
#else

                        BenhAnMatDayMatnOnServer = BenhAnMatDayMatFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnMatDayMatnOnServer.MaQuanLy != 0) _BenhAn = BenhAnMatDayMatnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnMatDayMat " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnMatGlocom()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnMatGlocom " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnMatGlocom _BenhAn = JsonConvert.DeserializeObject<BenhAnMatGlocom>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnMatGlocom BenhAnMatGlocomnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnMatGlocomnOnServer = JsonConvert.DeserializeObject<BenhAnMatGlocom>(ketquaAPI);
#else

                        BenhAnMatGlocomnOnServer = BenhAnMatGlocomFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy, XemBenhAn._ThongTinDieuTri);
#endif

                        if (BenhAnMatGlocomnOnServer.MaQuanLy != 0) _BenhAn = BenhAnMatGlocomnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnMatGlocom " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnMatLac()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnMatLac " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnMatLac _BenhAn = JsonConvert.DeserializeObject<BenhAnMatLac>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnMatLac BenhAnMatLacnOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnMatLacnOnServer = JsonConvert.DeserializeObject<BenhAnMatLac>(ketquaAPI);
#else

                        BenhAnMatLacnOnServer = BenhAnMatLacFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnMatLacnOnServer.MaQuanLy != 0) _BenhAn = BenhAnMatLacnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnMatLac " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnMatTreem()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnMatTreem " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnMatTreEm _BenhAn = JsonConvert.DeserializeObject<BenhAnMatTreEm>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnMatTreEm BenhAnMatTreEmnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnMatTreEmnOnServer = JsonConvert.DeserializeObject<BenhAnMatTreEm>(ketquaAPI);
#else

                        BenhAnMatTreEmnOnServer = BenhAnMatTreEmFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnMatTreEmnOnServer.MaQuanLy != 0) _BenhAn = BenhAnMatTreEmnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnMatTreem " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnNgoaiTruYHCT()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTruYHCT " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTruYHCT _BenhAn = null;
                        try
                        {
                            _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTruYHCT>(XemBenhAn.JsonInput);
                            if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        }
                        catch { }

                        if (_BenhAn == null)
                        {
                            _BenhAn = new BenhAnNgoaiTruYHCT();
                            _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy;
                        }
                        // 
                        BenhAnNgoaiTruYHCT BenhAnNgoaiTruYHCTnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTruYHCTnOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTruYHCT>(ketquaAPI);
#else

                        BenhAnNgoaiTruYHCTnOnServer = BenhAnNgoaiTruYHCTFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnNgoaiTruYHCTnOnServer.MaQuanLy != 0) _BenhAn = BenhAnNgoaiTruYHCTnOnServer;

                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();

                        _BenhAn.NgayKhamBenh = _BenhAn.NgayKhamBenh == Convert.ToDateTime(null) ? DateTime.Now : _BenhAn.NgayKhamBenh;
                        _BenhAn.NgayTongKet = _BenhAn.NgayTongKet == Convert.ToDateTime(null) ? DateTime.Now : _BenhAn.NgayTongKet;

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTruYHCT " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnNoiTruYHCT()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNoiTruYHCT " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnNoiTruYHCT _BenhAn = JsonConvert.DeserializeObject<BenhAnNoiTruYHCT>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNoiTruYHCT BenhAnNoiTruYHCTnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNoiTruYHCTnOnServer = JsonConvert.DeserializeObject<BenhAnNoiTruYHCT>(ketquaAPI);
#else

                        BenhAnNoiTruYHCTnOnServer = BenhAnNoiTruYHCTFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnNoiTruYHCTnOnServer.MaQuanLy != 0)
                        {
                            _BenhAn = BenhAnNoiTruYHCTnOnServer;
                        }
                        else
                        {
                            _BenhAn.MachTayTrai_Thon1 = Common.ConVSpecial(_BenhAn.MachTayTrai_Thon1);
                            _BenhAn.MachTayTrai_Thon2 = Common.ConVSpecial(_BenhAn.MachTayTrai_Thon2);
                            _BenhAn.MachTayTrai_Thon3 = Common.ConVSpecial(_BenhAn.MachTayTrai_Thon3);
                            _BenhAn.MachTayTrai_Quan1 = Common.ConVSpecial(_BenhAn.MachTayTrai_Quan1);
                            _BenhAn.MachTayTrai_Quan2 = Common.ConVSpecial(_BenhAn.MachTayTrai_Quan2);
                            _BenhAn.MachTayTrai_Quan3 = Common.ConVSpecial(_BenhAn.MachTayTrai_Quan3);
                            _BenhAn.MachTayTrai_Xich1 = Common.ConVSpecial(_BenhAn.MachTayTrai_Xich1);
                            _BenhAn.MachTayTrai_Xich2 = Common.ConVSpecial(_BenhAn.MachTayTrai_Xich2);
                            _BenhAn.MachTayTrai_Xich3 = Common.ConVSpecial(_BenhAn.MachTayTrai_Xich3);
                            _BenhAn.MachTayPhai_Thon1 = Common.ConVSpecial(_BenhAn.MachTayPhai_Thon1);
                            _BenhAn.MachTayPhai_Thon2 = Common.ConVSpecial(_BenhAn.MachTayPhai_Thon2);
                            _BenhAn.MachTayPhai_Thon3 = Common.ConVSpecial(_BenhAn.MachTayPhai_Thon3);
                            _BenhAn.MachTayPhai_Quan1 = Common.ConVSpecial(_BenhAn.MachTayPhai_Quan1);
                            _BenhAn.MachTayPhai_Quan2 = Common.ConVSpecial(_BenhAn.MachTayPhai_Quan2);
                            _BenhAn.MachTayPhai_Quan3 = Common.ConVSpecial(_BenhAn.MachTayPhai_Quan3);
                            _BenhAn.MachTayPhai_Xich1 = Common.ConVSpecial(_BenhAn.MachTayPhai_Xich1);
                            _BenhAn.MachTayPhai_Xich2 = Common.ConVSpecial(_BenhAn.MachTayPhai_Xich2);
                            _BenhAn.MachTayPhai_Xich3 = Common.ConVSpecial(_BenhAn.MachTayPhai_Xich3);

                            _BenhAn.HOSOKQ_CTSCANNER = XemBenhAn._ThongTinDieuTri.HoSo.CTScanner.ToString();
                            _BenhAn.HOSOKQ_XQUANG = XemBenhAn._ThongTinDieuTri.HoSo.XQuang.ToString();
                            _BenhAn.HOSOKQ_KHAC = XemBenhAn._ThongTinDieuTri.HoSo.Khac.ToString();
                            _BenhAn.HOSOKQ_KHAC_TXT = XemBenhAn._ThongTinDieuTri.HoSo.Khac_Text;
                            _BenhAn.HOSOKQ_TOANBOHOSO = XemBenhAn._ThongTinDieuTri.HoSo.ToanBoHoSo.ToString();
                        }
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNoiTruYHCT " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnXaPhuong()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnXaPhuong " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnXaPhuong _BenhAn = null;
                        try
                        {
                            _BenhAn = JsonConvert.DeserializeObject<BenhAnXaPhuong>(XemBenhAn.JsonInput);
                        }
                        catch { }
                        if (_BenhAn == null)
                        {
                            _BenhAn = new BenhAnXaPhuong();
                            _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy;
                        }
                        // 
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }

                        BenhAnXaPhuong BenhAnXaPhuongnOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnXaPhuongnOnServer = JsonConvert.DeserializeObject<BenhAnXaPhuong>(ketquaAPI);
#else

                        BenhAnXaPhuongnOnServer = BenhAnXaPhuongFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnXaPhuongnOnServer.MaQuanLy != 0) _BenhAn = BenhAnXaPhuongnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnXaPhuong " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnDieuTriBanNgay()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnDieuTriBanNgay " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        // 
                        BenhAnDieuTriBanNgay _BenhAn = JsonConvert.DeserializeObject<BenhAnDieuTriBanNgay>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnDieuTriBanNgay BenhAnDieuTriBanNgayOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null,null);
                        BenhAnDieuTriBanNgayOnServer = JsonConvert.DeserializeObject<BenhAnDieuTriBanNgay>(ketquaAPI);
#else

                        BenhAnDieuTriBanNgayOnServer = BenhAnDieuTriBanNgayFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnDieuTriBanNgayOnServer.MaQuanLy != 0) _BenhAn = BenhAnDieuTriBanNgayOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnDieuTriBanNgay " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnThanNhanTao()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                {
                    var timer = new Stopwatch();
                    timer.Start();
                    log.Info("++++++++++Start LoadBenhAnThanNhanTao " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    try
                    {
                        BenhAnThanNhanTao _BenhAn = JsonConvert.DeserializeObject<BenhAnThanNhanTao>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnThanNhanTao BenhAnThanNhanTaoOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnThanNhanTaoOnServer = JsonConvert.DeserializeObject<BenhAnThanNhanTao>(ketquaAPI);
#else

                        BenhAnThanNhanTaoOnServer = BenhAnThanNhanTaoFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnThanNhanTaoOnServer.MaQuanLy != 0) _BenhAn = BenhAnThanNhanTaoOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnThanNhanTao " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        private object LoadBenhAnTayChanMieng()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                {
                    var timer = new Stopwatch();
                    timer.Start();
                    log.Info("++++++++++Start LoadBenhAnTayChanMieng " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    try
                    {
                        BenhAnTayChanMieng _BenhAn = JsonConvert.DeserializeObject<BenhAnTayChanMieng>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnTayChanMieng BenhAnTayChanMiengOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnTayChanMiengOnServer = JsonConvert.DeserializeObject<BenhAnTayChanMieng>(ketquaAPI);
#else

                        BenhAnTayChanMiengOnServer = BenhAnTayChanMiengFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnTayChanMiengOnServer.MaQuanLy != 0) _BenhAn = BenhAnTayChanMiengOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnTayChanMieng " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnMat()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                {
                    var timer = new Stopwatch();
                    timer.Start();
                    log.Info("++++++++++Start LoadBenhAnMat " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    try
                    {
                        BenhAnMat _BenhAn = JsonConvert.DeserializeObject<BenhAnMat>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnMat BenhAnMatOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnMatOnServer = JsonConvert.DeserializeObject<BenhAnMat>(ketquaAPI);
#else

                        BenhAnMatOnServer = BenhAnMatFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnMatOnServer.MaQuanLy != 0) _BenhAn = BenhAnMatOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnMat " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnNgoaiTruMat()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                {
                    var timer = new Stopwatch();
                    timer.Start();
                    log.Info("++++++++++Start LoadBenhAnNgoaiTruMat " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                    try
                    {
                        BenhAnNgoaiTruMat _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTruMat>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTruMat BenhAnNgoaiTruMatOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTruMatOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTruMat>(ketquaAPI);
#else

                        BenhAnNgoaiTruMatOnServer = BenhAnNgoaiTruMatFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnNgoaiTruMatOnServer.MaQuanLy != 0) _BenhAn = BenhAnNgoaiTruMatOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTruMat " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        private object LoadBenhAnTim()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnTim " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnTim _BenhAn = JsonConvert.DeserializeObject<BenhAnTim>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnTim BenhAnTimOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnTimOnServer = JsonConvert.DeserializeObject<BenhAnTim>(ketquaAPI);
#else

                        BenhAnTimOnServer = BenhAnTimFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnTimOnServer.MaQuanLy != 0) _BenhAn = BenhAnTimOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.YeuToNguyCoMachVanh == null)
                        {
                            _BenhAn.YeuToNguyCoMachVanh = new NguyCoMachVanh();
                        }
                        if (_BenhAn.BenhNoiKhoa == null)
                        {
                            _BenhAn.BenhNoiKhoa = new BenhNoiKhoa();
                        }
                        if (_BenhAn.TrieuChungCoNang == null)
                        {
                            _BenhAn.TrieuChungCoNang = new TrieuChungCoNang();
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnTim " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        private object LoadBenhAnLuuCapCuu()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnLuuCapCuu " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BenhAnLuuCapCuu _BenhAn = JsonConvert.DeserializeObject<BenhAnLuuCapCuu>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnLuuCapCuu BenhAnLuuCapCuuOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnLuuCapCuuOnServer = JsonConvert.DeserializeObject<BenhAnLuuCapCuu>(ketquaAPI);
#else

                        BenhAnLuuCapCuuOnServer = BenhAnLuuCapCuuFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif




                        if (BenhAnLuuCapCuuOnServer.MaQuanLy != 0) _BenhAn = BenhAnLuuCapCuuOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();

                        if (_BenhAn.RaVienLuc == DateTime.MinValue)
                        {
                            _BenhAn.RaVienLuc = DateTime.Now;
                        }
                        if (_BenhAn.ThongTinYLenhs == null)
                        {
                            _BenhAn.ThongTinYLenhs = new ObservableCollection<ThongTinYLenh>();
                        }
                        if (BenhAnLuuCapCuuOnServer.MaQuanLy == 0 && string.IsNullOrEmpty(_BenhAn.ChanDoanBanDau))
                            _BenhAn.ChanDoanBanDau = XemBenhAn._ThongTinDieuTri.ChanDoanNoiGioiThieu;
                        if (BenhAnLuuCapCuuOnServer.MaQuanLy == 0 && string.IsNullOrEmpty(_BenhAn.ChanDoanKhiRaVien))
                            _BenhAn.ChanDoanKhiRaVien = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                        if (BenhAnLuuCapCuuOnServer.MaQuanLy == 0 && string.IsNullOrEmpty(_BenhAn.MAIDC_ChanDoanKhiRaVien))
                            _BenhAn.MAIDC_ChanDoanKhiRaVien = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnLuuCapCuu " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        private object LoadBANgoaTruPK()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBANgoaiTruPK " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BANgoaiTruPK _BenhAn = JsonConvert.DeserializeObject<BANgoaiTruPK>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BANgoaiTruPK baData = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        baData = JsonConvert.DeserializeObject<BANgoaiTruPK>(ketquaAPI);
#else

                        baData = BANgoaiTruPKFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif




                        if (baData.MaQuanLy != 0) _BenhAn = baData;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();

                        //if (_BenhAn.RaVienLuc == DateTime.MinValue)
                        //{
                        //    _BenhAn.RaVienLuc = DateTime.Now;
                        //}
                        //if (_BenhAn.ThongTinYLenhs == null)
                        //{
                        //    _BenhAn.ThongTinYLenhs = new ObservableCollection<ThongTinYLenh>();
                        //}
                        //if (BenhAnTimOnServer.MaQuanLy == 0 && string.IsNullOrEmpty(_BenhAn.ChanDoanBanDau))
                        //    _BenhAn.ChanDoanBanDau = XemBenhAn._ThongTinDieuTri.ChanDoanNoiGioiThieu;
                        //if (BenhAnTimOnServer.MaQuanLy == 0 && string.IsNullOrEmpty(_BenhAn.ChanDoanKhiRaVien))
                        //    _BenhAn.ChanDoanKhiRaVien = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                        //if (BenhAnTimOnServer.MaQuanLy == 0 && string.IsNullOrEmpty(_BenhAn.MAIDC_ChanDoanKhiRaVien))
                        //    _BenhAn.MAIDC_ChanDoanKhiRaVien = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBANgoaiTruPK " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        private object LoadBenhAnPhaThaiIII()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnPhaThaiIII " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BenhAnPhaThaiIII _BenhAn = JsonConvert.DeserializeObject<BenhAnPhaThaiIII>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnPhaThaiIII BenhAnPhaThaiIIIOnServer;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnPhaThaiIIIOnServer = JsonConvert.DeserializeObject<BenhAnPhaThaiIII>(ketquaAPI);
#else

                        BenhAnPhaThaiIIIOnServer = BenhAnPhaThaiIIIFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnPhaThaiIIIOnServer.MaQuanLy != 0) _BenhAn = BenhAnPhaThaiIIIOnServer;

                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnPhaThaiIII " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        private object LoadBenhAnCMU()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnCMU " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BenhAnCMU _BenhAn = JsonConvert.DeserializeObject<BenhAnCMU>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnCMU BenhAnCMUOnServer;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnCMUOnServer = JsonConvert.DeserializeObject<BenhAnCMU>(ketquaAPI);
#else

                        BenhAnCMUOnServer = BenhAnCMUFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnCMUOnServer.MaQuanLy != 0) _BenhAn = BenhAnCMUOnServer;

                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.Tuoi == null)
                        {
                            _BenhAn.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                        }
                        if (_BenhAn.Gioi == null)
                        {
                            _BenhAn.Gioi = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                        }
                        if (_BenhAn.CanNang == null && XemBenhAn._ThongTinDieuTri.DauSinhTon.CanNang != 0)
                        {
                            _BenhAn.CanNang = XemBenhAn._ThongTinDieuTri.DauSinhTon.CanNang;
                        }
                        if (_BenhAn.ChieuCao == null && XemBenhAn._ThongTinDieuTri.DauSinhTon.ChieuCao != 0)
                        {
                            _BenhAn.ChieuCao = XemBenhAn._ThongTinDieuTri.DauSinhTon.ChieuCao;
                        }
                        if (_BenhAn.BMI == null && XemBenhAn._ThongTinDieuTri.DauSinhTon.BMI != 0)
                        {
                            _BenhAn.BMI = XemBenhAn._ThongTinDieuTri.DauSinhTon.BMI;
                        }
                        if (_BenhAn.Mach == null && XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach != 0)
                        {
                            _BenhAn.Mach = XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach;
                        }
                        if (_BenhAn.Mach == null && XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach != 0)
                        {
                            _BenhAn.Mach = XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach;
                        }
                        if (_BenhAn.NhietDo == null && XemBenhAn._ThongTinDieuTri.DauSinhTon.NhietDo != 0)
                        {
                            _BenhAn.NhietDo = XemBenhAn._ThongTinDieuTri.DauSinhTon.NhietDo;
                        }
                        if (_BenhAn.HuyetAp == null && !string.IsNullOrEmpty(XemBenhAn._ThongTinDieuTri.DauSinhTon.HuyetAp))
                        {
                            _BenhAn.HuyetAp = XemBenhAn._ThongTinDieuTri.DauSinhTon.HuyetAp;
                        }
                        if (_BenhAn.NhipTho == null && XemBenhAn._ThongTinDieuTri.DauSinhTon.NhipTho != 0)
                        {
                            _BenhAn.NhipTho = XemBenhAn._ThongTinDieuTri.DauSinhTon.NhipTho;
                        }

                        if (_BenhAn.XetNghiemCMUs == null)
                        {
                            _BenhAn.XetNghiemCMUs = new ObservableCollection<XetNghiemCMU>();
                            _BenhAn.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FVC(L)" });
                            _BenhAn.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FEV1(L)" });
                            _BenhAn.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FEV1/FVC(%)" });
                            _BenhAn.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "MMEF(L/s)" });
                            _BenhAn.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "PEF(L/s)" });
                            _BenhAn.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FEF25(L/s)" });
                            _BenhAn.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FEF50(L/s)" });
                            _BenhAn.XetNghiemCMUs.Add(new XetNghiemCMU { ThongSo = "FEF75(L/s)" });
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnCMU " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        private object LoadBenhAnPhucHoiChucNangYHCT()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;
                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnPhucHoiChucNangYHCT " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BenhAnPhucHoiChucNangYHCT _BenhAn = JsonConvert.DeserializeObject<BenhAnPhucHoiChucNangYHCT>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnPhucHoiChucNangYHCT BenhAnPhucHoiChucNangYHCTOnServer = null;
#if CLOUD

                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnPhucHoiChucNangYHCTOnServer = JsonConvert.DeserializeObject<BenhAnPhucHoiChucNangYHCT>(ketquaAPI);
#else

                        BenhAnPhucHoiChucNangYHCTOnServer = BenhAnPhucHoiChucNangYHCTFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnPhucHoiChucNangYHCTOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnPhucHoiChucNangYHCTOnServer;
                        else
                        {
                            _BenhAn.MachTayTrai_Thon1 = _BenhAn.MachTayTrai_Thon1 + 1;
                            _BenhAn.MachTayTrai_Thon2 = _BenhAn.MachTayTrai_Thon2 + 1;
                            _BenhAn.MachTayTrai_Thon3 = _BenhAn.MachTayTrai_Thon3 + 1;
                            _BenhAn.MachTayTrai_Thon4 = _BenhAn.MachTayTrai_Thon4 + 1;
                            _BenhAn.MachTayTrai_Quan1 = _BenhAn.MachTayTrai_Quan1 + 1;
                            _BenhAn.MachTayTrai_Quan2 = _BenhAn.MachTayTrai_Quan2 + 1;
                            _BenhAn.MachTayTrai_Quan3 = _BenhAn.MachTayTrai_Quan3 + 1;
                            _BenhAn.MachTayTrai_Quan4 = _BenhAn.MachTayTrai_Quan4 + 1;
                            _BenhAn.MachTayTrai_Xich1 = _BenhAn.MachTayTrai_Xich1 + 1;
                            _BenhAn.MachTayTrai_Xich2 = _BenhAn.MachTayTrai_Xich2 + 1;
                            _BenhAn.MachTayTrai_Xich3 = _BenhAn.MachTayTrai_Xich3 + 1;
                            _BenhAn.MachTayTrai_Xich4 = _BenhAn.MachTayTrai_Xich4 + 1;
                            _BenhAn.MachTayPhai_Thon1 = _BenhAn.MachTayPhai_Thon1 + 1;
                            _BenhAn.MachTayPhai_Thon2 = _BenhAn.MachTayPhai_Thon2 + 1;
                            _BenhAn.MachTayPhai_Thon3 = _BenhAn.MachTayPhai_Thon3 + 1;
                            _BenhAn.MachTayPhai_Thon4 = _BenhAn.MachTayPhai_Thon4 + 1;
                            _BenhAn.MachTayPhai_Quan1 = _BenhAn.MachTayPhai_Quan1 + 1;
                            _BenhAn.MachTayPhai_Quan2 = _BenhAn.MachTayPhai_Quan2 + 1;
                            _BenhAn.MachTayPhai_Quan3 = _BenhAn.MachTayPhai_Quan3 + 1;
                            _BenhAn.MachTayPhai_Quan4 = _BenhAn.MachTayPhai_Quan4 + 1;
                            _BenhAn.MachTayPhai_Xich1 = _BenhAn.MachTayPhai_Xich1 + 1;
                            _BenhAn.MachTayPhai_Xich2 = _BenhAn.MachTayPhai_Xich2 + 1;
                            _BenhAn.MachTayPhai_Xich3 = _BenhAn.MachTayPhai_Xich3 + 1;
                            _BenhAn.MachTayPhai_Xich4 = _BenhAn.MachTayPhai_Xich4 + 1;

                            _BenhAn.HOSOKQ_CTSCANNER = XemBenhAn._ThongTinDieuTri.HoSo.CTScanner.ToString();
                            _BenhAn.HOSOKQ_XQUANG = XemBenhAn._ThongTinDieuTri.HoSo.XQuang.ToString();
                            _BenhAn.HOSOKQ_SIEUAM = XemBenhAn._ThongTinDieuTri.HoSo.SieuAm.ToString();
                            _BenhAn.HOSOKQ_XETNGHIEM = XemBenhAn._ThongTinDieuTri.HoSo.XetNghiem.ToString();
                            _BenhAn.HOSOKQ_KHAC = XemBenhAn._ThongTinDieuTri.HoSo.Khac.ToString();
                            _BenhAn.HOSOKQ_KHAC_TXT = XemBenhAn._ThongTinDieuTri.HoSo.Khac_Text;
                            _BenhAn.HOSOKQ_TOANBOHOSO = XemBenhAn._ThongTinDieuTri.HoSo.ToanBoHoSo.ToString();

                        }

                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnPhucHoiChucNangYHCT " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnNgoaiTruPHCN()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTruPHCN " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTruPHCN _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTruPHCN>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTruPHCN BenhAnNgoaiTruPHCNOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTruPHCNOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTruPHCN>(ketquaAPI);
#else

                        BenhAnNgoaiTruPHCNOnServer = BenhAnNgoaiTruPHCNFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnNgoaiTruPHCNOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnNgoaiTruPHCNOnServer;
                        else
                        {
                            _BenhAn.DieuTriNgoaiTru_TuNgay = (XemBenhAn._ThongTinDieuTri.NgayVaoVien != null && !DateTime.MinValue.Equals(XemBenhAn._ThongTinDieuTri.NgayVaoVien)) ? Convert.ToDateTime(XemBenhAn._ThongTinDieuTri.NgayVaoVien) : Convert.ToDateTime(null);
                            _BenhAn.DieuTriNgoaiTru_DenNgay = (XemBenhAn._ThongTinDieuTri.NgayRaVien != null && !DateTime.MinValue.Equals(XemBenhAn._ThongTinDieuTri.NgayRaVien)) ? Convert.ToDateTime(XemBenhAn._ThongTinDieuTri.NgayRaVien) : DateTime.Now;
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                            _BenhAn.MaICD_BenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.MaICD_BenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                            _BenhAn.ChanDoanKhiRaVien = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.MAIDC_ChanDoanKhiRaVien = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.IDGiamDoc = XemBenhAn._ThongTinDieuTri.MaGiamDocBenhVien;
                        }
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTru " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnPHCNNhi()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnPHCNNhi " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnPHCNNhi _BenhAn = JsonConvert.DeserializeObject<BenhAnPHCNNhi>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnPHCNNhi BenhAnPHCNNhiOnServer = null;
                        string ketquaAPI = "";
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnPHCNNhiOnServer = JsonConvert.DeserializeObject<BenhAnPHCNNhi>(ketquaAPI);
#else

                        BenhAnPHCNNhiOnServer = BenhAnPHCNNhiFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnPHCNNhiOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnPHCNNhiOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnPHCNNhi " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnPHCNII()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnPHCNII " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnPHCNII _BenhAn = JsonConvert.DeserializeObject<BenhAnPHCNII>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnPHCNII BenhAnPHCNIIOnServer = null;
                        string ketquaAPI = "";
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnPHCNIIOnServer = JsonConvert.DeserializeObject<BenhAnPHCNII>(ketquaAPI);
#else

                        BenhAnPHCNIIOnServer = BenhAnPHCNIIFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnPHCNIIOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnPHCNIIOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnPHCNII " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnDaLieuTW()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnDaLieuTW " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        //
                        BenhAnDaLieuTW _BenhAn = JsonConvert.DeserializeObject<BenhAnDaLieuTW>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnDaLieuTW BenhAnDaLieuTWnOnServer = null;
                        string ketquaAPI = "";
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnDaLieuTWnOnServer = JsonConvert.DeserializeObject<BenhAnDaLieuTW>(ketquaAPI);
#else

                        BenhAnDaLieuTWnOnServer = BenhAnDaLieuTWFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif


                        if (BenhAnDaLieuTWnOnServer.MaQuanLy != 0) _BenhAn = BenhAnDaLieuTWnOnServer;
                        if (_BenhAn.DacDiemLienQuanBenh == null) _BenhAn.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                        if (_BenhAn.HoSo == null) _BenhAn.HoSo = new HoSo();
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.NgayKhamBenh == DateTime.MinValue)
                        {
                            _BenhAn.NgayKhamBenh = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnDaLieuTW " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
        object LoadBenhAnNgoaiTru_VayNenThuongThuong()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTru_VayNenThuongThuong " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTru_BenhVayNenThongThuong _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTru_BenhVayNenThongThuong>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTru_BenhVayNenThongThuong BenhAnNgoaiTru_BenhVayNenThongThuongOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTru_BenhVayNenThongThuongOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTru_BenhVayNenThongThuong>(ketquaAPI);
#else

                        BenhAnNgoaiTru_BenhVayNenThongThuongOnServer = BenhAnNgoaiTru_BenhVayNenThongThuongFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnNgoaiTru_BenhVayNenThongThuongOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnNgoaiTru_BenhVayNenThongThuongOnServer;
                        else
                        {
                            _BenhAn.TK_BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.TK_MaBenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.TK_BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                            _BenhAn.TK_MaBenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if(_BenhAn.Methotrexate == null)
                            _BenhAn.Methotrexate = new ThuocToanThan();
                        if (_BenhAn.VitaminAAcid == null)
                            _BenhAn.VitaminAAcid = new ThuocToanThan();
                        if (_BenhAn.Cyclosporine == null)
                            _BenhAn.Cyclosporine = new ThuocToanThan();
                        if (_BenhAn.Corticosteroid == null)
                            _BenhAn.Corticosteroid = new ThuocToanThan();
                        if (_BenhAn.ChePhamSinhHoc1 == null)
                            _BenhAn.ChePhamSinhHoc1 = new ThuocToanThan();
                        if (_BenhAn.ChePhamSinhHoc2 == null)
                            _BenhAn.ChePhamSinhHoc2 = new ThuocToanThan();
                        if (_BenhAn.ChePhamSinhHoc3 == null)
                            _BenhAn.ChePhamSinhHoc3 = new ThuocToanThan();
                        if (_BenhAn.YHocCoTruyen == null)
                            _BenhAn.YHocCoTruyen = new ThuocToanThan();
                        if (_BenhAn.ThuocKhac == null)
                            _BenhAn.ThuocKhac = new ThuocToanThan();
                        if (_BenhAn.NAPSI_TayPhai == null)
                            _BenhAn.NAPSI_TayPhai = new DiemNAPSI();
                        if (_BenhAn.NAPSI_TayTrai == null)
                            _BenhAn.NAPSI_TayTrai = new DiemNAPSI();
                        if (_BenhAn.NAPSI_ChanPhai == null)
                            _BenhAn.NAPSI_ChanPhai = new DiemNAPSI();
                        if (_BenhAn.NAPSI_ChanTrai == null)
                            _BenhAn.NAPSI_ChanTrai = new DiemNAPSI();
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTru_VayNenThuongThuong " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnNgoaiTru_AVayNen()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTru_AVayNen " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTruAVayNen _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTruAVayNen>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTruAVayNen BenhAnNgoaiTruAVayNenOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTruAVayNenOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTruAVayNen>(ketquaAPI);
#else
                        BenhAnNgoaiTruAVayNenOnServer = BenhAnNgoaiTruAVayNenFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (BenhAnNgoaiTruAVayNenOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnNgoaiTruAVayNenOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                           
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTru_AVayNen " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnNgoaiTru_HoTroSinhSan()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTru_HoTroSinhSan " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTru_HoTroSinhSan _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTru_HoTroSinhSan>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTru_HoTroSinhSan BenhAnNgoaiTru_HoTroSinhSanOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTru_HoTroSinhSanOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTru_HoTroSinhSan>(ketquaAPI);
#else
                        BenhAnNgoaiTru_HoTroSinhSanOnServer = BenhAnNgoaiTru_HoTroSinhSanFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnNgoaiTru_HoTroSinhSanOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnNgoaiTru_HoTroSinhSanOnServer;
                        else
                        {
                            _BenhAn.ChanDoanBanDau = XemBenhAn._ThongTinDieuTri.ChanDoanNoiGioiThieu;
                            _BenhAn.ChanDoanKhiRaVien = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.ChanDoan = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.TienSuSanKhoaVo == null)
                            _BenhAn.TienSuSanKhoaVo = new ObservableCollection<TienSuSanKhoaVo>();
                        if (_BenhAn.PhieuTheoDoiNangNoan == null)
                            _BenhAn.PhieuTheoDoiNangNoan = new ObservableCollection<PhieuTheoDoiNangNoan>();
                        if (_BenhAn.PhieuTheoDoiNoiMac == null)
                            _BenhAn.PhieuTheoDoiNoiMac = new ObservableCollection<PhieuTheoDoiNoiMac>();
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTru_HoTroSinhSan " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnNgoaiTru_ViemBiCo()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTru_ViemBiCo " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTru_ViemBiCo _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTru_ViemBiCo>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTru_ViemBiCo BenhAnNgoaiTru_ViemBiCoOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTru_ViemBiCoOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTru_ViemBiCo>(ketquaAPI);
#else
                        BenhAnNgoaiTru_ViemBiCoOnServer = BenhAnNgoaiTru_ViemBiCoFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnNgoaiTru_ViemBiCoOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnNgoaiTru_ViemBiCoOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.MaBenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                            _BenhAn.MaBenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.CoGapCanhTay == null)
                            _BenhAn.CoGapCanhTay = new TrieuChungCo();
                        if (_BenhAn.CoDuoiCanhTay == null)
                            _BenhAn.CoDuoiCanhTay = new TrieuChungCo();
                        if (_BenhAn.CoGapDui == null)
                            _BenhAn.CoGapDui = new TrieuChungCo();
                        if (_BenhAn.CoDuoiDui == null)
                            _BenhAn.CoDuoiDui = new TrieuChungCo();
                        if (_BenhAn.TK_CoGapCanhTay == null)
                            _BenhAn.TK_CoGapCanhTay = new TrieuChungCo();
                        if (_BenhAn.TK_CoDuoiCanhTay == null)
                            _BenhAn.TK_CoDuoiCanhTay = new TrieuChungCo();
                        if (_BenhAn.TK_CoGapDui == null)
                            _BenhAn.TK_CoGapDui = new TrieuChungCo();
                        if (_BenhAn.TK_CoDuoiDui == null)
                            _BenhAn.TK_CoDuoiDui = new TrieuChungCo();

                        if (_BenhAn.TS_Corticosteroid == null)
                            _BenhAn.TS_Corticosteroid = new TienSuDieuTri();
                        if (_BenhAn.TS_CyclophosphamidLieuCao == null)
                            _BenhAn.TS_CyclophosphamidLieuCao = new TienSuDieuTri();
                        if (_BenhAn.TS_Azathioprine == null)
                            _BenhAn.TS_Azathioprine = new TienSuDieuTri();
                        if (_BenhAn.TS_Methotrexate == null)
                            _BenhAn.TS_Methotrexate = new TienSuDieuTri();
                        if (_BenhAn.TS_CyclosporineA == null)
                            _BenhAn.TS_CyclosporineA = new TienSuDieuTri();

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTru_ViemBiCo " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnNgoaiTru_LupusBanDoHeThong()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTru_LupusBanDoHeThong " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTru_LupusBanDoHeThong _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTru_LupusBanDoHeThong>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTru_LupusBanDoHeThong BenhAnNgoaiTru_LupusBanDoHeThongOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTru_LupusBanDoHeThongOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTru_LupusBanDoHeThong>(ketquaAPI);
#else
                        BenhAnNgoaiTru_LupusBanDoHeThongOnServer = BenhAnNgoaiTru_LupusBanDoHeThongFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif

                        if (BenhAnNgoaiTru_LupusBanDoHeThongOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnNgoaiTru_LupusBanDoHeThongOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.MaBenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                            _BenhAn.MaBenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if (_BenhAn.Corticosteroid == null)
                            _BenhAn.Corticosteroid = new ThuocToanThan();
                        if (_BenhAn.KhangSotRet == null)
                            _BenhAn.KhangSotRet = new ThuocToanThan();
                        if (_BenhAn.Cyclophosphamide == null)
                            _BenhAn.Cyclophosphamide = new ThuocToanThan();
                        if (_BenhAn.CyclophosphamideLieuCao == null)
                            _BenhAn.CyclophosphamideLieuCao = new ThuocToanThan();
                        if (_BenhAn.Methotrexate == null)
                            _BenhAn.Methotrexate = new ThuocToanThan();
                        if (_BenhAn.CyclosporineA == null)
                            _BenhAn.CyclosporineA = new ThuocToanThan();
                        if (_BenhAn.ThuocKhac == null)
                            _BenhAn.ThuocKhac = new ThuocToanThan();


                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTru_LupusBanDoHeThong " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }

        object LoadBenhAnNgoaiTru_PEMPHIGOID()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTru_PEMPHIGOID " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTruPemphigoid _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTruPemphigoid>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTruPemphigoid BenhAnNgoaiTruPemphigoidOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTruPemphigoidOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTruPemphigoid>(ketquaAPI);
#else
                        BenhAnNgoaiTruPemphigoidOnServer = BenhAnNgoaiTruPemphigoidFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (BenhAnNgoaiTruPemphigoidOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnNgoaiTruPemphigoidOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                            _BenhAn.MaBenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.MaBenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End BenhAnNgoaiTruPemphigoid " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnNgoaiTru_VayPhanDoNangLong()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTru_VayPhanDoNangLong " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTru_VayPhanDoNangLong _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTru_VayPhanDoNangLong>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTru_VayPhanDoNangLong BenhAnNgoaiTru_VayPhanDoNangLongOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        BenhAnNgoaiTru_VayPhanDoNangLongOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTru_VayPhanDoNangLong>(ketquaAPI);
#else
                        BenhAnNgoaiTru_VayPhanDoNangLongOnServer = BenhAnNgoaiTru_VayPhanDoNangLongFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (BenhAnNgoaiTru_VayPhanDoNangLongOnServer.MaQuanLy != 0)
                            _BenhAn = BenhAnNgoaiTru_VayPhanDoNangLongOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                            _BenhAn.MaBenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.MaBenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End BenhAnNgoaiTru_VayPhanDoNangLong " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnNgoaiTru_LuPusBanDoManTinh()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTru_LuPusBanDoManTinh " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTru_LuPusBanDoManTinh _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTru_LuPusBanDoManTinh>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTru_LuPusBanDoManTinh _LuPusBanDoManTinhOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _LuPusBanDoManTinhOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTru_LuPusBanDoManTinh>(ketquaAPI);
#else
                        _LuPusBanDoManTinhOnServer = BenhAnNgoaiTru_LuPusBanDoManTinhFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_LuPusBanDoManTinhOnServer.MaQuanLy != 0)
                            _BenhAn = _LuPusBanDoManTinhOnServer;
                        else
                        {
                            _BenhAn.TK_BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.TK_BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                            _BenhAn.TK_MaBenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.TK_MaBenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTru_LuPusBanDoManTinh " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnNgoaiTru_VayNenTheMu()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTru_VayNenTheMu " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTru_BenhVayNenTheMu _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTru_BenhVayNenTheMu>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        if (string.IsNullOrEmpty(_BenhAn.ChanDoanTheoGGP))
                        {
                            _BenhAn.ChanDoanTheoGGP = "    Mụn mủ nguyên phát, vô khuẩn nhìn thấy được bằng mắt thường ở trên da mà không phải là đầu chi (ngoại trừ các trường hợp mụn mủ giới hạn trên tổn thương vảy nến thông thường):\n" +
"* Có hoặc không có biểu hiện viêm toàn thân\n" +
"*Có hoặc không có vảy nến thể mảng\n" +
"* Tái phát( > 1 lần) hoặc kéo dài(> 3 tháng)";
                        }
                        if (string.IsNullOrEmpty(_BenhAn.ChanDoanVayNen))
                        {
                            _BenhAn.ChanDoanVayNen = "Chủ yếu đựa vào lâm sàng (nếu là vảy nến mủ khu trú thì không phải đánh giá JDA Score hay PASI cho GPP)";
                        }
                        BenhAnNgoaiTru_BenhVayNenTheMu _BenhAnNgoaiTru_BenhVayNenTheMuOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnNgoaiTru_BenhVayNenTheMuOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTru_BenhVayNenTheMu>(ketquaAPI);
#else

                        _BenhAnNgoaiTru_BenhVayNenTheMuOnServer = BenhAnNgoaiTru_BenhVayNenTheMuFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnNgoaiTru_BenhVayNenTheMuOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnNgoaiTru_BenhVayNenTheMuOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                            _BenhAn.MaBenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.MaBenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        if(_BenhAn.DauMatCo == null)
                        {
                            _BenhAn.DauMatCo = new ViTriTonThuong();
                        }
                        if (_BenhAn.ChiTren == null)
                        {
                            _BenhAn.ChiTren = new ViTriTonThuong();
                        }
                        if (_BenhAn.ThanTruoc == null)
                        {
                            _BenhAn.ThanTruoc = new ViTriTonThuong();
                        }
                        if (_BenhAn.ThanSau == null)
                        {
                            _BenhAn.ThanSau = new ViTriTonThuong();
                        }
                        if (_BenhAn.ChiDuoi == null)
                        {
                            _BenhAn.ChiDuoi = new ViTriTonThuong();
                        }
                        if (_BenhAn.BoPhanSD == null)
                        {
                            _BenhAn.BoPhanSD = new ViTriTonThuong();
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTru_VayNenTheMu " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnNgoaiTruDuhringBrocq()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTruDuhringBrocq " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTruDuhringBrocq _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTruDuhringBrocq>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTruDuhringBrocq _BenhAnNgoaiTruDuhringBrocqOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnNgoaiTruDuhringBrocqOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTruDuhringBrocq>(ketquaAPI);
#else

                        _BenhAnNgoaiTruDuhringBrocqOnServer = BenhAnNgoaiTruDuhringBrocqFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnNgoaiTruDuhringBrocqOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnNgoaiTruDuhringBrocqOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                            _BenhAn.MaBenhChinh = XemBenhAn._ThongTinDieuTri.MaICD_BenhChinh_RaVien;
                            _BenhAn.MaBenhKemTheo = XemBenhAn._ThongTinDieuTri.MaICD_BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTruDuhringBrocq " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnDaiThaoDuong()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnDaiThaoDuong " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnDaiThaoDuong _BenhAn = JsonConvert.DeserializeObject<BenhAnDaiThaoDuong>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnDaiThaoDuong _BenhAnDaiThaoDuongOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnDaiThaoDuongOnServer = JsonConvert.DeserializeObject<BenhAnDaiThaoDuong>(ketquaAPI);
#else

                        _BenhAnDaiThaoDuongOnServer = BenhAnDaiThaoDuongFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnDaiThaoDuongOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnDaiThaoDuongOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                        }

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnDaiThaoDuong " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnUngThuHacTo()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnUngThuHacTo " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnUngThuHacTo _BenhAn = JsonConvert.DeserializeObject<BenhAnUngThuHacTo>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnUngThuHacTo _BenhAnUngThuHacToOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnUngThuHacToOnServer = JsonConvert.DeserializeObject<BenhAnUngThuHacTo>(ketquaAPI);
#else

                        _BenhAnUngThuHacToOnServer = BenhAnUngThuHacToFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnUngThuHacToOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnUngThuHacToOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                        }
                        if(_BenhAn.TheoDoiDieuTris == null)
                        {
                            _BenhAn.TheoDoiDieuTris = new ObservableCollection<TheoDoiDieuTri_BAUngThuDaHacTo>();
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "3 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "6 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "9 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "12 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "18 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "24 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "30 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "36 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "4 Năm" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "5 Năm" });
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnUngThuHacTo " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnUngThuKhongHacTo()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnUngThuKhongHacTo " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnUngThuKhongHacTo _BenhAn = JsonConvert.DeserializeObject<BenhAnUngThuKhongHacTo>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnUngThuKhongHacTo _BenhAnUngThuKhongHacToOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnUngThuKhongHacToOnServer = JsonConvert.DeserializeObject<BenhAnUngThuKhongHacTo>(ketquaAPI);
#else

                        _BenhAnUngThuKhongHacToOnServer = BenhAnUngThuKhongHacToFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnUngThuKhongHacToOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnUngThuKhongHacToOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.TheoDoiDieuTris == null)
                        {
                            _BenhAn.TheoDoiDieuTris = new ObservableCollection<TheoDoiDieuTri_BAUngThuDaHacTo>();
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "3 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "6 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "9 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "12 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "18 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "24 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "30 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "36 tháng" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "4 Năm" });
                            _BenhAn.TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "5 Năm" });
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnUngThuKhongHacTo " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnNgoaiTruPemphigus()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTruPemphigus " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTruPemphigus _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTruPemphigus>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTruPemphigus _BenhAnNgoaiTruPemphigusOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnNgoaiTruPemphigusOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTruPemphigus>(ketquaAPI);
#else

                        _BenhAnNgoaiTruPemphigusOnServer = BenhAnNgoaiTruPemphigusFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnNgoaiTruPemphigusOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnNgoaiTruPemphigusOnServer;
                        else
                        {
                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTruPemphigus " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnVayNenTheKhop()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnVayNenTheKhop " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnVayNenTheKhop _BenhAn = JsonConvert.DeserializeObject<BenhAnVayNenTheKhop>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnVayNenTheKhop _BenhAnVayNenTheKhopOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnVayNenTheKhopOnServer = JsonConvert.DeserializeObject<BenhAnVayNenTheKhop>(ketquaAPI);
#else

                        _BenhAnVayNenTheKhopOnServer = BenhAnVayNenTheKhopFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnVayNenTheKhopOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnVayNenTheKhopOnServer;
                        else
                        {
                            _BenhAn.NhietDo = XemBenhAn._ThongTinDieuTri.DauSinhTon.NhietDo.HasValue ? XemBenhAn._ThongTinDieuTri.DauSinhTon.NhietDo.Value + "" : "";
                            _BenhAn.Mach = XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach.HasValue ? XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach.Value + "" : "";
                            _BenhAn.HA = XemBenhAn._ThongTinDieuTri.DauSinhTon.HuyetAp;
                            _BenhAn.Can = XemBenhAn._ThongTinDieuTri.DauSinhTon.CanNang.HasValue ? XemBenhAn._ThongTinDieuTri.DauSinhTon.CanNang.Value + "" : "";
                            _BenhAn.Cao = XemBenhAn._ThongTinDieuTri.DauSinhTon.ChieuCao.HasValue ? XemBenhAn._ThongTinDieuTri.DauSinhTon.ChieuCao.Value + "" : "";

                            _BenhAn.TK_NhietDo = XemBenhAn._ThongTinDieuTri.DauSinhTon.NhietDo.HasValue ? XemBenhAn._ThongTinDieuTri.DauSinhTon.NhietDo.Value + "" : "";
                            _BenhAn.TK_Mach = XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach.HasValue ? XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach.Value + "" : "";
                            _BenhAn.TK_HA = XemBenhAn._ThongTinDieuTri.DauSinhTon.HuyetAp;
                            _BenhAn.TK_Can = XemBenhAn._ThongTinDieuTri.DauSinhTon.CanNang.HasValue ? XemBenhAn._ThongTinDieuTri.DauSinhTon.CanNang.Value + "" : "";
                            _BenhAn.TK_Cao = XemBenhAn._ThongTinDieuTri.DauSinhTon.ChieuCao.HasValue ? XemBenhAn._ThongTinDieuTri.DauSinhTon.ChieuCao.Value + "" : "";


                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnVayNenTheKhop " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnNgoaiTru_HoiChungTrungLap()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnNgoaiTru_HoiChungTrungLap " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnNgoaiTru_HoiChungTrungLap _BenhAn = JsonConvert.DeserializeObject<BenhAnNgoaiTru_HoiChungTrungLap>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnNgoaiTru_HoiChungTrungLap _BenhAnNgoaiTru_HoiChungTrungLapOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnNgoaiTru_HoiChungTrungLapOnServer = JsonConvert.DeserializeObject<BenhAnNgoaiTru_HoiChungTrungLap>(ketquaAPI);
#else

                        _BenhAnNgoaiTru_HoiChungTrungLapOnServer = BenhAnNgoaiTru_HoiChungTrungLapFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnNgoaiTru_HoiChungTrungLapOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnNgoaiTru_HoiChungTrungLapOnServer;
                        else
                        {
                            _BenhAn.Mach = XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach.HasValue ? XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach.Value + "" : "";
                            _BenhAn.HuyetAp = XemBenhAn._ThongTinDieuTri.DauSinhTon.HuyetAp;
                            
                            _BenhAn.TK_Mach = XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach.HasValue ? XemBenhAn._ThongTinDieuTri.DauSinhTon.Mach.Value + "" : "";
                            _BenhAn.TK_HuyetAp = XemBenhAn._ThongTinDieuTri.DauSinhTon.HuyetAp;

                            _BenhAn.BenhChinh = XemBenhAn._ThongTinDieuTri.BenhChinh_RaVien;
                            _BenhAn.BenhKemTheo = XemBenhAn._ThongTinDieuTri.BenhKemTheo_RaVien;
                        }
                        if (_BenhAn.NgayTongKet == DateTime.MinValue)
                        {
                            _BenhAn.NgayTongKet = DateTime.Now;
                        }
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnNgoaiTru_HoiChungTrungLap " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnStentDongMachVanh()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnStentDongMachVanh " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnStentDongMachVanh _BenhAn = JsonConvert.DeserializeObject<BenhAnStentDongMachVanh>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnStentDongMachVanh _BenhAnStentDongMachVanhOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnStentDongMachVanhOnServer = JsonConvert.DeserializeObject<BenhAnStentDongMachVanh>(ketquaAPI);
#else

                        _BenhAnStentDongMachVanhOnServer = BenhAnStentDongMachVanhFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnStentDongMachVanhOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnStentDongMachVanhOnServer;
                       
                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnStentDongMachVanh " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnThieuMauCoTimCucBo()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnThieuMauCoTimCucBo " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnThieuMauCoTimCucBo _BenhAn = JsonConvert.DeserializeObject<BenhAnThieuMauCoTimCucBo>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnThieuMauCoTimCucBo _BenhAnThieuMauCoTimCucBoOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnThieuMauCoTimCucBoOnServer = JsonConvert.DeserializeObject<BenhAnThieuMauCoTimCucBo>(ketquaAPI);
#else

                        _BenhAnThieuMauCoTimCucBoOnServer = BenhAnThieuMauCoTimCucBoFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnThieuMauCoTimCucBoOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnThieuMauCoTimCucBoOnServer;

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnThieuMauCoTimCucBo " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnBenhBasedow()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnBenhBasedow " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnBenhBaseDow _BenhAn = JsonConvert.DeserializeObject<BenhAnBenhBaseDow>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnBenhBaseDow _BenhAnBenhBasedowOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnBenhBasedowOnServer = JsonConvert.DeserializeObject<BenhAnBenhBaseDow>(ketquaAPI);
#else

                        _BenhAnBenhBasedowOnServer = BenhAnBenhBaseDowFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnBenhBasedowOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnBenhBasedowOnServer;

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnBenhBasedow " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnViemGanBManTinh()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnViemGanBManTinh " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnViemGanBManTinh _BenhAn = JsonConvert.DeserializeObject<BenhAnViemGanBManTinh>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnViemGanBManTinh _BenhAnViemGanBManTinhOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnViemGanBManTinhOnServer = JsonConvert.DeserializeObject<BenhAnViemGanBManTinh>(ketquaAPI);
#else

                        _BenhAnViemGanBManTinhOnServer = BenhAnViemGanBManTinhFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnViemGanBManTinhOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnViemGanBManTinhOnServer;

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnViemGanBManTinh " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnPhoiTacNghenManTinh()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnPhoiTacNghenManTinh " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnPhoiTacNghenManTinh _BenhAn = JsonConvert.DeserializeObject<BenhAnPhoiTacNghenManTinh>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnPhoiTacNghenManTinh _BenhAnPhoiTacNghenManTinhOnServer = null;
#if CLOUD
                        ketquaAPI = crtGetDataBenhAn.FncGetData("SELECT", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), null, null);
                        _BenhAnPhoiTacNghenManTinhOnServer = JsonConvert.DeserializeObject<BenhAnPhoiTacNghenManTinh>(ketquaAPI);
#else

                        _BenhAnPhoiTacNghenManTinhOnServer = BenhAnPhoiTacNghenManTinhFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnPhoiTacNghenManTinhOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnPhoiTacNghenManTinhOnServer;
                        if (_BenhAn.DoPheDungs == null)
                        {
                            _BenhAn.DoPheDungs = new ObservableCollection<DoPheDung>();
                            _BenhAn.DoPheDungs.Add(new DoPheDung());
                            _BenhAn.DoPheDungs.Add(new DoPheDung());
                            _BenhAn.DoPheDungs.Add(new DoPheDung());
                        }
                        if (_BenhAn.DoChucNangHoHaps == null)
                        {
                            _BenhAn.DoChucNangHoHaps = new ObservableCollection<DoChucNangHoHap>();
                            _BenhAn.DoChucNangHoHaps.Add(new DoChucNangHoHap { ChucNang = "VC (L)" });
                            _BenhAn.DoChucNangHoHaps.Add(new DoChucNangHoHap { ChucNang = "FVC (L)" });
                            _BenhAn.DoChucNangHoHaps.Add(new DoChucNangHoHap { ChucNang = "FEV1 (L)" });
                            _BenhAn.DoChucNangHoHaps.Add(new DoChucNangHoHap { ChucNang = "FEV1/FVC" });
                            _BenhAn.DoChucNangHoHaps.Add(new DoChucNangHoHap { ChucNang = "FEV1/VC" });
                            _BenhAn.DoChucNangHoHaps.Add(new DoChucNangHoHap { ChucNang = "PEF (L/s)" });
                        }

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnPhoiTacNghenManTinh " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        object LoadBenhAnTangHuyetAp()
        {
            try
            {
                if (XemBenhAn._ThongTinDieuTri == null) return null;

                var timer = new Stopwatch();
                timer.Start();
                log.Info("++++++++++Start LoadBenhAnTangHuyetAp " + XemBenhAn._ThongTinDieuTri.MaQuanLy);
                {
                    try
                    {
                        BenhAnTangHuyetAp _BenhAn = JsonConvert.DeserializeObject<BenhAnTangHuyetAp>(XemBenhAn.JsonInput);
                        if (XemBenhAn._ThongTinDieuTri.MaQuanLy != 0) { _BenhAn.MaQuanLy = XemBenhAn._ThongTinDieuTri.MaQuanLy; }
                        BenhAnTangHuyetAp _BenhAnTangHuyetApOnServer = null;
#if CLOUD

#else

                        _BenhAnTangHuyetApOnServer = BenhAnTangHuyetApFunc.Select(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy);
#endif
                        if (_BenhAnTangHuyetApOnServer.MaQuanLy != 0)
                            _BenhAn = _BenhAnTangHuyetApOnServer;

                        return _BenhAn;
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi.Handle(ex);
                    }
                    finally
                    {
                        timer.Stop();
                        log.Info("++++++++++End LoadBenhAnTangHuyetAp " + XemBenhAn._ThongTinDieuTri.MaQuanLy + ". Total " + timer.ElapsedMilliseconds + " ms");
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return null;
        }
        #endregion
    }
}
