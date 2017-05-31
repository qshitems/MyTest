
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Code;
using MyTest.Model;
using System.Collections.Generic;//Please add references
namespace MyTest.DAL
{
    /// <summary>
    /// 数据访问类:Sys_UserDAL
    /// </summary>
    public partial class Sys_UserDAL
    {
        public Sys_UserDAL()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string F_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_User");
            strSql.Append(" where F_Id=@F_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
            parameters[0].Value = F_Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(MyTest.Model.Sys_UserModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_User(");
            strSql.Append("F_Id,F_Account,F_RealName,F_NickName,F_HeadIcon,F_Gender,F_Birthday,F_MobilePhone,F_Email,F_WeChat,F_ManagerId,F_SecurityLevel,F_Signature,F_OrganizeId,F_DepartmentId,F_RoleId,F_DutyId,F_IsAdministrator,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId)");
            strSql.Append(" values (");
            strSql.Append("@F_Id,@F_Account,@F_RealName,@F_NickName,@F_HeadIcon,@F_Gender,@F_Birthday,@F_MobilePhone,@F_Email,@F_WeChat,@F_ManagerId,@F_SecurityLevel,@F_Signature,@F_OrganizeId,@F_DepartmentId,@F_RoleId,@F_DutyId,@F_IsAdministrator,@F_SortCode,@F_DeleteMark,@F_EnabledMark,@F_Description,@F_CreatorTime,@F_CreatorUserId,@F_LastModifyTime,@F_LastModifyUserId,@F_DeleteTime,@F_DeleteUserId)");
            SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50),
					new SqlParameter("@F_Account", SqlDbType.VarChar,50),
					new SqlParameter("@F_RealName", SqlDbType.VarChar,50),
					new SqlParameter("@F_NickName", SqlDbType.VarChar,50),
					new SqlParameter("@F_HeadIcon", SqlDbType.VarChar,50),
					new SqlParameter("@F_Gender", SqlDbType.Bit,1),
					new SqlParameter("@F_Birthday", SqlDbType.DateTime),
					new SqlParameter("@F_MobilePhone", SqlDbType.VarChar,20),
					new SqlParameter("@F_Email", SqlDbType.VarChar,50),
					new SqlParameter("@F_WeChat", SqlDbType.VarChar,50),
					new SqlParameter("@F_ManagerId", SqlDbType.VarChar,50),
					new SqlParameter("@F_SecurityLevel", SqlDbType.Int,4),
					new SqlParameter("@F_Signature", SqlDbType.VarChar,500),
					new SqlParameter("@F_OrganizeId", SqlDbType.VarChar,50),
					new SqlParameter("@F_DepartmentId", SqlDbType.VarChar,500),
					new SqlParameter("@F_RoleId", SqlDbType.VarChar,500),
					new SqlParameter("@F_DutyId", SqlDbType.VarChar,500),
					new SqlParameter("@F_IsAdministrator", SqlDbType.Bit,1),
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
            parameters[1].Value = model.F_Account;
            parameters[2].Value = model.F_RealName;
            parameters[3].Value = model.F_NickName;
            parameters[4].Value = model.F_HeadIcon;
            parameters[5].Value = model.F_Gender;
            parameters[6].Value = model.F_Birthday;
            parameters[7].Value = model.F_MobilePhone;
            parameters[8].Value = model.F_Email;
            parameters[9].Value = model.F_WeChat;
            parameters[10].Value = model.F_ManagerId;
            parameters[11].Value = model.F_SecurityLevel;
            parameters[12].Value = model.F_Signature;
            parameters[13].Value = model.F_OrganizeId;
            parameters[14].Value = model.F_DepartmentId;
            parameters[15].Value = model.F_RoleId;
            parameters[16].Value = model.F_DutyId;
            parameters[17].Value = model.F_IsAdministrator;
            parameters[18].Value = model.F_SortCode;
            parameters[19].Value = model.F_DeleteMark;
            parameters[20].Value = model.F_EnabledMark;
            parameters[21].Value = model.F_Description;
            parameters[22].Value = model.F_CreatorTime;
            parameters[23].Value = model.F_CreatorUserId;
            parameters[24].Value = model.F_LastModifyTime;
            parameters[25].Value = model.F_LastModifyUserId;
            parameters[26].Value = model.F_DeleteTime;
            parameters[27].Value = model.F_DeleteUserId;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(MyTest.Model.Sys_UserModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_User set ");
            strSql.Append("F_Account=@F_Account,");
            strSql.Append("F_RealName=@F_RealName,");
            strSql.Append("F_NickName=@F_NickName,");
            strSql.Append("F_HeadIcon=@F_HeadIcon,");
            strSql.Append("F_Gender=@F_Gender,");
            strSql.Append("F_Birthday=@F_Birthday,");
            strSql.Append("F_MobilePhone=@F_MobilePhone,");
            strSql.Append("F_Email=@F_Email,");
            strSql.Append("F_WeChat=@F_WeChat,");
            strSql.Append("F_ManagerId=@F_ManagerId,");
            strSql.Append("F_SecurityLevel=@F_SecurityLevel,");
            strSql.Append("F_Signature=@F_Signature,");
            strSql.Append("F_OrganizeId=@F_OrganizeId,");
            strSql.Append("F_DepartmentId=@F_DepartmentId,");
            strSql.Append("F_RoleId=@F_RoleId,");
            strSql.Append("F_DutyId=@F_DutyId,");
            strSql.Append("F_IsAdministrator=@F_IsAdministrator,");
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
					new SqlParameter("@F_Account", SqlDbType.VarChar,50),
					new SqlParameter("@F_RealName", SqlDbType.VarChar,50),
					new SqlParameter("@F_NickName", SqlDbType.VarChar,50),
					new SqlParameter("@F_HeadIcon", SqlDbType.VarChar,50),
					new SqlParameter("@F_Gender", SqlDbType.Bit,1),
					new SqlParameter("@F_Birthday", SqlDbType.DateTime),
					new SqlParameter("@F_MobilePhone", SqlDbType.VarChar,20),
					new SqlParameter("@F_Email", SqlDbType.VarChar,50),
					new SqlParameter("@F_WeChat", SqlDbType.VarChar,50),
					new SqlParameter("@F_ManagerId", SqlDbType.VarChar,50),
					new SqlParameter("@F_SecurityLevel", SqlDbType.Int,4),
					new SqlParameter("@F_Signature", SqlDbType.VarChar,500),
					new SqlParameter("@F_OrganizeId", SqlDbType.VarChar,50),
					new SqlParameter("@F_DepartmentId", SqlDbType.VarChar,500),
					new SqlParameter("@F_RoleId", SqlDbType.VarChar,500),
					new SqlParameter("@F_DutyId", SqlDbType.VarChar,500),
					new SqlParameter("@F_IsAdministrator", SqlDbType.Bit,1),
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
            parameters[0].Value = model.F_Account;
            parameters[1].Value = model.F_RealName;
            parameters[2].Value = model.F_NickName;
            parameters[3].Value = model.F_HeadIcon;
            parameters[4].Value = model.F_Gender;
            parameters[5].Value = model.F_Birthday;
            parameters[6].Value = model.F_MobilePhone;
            parameters[7].Value = model.F_Email;
            parameters[8].Value = model.F_WeChat;
            parameters[9].Value = model.F_ManagerId;
            parameters[10].Value = model.F_SecurityLevel;
            parameters[11].Value = model.F_Signature;
            parameters[12].Value = model.F_OrganizeId;
            parameters[13].Value = model.F_DepartmentId;
            parameters[14].Value = model.F_RoleId;
            parameters[15].Value = model.F_DutyId;
            parameters[16].Value = model.F_IsAdministrator;
            parameters[17].Value = model.F_SortCode;
            parameters[18].Value = model.F_DeleteMark;
            parameters[19].Value = model.F_EnabledMark;
            parameters[20].Value = model.F_Description;
            parameters[21].Value = model.F_CreatorTime;
            parameters[22].Value = model.F_CreatorUserId;
            parameters[23].Value = model.F_LastModifyTime;
            parameters[24].Value = model.F_LastModifyUserId;
            parameters[25].Value = model.F_DeleteTime;
            parameters[26].Value = model.F_DeleteUserId;
            parameters[27].Value = model.F_Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_User ");
            strSql.Append(" where F_Id=@F_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
            parameters[0].Value = F_Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string F_Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_User ");
            strSql.Append(" where F_Id in (" + F_Idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public MyTest.Model.Sys_UserModel GetModel(string F_Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 F_Id,F_Account,F_RealName,F_NickName,F_HeadIcon,F_Gender,F_Birthday,F_MobilePhone,F_Email,F_WeChat,F_ManagerId,F_SecurityLevel,F_Signature,F_OrganizeId,F_DepartmentId,F_RoleId,F_DutyId,F_IsAdministrator,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId from Sys_User ");
            strSql.Append(" where F_Id=@F_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@F_Id", SqlDbType.VarChar,50)			};
            parameters[0].Value = F_Id;

            MyTest.Model.Sys_UserModel model = new MyTest.Model.Sys_UserModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public MyTest.Model.Sys_UserModel DataRowToModel(DataRow row)
        {
            MyTest.Model.Sys_UserModel model = new MyTest.Model.Sys_UserModel();
            if (row != null)
            {
                if (row["F_Id"] != null)
                {
                    model.F_Id = row["F_Id"].ToString();
                }
                if (row["F_Account"] != null)
                {
                    model.F_Account = row["F_Account"].ToString();
                }
                if (row["F_RealName"] != null)
                {
                    model.F_RealName = row["F_RealName"].ToString();
                }
                if (row["F_NickName"] != null)
                {
                    model.F_NickName = row["F_NickName"].ToString();
                }
                if (row["F_HeadIcon"] != null)
                {
                    model.F_HeadIcon = row["F_HeadIcon"].ToString();
                }
                if (row["F_Gender"] != null && row["F_Gender"].ToString() != "")
                {
                    if ((row["F_Gender"].ToString() == "1") || (row["F_Gender"].ToString().ToLower() == "true"))
                    {
                        model.F_Gender = true;
                    }
                    else
                    {
                        model.F_Gender = false;
                    }
                }
                if (row["F_Birthday"] != null && row["F_Birthday"].ToString() != "")
                {
                    model.F_Birthday = DateTime.Parse(row["F_Birthday"].ToString());
                }
                if (row["F_MobilePhone"] != null)
                {
                    model.F_MobilePhone = row["F_MobilePhone"].ToString();
                }
                if (row["F_Email"] != null)
                {
                    model.F_Email = row["F_Email"].ToString();
                }
                if (row["F_WeChat"] != null)
                {
                    model.F_WeChat = row["F_WeChat"].ToString();
                }
                if (row["F_ManagerId"] != null)
                {
                    model.F_ManagerId = row["F_ManagerId"].ToString();
                }
                if (row["F_SecurityLevel"] != null && row["F_SecurityLevel"].ToString() != "")
                {
                    model.F_SecurityLevel = int.Parse(row["F_SecurityLevel"].ToString());
                }
                if (row["F_Signature"] != null)
                {
                    model.F_Signature = row["F_Signature"].ToString();
                }
                if (row["F_OrganizeId"] != null)
                {
                    model.F_OrganizeId = row["F_OrganizeId"].ToString();
                }
                if (row["F_DepartmentId"] != null)
                {
                    model.F_DepartmentId = row["F_DepartmentId"].ToString();
                }
                if (row["F_RoleId"] != null)
                {
                    model.F_RoleId = row["F_RoleId"].ToString();
                }
                if (row["F_DutyId"] != null)
                {
                    model.F_DutyId = row["F_DutyId"].ToString();
                }
                if (row["F_IsAdministrator"] != null && row["F_IsAdministrator"].ToString() != "")
                {
                    if ((row["F_IsAdministrator"].ToString() == "1") || (row["F_IsAdministrator"].ToString().ToLower() == "true"))
                    {
                        model.F_IsAdministrator = true;
                    }
                    else
                    {
                        model.F_IsAdministrator = false;
                    }
                }
                if (row["F_SortCode"] != null && row["F_SortCode"].ToString() != "")
                {
                    model.F_SortCode = int.Parse(row["F_SortCode"].ToString());
                }
                if (row["F_DeleteMark"] != null && row["F_DeleteMark"].ToString() != "")
                {
                    if ((row["F_DeleteMark"].ToString() == "1") || (row["F_DeleteMark"].ToString().ToLower() == "true"))
                    {
                        model.F_DeleteMark = true;
                    }
                    else
                    {
                        model.F_DeleteMark = false;
                    }
                }
                if (row["F_EnabledMark"] != null && row["F_EnabledMark"].ToString() != "")
                {
                    if ((row["F_EnabledMark"].ToString() == "1") || (row["F_EnabledMark"].ToString().ToLower() == "true"))
                    {
                        model.F_EnabledMark = true;
                    }
                    else
                    {
                        model.F_EnabledMark = false;
                    }
                }
                if (row["F_Description"] != null)
                {
                    model.F_Description = row["F_Description"].ToString();
                }
                if (row["F_CreatorTime"] != null && row["F_CreatorTime"].ToString() != "")
                {
                    model.F_CreatorTime = DateTime.Parse(row["F_CreatorTime"].ToString());
                }
                if (row["F_CreatorUserId"] != null)
                {
                    model.F_CreatorUserId = row["F_CreatorUserId"].ToString();
                }
                if (row["F_LastModifyTime"] != null && row["F_LastModifyTime"].ToString() != "")
                {
                    model.F_LastModifyTime = DateTime.Parse(row["F_LastModifyTime"].ToString());
                }
                if (row["F_LastModifyUserId"] != null)
                {
                    model.F_LastModifyUserId = row["F_LastModifyUserId"].ToString();
                }
                if (row["F_DeleteTime"] != null && row["F_DeleteTime"].ToString() != "")
                {
                    model.F_DeleteTime = DateTime.Parse(row["F_DeleteTime"].ToString());
                }
                if (row["F_DeleteUserId"] != null)
                {
                    model.F_DeleteUserId = row["F_DeleteUserId"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select F_Id,F_Account,F_RealName,F_NickName,F_HeadIcon,F_Gender,F_Birthday,F_MobilePhone,F_Email,F_WeChat,F_ManagerId,F_SecurityLevel,F_Signature,F_OrganizeId,F_DepartmentId,F_RoleId,F_DutyId,F_IsAdministrator,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId ");
            strSql.Append(" FROM Sys_User ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" F_Id,F_Account,F_RealName,F_NickName,F_HeadIcon,F_Gender,F_Birthday,F_MobilePhone,F_Email,F_WeChat,F_ManagerId,F_SecurityLevel,F_Signature,F_OrganizeId,F_DepartmentId,F_RoleId,F_DutyId,F_IsAdministrator,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId ");
            strSql.Append(" FROM Sys_User ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Sys_User ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.F_Id desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_User T ");
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
            parameters[0].Value = "Sys_User";
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


        public Sys_UserModel CheckLogin(string username, string password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 F_Id,F_Account,F_RealName,F_NickName,F_HeadIcon,F_Gender,F_Birthday,F_MobilePhone,F_Email,F_WeChat,F_ManagerId,F_SecurityLevel,F_Signature,F_OrganizeId,F_DepartmentId,F_RoleId,F_DutyId,F_IsAdministrator,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId from Sys_User ");
            strSql.Append(" where F_Account=@F_Account ");
            SqlParameter[] parameters = {
					new SqlParameter("@F_Account", SqlDbType.VarChar,50)			};
            parameters[0].Value = username;
            MyTest.Model.Sys_UserModel model = new MyTest.Model.Sys_UserModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model = DataRowToModel(ds.Tables[0].Rows[0]);
            }
            if (model != null)
            {
                if (model.F_EnabledMark == true)
                {

                    StringBuilder strSql1 = new StringBuilder();
                    strSql1.Append("select  top 1 F_Id,F_UserId,F_UserPassword,F_UserSecretkey,F_AllowStartTime,F_AllowEndTime,F_LockStartDate,F_LockEndDate,F_FirstVisitTime,F_PreviousVisitTime,F_LastVisitTime,F_ChangePasswordDate,F_MultiUserLogin,F_LogOnCount,F_UserOnLine,F_Question,F_AnswerQuestion,F_CheckIPAddress,F_Language,F_Theme from Sys_UserLogOn ");
                    strSql1.Append(" where F_UserId=@F_UserId ");
                    SqlParameter[] parameters1 = {
					new SqlParameter("@F_UserId", SqlDbType.VarChar,50)			};
                    parameters1[0].Value = model.F_Id;
                    Sys_UserLogOnDAL ldal = new Sys_UserLogOnDAL();
                    MyTest.Model.Sys_UserLogOnModel lmodel = new MyTest.Model.Sys_UserLogOnModel();
                    DataSet ds1 = DbHelperSQL.Query(strSql1.ToString(), parameters1);
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        lmodel = ldal.DataRowToModel(ds1.Tables[0].Rows[0]);
                    }

                    string dbPassword = Md5.md5(DESEncrypt.Encrypt(password.ToLower(), lmodel.F_UserSecretkey).ToLower(), 32).ToLower();
                    if (dbPassword == lmodel.F_UserPassword)
                    {
                        DateTime lastVisitTime = DateTime.Now;
                        int LogOnCount = (lmodel.F_LogOnCount).ToInt() + 1;
                        if (lmodel.F_LastVisitTime != null)
                        {
                            lmodel.F_PreviousVisitTime = lmodel.F_LastVisitTime.ToDate();
                        }
                        lmodel.F_LastVisitTime = lastVisitTime;
                        lmodel.F_LogOnCount = LogOnCount;
                        ldal.Update(lmodel);
                        return model;
                    }
                    else
                    {
                        throw new Exception("密码不正确，请重新输入");
                    }
                }
                else
                {
                    throw new Exception("账户被系统锁定,请联系管理员");
                }
            }
            else
            {
                throw new Exception("账户不存在，请重新输入");
            }
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="total"></param>
        /// <param name="roleName"></param>
        /// <param name="isAdmin"></param>
        /// <returns></returns>
        public List<Sys_UserModel> GetPageList(Pagination Pagination, string Account)
        {
            string table = "Sys_User";
            string columns = "F_Id,F_Account,F_RealName,F_NickName,F_HeadIcon,F_Gender,F_Birthday,F_MobilePhone,F_Email,F_WeChat,F_ManagerId,F_SecurityLevel,F_Signature,F_OrganizeId,F_DepartmentId,F_RoleId,F_DutyId,F_IsAdministrator,F_SortCode,F_DeleteMark,F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,F_LastModifyUserId,F_DeleteTime,F_DeleteUserId";
            string orderBy = Pagination.sidx;
            string where = "1=1";

            DynamicParameters p = null;
            if (!string.IsNullOrEmpty(Account))
            {
                p = new DynamicParameters();
                where += " AND [F_Account] like @Account";
                p.Add("Account", "%" + Account + "%", DbType.String);
            }

            return BaseDal.ExecuteReaderReturnPageListT<Sys_UserModel>(columns, table, null, Pagination, p);
        }

        #endregion  ExtensionMethod
    }
}

