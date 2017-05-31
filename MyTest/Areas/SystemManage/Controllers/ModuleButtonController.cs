
using Code;
using MyTest.BLL;
using MyTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MyTest.Web.Areas.SystemManage.Controllers
{
    public class ModuleButtonController : ControllerBase
    {
        Sys_ModuleBLL mbll = new Sys_ModuleBLL();
        Sys_ModuleButtonBLL mbbll = new Sys_ModuleButtonBLL();
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeSelectJson(string moduleId)
        {
            var data = mbbll.GetModelList("F_ModuleId='" + moduleId + "'");
            var treeList = new List<TreeSelectModel>();
            foreach (var item in data)
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
        public ActionResult GetTreeGridJson(string moduleId)
        {
            var data = mbbll.GetModelList("F_ModuleId='" + moduleId + "'");
            var treeList = new List<TreeGridModel>();
            foreach (var item in data)
            {
                TreeGridModel treeModel = new TreeGridModel();
                bool hasChildren = data.Count(t => t.F_ParentId == item.F_Id) == 0 ? false : true;
                treeModel.id = item.F_Id;
                treeModel.isLeaf = hasChildren;
                treeModel.parentId = item.F_ParentId;
                treeModel.expanded = hasChildren;
                treeModel.entityJson = item.ToJson();
                treeList.Add(treeModel);
            }
            return Content(treeList.TreeGridJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = mbbll.GetModel(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(Sys_ModuleButtonModel moduleButtonEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                moduleButtonEntity.F_Id = keyValue;
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                if (LoginInfo != null)
                {
                    moduleButtonEntity.F_LastModifyUserId = LoginInfo.UserId;
                }
                moduleButtonEntity.F_LastModifyTime = DateTime.Now;
                mbbll.Update(moduleButtonEntity);
            }
            else
            {
                moduleButtonEntity.F_Id = Common.GuId();
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                if (LoginInfo != null)
                {
                    moduleButtonEntity.F_CreatorUserId = LoginInfo.UserId;
                }
                moduleButtonEntity.F_CreatorTime = DateTime.Now;
                mbbll.Add(moduleButtonEntity);
            }
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            mbbll.Delete(keyValue);
            return Success("删除成功。");
        }
        [HttpGet]
        public ActionResult CloneButton()
        {
            return View();
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetCloneButtonTreeJson()
        {
            var moduledata = mbll.GetModelList("");
            var buttondata = mbbll.GetModelList("");
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
                tree.hasChildren = true;
                treeList.Add(tree);
            }
            foreach (var item in buttondata)
            {
                TreeViewModel tree = new TreeViewModel();
                bool hasChildren = buttondata.Count(t => t.F_ParentId == item.F_Id) == 0 ? false : true;
                tree.id = item.F_Id;
                tree.text = item.F_FullName;
                tree.value = item.F_EnCode;
                if (item.F_ParentId == "0")
                {
                    tree.parentId = item.F_ModuleId;
                }
                else
                {
                    tree.parentId = item.F_ParentId;
                }
                tree.isexpand = true;
                tree.complete = true;
                tree.showcheck = true;
                tree.hasChildren = hasChildren;
                if (item.F_Icon != "")
                {
                    tree.img = item.F_Icon;
                }
                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult SubmitCloneButton(string moduleId, string Ids)
        {
            string[] ArrayId = Ids.Split(',');
            var data = mbbll.GetModelList("");
            foreach (string item in ArrayId)
            {
                var moduleButtonEntity = data.Find(t => t.F_Id == item);
                moduleButtonEntity.F_Id = Common.GuId();
                moduleButtonEntity.F_ModuleId = moduleId;
                mbbll.Add(moduleButtonEntity);
            }
            return Success("克隆成功。");
        }
    }
}
