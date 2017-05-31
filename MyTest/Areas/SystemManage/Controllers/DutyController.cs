
using MyTest.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Code;
using MyTest.Model;
using System;

namespace MyTest.Web.Areas.SystemManage.Controllers
{
    public class DutyController : ControllerBase
    {
        Sys_RoleBLL rbll = new Sys_RoleBLL();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string keyword)
        {
            var data = rbll.GetModelList("");
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = rbll.GetModel(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(Sys_RoleModel roleEntity, string keyValue)
        {

            if (!string.IsNullOrEmpty(keyValue))
            {
                roleEntity.F_Id = keyValue;
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                if (LoginInfo != null)
                {
                    roleEntity.F_LastModifyUserId = LoginInfo.UserId;
                }
                roleEntity.F_LastModifyTime = DateTime.Now;
                rbll.Update(roleEntity);
            }
            else
            {
                roleEntity.F_Id = Common.GuId();
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                if (LoginInfo != null)
                {
                    roleEntity.F_CreatorUserId = LoginInfo.UserId;
                }
                roleEntity.F_CreatorTime = DateTime.Now;
                roleEntity.F_Category = 2;
                rbll.Add(roleEntity);
            }
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
             rbll.Delete(keyValue);
            return Success("删除成功。");
        }
    }
}
