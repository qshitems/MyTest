using Code;
using MyTest.BLL;
using MyTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;



namespace MyTest.Web.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public virtual ActionResult Index()
        {
            var test = string.Format("{0:E2}", 1);
            return View();
        }
        [HttpGet]
        public ActionResult GetAuthCode()
        {
            return File(new VerifyCode().GetVerifyCode(), @"image/Gif");
        }

        [HttpGet]
        public ActionResult OutLogin()
        {

            Sys_LogBLL bll = new Sys_LogBLL();
            Sys_LogModel lmodel = new Sys_LogModel
            {

                F_ModuleName = "系统登录",
                F_Type = DbLogType.Exit.ToString(),
                F_Account = OperatorProvider.Provider.GetCurrent().UserCode,
                F_NickName = OperatorProvider.Provider.GetCurrent().UserName,
                F_Result = true,
                F_Description = "安全退出系统",
            };

            Session.Abandon();
            Session.Clear();
            OperatorProvider.Provider.RemoveCurrent();
            return RedirectToAction("Index", "Login");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult CheckLogin(string username, string password, string code)
        {

            Sys_UserBLL userbll = new Sys_UserBLL();
            Sys_UserModel usermodel = new Sys_UserModel();
            Sys_LogModel logModel = new Sys_LogModel();
            Sys_LogBLL logbll = new Sys_LogBLL();
            logModel.F_ModuleName = "系统登录";
            logModel.F_Type = DbLogType.Login.ToString();
            try
            {
                //if (Session["nfine_session_verifycode"].IsEmpty() || Md5.md5(code.ToLower(), 16) != Session["nfine_session_verifycode"].ToString())
                //{
                //    throw new Exception("验证码错误，请重新输入");
                //}

                usermodel = userbll.CheckLogin(username, password);
                if (usermodel != null)
                {
                    OperatorModel operatorModel = new OperatorModel();
                    operatorModel.UserId = usermodel.F_Id;
                    operatorModel.UserCode = usermodel.F_Account;
                    operatorModel.UserName = usermodel.F_RealName;
                    operatorModel.CompanyId = usermodel.F_OrganizeId;
                    operatorModel.DepartmentId = usermodel.F_DepartmentId;
                    operatorModel.RoleId = usermodel.F_RoleId;
                    operatorModel.LoginIPAddress = Net.Ip;
                    operatorModel.LoginIPAddressName = Net.GetLocation(operatorModel.LoginIPAddress);
                    operatorModel.LoginTime = DateTime.Now;
                    operatorModel.LoginToken = DESEncrypt.Encrypt(Guid.NewGuid().ToString());
                    if (usermodel.F_Account == "admin")
                    {
                        operatorModel.IsSystem = true;
                    }
                    else
                    {
                        operatorModel.IsSystem = false;
                    }
                    OperatorProvider.Provider.AddCurrent(operatorModel);
                    logModel.F_Account = usermodel.F_Account;
                    logModel.F_NickName = usermodel.F_RealName;
                    logModel.F_Result = true;
                    logModel.F_Description = "登录成功";
                    logModel.F_Id = Common.GuId();
                    logModel.F_Date = DateTime.Now;
                    logModel.F_IPAddress = Net.Ip;
                    logModel.F_IPAddressName = Net.GetLocation(logModel.F_IPAddress);
                    logbll.Add(logModel);
                }
                return Content(new AjaxResult { state = ResultType.success.ToString(), message = "登录成功。" }.ToJson());
            }
            catch (Exception ex)
            {
                logModel.F_Account = username;
                logModel.F_NickName = username;
                logModel.F_Result = false;
                logModel.F_Description = "登录失败，" + ex.Message;
                logModel.F_Id = Common.GuId();
                logModel.F_Date = DateTime.Now;
                logModel.F_IPAddress = Net.Ip;
                logModel.F_IPAddressName = Net.GetLocation(logModel.F_IPAddress);
                logbll.Add(logModel);
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = ex.Message }.ToJson());
            }
        }



    }
}