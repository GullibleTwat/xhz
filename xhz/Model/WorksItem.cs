using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// WorksItem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WorksItem
	{
		public WorksItem()
		{}
		#region Model
		private int _id;
		private string _title;
		private int _no;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int No
		{
			set{ _no=value;}
			get{return _no;}
		}
		#endregion Model

	}
}

