using Charity.Bll.Bend;
using Charity.Dal.TAllmoneyl;
using Charity.Model;
using System;

namespace Charity.Bll.TAllmoneyl
{
    public class TAllmoneylBll
    {
        TAllmoneylDal TAllmoneylDal = new TAllmoneylDal();
        BendShopBll _bendshopBll = new BendShopBll();
        BendMoneyBll _bendmoneyBll = new BendMoneyBll();
        TAllmoney shopmaney = new TAllmoney();
        BendPovertyBll _bendpovertyBll = new BendPovertyBll();




        #region  --总募捐物品价值 --减少  ID为1
        public bool delet_buyshop(int Id)
        {
            var model = _bendshopBll.Query_Shop(Id);//查找出该表全部数据
            shopmaney.ID = 1;
            int monmey = Convert.ToInt32(model.ShopValue);
            var AllMoneymodel = _bendmoneyBll.Scan_AllMoney();
            shopmaney.AllMoney = AllMoneymodel[0].AllMoney - monmey;
            return TAllmoneylDal.Add_buyshop(shopmaney);//进行更新
        }
        #endregion

        #region  --总募捐物品价值 --添加  ID为1
        public bool Add_shopvule(Tshop model)
        {
            shopmaney.ID = 1;
            int monmey = Convert.ToInt32(model.ShopValue);
            var AllMoneymodel = _bendmoneyBll.Scan_AllMoney();
            shopmaney.AllMoney = AllMoneymodel[0].AllMoney + monmey;
            return TAllmoneylDal.Add_buyshop(shopmaney);
        }
        #endregion
        
        #region  --总义卖物品所得 --添加  ID为2
        public bool Add_buyshop(int Id)
        {
            var model = _bendshopBll.Query_Shop(Id);
            shopmaney.ID = 2;
            int monmey = Convert.ToInt32(model.ShopValue);
            var AllMoneymodel = _bendmoneyBll.Scan_AllMoney();
            shopmaney.AllMoney = AllMoneymodel[1].AllMoney + monmey;
            return TAllmoneylDal.Add_buyshop(shopmaney);
        }
        #endregion

        #region  --慈善募捐--善筹资金 --添加  ID为3
        public bool AddMoneyMSG(Tmoney model)
        {
            shopmaney.ID = 3;
            int monmey = Convert.ToInt32(model.ChrityMoney);
            var AllMoneymodel = _bendmoneyBll.Scan_AllMoney();
            shopmaney.AllMoney = AllMoneymodel[2].AllMoney + monmey;
            return TAllmoneylDal.Add_buyshop(shopmaney);
        }
        #endregion

        #region  --慈善募捐--善筹资金 --减少  ID为3
        public bool Deleted_MoneyMSG(int Id)
        {
            shopmaney.ID = 3;
            var model = _bendmoneyBll.Query_Money(Id);
            int monmey = Convert.ToInt32(model.ChrityMoney);
            var AllMoneymodel = _bendmoneyBll.Scan_AllMoney();
            shopmaney.AllMoney = AllMoneymodel[2].AllMoney - monmey;
            return TAllmoneylDal.Add_buyshop(shopmaney);
        }
        #endregion

        #region  --总募捐物品价值 --添加  ID为4
        public bool AddProvertyMoneyMSG(Tpoverty model)
        {
            shopmaney.ID = 4;
            int monmey = Convert.ToInt32(model.ApplyValue);
            var AllMoneymodel = _bendmoneyBll.Scan_AllMoney();
            shopmaney.AllMoney = AllMoneymodel[3].AllMoney + monmey;
            return TAllmoneylDal.Add_buyshop(shopmaney);
        }
        #endregion

        #region  --总募捐物品价值 --减少  ID为4
        public bool Delect_ProvertyMoneyMSG(int Id)
        {
            var queryResult = _bendpovertyBll.Query_Poverty(Id);//查找出该表全部数据
            shopmaney.ID = 4;
            int monmey = Convert.ToInt32(queryResult.ApplyValue);
            var AllMoneymodel = _bendmoneyBll.Scan_AllMoney();
            shopmaney.AllMoney = AllMoneymodel[3].AllMoney - monmey;
            return TAllmoneylDal.Add_buyshop(shopmaney);//进行更新
        }
        #endregion

        #region  --总价值资金  --更新  ID为5
        public bool all_buyshop()
        {
            var AllMoneymodel = _bendmoneyBll.Scan_AllMoney();
            shopmaney.ID = 5;
            shopmaney.AllMoney = AllMoneymodel[0].AllMoney + AllMoneymodel[1].AllMoney + AllMoneymodel[1].AllMoney + AllMoneymodel[2].AllMoney;
            return TAllmoneylDal.Add_buyshop(shopmaney);
        }
        #endregion






    }
}
