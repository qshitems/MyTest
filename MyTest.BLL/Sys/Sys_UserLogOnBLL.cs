/**  版本信息模板在安装目录下，可自行修改。
* Sys_UserLogOnBLL.cs
*
* 功 能： N/A
* 类 名： Sys_UserLogOnBLL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/5/19 10:46:54   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using Code;
using MyTest.Model;
namespace MyTest.BLL
{
	/// <summary>
	/// 用户登录信息表
	/// </summary>
	public partial class Sys_UserLogOnBLL
	{
		private readonly MyTest.DAL.Sys_UserLogOnDAL dal=new MyTest.DAL.Sys_UserLogOnDAL();
		public Sys_UserLogOnBLL()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string F_Id)
		{
			return dal.Exists(F_Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyTest.Model.Sys_UserLogOnModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MyTest.Model.Sys_UserLogOnModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_Id)
		{
			
			return dal.Delete(F_Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string F_Idlist )
		{
			return dal.DeleteList(F_Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MyTest.Model.Sys_UserLogOnModel GetModel(string F_Id)
		{
			
			return dal.GetModel(F_Id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public MyTest.Model.Sys_UserLogOnModel GetModelByCache(string F_Id)
		{
			
			string CacheKey = "Sys_UserLogOnModelModel-" + F_Id;
			object objModel = DataCache.GetCache(CacheKey);;
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(F_Id);
					if (objModel != null)
					{
						
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(30), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (MyTest.Model.Sys_UserLogOnModel)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MyTest.Model.Sys_UserLogOnModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MyTest.Model.Sys_UserLogOnModel> DataTableToList(DataTable dt)
		{
			List<MyTest.Model.Sys_UserLogOnModel> modelList = new List<MyTest.Model.Sys_UserLogOnModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				MyTest.Model.Sys_UserLogOnModel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

