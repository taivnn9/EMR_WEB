
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDGMucDoTuKiTE : ThongTinKy
    {
        public PhieuDGMucDoTuKiTE()
        {
            TableName = "PhieuDGMucDoTuKiTE";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDGMDTKTE;
            TenMauPhieu = DanhMucPhieu.PDGMDTKTE.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public string NgaySinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public DateTime ThoiGian { get; set; }
        public int DG1 { get; set; }
        public int DG2 { get; set; }
        public int DG3 { get; set; }
        public int DG4 { get; set; }
        public int DG5 { get; set; }
        public int DG6 { get; set; }
        public int DG7 { get; set; }
        public int DG8 { get; set; }
        public int DG9 { get; set; }
        public int DG10 { get; set; }
        public int DG11 { get; set; }
        public int DG12 { get; set; }
        public int DG13 { get; set; }
        public int DG14 { get; set; }
        public int DG15 { get; set; }

        public double Diem_DG1
        {
            get
            {
                if (DG1 == 1)
                {
                    return 1;
                }
                else if (DG1 == 2)
                {
                    return 1.5;
                }
                else if (DG1 == 3)
                {
                    return 2;
                }
                else if (DG1 == 4)
                {
                    return 2.5;
                }
                else if (DG1 == 5)
                {
                    return 3;
                }
                else if (DG1 == 6)
                {
                    return 3.5;
                }
                else if (DG1 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG2
        {
            get
            {
                if (DG2 == 1)
                {
                    return 1;
                }
                else if (DG2 == 2)
                {
                    return 1.5;
                }
                else if (DG2 == 3)
                {
                    return 2;
                }
                else if (DG2 == 4)
                {
                    return 2.5;
                }
                else if (DG2 == 5)
                {
                    return 3;
                }
                else if (DG2 == 6)
                {
                    return 3.5;
                }
                else if (DG2 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG3
        {
            get
            {
                if (DG3 == 1)
                {
                    return 1;
                }
                else if (DG3 == 2)
                {
                    return 1.5;
                }
                else if (DG3 == 3)
                {
                    return 2;
                }
                else if (DG3 == 4)
                {
                    return 2.5;
                }
                else if (DG3 == 5)
                {
                    return 3;
                }
                else if (DG3 == 6)
                {
                    return 3.5;
                }
                else if (DG3 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }
        public double Diem_DG4
        {
            get
            {
                if (DG4 == 1)
                {
                    return 1;
                }
                else if (DG4 == 2)
                {
                    return 1.5;
                }
                else if (DG4 == 3)
                {
                    return 2;
                }
                else if (DG4 == 4)
                {
                    return 2.5;
                }
                else if (DG4 == 5)
                {
                    return 3;
                }
                else if (DG4 == 6)
                {
                    return 3.5;
                }
                else if (DG4 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG5
        {
            get
            {
                if (DG5 == 1)
                {
                    return 1;
                }
                else if (DG5 == 2)
                {
                    return 1.5;
                }
                else if (DG5 == 3)
                {
                    return 2;
                }
                else if (DG5 == 4)
                {
                    return 2.5;
                }
                else if (DG5 == 5)
                {
                    return 3;
                }
                else if (DG5 == 6)
                {
                    return 3.5;
                }
                else if (DG5 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG6
        {
            get
            {
                if (DG6 == 1)
                {
                    return 1;
                }
                else if (DG6 == 2)
                {
                    return 1.5;
                }
                else if (DG6 == 3)
                {
                    return 2;
                }
                else if (DG6 == 4)
                {
                    return 2.5;
                }
                else if (DG6 == 5)
                {
                    return 3;
                }
                else if (DG6 == 6)
                {
                    return 3.5;
                }
                else if (DG6 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG7
        {
            get
            {
                if (DG7 == 1)
                {
                    return 1;
                }
                else if (DG7 == 2)
                {
                    return 1.5;
                }
                else if (DG7 == 3)
                {
                    return 2;
                }
                else if (DG7 == 4)
                {
                    return 2.5;
                }
                else if (DG7 == 5)
                {
                    return 3;
                }
                else if (DG7 == 6)
                {
                    return 3.5;
                }
                else if (DG7 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG8
        {
            get
            {
                if (DG8 == 1)
                {
                    return 1;
                }
                else if (DG8 == 2)
                {
                    return 1.5;
                }
                else if (DG8 == 3)
                {
                    return 2;
                }
                else if (DG8 == 4)
                {
                    return 2.5;
                }
                else if (DG8 == 5)
                {
                    return 3;
                }
                else if (DG8 == 6)
                {
                    return 3.5;
                }
                else if (DG8 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG9
        {
            get
            {
                if (DG9 == 1)
                {
                    return 1;
                }
                else if (DG9 == 2)
                {
                    return 1.5;
                }
                else if (DG9 == 3)
                {
                    return 2;
                }
                else if (DG9 == 4)
                {
                    return 2.5;
                }
                else if (DG9 == 5)
                {
                    return 3;
                }
                else if (DG9 == 6)
                {
                    return 3.5;
                }
                else if (DG9 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG10
        {
            get
            {
                if (DG10 == 1)
                {
                    return 1;
                }
                else if (DG10 == 2)
                {
                    return 1.5;
                }
                else if (DG10 == 3)
                {
                    return 2;
                }
                else if (DG10 == 4)
                {
                    return 2.5;
                }
                else if (DG10 == 5)
                {
                    return 3;
                }
                else if (DG10 == 6)
                {
                    return 3.5;
                }
                else if (DG10 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG11
        {
            get
            {
                if (DG11 == 1)
                {
                    return 1;
                }
                else if (DG11 == 2)
                {
                    return 1.5;
                }
                else if (DG11 == 3)
                {
                    return 2;
                }
                else if (DG11 == 4)
                {
                    return 2.5;
                }
                else if (DG11 == 5)
                {
                    return 3;
                }
                else if (DG11 == 6)
                {
                    return 3.5;
                }
                else if (DG11 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG12
        {
            get
            {
                if (DG12 == 1)
                {
                    return 1;
                }
                else if (DG12 == 2)
                {
                    return 1.5;
                }
                else if (DG12 == 3)
                {
                    return 2;
                }
                else if (DG12 == 4)
                {
                    return 2.5;
                }
                else if (DG12 == 5)
                {
                    return 3;
                }
                else if (DG12 == 6)
                {
                    return 3.5;
                }
                else if (DG12 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG13
        {
            get
            {
                if (DG13 == 1)
                {
                    return 1;
                }
                else if (DG13 == 2)
                {
                    return 1.5;
                }
                else if (DG13 == 3)
                {
                    return 2;
                }
                else if (DG13 == 4)
                {
                    return 2.5;
                }
                else if (DG13 == 5)
                {
                    return 3;
                }
                else if (DG13 == 6)
                {
                    return 3.5;
                }
                else if (DG13 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG14
        {
            get
            {
                if (DG14 == 1)
                {
                    return 1;
                }
                else if (DG14 == 2)
                {
                    return 1.5;
                }
                else if (DG14 == 3)
                {
                    return 2;
                }
                else if (DG14 == 4)
                {
                    return 2.5;
                }
                else if (DG14 == 5)
                {
                    return 3;
                }
                else if (DG14 == 6)
                {
                    return 3.5;
                }
                else if (DG14 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }

        public double Diem_DG15
        {
            get
            {
                if (DG15 == 1)
                {
                    return 1;
                }
                else if (DG15 == 2)
                {
                    return 1.5;
                }
                else if (DG15 == 3)
                {
                    return 2;
                }
                else if (DG15 == 4)
                {
                    return 2.5;
                }
                else if (DG15 == 5)
                {
                    return 3;
                }
                else if (DG15 == 6)
                {
                    return 3.5;
                }
                else if (DG15 == 7)
                {
                    return 4;
                }
                return 0;
            }
        }
        public float? TongDiem { get; set; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        public string MaNVNguoiThucHien { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
       
    }
    public class PhieuDGMucDoTuKiTEFunc
    {
        public static bool InsertOrUpdate(PhieuDGMucDoTuKiTE obj, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "";
                if (obj.ID > 0)
                    sql = @"UPDATE PhieuDGMucDoTuKiTE SET 
                        MaQuanLy =:MaQuanLy,
                        MaBenhNhan =:MaBenhNhan,
                        TenBenhNhan =:TenBenhNhan,
                        NgaySinh =:NgaySinh,
                        DiaChi =:DiaChi,
                        ThoiGian =:ThoiGian,
                        DG1 =:DG1,
                        DG2 =:DG2,
                        DG3 =:DG3,
                        DG4 =:DG4,
                        DG5 =:DG5,
                        DG6 =:DG6,
                        DG7 =:DG7,
                        DG8 =:DG8,
                        DG9 =:DG9,
                        DG10 =:DG10,
                        DG11 =:DG11,
                        DG12 =:DG12,
                        DG13 =:DG13,
                        DG14 =:DG14,
                        DG15 =:DG15,
                        TongDiem =:TongDiem,
                        NguoiThucHien =:NguoiThucHien,
                        MaNVNguoiThucHien =:MaNVNguoiThucHien,
                        NgaySua =:NgaySua,
                        NguoiSua =:NguoiSua,
                        WHERE ID = " + obj.ID;
                else
                    sql = @"INSERT INTO PhieuDGMucDoTuKiTE (
                        MaQuanLy,
                        MaBenhNhan,
                        TenBenhNhan,
                        NgaySinh,
                        DiaChi,
                        ThoiGian,
                        DG1,
                        DG2,
                        DG3,
                        DG4,
                        DG5,
                        DG6,
                        DG7,
                        DG8,
                        DG9,
                        DG10,
                        DG11,
                        DG12,
                        DG13,
                        DG14,
                        DG15,
                        TongDiem,
                        NguoiThucHien,
                        MaNVNguoiThucHien,
                        NgayTao,
                        NguoiTao,
                        NgaySua,
                        NguoiSua
                        )VALUES
                        (
                        :MaQuanLy,
                        :MaBenhNhan,
                        :TenBenhNhan,
                        :NgaySinh,
                        :DiaChi,
                        :ThoiGian,
                        :DG1,
                        :DG2,
                        :DG3,
                        :DG4,
                        :DG5,
                        :DG6,
                        :DG7,
                        :DG8,
                        :DG9,
                        :DG10,
                        :DG11,
                        :DG12,
                        :DG13,
                        :DG14,
                        :DG15,
                        :TongDiem,
                        :NguoiThucHien,
                        :MaNVNguoiThucHien,
                        :NgayTao,
                        :NguoiTao,
                        :NgaySua,
                        :NguoiSua
                        ) RETURNING ID INTO :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                command.Parameters.Add(new MDB.MDBParameter("NgaySinh", obj.NgaySinh));
                command.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                command.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                command.Parameters.Add(new MDB.MDBParameter("DG1", obj.DG1));
                command.Parameters.Add(new MDB.MDBParameter("DG2", obj.DG2));
                command.Parameters.Add(new MDB.MDBParameter("DG3", obj.DG3));
                command.Parameters.Add(new MDB.MDBParameter("DG4", obj.DG4));
                command.Parameters.Add(new MDB.MDBParameter("DG5", obj.DG5));
                command.Parameters.Add(new MDB.MDBParameter("DG6", obj.DG6));
                command.Parameters.Add(new MDB.MDBParameter("DG7", obj.DG7));
                command.Parameters.Add(new MDB.MDBParameter("DG8", obj.DG8));
                command.Parameters.Add(new MDB.MDBParameter("DG9", obj.DG9));
                command.Parameters.Add(new MDB.MDBParameter("DG10", obj.DG10));
                command.Parameters.Add(new MDB.MDBParameter("DG11", obj.DG11));
                command.Parameters.Add(new MDB.MDBParameter("DG12", obj.DG12));
                command.Parameters.Add(new MDB.MDBParameter("DG13", obj.DG13));
                command.Parameters.Add(new MDB.MDBParameter("DG14", obj.DG14));
                command.Parameters.Add(new MDB.MDBParameter("DG15", obj.DG15));
                command.Parameters.Add(new MDB.MDBParameter("TongDiem", obj.TongDiem));
                command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", obj.NguoiThucHien));
                command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiThucHien", obj.MaNVNguoiThucHien));
                command.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                command.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                if (obj.ID == 0)
                {
                    command.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                    command.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    command.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                }
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                if (obj.ID == 0)
                {
                    long nextval = Convert.ToInt64((command.Parameters["ID"] as MDB.MDBParameter).Value);
                    obj.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
      
        public static List<PhieuDGMucDoTuKiTE> GetData(decimal MaQuanLy, MDB.MDBConnection conn)
        {
            List<PhieuDGMucDoTuKiTE> lstObject = new List<PhieuDGMucDoTuKiTE>();
            try
            {
                string sql = "SELECT * FROM PhieuDGMucDoTuKiTE WHERE MAQUANLY = :MAQUANLY ORDER BY ID DESC";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    EMR_MAIN.DATABASE.Other.PhieuDGMucDoTuKiTE obj = new PhieuDGMucDoTuKiTE();
                    obj.ID = Convert.ToInt64(DataReader.GetLong("ID"));
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                    obj.NgaySinh = Common.ConDBNull(DataReader["NgaySinh"]);
                    obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    obj.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    obj.DG1 = Common.ConDB_Int(DataReader["DG1"]);
                    obj.DG2 = Common.ConDB_Int(DataReader["DG2"]);
                    obj.DG3 = Common.ConDB_Int(DataReader["DG3"]);
                    obj.DG4 = Common.ConDB_Int(DataReader["DG4"]);
                    obj.DG5 = Common.ConDB_Int(DataReader["DG5"]);
                    obj.DG6 = Common.ConDB_Int(DataReader["DG6"]);
                    obj.DG7 = Common.ConDB_Int(DataReader["DG7"]);
                    obj.DG8 = Common.ConDB_Int(DataReader["DG8"]);
                    obj.DG9 = Common.ConDB_Int(DataReader["DG9"]);
                    obj.DG10 = Common.ConDB_Int(DataReader["DG10"]);
                    obj.DG11 = Common.ConDB_Int(DataReader["DG11"]);
                    obj.DG12 = Common.ConDB_Int(DataReader["DG12"]);
                    obj.DG13 = Common.ConDB_Int(DataReader["DG13"]);
                    obj.DG14 = Common.ConDB_Int(DataReader["DG14"]);
                    obj.DG15 = Common.ConDB_Int(DataReader["DG15"]);
                    obj.TongDiem = Common.ConDB_float(DataReader["TongDiem"]);
                    obj.NguoiThucHien = Common.ConDBNull(DataReader["NguoiThucHien"]);
                    obj.MaNVNguoiThucHien = Common.ConDBNull(DataReader["MaNVNguoiThucHien"]);
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.MaNVNguoiThucHien = Common.ConDBNull(DataReader["MaNVNguoiThucHien"]);
                    obj.NguoiThucHien = Common.ConDBNull(DataReader["NguoiThucHien"]);
                    obj.MaSoKy = DataReader.GetString("masokyten");
                    obj.NgayKy = DataReader.GetDate("ngayky");
                    obj.TenFileKy = DataReader.GetString("tenfileky");
                    obj.UserNameKy = DataReader.GetString("usernameky");
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;

                    obj.Chon = false;
                    lstObject.Add(obj);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstObject;
        }
     
        public static bool Delete(long ID, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "DELETE FROM PhieuDGMucDoTuKiTE WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
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
        public static DataSet GetDataSet(long ID, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "SELECT * FROM PhieuDGMucDoTuKiTE WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataAdapter dataAdapter = new MDB.MDBDataAdapter(command);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Table");
                ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
                ds.Tables[0].AddColumn("NamSinh", typeof(string));

                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.ToString("dd-MM-yyyy");

                return ds;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
    }
}
