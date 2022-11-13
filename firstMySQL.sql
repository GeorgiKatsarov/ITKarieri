create database itCareers1;

use itCareers1;
create table people(
   id int auto_increment primary key,
   first_name varchar(30) not null,
   last_name varchar(30) not null,
   age tinyint not null,
   person_id varchar(10) not null,
   gender varchar(10)

);

insert into people(first_name, last_name, age, person_id, gender)
values
('Ivan', 'Petrov', 24, '1234567890', 'm'),
('Maria', 'Petrova', 22, '1234567890', 'f'),
('Georgi', 'Petrov', 29, '1234567890', 'm');

select * from people;

create table towns(
   id int auto_increment primary key,
   name varchar(20) not null
);

select * from towns;

insert into towns(name) values
  ('Plovdiv'),
  ('Sofia'),
  ('Varna');

create table people_towns(
    person_id int not null,
    town_id int not null,
    foreign key (person_id) references people(id),
    foreign key (town_id) references towns(id)
);
select * from people_towns;
insert into people_towns values 
(1,3),
(2,1),
(3,2);


create table minions(
  id int auto_increment primary key,
  name varchar(10) not null,
  age int not null,
  town_id int not null,
  foreign key (town_id) references towns(id)
);

insert into minions(name, age, town_id)
values
('Kevin', 22, 1),
('Bob', 15, 3),
('Steward', 20, 2);

select * from minions;
select name from minions;

