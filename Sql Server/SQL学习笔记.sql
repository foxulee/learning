--ע�ͣ�
--����ע�Ϳ�ݼ� ctrl+k+c
/*
����ע��
*/


--ȡ�ַ�ʵ�ʳ���
--select len(birthday) from [dbo].[UserInfo]	

--ȥ�������͵ĳ���
--select datalength(birthday) from [dbo].[UserInfo]

--����һ��GUID
--select NEWID();


--DDL��create drop alter
--�������ݿ�
--Create database PhpDb
--ɾ�����ݿ�
--Drop database PhpDb


--go: �ύ����
--use School
--go


-----------------------------------------------����table--------------------------------

-------------------������---------------
--create table Employee
--(
--	Id int identity(1,1) primary key not null,
--	EmpID int not null,
--	EmpName nvarchar(32) null,
--	EmpAge int default(18) not null,
--	DelFlag smallint default(0) not null,
--)


-------------------�޸ı�  alter table...------------------
--------------����� altertable...add--------
--alter table [dbo].[Employee] add [Address] nvarchar(32) null
--�������
--insert into Employee values (125,'James',24, 1,'4418 Spruce st.')
--�޸�����
--update Employee set Address='4224 Osage Ave' where EmpName='James'

--���Լ��
--�﷨alter table ���� add constraint Լ������ ���� for ��
--alter table Employee add constraint DF_Employee_DeFlag default(0) for DelFlag

--�������Լ��
--alter table Employee add constraint PK_Employee_EmpID primary key (EmpID)

--���Ψһ��Լ��
--alter table Employee add constraint UQ_Employee_EmpID unique (EmpID)

--������Լ��
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
--alter table Product add constraint FK_Product_Category foreign key (CategoryID) references Category(CatID)  --������


----------ɾ���� alter table... drop------------
--�����Լ������Ҫ��ɾ��Լ��
--alter table Employee drop constraint DF__Employee__DelFla__117F9D94
--alter table Employee drop column DelFlag


----------�޸��� alter table alter column....
--�޸�������
--alter table Employee alter column [Address] nvarchar(64) null
--�޸�����
--exec sp_rename 'Address','EmpAddress'


-------------------------������ѯ------------------------
-------------------select ������ϵͳ���������ʽ������ ....-------------
--as�еı���
--select 1000*0.1+2000 as money   
--select *, proName as AliasName from Product

--as��ı���
--select * from Product as P   --�ڱ�����ӵ�ʱ�������

--select count(*) from Product
--count(*):�ұ�����̵��н���ͳ�Ƹ���
--count(1) count(2) count('ss') �Գ����н���ͳ������

--select getdate()

--select @@VERSION
--select @@CPU_BUSY
--select @@ERROR



--select * from dbo.Employee     --*��Ҫ��ѯ��������
--select 
--	EmpId,
--	EmpName 
--from 
--	dbo.Employee 
--where	
--	EmpID>111 --and/or .....

--�ۺϺ���
--		->Avg()
--		->Count()
--		->Sum()
--		->Min()/Max()
--		->Group

--	->Top��ȡ��Order ����
--select 
--top 10 * 
--from 
--	tblScore 
--order by 
--	score desc, score desc

--	->ȥ���ظ�:Distinct	       ->--distinctֻ�ܽ�����select���棬�����ǶԺ�������е��ж�����ȥ�ظ�����
	
--	->where��������
--		->�����ı��ʽ���ˣ����� ��select * from �� where Id>10
		
--		->���������ˣ� and or not�����ȼ���not > and >or��  &&  ||  !
--		->������ˣ�between and   �� in
		
--		->ģ����ѯ����������������������
--			->like��ѯ�﷨
--			->����ַ�����ѯ��ͨ����� %��ƥ��һ�����������ַ���  _��ƥ��һ�������ַ���   []
--			->�����ַ�ת�塣����  �� [ 
			
			
--		->��ֵ����
--			-> ��=Null�Ľ��
--			->is null��is not  null
--	->����Order by
--		->asc �� desc
--		->һ��������е�����������в�ѯ������й�����ɺ��ٶ����Ľ�����Ͻ�������
--		->Ĭ����asc

--->���ݽ��з��飺Group by   ----------������ֻҪ����group by����ôselect����ֻ�ܸ�group by������ֶλ����ǾۺϺ���
--	select �û���ID,Count(1) ,sum(�������)
--		from ������Ϣ��
--		group by �û���ID
	
--	->Having ����
--	->Sql����ִ��˳��
--		->from �ҵ���->where����->Group����->having ɸѡ������ ->Order ����




-------------Insert-----------------
--Insert into �������б�1���б�2....��values(ֵ1��ֵ2....)
--insert into dbo.Employee (EmpID,EmpName,EmpAge,DelFlag) values(123,'Jay',18,1 )
--insert into dbo.Employee (EmpID,EmpName,EmpAge,DelFlag) values(124,N'С��',18,1 )    --N��ʾunicle���� ��������


-------------Delete------------------
--delete from dbo.Employee where id=123

-------------Update------------------
--update dbo.Employee set EmpName=N'С��' where EmpID=124





----------------------------����ת��--------------------------------
-->��ѯ�������һ���ַ����������������
-->Convert����ת����Convert(Ŀ�����ͣ����ʽ������))
-->Cast����ת����Cast(���ʽ as ����)
--select Convert(nvarchar(32),CustomerId) +Title from SalesLT.Customer
--select Cast(CustomerId as nvarchar(32))+Title from SalesLT.Customer



---------------------------���ں���---------------------
select GETDATE()

select DATEADD(YEAR,1,'2015-3-1' )
select DATEADD(DAY,1,'2015-3-1' )

select DATEDIFF(YEAR,'2015-3-1','2017-3-2')
select DATEDIFF(SECOND,'2015-3-1','2017-3-2')

select DATEPART(MONTH,'2015-3-1' )
select MONTH('2015-3-1')

