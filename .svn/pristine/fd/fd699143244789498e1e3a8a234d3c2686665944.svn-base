
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace EMR_MAIN
{
    public class NhanVienFunc
    {
        private static List<NhanVien> _listNguoiNhanHoSo { get; set; } = new List<NhanVien>();
        public static List<NhanVien> ListNguoiNhanHoSo
        {
            get => XemBenhAn.IsHis2 ? _listNguoiNhanHoSo : ListNhanVien; // Nếu HIS khác dùng thì if thêm hoặc bỏ if dùng tất cả
            set => _listNguoiNhanHoSo = value;
        }
        public static List<NhanVien> ListGiamDoc { get; set; }
        public static List<NhanVien> ListNhanVien { get; set; }
        /// <summary>
        /// Lấy danh sách các nhân viên là giám đốc
        /// </summary>
        public static List<NhanVien> GetListGiamDoc(MDB.MDBConnection MyConnection)
        {
            if (ListGiamDoc == null || ListGiamDoc.Count == 0)
            {
                string sql;
                if (XemBenhAn.IsHis2)
                {
                    sql = $@"select * from NhanVien a where (chon = 1 or chon is null) and MaNhanVien in (select manhanvien from {MedilinkDatabases.Database.Schema}.P_DMNHANVIEN where bangiamdoc=1)";
                }
                else
                {
                    // 2021.05.10: chưa xử lý chung tất, xử lý tạm cho HIS2 trước, các HIS khác muốn dùng thì xử lý ở đây hoặc gán trực tiếp vào ListGiamDoc
                    return ListGiamDoc;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                ListGiamDoc = new List<NhanVien>();
                try
                {
                    while (DataReader.Read())
                    {
                        ListGiamDoc.Add(new NhanVien
                        {
                            IdNhanVien = DataReader.GetDecimal("IdNhanVien"),
                            MaNhanVien = DataReader["MaNhanVien"].ToString(),
                            HoVaTen = DataReader["HoVaTen"].ToString(),
                            MatKhau = DataReader["MatKhau"].ToString(),
                            Chon = DataReader["Chon"].ToString().Equals("1") ? 1 : 0,
                            Admin = DataReader.GetInt("admin"),
                        });
                    }
                }
                catch (Exception ex)
                {
                    XuLyLoi.LogError(ex);
                }
                finally
                {
                    if (DataReader != null)
                    {
                        DataReader.Close();
                    }
                    DataReader = null;
                }
            }
            return ListGiamDoc;
        }
        /// <summary>
        /// Lấy danh sách các nhân viên là giám đốc
        /// </summary>
        public static List<NhanVien> GetListNguoiNhanHoSo(MDB.MDBConnection MyConnection, string MaKhoa)
        {
            string sql;
            if (XemBenhAn.IsHis2)
            {
                sql = $@"select b.* from NhanVien_Khoa a join NhanVien b on a.IdNhanVien = b.IdNhanVien inner join Khoa c on c.IdKhoa = a.IdKhoa where  c.MaKhoa = :IdKhoa and b.MaNhanVien in (select manhanvien from {MedilinkDatabases.Database.Schema}.P_DMNHANVIEN where nguoinhanhoso=1)";
            }
            else
            {
                // 2021.05.10: chưa xử lý chung tất, xử lý tạm cho HIS2 trước, các HIS khác muốn dùng thì xử lý ở đây hoặc gán trực tiếp vào ListNguoiNhanHoSo
                return _listNguoiNhanHoSo;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("IdKhoa", MaKhoa);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            _listNguoiNhanHoSo = new List<NhanVien>();
            try
            {
                while (DataReader.Read())
                {
                    _listNguoiNhanHoSo.Add(new NhanVien
                    {
                        IdNhanVien = DataReader.GetDecimal("IdNhanVien"),
                        MaNhanVien = DataReader["MaNhanVien"].ToString(),
                        HoVaTen = DataReader["HoVaTen"].ToString(),
                        MatKhau = DataReader["MatKhau"].ToString(),
                        Chon = DataReader["Chon"].ToString().Equals("1") ? 1 : 0,
                        Admin = DataReader.GetInt("admin"),
                    });
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            finally
            {
                if (DataReader != null)
                {
                    DataReader.Close();
                }
                DataReader = null;
            }
            return _listNguoiNhanHoSo;
        }
        public static List<NhanVien> GetListNhanVien(MDB.MDBConnection MyConnection)
        {
            string sql =@"select * from NhanVien a where chon = 1 or chon is null";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ListNhanVien = new List<NhanVien>();
            while (DataReader.Read())
            {
                try
                {
                    ListNhanVien.Add(new NhanVien
                    {
                        IdNhanVien = DataReader.GetDecimal("IdNhanVien"),
                        MaNhanVien = DataReader["MaNhanVien"].ToString(),
                        HoVaTen = DataReader["HoVaTen"].ToString(),
                        MatKhau = DataReader["MatKhau"].ToString(),
                        Chon = DataReader["Chon"].ToString().Equals("1") ? 1 : 0,
                        Admin = DataReader.GetInt("admin"),
                    });
                }
                catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            try
            {
                DataReader.Close();
                DataReader = null;
            }
            catch { }
            return ListNhanVien;
        }
        public static List<NhanVien> GetListNhanVien2(MDB.MDBConnection MyConnection)
        {
            string sql =@"select *  from NhanVien a where chon = 1 or chon is null";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ListNhanVien = new List<NhanVien>();
            while (DataReader.Read())
            {
                try
                {
                    ListNhanVien.Add(new NhanVien
                    {
                        IdNhanVien = DataReader.GetDecimal("IdNhanVien"),
                        MaNhanVien = DataReader["MaNhanVien"].ToString(),
                        HoVaTen = DataReader["HoVaTen"].ToString(),
                        MatKhau = DataReader["MatKhau"].ToString(),
                        Chon = DataReader["Chon"].ToString().Equals("1") ? 1 : 0,
                        Admin = DataReader.GetInt("admin"),
                    });
                }
                catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            try
            {
                DataReader.Close();
                DataReader = null;
            }
            catch { }
            return ListNhanVien;
        }
        public static List<NhanVien> GetAllListNhanVien(MDB.MDBConnection MyConnection)
        {
            string sql = @"select * from NhanVien";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            List<NhanVien>  listNhanVien = new List<NhanVien>();
            try
            {
                while (DataReader.Read())
                {
                    listNhanVien.Add(new NhanVien
                    {
                        IdNhanVien = DataReader.GetDecimal("IdNhanVien"),
                        MaNhanVien = DataReader["MaNhanVien"].ToString(),
                        HoVaTen = DataReader["HoVaTen"].ToString(),
                        MatKhau = DataReader["MatKhau"].ToString(),
                        Chon = DataReader["Chon"].ToString().Equals("1") ? 1 : 0,
                        Admin = DataReader.GetInt("admin"),
                    });
                }
            }
            catch (Exception ex)
            {
                listNhanVien.Clear();
                MDB.ExceptionExtend.LogError(ex);
            }
            try
            {
                DataReader.Close();
                DataReader = null;
            }
            catch { }
            return listNhanVien;
        }
        public static List<NhanVien> GetListNhanVienByKhoa(MDB.MDBConnection MyConnection, string MaKhoa)
        {
            string sql = @"select b.* from NhanVien_Khoa a join NhanVien b on a.IdNhanVien = b.IdNhanVien inner join Khoa c on c.IdKhoa = a.IdKhoa where  c.MaKhoa = :IdKhoa";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("IdKhoa", MaKhoa);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ListNhanVien = new List<NhanVien>();
            while (DataReader.Read())
            {
                try
                {
                    ListNhanVien.Add(new NhanVien
                    {
                        MaNhanVien = DataReader["MaNhanVien"].ToString(),
                        HoVaTen = DataReader["HoVaTen"].ToString(),
                        MatKhau = DataReader["MatKhau"].ToString(),
                        Chon = DataReader["Chon"].ToString().Equals("1") ? 1 : 0,
                        Admin = DataReader.GetInt("admin"),
                    });
                }
                catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            try
            {
                DataReader.Close();
                DataReader = null;
            }
            catch { }
            if (ListNhanVien == null || ListNhanVien.Count == 0) ListNhanVien = GetListNhanVien(MyConnection);
            return ListNhanVien;
        }
        public static List<NhanVien> GetListNhanVienKhoaByKhoa(MDB.MDBConnection MyConnection, string IdKhoa)
        {
            string sql = @"select b.* from NhanVien_Khoa a join NhanVien b on a.IdNhanVien = b.IdNhanVien and a.IdKhoa = :IdKhoa";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("IdKhoa", IdKhoa);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            List<NhanVien> list = new List<NhanVien>();
            while (DataReader.Read())
            {
                try
                {
                    list.Add(new NhanVien
                    {
                        MaNhanVien = DataReader["MaNhanVien"].ToString(),
                        HoVaTen = DataReader["HoVaTen"].ToString(),
                        MatKhau = DataReader["MatKhau"].ToString(),
                        Chon = DataReader["Chon"].ToString().Equals("1") ? 1 : 0,
                        Admin = DataReader.GetInt("admin"),
                    });
                }
                catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            try
            {
                DataReader.Close();
                DataReader = null;
            }
            catch { }
            return list;
        }
        public static List<NhanVien_Khoa> GetAllListNhanVienKhoa(MDB.MDBConnection MyConnection)
        {
            string sql = @"select * from NhanVien_Khoa";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            List<NhanVien_Khoa> listNhanVien_Khoa = new List<NhanVien_Khoa>();
            try
            {
                while (DataReader.Read())
                {
                    listNhanVien_Khoa.Add(new NhanVien_Khoa
                    {
                        IdNhanVien = Convert.ToDecimal(DataReader["idnhanvien"]),
                        IdKhoa = Convert.ToDecimal(DataReader["idkhoa"]),
                    });
                }
            }
            catch (Exception ex)
            {
                listNhanVien_Khoa.Clear();
                MDB.ExceptionExtend.LogError(ex);
            }
            finally
            {
                DataReader.Close();
                DataReader = null;
            }
            return listNhanVien_Khoa;
        }
        public static NhanVien Select(MDB.MDBConnection MyConnection, decimal IDNhanVien)
        {
            string sql =
                      @"select * 
                        from NhanVien a
                        where IDNhanVien = :IDNhanVien";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("IDNhanVien", IDNhanVien);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            NhanVien NhanVien = new NhanVien();
            while (DataReader.Read())
            {
                NhanVien.IdNhanVien = DataReader.GetDecimal("IdNhanVien");
                NhanVien.MaNhanVien = DataReader["MaNhanVien"].ToString();
                NhanVien.HoVaTen = DataReader["HoVaTen"].ToString();
                NhanVien.MatKhau = DataReader["MatKhau"].ToString();
                NhanVien.Chon = DataReader["Chon"].ToString().Equals("1") ? 1 : 0;
                NhanVien.Admin = DataReader.GetInt("admin");
            }
            try
            {
                DataReader.Close();
                DataReader = null;
            }
            catch { }
            return NhanVien;
        }
        public static void InsertListNhanVien(MDB.MDBConnection MyConnection, List<NhanVien> ListNhanVien)
        {
            foreach (NhanVien NhanVien in ListNhanVien)
                InsertOrUpdateNhanVien(MyConnection, NhanVien);

            GetListNhanVien(MyConnection);
        }
        public static void InsertOrUpdateNhanVien(MDB.MDBConnection MyConnection, NhanVien NhanVien)
        {
            try
            {
                string sql = "";
                //      @"select MaNhanVien 
                //        from NhanVien
                //        where IdNhanVien = :IdNhanVien";
                //#endregion
                //MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                //Command.Parameters.Add("IdNhanVien", NhanVien.IdNhanVien);
                //MDB.MDBDataReader DataReader = Command.ExecuteReader();
                //int rowCount = 0;
                //while (DataReader.Read()) rowCount++;
                //if (rowCount == 1)  UpdateNhanVien(MyConnection, NhanVien);
                sql = @"UPDATE NhanVien SET MaNhanVien = :MaNhanVien, HoVaTen = :HoVaTen, Chon = :Chon,admin=" + NhanVien.Admin + " WHERE IdNhanVien = :IdNhanVien";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add("MaNhanVien", NhanVien.MaNhanVien);
                Command.Parameters.Add("HoVaTen", NhanVien.HoVaTen);
                Command.Parameters.Add("IdNhanVien", NhanVien.IdNhanVien);
                Command.Parameters.Add("Chon", NhanVien.Chon);
                int n = Command.ExecuteNonQuery(); // C#
                if (n == 0)
                {
                    sql = @"INSERT INTO NhanVien (IdNhanVien , MaNhanVien, HoVaTen, Chon, admin)
                VALUES(:IdNhanVien,:MaNhanVien, :HoVaTen, :Chon," + NhanVien.Admin + ")";
                    Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add("IdNhanVien", NhanVien.IdNhanVien);
                    Command.Parameters.Add("MaNhanVien", NhanVien.MaNhanVien);
                    Command.Parameters.Add("HoVaTen", NhanVien.HoVaTen);
                    Command.Parameters.Add("Chon", NhanVien.Chon);
                    n = Command.ExecuteNonQuery(); // C#
                }
            }
            catch(Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
            }
        }
        public static void UpdateNhanVien(MDB.MDBConnection MyConnection, NhanVien NhanVien)
        {
            string sql = @"UPDATE NhanVien SET 
                        MaNhanVien = :MaNhanVien,
                        HoVaTen = :HoVaTen,
                        Chon = :Chon,admin=" + NhanVien.Admin + " WHERE IdNhanVien = :IdNhanVien";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("MaNhanVien", NhanVien.MaNhanVien);
            Command.Parameters.Add("HoVaTen", NhanVien.HoVaTen);
            Command.Parameters.Add("IdNhanVien", NhanVien.IdNhanVien);
            Command.Parameters.Add("Chon", NhanVien.Chon);
            int n = Command.ExecuteNonQuery(); // C#
        }
        public static void UpdateMatKhau(MDB.MDBConnection MyConnection, NhanVien NhanVien)
        {
            try
            {
                string sql = @"update NhanVien set MatKhau = :MatKhau where IdNhanVien = :IdNhanVien";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add("MatKhau",NhanVien.MatKhau);
                Command.Parameters.Add("IdNhanVien",NhanVien.IdNhanVien);
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
        }
        public static bool CheckNhanVien(MDB.MDBConnection MyConnection, NhanVien NhanVien)
        {
            int Admin = 0;
            try
            {
                string sql = @"select ADMIN from NhanVien where MatKhau = :MatKhau and MaNhanVien = :MaNhanVien";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add("MatKhau", MaHoaFunc.Encrypt(NhanVien.MatKhau, MaHoaFunc.initVector));
                Command.Parameters.Add("MaNhanVien", NhanVien.MaNhanVien);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    Admin = DataReader.GetInt("admin");
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return Admin == 1;
        }
        public static bool DeleteNhanVien(MDB.MDBConnection MyConnection, NhanVien NhanVien)
        {
            string sql = @"DELETE FROM NhanVien 
                           WHERE MaNhanVien = :MaNhanVien";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("MaNhanVien", NhanVien.MaNhanVien);
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }

        public static void NhanVienComboBox_Filter(ComboBox sender)
        {
            var NhanVienComboBox = sender.Tag as List<NhanVien>;
            if (NhanVienComboBox == null)
            {
                NhanVienComboBox = sender.ItemsSource as List<NhanVien>;
                sender.Tag = NhanVienComboBox;
            }
            sender.IsDropDownOpen = true;
            if (sender.Text.Trim() == "")
            {
                sender.ItemsSource = NhanVienComboBox;
                try
                {
                    sender.SelectedItem = null;
                }
                catch { }
            }
            else
            {
                sender.ItemsSource = NhanVienComboBox.Where(x => x.HoVaTen.ToLower().Contains(sender.Text.Trim().ToLower()));
            }
        }
    }
}