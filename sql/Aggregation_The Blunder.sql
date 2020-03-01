/*
test data
--getdata from @hackerrank
--select 'INSERT INTO @EMPLOYEES SELECT '''+Name+''' ,'''+convert(varchar,salary) +'''' from EMPLOYEES 
declare @EMPLOYEES table (Name varchar(50),salary INT )


INSERT INTO @EMPLOYEES SELECT 'Ashley' ,'2340' 
INSERT INTO @EMPLOYEES SELECT 'Julia' ,'1198' 
INSERT INTO @EMPLOYEES SELECT 'Britney' ,'9009' 
INSERT INTO @EMPLOYEES SELECT 'Kristeen' ,'2341' 
INSERT INTO @EMPLOYEES SELECT 'Dyana' ,'9990' 
INSERT INTO @EMPLOYEES SELECT 'Diana' ,'8011' 
INSERT INTO @EMPLOYEES SELECT 'Jenny' ,'2341' 
INSERT INTO @EMPLOYEES SELECT 'Christeen' ,'2342' 
INSERT INTO @EMPLOYEES SELECT 'Meera' ,'2343' 
INSERT INTO @EMPLOYEES SELECT 'Priya' ,'2344' 
INSERT INTO @EMPLOYEES SELECT 'Priyanka' ,'2345' 
INSERT INTO @EMPLOYEES SELECT 'Paige' ,'2346' 
INSERT INTO @EMPLOYEES SELECT 'Jane' ,'2347' 
INSERT INTO @EMPLOYEES SELECT 'Belvet' ,'2348' 
INSERT INTO @EMPLOYEES SELECT 'Scarlet' ,'2349' 
INSERT INTO @EMPLOYEES SELECT 'Salma' ,'9087' 
INSERT INTO @EMPLOYEES SELECT 'Amanda' ,'7777' 
INSERT INTO @EMPLOYEES SELECT 'Aamina' ,'5500' 
INSERT INTO @EMPLOYEES SELECT 'Amina' ,'2570' 
INSERT INTO @EMPLOYEES SELECT 'Ketty' ,'2007' 

select CEILING(avg(cast (salary as decimal(18,3))) - avg (cast(replace(convert(varchar,salary),'0','') as decimal(18,3)))) from @EMPLOYEES
*/

--hackerrank 

select CEILING(avg(cast (salary as decimal(18,3))) - avg (cast(replace(convert(varchar,salary),'0','') as decimal(18,3)))) from EMPLOYEES