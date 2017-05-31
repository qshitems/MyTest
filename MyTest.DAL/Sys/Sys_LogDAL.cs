/**  版本信息模板在安装目录下，可自行修改。
* Sys_LogDAL.cs
*
* 功 能： N/A
* 类 名： Sys_LogDAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/5/19 10:46:51   N/A    初版
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
	/// 数据访问类:Sys_LogDAL
	/// </summary>
	public partial class Sys_LogDAL
	{
		public Sys_LogDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string F_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sys_Log");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
			parameters[0].Value = F_Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyTest.Model.Sys_LogModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_Log(");
			strSql.Append("F_Id,F_Date,F_Account,F_NickName,F_Type,F_IPAddress,F_IPAddressName,F_ModuleId,F_ModuleName,F_Result,F_Description,F_CreatorTime,F_CreatorUserId)");
			strSql.Append(" values (");
			strSql.Append("@F_Id,@F_Date,@F_Account,@F_NickName,@F_Type,@F_IPAddress,@F_IPAddressName,@F_ModuleId,@F_ModuleName,@F_Result,@F_Description,@F_CreatorTime,@F_CreatorUserId)");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50),
					new SqlParameter("@F_Date", SqlDbType.DateTime),
					new SqlParameter("@F_Account", SqlDbType.VarChar,50),
					new SqlParameter("@F_NickName", SqlDbType.VarChar,50),
					new SqlParameter("@F_Type", SqlDbType.VarChar,50),
					new SqlParameter("@F_IPAddress", SqlDbType.VarChar,50),
					new SqlParameter("@F_IPAddressName", SqlDbType.VarChar,50),
					new SqlParameter("@F_ModuleId", SqlDbType.VarChar,50),
					new SqlParameter("@F_ModuleName", SqlDbType.VarChar,50),
					new SqlParameter("@F_Result", SqlDbType.Bit,1),
					new SqlParameter("@F_Description", SqlDbType.VarChar,500),
					new SqlParameter("@F_CreatorTime", SqlDbType.DateTime),
					new SqlParameter("@F_CreatorUserId", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_Id;
			parameters[1].Value = model.F_Date;
			parameters[2].Value = model.F_Account;
			parameters[3].Value = model.F_NickName;
			parameters[4].Value = model.F_Type;
			parameters[5].Value = model.F_IPAddress;
			parameters[6].Value = model.F_IPAddressName;
			parameters[7].Value = model.F_ModuleId;
			parameters[8].Value = model.F_ModuleName;
			parameters[9].Value = model.F_Result;
			parameters[10].Value = model.F_Description;
			parameters[11].Value = model.F_CreatorTime;
			parameters[12].Value = model.F_CreatorUserId;

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
		public bool Update(MyTest.Model.Sys_LogModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sys_Log set ");
			strSql.Append("F_Date=@F_Date,");
			strSql.Append("F_Account=@F_Account,");
			strSql.Append("F_NickName=@F_NickName,");
			strSql.Append("F_Type=@F_Type,");
			strSql.Append("F_IPAddress=@F_IPAddress,");
			strSql.Append("F_IPAddressName=@F_IPAddressName,");
			strSql.Append("F_ModuleId=@F_ModuleId,");
			strSql.Append("F_ModuleName=@F_ModuleName,");
			strSql.Append("F_Result=@F_Result,");
			strSql.Append("F_Description=@F_Description,");
			strSql.Append("F_CreatorTime=@F_CreatorTime,");
			strSql.Append("F_CreatorUserId=@F_CreatorUserId");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Date", SqlDbType.DateTime),
					new SqlParameter("@F_Account", SqlDbType.VarChar,50),
					new SqlParameter("@F_NickName", SqlDbType.VarChar,50),
					new SqlParameter("@F_Type", SqlDbType.VarChar,50),
					new SqlParameter("@F_IPAddress", SqlDbType.VarChar,50),
					new SqlParameter("@F_IPAddressName", SqlDbType.VarChar,50),
					new SqlParameter("@F_ModuleId", SqlDbType.VarChar,50),
					new SqlParameter("@F_ModuleName", SqlDbType.VarChar,50),
					new SqlParameter("@F_Result", SqlDbType.Bit,1),
					new SqlParameter("@F_Description", SqlDbType.VarChar,500),
					new SqlParameter("@F_CreatorTime", SqlDbType.DateTime),
					new SqlParameter("@F_CreatorUserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_Date;
			parameters[1].Value = model.F_Account;
			parameters[2].Value = model.F_NickName;
			parameters[3].Value = model.F_Type;
			parameters[4].Value = model.F_IPAddress;
			parameters[5].Value = model.F_IPAddressName;
			parameters[6].Value = model.F_ModuleId;
			parameters[7].Value = model.F_ModuleName;
			parameters[8].Value = model.F_Result;
			parameters[9].Value = model.F_Description;
			parameters[10].Value = model.F_CreatorTime;
			parameters[11].Value = model.F_CreatorUserId;
			parameters[12].Value = model.F_Id;

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
			strSql.Append("delete from Sys_Log ");
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
			strSql.Append("delete from Sys_Log ");
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
		public MyTest.Model.Sys_LogModel GetModel(string F_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_Id,F_Date,F_Account,F_NickName,F_Type,F_IPAddress,F_IPAddressName,F_ModuleId,F_ModuleName,F_Result,F_Description,F_CreatorTime,F_CreatorUserId from Sys_Log ");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
			parameters[0].Value = F_Id;

			MyTest.Model.Sys_LogModel model=new MyTest.Model.Sys_LogModel();
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
		public MyTest.Model.Sys_LogModel DataRowToModel(DataRow row)
		{
			MyTest.Model.Sys_LogModel model=new MyTest.Model.Sys_LogModel();
			if (row != null)
			{
				if(row["F_Id"]!=null)
				{
					model.F_Id=row["F_Id"].ToString();
				}
				if(row["F_Date"]!=null && row["F_Date"].ToString()!="")
				{
					model.F_Date=DateTime.Parse(row["F_Date"].ToString());
				}
				if(row["F_Account"]!=null)
				{
					model.F_Account=row["F_Account"].ToString();
				}
				if(row["F_NickName"]!=null)
				{
					model.F_NickName=row["F_NickName"].ToString();
				}
				if(row["F_Type"]!=null)
				{
					model.F_Type=row["F_Type"].ToString();
				}
				if(row["F_IPAddress"]!=null)
				{
					model.F_IPAddress=row["F_IPAddress"].ToString();
				}
				if(row["F_IPAddressName"]!=null)
				{
					model.F_IPAddressName=row["F_IPAddressName"].ToString();
				}
				if(row["F_ModuleId"]!=null)
				{
					model.F_ModuleId=row["F_ModuleId"].ToString();
				}
				if(row["F_ModuleName"]!=null)
				{
					model.F_ModuleName=row["F_ModuleName"].ToString();
				}
				if(row["F_Result"]!=null && row["F_Result"].ToString()!="")
				{
					if((row["F_Result"].ToString()=="1")||(row["F_Result"].ToString().ToLower()=="true"))
					{
						model.F_Result=true;
					}
					else
					{
						model.F_Result=false;
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select F_Id,F_Date,F_Account,F_NickName,F_Type,F_IPAddress,F_IPAddressName,F_ModuleId,F_ModuleName,F_Result,F_Description,F_CreatorTime,F_CreatorUserId ");
			strSql.Append(" FROM Sys_Log ");
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
			strSql.Append(" F_Id,F_Date,F_Account,F_NickName,F_Type,F_IPAddress,F_IPAddressName,F_ModuleId,F_ModuleName,F_Result,F_Description,F_CreatorTime,F_CreatorUserId ");
			strSql.Append(" FROM Sys_Log ");
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
			strSql.Append("select count(1) FROM Sys_Log ");
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
			strSql.Append(")AS Row, T.*  from Sys_Log T ");
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
			parameters[0].Value = "Sys_Log";
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

