using Charity.Dal.Bend;
using Charity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Bll.Bend
{
    public class BendShopBll
    {
        BendShopDal bendshopDal = new BendShopDal();

        #region  --对数据库进行 BendShop 遍历的操作--
        public IList<Tshop> Scan_Shop()
        {
            return bendshopDal.Scan_Shop();
        }
        #endregion

        #region  --有条件对数据库进行 BendShop 遍历的操作--
        public IList<Tshop> Scan_onesShop(string ShopSale)
        {
            return bendshopDal.Scan_onesShop(ShopSale);
        }
        #endregion

        #region  --对数据库进行 BendShop 增加的操作--
        public bool AddShopMSG(Tshop model)
        {
            var NowTime = DateTime.Now;
            model.ShopSetTime = NowTime;
            return bendshopDal.AddShopMSG(model);
        }

        #endregion

        #region  --对数据库进行 BendShop 单个查找的操作--
        public Tshop Query_Shop(int Id)
        {
            return bendshopDal.Query_Shop(Id);
        }

        #endregion

        #region  --对数据库进行 BendShop 更新的操作--
        public bool Update_ShopMSG(Tshop model)
        {
            return bendshopDal.Update_ShopMSG(model);
        }

        #endregion

        #region  --对数据库进行 BendShop 删除的操作--
        public bool Shop_Delected(int Id)
        {
            return bendshopDal.Shop_Delected(Id);
        }

        #endregion
    }
}
