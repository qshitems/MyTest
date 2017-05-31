/**  版本信息模板在安装目录下，可自行修改。
* Sys_UserLogOnDAL.cs
*
* 功 能： N/A
* 类 名： Sys_UserLogOnDAL
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
using System.Text;
using System.Data.SqlClient;
using Code;//Please add references
namespace MyTest.DAL
{
	/// <summary>
	/// 数据访问类:Sys_UserLogOnDAL
	/// </summary>
	public partial class Sys_UserLogOnDAL
	{
		public Sys_UserLogOnDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string F_Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sys_UserLogOn");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
			parameters[0].Value = F_Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyTest.Model.Sys_UserLogOnModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_UserLogOn(");
			strSql.Append("F_Id,F_UserId,F_UserPassword,F_UserSecretkey,F_AllowStartTime,F_AllowEndTime,F_LockStartDate,F_LockEndDate,F_FirstVisitTime,F_PreviousVisitTime,F_LastVisitTime,F_ChangePasswordDate,F_MultiUserLogin,F_LogOnCount,F_UserOnLine,F_Question,F_AnswerQuestion,F_CheckIPAddress,F_Language,F_Theme)");
			strSql.Append(" values (");
			strSql.Append("@F_Id,@F_UserId,@F_UserPassword,@F_UserSecretkey,@F_AllowStartTime,@F_AllowEndTime,@F_LockStartDate,@F_LockEndDate,@F_FirstVisitTime,@F_PreviousVisitTime,@F_LastVisitTime,@F_ChangePasswordDate,@F_MultiUserLogin,@F_LogOnCount,@F_UserOnLine,@F_Question,@F_AnswerQuestion,@F_CheckIPAddress,@F_Language,@F_Theme)");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50),
					new SqlParameter("@F_UserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_UserPassword", SqlDbType.VarChar,50),
					new SqlParameter("@F_UserSecretkey", SqlDbType.VarChar,50),
					new SqlParameter("@F_AllowStartTime", SqlDbType.DateTime),
					new SqlParameter("@F_AllowEndTime", SqlDbType.DateTime),
					new SqlParameter("@F_LockStartDate", SqlDbType.DateTime),
					new SqlParameter("@F_LockEndDate", SqlDbType.DateTime),
					new SqlParameter("@F_FirstVisitTime", SqlDbType.DateTime),
					new SqlParameter("@F_PreviousVisitTime", SqlDbType.DateTime),
					new SqlParameter("@F_LastVisitTime", SqlDbType.DateTime),
					new SqlParameter("@F_ChangePasswordDate", SqlDbType.DateTime),
					new SqlParameter("@F_MultiUserLogin", SqlDbType.Bit,1),
					new SqlParameter("@F_LogOnCount", SqlDbType.Int,4),
					new SqlParameter("@F_UserOnLine", SqlDbType.Bit,1),
					new SqlParameter("@F_Question", SqlDbType.VarChar,50),
					new SqlParameter("@F_AnswerQuestion", SqlDbType.VarChar,500),
					new SqlParameter("@F_CheckIPAddress", SqlDbType.Bit,1),
					new SqlParameter("@F_Language", SqlDbType.VarChar,50),
					new SqlParameter("@F_Theme", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_Id;
			parameters[1].Value = model.F_UserId;
			parameters[2].Value = model.F_UserPassword;
			parameters[3].Value = model.F_UserSecretkey;
			parameters[4].Value = model.F_AllowStartTime;
			parameters[5].Value = model.F_AllowEndTime;
			parameters[6].Value = model.F_LockStartDate;
			parameters[7].Value = model.F_LockEndDate;
			parameters[8].Value = model.F_FirstVisitTime;
			parameters[9].Value = model.F_PreviousVisitTime;
			parameters[10].Value = model.F_LastVisitTime;
			parameters[11].Value = model.F_ChangePasswordDate;
			parameters[12].Value = model.F_MultiUserLogin;
			parameters[13].Value = model.F_LogOnCount;
			parameters[14].Value = model.F_UserOnLine;
			parameters[15].Value = model.F_Question;
			parameters[16].Value = model.F_AnswerQuestion;
			parameters[17].Value = model.F_CheckIPAddress;
			parameters[18].Value = model.F_Language;
			parameters[19].Value = model.F_Theme;

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
		public bool Update(MyTest.Model.Sys_UserLogOnModel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sys_UserLogOn set ");
			strSql.Append("F_UserId=@F_UserId,");
			strSql.Append("F_UserPassword=@F_UserPassword,");
			strSql.Append("F_UserSecretkey=@F_UserSecretkey,");
			strSql.Append("F_AllowStartTime=@F_AllowStartTime,");
			strSql.Append("F_AllowEndTime=@F_AllowEndTime,");
			strSql.Append("F_LockStartDate=@F_LockStartDate,");
			strSql.Append("F_LockEndDate=@F_LockEndDate,");
			strSql.Append("F_FirstVisitTime=@F_FirstVisitTime,");
			strSql.Append("F_PreviousVisitTime=@F_PreviousVisitTime,");
			strSql.Append("F_LastVisitTime=@F_LastVisitTime,");
			strSql.Append("F_ChangePasswordDate=@F_ChangePasswordDate,");
			strSql.Append("F_MultiUserLogin=@F_MultiUserLogin,");
			strSql.Append("F_LogOnCount=@F_LogOnCount,");
			strSql.Append("F_UserOnLine=@F_UserOnLine,");
			strSql.Append("F_Question=@F_Question,");
			strSql.Append("F_AnswerQuestion=@F_AnswerQuestion,");
			strSql.Append("F_CheckIPAddress=@F_CheckIPAddress,");
			strSql.Append("F_Language=@F_Language,");
			strSql.Append("F_Theme=@F_Theme");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_UserId", SqlDbType.VarChar,50),
					new SqlParameter("@F_UserPassword", SqlDbType.VarChar,50),
					new SqlParameter("@F_UserSecretkey", SqlDbType.VarChar,50),
					new SqlParameter("@F_AllowStartTime", SqlDbType.DateTime),
					new SqlParameter("@F_AllowEndTime", SqlDbType.DateTime),
					new SqlParameter("@F_LockStartDate", SqlDbType.DateTime),
					new SqlParameter("@F_LockEndDate", SqlDbType.DateTime),
					new SqlParameter("@F_FirstVisitTime", SqlDbType.DateTime),
					new SqlParameter("@F_PreviousVisitTime", SqlDbType.DateTime),
					new SqlParameter("@F_LastVisitTime", SqlDbType.DateTime),
					new SqlParameter("@F_ChangePasswordDate", SqlDbType.DateTime),
					new SqlParameter("@F_MultiUserLogin", SqlDbType.Bit,1),
					new SqlParameter("@F_LogOnCount", SqlDbType.Int,4),
					new SqlParameter("@F_UserOnLine", SqlDbType.Bit,1),
					new SqlParameter("@F_Question", SqlDbType.VarChar,50),
					new SqlParameter("@F_AnswerQuestion", SqlDbType.VarChar,500),
					new SqlParameter("@F_CheckIPAddress", SqlDbType.Bit,1),
					new SqlParameter("@F_Language", SqlDbType.VarChar,50),
					new SqlParameter("@F_Theme", SqlDbType.VarChar,50),
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)};
			parameters[0].Value = model.F_UserId;
			parameters[1].Value = model.F_UserPassword;
			parameters[2].Value = model.F_UserSecretkey;
			parameters[3].Value = model.F_AllowStartTime;
			parameters[4].Value = model.F_AllowEndTime;
			parameters[5].Value = model.F_LockStartDate;
			parameters[6].Value = model.F_LockEndDate;
			parameters[7].Value = model.F_FirstVisitTime;
			parameters[8].Value = model.F_PreviousVisitTime;
			parameters[9].Value = model.F_LastVisitTime;
			parameters[10].Value = model.F_ChangePasswordDate;
			parameters[11].Value = model.F_MultiUserLogin;
			parameters[12].Value = model.F_LogOnCount;
			parameters[13].Value = model.F_UserOnLine;
			parameters[14].Value = model.F_Question;
			parameters[15].Value = model.F_AnswerQuestion;
			parameters[16].Value = model.F_CheckIPAddress;
			parameters[17].Value = model.F_Language;
			parameters[18].Value = model.F_Theme;
			parameters[19].Value = model.F_Id;

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
			strSql.Append("delete from Sys_UserLogOn ");
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
			strSql.Append("delete from Sys_UserLogOn ");
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
		public MyTest.Model.Sys_UserLogOnModel GetModel(string F_Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 F_Id,F_UserId,F_UserPassword,F_UserSecretkey,F_AllowStartTime,F_AllowEndTime,F_LockStartDate,F_LockEndDate,F_FirstVisitTime,F_PreviousVisitTime,F_LastVisitTime,F_ChangePasswordDate,F_MultiUserLogin,F_LogOnCount,F_UserOnLine,F_Question,F_AnswerQuestion,F_CheckIPAddress,F_Language,F_Theme from Sys_UserLogOn ");
			strSql.Append(" where F_Id=@F_Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
			parameters[0].Value = F_Id;

			MyTest.Model.Sys_UserLogOnModel model=new MyTest.Model.Sys_UserLogOnModel();
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
		public MyTest.Model.Sys_UserLogOnModel DataRowToModel(DataRow row)
		{
			MyTest.Model.Sys_UserLogOnModel model=new MyTest.Model.Sys_UserLogOnModel();
			if (row != null)
			{
				if(row["F_Id"]!=null)
				{
					model.F_Id=row["F_Id"].ToString();
				}
				if(row["F_UserId"]!=null)
				{
					model.F_UserId=row["F_UserId"].ToString();
				}
				if(row["F_UserPassword"]!=null)
				{
					model.F_UserPassword=row["F_UserPassword"].ToString();
				}
				if(row["F_UserSecretkey"]!=null)
				{
					model.F_UserSecretkey=row["F_UserSecretkey"].ToString();
				}
				if(row["F_AllowStartTime"]!=null && row["F_AllowStartTime"].ToString()!="")
				{
					model.F_AllowStartTime=DateTime.Parse(row["F_AllowStartTime"].ToString());
				}
				if(row["F_AllowEndTime"]!=null && row["F_AllowEndTime"].ToString()!="")
				{
					model.F_AllowEndTime=DateTime.Parse(row["F_AllowEndTime"].ToString());
				}
				if(row["F_LockStartDate"]!=null && row["F_LockStartDate"].ToString()!="")
				{
					model.F_LockStartDate=DateTime.Parse(row["F_LockStartDate"].ToString());
				}
				if(row["F_LockEndDate"]!=null && row["F_LockEndDate"].ToString()!="")
				{
					model.F_LockEndDate=DateTime.Parse(row["F_LockEndDate"].ToString());
				}
				if(row["F_FirstVisitTime"]!=null && row["F_FirstVisitTime"].ToString()!="")
				{
					model.F_FirstVisitTime=DateTime.Parse(row["F_FirstVisitTime"].ToString());
				}
				if(row["F_PreviousVisitTime"]!=null && row["F_PreviousVisitTime"].ToString()!="")
				{
					model.F_PreviousVisitTime=DateTime.Parse(row["F_PreviousVisitTime"].ToString());
				}
				if(row["F_LastVisitTime"]!=null && row["F_LastVisitTime"].ToString()!="")
				{
					model.F_LastVisitTime=DateTime.Parse(row["F_LastVisitTime"].ToString());
				}
				if(row["F_ChangePasswordDate"]!=null && row["F_ChangePasswordDate"].ToString()!="")
				{
					model.F_ChangePasswordDate=DateTime.Parse(row["F_ChangePasswordDate"].ToString());
				}
				if(row["F_MultiUserLogin"]!=null && row["F_MultiUserLogin"].ToString()!="")
				{
					if((row["F_MultiUserLogin"].ToString()=="1")||(row["F_MultiUserLogin"].ToString().ToLower()=="true"))
					{
						model.F_MultiUserLogin=true;
					}
					else
					{
						model.F_MultiUserLogin=false;
					}
				}
				if(row["F_LogOnCount"]!=null && row["F_LogOnCount"].ToString()!="")
				{
					model.F_LogOnCount=int.Parse(row["F_LogOnCount"].ToString());
				}
				if(row["F_UserOnLine"]!=null && row["F_UserOnLine"].ToString()!="")
				{
					if((row["F_UserOnLine"].ToString()=="1")||(row["F_UserOnLine"].ToString().ToLower()=="true"))
					{
						model.F_UserOnLine=true;
					}
					else
					{
						model.F_UserOnLine=false;
					}
				}
				if(row["F_Question"]!=null)
				{
					model.F_Question=row["F_Question"].ToString();
				}
				if(row["F_AnswerQuestion"]!=null)
				{
					model.F_AnswerQuestion=row["F_AnswerQuestion"].ToString();
				}
				if(row["F_CheckIPAddress"]!=null && row["F_CheckIPAddress"].ToString()!="")
				{
					if((row["F_CheckIPAddress"].ToString()=="1")||(row["F_CheckIPAddress"].ToString().ToLower()=="true"))
					{
						model.F_CheckIPAddress=true;
					}
					else
					{
						model.F_CheckIPAddress=false;
					}
				}
				if(row["F_Language"]!=null)
				{
					model.F_Language=row["F_Language"].ToString();
				}
				if(row["F_Theme"]!=null)
				{
					model.F_Theme=row["F_Theme"].ToString();
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
			strSql.Append("select F_Id,F_UserId,F_UserPassword,F_UserSecretkey,F_AllowStartTime,F_AllowEndTime,F_LockStartDate,F_LockEndDate,F_FirstVisitTime,F_PreviousVisitTime,F_LastVisitTime,F_ChangePasswordDate,F_MultiUserLogin,F_LogOnCount,F_UserOnLine,F_Question,F_AnswerQuestion,F_CheckIPAddress,F_Language,F_Theme ");
			strSql.Append(" FROM Sys_UserLogOn ");
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
			strSql.Append(" F_Id,F_UserId,F_UserPassword,F_UserSecretkey,F_AllowStartTime,F_AllowEndTime,F_LockStartDate,F_LockEndDate,F_FirstVisitTime,F_PreviousVisitTime,F_LastVisitTime,F_ChangePasswordDate,F_MultiUserLogin,F_LogOnCount,F_UserOnLine,F_Question,F_AnswerQuestion,F_CheckIPAddress,F_Language,F_Theme ");
			strSql.Append(" FROM Sys_UserLogOn ");
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
			strSql.Append("select count(1) FROM Sys_UserLogOn ");
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
			strSql.Append(")AS Row, T.*  from Sys_UserLogOn T ");
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
			parameters[0].Value = "Sys_UserLogOn";
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

