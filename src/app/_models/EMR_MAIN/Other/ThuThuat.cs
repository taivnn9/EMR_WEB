
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class ThuThuat : ThongTinKy
    {
        public ThuThuat()
        {
            TableName = "PhieuThuThuat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTT;
            TenMauPhieu = DanhMucPhieu.PTT.Description();
        }

        [Key]
        [MoTaDuLieu("Mã định danh")]
		public decimal IDThuThuat { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string LoaiThuThuat { get; set; }
        public DateTime NgayGioThucHien { get; set; }
        //public string SoLuongBSThamGiaTT { get; set; }
        //public string SoLuongDDThamGiaTT { get; set; }

        /// <summary>
        /// Tên thủ thuật (giá dịch vụ)
        /// </summary>
        public string NoiDungThucHien { get; set; }

        /// <summary>
        /// Mô tả cách thức thực hiện trong quá trình thủ thuật
        /// </summary>
        public string MoTaChiTiet { get; set; }

        /// <summary>
        /// Link ảnh mô tả sẽ được lưu là một list các tên ảnh, cách nhau bởi dấu ;
        /// khi lấy thông tin link đầu đủ của ảnh, sẽ lấy theo fpt server_folder_link
        /// ví dụ LinkAnhMoTa = "truoc_no.png;sau_mo.png;sau_khau.png"
        /// link le cua tung anh sẽ là ftp_server + ftp_folder+/truoc_mo.png...
        /// </summary>
        public string LinkAnhMoTa { get; set; }
        public string DienBienSauThucHien { get; set; }

        /// <summary>
        /// Ekip thực hiện
        /// </summary>
        public ObservableCollection<BacSyDieuDuong> ListBsDd { get; set; }
    }

    public enum ChucVuEkip
    {
        BacSi=0,
        DieuDuong=1,
    }
    public class BacSyDieuDuong
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal IDThuThuat { get; set; }     
        public string Stt { get; set; }
        public ChucVuEkip ChucVuEkip { get; set; }
        public NhanVien NhanVien { get; set; }

        public BacSyDieuDuong(NhanVien nhanVien)
        {
            this.NhanVien = nhanVien;
        }
    }


    public class ThuThuatFunc
    {
        public static decimal InsertOrUpdate(MDB.MDBConnection MyConnection, ThuThuat ThuThuat)
        {
            return 0;
        }

        public static List<ThuThuat> GetData(MDB.MDBConnection MyConnection, string MaBenhAn, string TenKhoa, string IDThuThuat)
        {
           
            return null;
        }

        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDThuThuat)
        {
            string sql = ""; //@a linhpq giúp em câu lệnh querry nhé

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDThuThuat", IDThuThuat));
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            return ds;
        }
    }
}
