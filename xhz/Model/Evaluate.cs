﻿/**  版本信息模板在安装目录下，可自行修改。
* Evaluate.cs
*
* 功 能： N/A
* 类 名： Evaluate
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/5/7 2:08:45   N/A    初版
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
	/// Evaluate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Evaluate
	{
		public Evaluate()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _content;
		private string _attachment;
		private DateTime? _time= DateTime.Now;
		private bool _isopen= true;
		private int? _groupid;
		private int? _click=0;
		private int _no;
		private int? _mark;
		private string _s1;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Attachment
		{
			set{ _attachment=value;}
			get{return _attachment;}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 是否显示
		/// </summary>
		public bool IsOpen
		{
			set{ _isopen=value;}
			get{return _isopen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GroupID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// 点击数
		/// </summary>
		public int? Click
		{
			set{ _click=value;}
			get{return _click;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int No
		{
			set{ _no=value;}
			get{return _no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Mark
		{
			set{ _mark=value;}
			get{return _mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S1
		{
			set{ _s1=value;}
			get{return _s1;}
		}
		#endregion Model

	}
}

