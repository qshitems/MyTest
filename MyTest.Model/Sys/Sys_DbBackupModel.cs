/**  版本信息模板在安装目录下，可自行修改。
* Sys_DbBackupModel.cs
*
* 功 能： N/A
* 类 名： Sys_DbBackupModel
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/5/19 10:46:49   N/A    初版
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
	/// 数据库备份
	/// </summary>
	[Serializable]
	public partial class Sys_DbBackupModel
	{
		public Sys_DbBackupModel()
		{}
		#region Model
		private string _f_id;
		private string _f_backuptype;
		private string _f_dbname;
		private string _f_filename;
		private string _f_filesize;
		private string _f_filepath;
		private DateTime? _f_backuptime;
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
		/// 备份主键
		/// </summary>
		public string F_Id
		{
			set{ _f_id=value;}
			get{return _f_id;}
		}
		/// <summary>
		/// 备份类型
		/// </summary>
		public string F_BackupType
		{
			set{ _f_backuptype=value;}
			get{return _f_backuptype;}
		}
		/// <summary>
		/// 数据库名称
		/// </summary>
		public string F_DbName
		{
			set{ _f_dbname=value;}
			get{return _f_dbname;}
		}
		/// <summary>
		/// 文件名称
		/// </summary>
		public string F_FileName
		{
			set{ _f_filename=value;}
			get{return _f_filename;}
		}
		/// <summary>
		/// 文件大小
		/// </summary>
		public string F_FileSize
		{
			set{ _f_filesize=value;}
			get{return _f_filesize;}
		}
		/// <summary>
		/// 文件路径
		/// </summary>
		public string F_FilePath
		{
			set{ _f_filepath=value;}
			get{return _f_filepath;}
		}
		/// <summary>
		/// 备份时间
		/// </summary>
		public DateTime? F_BackupTime
		{
			set{ _f_backuptime=value;}
			get{return _f_backuptime;}
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

