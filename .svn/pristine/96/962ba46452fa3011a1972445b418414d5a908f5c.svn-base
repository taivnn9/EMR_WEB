
using EMR.KyDienTu;
using System.Collections.Generic;

namespace EMR_MAIN
{
    public class TienSuSanKhoa : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public int IDTienSuSanKhoa { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public int Nam { get; set; }
        public bool DeDuThang { get; set; }
        public bool DeThieuThang { get; set; }
        public bool Say { get; set; }
        public bool Hut { get; set; }
        public bool Nao { get; set; }
        public bool Covac { get; set; }
        public bool ChuaNgoaiTC { get; set; }
        public bool ChuaTrung { get; set; }
        public bool ThaiChetLuu { get; set; }
        public bool ConHienSong { get; set; }
        public double? CanNang { get; set; }
        public string PhuongPhapDe { get; set; }
        public bool TaiBien { get; set; }
    }
    public class TienSuSanKhoaFunc
    {
        public static List<TienSuSanKhoa> ListTienSuSanKhoa { get; private set; }

        public static List<TienSuSanKhoa> GetListTienSuSanKhoa(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"   select a.*
            from TienSuSanKhoa a
                  where a.maquanly = '" + MaQuanLy + "'";

            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ListTienSuSanKhoa = new List<TienSuSanKhoa>();
            double doubleTemp = 0;
            while (DataReader.Read())
            {
                ListTienSuSanKhoa.Add(new TienSuSanKhoa
                {
                    IDTienSuSanKhoa = int.Parse(DataReader["IDTienSuSanKhoa"].ToString()),
                    MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString()),
                    Nam = int.Parse(DataReader["Nam"].ToString()),
                    DeDuThang = DataReader["DeDuThang"].ToString() == "1" ? true : false,
                    DeThieuThang = DataReader["DeThieuThang"].ToString() == "1" ? true : false,
                    Say = DataReader["Say"].ToString() == "1" ? true : false,
                    Hut = DataReader["Hut"].ToString() == "1" ? true : false,
                    Nao = DataReader["Nao"].ToString() == "1" ? true : false,
                    Covac = DataReader["Covac"].ToString() == "1" ? true : false,
                    ChuaNgoaiTC = DataReader["ChuaNgoaiTC"].ToString() == "1" ? true : false,
                    ChuaTrung = DataReader["ChuaTrung"].ToString() == "1" ? true : false,
                    ThaiChetLuu = DataReader["ThaiChetLuu"].ToString() == "1" ? true : false,
                    ConHienSong = DataReader["ConHienSong"].ToString() == "1" ? true : false,
                    CanNang = double.TryParse(DataReader["CanNang"].ToString(), out doubleTemp) ? (double?)doubleTemp: null,
                    PhuongPhapDe = DataReader["PhuongPhapDe"].ToString(),
                    TaiBien = DataReader["TaiBien"].ToString() == "1" ? true : false,
                }); ;
            }
            return ListTienSuSanKhoa;
        }

