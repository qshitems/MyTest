
using Code;
using MyTest.BLL;
using MyTest.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MyTest.Web.Areas.SystemManage.Controllers
{
    public class RoleAuthorizeController : ControllerBase
    {
        private Sys_RoleAuthorizeBLL roleAuthorizebll = new Sys_RoleAuthorizeBLL();
        private Sys_ModuleBLL modulebll = new Sys_ModuleBLL();
        private Sys_ModuleButtonBLL moduleButtonbll = new Sys_ModuleButtonBLL();
        public ActionResult GetPermissionTree(string roleId)
        {
            var moduledata = modulebll.GetModelList("");
            var buttondata = moduleButtonbll.GetModelList("");
            var authorizedata = new List<Sys_RoleAuthorizeModel>();
            if (!string.IsNullOrEmpty(roleId))
            {
                authorizedata = roleAuthorizebll.GetModelList("F_ObjectId='" + roleId + "'");
            }
            var treeList = new List<TreeViewModel>();
            foreach (var item in moduledata)
            {
                TreeViewModel tree = new TreeViewModel();
                bool hasChildren = moduledata.Count(t => t.F_ParentId == item.F_Id) == 0 ? false : true;
                tree.id = item.F_Id;
                tree.text = item.F_FullName;
                tree.value = item.F_EnCode;
                tree.parentId = item.F_ParentId;
                tree.isexpand = true;
                tree.complete = true;
                tree.showcheck = true;
                tree.checkstate = authorizedata.Count(t => t.F_ItemId == item.F_Id);
                tree.hasChildren = true;
                tree.img = item.F_Icon == "" ? "" : item.F_Icon;
                treeList.Add(tree);
            }
            foreach (var item in buttondata)
            {
                TreeViewModel tree = new TreeViewModel();
                bool hasChildren = buttondata.Count(t => t.F_ParentId == item.F_Id) == 0 ? false : true;
                tree.id = item.F_Id;
                tree.text = item.F_FullName;
                tree.value = item.F_EnCode;
                tree.parentId = item.F_ParentId == "0" ? item.F_ModuleId : item.F_ParentId;
                tree.isexpand = true;
                tree.complete = true;
                tree.showcheck = true;
                tree.checkstate = authorizedata.Count(t => t.F_ItemId == item.F_Id);
                tree.hasChildren = hasChildren;
                tree.img = item.F_Icon == "" ? "" : item.F_Icon;
                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson());
        }
    }
}
