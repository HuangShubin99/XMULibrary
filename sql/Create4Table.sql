create database XMULibrary;
use XMULibrary;

--登陆表包括以下字段：
--账号，密码，权限（判断管理员还是读者）
create table loginTable
(
	UserId varchar(30) not null,
	Pswd varchar(30) not null,
	authority varchar(10) not null,
	constraint pk_userid primary key(UserId),
	constraint ck_author check(authority='admin' or authority='reader')
);
alter table loginTable add constraint de_author default 'reader' for authority;
drop table loginTable;

insert into loginTable (UserId,Pswd) values('123','123');
insert into loginTable (UserId,Pswd,authority) values('34520172201453','hsb19990812','admin');
select * from loginTable;

--图书信息表包括以下字段：
--ISBN书号、书名、出版社、作者、馆藏数量、可借数量、是否可借
create table bookTable
(
	ISBN varchar(30) not null,
	BookName varchar(30) not null,
	Publisher varchar(30) not null,
	Author varchar(30) not null,
	CollectionNum int not null check(CollectionNum>=0),
	CanBorrowNum int not null check(CanBorrowNum>=0),
	CanBorrow varchar(10) not null ,
	constraint pk_isbn primary key(ISBN),
	constraint ck_canborrow check(CanBorrow='true' or CanBorrow='false')
);
alter table bookTable add constraint de_collectionnum default 0 for CollectionNum;
alter table bookTable add constraint de_canborrownum default 0 for CanBorrowNum;
alter table bookTable add constraint de_canborrow default 'true' for CanBorrow;

insert into bookTable values('9787111407010','算法导论','机械工业出版社','Thomas H.Cormen',10,10,'true');
update bookTable set CanBorrowNum=9 where BookName='算法导论';
select * from bookTable;

drop table bookTable;

--读者信息表包括以下字段：
--借书证号、姓名、性别、职称、可借数量、已借数量、工作部门、联系电话
create table readerTable
(
	ReaderId varchar(30) not null,
	ReaderName varchar(30) not null,
	Sex varchar(30) not null,
	JobTitle varchar(30) not null,
	CanBorrowNum int not null check (CanBorrowNum>=0),
	BorrowedNum int not null check (BorrowedNum>=0),
	Department varchar(30) not null,
	PhoneNumber varchar(30) not null,
	constraint pk_readerid primary key(ReaderId),
	constraint ck_sex check(Sex='male' or Sex='female')
);
alter table readerTable add constraint de_sex default 'female' for Sex;
alter table readerTable add constraint de_job default 'student' for JobTitle;
alter table readerTable add constraint de_readerCanborrownum default 0 for CanBorrowNum;
alter table readerTable add constraint de_borrowednum default 0 for BorrowedNum;

insert into readerTable values ('27586874','黄书斌','male','student',20,0,'信息学院','18859458156');
update readerTable set CanBorrowNum=19,BorrowedNum=1 where ReaderName='黄书斌';
select * from readerTable;

drop table readerTable;

--借阅信息表包括以下字段：
--借书证号、借阅书号、借出日期、借阅期限、归还日期、罚款。
create table borrowTable
(
	ReaderId varchar(30) not null,
	ISBN varchar(30) not null,
	BorrowedDate varchar(30) not null,
	BorrowPeriod int not null,
	ReturnDate varchar(30) not null,
	Fine int not null check (Fine>=0),
	
	constraint fk_readerid foreign key(ReaderId)
	references readerTable(ReaderId)
	ON UPDATE CASCADE
    ON DELETE CASCADE,
    
	constraint fk_isbn foreign key(ISBN)
	references bookTable(ISBN)
	ON UPDATE CASCADE
    ON DELETE CASCADE,
	
	constraint pk_RI primary key (ReaderId,ISBN)
);
alter table borrowTable add constraint de_Fine default 0 for Fine;

insert into borrowTable values('27586874','9787111407010','2020/5/30','7','2020/6/6',0);
select * from borrowTable;

drop table borrowTable;
