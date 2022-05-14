
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.TrangBia
{
    public class TrangBiaNoiKhoa
    {
        public string SoYTe { get; set; }
        public string BenhVien { get; set; }
        public string SoLuuTru { get; set; }
        public string MaBenhNhan { get; set; }
        public string SoVaoVien { get; set; }
        public string DoiTuong { get; set; }
        public string NgayChuyenDoiTuong { get; set; }
        public string HoTenBenhNhan { get; set; }
        public string Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string ChanDoanBanDau { get; set; }
        public string ChanDoanRaVien { get; set; }
        public string NgayVaoVien { get; set; }
        public string NgayRaVien { get; set; }

        public static DataSet GetTrangBiaNoiKhoa(MDB.MDBConnection MyConnection, string SoNhapVien)
        {
            string sql = @"select a.*, to_char(thoigian, 'dd/MM/yyyy HH24:mi') thoigianbaocao from THONGTINCHAMSOC a WHERE  MaBenhAn = :MaBenhAn and TenKhoa = :TenKhoa ORDER BY IDThongTinChamSoc Desc";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("SoNhapVien", SoNhapVien));
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            return ds;
        }
    }
}
