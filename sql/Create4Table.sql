create database XMULibrary;
use XMULibrary;

--��½����������ֶΣ�
--�˺ţ����룬Ȩ�ޣ��жϹ���Ա���Ƕ��ߣ�
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

--ͼ����Ϣ����������ֶΣ�
--ISBN��š������������硢���ߡ��ݲ��������ɽ��������Ƿ�ɽ�
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

insert into bookTable values('9787111407010','�㷨����','��е��ҵ������','Thomas H.Cormen',10,10,'true');
update bookTable set CanBorrowNum=9 where BookName='�㷨����';
select * from bookTable;

drop table bookTable;

--������Ϣ����������ֶΣ�
--����֤�š��������Ա�ְ�ơ��ɽ��������ѽ��������������š���ϵ�绰
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

insert into readerTable values ('27586874','�����','male','student',20,0,'��ϢѧԺ','18859458156');
update readerTable set CanBorrowNum=19,BorrowedNum=1 where ReaderName='�����';
select * from readerTable;

drop table readerTable;

--������Ϣ����������ֶΣ�
--����֤�š�������š�������ڡ��������ޡ��黹���ڡ����
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
