/**  版本信息模板在安装目录下，可自行修改。
* Sys_OrganizeModel.cs
*
* 功 能： N/A
* 类 名： Sys_OrganizeModel
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
namespace MyTest.Model
{
	/// <summary>
	/// 组织表
	/// </summary>
	[Serializable]
	public partial class Sys_OrganizeModel
	{
		public Sys_OrganizeModel()
		{}
		#region Model
		private string _f_id;
		private string _f_parentid;
		private int? _f_layers;
		private string _f_encode;
		private string _f_fullname;
		private string _f_shortname;
		private string _f_categoryid;
		private string _f_managerid;
		private string _f_telephone;
		private string _f_mobilephone;
		private string _f_wechat;
		private string _f_fax;
		private string _f_email;
		private string _f_areaid;
		private string _f_address;
		private bool _f_allowedit;
		private bool _f_allowdelete;
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
		/// 组织主键
		/// </summary>
		public string F_Id
		{
			set{ _f_id=value;}
			get{return _f_id;}
		}
		/// <summary>
		/// 父级
		/// </summary>
		public string F_ParentId
		{
			set{ _f_parentid=value;}
			get{return _f_parentid;}
		}
		/// <summary>
		/// 层次
		/// </summary>
		public int? F_Layers
		{
			set{ _f_layers=value;}
			get{return _f_layers;}
		}
		/// <summary>
		/// 编码
		/// </summary>
		public string F_EnCode
		{
			set{ _f_encode=value;}
			get{return _f_encode;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string F_FullName
		{
			set{ _f_fullname=value;}
			get{return _f_fullname;}
		}
		/// <summary>
		/// 简称
		/// </summary>
		public string F_ShortName
		{
			set{ _f_shortname=value;}
			get{return _f_shortname;}
		}
		/// <summary>
		/// 分类
		/// </summary>
		public string F_CategoryId
		{
			set{ _f_categoryid=value;}
			get{return _f_categoryid;}
		}
		/// <summary>
		/// 负责人
		/// </summary>
		public string F_ManagerId
		{
			set{ _f_managerid=value;}
			get{return _f_managerid;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string F_TelePhone
		{
			set{ _f_telephone=value;}
			get{return _f_telephone;}
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
		/// 微信
		/// </summary>
		public string F_WeChat
		{
			set{ _f_wechat=value;}
			get{return _f_wechat;}
		}
		/// <summary>
		/// 传真
		/// </summary>
		public string F_Fax
		{
			set{ _f_fax=value;}
			get{return _f_fax;}
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
		/// 归属区域
		/// </summary>
		public string F_AreaId
		{
			set{ _f_areaid=value;}
			get{return _f_areaid;}
		}
		/// <summary>
		/// 联系地址
		/// </summary>
		public string F_Address
		{
			set{ _f_address=value;}
			get{return _f_address;}
		}
		/// <summary>
		/// 允许编辑
		/// </summary>
		public bool F_AllowEdit
		{
			set{ _f_allowedit=value;}
			get{return _f_allowedit;}
		}
		/// <summary>
		/// 允许删除
		/// </summary>
		public bool F_AllowDelete
		{
			set{ _f_allowdelete=value;}
			get{return _f_allowdelete;}
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

