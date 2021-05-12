using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// WorksGroup:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WorksGroup
	{
		public WorksGroup()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _atlas;
		private DateTime? _time;
		private string _info;
		private int _no;
		private int? _mark;
		private int? _click=0;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 组名
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Atlas
		{
			set{ _atlas=value;}
			get{return _atlas;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Info
		{
			set{ _info=value;}
			get{return _info;}
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
		public int? Click
		{
			set{ _click=value;}
			get{return _click;}
		}
		#endregion Model

	}
}

