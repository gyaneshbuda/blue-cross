-- 1. Using the table structure you defined, write a SQL query that retrieves all users that have rented more than one movie. Provide the UserID for each record and do not retrieve duplicate UserIDs

SELECT U.UserID, COUNT(*) as 'Movies Rented' FROM [USER] U
INNER JOIN RENTAL R
ON U.UserID = R.UserID
WHERE R.APPROVAL = 1
GROUP BY (U.UserID) HAVING COUNT(*) > 1


-- 2. Using the table structure you defined, write a SQL query that returns the top 3 users that rented that most movies.  Provide the complete user record for each username. 
SELECT * FROM [User] WHERE UserId in (
	SELECT TOP 3 U.UserID FROM [USER] U
	INNER JOIN RENTAL R
	ON U.UserID = R.UserID
	WHERE R.APPROVAL = 1
	GROUP BY (U.UserID)  
	Order By COUNT(*) desc
) 

