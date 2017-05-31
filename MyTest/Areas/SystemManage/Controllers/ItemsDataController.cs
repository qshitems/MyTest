
using MyTest.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Code;
using MyTest.Model;
using System.Text;
using System;

namespace MyTest.Web.Areas.SystemManage.Controllers
{
    public class ItemsDataController : ControllerBase
    {
        Sys_ItemsDetailBLL idbll = new Sys_ItemsDetailBLL();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string itemId, string keyword)
        {
            var data = idbll.GetModelList("F_ItemId= '" + itemId + "'");
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetSelectJson(string enCode)
        {


            var data = idbll.GetItemList(enCode);
            List<object> list = new List<object>();
            foreach (Sys_ItemsDetailModel item in data)
            {
                list.Add(new { id = item.F_ItemCode, text = item.F_ItemName });
            }
            return Content(list.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = idbll.GetModel(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(Sys_ItemsDetailModel itemsDetailEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                itemsDetailEntity.F_Id = keyValue;
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                if (LoginInfo != null)
                {
                    itemsDetailEntity.F_LastModifyUserId = LoginInfo.UserId;
                }
                itemsDetailEntity.F_LastModifyTime = DateTime.Now;
                idbll.Update(itemsDetailEntity);
            }
            else
            {
                itemsDetailEntity.F_Id = Common.GuId();
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                if (LoginInfo != null)
                {
                    itemsDetailEntity.F_CreatorUserId = LoginInfo.UserId;
                }
                itemsDetailEntity.F_CreatorTime = DateTime.Now;
                idbll.Add(itemsDetailEntity);
            }
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            idbll.Delete(keyValue);
            return Success("删除成功。");
        }
    }
}
