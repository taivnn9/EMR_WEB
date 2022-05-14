using System;

using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Reflection;
using System.Text;
using System.Linq;
using PMS.Access;
using System.Net.Http.Headers;
using System.Net.Http;
using EMR_MAIN.DATABASE.Other;
using System.Collections.ObjectModel;
using EMR_MAIN.DATABASE;
using EMR.KyDienTu;
using EMR_MAIN.ChucNangKhac;
using System.Diagnostics;
using MDB;

namespace EMR_MAIN
{
    public static class ObservableCollectionExtensions
    {
        public static void RemoveAll<T>(this ObservableCollection<T> collection,
                                                           Func<T, bool> condition)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (condition(collection[i]))
                {
                    collection.RemoveAt(i);
                }
            }
        }
    }
    public class DSNhanVien_Chon
    {
        public bool Chon { get; set; }
        public string MaNhanVien { get; set; }
        public string HoVaTen { get; set; }
        public int STT { get; set; }
    }

    public class NoiDungDG
    {
        public string ThangTuoi { get; set; }
        public string NamLoai1 { get; set; }
        public string NamLoai2 { get; set; }
        public string NamLoai3 { get; set; }
        public string NamLoai4 { get; set; }
        public string NuLoai1 { get; set; }
        public string NuLoai2 { get; set; }
        public string NuLoai3 { get; set; }
        public string NuLoai4 { get; set; }
    }
    public class Common
    {
        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }
        public static string Toabc(int number)
        {
            if (number == 0) return "a";
            if (number == 1) return "b";
            if (number == 2) return "c";
            if (number == 3) return "d";
            if (number == 4) return "e";
            if (number == 5) return "f";
            if (number == 6) return "g";
            if (number == 7) return "h";
            if (number == 8) return "i";
            if (number == 9) return "j";
            if (number == 10) return "k";
            if (number == 11) return "l";
            if (number == 12) return "m";
            if (number == 13) return "n";
            if (number == 14) return "o";
            if (number == 15) return "p";
            if (number == 16) return "q";
            if (number == 17) return "r";
            if (number == 18) return "s";
            if (number == 19) return "t";
            if (number == 20) return "u";
            if (number == 21) return "v";
            if (number == 22) return "w";
            if (number == 23) return "x";
            if (number == 24) return "y";
            if (number == 25) return "z";
            return number.ToString();
        }
        public static string getUserLogin()
        {
            return string.IsNullOrEmpty(XemBenhAn.userCode) ? XemBenhAn.UserCodeLogin : XemBenhAn.userCode;
        }

        public static bool IsUnicode(string input)
        {
            var asciiBytesCount = Encoding.ASCII.GetByteCount(input);
            var unicodBytesCount = Encoding.UTF8.GetByteCount(input);
            return asciiBytesCount != unicodBytesCount;
        }
        public static void updateSoLuongPhieu(MDB.MDBConnection oracleConnection, DanhSachPhieu Phieu, decimal maquanly)
        {
            try
            {
                //if (Phieu.DatabaseName.IsNullOrEmpty())
                //{
                //    var list = Phieu.CreateDanhSachPhieu();
                //    if (list != null && list.Count > 0)
                //    {
                //        var phieu = list.Where(x => x.MaPhieu == Phieu.MaPhieu).FirstOrDefault();
                //        if (phieu != null)
                //        {
                //            Phieu.DatabaseName = phieu?.DatabaseName;
                //        }
                //    }
                //}
                string sql = @"SELECT COUNT(*) FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy";
                switch (Phieu.MaPhieu)
                {
                    case "KSGTCM":
                    case "BKJH":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND TRANGTHAI = 0";
                        break;
                    case "PTTT":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND LOAI = 0";
                        break;
                    case "TT":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND LOAI = 1";
                        break;
                    case "CD":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND IS_DELETE = 0";
                        break;
                    case "TD":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND IS_DELETE = 0";
                        break;
                    case "PKTTT":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND LOAITT = 500";
                        break;
                    case "PPTT3":
                    case "KSTCK":
                    case "TBBHC":
                    case "BBHC":
                    case "YCSDKS":
                        sql = @"SELECT 
                                COUNT(*) 
                            FROM " + Phieu.DatabaseName + "  where MaQuanLy = :MaQuanLy AND XOA = 0";
                        break;
                    default:
                        break;

                }

                int count = 0;

                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("MaQuanLy", maquanly);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    count = int.Parse(oracleDataReader["Count(*)"].ToString());
                    Phieu.SoLuong = count;

                }
                sql = @"select * from SoLuongPhieu where MaPhieu = :MaPhieu And MaQuanLy = :MaQuanLy";
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("MaPhieu", Phieu.MaPhieu);
                oracleCommand.Parameters.Add("MaQuanLy", maquanly);
                MDB.MDBDataReader DataReader = oracleCommand.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) { rowCount++; break; };
                if (rowCount > 0)
                {
                    sql = @"update SoLuongPhieu set SoLuong = :SoLuong where MaPhieu = :MaPhieu and MaQuanLy = :MaQuanLy";
                    oracleCommand = new MDB.MDBCommand(sql, oracleConnection);

                    oracleCommand.Parameters.Add("SoLuong", count);
                    oracleCommand.Parameters.Add("MaPhieu", Phieu.MaPhieu);
                    oracleCommand.Parameters.Add("MaQuanLy", maquanly);
                    oracleCommand.ExecuteNonQuery();

                }
                else
                {

                    sql = @"insert into SoLuongPhieu(MaPhieu, MaQuanLy,SoLuong) values(:MaPhieu, :MaQuanLy, :SoLuong)";
                    oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                    oracleCommand.Parameters.Add("MaPhieu", Phieu.MaPhieu);
                    oracleCommand.Parameters.Add("MaQuanLy", maquanly);
                    oracleCommand.Parameters.Add("SoLuong", count);
                    oracleCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
        }
        public static string ConDBNull(object dbVal)
        {
            string ret = "";
            if (dbVal == null)
            {
                return ret;
            }
            ret = dbVal.ToString();
            return ret;
        }
        public static decimal ConDB_Decimal(object dbVal, decimal valDefault = 0)
        {
            decimal ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = decimal.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static int? ConVSpecial(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return null;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            if (ret == -1)
            {
                ret = 0;
            }
            return ret;
        }
        public static int ConDB_Int(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static int? ConDB_IntNull(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            try
            {
                if (dbVal == null || string.IsNullOrWhiteSpace(dbVal.ToString()))
                {
                    return null;
                }
                bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
                if (!isSuccess)
                {
                    return valDefault;
                }
            }
            catch
            {
                return null;
            }
            return ret;
        }
        public static float? ConDBNull_float(object dbVal)
        {
            float ret = 0;
            if (dbVal == null)
            {
                return null;
            }
            bool isSuccess = float.TryParse(dbVal.ToString(), out ret);
            if (isSuccess == false)
            {
                return null;
            }
            return ret;
        }
        public static float ConDB_float(object dbVal, float valDefault = 0)
        {
            float ret = 0;
            if (dbVal == null)
            {
                return valDefault;
            }
            bool isSuccess = float.TryParse(dbVal.ToString(), out ret);
            if (isSuccess == false)
            {
                return valDefault;
            }
            return ret;
        }
        public static double? ConDBNull_double(object dbVal)
        {
            double ret = 0;
            if (dbVal == null)
            {
                return null;
            }
            bool isSuccess = double.TryParse(dbVal.ToString(), out ret);
            if (isSuccess == false)
            {
                return null;
            }
            return ret;
        }
        public static double ConDB_double(object dbVal, double valDefault = 0)
        {
            double ret = 0;
            if (dbVal == null)
            {
                return valDefault;
            }
            bool isSuccess = double.TryParse(dbVal.ToString(), out ret);
            if (isSuccess == false)
            {
                return valDefault;
            }
            return ret;
        }
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            try
            {
                if (dbVal == null)
                {
                    return ret;
                }
                bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
            return ret;
        }
        public static string ConDB_FormatDateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            try
            {
                if (dbVal == null)
                {
                    return "";
                }
                bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            }
            catch (Exception ex)
            {
                return "";
            }
            finally
            {
            }
            return ret.ToString("dd/MM/yyyy");
        }
        public static string ConDB_FormatDateTime_NgayGio(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            string tmp = "";
            try
            {
                if (dbVal == null || dbVal.IsNullOrEmpty())
                {
                    return "";
                }
                bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
                tmp = string.Format("{0} Giờ {1} phút {2}", ret.ToString("HH"), ret.ToString("mm"), ret.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                return "";
            }
            finally
            {
            }
            return tmp;
        }
        public static DateTime? ConDB_DateTimeNull(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            try
            {
                if (dbVal == null || dbVal.IsNullOrEmpty())
                {
                    return null;
                }
                bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
            }
            return ret;
        }
        public static string getChanDoan()
        {
            var timer = new Stopwatch();
            timer.Start();
            ExceptionExtend.Log("Common", "Start getChanDoan");
            string strChanDoan = string.Empty;
            string URL = ERMDatabase.WebServiceUrl;
            DataTable dtDSPhieDieuTri = new DataTable();
            try
            {
#if CLOUD
            //ketquaAPI = crtTTCS.FncGetData("GETTODIEUTRI", XemBenhAn._ThongTinDieuTri.MaQuanLy.ToString(), new string[1] { khoa.IdKhoa.ToString() });
            //dtDSPhieDieuTri = JsonConvert.DeserializeObject<DataTable>(ketquaAPI);
            // 20200915 Tunght CLOUD???
#else
#if HIS2
                try
                {
                    dtDSPhieDieuTri = ThongTinChamSocFunc.GetToDieuTri(XemBenhAn.MyConnection, XemBenhAn._ThongTinDieuTri.MaQuanLy, XemBenhAn._ThongTinDieuTri.MaKhoa);
                    strChanDoan = dtDSPhieDieuTri.AsEnumerable().Select(t => t.Field<string>("ChanDoan")).FirstOrDefault();
                }
                catch (Exception ex) { XuLyLoi.LogError(ex); }
                if (strChanDoan == string.Empty)
                {
                    strChanDoan = XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri;
                }
#else
                if (XemBenhAn.IsHisPro && !string.IsNullOrEmpty(ERMDatabase.KyDienTu_DiaChiMOS))
                {
                    string tokenKy = XemBenhAn.TokenKy;
                    ChuKySo ky = new ChuKySo();
                    var valid = ky.CheckTokenIsValid(tokenKy, ERMDatabase.KyDienTu_DiaChiACS, ERMDatabase.KyDienTu_ApplicationCode);
                    bool checkLogin = true;
                    if (valid == null)
                    {
                        LoginKy formLoginKy = new LoginKy();
                        formLoginKy.ShowDialog();
                        tokenKy = formLoginKy.TokenKy;
                        if (string.IsNullOrEmpty(tokenKy))
                        {
                            MessageBox.Show("Đăng nhập tài khoản ký thất bại", "EMR Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                            checkLogin = false;
                        }
                    }
                    if (checkLogin)
                    {
                        DataOutputTraking dataTracking = ky.GetPhieuDieuTriHisPro(ERMDatabase.KyDienTu_DiaChiMOS, ERMDatabase.KyDienTu_ApplicationCode, tokenKy, XemBenhAn._ThongTinDieuTri.MaBenhAn);
                        if (dataTracking != null)
                        {
                            if (dataTracking.Data != null && dataTracking.Data.Count > 0)
                            {
                                List<ServiceTracking> dataList = dataTracking.Data.OrderByDescending(x => x.TrackingTime).ToList();
                                strChanDoan = dataList[0].IcdName;
                            }
                        }
                    }
                }
                else if (URL.IsNotNullOrEmpty())
                {
                    using (var client = new HttpClient())
                    {
                        try
                        {
                            client.BaseAddress = new Uri(URL);
                            client.DefaultRequestHeaders.Accept.Clear();
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            client.Timeout = new TimeSpan(0, 0, 1000);
                            var url = "api/KetXuat/ToDieuTri?MaQuanLy=" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "&TenKhoa=" + XemBenhAn._ThongTinDieuTri.Khoa;
                            HttpResponseMessage response = client.GetAsync(url).Result;
                            response.EnsureSuccessStatusCode();
                            if (response.IsSuccessStatusCode)
                            {
                                string result = response.Content.ReadAsStringAsync().Result;
                                if (result != "null")
                                {
                                    dtDSPhieDieuTri = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(Newtonsoft.Json.JsonConvert.SerializeObject(result));
                                    // Lấy chẩn đoán tờ điều trị.
                                    strChanDoan = dtDSPhieDieuTri.AsEnumerable().OrderByDescending(o => o.Field<string>("SoPhieu")).Select(t => t.Field<string>("ChanDoan")).FirstOrDefault();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            XuLyLoi.LogError("***Tunght***Lấy chẩn đoán lỗi: Không tìm thấy web service :" + ERMDatabase.WebServiceUrl + " để lấy thông tin điều trị");
                            strChanDoan = XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri;
                        }
                    }
                }
                if (string.IsNullOrEmpty(strChanDoan))
                {
                    strChanDoan = XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri;
                }
#endif
#endif
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError("*Không tìm thấy web service :" + ERMDatabase.WebServiceUrl + " để lấy thông tin điều trị");
                strChanDoan = XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri;
            }
            ExceptionExtend.Log("Common", "End  getChanDoan : Total: " + timer.ElapsedMilliseconds.ToString() + " ms");
            return strChanDoan;
        }
        public static string GetTomTatBenhAn()
        {
            string strTomTatBenhAn = string.Empty;
            string URL = ERMDatabase.WebServiceUrl;
            DataTable dtDSPhieDieuTri = new DataTable();
            try
            {
#if CLOUD
           
#else
#if HIS2
                
#else
                if (URL.IsNotNullOrEmpty())
                {
                    using (var client = new HttpClient())
                    {
                        try
                        {
                            client.BaseAddress = new Uri(URL);
                            client.DefaultRequestHeaders.Accept.Clear();
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            client.Timeout = new TimeSpan(0, 0, 1000);
                            var url = "api/KetXuat/ToDieuTri?MaQuanLy=" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "&TenKhoa=" + XemBenhAn._ThongTinDieuTri.Khoa;
                            HttpResponseMessage response = client.GetAsync(url).Result;
                            response.EnsureSuccessStatusCode();
                            if (response.IsSuccessStatusCode)
                            {
                                string result = response.Content.ReadAsStringAsync().Result;
                                if (result != "null")
                                {
                                    dtDSPhieDieuTri = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(result);
                                    // Lấy chẩn đoán tờ điều trị.
                                    strTomTatBenhAn = "Khám toàn thân:\n";
                                    strTomTatBenhAn += dtDSPhieDieuTri.AsEnumerable().OrderByDescending(o => o.Field<string>("SoPhieu")).Select(t => t.Field<string>("KhamToanThan")).FirstOrDefault();
                                    strTomTatBenhAn += "\nKhám bộ phận:\n";
                                    strTomTatBenhAn += dtDSPhieDieuTri.AsEnumerable().OrderByDescending(o => o.Field<string>("SoPhieu")).Select(t => t.Field<string>("KhamBoPhan")).FirstOrDefault();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            XuLyLoi.LogError(ex.Message);
                            XuLyLoi.LogError("***Tunght***Lấy thông tin lỗi: Không tìm thấy web service :" + ERMDatabase.WebServiceUrl + " để lấy thông tin điều trị");
                            strTomTatBenhAn = "";
                        }
                    }
                }
                if (string.IsNullOrEmpty(strTomTatBenhAn))
                {
                    strTomTatBenhAn = "";
                }
#endif
#endif
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError("*Không tìm thấy web service :" + ERMDatabase.WebServiceUrl + " để lấy thông tin điều trị");
                strTomTatBenhAn = XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri;
            }

            return strTomTatBenhAn;
        }
        public static string GetDiaChi()
        {
            try
            {
                List<string> diachi = new List<string>();
                if (!string.IsNullOrEmpty(XemBenhAn._HanhChinhBenhNhan.SoNha))
                {
                    diachi.Add(XemBenhAn._HanhChinhBenhNhan.SoNha);
                }
                if (!string.IsNullOrEmpty(XemBenhAn._HanhChinhBenhNhan.ThonPho))
                {
                    diachi.Add(XemBenhAn._HanhChinhBenhNhan.ThonPho);
                }
                if (!string.IsNullOrEmpty(XemBenhAn._HanhChinhBenhNhan.XaPhuong))
                {
                    diachi.Add(XemBenhAn._HanhChinhBenhNhan.XaPhuong);
                }
                if (!string.IsNullOrEmpty(XemBenhAn._HanhChinhBenhNhan.HuyenQuan))
                {
                    diachi.Add(XemBenhAn._HanhChinhBenhNhan.HuyenQuan);
                }
                if (!string.IsNullOrEmpty(XemBenhAn._HanhChinhBenhNhan.TinhThanhPho))
                {
                    diachi.Add(XemBenhAn._HanhChinhBenhNhan.TinhThanhPho);
                }
                return string.Join(", ", diachi);
            }
            catch
            {
                return "";
            }
        }
        public static string GetGioiTinh()
        {
            if (XemBenhAn._HanhChinhBenhNhan.GioiTinh == GioiTinh.Nam)
            {
                return "Nam";
            }
            if (XemBenhAn._HanhChinhBenhNhan.GioiTinh == GioiTinh.Nu)
            {
                return "Nữ";
            }
            if (XemBenhAn._HanhChinhBenhNhan.GioiTinh == GioiTinh.KhongBiet)
            {
                return "Không biết";
            }
            if (XemBenhAn._HanhChinhBenhNhan.GioiTinh == GioiTinh.ChuaXacDinh)
            {
                return "Chưa xác định";
            }
            return "Nam";
        }
        public static string XoaDauTiengViet(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = input.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty)
                        .Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public static DataTable ListToDataTable<T>(IList<T> list, string tableName)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable(tableName);
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in list)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = props[i].GetValue(item) ?? DBNull.Value;
                table.Rows.Add(values);
            }
            return table;
        }
        public static IEnumerable<string> SplitByLength(string str, int maxLength)
        {
            for (int index = 0; index < str.Length; index += maxLength)
            {
                yield return str.Substring(index, Math.Min(maxLength, str.Length - index));
            }
        }
        public static  BitmapImage CreateBitmapFromSource(string path)
        {
            BitmapImage bi = new BitmapImage();
            if (File.Exists(path))
            {

                using (var stream = File.OpenRead(path))
                {
                    bi.BeginInit();
                    bi.CacheOption = BitmapCacheOption.OnLoad;
                    bi.StreamSource = stream;
                    bi.EndInit();
                    bi.Freeze();
                }
                return bi;
            }
            return null;
        }
    }
}
