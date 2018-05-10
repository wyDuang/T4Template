using System;

namespace RoleSystem.Model
{    
	/// <summary>
	/// 实体-Article-
	/// </summary>
	public partial class Article    
	{
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 ArticleId { get; set; }
 
        /// <summary>
        /// 标题
        /// </summary>
        public String Title { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public Int32? ArticleTypeId { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public Int16? ApproveStatus { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public String ComeFrom { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public Int32? ClickCount { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public String Avatar { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public Int16? IsTop { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public String Content { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public String Summary { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public String KeyName { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public Int16? LocationType { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public String Tag { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateDate { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateDate { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public Int32? UserId { get; set; }
 
        /// <summary>
        /// 
        /// </summary>
        public Int32? OperatorId { get; set; }
	}
}
    
