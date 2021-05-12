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

