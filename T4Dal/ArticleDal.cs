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
	public class ArticleDal
	{ 
		private static readonly string connStr = ConfigHelper.GetConnectionString("ExcessChipStr");
		private SqlConnection _conn;
		public SqlConnection Conn
		{
			get
			{
				_conn = new SqlConnection(connStr);
				_conn.Open();
				return _conn;
			}
		}

		#region 默认方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		/// <returns></returns>
		public object AddArticle(Article model)
		{
			using (Conn)
			{
				string sql = @"insert into Article (Title, ArticleTypeId, ApproveStatus, ComeFrom, ClickCount, Avatar, IsTop, Content, Summary, KeyName, LocationType, Tag, CreateDate, UpdateDate, UserId, OperatorId) values(@Title, @ArticleTypeId, @ApproveStatus, @ComeFrom, @ClickCount, @Avatar, @IsTop, @Content, @Summary, @KeyName, @LocationType, @Tag, @CreateDate, @UpdateDate, @UserId, @OperatorId); SELECT @@IDENTITY";
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
				string sql = @"update set Article Title=@Title, ArticleTypeId = @ArticleTypeId, ApproveStatus = @ApproveStatus, ComeFrom = @ComeFrom, ClickCount = @ClickCount, Avatar = @Avatar, IsTop = @IsTop, Content = @Content, Summary = @Summary, KeyName = @KeyName, LocationType = @LocationType, Tag = @Tag, CreateDate = @CreateDate, UpdateDate = @UpdateDate, UserId = @UserId, OperatorId = @OperatorId where id = @id";
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
				string sql = @"delete from Article where Id = @Id";
				return Conn.Execute(sql.ToString(), id);
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
				string sql="select * from Article where Id = @Id";
				return Conn.Query<Article>(sql, new { Id = id }).SingleOrDefault();
			}
		}

		/// <summary>
		/// 获取实体集合
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Article> GetArticleList()
		{
			using (Conn)
			{
				string sql="select * from Article";
				return Conn.Query<Article>(sql);
			}
		}

		/// <summary>
		/// 检测某字段的值是否存在
		/// </summary>
		/// <returns></returns>
		public int IsColumnExist(string key, string value)
		{
			using (Conn)
			{
				string sql="select count(*) from Article where {0} = '{1}'";
				return Conn.QuerySingle<int>(string.Format(sql, key, value));
			}
		}
		#endregion

		#region 自定义方法

		#endregion
	}
}
