using PMS.Access;
using System.Collections.ObjectModel;

namespace EMR_MAIN.DATABASE.BenhAn
{
    public class BenhAnTruyenNhiemII : BenhAnTruyenNhiem
    {
        public BenhAnTruyenNhiemII()
        {
            IDMauPhieu = (int)DanhMucPhieu.BATNhiemII;
            TenMauPhieu= DanhMucPhieu.BATNhiemII.Description();
        }
        public ObservableCollection<TienSuDiUng> TienSuDiUngs { get; set; }
    }
    public class TienSuDiUng
    {
        public int STT { get; set; }
        public string NoiDung { get; set; }
        public string TenThuoc { get; set; }
        public string SoLan { get; set; }
        public bool Khong { get; set; }
        public string BieuHienLamSang { get; set; }
        public static ObservableCollection<TienSuDiUng> CreateData()
        {
            ObservableCollection<TienSuDiUng> listDefault = new ObservableCollection<TienSuDiUng>();
            TienSuDiUng stt1 = new TienSuDiUng { STT = 1, NoiDung= "Loại thuốc hoặc dị nguyên nào đã gây dị ứng?"};
            listDefault.Add(stt1);
            TienSuDiUng stt2 = new TienSuDiUng { STT = 2, NoiDung = "Dị ứng với loại côn trùng nào?" };
            listDefault.Add(stt2);
            TienSuDiUng stt3 = new TienSuDiUng { STT = 3, NoiDung = "Dị ứng với loại thực phẩm nào?" };
            listDefault.Add(stt3);
            TienSuDiUng stt4 = new TienSuDiUng { STT = 4, NoiDung = "Dị ứng với các tác nhân khác: phấn hoa, bụi nhà, hóa chất, mỹ phẩm...?" };
            listDefault.Add(stt4);
            TienSuDiUng stt5 = new TienSuDiUng { STT = 5, NoiDung = "Tiền sử cá nhân có bệnh dị ứng nào? (viêm mũi dị ứng, hen phế quản...)" };
            listDefault.Add(stt5);
            TienSuDiUng stt6 = new TienSuDiUng { STT = 6, NoiDung = "Tiền sử gia đình có bệnh dị ứng nào? (Bố mẹ, con, a/c em ruột, có ai bị các bệnh dị ứng trên không)." };
            listDefault.Add(stt6);

            return listDefault;
        }    
    }
}
