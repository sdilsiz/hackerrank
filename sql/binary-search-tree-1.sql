/*
Test Data
declare @BST table (N INT ,p INT NULL)
--Root: If node is root node.
--Leaf: If node is leaf node.
--Inner: If node is neither root nor leaf node.
INSERT INTO @BST SELECT '1','2' 
INSERT INTO @BST SELECT '3','2' 
INSERT INTO @BST SELECT '5','6' 
INSERT INTO @BST SELECT '7','6' 
INSERT INTO @BST SELECT '2','4' 
INSERT INTO @BST SELECT '6','4' 
INSERT INTO @BST SELECT '4','15' 
INSERT INTO @BST SELECT '8','9' 
INSERT INTO @BST SELECT '10','9' 
INSERT INTO @BST SELECT '12','13' 
INSERT INTO @BST SELECT '14','13' 
INSERT INTO @BST SELECT '9','11' 
INSERT INTO @BST SELECT '13','11' 
INSERT INTO @BST SELECT '11','15' 
INSERT INTO @BST SELECT '15',NULL


SELECT distinct  N,CASE WHEN P IS NULL  THEN 'Root'  when exists (select * from @BST p where p.p=x.N) then 'Inner' else 'Leaf' End FROM @BST x  

*/
--hackerrank
SELECT distinct  N,CASE WHEN P IS NULL  THEN 'Root'  when exists (select * from BST p where p.p=x.N) then 'Inner' else 'Leaf' End FROM BST x  

   