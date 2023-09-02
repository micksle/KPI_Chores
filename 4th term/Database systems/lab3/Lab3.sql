CREATE DATABASE lab3;
USE lab3;

CREATE TABLE driver (
ID INT NOT NULL AUTO_INCREMENT,
Name VARCHAR(10) NOT NULL,
Surname VARCHAR(10) NOT NULL,
Lastname VARCHAR(10),
Experience DOUBLE NOT NULL,

CHECK (Experience > 0 AND Experience < 45 AND LENGTH(Name) > 1 AND LENGTH(Surname) >= 1),
PRIMARY KEY (ID)
);

CREATE TABLE path (
ID INT NOT NULL AUTO_INCREMENT,
DepartureName VARCHAR(20) NOT NULL,
ArrivalName VARCHAR(20) NOT NULL,

CHECK (LENGTH(DepartureName) > 2 AND LENGTH (ArrivalName) > 2),
PRIMARY KEY (ID)
);

CREATE TABLE route (
ID INT NOT NULL AUTO_INCREMENT,
Path_ID INT NOT NULL,
Distance DOUBLE NOT NULL,
Payment DECIMAL(8,2) NOT NULL, 

CHECK (Distance > 0 AND Payment > 0),
PRIMARY KEY (ID),
CONSTRAINT pathCONST FOREIGN KEY (Path_ID) REFERENCES path(ID) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE transportation (
ID INT NOT NULL AUTO_INCREMENT,
Route_ID INT NOT NULL,
FirstDriver INT NOT NULL,
SecondDriver INT,
DepartureTime DATETIME DEFAULT(current_timestamp()),
ArrivalTime DATETIME DEFAULT(current_timestamp()),
Bonus DECIMAL(4, 2),

PRIMARY KEY (`ID`),
CHECK (DepartureTime <= ArrivalTime AND Bonus <= 100),
CONSTRAINT routeCONST FOREIGN KEY (Route_ID) REFERENCES route(ID)  ON UPDATE CASCADE ON DELETE CASCADE,
CONSTRAINT firstDriverCONST FOREIGN KEY (FirstDriver) REFERENCES driver(ID)  ON UPDATE CASCADE ON DELETE CASCADE,
CONSTRAINT secondDriverCONST FOREIGN KEY (SecondDriver) REFERENCES driver(ID)  ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE salary (
ID INT NOT NULL AUTO_INCREMENT,
Driver INT NOT NULL,
DriversSalary DECIMAL(8,2) NOT NULL,
Route INT NOT NULL,
Experience INT NOT NULL DEFAULT(1),
SecondDriver BOOLEAN NOT NULL,

PRIMARY KEY (ID),
CONSTRAINT transportationCONST FOREIGN KEY (Driver) REFERENCES transportation(ID)  ON UPDATE CASCADE ON DELETE CASCADE
#CONSTRAINT trasnportationCONST FOREIGN KEY (Route) REFERENCES trasnportation(ID)  ON UPDATE CASCADE ON DELETE CASCADE,  #Path
#CONSTRAINT expCONST FOREIGN KEY (Experience) REFERENCES trasnportation(ID)  ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE costOfTransportation (
ID INT NOT NULL AUTO_INCREMENT,
TransportationCost DECIMAL(8,2) NOT NULL,
Salary_ID INT NOT NULL,

PRIMARY KEY (ID),
CONSTRAINT salaryCONST FOREIGN KEY (Salary_ID) REFERENCES salary(ID) ON UPDATE CASCADE ON DELETE CASCADE
);
# -------------- -------------- -------------- DATABASE MANAGEMENT -------------- -------------- --------------
# -------------- -------------- -------------- |-------- --------| -------------- -------------- --------------
SELECT * FROM driver;
SELECT * FROM path;
SELECT * FROM route;
SELECT * FROM transportation;
SELECT * FROM salary;
SELECT * FROM costOfTransportation;

DROP TABLE IF EXISTS  costOfTransportation;
DROP TABLE IF EXISTS  salary;
DROP TABLE IF EXISTS  transportation;
DROP TABLE IF EXISTS  route;
DROP TABLE IF EXISTS  path;
DROP TABLE IF EXISTS  driver;

DROP DATABASE IF EXISTS lab3;
# -------------- -------------- -------------- DATABASE SELECTIONS -------------- -------------- --------------
# -------------- -------------- -------------- |-------- --------| -------------- -------------- --------------

SELECT id, name, surname, experience FROM driver;
     
SELECT Route_ID, departureTime, arrivalTime FROM transportation
	WHERE bonus IS NOT NULL OR NOT secondDriver IS NULL;
    
SELECT * FROM path
	WHERE departureName LIKE '%k';

SELECT ID, departureName FROM path
	WHERE ID NOT BETWEEN 4 AND 9 GROUP BY departureName, ID HAVING departureName NOT LIKE '%k%';
    
SELECT route_id, departureTime, arrivalTime FROM transportation
	WHERE departureTime BETWEEN '2023-03-15 6:00:00' AND '2023-03-15 14:21:00'
		AND NOT departureTime IN('2023-03-15 14:21:00');
    
SELECT * FROM path
	WHERE departureName IN('Dnipro', 'Kyiv');
    
SELECT ID, route_ID, departureTime, ArrivalTime FROM transportation
	WHERE secondDriver IS NULL AND timediff(ArrivalTime, departureTime) < '12:00:00'
		ORDER BY departureTime, route_ID;
    
SELECT ID, path_ID, FORMAT(distance / payment, 2) AS pricePerKilometer FROM route
	ORDER BY pricePerKilometer DESC;
    
SELECT DISTINCT departureName FROM path
	ORDER BY departureName;

SELECT departureName, arrivalName, distance, payment FROM route
	INNER JOIN path 
		WHERE distance > 700 AND NOT payment < 1400 
			AND route.id = path.id;
            
SELECT departureName, arrivalName, distance FROM path AS p
	INNER JOIN route AS r
		WHERE p.id = r.id
			LIMIT 3, 5;
    
SELECT transportation.ID, 
	path.departureName AS departureName,
	path.arrivalName AS arrivalName,
	driver.name AS driver,
	transportation.departureTime, transportation.arrivalTime
		FROM transportation
			INNER JOIN route ON transportation.route_id = route.id
			INNER JOIN path ON route.path_ID = path.ID
            INNER JOIN driver ON transportation.firstDriver = driver.ID
				LIMIT 8;
            
SELECT salary.ID, 
	path.departureName, path.arrivalName,
	driversSalary AS salary,
	experience
		FROM salary 
			LEFT JOIN route ON salary.route = route.id
			LEFT JOIN path ON route.path_ID = path.ID;
            
SELECT salary.ID, 
	driver.name AS name,
	path.departureName,	
    path.arrivalName,
	driversSalary AS salary,
    driver.experience, 
    salary.secondDriver
		FROM salary 
			LEFT JOIN route ON salary.route = route.id
			LEFT JOIN path ON route.path_ID = path.ID
            LEFT JOIN driver ON salary.driver = driver.ID;

SELECT route.ID, departureName, arrivalName, distance, payment FROM route 
	RIGHT JOIN path ON route.path_ID = path.id;
    
SELECT departureName FROM path
	UNION ALL
		SELECT arrivalname FROM path;
        
SELECT departureName FROM path
	UNION
		SELECT arrivalname FROM path;
        
SELECT departureName FROM path
	WHERE departureName LIKE '%k'
		UNION
			SELECT arrivalname FROM path
	WHERE departureName LIKE '%k';
# -------------- -------------- -------------- FILLING IN DATABASE -------------- -------------- --------------
# -------------- -------------- -------------- |-------- --------| -------------- -------------- --------------
INSERT INTO driver (Name, Surname, Lastname, Experience) VALUES
('William', 'nizhen', '', 1),
('Sensoi', 'kortman', 'Vodiy', 17.2),
('Mickle', 'linchet', 'Vairuotoj', 3),
('Julien', 'asomov', 'Vodiyev', 4.4),
('Kortman', 'jesto', '', 9.7),
('Montre', 'nuomi', 'Kierowca', 0.6),
('Luigi', 'qwentus', '', 7.7),
('Alfred', 'sofran', '', 8);


INSERT INTO path (DepartureName, ArrivalName) VALUES
('Kyiv', 'Lviv'),
('Odessa', 'Mariupol'),
('Riga','Lviv'),
('Kyiv', 'Dnipro'),
('Kharkiv', 'Odessa'),
('Crimea', 'Kyiv'),
('Dnipro','Poznań'),
('Zaporizhzhia', 'Kherson'),
('Poltava','Rivne'),
('Kyiv','Tallinn'),
('Vinnitsa','Mykolaiv'),
('Ivano-Frankivsk','Warsaw'),
('Berdyansk','Genichesk'),
('Symu','Poltava'),
('Zhitomir','Mykolaiv'),
('Rivne','Warsaw'),
('Mykolaiv','Dnipro');


INSERT INTO route (Path_ID, Distance, Payment) VALUES
(1, 541, 1090.30),
(4, 485, 1120.90),
(2, 652, 1340.0),
(7, 1050, 2080.30),
(5, 744, 1580.60),
(11, 839, 1600.0),
(8, 314, 899.90),
(3, 1571, 2980.40),
(9, 681, 1470.0),
(10, 1321, 2400.80),
(12, 618, 1360.20),
(6, 463, 999),
(13, 98.2, 450.99);


INSERT INTO transportation (Route_ID, FirstDriver, DepartureTime, ArrivalTime) VALUES
(1, 1,'2023-03-13 22:17:42', '2023-03-14 04:06:51'),
(2, 2, '2023-04-18 14:22:53', current_timestamp()),
(4, 3, '2023-04-16 19:05:23', current_timestamp()),
(9, 5, '2023-03-13 13:11:02', '2023-03-13 23:15:23'),
(11, 7, '2023-04-16 19:05:23', current_timestamp()),
(13, 4, '2023-03-15 07:08:10', '2023-03-15 16:25:31');

INSERT INTO transportation (Route_ID, FirstDriver, DepartureTime, ArrivalTime, Bonus) VALUES
(6, 4, '2023-02-13 22:17:42', '2023-02-14 04:06:51', 9.4),
(10, 3, '2023-03-15 07:08:10', '2023-03-15 16:25:31', 11.8),
(8, 8, '2023-04-18 14:22:53', current_timestamp(), 3.6);

INSERT INTO transportation (Route_ID, FirstDriver, SecondDriver, DepartureTime, ArrivalTime) VALUES
(3, 1, 2, '2023-03-15 13:17:17', '2023-03-16 8:07:03'),
(7, 3, 1, '2023-04-16 16:34:27', '2023-04-16 21:17:07'),
(5, 6, 8, '2023-03-15 13:17:17', '2023-03-16 8:07:03'),
(12, 5, 6, '2023-03-15 15:09:26', '2023-03-15 19:05:34');


INSERT INTO salary (Route, Driver, DriversSalary, SecondDriver) VALUES
(2, 4, 789.9, false),
(5, 1, 623.5, false),
(3, 7, 486.2, true),
(4, 3, 80.8, false),
(1, 2, 1000, true),
(6, 6, 899, false);


INSERT INTO costOfTransportation (TransportationCost, salary_ID) VALUES
(1240.9, 6),
(900, 2),
(715.7, 5),
(520.1, 3),
(1308.10, 1),
(140.8, 4);