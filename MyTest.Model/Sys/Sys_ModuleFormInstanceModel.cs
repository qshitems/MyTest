/**  版本信息模板在安装目录下，可自行修改。
* Sys_ModuleFormInstanceModel.cs
*
* 功 能： N/A
* 类 名： Sys_ModuleFormInstanceModel
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/5/19 10:46:52   N/A    初版
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
	/// 模块表单实例
	/// </summary>
	[Serializable]
	public partial class Sys_ModuleFormInstanceModel
	{
		public Sys_ModuleFormInstanceModel()
		{}
		#region Model
		private string _f_id;
		private string _f_formid;
		private string _f_objectid;
		private string _f_instancejson;
		private int? _f_sortcode;
		private DateTime? _f_creatortime;
		private string _f_creatoruserid;
		/// <summary>
		/// 表单实例主键
		/// </summary>
		public string F_Id
		{
			set{ _f_id=value;}
			get{return _f_id;}
		}
		/// <summary>
		/// 表单主键
		/// </summary>
		public string F_FormId
		{
			set{ _f_formid=value;}
			get{return _f_formid;}
		}
		/// <summary>
		/// 对象主键
		/// </summary>
		public string F_ObjectId
		{
			set{ _f_objectid=value;}
			get{return _f_objectid;}
		}
		/// <summary>
		/// 表单实例Json
		/// </summary>
		public string F_InstanceJson
		{
			set{ _f_instancejson=value;}
			get{return _f_instancejson;}
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

