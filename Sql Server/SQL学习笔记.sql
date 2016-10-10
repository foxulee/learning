--注释：
--单行注释快捷键 ctrl+k+c
/*
多行注释
*/


--取字符实际长度
--select len(birthday) from [dbo].[UserInfo]	

--去数据类型的长度
--select datalength(birthday) from [dbo].[UserInfo]

--创建一个GUID
--select NEWID();


--DDL：create drop alter
--创建数据库
--Create database PhpDb
--删除数据库
--Drop database PhpDb


--go: 提交命令
--use School
--go


-----------------------------------------------操作table--------------------------------

-------------------创建表---------------
--create table Employee
--(
--	Id int identity(1,1) primary key not null,
--	EmpID int not null,
--	EmpName nvarchar(32) null,
--	EmpAge int default(18) not null,
--	DelFlag smallint default(0) not null,
--)


-------------------修改表  alter table...------------------
--------------添加列 altertable...add--------
--alter table [dbo].[Employee] add [Address] nvarchar(32) null
--添加数据
--insert into Employee values (125,'James',24, 1,'4418 Spruce st.')
--修改数据
--update Employee set Address='4224 Osage Ave' where EmpName='James'

--添加约束
--语法alter table 表明 add constraint 约束名字 内容 for 列
--alter table Employee add constraint DF_Employee_DeFlag default(0) for DelFlag

--添加主键约束
--alter table Employee add constraint PK_Employee_EmpID primary key (EmpID)

--添加唯一键约束
--alter table Employee add constraint UQ_Employee_EmpID unique (EmpID)

--添加外键约束
--create table OrderInfo
--(
--	OrderID int identity(1,1) primary key not null,
--	OrderInforDes nvarchar(64) null,
--	DelFlag smallint default(0) null,
--)
--create table Category
--(
--	CatID int identity(1,1) primary key not null,
--	CatName nvarchar(32) null,
--	ParentCatID int null,
--	DelFlag smallint default(0) null
--)
--create table Product
--(
--	ProID int primary key not null,
--	ProName nvarchar(32) not null,
--	ProCreateOn datetime default(getdate()) null
--)
--alter table Product add CategoryID int null
--alter table Product add constraint FK_Product_Category foreign key (CategoryID) references Category(CatID)  --添加外键


----------删除列 alter table... drop------------
--如果有约束的需要先删除约束
--alter table Employee drop constraint DF__Employee__DelFla__117F9D94
--alter table Employee drop column DelFlag


----------修改列 alter table alter column....
--修改列属性
--alter table Employee alter column [Address] nvarchar(64) null
--修改列名
--exec sp_rename 'Address','EmpAddress'


-------------------------基本查询------------------------
-------------------select 常量，系统函数，表达式，列名 ....-------------
--as列的别名
--select 1000*0.1+2000 as money   
--select *, proName as AliasName from Product

--as表的别名
--select * from Product as P   --在表的连接的时候很有用

--select count(*) from Product
--count(*):找表中最短的列进行统计个数
--count(1) count(2) count('ss') 对常熟列进行统计行数

--select getdate()

--select @@VERSION
--select @@CPU_BUSY
--select @@ERROR



--select * from dbo.Employee     --*：要查询的所有列
--select 
--	EmpId,
--	EmpName 
--from 
--	dbo.Employee 
--where	
--	EmpID>111 --and/or .....

--聚合函数
--		->Avg()
--		->Count()
--		->Sum()
--		->Min()/Max()
--		->Group

--	->Top截取和Order 排序
--select 
--top 10 * 
--from 
--	tblScore 
--order by 
--	score desc, score desc

--	->去除重复:Distinct	       ->--distinct只能紧跟这select后面，而且是对后面的所有的列都进行去重复操作
	
--	->where条件过滤
--		->常见的表达式过滤：比如 ，select * from 表 where Id>10
		
--		->多条件过滤： and or not（优先级：not > and >or）  &&  ||  !
--		->区间过滤：between and   和 in
		
--		->模糊查询！！！！！！！！！！！
--			->like查询语法
--			->针对字符串查询的通配符： %（匹配一个或多个任意字符）  _（匹配一个任意字符）   []
--			->特殊字符转义。‘’  和 [ 
			
			
--		->空值处理：
--			-> 列=Null的结果
--			->is null和is not  null
--	->排序Order by
--		->asc 和 desc
--		->一般放在所有的语句的最后，所有查询结果进行过滤完成后，再对最后的结果集合进行排序。
--		->默认是asc

--->数据进行分组：Group by   ----------！！！只要用了group by，那么select后面只能跟group by后面的字段或者是聚合函数
--	select 用户的ID,Count(1) ,sum(订单金额)
--		from 订单信息表
--		group by 用户的ID
	
--	->Having 过滤
--	->Sql语句的执行顺序。
--		->from 找到表->where过滤->Group分组->having 筛选分组结果 ->Order 排序




-------------Insert-----------------
--Insert into 表名（列表1，列表2....）values(值1，值2....)
--insert into dbo.Employee (EmpID,EmpName,EmpAge,DelFlag) values(123,'Jay',18,1 )
--insert into dbo.Employee (EmpID,EmpName,EmpAge,DelFlag) values(124,N'小明',18,1 )    --N表示unicle编码 输入中文


-------------Delete------------------
--delete from dbo.Employee where id=123

-------------Update------------------
--update dbo.Employee set EmpName=N'小兰' where EmpID=124





----------------------------类型转换--------------------------------
-->查询：比如把一个字符串和整数进行相加
-->Convert类型转换：Convert(目标类型，表达式，类型))
-->Cast类型转换：Cast(表达式 as 类型)
--select Convert(nvarchar(32),CustomerId) +Title from SalesLT.Customer
--select Cast(CustomerId as nvarchar(32))+Title from SalesLT.Customer



---------------------------日期函数---------------------
select GETDATE()

select DATEADD(YEAR,1,'2015-3-1' )
select DATEADD(DAY,1,'2015-3-1' )

select DATEDIFF(YEAR,'2015-3-1','2017-3-2')
select DATEDIFF(SECOND,'2015-3-1','2017-3-2')

select DATEPART(MONTH,'2015-3-1' )
select MONTH('2015-3-1')

