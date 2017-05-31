using Code;
using MyTest.BLL;
using MyTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTest.Web.Areas.SystemManage.Controllers
{
    [HandlerLogin]
    public class UserController : ControllerBase
    {
        Sys_UserBLL userbll = new Sys_UserBLL();
        Sys_UserModel usermodel = new Sys_UserModel();
        Sys_UserLogOnBLL ulbll = new Sys_UserLogOnBLL();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            var list = userbll.GetPageList(pagination, keyword);
            var data = new
            {
                rows = list,
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = userbll.GetModel(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(Sys_UserModel userEntity, Sys_UserLogOnModel userLogOnEntity, string keyValue)
        {

         
            if (!string.IsNullOrEmpty(keyValue))
            {
                userEntity.F_Id = keyValue;
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                if (LoginInfo != null)
                {
                    userEntity.F_LastModifyUserId = LoginInfo.UserId;
                }
                userEntity.F_LastModifyTime = DateTime.Now;
                userbll.Update(userEntity);
            }
            else
            {
                userEntity.F_Id = Common.GuId();
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                if (LoginInfo != null)
                {
                    userEntity.F_CreatorUserId = LoginInfo.UserId;
                }
                userEntity.F_CreatorTime = DateTime.Now;
                userLogOnEntity.F_Id = userEntity.F_Id;
                userLogOnEntity.F_UserId = userEntity.F_Id;
                userLogOnEntity.F_UserSecretkey = Md5.md5(Common.CreateNo(), 16).ToLower();
                userLogOnEntity.F_UserPassword = Md5.md5(DESEncrypt.Encrypt(Md5.md5(userLogOnEntity.F_UserPassword, 32).ToLower(), userLogOnEntity.F_UserSecretkey).ToLower(), 32).ToLower();
                userbll.Add(userEntity);
                ulbll.Add(userLogOnEntity);
            }
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            userbll.Delete(keyValue);
            return Success("删除成功。");
        }
        [HttpGet]
        public ActionResult RevisePassword()
        {
            return View();
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitRevisePassword(string userPassword, string keyValue)
        {
            Sys_UserLogOnModel userLogOnEntity = new Sys_UserLogOnModel();
            userLogOnEntity.F_Id = keyValue;
            userLogOnEntity.F_UserSecretkey = Md5.md5(Common.CreateNo(), 16).ToLower();
            userLogOnEntity.F_UserPassword = Md5.md5(DESEncrypt.Encrypt(Md5.md5(userPassword, 32).ToLower(), userLogOnEntity.F_UserSecretkey).ToLower(), 32).ToLower();
            ulbll.Update(userLogOnEntity);
            return Success("重置密码成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DisabledAccount(string keyValue)
        {
            Sys_UserModel userEntity = new Sys_UserModel();
            userEntity = userbll.GetModel(keyValue);
            userEntity.F_EnabledMark = false;
            userbll.Update(userEntity);
            return Success("账户禁用成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult EnabledAccount(string keyValue)
        {
            Sys_UserModel userEntity = new Sys_UserModel();
            userEntity = userbll.GetModel(keyValue);
            userEntity.F_EnabledMark = true;
            userbll.Update(userEntity);
            return Success("账户启用成功。");
        }

        [HttpGet]
        public ActionResult Info()
        {
            return View();
        }

    }
}