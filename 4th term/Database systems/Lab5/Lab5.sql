CREATE DATABASE lab5;
USE lab5;


CALL create_tables;
CALL fill_values;
CALL add_extra_values;
CALL select_tables;

SELECT * FROM driver;
SELECT * FROM expenses;
SELECT * FROM route;
SELECT * FROM transportation;
SELECT * FROM salary;
SELECT * FROM costOfTransportation;
# -------------- -------------- -------------- DATABASE MANAGEMENT -------------- -------------- --------------
# -------------- -------------- -------------- |-------- --------| -------------- -------------- --------------
DELIMITER $$
CREATE PROCEDURE create_tables()
BEGIN
CREATE TABLE driver (
	ID INT NOT NULL AUTO_INCREMENT,
	Name VARCHAR(10) NOT NULL,
	Surname VARCHAR(10) NOT NULL,
	Lastname VARCHAR(10),
	Experience DOUBLE NOT NULL,

	CHECK (Experience > 0 AND Experience < 45 AND LENGTH(Name) > 1 AND LENGTH(Surname) >= 1),
	PRIMARY KEY (ID)
);

CREATE TABLE expenses(
	ID INT NOT NULL AUTO_INCREMENT, 
	Name VARCHAR(20) NOT NULL,
	Sum DOUBLE NOT NULL,
	Comment VARCHAR(40) DEFAULT(NULL),

	PRIMARY KEY(ID)
);

CREATE TABLE route (
	ID INT NOT NULL AUTO_INCREMENT,
	DepartureName VARCHAR(20) NOT NULL,
	ArrivalName VARCHAR(20) NOT NULL,
	Distance DOUBLE NOT NULL,
	Payment DECIMAL(8,2) NOT NULL,
    Expenses DOUBLE,

	CHECK (Distance > 0 AND Payment > 0 AND Expenses > 0),
	CHECK (LENGTH(DepartureName) > 2 AND LENGTH(ArrivalName) > 2),
	PRIMARY KEY (ID)
);

