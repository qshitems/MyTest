﻿/**  版本信息模板在安装目录下，可自行修改。
* Sys_RoleDAL.cs
*
* 功 能： N/A
* 类 名： Sys_RoleDAL
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
	/// 数据访问类:Sys_RoleDAL
	/// </summary>
	public partial class Sys_RoleDAL
	{
		public Sys_RoleDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string F_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sys_Role");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
			parameters[0].Value = F_Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyTest.Model.Sys_RoleModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_Role(");
			strSql.Append("F_Id,F_OrganizeId,F_Category,F_EnCode,F_FullName,F_Type,F_AllowEdit,F_AllowDelete,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId)");
			strSql.Append(" values (");
			strSql.Append("@F_Id,@F_OrganizeId,@F_Category,@F_EnCode,@F_FullName,@F_Type,@F_AllowEdit,@F_AllowDelete,@F_SortCode,@F_DeleteMark,@F_EnabledMark,@F_Description,@F_CreatorTime,@F_CreatorUserId,@F_LastModifyTime,@F_LastModifyUserId,@F_DeleteTime,@F_DeleteUserId)");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50),
					new SqlParameter("@F_OrganizeId", SqlDbType.VarChar,50),
					new SqlParameter("@F_Category", SqlDbType.Int,4),
					new SqlParameter("@F_EnCode", SqlDbType.VarChar,50),
					new SqlParameter("@F_FullName", SqlDbType.VarChar,50),
					new SqlParameter("@F_Type", SqlDbType.VarChar,50),
					new SqlParameter("@F_AllowEdit", SqlDbType.Bit,1),
					new SqlParameter("@F_AllowDelete", SqlDbType.Bit,1),
					new SqlParameter("@F_SortCode", SqlDbType.Int,4),
					new SqlParameter("@F_DeleteMark", SqlDbType.Bit,1),
					new SqlParameter("@F_EnabledMark", SqlDbType.Bit,1),
					new SqlParameter("@F_Description", SqlDbType.VarChar,500),
					new SqlParameter("@F_CreatorTime", SqlDbType.DateTime),
					new SqlParameter("@F_CreatorUserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_LastModifyTime", SqlDbType.DateTime),
					new SqlParameter("@F_LastModifyUserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_DeleteTime", SqlDbType.DateTime),
					new SqlParameter("@F_DeleteUserId", SqlDbType.VarChar,500)};
			parameters[0].Value = model.F_Id;
			parameters[1].Value = model.F_OrganizeId;
			parameters[2].Value = model.F_Category;
			parameters[3].Value = model.F_EnCode;
			parameters[4].Value = model.F_FullName;
			parameters[5].Value = model.F_Type;
			parameters[6].Value = model.F_AllowEdit;
			parameters[7].Value = model.F_AllowDelete;
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
		public bool Update(MyTest.Model.Sys_RoleModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sys_Role set ");
			strSql.Append("F_OrganizeId=@F_OrganizeId,");
			strSql.Append("F_Category=@F_Category,");
			strSql.Append("F_EnCode=@F_EnCode,");
			strSql.Append("F_FullName=@F_FullName,");
			strSql.Append("F_Type=@F_Type,");
			strSql.Append("F_AllowEdit=@F_AllowEdit,");
			strSql.Append("F_AllowDelete=@F_AllowDelete,");
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
					new SqlParameter("@F_OrganizeId", SqlDbType.VarChar,50),
					new SqlParameter("@F_Category", SqlDbType.Int,4),
					new SqlParameter("@F_EnCode", SqlDbType.VarChar,50),
					new SqlParameter("@F_FullName", SqlDbType.VarChar,50),
					new SqlParameter("@F_Type", SqlDbType.VarChar,50),
					new SqlParameter("@F_AllowEdit", SqlDbType.Bit,1),
					new SqlParameter("@F_AllowDelete", SqlDbType.Bit,1),
					new SqlParameter("@F_SortCode", SqlDbType.Int,4),
					new SqlParameter("@F_DeleteMark", SqlDbType.Bit,1),
					new SqlParameter("@F_EnabledMark", SqlDbType.Bit,1),
					new SqlParameter("@F_Description", SqlDbType.VarChar,500),
					new SqlParameter("@F_CreatorTime", SqlDbType.DateTime),
					new SqlParameter("@F_CreatorUserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_LastModifyTime", SqlDbType.DateTime),
					new SqlParameter("@F_LastModifyUserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_DeleteTime", SqlDbType.DateTime),
					new SqlParameter("@F_DeleteUserId", SqlDbType.VarChar,500),
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_OrganizeId;
			parameters[1].Value = model.F_Category;
			parameters[2].Value = model.F_EnCode;
			parameters[3].Value = model.F_FullName;
			parameters[4].Value = model.F_Type;
			parameters[5].Value = model.F_AllowEdit;
			parameters[6].Value = model.F_AllowDelete;
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
			strSql.Append("delete from Sys_Role ");
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
			strSql.Append("delete from Sys_Role ");
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
		public MyTest.Model.Sys_RoleModel GetModel(string F_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_Id,F_OrganizeId,F_Category,F_EnCode,F_FullName,F_Type,F_AllowEdit,F_AllowDelete,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId from Sys_Role ");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
			parameters[0].Value = F_Id;

			MyTest.Model.Sys_RoleModel model=new MyTest.Model.Sys_RoleModel();
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
		public MyTest.Model.Sys_RoleModel DataRowToModel(DataRow row)
		{
			MyTest.Model.Sys_RoleModel model=new MyTest.Model.Sys_RoleModel();
			if (row != null)
			{
				if(row["F_Id"]!=null)
				{
					model.F_Id=row["F_Id"].ToString();
				}
				if(row["F_OrganizeId"]!=null)
				{
					model.F_OrganizeId=row["F_OrganizeId"].ToString();
				}
				if(row["F_Category"]!=null && row["F_Category"].ToString()!="")
				{
					model.F_Category=int.Parse(row["F_Category"].ToString());
				}
				if(row["F_EnCode"]!=null)
				{
					model.F_EnCode=row["F_EnCode"].ToString();
				}
				if(row["F_FullName"]!=null)
				{
					model.F_FullName=row["F_FullName"].ToString();
				}
				if(row["F_Type"]!=null)
				{
					model.F_Type=row["F_Type"].ToString();
				}
				if(row["F_AllowEdit"]!=null && row["F_AllowEdit"].ToString()!="")
				{
					if((row["F_AllowEdit"].ToString()=="1")||(row["F_AllowEdit"].ToString().ToLower()=="true"))
					{
						model.F_AllowEdit=true;
					}
					else
					{
						model.F_AllowEdit=false;
					}
				}
				if(row["F_AllowDelete"]!=null && row["F_AllowDelete"].ToString()!="")
				{
					if((row["F_AllowDelete"].ToString()=="1")||(row["F_AllowDelete"].ToString().ToLower()=="true"))
					{
						model.F_AllowDelete=true;
					}
					else
					{
						model.F_AllowDelete=false;
					}
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
			strSql.Append("select F_Id,F_OrganizeId,F_Category,F_EnCode,F_FullName,F_Type,F_AllowEdit,F_AllowDelete,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId ");
			strSql.Append(" FROM Sys_Role ");
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
			strSql.Append(" F_Id,F_OrganizeId,F_Category,F_EnCode,F_FullName,F_Type,F_AllowEdit,F_AllowDelete,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId ");
			strSql.Append(" FROM Sys_Role ");
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
			strSql.Append("select count(1) FROM Sys_Role ");
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
			strSql.Append(")AS Row, T.*  from Sys_Role T ");
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
			parameters[0].Value = "Sys_Role";
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

