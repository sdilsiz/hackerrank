select  s.[Name]  
from Students s inner join Packages ss on s.Id = ss.Id  
                inner join Friends sf on s.Id = sf.Id   
               
                inner join Packages fs on sf.Friend_Id = fs.Id and fs.Salary > ss.Salary
    order by fs.Salary asc;