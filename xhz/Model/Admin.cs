/**  版本信息模板在安装目录下，可自行修改。
* Admin.cs
*
* 功 能： N/A
* 类 名： Admin
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/5/7 14:09:53   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Admin:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Admin
	{
		public Admin()
		{}
		#region Model
		private string _id;
		private string _passwd;
		private int _power;
		/// <summary>
		/// ID
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string Passwd
		{
			set{ _passwd=value;}
			get{return _passwd;}
		}
		/// <summary>
		/// 权限
		/// </summary>
		public int Power
		{
			set{ _power=value;}
			get{return _power;}
		}
		#endregion Model

	}
}

