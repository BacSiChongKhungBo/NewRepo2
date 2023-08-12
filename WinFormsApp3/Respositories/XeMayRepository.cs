using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Context;
using WinFormsApp3.DomainClass;

namespace WinFormsApp3.Respositories
{
    internal class XeMayRepository
    {
        //Để sử dụng được dbcontext và lấy dữ liệu
        private DBContext dbContext; // lưu ý sử dụng dbconext của solution

        //ctor tab
        public XeMayRepository()
        {
            dbContext = new DBContext();
        }

        //Lấy dữ liệu từ bảng xe máy
        public List<XeMay> GetAll()
        {
            //lấy dữ liệu từ bảng xe máy trong DB dưới dạng list
            return dbContext.XeMays.ToList();
        }

        public bool AddXeMay(XeMay x)
        {
            if(x == null)
            {
                return false;
            }
            // tạo guidID cho xe máy mới
            x.Id = Guid.NewGuid();
            //tiến hành gọi dbconext để add
            dbContext.Add(x);
            // lưu thay đổi
            dbContext.SaveChanges();
            return true;
        }

        public bool DeleteXeMay(string currentMaXe)
        {
            // tìm xe tương ứng với mã đó
            var x = dbContext.XeMays.FirstOrDefault(xm => xm.Ma == currentMaXe);
            if(x == null)
            {
                return false;
            }
            dbContext.Remove(x);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateXeMay(XeMay obj)
        {
            //LƯU Ý, Khi update thì không dùng chính obj để update
            // ta sẽ update 1 biến temp thay cho obj
            if(obj == null)
            {
                return false;
            }
            var temp = dbContext.XeMays.FirstOrDefault(x => x.Ma == obj.Ma);
            temp.Ten = obj.Ten;
            temp.Mota = obj.Mota;
            temp.GiaNhap = obj.GiaNhap;
            temp.SoLuong = obj.SoLuong;
            dbContext.Update(temp);// UPDATE TEMP, KO UPDATE OBJ
            dbContext.SaveChanges();
            return true;
        }

        //Lấy list Loại Xe Máy
        public List<LoaiXm> GetLoaiXms()
        {
            return dbContext.LoaiXms.ToList();
        }
    }
}
