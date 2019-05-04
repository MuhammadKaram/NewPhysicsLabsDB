create database Physics_DB;
use Physics_DB;
create table devices_tb(
	device_name varchar(100) not null,
	device_barcode decimal(50,0) UNIQUE not null,
	lab_name varchar(100) not null,
	device_status varchar(20) not null,
	exp_name varchar(100) not null,
	exp_num int not null,
	respon varchar(100) not null,
	description varchar(250),
	ID int primary key AUTO_INCREMENT
);

create table labs(
	ID int primary key AUTO_INCREMENT,
	lab_name varchar(100) not null
);

create table respon(
	ID int primary key AUTO_INCREMENT,
	name varchar(100) not null
);

create table exp
(	ID int primary key AUTO_INCREMENT,
	exp_name varchar(100) not null,
	exp_num int not null,
	lab_name varchar(100) not null
);

create table AccountTypes(
	ID int primary key AUTO_INCREMENT,
    AccountType varchar(100) not null
);

create table Accounts(
	ID int primary key AUTO_INCREMENT,
	UserName varchar(100) not null,
	UserPassword varchar(255) not null,
    Respon int not null,
	AccountType int not null
);

ALTER TABLE `physics_db`.`accounts` 
ADD INDEX `Accounts_AccountType_ID_idx` (`AccountType` ASC),
ADD INDEX `Accounts_respon_ID_idx` (`Respon` ASC);
ALTER TABLE `physics_db`.`accounts` 
ADD CONSTRAINT `Accounts_AccountType_ID`
  FOREIGN KEY (`AccountType`)
  REFERENCES `physics_db`.`accounttypes` (`ID`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION,
ADD CONSTRAINT `Accounts_respon_ID`
  FOREIGN KEY (`Respon`)
  REFERENCES `physics_db`.`respon` (`ID`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
