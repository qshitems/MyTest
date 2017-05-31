/**  版本信息模板在安装目录下，可自行修改。
* Sys_UserModel.cs
*
* 功 能： N/A
* 类 名： Sys_UserModel
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
	/// 用户表
	/// </summary>
	[Serializable]
	public partial class Sys_UserModel
	{
		public Sys_UserModel()
		{}
		#region Model
		private string _f_id;
		private string _f_account;
		private string _f_realname;
		private string _f_nickname;
		private string _f_headicon;
		private bool _f_gender;
		private DateTime? _f_birthday;
		private string _f_mobilephone;
		private string _f_email;
		private string _f_wechat;
		private string _f_managerid;
		private int? _f_securitylevel;
		private string _f_signature;
		private string _f_organizeid;
		private string _f_departmentid;
		private string _f_roleid;
		private string _f_dutyid;
		private bool _f_isadministrator;
		private int? _f_sortcode;
		private bool _f_deletemark;
		private bool _f_enabledmark;
		private string _f_description;
		private DateTime? _f_creatortime;
		private string _f_creatoruserid;
		private DateTime? _f_lastmodifytime;
		private string _f_lastmodifyuserid;
		private DateTime? _f_deletetime;
		private string _f_deleteuserid;
		/// <summary>
		/// 用户主键
		/// </summary>
		public string F_Id
		{
			set{ _f_id=value;}
			get{return _f_id;}
		}
		/// <summary>
		/// 账户
		/// </summary>
		public string F_Account
		{
			set{ _f_account=value;}
			get{return _f_account;}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string F_RealName
		{
			set{ _f_realname=value;}
			get{return _f_realname;}
		}
		/// <summary>
		/// 呢称
		/// </summary>
		public string F_NickName
		{
			set{ _f_nickname=value;}
			get{return _f_nickname;}
		}
		/// <summary>
		/// 头像
		/// </summary>
		public string F_HeadIcon
		{
			set{ _f_headicon=value;}
			get{return _f_headicon;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public bool F_Gender
		{
			set{ _f_gender=value;}
			get{return _f_gender;}
		}
		/// <summary>
		/// 生日
		/// </summary>
		public DateTime? F_Birthday
		{
			set{ _f_birthday=value;}
			get{return _f_birthday;}
		}
		/// <summary>
		/// 手机
		/// </summary>
		public string F_MobilePhone
		{
			set{ _f_mobilephone=value;}
			get{return _f_mobilephone;}
		}
		/// <summary>
		/// 邮箱
		/// </summary>
		public string F_Email
		{
			set{ _f_email=value;}
			get{return _f_email;}
		}
		/// <summary>
		/// 微信
		/// </summary>
		public string F_WeChat
		{
			set{ _f_wechat=value;}
			get{return _f_wechat;}
		}
		/// <summary>
		/// 主管主键
		/// </summary>
		public string F_ManagerId
		{
			set{ _f_managerid=value;}
			get{return _f_managerid;}
		}
		/// <summary>
		/// 安全级别
		/// </summary>
		public int? F_SecurityLevel
		{
			set{ _f_securitylevel=value;}
			get{return _f_securitylevel;}
		}
		/// <summary>
		/// 个性签名
		/// </summary>
		public string F_Signature
		{
			set{ _f_signature=value;}
			get{return _f_signature;}
		}
		/// <summary>
		/// 组织主键
		/// </summary>
		public string F_OrganizeId
		{
			set{ _f_organizeid=value;}
			get{return _f_organizeid;}
		}
		/// <summary>
		/// 部门主键
		/// </summary>
		public string F_DepartmentId
		{
			set{ _f_departmentid=value;}
			get{return _f_departmentid;}
		}
		/// <summary>
		/// 角色主键
		/// </summary>
		public string F_RoleId
		{
			set{ _f_roleid=value;}
			get{return _f_roleid;}
		}
		/// <summary>
		/// 岗位主键
		/// </summary>
		public string F_DutyId
		{
			set{ _f_dutyid=value;}
			get{return _f_dutyid;}
		}
		/// <summary>
		/// 是否管理员
		/// </summary>
		public bool F_IsAdministrator
		{
			set{ _f_isadministrator=value;}
			get{return _f_isadministrator;}
		}
		/// <summary>
		/// 排序码
		/// </summary>
		public int? F_SortCode
		{
			set{ _f_sortcode=value;}
			get{return _f_sortcode;}
		}
		/// <summary>
		/// 删除标志
		/// </summary>
		public bool F_DeleteMark
		{
			set{ _f_deletemark=value;}
			get{return _f_deletemark;}
		}
		/// <summary>
		/// 有效标志
		/// </summary>
		public bool F_EnabledMark
		{
			set{ _f_enabledmark=value;}
			get{return _f_enabledmark;}
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
		/// <summary>
		/// 最后修改时间
		/// </summary>
		public DateTime? F_LastModifyTime
		{
			set{ _f_lastmodifytime=value;}
			get{return _f_lastmodifytime;}
		}
		/// <summary>
		/// 最后修改用户
		/// </summary>
		public string F_LastModifyUserId
		{
			set{ _f_lastmodifyuserid=value;}
			get{return _f_lastmodifyuserid;}
		}
		/// <summary>
		/// 删除时间
		/// </summary>
		public DateTime? F_DeleteTime
		{
			set{ _f_deletetime=value;}
			get{return _f_deletetime;}
		}
		/// <summary>
		/// 删除用户
		/// </summary>
		public string F_DeleteUserId
		{
			set{ _f_deleteuserid=value;}
			get{return _f_deleteuserid;}
		}
		#endregion Model

	}
}

