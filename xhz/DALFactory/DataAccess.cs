using System;
using System.Reflection;
using System.Configuration;
namespace Maticsoft.DALFactory
{
	/// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="Maticsoft.SQLServerDAL" />。
	/// </summary>
	public sealed class DataAccess 
	{
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];        
		public DataAccess()
		{ }

        #region CreateObject 

		//不使用缓存
        private static object CreateObjectNoCache(string AssemblyPath,string classNamespace)
		{		
			try
			{
				object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);	
				return objType;
			}
			catch//(System.Exception ex)
			{
				//string str=ex.Message;// 记录错误日志
				return null;
			}			
			
        }
		//使用缓存
		private static object CreateObject(string AssemblyPath,string classNamespace)
		{			
			object objType = DataCache.GetCache(classNamespace);
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);					
					DataCache.SetCache(classNamespace, objType);// 写入缓存
				}
				catch//(System.Exception ex)
				{
					//string str=ex.Message;// 记录错误日志
				}
			}
			return objType;
		}
        #endregion

        #region 泛型生成
        ///// <summary>
        ///// 创建数据层接口。
        ///// </summary>
        //public static t Create(string ClassName)
        //{

        //    string ClassNamespace = AssemblyPath +"."+ ClassName;
        //    object objType = CreateObject(AssemblyPath, ClassNamespace);
        //    return (t)objType;
        //}
        #endregion

        #region CreateSysManage
        public static Maticsoft.IDAL.ISysManage CreateSysManage()
		{
			//方式1			
			//return (Maticsoft.IDAL.ISysManage)Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath+".SysManage");

			//方式2 			
			string classNamespace = AssemblyPath+".SysManage";	
			object objType=CreateObject(AssemblyPath,classNamespace);
            return (Maticsoft.IDAL.ISysManage)objType;		
		}
		#endregion
             
        
   
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