/**  版本信息模板在安装目录下，可自行修改。
* Sys_LogModel.cs
*
* 功 能： N/A
* 类 名： Sys_LogModel
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
namespace MyTest.Model
{
	/// <summary>
	/// 系统日志
	/// </summary>
	[Serializable]
	public partial class Sys_LogModel
	{
		public Sys_LogModel()
		{}
		#region Model
		private string _f_id;
		private DateTime? _f_date;
		private string _f_account;
		private string _f_nickname;
		private string _f_type;
		private string _f_ipaddress;
		private string _f_ipaddressname;
		private string _f_moduleid;
		private string _f_modulename;
		private bool _f_result;
		private string _f_description;
		private DateTime? _f_creatortime;
		private string _f_creatoruserid;
		/// <summary>
		/// 日志主键
		/// </summary>
		public string F_Id
		{
			set{ _f_id=value;}
			get{return _f_id;}
		}
		/// <summary>
		/// 日期
		/// </summary>
		public DateTime? F_Date
		{
			set{ _f_date=value;}
			get{return _f_date;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string F_Account
		{
			set{ _f_account=value;}
			get{return _f_account;}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string F_NickName
		{
			set{ _f_nickname=value;}
			get{return _f_nickname;}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public string F_Type
		{
			set{ _f_type=value;}
			get{return _f_type;}
		}
		/// <summary>
		/// IP地址
		/// </summary>
		public string F_IPAddress
		{
			set{ _f_ipaddress=value;}
			get{return _f_ipaddress;}
		}
		/// <summary>
		/// IP所在城市
		/// </summary>
		public string F_IPAddressName
		{
			set{ _f_ipaddressname=value;}
			get{return _f_ipaddressname;}
		}
		/// <summary>
		/// 系统模块Id
		/// </summary>
		public string F_ModuleId
		{
			set{ _f_moduleid=value;}
			get{return _f_moduleid;}
		}
		/// <summary>
		/// 系统模块
		/// </summary>
		public string F_ModuleName
		{
			set{ _f_modulename=value;}
			get{return _f_modulename;}
		}
		/// <summary>
		/// 结果
		/// </summary>
		public bool F_Result
		{
			set{ _f_result=value;}
			get{return _f_result;}
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string F_Description
		{
			set{ _f_description=value;}
			get{return _f_description;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? F_CreatorTime
		{
			set{ _f_creatortime=value;}
			get{return _f_creatortime;}
		}
		/// <summary>
		/// 创建用户
		/// </summary>
		public string F_CreatorUserId
		{
			set{ _f_creatoruserid=value;}
			get{return _f_creatoruserid;}
		}
		#endregion Model

	}
}

