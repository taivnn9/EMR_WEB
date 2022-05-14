using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EMR_MAIN.DATABASE
{
    public enum LoaiTT
    {
        XoangHam = 0,
        ThuthuatbomruaBQ = 1,
        ThuthuatDonhanap = 2,
        Thuthuatduonghohapduoi = 3,
        Thuthuathutdomdaitren = 4,
        ThuthuathutdomongNKQ =5,
        Thuthuatkhidung = 6,
        Thuthuatlamthuoctai = 7,
        Thuthuat_locmau1 = 8,
        Thuthuat_locmau2 = 9,
        Thuthuat_locmau3 = 10,
        Thuthuatproetz = 11,
        Thuthuatruadaday = 12,
        Thuthuatsondetieunam = 13,
        Thuthuatsondetieunu = 14,
        ThuthuatthaybangruavetthuongNT = 15,
        Thuthuatthokhidung_Canuyl = 16,
        Thuthuatthongdaday = 17,
        Thuthuatthonghaumon = 18,
        Thuthuatthooxygongkinh = 19,
        Thuthuatthutthaophan = 20,
        Thuthuatthutthaophanbangthuoc = 21,
        Thuthuattruyenhoachat = 22,
        ThuthuatYHCT = 23,
        ThuthuatYHCT_NU = 24,
        ThuthuatPHCN = 25,
        DatCatheterTinhMachDui = 28,
        ThoMayXamNhap = 29,
        ThoMayKhongXamNhap =30,
        Khac = 500
    }
    public class TaoPhieuThuThuat
    {
        public long ID { get; set; }
        public string MaPhieu { get; set; }
        public string TenPhieu { get; set; }
        public string Mota { get; set; }
        public string pathLocalAnh1 { get; set; } 
        public string pathLocalAnh2 { get; set; }
        public string pathAnh1 { get; set; }

        public string pathAnh2 { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public bool ShowBSSDD { get; set; }
        public bool ShowSLBSDD { get; set; }
        public TaoPhieuThuThuat()
        {

        }
        public TaoPhieuThuThuat(LoaiTT loaiTT)
        {

            switch (loaiTT)
            {
                case LoaiTT.XoangHam: //0
                    this.TenPhieu = "PHIẾU THỦ THUẬT CHỌC RỬA XOANG HÀM";
                    this.MaPhieu = "XoangHam";
                    this.Mota = "Đặt thuốc tê (Xylocain 6%) đặt vào ngách giữa và ngách dưới trong 5 phút\n- Chọc kim vào khe mũi dưới đúng kỹ thuật\n-Rút nòng trong ra, hút thử thấy không khí - Bơm rửa xoang bằng nước muối sinh lý.\n- Sau khi rửa sạch, bơm thuốc vào xoang.\n-Rút Troca và đặt bông ép trong 3 phút\n- Trong và sau thủ thuật không xảy ra tai biến gì";
                    this.pathAnh1 = "XoangHam_1.bmp";
                    this.pathAnh2 = "XoangHam_2.bmp";
                    break;
                case LoaiTT.ThuthuatbomruaBQ: //1
                    this.TenPhieu = "PHIẾU THỦ THUẬT BƠM RỬA BÀNG QUANG";
                    this.MaPhieu = "ThuthuatbomruaBQ";
                    this.Mota = "- Thông báo thủ thuật sắp tiến hành trên NB.\n - Chuẩn bị dụng cụ đầy đủ.\n - Hướng dẫn NB nằm ngửa trên giường, bộc lộ bộ phận sinh dục.\n - Đổ dung dịch rửa vào bát kền.\n - Tháo nước tiểu trong túi nước tiểu vào bô.\n - Sát khuẩn chỗ nối giữa sonde tiểu và túi đựng nước tiểu.\n - Mang găng tay, kẹp sonde tiểu.Tháo sonde tiểu ra khỏi túi đựng nước tiểu.\n - Bơm từ từ dung dịch rửa theo y lệnh vào bàng quang NB, mỗi lần bơm từ 200 - 250 ml.\n - Mở kẹp cho nước tiểu chảy ra. Quan sát đánh giá màu sắc nước tiểu. Rửa tới khi sạch hoặc theo chỉ định của bác sỹ.\n - Nối sonde tiểu với túi đựng nước tiểu.\n - Mặc quần cho NB, thu dọn dụng cụ.\n - Dặn dò những điều cần thiết.";
                    this.pathAnh1 = ""; //null
                    this.pathAnh2 = ""; //null
                    break;
                case LoaiTT.ThuthuatDonhanap: //2
                    this.TenPhieu = "PHIẾU THỦ THUẬT ĐO NHÃN ÁP";
                    this.MaPhieu = "ThuthuatDonhanap";
                    this.Mota = "Tra thuốc tê Dicain. Sát trùng và hơ quả cân trên ngọn lửa đèn cồn.Tẩm mực in vào 2 đầu quả cân cho thật đều, hơ lại quả cân lên ngọn lửa đèn cồn.\n- Hướng dẫn người bệnh đưa tay ra trước mắt, mắt nhìn thẳng vào ngón tay trỏ (Nếu đo mắt phải, người bệnh đưa tay trái ra hoặc ngược lại). Tay phải cầm tay cầm quả cân tay, trái vành hai mi chú ý không được đè tay vào nhãn cầu. Đặt quả cân thẳng góc chính giữa giác mạc, từ từ đặt quả cân đè lên giác mạc. Đưa nhẹ tay cầm xuống dưới, khi tay cầm đưa xuống quá nửa chiều cao quả cân nhấc nhanh quả cân ra khỏi mắt.Lấy bông tẩm cồn 90 độ  bôi vào giấy, in dấu nhãn áp lên giấy.\n- Dùng thước đo, ghi kết quả đo.\nTra Natriclorua 0,9% hoặc kháng sinh vào mắt vừa đo";
                    this.pathAnh1 = "ThuthuatDonhanap_1.bmp";
                    this.pathAnh2 = ""; //null
                    break;
                case LoaiTT.Thuthuatduonghohapduoi: //3
                    this.TenPhieu = "PHIẾU THỦ THUẬT HÚT ĐỜM CANUYL MỞ KHÍ QUẢN";
                    this.MaPhieu = "Thuthuatduonghohapduoi";
                    this.Mota = "Thông báo về thủ thuật sắp tiến hành\n- Chuẩn bị dụng cụ đầy đủ\n- Bật máy hút và điều chỉnh áp lực.\n- Mang găng tay vô khuẩn\n-  Nối ống hút với hệ thống máy hút.\n- Luồn ống hút vào ống canuyl MKQ đến độ sâu mong muốn.\n- Vừa xoay nhẹ vừa kéo ống hút ra ngoài, theo dõi NB khi hút đờm.\n- Nếu đờm đặc thì bơm 1-2ml dung dịch rửa qua canuyl MKQ, sau 10-15 giây  hút lại theo quy trình.\n- Mỗi lần hút không quá 15 giây, không quá 2 phút/ đợt hút. \n- Tháo bỏ găng tay và ống hút\n- Đánh giá lại toàn trạng người bệnh";
                    this.pathAnh1 = "Thuthuatduonghohapduoi_1.bmp";
                    this.pathAnh2 = "";//null
                    break;
                case LoaiTT.Thuthuathutdomdaitren: //4
                    this.TenPhieu = "PHIẾU THỦ THUẬT HÚT ĐỜM HẦU HỌNG";
                    this.MaPhieu = "Thuthuathutdomdaitren";
                    this.Mota = "- Thông báo về thủ thuật sắp tiến hành\n- Chuẩn bị dụng cụ đầy đủ\n- Bật máy hút và điều chỉnh áp lực.\n- Mang găng tay \n-  Nối ống hút với hệ thống máy hút.\n- Luồn ống hút vào qua mũi tới họng NB.\n- Vừa xoay nhẹ vừa kéo ống hút ra ngoài, theo dõi NB khi hút đờm.\n- Hút từng đợt ngắt quãng từ 10-15 giây.\n- Luồn ống hút xung quanh miệng NB, di chuyển ống hút, hút xung quanh miệng NB, động viên NB ho.\n- Tháo bỏ găng tay và ống hút.\n- Đánh giá lại toàn trạng NB. ";
                    this.pathAnh1 = "Thuthuathutdomdaitren_1.bmp";
                    this.pathAnh2 = "";//null
                    break;
                case LoaiTT.ThuthuathutdomongNKQ: //5
                    this.TenPhieu = "PHIẾU THỦ THUẬT HÚT ĐỜM ỐNG NỘI KHÍ QUẢN";
                    this.MaPhieu = "ThuthuathutdomongNKQ";
                    this.Mota = " - Thông báo về thủ thuật sắp tiến hành\n - Chuẩn bị dụng cụ đầy đủ\n - Bật máy hút và điều chỉnh áp lực.\n - Mang găng tay vô khuẩn\n -  Nối ống hút với hệ thống máy hút.\n - Luồn ống hút vào ống  NKQ đến độ sâu mong muốn.\n - Vừa xoay nhẹ vừa kéo ống hút ra  theo dõi NB khi hút đờm.\n - Nếu đờm đặc thì bơm 1-2ml dung dịch rửa qua ống NKQ, sau 10- 15 giây  hút lại theo quy trình.\n - Mỗi lần hút không quá 15 giây, không quá 2 phút/ đợt hút. \n - Tháo bỏ găng tay và ống hút\n - Đánh giá lại toàn trạng người bệnh";
                    this.pathAnh1 = "ThuthuathutdomongNKQ_1.bmp";
                    this.pathAnh2 = "";//null
                    break;
                case LoaiTT.Thuthuatkhidung: //6
                    this.TenPhieu = "PHIẾU THỦ THUẬT KHÍ DUNG";
                    this.MaPhieu = "Thuthuatkhidung";
                    this.Mota = " - Thông báo thủ thuật sắp tiến hành trên NB\n- Chuẩn bị dụng cụ, thuốc đầy đủ.\n- Kiểm tra máy khí dung hoạt động bình thường\n- Lắp hệ thống dây nối vào máy\n- Cho thuốc vào bầu đựng thuốc, nối bầu khí dung vào hệ thống dây dẫn.\n- Bật máy, quan sát thấy thuốc bay ra dưới dạng sương\n-  Áp Mask kín mũi miệng NB, hướng dẫn NB cách hít thở.\n- Theo dõi NB trong quá trình thở\n- Kết thúc thở khí dung: lau mũi miệng và cho NB xúc miệng.\n- Vệ sinh mask khí dung theo quy định";
                    this.pathAnh1 = "Thuthuatkhidung_1.bmp";
                    this.pathAnh2 = "";//null
                    break;
                case LoaiTT.Thuthuatlamthuoctai: //7
                    this.TenPhieu = "PHIẾU THỦ THUẬT LÀM THUỐC TAI";
                    this.MaPhieu = "Thuthuatlamthuoctai";
                    this.Mota = " Người bệnh ngồi quay tai về phía thầy thuốc\n- Dùng đèn clar và loa soi tai kiểm tra ống tai màng nhĩ\n- Dùng que tăm bông làm sạch mủ và tổ chức bã đậu ống tai, màng nhĩ nhiều lần\n- Dùng que tăm bông lau thuốc ống tai, màng nhĩ\n- Trong sau thủ thuật an toàn";
                    this.pathAnh1 = "Thuthuatlamthuoctai_1.bmp";
                    this.pathAnh2 = "";//null
                    break;
                case LoaiTT.Thuthuat_locmau1: //8
                    this.TenPhieu = "PHIẾU THỦ THUẬT LỌC MÁU 1";
                    this.MaPhieu = "Thuthuat_locmau1";
                    this.Mota = "Cách thức tiến hành:\n- Bệnh nhân nằm tư thế thuận lợi\n- Bộc lộ FAV\n- Thiết lập vòng tuần hoàn ngoài cơ thể\n- Theo dõi buổi lọc máu\n- Kết thúc buổi lọc máu";
                    this.pathAnh1 = "Thuthuat_locmau1_1.bmp";
                    this.pathAnh2 = "";//null
                    break;
                case LoaiTT.Thuthuat_locmau2: //9
                    this.TenPhieu = "PHIẾU THỦ THUẬT LỌC MÁU 2";
                    this.MaPhieu = "Thuthuat_locmau2";
                    this.Mota = "Cách thức tiến hành:\n- Bệnh nhân nằm tư thế thuận lợi\n- Bộc lộ catheter\n- Thiết lập vòng tuần hoàn ngoài cơ thể\n- Theo dõi buổi lọc máu\n- Kết thúc buổi lọc máu\n- Bảo quản catheter";
                    this.pathAnh1 = "Thuthuat_locmau2_1.bmp";
                    this.pathAnh2 = "";//null
                    break;
                case LoaiTT.Thuthuat_locmau3: //10
                    this.TenPhieu = "PHIẾU THỦ THUẬT LỌC MÁU 3";
                    this.MaPhieu = "Thuthuat_locmau3";
                    this.Mota = "Cách thức tiến hành:\n- Bệnh nhân nằm tư thế thuận lợi\n- Bộc lộ catheter\n- Thiết lập vòng tuần hoàn ngoài cơ thể\n- Theo dõi buổi lọc máu\n- Kết thúc buổi lọc máu\n- Bảo quản catheter";
                    this.pathAnh1 = "Thuthuat_locmau3_1.bmp";
                    this.pathAnh2 = "";//null
                    break;
                case LoaiTT.Thuthuatproetz: //11
                    this.TenPhieu = "PHIẾU THỦ THUẬT PROETZ";
                    this.MaPhieu = "Thuthuatproetz";
                    this.Mota = " - NB được đăt nằm ngửa, tư thế đầu ngửa tối đa\n- Một bên mũi sẽ được bịt kín, bên mũi còn lại dùng hút lắp ambu vừa khít hốc mũi, và hướng dẫn người bệnh kêu (kê kê) máy hút dịch mũi ra ngoài.\n- Nhỏ khoảng từ 10- 20 giọt thuốc nước muối vào bên trong  mũi .\n- Đổi bên mũi bị bịt kín, và thực hiện tương tự với bên còn lại\n- NB nằm giữ nguyên tư thế nằm ngửa trong khoảng 10-15 phút\n - Trong và sau thủ thuật không xảy ra tai biến gì";
                    this.pathAnh1 = "Thuthuatproetz_1.bmp";
                    this.pathAnh2 = "";//null
                    break;
                case LoaiTT.Thuthuatruadaday: //12
                    this.TenPhieu = "PHIẾU THỦ THUẬT RỬA DẠ DÀY";
                    this.MaPhieu = "Thuthuatruadaday";
                    this.Mota = " - Thông báo về thủ thuật sắp tiến hành trên NB.\n - Chuẩn bị dụng cụ đầy đủ.\n - Mang găng tay vô khuẩn.\n - Kiểm tra ống sonde chắc chắn đã vào dạ dày.\n - Dùng bơm 50ml bơm mỗi lần từ 300ml - 500ml dung dịch rửa vào dạ dày NB.  Hạ thấp ống thông cho dịch dạ dày chảy ra.\n - Lặp lại quy trình trên đến khi dịch dạ dày chảy ra trong hoặc theo chỉ định của bác sỹ.\n - Rút sonde, lau mũi miệng cho NB.\n - Dặn dò NB những điều cần thiết.";
                    this.pathAnh1 = "";//null
                    this.pathAnh2 = "";//null
                    break;
                case LoaiTT.Thuthuatsondetieunam: //13
                    this.TenPhieu = "PHIẾU THỦ THUẬT ĐẶT SONDE BÀNG QUANG NAM";
                    this.MaPhieu = "Thuthuatsondetieunam";
                    this.Mota = " - Thông báo thủ thuật sắp tiến hành trên NB\n- Chuẩn bị dụng cụ đầy đủ.\n- Hướng dẫn NB nằm ngửa trên giường, dạng hai chân.\n- Đặt bộ dụng cụ thông tiểu và khay quả đậu đựng rác ở vị trí thích hợp.\n- Đeo găng vô khuẩn\n- Bôi trơn đầu ống thông \n- Sát khuẩn bộ phận sinh dục đúng kỹ thuật\n- Đưa ống thông qua niệu đạo vào bàng quang đúng kỹ thuật. Hướng dẫn, động viên NB\n- Khi có nước tiểu chảy ra, đẩy sonde thêm 5 cm, tiến hành bơm Cuff\n- Mặc quần cho NB, thu dọn dụng cụ\n- Dặn dò những điều cần thiết.";
                    this.pathAnh1 = ""; //null
                    this.pathAnh2 = ""; //null
                    break;
                case LoaiTT.Thuthuatsondetieunu: //14
                    this.TenPhieu = "PHIẾU THỦ THUẬT ĐẶT SONDE BÀNG QUANG NỮ";
                    this.MaPhieu = "Thuthuatsondetieunu";
                    this.Mota = " - Thông báo thủ thuật sắp tiến hành trên NB.\n- Chuẩn bị dụng cụ đầy đủ.\n- Hướng dẫn NB nằm ngửa trên giường, hai chân chống, dạng đùi.\n- Đặt bộ dụng cụ thông tiểu và khay quả đậu đựng rác ở vị trí thích hợp.\n- Đeo găng vô khuẩn.\n- Bôi trơn đầu ống thông.\n- Sát khuẩn bộ phận sinh dục đúng kỹ thuật.\n- Đưa ống thông qua niệu đạo vào bàng quang đúng kỹ thuật. Hướng dẫn, động viên NB.\n- Khi có nước tiểu chảy ra, đẩy sonde thêm 5 cm,  tiến hành bơm Cuff.\n- Mặc quần cho NB, thu dọn dụng cụ.\n- Dặn dò NB những điều cần thiết.";
                    this.pathAnh1 = ""; //null
                    this.pathAnh2 = ""; //null
                    break;
                case LoaiTT.ThuthuatthaybangruavetthuongNT: //15
                    this.TenPhieu = "PHIẾU THỦ THUẬT THAY BĂNG VẾT THƯƠNG NHIỄM TRÙNG";
                    this.MaPhieu = "ThuthuatthaybangruavetthuongNT";
                    this.Mota = " - Thông báo về thủ thuật sắp tiến hành trên NB.\n- Chuẩn bị dụng cụ đầy đủ.\n- Trải nilon xuống dưới vết thương, đặt khay quả đậu ở vị trí thích hợp.\n-  Dùng kẹp tháo bỏ băng cũ.\n-  Quan sát, đánh giá tình trạng vết thương.\n-  Rửa rộng xung quanh vết thương và các vùng lân cận bằng dd NaCl 0.9% \n- Dùng kẹp và kéo cắt chỉ cách (nếu có chỉ định)\n- Gắp gạc vô khuẩn, ấn nhẹ theo chiều dọc của vết thương để ép dịch ở trong vết thương chảy ra.\n-  Rửa vết thương cho đến khi sạch. \n- Dùng gạc vô khuẩn thấm khô vết thương.\n- Sát khuẩn vết thương bằng dd Betadin.\n- Đắp gạc vô khuẩn lên vết thương.\n- Dùng băng dính cố định băng.\n- Đặt NB về tư thế thoải mái.";
                    this.pathAnh1 = ""; //null
                    this.pathAnh2 = ""; //null
                    break;
                case LoaiTT.Thuthuatthokhidung_Canuyl: //16
                    this.TenPhieu = "PHIẾU THỦ THUẬT THỞ KHÍ DUNG QUA CANUYL";
                    this.MaPhieu = "Thuthuatthokhidung_Canuyl";
                    this.Mota = "Thông báo thủ thuật sắp tiến hành trên NB\n- Chuẩn bị dụng cụ, thuốc đầy đủ.\n- Kiểm tra máy khí dung hoạt động bình thường\n- Lắp hệ thống dây nối vào máy\n- Cho thuốc vào bầu đựng thuốc, nối bầu khí dung vào hệ thống dây dẫn.\n- Bật máy, quan sát thấy thuốc bay ra dưới dạng sương\n-  Áp Mask kín canuyl.\n- Theo dõi NB trong quá trình thở\n- Kết thúc quá trình thở khí dung: vệ sinh mask khí dung theo quy định.";
                    this.pathAnh1 = "Thuthuatthongdaday_1.bmp";
                    this.pathAnh2 = "";
                    break;
                case LoaiTT.Thuthuatthongdaday: //17    
                    this.TenPhieu = "PHIẾU THỦ THUẬT ĐẶT ỐNG THÔNG DẠ DÀY";
                    this.MaPhieu = "Thuthuatthongdaday";
                    this.Mota = " -Thông báo thủ thuật sắp tiến hành trên NB\n- Chuẩn bị dụng cụ đầy đủ.\n- Vệ sinh mũi, cắt băng dính.\n- Mang găng tay.\n- Đo và đánh dấu ống thông.\n- Bôi trơn đầu ống thông đưa ống thông nhẹ nhàng vào mũi, qua họng, thực quản xuống dạ dày NB\n- Kiểm tra và xác định chính xác ống thông đã vào trong dạ dày NB, cố định ống thông.\n- Dặn dò những điều cần thiết";
                    this.pathAnh1 = "";
                    this.pathAnh2 = "";
                    break;
                case LoaiTT.Thuthuatthonghaumon: //18
                    this.TenPhieu = "PHIẾU THỦ THUẬT ĐẶT ỐNG THÔNG HẬU MÔN";
                    this.MaPhieu = "Thuthuatthonghaumon";
                    this.Mota = " - Thông báo về thủ thuật sắp tiến hành\n - Chuẩn bị dụng cụ đầy đủ\n - Trải nilon dưới mông, bộc lộ hậu môn\n - Giúp NB nằm nghiêng sang trái\n - Điều dưỡng đeo găng tay. Bôi trơn đầu sonde từ 3-5 cm\n - Đưa sonde vào hậu môn NB đúng kỹ thuật\n - Động viên NB\n - Cố định sonde\n -  Mặc quần lại cho NB, hướng dẫn những điều cần thiết";
                    this.pathAnh1 = "";
                    this.pathAnh2 = "";
                    break;
                case LoaiTT.Thuthuatthooxygongkinh: //19
                    this.TenPhieu = "PHIẾU THỦ THUẬT THỞ OXY GỌNG KÍNH";
                    this.MaPhieu = "Thuthuatthooxygongkinh";
                    this.Mota = " - Thông báo với NB về thủ thuật sắp tiến hành.\n- Chuẩn bị dụng cụ đầy đủ.\n- Lắp đồng hồ vào bình Oxy.\n- Đổ nước vào bình làm ẩm. Mở khóa bình Oxy quan sát bình làm ẩm có sủi không khóa bình lại.\n- Sát khuẩn tay nhanh.\n- Nối dây oxy vào bình làm ẩm. Mở khóa kiểm tra hệ thống có thông không. Điều chỉnh lưu lượng Oxy đúng chỉ định.\n- Đưa gọng kính vào mũi người bệnh, cố định dây Oxy trên đỉnh đầu hoặc dưới cằm người bệnh.\n- Với người bệnh tỉnh: hỏi người bệnh có cảm giác mát vào hai bên mũi không. Hướng dẫn người bệnh cách thở.\n- Với người bệnh không tỉnh: quan sát đánh giá da, môi, nhịp thở, SpO2.\n- Theo dõi và dặn dò người bệnh những điều cần thiết.";
                    this.pathAnh1 = "";
                    this.pathAnh2 = "";
                    break;
                case LoaiTT.Thuthuatthutthaophan: //20
                    this.TenPhieu = "PHIẾU THỦ THUẬT THỤT THÁO PHÂN (BẰNG NƯỚC)";
                    this.MaPhieu = "Thuthuatthutthaophan";
                    this.Mota = "- Thông báo thủ thuật sắp tiến hành trên NB.\n- Chuẩn bị dụng cụ đầy đủ.\n- Trải nilon dưới mông, bộc lộ vùng hậu môn.\n- Hướng dẫn NB nằm nghiêng sang trái, kiểm tra nhiệt độ của nước. Treo bốc lên cọc\n- Mang găng tay.\n- Bôi trơn canuyl (hoặc sonde hậu môn), đưa canuyl vào trực tràng đúng kỹ thuật.\n- Mở khóa cho nước chảy từ từ vào đại tràng NB.\n- Rút Canuyl ra khỏi hậu môn NB, khép chặt hậu môn.\n- Dặn dò NB những điều cần thiết.\n- Thu dọn dụng cụ.";
                    this.pathAnh1 = "";
                    this.pathAnh2 = "";
                    break;
                case LoaiTT.Thuthuatthutthaophanbangthuoc: //21
                    this.TenPhieu = "PHIẾU THỦ THUẬT THỤT THÁO PHÂN (BẰNG THUỐC)";
                    this.MaPhieu = "Thuthuatthutthaophanbangthuoc";
                    this.Mota = " - Thông báo thủ thuật sắp tiến hành trên NB.\n- Chuẩn bị dụng cụ đầy đủ.\n- Bộc lộ vùng hậu môn NB.\n- Mang găng tay.\n- Tay thuận cầm tuyp thuốc, mở nắp, bội trơn đầu tuyp thuốc.\n- Vành mông NB, đưa đầu tuyp thuốc vào hậu môn, bóp hết thuốc vào trực tràng NB.\n- Rút tuyp thuốc ra khỏi hậu môn, khép chặt hậu môn NB. \n- Dặn dò những điều cần thiết.\n- Thu dọn dụng cụ.";
                    this.pathAnh1 = "";
                    this.pathAnh2 = "";
                    break;
                case LoaiTT.Thuthuattruyenhoachat: //22
                    this.TenPhieu = "PHIẾU THỦ THUẬT TRUYỀN HÓA CHẤT TĨNH MẠCH";
                    this.MaPhieu = "Thuthuattruyenhoachat";
                    this.Mota = " Cách thức tiến hành:\n- Thông báo, giải thích cho người bệnh trước khi làm thủ thuật\n- Pha hóa chất theo y lệnh…………………………\n- Đặt đường truyền tĩnh mạch\n- Thực hiện y lệnh điều trị\n- Truyền hóa chất theo thứ tự, tốc độ theo chỉ định của bác sĩ\n- Theo dõi sát quá trình truyền hóa chất\n- Tiêm thuốc sau truyền hóa chất theo y lệnh\n- Rút kim truyền tĩnh mạch\n- Kết thúc thủ thuật, dặn bệnh nhân những điều cần thiết";
                    this.pathAnh1 = "Thuthuattruyenhoachat_1.bmp";
                    this.pathAnh2 = "";
                    break; 
                case LoaiTT.ThuthuatYHCT: //23
                    this.TenPhieu = "PHIẾU THỦ THUẬT CẤY CHỈ";
                    this.MaPhieu = "ThuthuatYHCT";
                    this.Mota = "\nChuẩn bị bệnh nhân. \n- Chuẩn bị dụng cụ: kim, chỉ, dụng cụ khác.\n- Xác định huyệt cấy chỉ.\n- Sát khuẩn vùng huyệt.\n- Đâm kim cấy chỉ vào huyệt.\n- Cho lòng vào ống kim, đẩy lòng từ\n  từ, rút lòng kim ra, chỉ nằm lại huyệt.\n- Rút toàn bộ kim ra khỏi huyệt.\n- Sát khuẩn, đặt bông và băng dính.\n- Thủ thuật an toàn.";
                    this.pathAnh1 = "ThuthuatYHCT_1.bmp";
                    this.pathAnh2 = "";
                    break;
                case LoaiTT.ThuthuatYHCT_NU: //24
                    this.TenPhieu = "PHIẾU THỦ THUẬT CẤY CHỈ NỮ";
                    this.MaPhieu = "ThuthuatYHCT_NU";
                    this.Mota = "Chuẩn bị bệnh nhân. \n- Chuẩn bị dụng cụ: kim, chỉ, dụng cụ khác.\n- Xác định huyệt cấy chỉ.\n- Sát khuẩn vùng huyệt.\n- Đâm kim cấy chỉ vào huyệt.\n- Cho lòng vào ống kim, đẩy lòng từ từ, rút lòng kim ra, chỉ nằm lại huyệt.\n- Rút toàn bộ kim ra khỏi huyệt.\n- Sát khuẩn, đặt bông và băng dính.\n- Thủ thuật an toàn.";
                    this.pathAnh1 = "ThuthuatYHCT_NU_1.bmp"; ;
                    this.pathAnh2 = "";
                    break;
                case LoaiTT.ThuthuatPHCN: //25
                    this.TenPhieu = "PHIẾU THỦ THUẬT PHỤC HỒI CHỨC NĂNG";
                    this.MaPhieu = "ThuthuatPHCN";
                    this.Mota = "";
                    this.pathAnh1 = "ThuthuatPHCN_1.bmp"; ;
                    this.pathAnh2 = "";
                    break;
                case LoaiTT.ThoMayXamNhap:
                    this.TenPhieu = "PHIẾU THỦ THUẬT THỞ MÁY XÂM NHẬP";
                    this.MaPhieu = "ThoMayXamNhap";
                    this.Mota = "Khởi động máy thở\n- Test máy thở\n-Chọn mode thở\n-Cài đặt thông số theo y lệnh\n-Kết nối bệnh nhân với máy thở\n-Theo dõi toàn trạng bệnh nhân ";
                    this.pathAnh1 = "TT_ThoMayXamNhap.png"; ;
                    this.pathAnh2 = "";
                    break;
                case LoaiTT.ThoMayKhongXamNhap:
                    this.TenPhieu = "PHIẾU THỦ THUẬT THỞ MÁY KHÔNG XÂM NHẬP";
                    this.MaPhieu = "ThoMayKhongXamNhap";
                    this.Mota = "Khởi động máy thở\n- Test máy thở\n-Chọn mode thở\n-Cài đặt thông số theo y lệnh\n-Kết nối bệnh nhân với máy thở\n-Theo dõi toàn trạng bệnh nhân ";
                    this.pathAnh1 = "TT_ThoMayKhongXamNhap.png"; ;
                    this.pathAnh2 = "";
                    break;
                default:
                    this.TenPhieu = "PHIẾU THỦ THUẬT";
                    this.Mota = "";
                    this.pathAnh1 = ""; ;
                    this.pathAnh2 = "";
                    break;
            }
        }
        public string GetTenPhieu()
        {
            return this.TenPhieu;
        }
        public string GetAnh1()
        {
            return this.pathAnh1;
        }
        public string GetAnh2()
        {
            return this.pathAnh2;
        }
        public string GetMota()
        {
            return this.Mota;
        }
    }
    public class TaoPhieuThuThuatFunc
    {
        public static string PathApp = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"/PaintLibrary/HinhAnh/ThuThuat/";
        public static List<TaoPhieuThuThuat> GetDanhSachPhieu(MDB.MDBConnection MyConnection)
        {
            List<TaoPhieuThuThuat> lstDSPhieuTT = new List<TaoPhieuThuThuat>();
            try
            {
                string sql = "SELECT * FROM DS_PHIEUTHUTHUAT";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {

                    TaoPhieuThuThuat phieuThuThuat = new TaoPhieuThuThuat();
                    phieuThuThuat.ID = dataReader.GetLong("ID");
                    phieuThuThuat.TenPhieu = dataReader["TenPhieu"].ToString();
                    phieuThuThuat.MaPhieu = dataReader["MaPhieu"].ToString();
                    phieuThuThuat.Mota = dataReader["mota"].ToString();
                    phieuThuThuat.ShowBSSDD = dataReader["ShowBSSDD"].ToString().Equals("1") ? true:false;
                    phieuThuThuat.ShowSLBSDD = dataReader["ShowSLBSDD"].ToString().Equals("1") ? true : false;
                    phieuThuThuat.NgayTao = Convert.ToDateTime(dataReader["NgayTao"] == DBNull.Value ? DateTime.Now : dataReader["NgayTao"]);
                    phieuThuThuat.NguoiTao = dataReader["NguoiTao"].ToString();
                    phieuThuThuat.NgaySua = Convert.ToDateTime(dataReader["NgaySua"] == DBNull.Value ? DateTime.Now : dataReader["NgaySua"]);
                    phieuThuThuat.NguoiSua = dataReader["NguoiSua"].ToString();
                    switch (phieuThuThuat.MaPhieu)
                    {
                        case "XoangHam": //0

                            phieuThuThuat.pathAnh1 = "XoangHam_1.bmp";
                            phieuThuThuat.pathAnh2 = "XoangHam_2.bmp";
                            break;
                        case "ThuthuatbomruaBQ": //1

                            phieuThuThuat.pathAnh1 = ""; //null
                            phieuThuThuat.pathAnh2 = ""; //null
                            break;
                        case "ThuthuatDonhanap": //2

                            phieuThuThuat.pathAnh1 = "ThuthuatDonhanap_1.bmp";
                            phieuThuThuat.pathAnh2 = ""; //null
                            break;
                        case "Thuthuatduonghohapduoi": //3

                            phieuThuThuat.pathAnh1 = "Thuthuatduonghohapduoi_1.bmp";
                            phieuThuThuat.pathAnh2 = "";//null
                            break;
                        case "Thuthuathutdomdaitren": //4

                            phieuThuThuat.pathAnh1 = "Thuthuathutdomdaitren_1.bmp";
                            phieuThuThuat.pathAnh2 = "";//null
                            break;
                        case "ThuthuathutdomongNKQ": //5

                            phieuThuThuat.pathAnh1 = "ThuthuathutdomongNKQ_1.bmp";
                            phieuThuThuat.pathAnh2 = "";//null
                            break;
                        case "Thuthuatkhidung": //6

                            phieuThuThuat.pathAnh1 = "Thuthuatkhidung_1.bmp";
                            phieuThuThuat.pathAnh2 = "";//null
                            break;
                        case "Thuthuatlamthuoctai": //7

                            phieuThuThuat.pathAnh1 = "Thuthuatlamthuoctai_1.bmp";
                            phieuThuThuat.pathAnh2 = "";//null
                            break;
                        case "Thuthuat_locmau1": //8

                            phieuThuThuat.pathAnh1 = "Thuthuat_locmau1_1.bmp";
                            phieuThuThuat.pathAnh2 = "";//null
                            break;
                        case "Thuthuat_locmau2": //9

                            phieuThuThuat.pathAnh1 = "Thuthuat_locmau2_1.bmp";
                            phieuThuThuat.pathAnh2 = "";//null
                            break;
                        case "Thuthuat_locmau3": //10

                            phieuThuThuat.pathAnh1 = "Thuthuat_locmau3_1.bmp";
                            phieuThuThuat.pathAnh2 = "";//null
                            break;
                        case "Thuthuatproetz": //11

                            phieuThuThuat.pathAnh1 = "Thuthuatproetz_1.bmp";
                            phieuThuThuat.pathAnh2 = "";//null
                            break;
                        case "Thuthuatruadaday": //12

                            phieuThuThuat.pathAnh1 = "";//null
                            phieuThuThuat.pathAnh2 = "";//null
                            break;
                        case "Thuthuatsondetieunam": //13

                            phieuThuThuat.pathAnh1 = ""; //null
                            phieuThuThuat.pathAnh2 = ""; //null
                            break;
                        case "Thuthuatsondetieunu": //14

                            phieuThuThuat.pathAnh1 = ""; //null
                            phieuThuThuat.pathAnh2 = ""; //null
                            break;
                        case "ThuthuatthaybangruavetthuongNT": //15

                            phieuThuThuat.pathAnh1 = ""; //null
                            phieuThuThuat.pathAnh2 = ""; //null
                            break;
                        case "Thuthuatthokhidung_Canuyl": //16

                            phieuThuThuat.pathAnh1 = "Thuthuatthongdaday_1.bmp";
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        case "Thuthuatthongdaday": //17    

                            phieuThuThuat.pathAnh1 = "";
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        case "Thuthuatthonghaumon": //18

                            phieuThuThuat.pathAnh1 = "";
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        case "Thuthuatthooxygongkinh": //19

                            phieuThuThuat.pathAnh1 = "";
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        case "Thuthuatthutthaophan": //20

                            phieuThuThuat.pathAnh1 = "";
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        case "Thuthuatthutthaophanbangthuoc": //21

                            phieuThuThuat.pathAnh1 = "";
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        case "Thuthuattruyenhoachat": //22

                            phieuThuThuat.pathAnh1 = "Thuthuattruyenhoachat_1.bmp";
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        case "ThuthuatYHCT": //23

                            phieuThuThuat.pathAnh1 = "ThuthuatYHCT_1.bmp";
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        case "ThuthuatYHCT_NU": //24

                            phieuThuThuat.pathAnh1 = "ThuthuatYHCT_NU_1.bmp"; ;
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        case "ThuthuatPHCN": //25

                            phieuThuThuat.pathAnh1 = "ThuthuatPHCN_1.bmp"; ;
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        case "ThoMayXamNhap":

                            phieuThuThuat.pathAnh1 = "TT_ThoMayXamNhap.png"; ;
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        case "ThoMayKhongXamNhap":

                            phieuThuThuat.pathAnh1 = "TT_ThoMayKhongXamNhap.png"; ;
                            phieuThuThuat.pathAnh2 = "";
                            break;
                        default:
                            phieuThuThuat.pathAnh1 = ""; ;
                            phieuThuThuat.pathAnh2 = "";
                            break;
                    }
                    lstDSPhieuTT.Add(phieuThuThuat);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return lstDSPhieuTT;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref TaoPhieuThuThuat phieuThuThuat)
        {
            try
            {
                string sql = @"INSERT INTO DS_PHIEUTHUTHUAT
                (
                    TenPhieu,
                    MaPhieu,
                    Mota,
                    ShowBSSDD,
                    ShowSLBSDD,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :TenPhieu,
                    :MaPhieu,
                    :Mota,
                    :ShowBSSDD,
                    :ShowSLBSDD,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuThuThuat.ID != 0)
                {
                    sql = @"UPDATE DS_PHIEUTHUTHUAT SET 
                    TenPhieu = :TenPhieu,
                    MaPhieu = :MaPhieu,
                    Mota = :Mota,
                    ShowBSSDD = :ShowBSSDD,
                    ShowSLBSDD = :ShowSLBSDD,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuThuThuat.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("TenPhieu", phieuThuThuat.TenPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhieu", phieuThuThuat.MaPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("Mota", phieuThuThuat.Mota));
                Command.Parameters.Add(new MDB.MDBParameter("ShowBSSDD", phieuThuThuat.ShowBSSDD ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("ShowSLBSDD", phieuThuThuat.ShowSLBSDD ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuThuThuat.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuThuThuat.NgaySua));
                if (phieuThuThuat.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuThuThuat.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuThuThuat.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuThuThuat.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuThuThuat.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuThuThuat.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, TaoPhieuThuThuat phieuThuThuat)
        {
            string sql = "DELETE FROM DS_PHIEUTHUTHUAT WHERE ID = :ID";
            MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("ID", phieuThuThuat.ID));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static string DownloadAnhMoTa(int stt, decimal IdThuThuat, decimal maQuanLy, string MaPhieu, bool WSActive)
        {
            string fullPath = "";
            bool checkResult = false;
            try
            {
                string FileHinhAnh = @"\PKTTT"+ stt + @"\" + maQuanLy;
                if (IdThuThuat != 0M)
                {
                    if (WSActive)
                    {
                        using (var client = new HttpClient())
                        {
                            try
                            {
                                string URL = ERMDatabase.WebServiceEMR;
                                client.BaseAddress = new Uri(URL);
                                client.DefaultRequestHeaders.Accept.Clear();
                                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                                client.Timeout = new TimeSpan(0, 0, 1000);
                                string fileName = FileHinhAnh.Trim('\\') + "\\" + IdThuThuat + ".png";
                                var url = "api/KetXuat/Get1File?PathFile=" + fileName;
                                HttpResponseMessage response = client.GetAsync(url).Result;
                                response.EnsureSuccessStatusCode();
                                if (response.IsSuccessStatusCode)
                                {
                                    string result = response.Content.ReadAsStringAsync().Result;
                                    if (result != "null" && result != "[]")
                                    {
                                        FileCopy lstFile = JsonConvert.DeserializeObject<FileCopy>(result);
                                        if (lstFile != null)
                                        {
                                            string tempPath = System.IO.Path.GetTempPath().Trim('\\');
                                            fullPath = tempPath.Trim('\\') + "\\" + FileHinhAnh.Trim('\\');
                                            if (!System.IO.Directory.Exists(fullPath)) { System.IO.Directory.CreateDirectory(fullPath); }
                                            string fileHinhAnh = fullPath.Trim('\\') + "\\" + lstFile.FileName;
                                            try
                                            {
                                                File.WriteAllBytes(fileHinhAnh, lstFile.ArrayBytes);
                                            }
                                            catch
                                            {
                                                //fileHinhAnh = fullPath.Trim('\\') + "\\COPY_" + lstFile.FileName;
                                                //File.WriteAllBytes(fileHinhAnh, lstFile.ArrayBytes);
                                            }
                                            checkResult = true;
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                XuLyLoi.LogError(ex);
                            }
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            if (!checkResult && !string.IsNullOrEmpty(MaPhieu))
            {

                switch (MaPhieu)
                {
                    case "XoangHam": //0
                        if(stt == 1)
                            fullPath = PathApp + "XoangHam_1.bmp";
                        else if (stt == 2)
                            fullPath = PathApp + "XoangHam_2.bmp";
                        break;
                    case "ThuthuatDonhanap": //2
                        if (stt == 1)
                            fullPath = PathApp + "ThuthuatDonhanap_1.bmp";
                        else if (stt == 2)
                            fullPath = ""; //null
                        break;
                    case "Thuthuatduonghohapduoi": //3
                        if (stt == 1)
                            fullPath = PathApp + "Thuthuatduonghohapduoi_1.bmp";
                        break;
                    case "Thuthuathutdomdaitren": //4
                        if (stt == 1)
                            fullPath = PathApp + "Thuthuathutdomdaitren_1.bmp";
                        break;
                    case "ThuthuathutdomongNKQ": //5
                        if (stt == 1)
                            fullPath = PathApp + "ThuthuathutdomongNKQ_1.bmp";
                        break;
                    case "Thuthuatkhidung": //6
                        if (stt == 1)
                            fullPath = PathApp +  "Thuthuatkhidung_1.bmp";
                        break;
                    case "Thuthuatlamthuoctai": //7
                        if (stt == 1)
                            fullPath = PathApp + "Thuthuatlamthuoctai_1.bmp";
                        break;
                    case "Thuthuat_locmau1": //8

                        if (stt == 1)
                            fullPath = PathApp + "Thuthuat_locmau1_1.bmp";
                        break;
                    case "Thuthuat_locmau2": //9
                        if (stt == 1)
                            fullPath = PathApp + "Thuthuat_locmau2_1.bmp";
                        break;
                    case "Thuthuat_locmau3": //10
                        if (stt == 1)
                            fullPath = PathApp + "Thuthuat_locmau3_1.bmp";
                        break;
                    case "Thuthuatproetz": //11
                        if (stt == 1)
                            fullPath = PathApp + "Thuthuatproetz_1.bmp";
                        break;
                    case "Thuthuatthokhidung_Canuyl": //16
                        if (stt == 1)
                            fullPath = PathApp + "Thuthuatthongdaday_1.bmp";
                        break;
                    case "Thuthuattruyenhoachat": //22
                        if (stt == 1)
                            fullPath = PathApp + "Thuthuattruyenhoachat_1.bmp";
                        break;
                    case "ThuthuatYHCT": //23
                        if (stt == 1)
                            fullPath = PathApp + "ThuthuatYHCT_1.bmp";
                        break;
                    case "ThuthuatYHCT_NU": //24
                        if (stt == 1)
                            fullPath = PathApp + "ThuthuatYHCT_NU_1.bmp"; ;
                        break;
                    case "ThuthuatPHCN": //25
                        if (stt == 1)
                            fullPath = PathApp + "ThuthuatPHCN_1.bmp"; ;
                        break;
                    case "ThoMayXamNhap":
                        if (stt == 1)
                            fullPath = PathApp + "TT_ThoMayXamNhap.png"; ;
                        break;
                    case "ThoMayKhongXamNhap":
                        if (stt == 1)
                            fullPath = PathApp + "TT_ThoMayKhongXamNhap.png"; ;
                        break;
                }
            }
            return fullPath;
        }
    }
}