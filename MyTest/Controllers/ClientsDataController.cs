using Code;
using MyTest.BLL;
using MyTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MyTest.Web.Controllers
{
    [HandlerLogin]
    public class ClientsDataController : Controller
    {
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetClientsDataJson()
        {
            var data = new
            {
                dataItems = this.GetDataItemList(),
                organize = this.GetOrganizeList(),
                role = this.GetRoleList(),
                duty = this.GetDutyList(),
                user = "",
                authorizeMenu = this.GetMenuList(),
                authorizeButton = this.GetMenuButtonList(),
            };
            return Content(data.ToJson());
        }
        private object GetDataItemList()
        {
            Sys_ItemsBLL ibll = new Sys_ItemsBLL();
            Sys_ItemsDetailBLL idbll = new Sys_ItemsDetailBLL();
            var itemdata = ibll.GetModelList("");
            Dictionary<string, object> dictionaryItem = new Dictionary<string, object>();
            foreach (var item in itemdata)
            {
                var dataItemList = idbll.GetModelList("F_ItemId='" + item.F_Id + "'");
                Dictionary<string, string> dictionaryItemList = new Dictionary<string, string>();
                foreach (var itemList in dataItemList)
                {
                    dictionaryItemList.Add(itemList.F_ItemCode, itemList.F_ItemName);
                }
                dictionaryItem.Add(item.F_EnCode, dictionaryItemList);
            }
            return dictionaryItem;
        }
        private object GetOrganizeList()
        {
            Sys_OrganizeBLL obll = new Sys_OrganizeBLL();
            var data = obll.GetModelList("");
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (var item in data)
            {
                var fieldItem = new
                {
                    encode = item.F_EnCode,
                    fullname = item.F_FullName
                };
                dictionary.Add(item.F_Id, fieldItem);
            }
            return dictionary;
        }
        private object GetRoleList()
        {
            Sys_RoleBLL rbll = new Sys_RoleBLL();
            var data = rbll.GetModelList("F_Category=1");
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (var item in data)
            {
                var fieldItem = new
                {
                    encode = item.F_EnCode,
                    fullname = item.F_FullName
                };
                dictionary.Add(item.F_Id, fieldItem);
            }
            return dictionary;
        }
        private object GetDutyList()
        {
            Sys_RoleBLL rbll = new Sys_RoleBLL();
            var data = rbll.GetModelList("F_Category=1");
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (var item in data)
            {
                var fieldItem = new
                {
                    encode = item.F_EnCode,
                    fullname = item.F_FullName
                };
                dictionary.Add(item.F_Id, fieldItem);
            }
            return dictionary;
        }
        private object GetMenuList()
        {
            Sys_ModuleBLL mbll = new Sys_ModuleBLL();
            var roleId = OperatorProvider.Provider.GetCurrent().RoleId;
            return ToMenuJson(GetMenuList(roleId), "0");
        }
        private string ToMenuJson(List<Sys_ModuleModel> data, string parentId)
        {
            StringBuilder sbJson = new StringBuilder();
            sbJson.Append("[");
            List<Sys_ModuleModel> entitys = data.Where(t => t.F_ParentId == parentId).ToList();
            if (entitys.Count > 0)
            {
                foreach (var item in entitys)
                {
                    string strJson = item.ToJson();
                    strJson = strJson.Insert(strJson.Length - 1, ",\"ChildNodes\":" + ToMenuJson(data, item.F_Id) + "");
                    sbJson.Append(strJson + ",");
                }
                sbJson = sbJson.Remove(sbJson.Length - 1, 1);
            }
            sbJson.Append("]");
            return sbJson.ToString();
        }

        public List<Sys_ModuleModel> GetMenuList(string roleId)
        {
            Sys_ModuleBLL mbll = new Sys_ModuleBLL();
            Sys_RoleAuthorizeBLL rhbll = new Sys_RoleAuthorizeBLL();
            var data = new List<Sys_ModuleModel>();
            if (OperatorProvider.Provider.GetCurrent().IsSystem)
            {
                data = mbll.GetModelList("");
            }
            else
            {
                var moduledata = mbll.GetModelList("");
                var authorizedata = rhbll.GetModelList("F_ObjectId = '" + roleId + "'  and F_ItemType = 1");

                foreach (var item in authorizedata)
                {
                    Sys_ModuleModel moduleEntity = mbll.GetModel(item.F_ItemId);
                    if (moduleEntity != null)
                    {
                        data.Add(moduleEntity);
                    }
                }
            }
            return data.OrderBy(t => t.F_SortCode).ToList();
        }
        public object GetMenuButtonList()
        {
            var roleId = OperatorProvider.Provider.GetCurrent().RoleId;
            var data = GetButtonList1(roleId);
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
           var dataModuleId = data.Distinct(new ExtList<Sys_ModuleButtonModel>("F_ModuleId"));
           foreach (var item in dataModuleId)
            {
                var buttonList = data.Where(t => t.F_ModuleId.Equals(item.F_ModuleId));
                dictionary.Add(item.F_ModuleId, buttonList);
            }
            return dictionary;
        }

        public List<Sys_ModuleButtonModel> GetButtonList1(string roleId)
        {
            Sys_ModuleButtonBLL mbbll = new Sys_ModuleButtonBLL();
            var data = new List<Sys_ModuleButtonModel>();
            Sys_RoleAuthorizeBLL rhbll = new Sys_RoleAuthorizeBLL();
            if (OperatorProvider.Provider.GetCurrent().IsSystem)
            {
                data = mbbll.GetModelList("");
            }
            else
            {
                var buttondata = mbbll.GetModelList("");
                var authorizedata = rhbll.GetModelList("F_ObjectId = '" + roleId + "'  and F_ItemType = 2");
                foreach (var item in authorizedata)
                {
                    Sys_ModuleButtonModel moduleButtonEntity = mbbll.GetModel(item.F_ItemId);
                    if (moduleButtonEntity != null)
                    {
                        data.Add(moduleButtonEntity);
                    }
                }
            }
            return data.OrderBy(t => t.F_SortCode).ToList();
        }
    }
}