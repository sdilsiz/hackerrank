declare @asf varchar(max) ;WITH all_numbers(n) AS(    SELECT 2    UNION ALL    SELECT n+1 FROM all_numbers WHERE n < 1000)SELECT @asf =REPLACE(REPLACE( CAST(  (SELECT     CONVERT(VARCHAR ,all1.n  )+'&'from all_numbers all1 where not exists (select 1 from all_numbers all2 where all2.n < all1.n AND all1.n % all2.n = 0)  order by all1.n   FOR XML PATH('')) AS VARCHAR(MAX)),'amp;',''),'997&','997')  OPTION (MAXRECURSION 10000) print(@asf);  