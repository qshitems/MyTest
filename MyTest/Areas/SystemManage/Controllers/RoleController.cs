
using MyTest.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Code;
using MyTest.Model;

namespace MyTest.Web.Areas.SystemManage.Controllers
{
    public class RoleController : ControllerBase
    {
        private Sys_RoleBLL rolebll = new Sys_RoleBLL();
        private Sys_RoleAuthorizeBLL roleAuthorizebll = new Sys_RoleAuthorizeBLL();
        private Sys_ModuleBLL modulebll = new Sys_ModuleBLL();
        private Sys_ModuleButtonBLL moduleButtonbll = new Sys_ModuleButtonBLL();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string keyword)
        {
            var data = rolebll.GetModelList("F_Category=1");
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = rolebll.GetModel(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(Sys_RoleModel roleEntity, string permissionIds, string keyValue)
        {

            if (!string.IsNullOrEmpty(keyValue))
            {
                roleEntity.F_Id = keyValue;
                rolebll.Update(roleEntity);
            }
            else
            {
                roleEntity.F_Id = Common.GuId();
                roleEntity.F_Category = 1;
                rolebll.Add(roleEntity);
            }
            var moduledata = modulebll.GetModelList("");
            var buttondata = moduleButtonbll.GetModelList("");
            var authorizedata = new List<Sys_RoleAuthorizeModel>();

            var perIds = permissionIds.Split(',');
            roleAuthorizebll.DeleteByObjectId(roleEntity.F_Id);
            foreach (var itemId in perIds)
            {
                Sys_RoleAuthorizeModel roleAuthorizeEntity = new Sys_RoleAuthorizeModel();
                roleAuthorizeEntity.F_Id = Common.GuId();
                roleAuthorizeEntity.F_ObjectType = 1;
                roleAuthorizeEntity.F_ObjectId = roleEntity.F_Id;
                roleAuthorizeEntity.F_ItemId = itemId;
                if (moduledata.Find(t => t.F_Id == itemId) != null)
                {
                    roleAuthorizeEntity.F_ItemType = 1;
                }
                if (buttondata.Find(t => t.F_Id == itemId) != null)
                {
                    roleAuthorizeEntity.F_ItemType = 2;
                }
                authorizedata.Add(roleAuthorizeEntity);
                roleAuthorizebll.Add(roleAuthorizeEntity);
            }


            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            rolebll.Delete(keyValue);
            roleAuthorizebll.DeleteByObjectId(keyValue);
            return Success("删除成功。");
        }
    }
}
