# T4Template
《使用T4批量生成Model和基于Dapper的DAL》

使用方法：
1、T4Dal  打开T4_Dal.tt，修改数据库连接字符串：connectionString，Ctrl + S保存。 ok

2、T4Model这个有两种  
    t4_Model1引用了 MultipleOutputHelper.ttinclude，能够批量生成，但是字段类型。。。
    t4_Model2引用了 DbHelper.ttinclude，目前只能申成单个表。自己扩展吧。