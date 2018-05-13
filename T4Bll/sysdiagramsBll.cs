using ExcessChip.DAL;
using ExcessChip.Model;
using System;
using System.Collections.Generic;

namespace ExcessChip.BLL
{
	public class sysdiagramsBll
	{ 
		private readonly sysdiagramsDal _dal = new sysdiagramsDal();

		#region 默认方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		/// <returns></returns>
		public object Addsysdiagrams(sysdiagrams model) => Convert.ToInt32(_dal.Addsysdiagrams(model));

		/// <summary>
		/// 更新一条数据
		/// </summary>
		/// <returns></returns>
		public bool Updatesysdiagrams(sysdiagrams model) => _dal.Updatesysdiagrams(model) > 0;

		/// <summary>
		/// 删除一条数据
		/// </summary>
		/// <returns></returns>
		public bool Deletesysdiagrams(int id) => _dal.Deletesysdiagrams(id) > 0;

		/// <summary>
		/// 根据主键Id获取一个对象实体
		/// </summary>
		/// <returns></returns>
		public sysdiagrams GetsysdiagramsById(int id) => _dal.GetsysdiagramsById(id);

		/// <summary>
		/// 获取实体集合
		/// </summary>
		/// <returns></returns>
		public IEnumerable<sysdiagrams> GetsysdiagramsList() => _dal.GetsysdiagramsList();

		/// <summary>
		/// 检测某字段的值是否存在
		/// </summary>
		/// <returns></returns>
		public bool IsColumnExist(string key, string value) => _dal.IsColumnExist(key, value) > 0;

		#endregion

		#region 自定义方法

		#endregion
	}
}
