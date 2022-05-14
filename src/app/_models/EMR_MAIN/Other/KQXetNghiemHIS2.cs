using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDB;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
   public static class KQXetNghiemHIS2
    {
        public static List<KetQuaXetNghiemModel> GetKQXetNghiemHIS2(decimal d_MaQuanLy, MDB.MDBConnection _OracleConnection, DateTime? DTNew = null)
        {
            //10/06/2021 Add by Hòa Issues 64961
            //Add để thực hiện lọc theo ngày tháng để lấy dữ liệu nhỏ hơn hoặc bằng ngày chọn, nếu không thì lấy ngày giờ hiện tại
            if (DTNew == null)
            {
                DTNew = DateTime.Now;
            }
            // conver từ nclod sang chuỗi
            DevExpress.XtraRichEdit.RichEditControl txtFormat = new DevExpress.XtraRichEdit.RichEditControl();
            txtFormat.Location = new System.Drawing.Point(484, 131);
            txtFormat.Name = "txtFormat";
            txtFormat.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            txtFormat.Options.MailMerge.KeepLastParagraph = false;
            txtFormat.Size = new System.Drawing.Size(283, 59);
            txtFormat.TabIndex = 51;
            txtFormat.Text = "richEditControl1";
            string ConvertRTFText(string s_NoiDung)
            {
                if (s_NoiDung != "")
                {
                    txtFormat.RtfText = s_NoiDung;
                    txtFormat.Update();
                    Application.DoEvents();
                    return txtFormat.Text;
                }
                return "";
            }
            //10/06/2021 End by Hòa Issues 64961
            List<KetQuaXetNghiemModel> lstData = new List<KetQuaXetNghiemModel>();

            try
            {
                DataTable dtKetQuaXetNghiem = new DataTable();
                string s_MMYY = ThuVien.MMYY(d_MaQuanLy, 300);
                string s_SQL = "";
                //s_SQL += "select cast(0 as decimal) as chon,a.idketqua,a.sophieu,a.ngay as ngayketqua,a.ngaylaymau," +
                //    "b.idxetnghiem,l.maxetnghiem,l.tenxetnghiem,b.ketqua,l.donvi," +
                //    " l.binhthuongnu,l.binhthuongnam,b.ghichu,k.idgiavienphi,vp.tengiavienphi, m.tensoxetnghiem";
                //s_SQL += ",a.mmyy,a.maql,a.idkhoa,d.tenkhoaphong,e.tennhanvien as tenbschidinh," +
                //    "a.loaibn,a.tinhtrang,a.maicd,a.chandoan,f.tendoituong,e1.tennhanvien as tenktv," +
                //    "a.ngayra,e2.tennhanvien as tenbsdoc,a.ghichu,a.nhanxet,a.ketluan,a.denghi,a.mabenhpham,a.stt,a.lanin," +
                //    "a.ngaylaymau,a.dalaymau,a.traketqua,a.id_khu,a.mainkey,e3.tennhanvien as tennguoilaymau," +
                //    "a.iddotchidinh,b.idchidinh,b.idxuatnoivien," +
                //    "b.ketqua,b.ketqua_ori,b.ghichu,b.done,b.id_may," +
                //    "b.ketqua_hople,b.chaylai,b.lydochaylai,b.ketquachaylai, vp.khangsinhdo ";

                s_SQL += "select a.maql as MaBenhAn, a.idketqua as MaPhieu, a.sophieu as BarCode," +
                    " e.tennhanvien as TenBacSiChiDinh, a.mabschidinh as MaBacSiChiDinh, e2.tennhanvien as TenBacSiTraKQ," +
                    " a.mabsdoc as MaBacSiTraKQ, e3.tennhanvien as TenBacSiLayMau, a.nguoilaymau as MaBacSiLayMau," +
                    " to_char(a.ngaylaymau,'dd/mm/yyyy hh24:mi:ss') as ThoiGianLayMau," +
                    " to_char(a.ngay,'dd/mm/yyyy hh24:mi:ss') as ThoiGianKetThuc," +
                    " d.tenkhoaphong as KhoaPhongChiDinh, a.chandoan as ChanDoanChiDinh, a.maicd as ChanDoanChiDinh_Code," +
                    " 3 as TrangThai, vp.tengiavienphi as TenDich, vp.mavp as MaDichVu, l.tenxetnghiem as TenDichVu," +
                    " b.ketqua as KetQua, b.ghichu as GhiChuKq" +
                    " , h.tenloaixetnghiem loaidichvu" + //03/06/2021 Add by Hòa Issues 64983
                    ", b.idxetnghiem, '' mota, 0 idloaixetnghiem"; //08/06/2021 Add by Hòa Issues 64961
                s_SQL += " from l_ketqua a" +
                    " inner join l_ketquachitiet b on a.idketqua=b.idketqua" +
                    " inner join l_dmvienphi k on b.idvienphi=k.idvienphi" +
                    " inner join l_dmxetnghiem l on b.idxetnghiem=l.idxetnghiem" +
                    " inner join l_dmsoxetnghiem m on k.idsoxetnghiem=m.idsoxetnghiem" +
                    " inner join b_dmgiavienphi vp on k.idgiavienphi=vp.idgiavienphi";
                s_SQL += " inner join p_dmkhoaphongbenhvien d on a.idkhoaphong=d.idkhoaphong" +
                    " left join p_dmnhanvien e on a.mabschidinh=e.manhanvien " +
                   " inner join p_dmdoituong f on a.madoituong=f.madoituong" +
                   " left join p_dmnhanvien e1 on a.maktv=e1.manhanvien " +
                   " left join p_dmnhanvien e2 on a.mabsdoc=e2.manhanvien" +
                   " left join p_dmnhanvien e3 on a.nguoilaymau=e3.manhanvien " +
                   " left join r_dmmay r on b.mayxetnghiem = r.mamay and nvl(r.mamay,'') <> '' " +
                   " inner join l_dmloaixetnghiem h on l.idloaixetnghiem=h.idloaixetnghiem"; //03/06/2021 Add by Hòa Issues 64983
                s_SQL += " where a.maql=" + d_MaQuanLy;
                s_SQL += " and b.ketqua is not null and length(trim(b.ketqua)) >0";
                s_SQL += " and " + ThuVien.ReplaceMMYYNew("a.mmyy", s_MMYY) + " and " + ThuVien.ReplaceMMYYNew("b.mmyy", s_MMYY);
                //11/06/2021 Add by Hòa Issues 64961
                s_SQL += " and to_char(a.ngay, 'ddmmyyyyhh24miss') <= to_char(TO_DATE('" + String.Format("{0:dd/MM/yyyy HHmmss}", DTNew) + "' , 'dd/mm/yyyy hh24miss'), 'ddmmyyyyhh24miss')" +
                    " Order by to_char(a.ngay,'dd/mm/yyyy hh24:mi:ss') DESC";
                //11/06/2021 End by Hòa Issues 64961
                MDBDataAdapter mdbAdt = new MDBDataAdapter(s_SQL, _OracleConnection);
                mdbAdt.SelectCommand.CommandTimeout = 50000;
                DataTable dtKQ = new DataTable("KQXetNghiem");
                mdbAdt.Fill(dtKQ);
                s_SQL = "select a.maql as MaBenhAn, a.idketqua as MaPhieu, a.MACANLAMSANG as BarCode," +
                    " e2.tennhanvien as TenBacSiTraKQ," +
                    " a.MABS as MaBacSiTraKQ, e3.tennhanvien as TenBacSiLayMau, a.MABS1 as MaBacSiLayMau," +
                    " to_char(a.NGAYCHUP,'dd/mm/yyyy hh24:mi:ss') as ThoiGianLayMau," +
                    " to_char(a.ngay,'dd/mm/yyyy hh24:mi:ss') as ThoiGianKetThuc," +
                    " d.tenkhoaphong as KhoaPhongChiDinh," +
                    " 3 as TrangThai, l.tenloaicdha as TenDichVu," +
                    " ct.KETLUAN as KetQua, ct.GHICHU as GhiChuKq" +
                    " , kt.tenkythuat loaidichvu" +
                    ", l.idloaicdha idxetnghiem, TO_NCLOB(ct.mota) mota, 1 idloaixetnghiem" +
                    " from r_ketquall a " +
                    " inner join r_ketquact ct on a.idketqua = ct.idketqua" +
                    " inner join r_dmkythuat kt on ct.makt = kt.idkythuat" +
                    " inner join r_dmloaicdha l on kt.idloaicdha = l.idloaicdha" +
                    " inner join p_dmkhoaphongbenhvien d on a.IDPHONGTHUCHIEN = d.idkhoaphong" +
                    " left join p_dmnhanvien e2 on a.MABS = e2.manhanvien" +
                    " left join p_dmnhanvien e3 on a.MABS1 = e3.manhanvien " +
                    " where a.maql = " + d_MaQuanLy +
                    " and " + ThuVien.ReplaceMMYYNew("a.mmyy", s_MMYY) +
                    " and ct.KETLUAN is not null and length(trim(ct.KETLUAN)) > 0" +
                    " and to_char(a.ngay, 'ddmmyyyyhh24miss') <= to_char(TO_DATE('" + String.Format("{0:dd/MM/yyyy HHmmss}", DTNew) + "'" + ", 'dd/mm/yyyy hh24miss'), 'ddmmyyyyhh24miss')" +
                    " Order by to_char(a.ngay,'dd/mm/yyyy hh24:mi:ss') DESC";
                
                mdbAdt = new MDBDataAdapter(s_SQL, _OracleConnection);
                mdbAdt.Fill(dtKQ);
                //08/06/2021 End by Hòa Issues 64961


                if (dtKQ.IsNotNullOrEmpty())
                {
                    //03/06/2021 Add by Hòa Issues 64983
                    lstData = (from a in dtKQ.AsEnumerable()
                               select new KetQuaXetNghiemModel()
                               {
                                   NgayGio = a["ThoiGianKetThuc"].ToDateTime(),
                                   LoaiDichVu = a["loaidichvu"].ToString(),
                                   TenDichVu = a["TenDichVu"].ToString(),
                                   TenXetNghiem = null,
                                   KetQua = a["KetQua"].ToString(),
                                   GhiChuKq = a["GhiChuKq"].ToString(),
                                   IDXETNGHIEM = a["idxetnghiem"].ToInt32(), //03/06/2021 Add by Hòa Issues 64961
                                   MoTa = ConvertRTFText(a["mota"].ToString()).Replace("text^application/text^Text^", ""), //10/06/2021 Add by Hòa Issues 64961
                                   IDLoaiXetNghiem = a["idloaixetnghiem"].ToInt32(),//10/06/2021 Add by Hòa Issues 64961
                               }).ToList<KetQuaXetNghiemModel>();
                    //03/06/2021 End by Hòa Issues 64983
                    //03/06/2021 Close by Hòa Issues 64983
                    //lstData = (from a in dtKQ.AsEnumerable()
                    //           select new KetQuaXetNghiemModel()
                    //           {
                    //               TenDichVu = a["TenDichVu"].ToString(),
                    //               KetQua = a["KetQua"].ToString(),
                    //               GhiChuKq = a["GhiChuKq"].ToString(),
                    //           }).ToList<KetQuaXetNghiemModel>();
                    //03/06/2021 End by Hòa Issues 64983
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return lstData;

        }
    }
}