CREATE TABLE transportation (
	ID INT NOT NULL AUTO_INCREMENT,
	Route_ID INT NOT NULL,
	FirstDriver_ID INT NOT NULL,
	SecondDriver_ID INT,
	DepartureTime DATETIME DEFAULT(current_timestamp()),
	ArrivalTime DATETIME DEFAULT(current_timestamp()),
	Bonus DOUBLE,

	PRIMARY KEY (`ID`),
	CHECK (DepartureTime <= ArrivalTime AND Bonus <= 100),
	CONSTRAINT t_route_CONST FOREIGN KEY (Route_ID) REFERENCES route(ID) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT t_firstDriver_CONST FOREIGN KEY (FirstDriver_ID) REFERENCES driver(ID) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT t_secondDriver_CONST FOREIGN KEY (SecondDriver_ID) REFERENCES driver(ID) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE salary(
	ID INT NOT NULL AUTO_INCREMENT, 
	Transportation_ID INT NOT NULL,
	Driver_ID INT NOT NULL,
	TotalSalary INT,

	PRIMARY KEY(ID),
	CONSTRAINT s_transportation_CONST FOREIGN KEY (Transportation_ID) REFERENCES transportation(ID) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT s_driver_CONST FOREIGN KEY (Driver_ID) REFERENCES driver(ID) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE costOfTransportation (
	ID INT NOT NULL AUTO_INCREMENT,
	Salary_ID INT NOT NULL,
    Salary INT NOT NULL,
    Expenses DOUBLE NOT NULL,
	FullCost DOUBLE NOT NULL,
    
	PRIMARY KEY (ID),
	CONSTRAINT COT_salary_ID_CONST FOREIGN KEY (Salary_ID) REFERENCES salary(ID) ON UPDATE CASCADE ON DELETE CASCADE
);
END $$
DELIMITER ;
CALL create_tables;

DELIMITER $$
CREATE PROCEDURE fill_values()
BEGIN
INSERT INTO driver (Name, Surname, Lastname, Experience) VALUES
	('William', 'nizhen', NULL, 1),
	('Arseno', 'Karavadzho', 'Sentinelev', 4.4),
	('Sensoi', 'kortman', 'Vodiy', 3),
	('Mickle', 'linchet', 'Vairuotoj', 17.2),
	('Julien', 'asomov', 'Vodiyev', 5.2),
	('Kortman', 'jesto', NULL, 9.7),
	('Montre', 'nuomi', 'Kierowca', 0.6),
	('Luigi', 'qwentus', NULL, 7.7),
	('Alfred', 'sofran', NULL, 8);

INSERT INTO expenses (Name, Sum, Comment) VALUES
    ('Supplies', 0.13, 'Oil, coolant'),
	('Fuel', 1.12, NULL),
    ('Permission', 200, 'UA-EU - passing the border');
	#('Overload', 50, 'Overloading the vehicle`s weight');
    
INSERT INTO route (DepartureName, ArrivalName, Distance, Payment) VALUES
	('Kyiv', 'Lviv', 541, 1090.30),
	('Odessa', 'Mariupol', 652, 1340.0),
	('Riga','Lviv', 1571, 2980.40),
	('Kyiv', 'Dnipro', 485, 1120.90),
	('Kharkiv', 'Odessa', 744, 1580.60),
	('Crimea', 'Kyiv', 463, 999),
	('Dnipro','Poznań', 1050, 2080.30),
	('Zaporizhzhia', 'Kherson', 314, 899.90),
	('Poltava','Rivne', 681, 1470.0),
	('Kyiv','Tallinn', 1321, 2400.80),
	('Vinnitsa','Mykolaiv', 839, 1600.0),
	('Ivano-Frankivsk','Warsaw', 618, 1360.20),
	('Berdyansk','Genichesk', 98.2, 450.99),
	('Symu','Poltava', 954, 1570.3);

INSERT INTO transportation (Route_ID, FirstDriver_ID, DepartureTime, ArrivalTime) VALUES
	(1, 7,'2023-03-13 22:17:42', '2023-03-14 04:06:51'),
	(2, 2, '2023-04-18 14:22:53', current_timestamp()),
	(4, 5, '2023-04-16 19:05:23', current_timestamp()),
	(9, 3, '2023-03-13 13:11:02', '2023-03-13 23:15:23'),
	(11, 1, '2023-04-17 19:05:23', current_timestamp()),
	(13, 4, '2023-03-15 07:08:10', '2023-03-15 16:25:31');

INSERT INTO transportation (Route_ID, FirstDriver_ID, SecondDriver_ID, DepartureTime, ArrivalTime, Bonus) VALUES
	(3, 3, 7, '2023-04-23 23:11:02', '2023-04-24 19:27:03', 6.6),
    (11, 1, 2, '2023-05-18 13:17:17', '2023-05-19 10:47:02', NULL),
	(7, 3, 1, '2023-04-20 16:34:27', '2023-04-21 01:30:07', NULL),
	(5, 6, 8, '2023-03-12 13:17:17', '2023-03-16 8:07:03', 7.2),
	(12, 5, 6, '2023-03-27 15:09:26', '2023-03-28 08:03:54', NULL);

INSERT INTO transportation (Route_ID, FirstDriver_ID, DepartureTime, ArrivalTime, Bonus) VALUES
	(6, 4, '2023-02-13 22:17:42', '2023-02-14 04:06:51', 9.4),
	(10, 3, '2023-05-27 07:08:10', '2023-05-27 23:59:01', 11.8),
	(4, 7, '2023-05-03 14:00:23', '2023-05-03 23:25:31', 2.8),
	(3, 8, '2023-04-12 14:22:53', current_timestamp(), 3.6);

INSERT INTO salary (Transportation_ID, Driver_ID)
	SELECT transportation.ID, transportation.FirstDriver_ID  FROM transportation;
END $$
DELIMITER ;
CALL fill_values;

# |---------------------------------------------------------------|
DELIMITER $$
CREATE PROCEDURE define_EU(IN Route_ID INT, OUT IsEU BOOLEAN)
BEGIN
	SET @DepartureName = (SELECT DepartureName FROM route WHERE Route_ID = route.ID);
	SET @ArrivalName = (SELECT ArrivalName FROM route WHERE Route_ID = route.ID);
    
	SET IsEU = (CASE
		WHEN (@DepartureName IN('Riga', 'Warsaw', 'TalliNn', 'Poznań')
			OR @ArrivalName IN('Riga', 'Warsaw', 'TalliNn', 'Poznań'))
            THEN true
		ELSE
			false
        END);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE count_expenses(IN Route_ID INT)
BEGIN
    DECLARE isEU BOOLEAN;
    
	SET @Distance = (SELECT Distance FROM route WHERE Route_ID = route.ID);

    -- Виклик процедури define_EU та отримання значень
    CALL define_EU(Route_ID, isEU);
    
    -- SET @IsEU = (SELECT Route_id, @IsEU FROM define_EU);
    
	SET @Fuel = (SELECT Sum FROM expenses WHERE Name = 'Fuel');
	SET @Supplies = (SELECT Sum FROM expenses WHERE Name = 'Supplies');
	SET @Permission = (SELECT Sum FROM expenses WHERE Name = 'Permission');
    
    # 17 - fuel comsamption by the bus, 0.4 - supplies per 1000 km
    SET @BasicExpenses = (((@Distance * 17) / 100) * @Fuel) + (((@Distance * 0.4) / 1000) * @Supplies); # fuel + supplies
    SET @ExtraExpenses = IF(isEU = true, @Permission, 0);
    
	UPDATE route SET Expenses = FORMAT((@BasicExpenses + @ExtraExpenses), 2) WHERE route.ID = Route_ID;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE count_total_salary(IN Salary_ID INT)
BEGIN
	IF (SELECT SecondDriver_ID FROM salary AS s
		INNER JOIN transportation ON s.transportation_ID = transportation.ID WHERE s.ID = Salary_ID)
		IS NOT NULL THEN SET @SecondDriverValue = true;
	ELSE 
		SET @SecondDriverValue = false;
	END IF;
    
	SET @PaymentValue = (
		SELECT r.Payment FROM salary AS s
		INNER JOIN transportation AS t ON s.transportation_ID = t.ID
		INNER JOIN route AS r ON t.route_ID = r.ID
        WHERE s.ID = Salary_ID
	);
        
	SET @ExperienceValue = (SELECT Experience FROM salary AS s
		INNER JOIN transportation AS t ON s.transportation_ID = t.ID
		INNER JOIN driver AS d ON d.ID = t.FirstDriver_ID WHERE s.ID = Salary_ID);  -- OR d.ID = t.SecondDriver_ID) 
        
	SET @BonusValue = (SELECT Bonus FROM salary AS s
		INNER JOIN transportation AS t ON s.transportation_ID = t.ID WHERE s.ID = Salary_ID);

    SET @FinalPayment = @PaymentValue;
    SET @ExperienceGT4 = (@PaymentValue * 0.05);
    SET @ExperienceGT10 = (@PaymentValue * 0.1);
    SET @TwoDrivers = (@PaymentValue * 0.3); 
    SET @Bonus = (@PaymentValue * @BonusValue / 100);
    
	IF @SecondDriverValue = true THEN
		SET @FinalPayment = @TotalValue - @TwoDrivers;
	END IF;
    
    IF @BonusValue IS NOT NULL THEN
		SET @FinalPayment = @FinalPayment + @Bonus;
	END IF;
    
    IF @ExperienceValue >= 10 THEN
		SET @FinalPayment = @FinalPayment + @ExperienceGT10; 
	ELSEIF @Experience >= 4 AND @Experience < 10 THEN
		SET @FinalPayment = @FinalPayment + @ExperienceGT4; 
    END IF;
    
	UPDATE salary SET TotalSalary = ROUND(@FinalPayment) WHERE salary.ID = Salary_ID;
END $$
DELIMITER ;
# |---------------------------------------------------------------|

DELIMITER $$
CREATE PROCEDURE add_extra_values()
BEGIN
	CALL count_expenses(1);
	CALL count_expenses(2);
	CALL count_expenses(3);
	CALL count_expenses(4);
	CALL count_expenses(5);
	CALL count_expenses(6);
	CALL count_expenses(7);
	CALL count_expenses(8);
	CALL count_expenses(9);
	CALL count_expenses(10);
	CALL count_expenses(11);
	CALL count_expenses(12);
	CALL count_expenses(13);
	CALL count_expenses(14);
	CALL count_expenses(15);
	
	CALL count_total_salary(1);
	CALL count_total_salary(2);
	CALL count_total_salary(3);
	CALL count_total_salary(4);
	CALL count_total_salary(5);
	CALL count_total_salary(6);
	CALL count_total_salary(7);
	CALL count_total_salary(8);
	CALL count_total_salary(9);
	CALL count_total_salary(10);
	CALL count_total_salary(11);
	CALL count_total_salary(12);
	CALL count_total_salary(13);
	CALL count_total_salary(14);
	CALL count_total_salary(15);
	
	INSERT INTO costOfTransportation (Salary_ID, Salary, Expenses, FullCost) 
		SELECT s.ID, s.TotalSalary, r.Expenses, ROUND((s.TotalSalary + r.Expenses), 2) FROM salary AS s
			INNER JOIN transportation AS t ON s.Transportation_ID = t.ID
			INNER JOIN route AS r ON r.ID = t.Route_ID;
END $$
DELIMITER ;
CALL add_extra_values;

DELIMITER $$
CREATE PROCEDURE select_tables()
BEGIN
	SELECT * FROM driver;
	SELECT * FROM expenses;
	SELECT * FROM route;
	SELECT * FROM transportation;
	SELECT * FROM salary;
	SELECT * FROM costOfTransportation;
END $$
DELIMITER ;
CALL select_tables;

DELIMITER $$
CREATE PROCEDURE delete_tables()
BEGIN
	DROP TABLE IF EXISTS costOfTransportation;
	DROP TABLE IF EXISTS salary;
	DROP TABLE IF EXISTS transportation;
	DROP TABLE IF EXISTS route;
    DROP TABLE IF EXISTS expenses;
	DROP TABLE IF EXISTS driver;
END $$
DELIMITER ;
CALL delete_tables;


DROP PROCEDURE IF EXISTS create_tables;
DROP PROCEDURE IF EXISTS fill_values;
DROP PROCEDURE IF EXISTS add_extra_values;
DROP PROCEDURE IF EXISTS select_tables;
DROP PROCEDURE IF EXISTS delete_tables;

DROP PROCEDURE IF EXISTS define_EU;
DROP PROCEDURE IF EXISTS count_expenses;
DROP PROCEDURE IF EXISTS count_total_salary;

DROP DATABASE IF EXISTS lab5;
# -------------- -------------- -------------- RELATOINAL  ALGEBRA -------------- -------------- --------------
# -------------- -------------- -------------- |----- LAB6 ------| -------------- -------------- --------------





# -------------- -------------- -------------- CASE & IF STATEMENT -------------- -------------- --------------
# -------------- -------------- -------------- |----- LAB5 ------| -------------- -------------- --------------
-- ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES
SET SQL_SAFE_UPDATES = 0;
SET @@sql_mode = "NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION";

# |-------- ПРИКЛАДИ ЗАПИТУ З ВИКОРИСТАННЯМ ВИРАЗУ CASE --------| 

SELECT ID, name, CASE 
	WHEN (lastName = '' OR lastName IS NULL) THEN 'European'
    WHEN lastName IS NOT NULL THEN 'post-Soviet'
    END AS 'citizen'
	FROM driver;

SELECT ID, departureName, arrivalName, max(payment) AS 'MAX_payment', CASE 
	WHEN payment > 1400 THEN 'high'
    WHEN payment > 900 THEN 'medium'
    ELSE 'low' 
    END AS 'status'
	FROM route AS r 
	GROUP BY status ORDER BY MAX_payment;

# |-------- ПРИКЛАДИ ЗАПИТУ З ВИКОРИСТАННЯМ ОПЕРАТОРА UNION --------| 

CREATE TABLE available_cities
	SELECT departureName AS City FROM route
	UNION
	SELECT arrivalname FROM route;
    
DROP TABLE IF EXISTS available_cities;
SELECT * FROM available_cities;

SELECT city, CASE 
	WHEN city IN('Riga', 'Warsaw', 'TalliNn', 'Poznań') THEN 'European'
    ELSE CASE 
		WHEN city IN('Dnipro', 'Zaporizhzhia', 'Mariupol', 'Berdyansk', 'Poltava', 'Kharkiv') THEN 'East'
        WHEN city IN('Kyiv', 'Symu') THEN 'North'
        WHEN city IN('Crimea', 'Odessa', 'Kherson', 'Mykolaiv', 'Genichesk') THEN 'South'
        ELSE 'West'
        END
    END AS 'belonging'
	FROM available_cities
    ORDER BY belonging;
    
# |-------- ПРИКЛАДИ ЗАПИТУ З ВИКОРИСТАННЯМ ІНСТРУКЦІЇ IF --------| 

SELECT ID, 
	DepartureName,
	ArrivalName, 
    Distance,
    IF (Distance < 300, 'short', IF(Distance < 700, 'medium', 'long')) AS Distance_Type,
	Payment
FROM route
ORDER BY Distance_Type DESC;

# |-------- ПРИКЛАДИ ЗАПИТУ З ВИКОРИСТАННЯМ CASE В РІЗНИХ РОЗДІЛАХ ПОШУКОВОГО ЗАПИТУ --------| 

SELECT *,
	TRUNCATE((Expenses / Payment) * 100, 2) AS Сorrelation,
    TRUNCATE(MAX((Expenses / Payment) * 100), 2) AS 'MaxValue',
    TRUNCATE(AVG((Expenses / Payment) * 100), 2) AS 'AvgValue'
    FROM route
	GROUP BY CASE 
		WHEN Сorrelation >= 15 THEN 1
		WHEN Сorrelation >= 7 THEN 2
        ELSE 3
        END
    ORDER BY Сorrelation DESC;

SELECT 
	r.ID AS Route_ID,
	r.DepartureName,
	r.ArrivalName,
	d.ID AS Driver_ID,
	d.Name,
	d.Surname,
	d.Experience,
	r.Distance,
	r.Payment
FROM route AS r
	CROSS JOIN driver AS d
	WHERE d.Experience = (
		SELECT MAX(Experience) FROM driver)
	AND r.Distance = (
		SELECT MAX(Distance) FROM route);
        
# |-------- ПРИКЛАДИ ВИКОРИСТАННЯ CASE або IF В ЗАПИТАХ UPDATE, DELETE --------| 
 
CREATE TABLE tempTable SELECT * FROM costOfTransportation; 
DROP TABLE tempTable;

SELECT * FROM tempTable;
SELECT * FROM costOfTransportation;
    
UPDATE tempTable
SET Salary = 
  CASE
    WHEN Salary < (SELECT AVG(FullCost) FROM costOfTransportation) 
		THEN Salary + (Salary * 5 / 100)
    WHEN Salary >= (SELECT AVG(FullCost) FROM costOfTransportation)
		THEN Salary + (Salary * 2 / 100)
    ELSE Salary
  END;
    
DELETE FROM tempTable WHERE ID 
	IN (SELECT tempTable.ID FROM (
		SELECT t.ID, 
			IF (c.FullCost > (SELECT AVG(FullCost) FROM costOfTransportation), '1', '2') AS group_name
		FROM tempTable t
		JOIN costOfTransportation c ON t.ID = c.ID) AS subquery 
		WHERE group_name = '1' OR group_name = '2') 
	ORDER BY tempTable.FullCost DESC
	LIMIT 2;

# |-------- ПРИКЛАДИ ЗАПИТУ З ВИКОРИСТАННЯМ ФУНКЦІЇ COALESCE --------| 

SELECT 
	t.ID,
	r.DepartureName,
    r.ArrivalName,
	t.FirstDriver_ID,
    COALESCE(SecondDriver_ID, 'missing') AS 'Partner'
	FROM transportation AS t
	INNER JOIN route AS r ON t.route_ID = r.ID;

SELECT 
	s.ID, 
    d.Name, 
    d.Surname, 
    COALESCE(d.Lastname, '-') AS Lastname,
    r.DepartureName,
    r.ArrivalName, 
    CONCAT(
        DATE_FORMAT(t.ArrivalTime, '%H'),
        ':',
        DATE_FORMAT(t.ArrivalTime, '%i'),
        ' - ',
        DATE_FORMAT(t.ArrivalTime, '%d'),
        '/',
        DATE_FORMAT(t.ArrivalTime, '%m')
    ) AS ArrivalTime, 
    CASE
		WHEN SecondDriver_ID IS NULL THEN '-'
		ELSE '+'
	END AS 'Second_driver',
    s.TotalSalary
FROM salary AS s
	LEFT JOIN transportation AS t ON Transportation_ID = t.ID
	LEFT JOIN driver AS d ON d.ID = Driver_ID
	LEFT JOIN route AS r ON Route_ID = r.ID;
# -------------- -------------- -------------- DATABASE SELECTIONS -------------- -------------- --------------
# -------------- -------------- -------------- |----- LAB3 ------| -------------- -------------- --------------

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

# -------------- -------------- --------------  DATABASE GROUPING  -------------- -------------- --------------
# -------------- -------------- -------------- |----- LAB4 ------| -------------- -------------- --------------
SELECT AVG(experience) FROM driver;

SELECT COUNT(experience) AS number,
	AVG(experience) AS avarage_exp 
		FROM driver GROUP BY experience;
    
SELECT MIN(driversSalary) FROM salary;

SELECT MIN(departureName) FROM path;

SELECT MAX(departureName) FROM path;

SELECT SUM(distance)/AVG(payment) AS price_per_km FROM route;

SELECT AVG(timediff(ArrivalTime, departureTime))/86400 AS AVG_days
	FROM transportation;

SELECT COUNT(arrivalName) AS arrival_places_num FROM path;
SELECT COUNT(DISTINCT arrivalName) FROM path;
SELECT arrivalName,
	COUNT(arrivalName) AS num 
		FROM path 
			GROUP BY arrivalName #, departureName
				ORDER BY num DESC;
SELECT arrivalName,
	COUNT(DISTINCT arrivalName) AS arrival_places_num FROM path
	GROUP BY arrivalName;

SELECT departureName, 
	COUNT(arrivalName) AS arrival_places_num
    FROM path
	GROUP BY departureName;

SELECT * FROM path 
	GROUP BY ID
		HAVING arrivalName NOT IN ('Dnipro', 'Mykolaiv', 'Rivne');

SELECT driver, driversSalary, route FROM salary
	GROUP BY ID
		HAVING driversSalary > some(SELECT AVG(driversSalary) FROM salary);
        
SELECT name,
	surname, 
	COUNT(firstDriver) AS orders_quantity
		FROM transportation AS t
			INNER JOIN driver ON t.firstDriver = driver.ID
				GROUP BY firstDriver
					HAVING orders_quantity >= 2;
                    
SELECT path_ID,
	SUM(distance) AS total_distance,
	TRUNCATE(AVG(payment), 2) AS avg_payment 
		FROM route 
			WHERE path_ID > 3 AND NOT path_ID > 12
				GROUP BY path_ID, distance, payment
					HAVING payment > 1200 AND total_distance NOT IN (618);