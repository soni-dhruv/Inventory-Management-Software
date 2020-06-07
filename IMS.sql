create database IMS
use IMS
drop table login
create table login(fName varchar(20), lName varchar(20), mobileNo bigint , userName varchar(30), password varchar(20))
select * from login
insert into login values('Dhruv', 'Soni', 9967164404, 'dhruvsoni', '0502dHRuV!')
insert into login values('Dinesh', 'Soni', 9892469584, 'dineshsoni', '1603dINeSh!')