using Dapper;
using ExcessChip.Common;
using ExcessChip.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ExcessChip.DAL
{
	/// <summary>
	/// -Article 
	/// </summary>
	public class ArticleDal
	{ 
		private static readonly string connString = ConfigHelper.GetConnectionString("connStr");
		private SqlConnection _conn;
		public SqlConnection Conn {
			get {
				_conn = new SqlConnection(connString);
				_conn.Open();
				return _conn;
			}
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		/// <returns></returns>
		public object AddArticle(Article model)
		{
			using (Conn)
			{
				string sql=@"insert into Article (Title, ArticleTypeId, ApproveStatus, ComeFrom, ClickCount, Avatar, IsTop, Content, Summary, KeyName, LocationType, Tag, CreateDate, UpdateDate, UserId, OperatorId) values(@Title, @ArticleTypeId, @ApproveStatus, @ComeFrom, @ClickCount, @Avatar, @IsTop, @Content, @Summary, @KeyName, @LocationType, @Tag, @CreateDate, @UpdateDate, @UserId, @OperatorId); SELECT @@IDENTITY";
				return Conn.ExecuteScalar(sql.ToString(), model);
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		/// <returns></returns>
		public int UpdateArticle(Article model)
		{
			using (Conn)
			{
				string sql=@"update set Article Title=@Title,ArticleTypeId=@ArticleTypeId,ApproveStatus=@ApproveStatus,ComeFrom=@ComeFrom,ClickCount=@ClickCount,Avatar=@Avatar,IsTop=@IsTop,Content=@Content,Summary=@Summary,KeyName=@KeyName,LocationType=@LocationType,Tag=@Tag,CreateDate=@CreateDate,UpdateDate=@UpdateDate,UserId=@UserId,OperatorId=@OperatorId where id=@id";
				return Conn.Execute(sql.ToString(), model);
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		/// <returns></returns>
		public int DeleteArticle(int id)
		{
			using (Conn)
			{
				string sql=@"delete from Article where Id = @Id";
				return Conn.Execute(sql.ToString());
			}
		}

		/// <summary>
		/// 根据主键Id获取一个对象实体
		/// </summary>
		/// <returns></returns>
		public Article GetArticleById(int id)
		{
			using (Conn)
			{
				string sql="select * from Article where Id=@Id";
				return Conn.Query<Article>(sql, new { Id = id }).SingleOrDefault();
			}
		}

		/// <summary>
		/// 获取实体List
		/// </summary>
		/// <returns></returns>
		public List<Article> GetArticleList(int top, string where = null, string order = null)
		{
			using (Conn)
			{
				string sql="select * from Article";
				return Conn.Query<Article>(sql).ToList();
			}
		}

		/// <summary>
		/// 检测字段值是否存在
		/// </summary>
		/// <returns></returns>
		public bool IsColumnExist(string key,string val)
		{
			using (Conn)
			{
				string sql="select count(*) from Article where {0}='{1}' ";
				return Conn.QuerySingle<int>(string.Format(sql, key, val)) > 0;
			}
		}

	}
}