        public static TienSuSanKhoa Select(MDB.MDBConnection MyConnection, decimal IDTienSuSanKhoa)
        {
            #region
            string sql =
                      @"select * 
                        from TienSuSanKhoa a
                        where IDTienSuSanKhoa = :IDTienSuSanKhoa";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDTienSuSanKhoa", IDTienSuSanKhoa));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            TienSuSanKhoa TienSuSanKhoa = new TienSuSanKhoa();
            double doubleTemp = 0;
            while (DataReader.Read())
            {
                TienSuSanKhoa.IDTienSuSanKhoa = int.Parse(DataReader["IDPhauThuThuThuat"].ToString());
                TienSuSanKhoa.MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString());
                TienSuSanKhoa.Nam = int.Parse(DataReader["Nam"].ToString());
                TienSuSanKhoa.DeDuThang = DataReader["DeDuThang"].ToString() == "1" ? true : false;
                TienSuSanKhoa.DeThieuThang = DataReader["DeThieuThang"].ToString() == "1" ? true : false;
                TienSuSanKhoa.Say = DataReader["Say"].ToString() == "1" ? true : false;
                TienSuSanKhoa.Hut = DataReader["Hut"].ToString() == "1" ? true : false;
                TienSuSanKhoa.Nao = DataReader["Nao"].ToString() == "1" ? true : false;
                TienSuSanKhoa.Covac = DataReader["Covac"].ToString() == "1" ? true : false;
                TienSuSanKhoa.ChuaNgoaiTC = DataReader["ChuaNgoaiTC"].ToString() == "1" ? true : false;
                TienSuSanKhoa.ChuaTrung = DataReader["ChuaTrung"].ToString() == "1" ? true : false;
                TienSuSanKhoa.ThaiChetLuu = DataReader["ThaiChetLuu"].ToString() == "1" ? true : false;
                TienSuSanKhoa.ConHienSong = DataReader["ConHienSong"].ToString() == "1" ? true : false;
                TienSuSanKhoa.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                TienSuSanKhoa.PhuongPhapDe = DataReader["PhuongPhapDe"].ToString();
                TienSuSanKhoa.TaiBien = DataReader["TaiBien"].ToString() == "1" ? true : false;

            }
            return TienSuSanKhoa;
        }

        public static bool Insert(MDB.MDBConnection MyConnection, TienSuSanKhoa TienSuSanKhoa)
        {
            string sql = @"
       INSERT INTO TienSuSanKhoa ( MaQuanLy, Nam, DeDuThang, DeThieuThang, Say, Hut, Nao, Covac, ChuaNgoaiTC, ChuaTrung, ThaiChetLuu, ConHienSong, CanNang, PhuongPhapDe, TaiBien)
 VALUES( :MaQuanLy, :Nam, :DeDuThang, :DeThieuThang, :Say, :Hut, :Nao, :Covac, :ChuaNgoaiTC, :ChuaTrung, :ThaiChetLuu, :ConHienSong, :CanNang, :PhuongPhapDe, :TaiBien)           ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", TienSuSanKhoa.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("Nam", TienSuSanKhoa.Nam));
            Command.Parameters.Add(new MDB.MDBParameter("DeDuThang", TienSuSanKhoa.DeDuThang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DeThieuThang", TienSuSanKhoa.DeThieuThang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Say", TienSuSanKhoa.Say == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hut", TienSuSanKhoa.Hut == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nao", TienSuSanKhoa.Nao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Covac", TienSuSanKhoa.Covac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaNgoaiTC", TienSuSanKhoa.ChuaNgoaiTC == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaTrung", TienSuSanKhoa.ChuaTrung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThaiChetLuu", TienSuSanKhoa.ThaiChetLuu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ConHienSong", TienSuSanKhoa.ConHienSong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CanNang", TienSuSanKhoa.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDe", TienSuSanKhoa.PhuongPhapDe));
            Command.Parameters.Add(new MDB.MDBParameter("TaiBien", TienSuSanKhoa.TaiBien == true ? "1" : "0"));


            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, TienSuSanKhoa TienSuSanKhoa)
        {
            string sql = @"UPDATE TienSuSanKhoa SET 
MaQuanLy = :MaQuanLy,
Nam = :Nam,
DeDuThang = :DeDuThang,
DeThieuThang = :DeThieuThang,
Say = :Say,
Hut = :Hut,
Nao = :Nao,
Covac = :Covac,
ChuaNgoaiTC = :ChuaNgoaiTC,
ChuaTrung = :ChuaTrung,
ThaiChetLuu = :ThaiChetLuu,
ConHienSong = :ConHienSong,
CanNang = :CanNang,
PhuongPhapDe = :PhuongPhapDe,
TaiBien = :TaiBien
                        WHERE   IDTienSuSanKhoa = :IDTienSuSanKhoa";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", TienSuSanKhoa.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("Nam", TienSuSanKhoa.Nam));
            Command.Parameters.Add(new MDB.MDBParameter("DeDuThang", TienSuSanKhoa.DeDuThang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DeThieuThang", TienSuSanKhoa.DeThieuThang == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Say", TienSuSanKhoa.Say == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Hut", TienSuSanKhoa.Hut == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Nao", TienSuSanKhoa.Nao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Covac", TienSuSanKhoa.Covac == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaNgoaiTC", TienSuSanKhoa.ChuaNgoaiTC == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaTrung", TienSuSanKhoa.ChuaTrung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThaiChetLuu", TienSuSanKhoa.ThaiChetLuu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ConHienSong", TienSuSanKhoa.ConHienSong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CanNang", TienSuSanKhoa.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDe", TienSuSanKhoa.PhuongPhapDe));
            Command.Parameters.Add(new MDB.MDBParameter("TaiBien", TienSuSanKhoa.TaiBien == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("IDTienSuSanKhoa", TienSuSanKhoa.IDTienSuSanKhoa));
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool DeleteTienSuSanKhoa(MDB.MDBConnection MyConnection, TienSuSanKhoa TienSuSanKhoa)
        {
            string sql = @"DELETE FROM TienSuSanKhoa 
                           WHERE IDTienSuSanKhoa = :IDTienSuSanKhoa";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDTienSuSanKhoa", TienSuSanKhoa.IDTienSuSanKhoa));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
