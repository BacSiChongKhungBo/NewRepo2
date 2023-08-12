using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.DomainClass;
using WinFormsApp3.Respositories;

namespace WinFormsApp3.Services
{
    internal class XeMayService
    {
        //Để sử dụng repos
        private XeMayRepository _repos;

        public XeMayService()
        {
            _repos = new XeMayRepository();
        }

        //Load grid và tìm kiếm
        public List<XeMay> GetXeMays(string txtSearch)
        {
            //Nếu ô textbox tìm kiếm ko nhập gì
            if(txtSearch == null)
            {
                //lấy ra tất cả dữ liệu có được từ repos
                return _repos.GetAll();
            }
            // có tìm kiếm trong ô textbox
            else
            {
                //Trả về list đối tượng được tìm kiếm
                return _repos.GetAll().Where(xm => xm.Ten.StartsWith(txtSearch)).ToList();
            }
        }

        public List<LoaiXm> GetXms() 
        {
            return _repos.GetLoaiXms();
        }

        public string ThemXeMay(XeMay obj)
        {
            if (_repos.AddXeMay(obj))
            {
                return "Thêm thành công";
            } 
            else
            {
                return "Thêm thất bại";
            }
        }

        internal string SuaXeMay(XeMay obj)
        {
            if (_repos.UpdateXeMay(obj))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        internal string XoaXeMay(string currentMaXe)
        {
            if (_repos.DeleteXeMay(currentMaXe))
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }
    }
}
