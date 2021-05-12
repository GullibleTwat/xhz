﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Essays
	/// </summary>
	public partial class Essays:IEssays
	{
		public Essays()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("No", "Essays"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int No,int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Essays");
			strSql.Append(" where No=@No and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@No", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = No;
			parameters[1].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Essays model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Essays(");
			strSql.Append("Title,Content,Time,IsOpen,Click,No,Mark,S1)");
			strSql.Append(" values (");
			strSql.Append("@Title,@Content,@Time,@IsOpen,@Click,@No,@Mark,@S1)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@IsOpen", SqlDbType.Bit,1),
					new SqlParameter("@Click", SqlDbType.Int,4),
					new SqlParameter("@No", SqlDbType.Int,4),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@S1", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.Content;
			parameters[2].Value = model.Time;
			parameters[3].Value = model.IsOpen;
			parameters[4].Value = model.Click;
			parameters[5].Value = model.No;
			parameters[6].Value = model.Mark;
			parameters[7].Value = model.S1;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Essays model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Essays set ");
			strSql.Append("Title=@Title,");
			strSql.Append("Content=@Content,");
			strSql.Append("Time=@Time,");
			strSql.Append("IsOpen=@IsOpen,");
			strSql.Append("Click=@Click,");
			strSql.Append("Mark=@Mark,");
			strSql.Append("S1=@S1");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@IsOpen", SqlDbType.Bit,1),
					new SqlParameter("@Click", SqlDbType.Int,4),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@S1", SqlDbType.NVarChar,100),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@No", SqlDbType.Int,4)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.Content;
			parameters[2].Value = model.Time;
			parameters[3].Value = model.IsOpen;
			parameters[4].Value = model.Click;
			parameters[5].Value = model.Mark;
			parameters[6].Value = model.S1;
			parameters[7].Value = model.ID;
			parameters[8].Value = model.No;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Essays ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int No,int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Essays ");
			strSql.Append(" where No=@No and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@No", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = No;
			parameters[1].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Essays ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Essays GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Title,Content,Time,IsOpen,Click,No,Mark,S1 from Essays ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.Essays model=new Maticsoft.Model.Essays();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Essays DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Essays model=new Maticsoft.Model.Essays();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Content"]!=null)
				{
					model.Content=row["Content"].ToString();
				}
				if(row["Time"]!=null && row["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(row["Time"].ToString());
				}
				if(row["IsOpen"]!=null && row["IsOpen"].ToString()!="")
				{
					if((row["IsOpen"].ToString()=="1")||(row["IsOpen"].ToString().ToLower()=="true"))
					{
						model.IsOpen=true;
					}
					else
					{
						model.IsOpen=false;
					}
				}
				if(row["Click"]!=null && row["Click"].ToString()!="")
				{
					model.Click=int.Parse(row["Click"].ToString());
				}
				if(row["No"]!=null && row["No"].ToString()!="")
				{
					model.No=int.Parse(row["No"].ToString());
				}
				if(row["Mark"]!=null && row["Mark"].ToString()!="")
				{
					model.Mark=int.Parse(row["Mark"].ToString());
				}
				if(row["S1"]!=null)
				{
					model.S1=row["S1"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Title,Content,Time,IsOpen,Click,No,Mark,S1 ");
			strSql.Append(" FROM Essays ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,Title,Content,Time,IsOpen,Click,No,Mark,S1 ");
			strSql.Append(" FROM Essays ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Essays ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Essays T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Essays";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

