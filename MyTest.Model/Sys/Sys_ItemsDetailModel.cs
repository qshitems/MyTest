/**  版本信息模板在安装目录下，可自行修改。
* Sys_ItemsDetailModel.cs
*
* 功 能： N/A
* 类 名： Sys_ItemsDetailModel
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
	/// 选项明细表
	/// </summary>
	[Serializable]
	public partial class Sys_ItemsDetailModel
	{
		public Sys_ItemsDetailModel()
		{}
		#region Model
		private string _f_id;
		private string _f_itemid;
		private string _f_parentid;
		private string _f_itemcode;
		private string _f_itemname;
		private string _f_simplespelling;
		private bool _f_isdefault;
		private int? _f_layers;
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
		/// 明细主键
		/// </summary>
		public string F_Id
		{
			set{ _f_id=value;}
			get{return _f_id;}
		}
		/// <summary>
		/// 主表主键
		/// </summary>
		public string F_ItemId
		{
			set{ _f_itemid=value;}
			get{return _f_itemid;}
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
		/// 编码
		/// </summary>
		public string F_ItemCode
		{
			set{ _f_itemcode=value;}
			get{return _f_itemcode;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string F_ItemName
		{
			set{ _f_itemname=value;}
			get{return _f_itemname;}
		}
		/// <summary>
		/// 简拼
		/// </summary>
		public string F_SimpleSpelling
		{
			set{ _f_simplespelling=value;}
			get{return _f_simplespelling;}
		}
		/// <summary>
		/// 默认
		/// </summary>
		public bool F_IsDefault
		{
			set{ _f_isdefault=value;}
			get{return _f_isdefault;}
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
		/// 创建日期
		/// </summary>
		public DateTime? F_CreatorTime
		{
			set{ _f_creatortime=value;}
			get{return _f_creatortime;}
		}
		/// <summary>
		/// 创建用户主键
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

