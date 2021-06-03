/**  版本信息模板在安装目录下，可自行修改。
* ArtsMatterGroup.cs
*
* 功 能： N/A
* 类 名： ArtsMatterGroup
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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:ArtsMatterGroup
	/// </summary>
	public partial class ArtsMatterGroup:IArtsMatterGroup
	{
		public ArtsMatterGroup()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ArtsMatterGroup"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID,int No)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ArtsMatterGroup");
			strSql.Append(" where ID=@ID and No=@No ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@No", SqlDbType.Int,4)			};
			parameters[0].Value = ID;
			parameters[1].Value = No;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.ArtsMatterGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ArtsMatterGroup(");
			strSql.Append("ID,Title,Atlas,Time,Info,Mark,Click)");
			strSql.Append(" values (");
			strSql.Append("@ID,@Title,@Atlas,@Time,@Info,@Mark,@Click)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@Atlas", SqlDbType.NVarChar,50),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@Info", SqlDbType.NVarChar,-1),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@Click", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.Atlas;
			parameters[3].Value = model.Time;
			parameters[4].Value = model.Info;
			parameters[5].Value = model.Mark;
			parameters[6].Value = model.Click;

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
		public bool Update(Maticsoft.Model.ArtsMatterGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ArtsMatterGroup set ");
			strSql.Append("Title=@Title,");
			strSql.Append("Atlas=@Atlas,");
			strSql.Append("Time=@Time,");
			strSql.Append("Info=@Info,");
			strSql.Append("Mark=@Mark,");
			strSql.Append("Click=@Click");
			strSql.Append(" where No=@No");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@Atlas", SqlDbType.NVarChar,50),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@Info", SqlDbType.NVarChar,-1),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@Click", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@No", SqlDbType.Int,4)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.Atlas;
			parameters[2].Value = model.Time;
			parameters[3].Value = model.Info;
			parameters[4].Value = model.Mark;
			parameters[5].Value = model.Click;
			parameters[6].Value = model.ID;
			parameters[7].Value = model.No;

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
		public bool Delete(int No)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ArtsMatterGroup ");
			strSql.Append(" where No=@No");
			SqlParameter[] parameters = {
					new SqlParameter("@No", SqlDbType.Int,4)
			};
			parameters[0].Value = No;

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
		public bool Delete(int ID,int No)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ArtsMatterGroup ");
			strSql.Append(" where ID=@ID and No=@No ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@No", SqlDbType.Int,4)			};
			parameters[0].Value = ID;
			parameters[1].Value = No;

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
		public bool DeleteList(string Nolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ArtsMatterGroup ");
			strSql.Append(" where No in ("+Nolist + ")  ");
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
		public Maticsoft.Model.ArtsMatterGroup GetModel(int No)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Title,Atlas,Time,Info,No,Mark,Click from ArtsMatterGroup ");
			strSql.Append(" where No=@No");
			SqlParameter[] parameters = {
					new SqlParameter("@No", SqlDbType.Int,4)
			};
			parameters[0].Value = No;

			Maticsoft.Model.ArtsMatterGroup model=new Maticsoft.Model.ArtsMatterGroup();
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
		public Maticsoft.Model.ArtsMatterGroup DataRowToModel(DataRow row)
		{
			Maticsoft.Model.ArtsMatterGroup model=new Maticsoft.Model.ArtsMatterGroup();
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
				if(row["Atlas"]!=null)
				{
					model.Atlas=row["Atlas"].ToString();
				}
				if(row["Time"]!=null && row["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(row["Time"].ToString());
				}
				if(row["Info"]!=null)
				{
					model.Info=row["Info"].ToString();
				}
				if(row["No"]!=null && row["No"].ToString()!="")
				{
					model.No=int.Parse(row["No"].ToString());
				}
				if(row["Mark"]!=null && row["Mark"].ToString()!="")
				{
					model.Mark=int.Parse(row["Mark"].ToString());
				}
				if(row["Click"]!=null && row["Click"].ToString()!="")
				{
					model.Click=int.Parse(row["Click"].ToString());
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
			strSql.Append("select ID,Title,Atlas,Time,Info,No,Mark,Click ");
			strSql.Append(" FROM ArtsMatterGroup ");
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
			strSql.Append(" ID,Title,Atlas,Time,Info,No,Mark,Click ");
			strSql.Append(" FROM ArtsMatterGroup ");
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
			strSql.Append("select count(1) FROM ArtsMatterGroup ");
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
				strSql.Append("order by T.No desc");
			}
			strSql.Append(")AS Row, T.*  from ArtsMatterGroup T ");
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
			parameters[0].Value = "ArtsMatterGroup";
			parameters[1].Value = "No";
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

