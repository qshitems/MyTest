
using System;
using System.Data;
using System.Collections.Generic;
using Code;
using MyTest.Model;
namespace MyTest.BLL
{
	/// <summary>
	/// 选项明细表
	/// </summary>
	public partial class Sys_ItemsDetailBLL
	{
		private readonly MyTest.DAL.Sys_ItemsDetailDAL dal=new MyTest.DAL.Sys_ItemsDetailDAL();
		public Sys_ItemsDetailBLL()
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
		public bool Add(MyTest.Model.Sys_ItemsDetailModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MyTest.Model.Sys_ItemsDetailModel model)
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
		public MyTest.Model.Sys_ItemsDetailModel GetModel(string F_Id)
		{
			
			return dal.GetModel(F_Id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public MyTest.Model.Sys_ItemsDetailModel GetModelByCache(string F_Id)
		{
			
			string CacheKey = "Sys_ItemsDetailModelModel-" + F_Id;
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
			return (MyTest.Model.Sys_ItemsDetailModel)objModel;
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
		public List<MyTest.Model.Sys_ItemsDetailModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MyTest.Model.Sys_ItemsDetailModel> DataTableToList(DataTable dt)
		{
			List<MyTest.Model.Sys_ItemsDetailModel> modelList = new List<MyTest.Model.Sys_ItemsDetailModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				MyTest.Model.Sys_ItemsDetailModel model;
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
        public List<MyTest.Model.Sys_ItemsDetailModel> GetItemList(string enCode)
        {
            return dal.GetItemList(enCode);
        }
		#endregion  ExtensionMethod
	}
}

