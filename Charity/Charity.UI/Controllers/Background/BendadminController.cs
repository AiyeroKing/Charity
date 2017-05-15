using Charity.Bll.Bend;
using Charity.Model;
using System.Web.Mvc;

namespace Charity.UI.Controllers.Background
{
    public class BendadminController : Controller
    {
        BendadmindBll _bendadmindBll = new BendadmindBll();
        #region --返回页面
        /// <summary>
        /// 管理员主页面
        /// </summary>
        /// <returns></returns>
        // GET: Bendadmin
        public ActionResult BendadminIndex()
        {
            var queryResult = _bendadmindBll.Scan_Bendadmind();
            ViewBag.List = queryResult;
            return View();
        }

        /// <summary>
        /// 管理员增加页面一
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAddadminoneIndex()
        {
            return View();
        }
        /// <summary>
        /// 管理员增加页面二
        /// </summary>
        /// <returns></returns>
        public ActionResult BendAddadmintwoIndex()
        {
            return View();
        }
        /// <summary>
        /// 管理员编辑页面
        /// </summary>
        /// <returns></returns>
  
        public ActionResult BendEditIndex(int Id = 0)
        {
            var queryResult = _bendadmindBll.Query_Bendadmind(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }

        public ActionResult BendadminAritialIndex(int Id = 0)
        {
            var queryResult = _bendadmindBll.Query_Bendadmind(Id);
            ViewData.Model = queryResult;
            return View(ViewData.Model);
        }
        

        #endregion

        #region --序列号验证
        public ActionResult CheckXuliehao(string xuliehao)
        {
            string xuliehao1 = "123456";
            if(xuliehao == xuliehao1)
            {
                return RedirectToAction("BendAddadmintwoIndex", "Bendadmin");
            }
            else
            {
                return RedirectToAction("BendAddadminoneIndex", "Bendadmin");
            }
        }

        #endregion

        #region --增加管理员信息
        [HttpPost]
        public ActionResult AddBendadmindMSG(Tadmin model)
        {
            var result = false;
            result = _bendadmindBll.AddBendadmindMSG(model);
            return RedirectToAction("BendadminIndex", "Bendadmin");

        }
        #endregion

        #region --编辑管理员信息
        public ActionResult UpdateBendadmindMSG(Tadmin model)
        {
            var result = false;
            result = _bendadmindBll.UpdateBendadmindMSG(model);
            return RedirectToAction("BendadminIndex", "Bendadmin");
        }
        #endregion

        #region --删除管理员信息
        public ActionResult BendadminDelected(int Id = 0)
        {
            var delectResult = _bendadmindBll.DelectResult(Id);
            return RedirectToAction("BendadminIndex", "Bendadmin");

        }
        #endregion

    }
}