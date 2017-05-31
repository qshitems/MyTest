/**  版本信息模板在安装目录下，可自行修改。
* Sys_ModuleFormInstanceDAL.cs
*
* 功 能： N/A
* 类 名： Sys_ModuleFormInstanceDAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/5/19 10:46:53   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Code;
namespace MyTest.DAL
{
	/// <summary>
	/// 数据访问类:Sys_ModuleFormInstanceDAL
	/// </summary>
	public partial class Sys_ModuleFormInstanceDAL
	{
		public Sys_ModuleFormInstanceDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string F_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sys_ModuleFormInstance");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
			parameters[0].Value = F_Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyTest.Model.Sys_ModuleFormInstanceModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_ModuleFormInstance(");
			strSql.Append("F_Id,F_FormId,F_ObjectId,F_InstanceJson,F_SortCode,F_CreatorTime,F_CreatorUserId)");
			strSql.Append(" values (");
			strSql.Append("@F_Id,@F_FormId,@F_ObjectId,@F_InstanceJson,@F_SortCode,@F_CreatorTime,@F_CreatorUserId)");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50),
					new SqlParameter("@F_FormId", SqlDbType.VarChar,50),
					new SqlParameter("@F_ObjectId", SqlDbType.VarChar,50),
					new SqlParameter("@F_InstanceJson", SqlDbType.VarChar,-1),
					new SqlParameter("@F_SortCode", SqlDbType.Int,4),
					new SqlParameter("@F_CreatorTime", SqlDbType.DateTime),
					new SqlParameter("@F_CreatorUserId", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_Id;
			parameters[1].Value = model.F_FormId;
			parameters[2].Value = model.F_ObjectId;
			parameters[3].Value = model.F_InstanceJson;
			parameters[4].Value = model.F_SortCode;
			parameters[5].Value = model.F_CreatorTime;
			parameters[6].Value = model.F_CreatorUserId;

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
		public bool Update(MyTest.Model.Sys_ModuleFormInstanceModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sys_ModuleFormInstance set ");
			strSql.Append("F_FormId=@F_FormId,");
			strSql.Append("F_ObjectId=@F_ObjectId,");
			strSql.Append("F_InstanceJson=@F_InstanceJson,");
			strSql.Append("F_SortCode=@F_SortCode,");
			strSql.Append("F_CreatorTime=@F_CreatorTime,");
			strSql.Append("F_CreatorUserId=@F_CreatorUserId");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_FormId", SqlDbType.VarChar,50),
					new SqlParameter("@F_ObjectId", SqlDbType.VarChar,50),
					new SqlParameter("@F_InstanceJson", SqlDbType.VarChar,-1),
					new SqlParameter("@F_SortCode", SqlDbType.Int,4),
					new SqlParameter("@F_CreatorTime", SqlDbType.DateTime),
					new SqlParameter("@F_CreatorUserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_FormId;
			parameters[1].Value = model.F_ObjectId;
			parameters[2].Value = model.F_InstanceJson;
			parameters[3].Value = model.F_SortCode;
			parameters[4].Value = model.F_CreatorTime;
			parameters[5].Value = model.F_CreatorUserId;
			parameters[6].Value = model.F_Id;

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
			strSql.Append("delete from Sys_ModuleFormInstance ");
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
			strSql.Append("delete from Sys_ModuleFormInstance ");
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
		public MyTest.Model.Sys_ModuleFormInstanceModel GetModel(string F_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_Id,F_FormId,F_ObjectId,F_InstanceJson,F_SortCode,F_CreatorTime,F_CreatorUserId from Sys_ModuleFormInstance ");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
			parameters[0].Value = F_Id;

			MyTest.Model.Sys_ModuleFormInstanceModel model=new MyTest.Model.Sys_ModuleFormInstanceModel();
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
		public MyTest.Model.Sys_ModuleFormInstanceModel DataRowToModel(DataRow row)
		{
			MyTest.Model.Sys_ModuleFormInstanceModel model=new MyTest.Model.Sys_ModuleFormInstanceModel();
			if (row != null)
			{
				if(row["F_Id"]!=null)
				{
					model.F_Id=row["F_Id"].ToString();
				}
				if(row["F_FormId"]!=null)
				{
					model.F_FormId=row["F_FormId"].ToString();
				}
				if(row["F_ObjectId"]!=null)
				{
					model.F_ObjectId=row["F_ObjectId"].ToString();
				}
				if(row["F_InstanceJson"]!=null)
				{
					model.F_InstanceJson=row["F_InstanceJson"].ToString();
				}
				if(row["F_SortCode"]!=null && row["F_SortCode"].ToString()!="")
				{
					model.F_SortCode=int.Parse(row["F_SortCode"].ToString());
				}
				if(row["F_CreatorTime"]!=null && row["F_CreatorTime"].ToString()!="")
				{
					model.F_CreatorTime=DateTime.Parse(row["F_CreatorTime"].ToString());
				}
				if(row["F_CreatorUserId"]!=null)
				{
					model.F_CreatorUserId=row["F_CreatorUserId"].ToString();
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
			strSql.Append("select F_Id,F_FormId,F_ObjectId,F_InstanceJson,F_SortCode,F_CreatorTime,F_CreatorUserId ");
			strSql.Append(" FROM Sys_ModuleFormInstance ");
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
			strSql.Append(" F_Id,F_FormId,F_ObjectId,F_InstanceJson,F_SortCode,F_CreatorTime,F_CreatorUserId ");
			strSql.Append(" FROM Sys_ModuleFormInstance ");
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
			strSql.Append("select count(1) FROM Sys_ModuleFormInstance ");
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
			strSql.Append(")AS Row, T.*  from Sys_ModuleFormInstance T ");
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
			parameters[0].Value = "Sys_ModuleFormInstance";
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

		#endregion  ExtensionMethod
	}
}

