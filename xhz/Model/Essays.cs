using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Essays:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Essays
	{
		public Essays()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _content;
		private DateTime? _time= DateTime.Now;
		private bool _isopen= true;
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
		/// 备用
		/// </summary>
		public string S1
		{
			set{ _s1=value;}
			get{return _s1;}
		}
		#endregion Model

	}
}

