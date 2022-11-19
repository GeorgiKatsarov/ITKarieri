/*problem 1*/
select * from departments;
select name from departments;
select first_name, last_name, salary from employees;
select first_name, middle_name, last_name from  employees;
select concat(first_name, '.', last_name, '@suftuni.bg') as full_email_address from employees;
select distinct salary from employees;
select * from employees where job_title = 'Sales Representative';
select first_name, last_name, job_title  from employees  where salary between 20000 and 30000 ;
select concat(first_name, ' ', middle_name, ' ', last_name) as full_name from employees where salary in (25000, 14000, 12500, 23600);
select first_name, last_name from employees where manager_id is null;
select first_name, last_name, salary from employees where salary > 50000;
/*problem13*/
select first_name, last_name from employees where department_id not in (4);
select distinct job_title from employees;
/*problem16*/
/*problem17*/
update employees set salary = salary + salary*0.12 where department_id in (1, 2, 4, 11);  select salary from employees;

