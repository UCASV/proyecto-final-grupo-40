CREATE DATABASE project_BDD_POO;
USE project_BDD_POO;

CREATE TABLE CABIN(
	id int primary key auto_increment,
    direction varchar(30),
    phone varchar(15),
    manager_name varchar(30),
    mail varchar(20)
);

CREATE TABLE EMPLOYEE(
	id int primary key auto_increment,
    employee_name varchar(30),
    institutional_mail varchar(30),
    direction varchar(30),
    employee_type varchar(20),
    employee_user varchar(25),
    employee_password varchar(8)
);


CREATE TABLE EMPLOYEExCABIN(
	id int primary key auto_increment,
	cabin_id int,
    employee_id int,
    login datetime,
    logout datetime
);

CREATE TABLE CITIZEN(
	id int primary key auto_increment,
	DUI varchar(15),
	citizen_name varchar(30),
    address varchar(200),
    phone varchar(15),
    age int,
    institutional_id varchar(50),
    mail varchar(60),
    cabin_id int
);

CREATE TABLE DISEASE(
	id int primary key auto_increment,
    diseasea_name varchar(40)
);

CREATE TABLE CITIZENXDISEASE(
	id int primary key auto_increment,
	citizen_id int,
    disease_id int
);

CREATE TABLE APPOINTMENT_ONE(
	id int primary key auto_increment,
    date_appointment datetime,
    place varchar(30),
    row_date datetime,
    vaccination_date datetime,
    side_effect_time time,
    employee_id int,
    citizen_id int
);

CREATE TABLE APPOINTMENT_TWOO(
	id int primary key auto_increment,
    date_appointment datetime,
    place varchar(30),
    row_date datetime,
    vaccination_date datetime,
    side_effect_time time,
    employee_id int,
    citizen_id int
);

create table INSTITUTIONAL_ID(
	id int primary key auto_increment,
    identificator varchar(10),
    citizen_id int
);


alter table EMPLOYEExCABIN add constraint FK_employexcabin
	foreign key(cabin_id) references CABIN(id);
    
alter table EMPLOYEExCABIN add constraint FK_employexcabin_employee
	foreign key(employee_id) references EMPLOYEE(id);
    
alter table CITIZENXDISEASE add constraint FK_citizenxdisease_citizen
	foreign key(citizen_id) references CITIZEN(id);

alter table CITIZENXDISEASE add constraint FK_citizenxdisease_disease
	foreign key(disease_id) references DISEASE(id);
    
alter table CITIZEN add constraint FK_cabin
	foreign key(cabin_id ) references CABIN(id);
    
alter table APPOINTMENT_ONE add constraint FK_citizen_one
	foreign key(citizen_id ) references CITIZEN(id);

 alter table APPOINTMENT_TWOO add constraint FK_citizen_twoo
	foreign key(citizen_id ) references CITIZEN(id);
    
alter table APPOINTMENT_ONE add constraint FK_employee_one
	foreign key(employee_id ) references EMPLOYEE(id);
    
alter table APPOINTMENT_TWOO add constraint FK_employee_twoo
	foreign key(employee_id ) references EMPLOYEE(id);
    
alter table INSTITUTIONAL_ID add constraint FK_inst_id_citizen
	foreign key(citizen_id ) references CITIZEN(id);
    
insert into EMPLOYEE(employee_name,institutional_mail,direction,employee_type,employee_user,employee_password) 
	values ('Roberto Ramirez','roberC123@gob.sv','Casa 23A, Cima 1, San Salvador','vacunador','alejandro039','yejxb010');
insert into EMPLOYEE(employee_name,institutional_mail,direction,employee_type,employee_user,employee_password)
	values ('Enrique Pania','enrique05@gob.sv','Pasaje 3, Colonia Miramonte','Asistente de Salud','regenor56','ueybeu32');
insert into EMPLOYEE(employee_name,institutional_mail,direction,employee_type,employee_user,employee_password) 
	values ('Josue Machado','machado2828@gob.sv','Casa 12, Colonia Buenos Aires','vacunador','keknes','iiene9se');
insert into EMPLOYEE ( employee_name,institutional_mail,direction,employee_type,employee_user,employee_password)
	values ('Laura Sisco','lsisco95@gob.sv','los Heroes, San Salvador','Encargado de cabina','inneuuw2','jejndp0');
insert into EMPLOYEE ( employee_name,institutional_mail,direction,employee_type,employee_user,employee_password)
	values ('Julian Ochoa','roberC123@gob.sv','Lot San Antonio, Sonsonate','vacunador','jnnduwo3','unneue9');
    
insert into CABIN( direction,phone,manager_name,mail) values ('Caluco, sonsonate','50322838493','Roberto Ramirez','cabina1Caluco@gob.sv');

insert into INSTITUTIONAL_ID(identificator) values ('MINED');
insert into INSTITUTIONAL_ID(identificator) values ('PNC');
insert into INSTITUTIONAL_ID(identificator) values ('FA');
insert into INSTITUTIONAL_ID(identificator) values ('MINSAL');

insert into DISEASE (diseasea_name)values ('Cancer');
insert into DISEASE (diseasea_name)values ('Demencia');
insert into DISEASE (diseasea_name)values ('Artritis');
insert into DISEASE (diseasea_name)values ('VIH/SIDA');
insert into DISEASE (diseasea_name)values ('Asma');
insert into DISEASE (diseasea_name)values ('Epilepsia');
insert into DISEASE (diseasea_name)values ('Diabetes');
insert into DISEASE (diseasea_name)values ('Enfermedad del corazon');

SELECT * FROM INSTITUTIONAL_ID;

SELECT * FROM EMPLOYEE;

SELECT * FROM CITIZEN;

SELECT * FROM DISEASE;

SELECT * FROM CITIZENXDISEASE;

SELECT * FROM APPOINTMENT_ONE;

