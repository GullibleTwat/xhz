using System;
using System.Reflection;
using System.Configuration;
using Maticsoft.IDAL;
namespace Maticsoft.DALFactory
{
	/// <summary>
	/// 抽象工厂模式创建DAL。
	/// web.config 需要加入配置：(利用工厂模式+反射机制+缓存机制,实现动态创建不同的数据层对象接口) 
	/// DataCache类在导出代码的文件夹里
	/// <appSettings> 
	/// <add key="DAL" value="Maticsoft.SQLServerDAL" /> (这里的命名空间根据实际情况更改为自己项目的命名空间)
	/// </appSettings> 
	/// </summary>
	public sealed class DataAccess//<t>
	{
		private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];
		/// <summary>
		/// 创建对象或从缓存获取
		/// </summary>
		public static object CreateObject(string AssemblyPath,string ClassNamespace)
		{
			object objType = DataCache.GetCache(ClassNamespace);//从缓存读取
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(ClassNamespace);//反射创建
					DataCache.SetCache(ClassNamespace, objType);// 写入缓存
				}
				catch
				{}
			}
			return objType;
		}
        public static Maticsoft.IDAL.ISysManage CreateSysManage()
        {

            //方式1			

            //return (Maticsoft.IDAL.ISysManage)Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath+".SysManage");



            //方式2 			

            string classNamespace = AssemblyPath + ".SysManage";

            object objType = CreateObject(AssemblyPath, classNamespace);

            return (Maticsoft.IDAL.ISysManage)objType;

        }


		/// <summary>
		/// 创建数据层接口
		/// </summary>
		//public static t Create(string ClassName)
		//{
			//string ClassNamespace = AssemblyPath +"."+ ClassName;
			//object objType = CreateObject(AssemblyPath, ClassNamespace);
			//return (t)objType;
		//}
		/// <summary>
		/// 创建Admin数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IAdmin CreateAdmin()
		{

			string ClassNamespace = AssemblyPath +".Admin";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IAdmin)objType;
		}


		/// <summary>
		/// 创建ArtsMatter数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IArtsMatter CreateArtsMatter()
		{

			string ClassNamespace = AssemblyPath +".ArtsMatter";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IArtsMatter)objType;
		}


		/// <summary>
		/// 创建ArtsMatterGroup数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IArtsMatterGroup CreateArtsMatterGroup()
		{

			string ClassNamespace = AssemblyPath +".ArtsMatterGroup";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IArtsMatterGroup)objType;
		}


		/// <summary>
		/// 创建Essays数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IEssays CreateEssays()
		{

			string ClassNamespace = AssemblyPath +".Essays";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IEssays)objType;
		}


		/// <summary>
		/// 创建Evaluate数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IEvaluate CreateEvaluate()
		{

			string ClassNamespace = AssemblyPath +".Evaluate";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IEvaluate)objType;
		}


		/// <summary>
		/// 创建EvaluateGroup数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IEvaluateGroup CreateEvaluateGroup()
		{

			string ClassNamespace = AssemblyPath +".EvaluateGroup";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IEvaluateGroup)objType;
		}


		/// <summary>
		/// 创建Message数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IMessage CreateMessage()
		{

			string ClassNamespace = AssemblyPath +".Message";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IMessage)objType;
		}


		/// <summary>
		/// 创建News数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.INews CreateNews()
		{

			string ClassNamespace = AssemblyPath +".News";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.INews)objType;
		}


		/// <summary>
		/// 创建NewsGroup数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.INewsGroup CreateNewsGroup()
		{

			string ClassNamespace = AssemblyPath +".NewsGroup";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.INewsGroup)objType;
		}


		/// <summary>
		/// 创建Works数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IWorks CreateWorks()
		{

			string ClassNamespace = AssemblyPath +".Works";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IWorks)objType;
		}


		/// <summary>
		/// 创建WorksGroup数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IWorksGroup CreateWorksGroup()
		{

			string ClassNamespace = AssemblyPath +".WorksGroup";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IWorksGroup)objType;
		}


		/// <summary>
		/// 创建WorksItem数据层接口。
		/// </summary>
		public static Maticsoft.IDAL.IWorksItem CreateWorksItem()
		{

			string ClassNamespace = AssemblyPath +".WorksItem";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (Maticsoft.IDAL.IWorksItem)objType;
		}

}
}