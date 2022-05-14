using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class DanhSachPhieuInfo
    {
        public string MaNguoiThaoTac { get; set; }
        public string NguoiThaoTac { get; set; }
        public DateTime? NgayThaoTac { get; set; }
        public int SoLuong { get; set; }
    }
    public class DanhSachPhieuFunc
    {
        #region OLD SOLUTION
        /*
        public static int GetSoLuong(MDB.MDBConnection MyConnection, string tenBang, List<string> DatabaseNameDetail, string ngayTaoHoacNgaySua, string nguoiTaoHoacNguoiSua, DateTime ngayTaoHoacNgaySuaValue, DateTime ngayTaoHoacNgaySuaValue2, string maKhoa)
        {
            int soLuong = GetSoLuong(MyConnection, tenBang, ngayTaoHoacNgaySua, nguoiTaoHoacNguoiSua, ngayTaoHoacNgaySuaValue, ngayTaoHoacNgaySuaValue2, maKhoa);
            if (DatabaseNameDetail == null || DatabaseNameDetail.Count == 0)
            {
                return soLuong;
            }
            DatabaseNameDetail.ForEach(tenBangChiTiet =>
            soLuong += GetSoLuong(MyConnection, tenBangChiTiet, ngayTaoHoacNgaySua, nguoiTaoHoacNguoiSua, ngayTaoHoacNgaySuaValue, ngayTaoHoacNgaySuaValue2, maKhoa));
            return soLuong;
        }

        private static int GetSoLuong(MDB.MDBConnection MyConnection, string tenBang, string ngayTaoHoacNgaySua, string nguoiTaoHoacNguoiSua, DateTime ngayTaoHoacNgaySuaValue, DateTime ngayTaoHoacNgaySuaValue2, string maKhoa)
        {
            if (string.IsNullOrEmpty(tenBang) || string.IsNullOrEmpty(ngayTaoHoacNgaySua))
            {
                return 0;
            }
            try
            {
                if (string.IsNullOrEmpty(maKhoa))
                {
                    return GetSoLuongTatCaCacKhoa(MyConnection, tenBang, ngayTaoHoacNgaySua, ngayTaoHoacNgaySuaValue, ngayTaoHoacNgaySuaValue2);
                }
                return GetSoLuongTheoKhoa(MyConnection, tenBang, ngayTaoHoacNgaySua, nguoiTaoHoacNguoiSua, ngayTaoHoacNgaySuaValue, ngayTaoHoacNgaySuaValue2, maKhoa);
            }
            catch
            {
                return 0;
            }
        }

        private static int GetSoLuongTatCaCacKhoa(MDB.MDBConnection MyConnection, string tenBang, string ngayTaoHoacNgaySua, DateTime ngayTaoHoacNgaySuaValue, DateTime ngayTaoHoacNgaySuaValue2)
        {
            string sql = string.Format("SELECT COUNT(*) FROM {0} WHERE {1} >= TO_DATE('{2}','YYYY/MM/DD') AND {3} < TO_DATE('{4}','YYYY/MM/DD')",
                                tenBang, ngayTaoHoacNgaySua, ngayTaoHoacNgaySuaValue.ToString("yyyy/MM/dd"), ngayTaoHoacNgaySua, ngayTaoHoacNgaySuaValue2.AddDays(1).ToString("yyyy/MM/dd"));
            MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.BindByName = true;
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private static int GetSoLuongTheoKhoa(MDB.MDBConnection MyConnection, string tenBang, string ngayTaoHoacNgaySua, string nguoiTaoHoacNguoiSua, DateTime ngayTaoHoacNgaySuaValue, DateTime ngayTaoHoacNgaySuaValue2, string maKhoa)
        {
            if (string.IsNullOrEmpty(nguoiTaoHoacNguoiSua))
            {
                return 0;
            }
            string sql = string.Format("SELECT COUNT(*) FROM {0} tb, NhanVien_Khoa nvk WHERE tb.{1} >= TO_DATE('{2}','YYYY/MM/DD') AND tb.{3} <= TO_DATE('{4}','YYYY/MM/DD') " +
            "AND tb.{5} = nkv.IDNHANVIEN AND nvk.IDKHOA = {6}",
         tenBang, ngayTaoHoacNgaySua, ngayTaoHoacNgaySuaValue.ToString("yyyy/MM/dd"),
         ngayTaoHoacNgaySua, ngayTaoHoacNgaySuaValue2.AddDays(1).ToString("yyyy/MM/dd"),
         nguoiTaoHoacNguoiSua, maKhoa);
            MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.BindByName = true;
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public static DanhSachPhieu GetThongTinCapNhatPhieu(MDB.MDBConnection MyConnection, string tenBang, string nguoiTao, string nguoiSua, string ngayTao, string ngaySua)
        {
            try
            {
                if (string.IsNullOrEmpty(tenBang) || string.IsNullOrEmpty(nguoiTao) || string.IsNullOrEmpty(nguoiSua) || string.IsNullOrEmpty(ngayTao) || string.IsNullOrEmpty(ngaySua))
                {
                    return null;
                }
                var selectArray = new[] { nguoiTao, nguoiSua, ngayTao, ngaySua };
                string selectQuerry = string.Join(", ", selectArray.Where(s => !string.IsNullOrEmpty(s)));
                if (string.IsNullOrEmpty(selectQuerry))
                {
                    return null;
                }
                string orderByQuerry = "";
                if (!string.IsNullOrEmpty(ngayTao))
                {
                    orderByQuerry = ngayTao + " DESC";
                    if (!string.IsNullOrEmpty(ngaySua))
                    {
                        orderByQuerry += ", ";
                    }
                }
                if (!string.IsNullOrEmpty(ngaySua))
                {
                    orderByQuerry += ngaySua + " DESC";
                }
                if (!string.IsNullOrEmpty(orderByQuerry))
                {
                    orderByQuerry = " ORDER BY " + orderByQuerry;
                }
                string sql = string.Format("SELECT {0} FROM {1} {2}", selectQuerry, tenBang, orderByQuerry);
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    DanhSachPhieu data = new DanhSachPhieu();
                    data.MaNguoiTao = Common.ConDBNull(DataReader[nguoiTao]);
                    data.MaNguoiSua = Common.ConDBNull(DataReader[nguoiSua]);
                    data.NgayNguoiTao = Common.ConDB_DateTimeNull(DataReader[ngayTao]);
                    data.NgayNguoiSua = Common.ConDB_DateTimeNull(DataReader["TAMMM"]);
                    return data;
                }
            }
            catch { }
            return null;
        }
        */
        #endregion
        public static DanhSachPhieuInfo GetThongTin(MDB.MDBConnection MyConnection, string tenBang, string nguoiThaoTac, string ngayThaoTac, DateTime thoiGianFrom, DateTime thoiGianTo, string idKhoa, string maNhanVien)
        {
            try
            {
                DanhSachPhieuInfo result = new DanhSachPhieuInfo();
                if (string.IsNullOrEmpty(tenBang))
                {
                    return null;
                }
                //Neu BV yeu cau them phan loc tat ca cac ngay, thi se xu ly o day
                //Neu ko thi may phan check null cho ngayThaoTac o duoi co the xoa di
                if (string.IsNullOrEmpty(ngayThaoTac))
                {
                    return null;
                }
                if (string.IsNullOrEmpty(nguoiThaoTac))
                {
                    return null;
                }
                string selectQuerry = getSelectQuerry(nguoiThaoTac, ngayThaoTac);
                string fromQuerry = getFromQuerry(tenBang, nguoiThaoTac, idKhoa, maNhanVien);
                string whereQuerry = getWhereQuerry(nguoiThaoTac, idKhoa, maNhanVien, ngayThaoTac, thoiGianFrom, thoiGianTo);
                string groupByQuerry = getGroupByQuerry(nguoiThaoTac, ngayThaoTac);
                string orderByQuerry = getOrderByQuerry(ngayThaoTac);
                string sql = selectQuerry + " " + fromQuerry + " " + whereQuerry + " " + groupByQuerry + " " + orderByQuerry;
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader DataReader = command.ExecuteReader();
                int soLuong = 0;
                DanhSachPhieuInfo data = new DanhSachPhieuInfo();
                while (DataReader.Read())
                {
                    data.MaNguoiThaoTac = Common.ConDBNull(DataReader["MANHANVIEN"]);
                    data.NguoiThaoTac = Common.ConDBNull(DataReader["HOVATEN"]);
                    data.NgayThaoTac = Common.ConDB_DateTimeNull(DataReader[ngayThaoTac]);
                    data.SoLuong = Common.ConDB_Int(DataReader["SOLUONG"]);
                    if (string.IsNullOrEmpty(nguoiThaoTac) || string.IsNullOrEmpty(ngayThaoTac))
                    {
                        return data;
                    }
                    soLuong += data.SoLuong;
                }
                data.SoLuong = soLuong;
                return data;
            }
            catch { }
            return null;
        }

        private static string getSelectQuerry(string nguoiThaoTac, string ngayThaoTac)
        {
            string querry = "SELECT COUNT(*) as SOLUONG, nv.MANHANVIEN, nv.HOVATEN ";
            if (!string.IsNullOrEmpty(nguoiThaoTac))
            {
                querry += string.Format(", tb.{0} ", nguoiThaoTac);
            }
            if (!string.IsNullOrEmpty(ngayThaoTac))
            {
                querry += string.Format(", tb.{0} ", ngayThaoTac);
            }
            return querry;
        }

        private static string getFromQuerry(string tenBang, string nguoiThaoTac, string idKhoa, string maNhanVien)
        {
            string querry = string.Format(" FROM {0} tb, NHANVIEN nv ", tenBang);
            if (!string.IsNullOrEmpty(maNhanVien))
            {
                return querry;
            }
            if (!string.IsNullOrEmpty(nguoiThaoTac) && !string.IsNullOrEmpty(idKhoa))
            {
                querry += ", NHANVIEN_KHOA nvk ";
            }
            return querry;
        }

        private static string getWhereQuerry(string nguoiThaoTac, string idKhoa, string maNhanVien, string ngayThaoTac, DateTime thoiGianFrom, DateTime thoiGianTo)
        {
            if (string.IsNullOrEmpty(nguoiThaoTac) && string.IsNullOrEmpty(ngayThaoTac))
                return " ";
            string querry = " WHERE ";
            if (!string.IsNullOrEmpty(nguoiThaoTac))
            {
                querry += string.Format(" tb.{0} = nv.MANHANVIEN ", nguoiThaoTac);
                if (!string.IsNullOrEmpty(maNhanVien))
                {
                    querry += string.Format(" AND nv.MANHANVIEN = {0} ", maNhanVien);
                }
                else if (!string.IsNullOrEmpty(idKhoa))
                {
                    querry += string.Format(" AND nv.IDNHANVIEN = nvk.IDNHANVIEN AND nvk.IDKHOA = {0} ", idKhoa);
                }
                if (!string.IsNullOrEmpty(ngayThaoTac))
                {
                    querry += " AND ";
                }
            }
            if (!string.IsNullOrEmpty(ngayThaoTac))
            {
                querry += string.Format(" tb.{0} >= TO_DATE('{1}','YYYY/MM/DD') AND tb.{2} <= TO_DATE('{3}','YYYY/MM/DD') ", ngayThaoTac,
                    thoiGianFrom.ToString("yyyy/MM/dd"), ngayThaoTac, thoiGianTo.AddDays(1).ToString("yyyy/MM/dd"));
            }
            return querry;
        }

        private static string getGroupByQuerry(string nguoiThaoTac, string ngayThaoTac)
        {
            string querry = " GROUP BY nv.MANHANVIEN, nv.HOVATEN ";
            if (!string.IsNullOrEmpty(nguoiThaoTac))
            {
                querry += string.Format(", tb.{0} ", nguoiThaoTac);
            }
            if (!string.IsNullOrEmpty(ngayThaoTac))
            {
                querry += string.Format(", tb.{0} ", ngayThaoTac);
            }
            return querry;
        }

        private static string getOrderByQuerry(string ngayThaoTac)
        {
            if (string.IsNullOrEmpty(ngayThaoTac))
            {
                return "";
            }
            return string.Format(" ORDER BY tb.{0} ", ngayThaoTac);
        }
    }
}
