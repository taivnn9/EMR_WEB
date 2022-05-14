
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class DieuTriPhucHoiChucNangFunc
    {
        public static MDB.MDBDataAdapter GetDataSet(MDB.MDBConnection MyConnection, string MaBenhNhan, decimal MaQuanLy)
        {
            string sql = @"SELECT * FROM PHIEUDIEUTRIPHUCHOICHUCNANG WHERE MaBenhNhan = :MaBenhNhan AND MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                adt = new MDB.MDBDataAdapter(Command);
            }
            return adt;

        }
        public static DieuTriPhucHoiChucNang Select(MDB.MDBConnection MyConnection, string MaBenhNhan, decimal MaQuanLy)
        {
            string sql = @"SELECT * FROM PHIEUDIEUTRIPHUCHOICHUCNANG WHERE MaBenhNhan = :MaBenhNhan AND MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            DieuTriPhucHoiChucNang item = new DieuTriPhucHoiChucNang();
            while (DataReader.Read())
            {
                item.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                item.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                item.NoiGui = DataReader["NoiGui"].ToString();
                try
                {
                    item.ThoiGian = (DateTime)DataReader["ThoiGian"];
                }
                catch { }
                item.ViTri = DataReader["ViTri"].ToString();
                item.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"].ToString();
                item.PhuongPhapDieuTriChiTiet = DataReader["PhuongPhapDieuTriChiTiet"].ToString();
                item.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                item.TenBacSyDieuTri = DataReader["TenBacSyDieuTri"].ToString();
                item.MaNguoiThucHien = DataReader["MaNguoiThucHien"].ToString();
                item.TenNguoiThucHien = DataReader["TenNguoiThucHien"].ToString();
                item.HinhAnhTruoc = ERMDatabase.FTPImageString + DataReader["HinhAnhTruoc"].ToString();
                item.HinhAnhSau = ERMDatabase.FTPImageString + DataReader["HinhAnhSau"].ToString();
                item.HinhAnhTrai = ERMDatabase.FTPImageString + DataReader["HinhAnhTrai"].ToString();
                item.HinhAnhPhai = ERMDatabase.FTPImageString + DataReader["HinhAnhPhai"].ToString();
                item.TenFileKy = DataReader["TenFileKy"].ToString();
                item.UserNameKy = DataReader["UsernameKy"].ToString();
                try
                {
                    item.NgayKy = (DateTime)DataReader["NgayKy"];
                }
                catch { }
                item.ComputerKyTen = DataReader["ComputerKyTen"].ToString();
                item.MaSoKy = DataReader["MaSoKyTen"].ToString();
            }
            return item;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, DieuTriPhucHoiChucNang data)
        {
            string sql = @"SELECT * FROM PHIEUDIEUTRIPHUCHOICHUCNANG WHERE MaBenhNhan = :MaBenhNhan AND MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 0)
            {
                sql = @"
                   INSERT INTO PHIEUDIEUTRIPHUCHOICHUCNANG (MaBenhNhan, MaQuanLy, NoiGui, ThoiGian, ViTri, PhuongPhapDieuTri, PhuongPhapDieuTriChiTiet, MaBacSyDieuTri, TenBacSyDieuTri, MaNguoiThucHien, TenNguoiThucHien, HinhAnhTruoc, HinhAnhSau, HinhAnhTrai, HinhAnhPhai, TenFileKy, UsernameKy, NgayKy, ComputerKyTen, MaSoKyTen)
                   VALUES(:MaBenhNhan, :MaQuanLy, :NoiGui, to_date(:ThoiGian,'yyyyMMddHH24mi'), :ViTri, :PhuongPhapDieuTri, :PhuongPhapDieuTriChiTiet, :MaBacSyDieuTri, :TenBacSyDieuTri, :MaNguoiThucHien, :TenNguoiThucHien, :HinhAnhTruoc, :HinhAnhSau, :HinhAnhTrai, :HinhAnhPhai, :TenFileKy, :UsernameKy, to_date(:NgayKy,'yyyyMMddHH24mi'), :ComputerKyTen, :MaSoKyTen)";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("NoiGui", data.NoiGui));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian.ToString("yyyyMMddHHmm")));
                Command.Parameters.Add(new MDB.MDBParameter("ViTri", data.ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", data.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTriChiTiet", data.PhuongPhapDieuTriChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", data.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TenBacSyDieuTri", data.TenBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", data.MaNguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("TenNguoiThucHien", data.TenNguoiThucHien));
                if (ERMDatabase.FTPImageString != null)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("HinhAnhTruoc", data.HinhAnhTruoc != null ? data.HinhAnhTruoc.Replace(ERMDatabase.FTPImageString, "") : ""));
                    Command.Parameters.Add(new MDB.MDBParameter("HinhAnhSau", data.HinhAnhSau != null ? data.HinhAnhSau.Replace(ERMDatabase.FTPImageString, "") : ""));
                    Command.Parameters.Add(new MDB.MDBParameter("HinhAnhTrai", data.HinhAnhTrai != null ? data.HinhAnhTrai.Replace(ERMDatabase.FTPImageString, "") : ""));
                    Command.Parameters.Add(new MDB.MDBParameter("HinhAnhPhai", data.HinhAnhPhai != null ? data.HinhAnhPhai.Replace(ERMDatabase.FTPImageString, "") : ""));
                }                
                Command.Parameters.Add(new MDB.MDBParameter("TenFileKy", data.TenFileKy));
                Command.Parameters.Add(new MDB.MDBParameter("UsernameKy", data.UserNameKy));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKy", data.NgayKy.ToString("yyyyMMddHHmm")));
                Command.Parameters.Add(new MDB.MDBParameter("ComputerKyTen", data.ComputerKyTen));
                Command.Parameters.Add(new MDB.MDBParameter("MaSoKyTen", data.MaSoKy));
                return Command.ExecuteNonQuery() > 0;
            }
            sql = @"UPDATE PHIEUDIEUTRIPHUCHOICHUCNANG SET 
                        NoiGui = :NoiGui,
                        ThoiGian = to_date(:ThoiGian,'yyyyMMddHH24mi'),
                        ViTri = :ViTri,
                        PhuongPhapDieuTri = :PhuongPhapDieuTri,
                        PhuongPhapDieuTriChiTiet = :PhuongPhapDieuTriChiTiet,
                        MaBacSyDieuTri = :MaBacSyDieuTri,
                        TenBacSyDieuTri = :TenBacSyDieuTri,
                        MaNguoiThucHien = :MaNguoiThucHien,
                        TenNguoiThucHien = :TenNguoiThucHien,
                        HinhAnhTruoc = :HinhAnhTruoc,
                        HinhAnhSau = :HinhAnhSau,
                        HinhAnhTrai = :HinhAnhTrai,
                        HinhAnhPhai = :HinhAnhPhai,
                        TenFileKy = :TenFileKy,
                        UsernameKy = :UsernameKy,
                        NgayKy = to_date(:NgayKy,'yyyyMMddHH24mi'),
                        ComputerKyTen = :ComputerKyTen,
                        MaSoKyTen = :MaSoKyTen
                        WHERE MaBenhNhan = :MaBenhNhan AND MaQuanLy = :MaQuanLy";

            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("NoiGui", data.NoiGui));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri", data.ViTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", data.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTriChiTiet", data.PhuongPhapDieuTriChiTiet));
            Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", data.MaBacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TenBacSyDieuTri", data.TenBacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", data.MaNguoiThucHien));
            Command.Parameters.Add(new MDB.MDBParameter("TenNguoiThucHien", data.TenNguoiThucHien));
            if (ERMDatabase.FTPImageString != null)
            {
                Command.Parameters.Add(new MDB.MDBParameter("HinhAnhTruoc", data.HinhAnhTruoc != null ? data.HinhAnhTruoc.Replace(ERMDatabase.FTPImageString, "") : ""));
                Command.Parameters.Add(new MDB.MDBParameter("HinhAnhSau", data.HinhAnhSau != null ? data.HinhAnhSau.Replace(ERMDatabase.FTPImageString, "") : ""));
                Command.Parameters.Add(new MDB.MDBParameter("HinhAnhTrai", data.HinhAnhTrai != null ? data.HinhAnhTrai.Replace(ERMDatabase.FTPImageString, "") : ""));
                Command.Parameters.Add(new MDB.MDBParameter("HinhAnhPhai", data.HinhAnhPhai != null ? data.HinhAnhPhai.Replace(ERMDatabase.FTPImageString, "") : ""));
            }            
            Command.Parameters.Add(new MDB.MDBParameter("TenFileKy", data.TenFileKy));
            Command.Parameters.Add(new MDB.MDBParameter("UsernameKy", data.UserNameKy));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKy", data.NgayKy.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("ComputerKyTen", data.ComputerKyTen));
            Command.Parameters.Add(new MDB.MDBParameter("MaSoKyTen", data.MaSoKy));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
            return Command.ExecuteNonQuery() > 0;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, string MaBenhNhan, decimal MaQuanLy)
        {
            string sql = @"DELETE FROM PHIEUDIEUTRIPHUCHOICHUCNANG WHERE MaBenhNhan = :MaBenhNhan AND MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            return Command.ExecuteNonQuery() > 0;
        }
    }
}