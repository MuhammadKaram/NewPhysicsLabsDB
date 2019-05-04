use physics_db;
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