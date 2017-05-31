/**  版本信息模板在安装目录下，可自行修改。
* Sys_UserLogOnModel.cs
*
* 功 能： N/A
* 类 名： Sys_UserLogOnModel
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
namespace MyTest.Model
{
	/// <summary>
	/// 用户登录信息表
	/// </summary>
	[Serializable]
	public partial class Sys_UserLogOnModel
	{
		public Sys_UserLogOnModel()
		{}
		#region Model
		private string _f_id;
		private string _f_userid;
		private string _f_userpassword;
		private string _f_usersecretkey;
		private DateTime? _f_allowstarttime;
		private DateTime? _f_allowendtime;
		private DateTime? _f_lockstartdate;
		private DateTime? _f_lockenddate;
		private DateTime? _f_firstvisittime;
		private DateTime? _f_previousvisittime;
		private DateTime? _f_lastvisittime;
		private DateTime? _f_changepassworddate;
		private bool _f_multiuserlogin;
		private int? _f_logoncount;
		private bool _f_useronline;
		private string _f_question;
		private string _f_answerquestion;
		private bool _f_checkipaddress;
		private string _f_language;
		private string _f_theme;
		/// <summary>
		/// 用户登录主键
		/// </summary>
		public string F_Id
		{
			set{ _f_id=value;}
			get{return _f_id;}
		}
		/// <summary>
		/// 用户主键
		/// </summary>
		public string F_UserId
		{
			set{ _f_userid=value;}
			get{return _f_userid;}
		}
		/// <summary>
		/// 用户密码
		/// </summary>
		public string F_UserPassword
		{
			set{ _f_userpassword=value;}
			get{return _f_userpassword;}
		}
		/// <summary>
		/// 用户秘钥
		/// </summary>
		public string F_UserSecretkey
		{
			set{ _f_usersecretkey=value;}
			get{return _f_usersecretkey;}
		}
		/// <summary>
		/// 允许登录时间开始
		/// </summary>
		public DateTime? F_AllowStartTime
		{
			set{ _f_allowstarttime=value;}
			get{return _f_allowstarttime;}
		}
		/// <summary>
		/// 允许登录时间结束
		/// </summary>
		public DateTime? F_AllowEndTime
		{
			set{ _f_allowendtime=value;}
			get{return _f_allowendtime;}
		}
		/// <summary>
		/// 暂停用户开始日期
		/// </summary>
		public DateTime? F_LockStartDate
		{
			set{ _f_lockstartdate=value;}
			get{return _f_lockstartdate;}
		}
		/// <summary>
		/// 暂停用户结束日期
		/// </summary>
		public DateTime? F_LockEndDate
		{
			set{ _f_lockenddate=value;}
			get{return _f_lockenddate;}
		}
		/// <summary>
		/// 第一次访问时间
		/// </summary>
		public DateTime? F_FirstVisitTime
		{
			set{ _f_firstvisittime=value;}
			get{return _f_firstvisittime;}
		}
		/// <summary>
		/// 上一次访问时间
		/// </summary>
		public DateTime? F_PreviousVisitTime
		{
			set{ _f_previousvisittime=value;}
			get{return _f_previousvisittime;}
		}
		/// <summary>
		/// 最后访问时间
		/// </summary>
		public DateTime? F_LastVisitTime
		{
			set{ _f_lastvisittime=value;}
			get{return _f_lastvisittime;}
		}
		/// <summary>
		/// 最后修改密码日期
		/// </summary>
		public DateTime? F_ChangePasswordDate
		{
			set{ _f_changepassworddate=value;}
			get{return _f_changepassworddate;}
		}
		/// <summary>
		/// 允许同时有多用户登录
		/// </summary>
		public bool F_MultiUserLogin
		{
			set{ _f_multiuserlogin=value;}
			get{return _f_multiuserlogin;}
		}
		/// <summary>
		/// 登录次数
		/// </summary>
		public int? F_LogOnCount
		{
			set{ _f_logoncount=value;}
			get{return _f_logoncount;}
		}
		/// <summary>
		/// 在线状态
		/// </summary>
		public bool F_UserOnLine
		{
			set{ _f_useronline=value;}
			get{return _f_useronline;}
		}
		/// <summary>
		/// 密码提示问题
		/// </summary>
		public string F_Question
		{
			set{ _f_question=value;}
			get{return _f_question;}
		}
		/// <summary>
		/// 密码提示答案
		/// </summary>
		public string F_AnswerQuestion
		{
			set{ _f_answerquestion=value;}
			get{return _f_answerquestion;}
		}
		/// <summary>
		/// 是否访问限制
		/// </summary>
		public bool F_CheckIPAddress
		{
			set{ _f_checkipaddress=value;}
			get{return _f_checkipaddress;}
		}
		/// <summary>
		/// 系统语言
		/// </summary>
		public string F_Language
		{
			set{ _f_language=value;}
			get{return _f_language;}
		}
		/// <summary>
		/// 系统样式
		/// </summary>
		public string F_Theme
		{
			set{ _f_theme=value;}
			get{return _f_theme;}
		}
		#endregion Model

	}
}

