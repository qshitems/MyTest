
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Code;
using System.Collections.Generic;
namespace MyTest.DAL
{
	/// <summary>
	/// 数据访问类:Sys_ItemsDetailDAL
	/// </summary>
	public partial class Sys_ItemsDetailDAL
	{
		public Sys_ItemsDetailDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string F_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sys_ItemsDetail");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
			parameters[0].Value = F_Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyTest.Model.Sys_ItemsDetailModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_ItemsDetail(");
			strSql.Append("F_Id,F_ItemId,F_ParentId,F_ItemCode,F_ItemName,F_SimpleSpelling,F_IsDefault,F_Layers,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId)");
			strSql.Append(" values (");
			strSql.Append("@F_Id,@F_ItemId,@F_ParentId,@F_ItemCode,@F_ItemName,@F_SimpleSpelling,@F_IsDefault,@F_Layers,@F_SortCode,@F_DeleteMark,@F_EnabledMark,@F_Description,@F_CreatorTime,@F_CreatorUserId,@F_LastModifyTime,@F_LastModifyUserId,@F_DeleteTime,@F_DeleteUserId)");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50),
					new SqlParameter("@F_ItemId", SqlDbType.VarChar,50),
					new SqlParameter("@F_ParentId", SqlDbType.VarChar,50),
					new SqlParameter("@F_ItemCode", SqlDbType.VarChar,50),
					new SqlParameter("@F_ItemName", SqlDbType.VarChar,50),
					new SqlParameter("@F_SimpleSpelling", SqlDbType.VarChar,500),
					new SqlParameter("@F_IsDefault", SqlDbType.Bit,1),
					new SqlParameter("@F_Layers", SqlDbType.Int,4),
					new SqlParameter("@F_SortCode", SqlDbType.Int,4),
					new SqlParameter("@F_DeleteMark", SqlDbType.Bit,1),
					new SqlParameter("@F_EnabledMark", SqlDbType.Bit,1),
					new SqlParameter("@F_Description", SqlDbType.VarChar,500),
					new SqlParameter("@F_CreatorTime", SqlDbType.DateTime),
					new SqlParameter("@F_CreatorUserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_LastModifyTime", SqlDbType.DateTime),
					new SqlParameter("@F_LastModifyUserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_DeleteTime", SqlDbType.DateTime),
					new SqlParameter("@F_DeleteUserId", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_Id;
			parameters[1].Value = model.F_ItemId;
			parameters[2].Value = model.F_ParentId;
			parameters[3].Value = model.F_ItemCode;
			parameters[4].Value = model.F_ItemName;
			parameters[5].Value = model.F_SimpleSpelling;
			parameters[6].Value = model.F_IsDefault;
			parameters[7].Value = model.F_Layers;
			parameters[8].Value = model.F_SortCode;
			parameters[9].Value = model.F_DeleteMark;
			parameters[10].Value = model.F_EnabledMark;
			parameters[11].Value = model.F_Description;
			parameters[12].Value = model.F_CreatorTime;
			parameters[13].Value = model.F_CreatorUserId;
			parameters[14].Value = model.F_LastModifyTime;
			parameters[15].Value = model.F_LastModifyUserId;
			parameters[16].Value = model.F_DeleteTime;
			parameters[17].Value = model.F_DeleteUserId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MyTest.Model.Sys_ItemsDetailModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sys_ItemsDetail set ");
			strSql.Append("F_ItemId=@F_ItemId,");
			strSql.Append("F_ParentId=@F_ParentId,");
			strSql.Append("F_ItemCode=@F_ItemCode,");
			strSql.Append("F_ItemName=@F_ItemName,");
			strSql.Append("F_SimpleSpelling=@F_SimpleSpelling,");
			strSql.Append("F_IsDefault=@F_IsDefault,");
			strSql.Append("F_Layers=@F_Layers,");
			strSql.Append("F_SortCode=@F_SortCode,");
			strSql.Append("F_DeleteMark=@F_DeleteMark,");
			strSql.Append("F_EnabledMark=@F_EnabledMark,");
			strSql.Append("F_Description=@F_Description,");
			strSql.Append("F_CreatorTime=@F_CreatorTime,");
			strSql.Append("F_CreatorUserId=@F_CreatorUserId,");
			strSql.Append("F_LastModifyTime=@F_LastModifyTime,");
			strSql.Append("F_LastModifyUserId=@F_LastModifyUserId,");
			strSql.Append("F_DeleteTime=@F_DeleteTime,");
			strSql.Append("F_DeleteUserId=@F_DeleteUserId");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_ItemId", SqlDbType.VarChar,50),
					new SqlParameter("@F_ParentId", SqlDbType.VarChar,50),
					new SqlParameter("@F_ItemCode", SqlDbType.VarChar,50),
					new SqlParameter("@F_ItemName", SqlDbType.VarChar,50),
					new SqlParameter("@F_SimpleSpelling", SqlDbType.VarChar,500),
					new SqlParameter("@F_IsDefault", SqlDbType.Bit,1),
					new SqlParameter("@F_Layers", SqlDbType.Int,4),
					new SqlParameter("@F_SortCode", SqlDbType.Int,4),
					new SqlParameter("@F_DeleteMark", SqlDbType.Bit,1),
					new SqlParameter("@F_EnabledMark", SqlDbType.Bit,1),
					new SqlParameter("@F_Description", SqlDbType.VarChar,500),
					new SqlParameter("@F_CreatorTime", SqlDbType.DateTime),
					new SqlParameter("@F_CreatorUserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_LastModifyTime", SqlDbType.DateTime),
					new SqlParameter("@F_LastModifyUserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_DeleteTime", SqlDbType.DateTime),
					new SqlParameter("@F_DeleteUserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_ItemId;
			parameters[1].Value = model.F_ParentId;
			parameters[2].Value = model.F_ItemCode;
			parameters[3].Value = model.F_ItemName;
			parameters[4].Value = model.F_SimpleSpelling;
			parameters[5].Value = model.F_IsDefault;
			parameters[6].Value = model.F_Layers;
			parameters[7].Value = model.F_SortCode;
			parameters[8].Value = model.F_DeleteMark;
			parameters[9].Value = model.F_EnabledMark;
			parameters[10].Value = model.F_Description;
			parameters[11].Value = model.F_CreatorTime;
			parameters[12].Value = model.F_CreatorUserId;
			parameters[13].Value = model.F_LastModifyTime;
			parameters[14].Value = model.F_LastModifyUserId;
			parameters[15].Value = model.F_DeleteTime;
			parameters[16].Value = model.F_DeleteUserId;
			parameters[17].Value = model.F_Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_ItemsDetail ");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
			parameters[0].Value = F_Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string F_Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_ItemsDetail ");
			strSql.Append(" where F_Id in ("+F_Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MyTest.Model.Sys_ItemsDetailModel GetModel(string F_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_Id,F_ItemId,F_ParentId,F_ItemCode,F_ItemName,F_SimpleSpelling,F_IsDefault,F_Layers,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId from Sys_ItemsDetail ");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
			parameters[0].Value = F_Id;

			MyTest.Model.Sys_ItemsDetailModel model=new MyTest.Model.Sys_ItemsDetailModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MyTest.Model.Sys_ItemsDetailModel DataRowToModel(DataRow row)
		{
			MyTest.Model.Sys_ItemsDetailModel model=new MyTest.Model.Sys_ItemsDetailModel();
			if (row != null)
			{
				if(row["F_Id"]!=null)
				{
					model.F_Id=row["F_Id"].ToString();
				}
				if(row["F_ItemId"]!=null)
				{
					model.F_ItemId=row["F_ItemId"].ToString();
				}
				if(row["F_ParentId"]!=null)
				{
					model.F_ParentId=row["F_ParentId"].ToString();
				}
				if(row["F_ItemCode"]!=null)
				{
					model.F_ItemCode=row["F_ItemCode"].ToString();
				}
				if(row["F_ItemName"]!=null)
				{
					model.F_ItemName=row["F_ItemName"].ToString();
				}
				if(row["F_SimpleSpelling"]!=null)
				{
					model.F_SimpleSpelling=row["F_SimpleSpelling"].ToString();
				}
				if(row["F_IsDefault"]!=null && row["F_IsDefault"].ToString()!="")
				{
					if((row["F_IsDefault"].ToString()=="1")||(row["F_IsDefault"].ToString().ToLower()=="true"))
					{
						model.F_IsDefault=true;
					}
					else
					{
						model.F_IsDefault=false;
					}
				}
				if(row["F_Layers"]!=null && row["F_Layers"].ToString()!="")
				{
					model.F_Layers=int.Parse(row["F_Layers"].ToString());
				}
				if(row["F_SortCode"]!=null && row["F_SortCode"].ToString()!="")
				{
					model.F_SortCode=int.Parse(row["F_SortCode"].ToString());
				}
				if(row["F_DeleteMark"]!=null && row["F_DeleteMark"].ToString()!="")
				{
					if((row["F_DeleteMark"].ToString()=="1")||(row["F_DeleteMark"].ToString().ToLower()=="true"))
					{
						model.F_DeleteMark=true;
					}
					else
					{
						model.F_DeleteMark=false;
					}
				}
				if(row["F_EnabledMark"]!=null && row["F_EnabledMark"].ToString()!="")
				{
					if((row["F_EnabledMark"].ToString()=="1")||(row["F_EnabledMark"].ToString().ToLower()=="true"))
					{
						model.F_EnabledMark=true;
					}
					else
					{
						model.F_EnabledMark=false;
					}
				}
				if(row["F_Description"]!=null)
				{
					model.F_Description=row["F_Description"].ToString();
				}
				if(row["F_CreatorTime"]!=null && row["F_CreatorTime"].ToString()!="")
				{
					model.F_CreatorTime=DateTime.Parse(row["F_CreatorTime"].ToString());
				}
				if(row["F_CreatorUserId"]!=null)
				{
					model.F_CreatorUserId=row["F_CreatorUserId"].ToString();
				}
				if(row["F_LastModifyTime"]!=null && row["F_LastModifyTime"].ToString()!="")
				{
					model.F_LastModifyTime=DateTime.Parse(row["F_LastModifyTime"].ToString());
				}
				if(row["F_LastModifyUserId"]!=null)
				{
					model.F_LastModifyUserId=row["F_LastModifyUserId"].ToString();
				}
				if(row["F_DeleteTime"]!=null && row["F_DeleteTime"].ToString()!="")
				{
					model.F_DeleteTime=DateTime.Parse(row["F_DeleteTime"].ToString());
				}
				if(row["F_DeleteUserId"]!=null)
				{
					model.F_DeleteUserId=row["F_DeleteUserId"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select F_Id,F_ItemId,F_ParentId,F_ItemCode,F_ItemName,F_SimpleSpelling,F_IsDefault,F_Layers,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId ");
			strSql.Append(" FROM Sys_ItemsDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" F_Id,F_ItemId,F_ParentId,F_ItemCode,F_ItemName,F_SimpleSpelling,F_IsDefault,F_Layers,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId ");
			strSql.Append(" FROM Sys_ItemsDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Sys_ItemsDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.F_Id desc");
			}
			strSql.Append(")AS Row, T.*  from Sys_ItemsDetail T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Sys_ItemsDetail";
			parameters[1].Value = "F_Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod


        public List<MyTest.Model.Sys_ItemsDetailModel> GetItemList(string enCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT  d.*
                            FROM    Sys_ItemsDetail d
                                    INNER  JOIN Sys_Items i ON i.F_Id = d.F_ItemId
                            WHERE   1 = 1  AND i.F_EnCode = '"+enCode+"'    AND d.F_EnabledMark = 1     AND d.F_DeleteMark = 0                          ORDER BY d.F_SortCode ASC");
            return BaseDal.ExecuteReaderReturnListT<MyTest.Model.Sys_ItemsDetailModel>(strSql.ToString());
        }


		#endregion  ExtensionMethod
	}
}

