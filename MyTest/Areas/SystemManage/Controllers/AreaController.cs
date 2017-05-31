
using Code;
using MyTest.BLL;
using MyTest.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MyTest.Web.Areas.SystemManage.Controllers
{
    public class AreaController : ControllerBase
    {

        Sys_AreaBLL abll = new Sys_AreaBLL();
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeSelectJson()
        {
            var data = abll.GetModelList("");
            var treeList = new List<TreeSelectModel>();
            foreach (Sys_AreaModel item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.F_Id;
                treeModel.text = item.F_FullName;
                treeModel.parentId = item.F_ParentId;
                treeList.Add(treeModel);
            }
            return Content(treeList.TreeSelectJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeGridJson(string keyword)
        {
            var data = abll.GetModelList("");
            var treeList = new List<TreeGridModel>();
            foreach (Sys_AreaModel item in data)
            {
                TreeGridModel treeModel = new TreeGridModel();
                bool hasChildren = data.Count(t => t.F_ParentId == item.F_Id) == 0 ? false : true;
                treeModel.id = item.F_Id;
                treeModel.text = item.F_FullName;
                treeModel.isLeaf = hasChildren;
                treeModel.parentId = item.F_ParentId;
                treeModel.expanded = true;
                treeModel.entityJson = item.ToJson();
                treeList.Add(treeModel);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                treeList = treeList.TreeWhere(t => t.text.Contains(keyword), "id", "parentId");
            }
            return Content(treeList.TreeGridJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = abll.GetModel(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(Sys_AreaModel areaEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                abll.Update(areaEntity);
            }
            else
            {
                abll.Add(areaEntity);
            }
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            abll.Delete(keyValue);
            return Success("删除成功。");
        }
    }
}
