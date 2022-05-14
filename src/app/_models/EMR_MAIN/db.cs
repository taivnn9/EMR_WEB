using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace EMR_MAIN
{
    public static class Extends
    {
        public static string TableName(this LoaiBenhAnEMR value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            TableNameAttribute[] attributes =
                (TableNameAttribute[])fi.GetCustomAttributes(
                typeof(TableNameAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Name;
            else
                return value.ToString();

        }
        public static string PrimayKey(this LoaiBenhAnEMR value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            TableNameAttribute[] attributes =
                (TableNameAttribute[])fi.GetCustomAttributes(
                typeof(TableNameAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].PrimaryKey;
            else
                return value.ToString();

        }
        public static Byte[] ConvertToByteArray(this BitmapImage imageSource)
        {
            Stream stream = imageSource.StreamSource;
            Byte[] buffer = null;
            if (stream != null && stream.Length > 0)
            {
                using (BinaryReader br = new BinaryReader(stream))
                {
                    buffer = br.ReadBytes((Int32)stream.Length);
                }
            }

            return buffer;
        }

        public static Byte[] ConvertToByteArray(this ImageSource imageSource)
        {
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            byte[] bytes = null;
            var bitmapSource = imageSource as BitmapSource;

            if (bitmapSource != null)
            {
                encoder.Frames.Add(BitmapFrame.Create(bitmapSource));

                using (var stream = new MemoryStream())
                {
                    encoder.Save(stream);
                    bytes = stream.ToArray();
                }
            }

            return bytes;
        }

        public static bool PostCloud<T>(this T value)
        {
            try
            {
                //if (ERMDatabase.URLEMRCloud.IsNotNullOrEmpty())
                //{
                //    try
                //    {
                //        using (var client = new HttpClient())
                //        {
                //            client.BaseAddress = new Uri(ERMDatabase.URLEMRCloud);
                //            client.DefaultRequestHeaders.Accept.Clear();
                //            client.Timeout = new TimeSpan(0, 0, 1000);
                //            HttpResponseMessage resp = client.PostAsJsonAsync("api/BenhAn/Save").Result;
                //            if (resp.IsSuccessStatusCode)
                //            {
                //                string responseData = resp.Content.ReadAsStringAsync().Result;
                //                return true;
                //            }
                //            else
                //            {
                //                MDB.ExceptionExtend.LogError(new Exception(string.Format("Loi khi goi API: {0}. StatusCode: {1}", client.BaseAddress, resp.StatusCode.GetHashCode())));
                //            }
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        MDB.ExceptionExtend.LogError(ex);
                //    }
                //    return false;
                //}
                //return true;
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
            }
            return false;
        }
    }
    public enum PicDefaults
    {
        [Description("TMH_ManNhiPhai.png")]
        TMH_ManNhiPhai,
        [Description("TMH_ManNhiTrai.png")]
        TMH_ManNhiTrai,
        [Description("TMH_MuiTruoc.png")]
        TMH_MuiTruoc,
        [Description("TMH_MuiSau.png")]
        TMH_MuiSau,
        [Description("TMH_ThanhQuan.png")]
        TMH_ThanhQuan,
        [Description("TMH_Hong.png")]
        TMH_Hong,
        [Description("TMH_CoNghiengPhai.png")]
        TMH_CoNghiengPhai,
        [Description("TMH_CoNghiengTrai.png")]
        TMH_CoNghiengTrai,

        [Description("HinhAnhDaLieu.png")]
        HinhAnhDaLieu,

        [Description("BenhAnMat_MatPhai.png")]
        BenhAnMat_MatPhai,
        [Description("BenhAnMat_MatTrai.png")]
        BenhAnMat_MatTrai,
        [Description("BenhAnMat_GiacMacPhai.png")]
        BenhAnMat_GiacMacPhai,
        [Description("BenhAnMat_GiacMacTrai.png")]
        BenhAnMat_GiacMacTrai,
        [Description("BenhAnMatGlocomMP.png")]
        BenhAnMatGlocomMP,
        [Description("BenhAnMatGlocomMT.png")]
        BenhAnMatGlocomMT,

        [Description("BenhAnNgoaiTruMat_MatPhai.png")]
        BenhAnNgoaiTruMat_MatPhai,
        [Description("BenhAnNgoaiTruMat_MatTrai.png")]
        BenhAnNgoaiTruMat_MatTrai,
        [Description("BenhAnNgoaiTruMat_GiacMacPhai.png")]
        BenhAnNgoaiTruMat_GiacMacPhai,
        [Description("BenhAnNgoaiTruMat_GiacMacTrai.png")]
        BenhAnNgoaiTruMat_GiacMacTrai,

        [Description("RHM_Phai.png")]
        RHM_Phai,
        [Description("RHM_Thang.png")]
        RHM_Thang,
        [Description("RHM_Trai.png")]
        RHM_Trai,
        [Description("RHM_HamTrenVaHong.png")]
        RHM_HamTrenVaHong,
        [Description("RHM_HamDuoi.png")]
        RHM_HamDuoi,
        [Description("RHM_PhanLoaiKheHo.png")]
        RHM_PhanLoaiKheHo,

        [Description("HinhVeTonThuongVaoVienPHCN.png")]
        HinhVeTonThuongVaoVienPHCN,

        [Description("DTPHCN_HinhAnhTruoc.png")]
        DTPHCN_HinhAnhTruoc,
        [Description("DTPHCN_HinhAnhSau.png")]
        DTPHCN_HinhAnhSau,
        [Description("DTPHCN_HinhAnhTrai.png")]
        DTPHCN_HinhAnhTrai,
        [Description("DTPHCN_HinhAnhPhai.png")]
        DTPHCN_HinhAnhPhai,
        [Description("BA_MatChanThuong_MP.png")]
        BA_MatChanThuong_MP,
        [Description("BA_MatChanThuong_MT.png")]
        BA_MatChanThuong_MT,
        [Description("BA_MatChanThuong_VongMac_MP.png")]
        BA_MatChanThuong_VongMac_MP,
        [Description("BA_MatChanThuong_VongMac_MT.png")]
        BA_MatChanThuong_VongMac_MT,
        [Description("BA_MatBanPhanTruoc_MP.png")]
        BA_MatBanPhanTruoc_MP,
        [Description("BA_MatBanPhanTruoc_MT.png")]
        BA_MatBanPhanTruoc_MT,
        [Description("ThamDoDienSinhLy_RF.png")]
        ThamDoDienSinhLy_RF,
        [Description("KQDieuTriCanThiepDMV.png")]
        KQDieuTriCanThiepDMV,
        [Description("phieudanhgianguoibenhnhapvien001.png")]
        phieudanhgianguoibenhnhapvien001,
        [Description("phieudanhgianguoibenhnhapvien002.png")]
        phieudanhgianguoibenhnhapvien002,
        [Description("DaLieuTW_Phai.png")]
        DaLieuTW_Phai,
        [Description("DaLieuTW_Trai.png")]
        DaLieuTW_Trai,
        [Description("BAUngThuHacTo.png")]
        BAUngThuHacTo,
        [Description("BenhAnVayNenTheKhop.png")]
        BenhAnVayNenTheKhop,
    }

    public class ERMDatabase
    {
        // web service
        public static string WebServiceUrl = "";
        public static string URLEMRCloud = "http://localhost:49999/";
        public static string WebServiceEMR = "";

        public static string KyDienTu = "388";
        public static string KyDienTu_DiaChiACS = "";
        public static string KyDienTu_DiaChiEMR = "";
        public static string KyDienTu_DiaChiThuVienKy = "/";
        //public static string KyDienTu_DiaChiACS = "http://192.168.1.251:1401/";
        //public static string KyDienTu_DiaChiEMR = "http://192.168.1.251:1415/";
        //public static string KyDienTu_DiaChiThuVienKy = "http://192.168.1.251:1405/";
        public static string KyDienTu_UserNameHeThongKy = "";
        public static string KyDienTu_MatKhauHeThongKy = "";
        public static string KyDienTu_ApplicationCode = "HIS";
        public static string ThuMucChuaCacFileHoSoBenhAn = "395";
        public static string KyDienTu_TREATMENT_CODE = ""; // HISPRO ký
        public static string KyDienTu_DiaChiMOS = ""; // HISPRO ký

        public static string FullPACS = "";
        public static string HospitalAddress = "";

        static string ConnectionStringFormat = "Data Source=(DESCRIPTION =(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST = {0})(PORT = {1})))(CONNECT_DATA =(SERVICE_NAME = {2})));User ID={3};Password={4}";
        public static string ConnectionString;
        public static string FTPImageStringFormat = "ftp://{0}:{1}@{2}/{3}/";
        public static string FTPImageString;
        public static string FTPAddress;
        public static string FTPUsername;
        public static string FTPPassword;
        public static string FTPFolder;

        public ERMDatabase()
        {
            try
            {
                URLEMRCloud = ReadConfig("URLEMRCloud");
            }
            catch { }
        }

        public static void TaoChuoiKetNoiFTP(string Address, string Username, string Password, string Folder)
        {
            FTPAddress = Address;
            FTPUsername = Username;
            FTPPassword = Password;
            FTPFolder = Folder;
            FTPImageString = string.Format(FTPImageStringFormat, FTPUsername, FTPPassword, FTPAddress, FTPFolder);
        }
        /// Return True nếu thành công
        /// </summary>
        /// <returns></returns>
        public static bool KetNoi(string DiaChiServer, string TaiKhoanDatabase, string MatKhauTaiKhoanDatabase, string PortKetNoi, string ServiceName)
        {
            try
            {

                ConnectionString = string.Format(ConnectionStringFormat, DiaChiServer, PortKetNoi, ServiceName, TaiKhoanDatabase, MatKhauTaiKhoanDatabase);
                {
                    RaiseIdle();
                    CultureInfo ci = new CultureInfo("en");
                    ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                    Thread.CurrentThread.CurrentCulture = ci;

                    return true;
                }
            }
            catch (Exception exception)
            {
                XuLyLoi.Handle(exception);
                return false;
            }
        }
        static void RaiseIdle()
        {
            //System.Windows.Forms.Application.RaiseIdle(EventArgs.Empty);
            //System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(new Action(RaiseIdle), System.Windows.Threading.DispatcherPriority.ApplicationIdle);
        }

        public static DataTable GetData(string sql, List<MDB.MDBParameter> parameters)
        {
            DataTable result = new DataTable();
            //MDB.MDBConnection conn = null;
            try
            {
                //conn = new MDB.MDBConnection(ConnectionString);
                //
                MDB.MDBCommand cmd = new MDB.MDBCommand(sql, XemBenhAn.MyConnection);
                //cmd.CommandText = sql;
                //cmd.Connection = XemBenhAn.MyConnection;
                cmd.CommandTimeout = 500000;
                if (parameters != null && parameters.Count > 0)
                {
                    foreach (MDB.MDBParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                //using (MDB.MDBDataReader reader = cmd.ExecuteReader())
                {
                    MDB.MDBDataReader reader = cmd.ExecuteReader();
                    result.Load(reader as IDataReader);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // 
                // 
            }
        }
        public static bool ExecuteNonQuery(string sql, List<MDB.MDBParameter> parameters)
        {
            //MDB.MDBConnection conn = null;
            try
            {
                //conn = new MDB.MDBConnection(ConnectionString);
                //
                MDB.MDBCommand cmd = new MDB.MDBCommand(sql, XemBenhAn.MyConnection);
                //cmd.CommandText = sql;
                //cmd.Connection = conn;
                cmd.CommandTimeout = 500000;
                if (parameters != null && parameters.Count > 0)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                int n = cmd.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //
                //
            }
        }

        public static readonly string BLOCK_COMMENTS = @"/\*(.*?)\*/";
        public static readonly string LINE_COMMENTS = @"--[^@](.*?)\r?\n";
        public static readonly string STRINGS = @"""((\\[^\n]|[^""\n])*)""";
        public static void CreateTableAndDataDefault(MDB.MDBConnection connection, string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                string contentWithoutComments = Regex.Replace(content.Replace("'", "\""), BLOCK_COMMENTS + "|" + LINE_COMMENTS + "|" + STRINGS,
                        me =>
                        {
                            if (me.Value.StartsWith("/*") || me.Value.StartsWith("--"))
                                return me.Value.StartsWith("--") ? Environment.NewLine : "";
                            return me.Value;
                        },
                        RegexOptions.Singleline);
                var sqls = contentWithoutComments.Split('/');

                foreach (var sql in sqls)
                {
                    if (!sql.Trim().Equals(""))
                    {
                        try
                        {
                            string sql_fit = sql.Trim().EndsWith(";") && !sql.Trim().EndsWith("end;") ? sql.Trim().Substring(0, sql.Trim().Length - 1) : sql.Trim();
                            MDB.MDBCommand cmd = new MDB.MDBCommand(sql_fit, connection);
                            int n = cmd.ExecuteNonQuery();
                            if (n > 0)
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            //XuLyLoi.LogError(ex);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                //XuLyLoi.Handle(ex);
            }
        }

        public static string ReadConfig(string Tag)
        {
            try
            {
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration("EMR_MAIN.dll");
                try
                {
                    var value = config.AppSettings.Settings[Tag]?.Value;
                    return value;
                }
                catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
            }
            return null;
        }
    }
}
