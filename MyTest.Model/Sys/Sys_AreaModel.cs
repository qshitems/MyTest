
using System;
namespace MyTest.Model
{
	/// <summary>
	/// 行政区域表
	/// </summary>
	[Serializable]
	public partial class Sys_AreaModel
	{
		public Sys_AreaModel()
		{}
		#region Model
		private string _f_id;
		private string _f_parentid;
		private int? _f_layers;
		private string _f_encode;
		private string _f_fullname;
		private string _f_simplespelling;
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
		/// 主键
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
		/// 简拼
		/// </summary>
		public string F_SimpleSpelling
		{
			set{ _f_simplespelling=value;}
			get{return _f_simplespelling;}
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

