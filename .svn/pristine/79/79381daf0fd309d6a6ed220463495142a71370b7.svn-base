using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Filtering.Templates;
using EMR.KyDienTu;
using EMR_MAIN.ChucNangKhac;
using MDB;
using Newtonsoft.Json;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKhamVaDieuTriPHCNHoHap : ThongTinKy
    {
        public PhieuKhamVaDieuTriPHCNHoHap()
        {
            TableName = "PhieuKhamVaDieuTriPHCNHoHap";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKVDTPHCNHH;
            TenMauPhieu = DanhMucPhieu.PKVDTPHCNHH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string TheTrangHienTai { get; set; }
        public string TuVan { get; set; }
        [MoTaDuLieu("Nhịp tim")]
		public string NhipTim { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        public string SPO2 { get; set; }
        public int TTHutThuoc { get; set; }
        public string TTHutThuoc_SoBaoNam { get; set; }
        public string TTHutThuoc_DaCai_SoBaoNam { get; set; }
        public DateTime NgayCaiThuocLa { get; set; }
        public string SVC { get; set; }
        public string FVC { get; set; }
        public string FEV1 { get; set; }
        public string FEV1_FVC { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanCNHH { get; set; }
        public string ChiDinhDieuTri { get; set; }

        public string[] CDDT_1 { get; set; } = new string[4];

        public string[] CDDT_2 { get; set; } = new string[4];

        public string[] CDDT_3 { get; set; } = new string[4];

        public string[] CDDT_4 { get; set; } = new string[4];

        public string MaNVBacSyDieuTri { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }

        public string[] TenKiThuatPHCN { get; set; } = new string[18];

        public ObservableCollection<TheoDoiChamSoc> TheoDoiChamSocs { get; set; }
        public string GiaSauPHCN { get; set; }

        public string KQTD_NhipTim { get; set; }
        public string KQTD_NhipTho { get; set; }
        public string KQTD_HuyetAp { get; set; }
        public string KQTD_SPO2 { get; set; }

        public string KQ_SVC { get; set; }
        public string KQ_FVC { get; set; }
        public string KQ_FEV1 { get; set; }
        public string KQ_FEV1_FVC { get; set; }
        public string TrieuTrungLS_1 { get; set; }
        public string TrieuTrungLS_2 { get; set; }
        public int KetQuaDieuTri { get; set; }
        public string GhiNhanKhac { get; set; }
        public string MaNVBacSy { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }

        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class TheoDoiChamSoc {
        public int TT { get; set; }
        [MoTaDuLieu("Ngày tháng")]
		public DateTime NgayThang { get; set; }
        [MoTaDuLieu("Thực hiện y lệnh")]
		public string ThucHienYLenh { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongKyTen { get; set; }
        public string BenhNhanKyTen { get; set; }
    }
    public class PhieuKhamVaDieuTriPHCNHoHapFunc
    {
        public const string TableName = "PhieuKhamVaDieuTriPHCNHoHap";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuKhamVaDieuTriPHCNHoHap> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhamVaDieuTriPHCNHoHap> list = new List<PhieuKhamVaDieuTriPHCNHoHap>();
            try
            {

                string sql = @"SELECT * FROM PhieuKhamVaDieuTriPHCNHoHap where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PhieuKhamVaDieuTriPHCNHoHap data = new PhieuKhamVaDieuTriPHCNHoHap();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                        data.MaBenhNhan = DataReader.GetString("MaQuanLy");
                        data.TenBenhNhan = DataReader.GetString("TenBenhNhan"); 
                        data.Tuoi = DataReader.GetString("Tuoi");
                        data.GioiTinh = DataReader.GetString("GioiTinh");
                        data.DiaChi = DataReader.GetString("DiaChi");
                        data.NgayVaoVien = ConDB_DateTime(DataReader["NgayVaoVien"]);
                        data.ChanDoan = DataReader.GetString("ChanDoan");
                        data.TheTrangHienTai = DataReader.GetString("TheTrangHienTai");

                        data.NhipTim = DataReader.GetString("NhipTim");
                        data.NhipTho = DataReader.GetString("NhipTho");
                        data.HuyetAp = DataReader.GetString("HuyetAp");
                        data.SPO2 = DataReader.GetString("SPO2");
                        data.TTHutThuoc = DataReader.GetInt("TTHutThuoc");
                        data.TTHutThuoc_SoBaoNam = DataReader.GetString("TTHutThuoc_SoBaoNam");
                        data.TTHutThuoc_DaCai_SoBaoNam = DataReader.GetString("TTHutThuoc_DaCai_SoBaoNam");
                        data.NgayCaiThuocLa = ConDB_DateTime(DataReader["NgayCaiThuocLa"]);
                        data.SVC = DataReader.GetString("SVC");
                        data.FVC = DataReader.GetString("FVC");
                        data.FEV1 = DataReader.GetString("FEV1");
                        data.FEV1_FVC = DataReader.GetString("FEV1_FVC");
                        data.ChanDoanCNHH = DataReader.GetString("ChanDoanCNHH");
                        data.ChiDinhDieuTri = DataReader.GetString("ChiDinhDieuTri");
                        data.CDDT_1 = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("CDDT_1"));
                        data.CDDT_2 = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("CDDT_2"));
                        data.CDDT_3 = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("CDDT_3"));
                        data.CDDT_4 = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("CDDT_4"));
                        data.TuVan = DataReader.GetString("TuVan");
                        data.MaNVBacSyDieuTri = DataReader.GetString("MaNVBacSyDieuTri");
                        data.BacSyDieuTri = DataReader.GetString("BacSyDieuTri");
                        data.TenKiThuatPHCN = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("TenKiThuatPHCN")); 
                        data.TheoDoiChamSocs = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiChamSoc>>(DataReader.GetString("TheoDoiChamSoc"));
                        data.GiaSauPHCN = DataReader.GetString("GiaSauPHCN");
                        data.KQTD_HuyetAp = DataReader.GetString("KQTD_HuyetAp");
                        data.KQTD_NhipTho = DataReader.GetString("KQTD_NhipTho");
                        data.KQTD_NhipTim = DataReader.GetString("KQTD_NhipTim");
                        data.KQTD_SPO2 = DataReader.GetString("KQTD_SPO2");
                        data.KQ_SVC = DataReader.GetString("KQ_SVC");
                        data.KQ_FVC = DataReader.GetString("KQ_FVC");
                        data.KQ_FEV1 = DataReader.GetString("KQ_FEV1");
                        data.KQ_FEV1_FVC = DataReader.GetString("KQ_FEV1_FVC");
                        data.TrieuTrungLS_1 = DataReader.GetString("TrieuTrungLS_1");
                        data.TrieuTrungLS_2 = DataReader.GetString("TrieuTrungLS_2");
                        data.MaNVBacSy = DataReader.GetString("MaNVBacSy");
                        data.BacSy = DataReader.GetString("BacSy");
                        data.KetQuaDieuTri = DataReader.GetInt("KetQuaDieuTri");
                        data.GhiNhanKhac = DataReader.GetString("GhiNhanKhac");
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");

                        list.Add(data);
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKhamVaDieuTriPHCNHoHap objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO PhieuKhamVaDieuTriPHCNHoHap (
                                    maquanly ,
                                    mabenhnhan ,
                                    tenbenhnhan ,
                                    tuoi ,
                                    gioitinh ,
                                    diachi ,
                                    ngayvaovien ,
                                    chandoan ,
                                    thetranghientai ,
                                    nhiptim ,
                                    nhiptho ,
                                    huyetap ,
                                    spo2 ,
                                    tthutthuoc ,
                                    tthutthuoc_sobaonam ,
                                    tthutthuoc_dacai_sobaonam ,
                                    ngaycaithuocla ,
                                    svc ,
                                    fvc ,
                                    fev1 ,
                                    fev1_fvc ,
                                    chandoancnhh ,
                                    chidinhdieutri ,
                                    cddt_1 ,
                                    cddt_2 ,
                                    cddt_3 ,
                                    cddt_4 ,
                                    tuvan ,
                                    manvbacsydieutri ,
                                    bacsydieutri ,
                                    tenkithuatphcn ,
                                    theodoichamsoc ,
                                    giasauphcn ,
                                    kqtd_nhiptim ,
                                    kqtd_nhiptho ,
                                    kqtd_huyetap ,
                                    kqtd_spo2 ,
                                    kq_svc ,
                                    kq_fvc ,
                                    kq_fev1 ,
                                    kq_fev1_fvc ,
                                    trieutrungls_1 ,
                                    trieutrungls_2 ,
                                    manvbacsy ,
                                    bacsy ,
                                    ketquadieutri ,
                                    ghinhankhac ,
                                    nguoitao,
                                    ngaytao
                                ) VALUES (
                                    :maquanly,
                                    :mabenhnhan,
                                    :tenbenhnhan,
                                    :tuoi,
                                    :gioitinh,
                                    :diachi,
                                    :ngayvaovien,
                                    :chandoan,
                                    :thetranghientai,
                                    :nhiptim,
                                    :nhiptho,
                                    :huyetap,
                                    :spo2,
                                    :tthutthuoc,
                                    :tthutthuoc_sobaonam,
                                    :tthutthuoc_dacai_sobaonam,
                                    :ngaycaithuocla,
                                    :svc,
                                    :fvc,
                                    :fev1,
                                    :fev1_fvc,
                                    :chandoancnhh,
                                    :chidinhdieutri,
                                    :cddt_1,
                                    :cddt_2,
                                    :cddt_3,
                                    :cddt_4,
                                    :tuvan,
                                    :manvbacsydieutri,
                                    :bacsydieutri,
                                    :tenkithuatphcn,
                                    :theodoichamsoc,
                                    :giasauphcn,
                                    :kqtd_nhiptim,
                                    :kqtd_nhiptho,
                                    :kqtd_huyetap,
                                    :kqtd_spo2,
                                    :kq_svc,
                                    :kq_fvc,
                                    :kq_fev1,
                                    :kq_fev1_fvc,
                                    :trieutrungls_1,
                                    :trieutrungls_2,
                                    :manvbacsy,
                                    :bacsy,
                                    :ketquadieutri ,
                                    :ghinhankhac ,
                                    :nguoitao,
                                    :ngaytao
                                ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("diachi", objData.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("ngayvaovien", objData.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("chandoan", objData.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("thetranghientai", objData.TheTrangHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("nhiptim", objData.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("nhiptho", objData.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("huyetap", objData.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("spo2", objData.SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("tthutthuoc", objData.TTHutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("tthutthuoc_sobaonam", objData.TTHutThuoc_SoBaoNam));
                Command.Parameters.Add(new MDB.MDBParameter("tthutthuoc_dacai_sobaonam", objData.TTHutThuoc_DaCai_SoBaoNam));
                Command.Parameters.Add(new MDB.MDBParameter("ngaycaithuocla", objData.NgayCaiThuocLa));
                Command.Parameters.Add(new MDB.MDBParameter("svc", objData.SVC));
                Command.Parameters.Add(new MDB.MDBParameter("fvc", objData.FVC));
                Command.Parameters.Add(new MDB.MDBParameter("fev1", objData.FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("fev1_fvc", objData.FEV1_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("chandoancnhh", objData.ChanDoanCNHH));
                Command.Parameters.Add(new MDB.MDBParameter("chidinhdieutri", objData.ChiDinhDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("cddt_1", JsonConvert.SerializeObject(objData.CDDT_1)));
                Command.Parameters.Add(new MDB.MDBParameter("cddt_2", JsonConvert.SerializeObject(objData.CDDT_2)));
                Command.Parameters.Add(new MDB.MDBParameter("cddt_3", JsonConvert.SerializeObject(objData.CDDT_3)));
                Command.Parameters.Add(new MDB.MDBParameter("cddt_4", JsonConvert.SerializeObject(objData.CDDT_4)));
                Command.Parameters.Add(new MDB.MDBParameter("tuvan", objData.TuVan));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsydieutri", objData.MaNVBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("bacsydieutri", objData.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("tenkithuatphcn", JsonConvert.SerializeObject(objData.TenKiThuatPHCN)));
                Command.Parameters.Add(new MDB.MDBParameter("theodoichamsoc", JsonConvert.SerializeObject(objData.TheoDoiChamSocs)));
                Command.Parameters.Add(new MDB.MDBParameter("giasauphcn", objData.GiaSauPHCN));
                Command.Parameters.Add(new MDB.MDBParameter("kqtd_nhiptim", objData.KQTD_NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("kqtd_nhiptho", objData.KQTD_NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("kqtd_huyetap", objData.KQTD_HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("kqtd_spo2", objData.KQTD_SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("kq_svc", objData.KQ_SVC));
                Command.Parameters.Add(new MDB.MDBParameter("kq_fvc", objData.KQ_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("kq_fev1", objData.KQ_FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("kq_fev1_fvc", objData.KQ_FEV1_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("trieutrungls_1", objData.TrieuTrungLS_1));
                Command.Parameters.Add(new MDB.MDBParameter("trieutrungls_2", objData.TrieuTrungLS_2));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsy", objData.MaNVBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("bacsy", objData.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("ketquadieutri", objData.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ghinhankhac", objData.GhiNhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                Command.Parameters.Add(new MDB.MDBParameter("nguoitao", objData.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytao", objData.NgayTao));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

                if (n > 0)
                {
                    if (objData.ID == 0)
                    {
                        long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                        objData.ID = nextval;
                    }
                }
            }

            else
            {
                sql = @"UPDATE PhieuKhamVaDieuTriPHCNHoHap SET  
                                        maquanly=:maquanly,
                                        mabenhnhan=:mabenhnhan,
                                        tenbenhnhan=:tenbenhnhan,
                                        tuoi=:tuoi,
                                        gioitinh=:gioitinh,
                                        diachi=:diachi,
                                        ngayvaovien=:ngayvaovien,
                                        chandoan=:chandoan,
                                        thetranghientai=:thetranghientai,
                                        nhiptim=:nhiptim,
                                        nhiptho=:nhiptho,
                                        huyetap=:huyetap,
                                        spo2=:spo2,
                                        tthutthuoc=:tthutthuoc,
                                        tthutthuoc_sobaonam=:tthutthuoc_sobaonam,
                                        tthutthuoc_dacai_sobaonam=:tthutthuoc_dacai_sobaonam,
                                        ngaycaithuocla=:ngaycaithuocla,
                                        svc=:svc,
                                        fvc=:fvc,
                                        fev1=:fev1,
                                        fev1_fvc=:fev1_fvc,
                                        chandoancnhh=:chandoancnhh,
                                        chidinhdieutri=:chidinhdieutri,
                                        cddt_1=:cddt_1,
                                        cddt_2=:cddt_2,
                                        cddt_3=:cddt_3,
                                        cddt_4=:cddt_4,
                                        tuvan=:tuvan,
                                        manvbacsydieutri=:manvbacsydieutri,
                                        bacsydieutri=:bacsydieutri,
                                        tenkithuatphcn=:tenkithuatphcn,
                                        theodoichamsoc=:theodoichamsoc,
                                        giasauphcn=:giasauphcn,
                                        kqtd_nhiptim=:kqtd_nhiptim,
                                        kqtd_nhiptho=:kqtd_nhiptho,
                                        kqtd_huyetap=:kqtd_huyetap,
                                        kqtd_spo2=:kqtd_spo2,
                                        kq_svc=:kq_svc,
                                        kq_fvc=:kq_fvc,
                                        kq_fev1=:kq_fev1,
                                        kq_fev1_fvc=:kq_fev1_fvc,
                                        trieutrungls_1=:trieutrungls_1,
                                        trieutrungls_2=:trieutrungls_2,
                                        manvbacsy=:manvbacsy,
                                        bacsy=:bacsy,
                                        ketquadieutri=:ketquadieutri,
                                        ghinhankhac=:ghinhankhac,
                                         nguoisua = :nguoisua,
                                         ngaysua = :ngaysua 
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("diachi", objData.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("ngayvaovien", objData.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("chandoan", objData.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("thetranghientai", objData.TheTrangHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("nhiptim", objData.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("nhiptho", objData.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("huyetap", objData.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("spo2", objData.SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("tthutthuoc", objData.TTHutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("tthutthuoc_sobaonam", objData.TTHutThuoc_SoBaoNam));
                Command.Parameters.Add(new MDB.MDBParameter("tthutthuoc_dacai_sobaonam", objData.TTHutThuoc_DaCai_SoBaoNam));
                Command.Parameters.Add(new MDB.MDBParameter("ngaycaithuocla", objData.NgayCaiThuocLa));
                Command.Parameters.Add(new MDB.MDBParameter("svc", objData.SVC));
                Command.Parameters.Add(new MDB.MDBParameter("fvc", objData.FVC));
                Command.Parameters.Add(new MDB.MDBParameter("fev1", objData.FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("fev1_fvc", objData.FEV1_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("chandoancnhh", objData.ChanDoanCNHH));
                Command.Parameters.Add(new MDB.MDBParameter("chidinhdieutri", objData.ChiDinhDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("cddt_1", JsonConvert.SerializeObject(objData.CDDT_1)));
                Command.Parameters.Add(new MDB.MDBParameter("cddt_2", JsonConvert.SerializeObject(objData.CDDT_2)));
                Command.Parameters.Add(new MDB.MDBParameter("cddt_3", JsonConvert.SerializeObject(objData.CDDT_3)));
                Command.Parameters.Add(new MDB.MDBParameter("cddt_4", JsonConvert.SerializeObject(objData.CDDT_4)));
                Command.Parameters.Add(new MDB.MDBParameter("tuvan", objData.TuVan));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsydieutri", objData.MaNVBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("bacsydieutri", objData.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("tenkithuatphcn", JsonConvert.SerializeObject(objData.TenKiThuatPHCN)));
                Command.Parameters.Add(new MDB.MDBParameter("theodoichamsoc", JsonConvert.SerializeObject(objData.TheoDoiChamSocs)));
                Command.Parameters.Add(new MDB.MDBParameter("giasauphcn", objData.GiaSauPHCN));
                Command.Parameters.Add(new MDB.MDBParameter("kqtd_nhiptim", objData.KQTD_NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("kqtd_nhiptho", objData.KQTD_NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("kqtd_huyetap", objData.KQTD_HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("kqtd_spo2", objData.KQTD_SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("kq_svc", objData.KQ_SVC));
                Command.Parameters.Add(new MDB.MDBParameter("kq_fvc", objData.KQ_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("kq_fev1", objData.KQ_FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("kq_fev1_fvc", objData.KQ_FEV1_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("trieutrungls_1", objData.TrieuTrungLS_1));
                Command.Parameters.Add(new MDB.MDBParameter("trieutrungls_2", objData.TrieuTrungLS_2));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsy", objData.MaNVBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("bacsy", objData.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("ketquadieutri", objData.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ghinhankhac", objData.GhiNhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("nguoisua", objData.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ngaysua", objData.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }


            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM PhieuKhamVaDieuTriPHCNHoHap WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static PhieuKhamVaDieuTriPHCNHoHap GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM PhieuKhamVaDieuTriPHCNHoHap where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PhieuKhamVaDieuTriPHCNHoHap data = new PhieuKhamVaDieuTriPHCNHoHap();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                        data.MaBenhNhan = DataReader.GetString("MaQuanLy");
                        data.TenBenhNhan = DataReader.GetString("TenBenhNhan");
                        data.Tuoi = DataReader.GetString("Tuoi");
                        data.GioiTinh = DataReader.GetString("GioiTinh");
                        data.DiaChi = DataReader.GetString("DiaChi");
                        data.NgayVaoVien = ConDB_DateTime(DataReader["NgayVaoVien"]);
                        data.ChanDoan = DataReader.GetString("ChanDoan");
                        data.TheTrangHienTai = DataReader.GetString("TheTrangHienTai");

                        data.NhipTim = DataReader.GetString("NhipTim");
                        data.NhipTho = DataReader.GetString("NhipTho");
                        data.HuyetAp = DataReader.GetString("HuyetAp");
                        data.SPO2 = DataReader.GetString("SPO2");
                        data.TTHutThuoc = DataReader.GetInt("TTHutThuoc");
                        data.TTHutThuoc_SoBaoNam = DataReader.GetString("TTHutThuoc_SoBaoNam");
                        data.TTHutThuoc_DaCai_SoBaoNam = DataReader.GetString("TTHutThuoc_DaCai_SoBaoNam");
                        data.NgayCaiThuocLa = ConDB_DateTime(DataReader["NgayCaiThuocLa"]);
                        data.SVC = DataReader.GetString("SVC");
                        data.FVC = DataReader.GetString("FVC");
                        data.FEV1 = DataReader.GetString("FEV1");
                        data.FEV1_FVC = DataReader.GetString("FEV1_FVC");
                        data.ChanDoanCNHH = DataReader.GetString("ChanDoanCNHH");
                        data.ChiDinhDieuTri = DataReader.GetString("ChiDinhDieuTri");
                        data.CDDT_1 = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("CDDT_1"));
                        data.CDDT_2 = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("CDDT_2"));
                        data.CDDT_3 = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("CDDT_3"));
                        data.CDDT_4 = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("CDDT_4"));
                        data.TuVan = DataReader.GetString("TuVan");
                        data.MaNVBacSyDieuTri = DataReader.GetString("MaNVBacSyDieuTri");
                        data.BacSyDieuTri = DataReader.GetString("BacSyDieuTri");
                        data.TenKiThuatPHCN = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("TenKiThuatPHCN"));
                        data.TheoDoiChamSocs = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiChamSoc>>(DataReader.GetString("TheoDoiChamSoc"));
                        data.GiaSauPHCN = DataReader.GetString("GiaSauPHCN");
                        data.KQTD_HuyetAp = DataReader.GetString("KQTD_HuyetAp");
                        data.KQTD_NhipTho = DataReader.GetString("KQTD_NhipTho");
                        data.KQTD_NhipTim = DataReader.GetString("KQTD_NhipTim");
                        data.KQTD_SPO2 = DataReader.GetString("KQTD_SPO2");
                        data.KQ_SVC = DataReader.GetString("KQ_SVC");
                        data.KQ_FVC = DataReader.GetString("KQ_FVC");
                        data.KQ_FEV1 = DataReader.GetString("KQ_FEV1");
                        data.KQ_FEV1_FVC = DataReader.GetString("KQ_FEV1_FVC");
                        data.TrieuTrungLS_1 = DataReader.GetString("TrieuTrungLS_1");
                        data.TrieuTrungLS_2 = DataReader.GetString("TrieuTrungLS_2");
                        data.MaNVBacSy = DataReader.GetString("MaNVBacSy");
                        data.BacSy = DataReader.GetString("BacSy");
                        data.KetQuaDieuTri = DataReader.GetInt("KetQuaDieuTri");
                        data.GhiNhanKhac = DataReader.GetString("GhiNhanKhac");
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");

                        return data;
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return null;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql2 = @"SELECT
                D.*,
	            T.MABENHNHAN,
	            T.KHOA,
	            T.GIUONG,
                T.BUONG,
	            T.NGAYVAOVIEN,
	            H.SOYTE,
	            H.BENHVIEN,
	            H.MABENHNHAN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH
            FROM
                PhieuKhamVaDieuTriPHCNHoHap D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds,"BK");
            string jsonTheoDoiChamSoc = ds.Tables[0].Rows[0]["TheoDoiChamSoc"].ToString();
            ObservableCollection<TheoDoiChamSoc> lstTheoDoiChamDoc = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiChamSoc>>(jsonTheoDoiChamSoc);

            DataTable tbTDCS = new DataTable("TD");
            tbTDCS.Columns.Add("TT", typeof(string));
            tbTDCS.Columns.Add("NgayThang", typeof(string));
            tbTDCS.Columns.Add("ThucHienYLenh", typeof(string));
            tbTDCS.Columns.Add("DieuDuongKyTen", typeof(string));
            tbTDCS.Columns.Add("BenhNhanKyTen", typeof(string));
            if(lstTheoDoiChamDoc != null)
                foreach(TheoDoiChamSoc tdcs in lstTheoDoiChamDoc)
                {
                        tbTDCS.Rows.Add
                        (
                            tdcs.TT.ToString(),
                            tdcs.NgayThang.ToString("dd/MM/yyyy"),
                            tdcs.ThucHienYLenh,
                            tdcs.DieuDuongKyTen,
                            tdcs.BenhNhanKyTen
                        );
                }
            ds.Tables.Add(tbTDCS);

            string[] CDDT_1 = JsonConvert.DeserializeObject<string[]>(ds.Tables[0].Rows[0]["CDDT_1"].ToString());
            string[] CDDT_2 = JsonConvert.DeserializeObject<string[]>(ds.Tables[0].Rows[0]["CDDT_2"].ToString());
            string[] CDDT_3 = JsonConvert.DeserializeObject<string[]>(ds.Tables[0].Rows[0]["CDDT_3"].ToString());
            string[] CDDT_4 = JsonConvert.DeserializeObject<string[]>(ds.Tables[0].Rows[0]["CDDT_4"].ToString());

            DataTable cddt1 = new DataTable("cddt_1");
            cddt1.Columns.Add("TS1", typeof(string));
            cddt1.Columns.Add("TS2", typeof(string));
            cddt1.Columns.Add("TS3", typeof(string));
            cddt1.Columns.Add("TS4", typeof(string));
            cddt1.Rows.Add(CDDT_1[0], CDDT_1[1], CDDT_1[2], CDDT_1[3]);

            DataTable cddt2 = new DataTable("cddt_2");
            cddt2.Columns.Add("TS1", typeof(string));
            cddt2.Columns.Add("TS2", typeof(string));
            cddt2.Columns.Add("TS3", typeof(string));
            cddt2.Columns.Add("TS4", typeof(string));
            cddt2.Rows.Add(CDDT_2[0], CDDT_2[1], CDDT_2[2], CDDT_2[3]);

            DataTable cddt3 = new DataTable("cddt_3");
            cddt3.Columns.Add("TS1", typeof(string));
            cddt3.Columns.Add("TS2", typeof(string));
            cddt3.Columns.Add("TS3", typeof(string));
            cddt3.Columns.Add("TS4", typeof(string));
            cddt3.Rows.Add(CDDT_3[0], CDDT_3[1], CDDT_3[2], CDDT_3[3]);

            DataTable cddt4 = new DataTable("cddt_4");
            cddt4.Columns.Add("TS1", typeof(string));
            cddt4.Columns.Add("TS2", typeof(string));
            cddt4.Columns.Add("TS3", typeof(string));
            cddt4.Columns.Add("TS4", typeof(string));
            cddt4.Rows.Add(CDDT_4[0], CDDT_4[1], CDDT_4[2], CDDT_4[3]);

            ds.Tables.Add(cddt1);
            ds.Tables.Add(cddt2);
            ds.Tables.Add(cddt3);
            ds.Tables.Add(cddt4);

            DataTable KT_PHCN = new DataTable("KT");
            string[] TenKiThuatPHCN = JsonConvert.DeserializeObject<string[]>(ds.Tables[0].Rows[0]["TenKiThuatPHCN"].ToString());
            for(int i = 1;i < TenKiThuatPHCN.Length + 1; i++)
            {
                KT_PHCN.Columns.Add("R" + i, typeof(string));
            }
            DataRow row = KT_PHCN.NewRow();
            for (int i = 0; i < TenKiThuatPHCN.Length; i++)
            {
                row[i] = TenKiThuatPHCN[i];
            }
            KT_PHCN.Rows.Add(row);
            ds.Tables.Add(KT_PHCN);
            return ds;
        }
    }
}
