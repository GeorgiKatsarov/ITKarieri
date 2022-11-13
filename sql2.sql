use itcareers1;
create table subjects(
  subject_id int(11) AUTO_INCREMENT primary key,
  subject_name varchar(50) not null
);

create table majors(
   major_id int(11) auto_increment primary key,
   name varchar(50) not null

);

create table students(
   student_id int(11) auto_increment primary key,
   student_number varchar(12) not null,
   student_name varchar(50) not null,
   major_id int(11) not null,
   foreign key (major_id) references majors(major_id)
);

create table payments(
   payment_id int(11) auto_increment primary key,
   payment_date date not null,
   payment_amount decimal(8,2) not null,
   student_id int(11) not null,
   foreign key (student_id) references students(student_id)
);

create table agenda(
    student_id int(11) not null,
    subject_id int(11) not null,
    foreign key (student_id) references students(student_id),
    foreign key (subject_id) references subjects(subject_id)
   
);
