CREATE DATABASE lab6;
USE lab6;

CALL create_tables;
CALL fill_values;
CALL select_tables;

CALL delete_tables;

SELECT * FROM driver;
SELECT * FROM expenses;
SELECT * FROM route;
SELECT * FROM transportation;
SELECT * FROM salary;
SELECT * FROM Cost_Of_Transportation;

DROP DATABASE IF EXISTS lab6;
# -------------- -------------- -------------- DATABASE MANAGEMENT -------------- -------------- --------------
# -------------- -------------- -------------- |-------- --------| -------------- -------------- --------------
DELIMITER $$													
CREATE PROCEDURE create_tables()									-- procedure to automaticly create all the needed tables
BEGIN
CREATE TABLE driver (
	ID INT NOT NULL AUTO_INCREMENT,
	Name VARCHAR(15) NOT NULL,
	Surname VARCHAR(15) NOT NULL,
	Lastname VARCHAR(15),
	Experience DOUBLE NOT NULL,

	CHECK (Experience > 0 AND Experience < 45 AND LENGTH(Name) > 1 AND LENGTH(Surname) >= 1),
	PRIMARY KEY (ID)
);

CREATE TABLE expenses(
	ID INT NOT NULL AUTO_INCREMENT, 
	Name VARCHAR(20) NOT NULL,
	Sum DECIMAL(10, 2) NOT NULL,
	Comment VARCHAR(40) DEFAULT(NULL),

	PRIMARY KEY(ID)
);

CREATE TABLE route (
	ID INT NOT NULL AUTO_INCREMENT,
	DepartureName VARCHAR(30) NOT NULL,
	ArrivalName VARCHAR(30) NOT NULL,
	Distance DOUBLE NOT NULL,
	Payment DECIMAL(10, 2) NOT NULL,
    Expenses DOUBLE,

	PRIMARY KEY (ID),
	CHECK (Distance > 0 AND Payment > 0 AND Expenses > 0),
	CHECK (LENGTH(DepartureName) > 2 AND LENGTH(ArrivalName) > 2)
);

CREATE TABLE transportation (
	ID INT NOT NULL AUTO_INCREMENT,
	Route_ID INT NOT NULL,
	FirstDriver_ID INT NOT NULL,
	SecondDriver_ID INT,
	DepartureTime DATETIME NOT NULL DEFAULT(current_timestamp()),
	ArrivalTime DATETIME NOT NULL DEFAULT(current_timestamp()),
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
	TotalSalary DECIMAL(8,2),

	PRIMARY KEY(ID),
	CONSTRAINT s_transportation_CONST FOREIGN KEY (Transportation_ID) REFERENCES transportation(ID) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT s_driver_CONST FOREIGN KEY (Driver_ID) REFERENCES driver(ID) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE Cost_Of_Transportation (
	ID INT NOT NULL AUTO_INCREMENT,
	Transportation_ID INT NOT NULL,
    Drivers_Salary DECIMAL(10, 2) NOT NULL,
    Route_Expenses DECIMAL(10, 2) NOT NULL,
	Full_Cost DECIMAL(10, 2) NOT NULL,
    
	PRIMARY KEY (ID),
    CONSTRAINT transportation_cost_CONST FOREIGN KEY (Transportation_ID) REFERENCES transportation(ID) ON UPDATE CASCADE ON DELETE CASCADE
);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE fill_values()										-- procedure to automaticly fill the values into the tables
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
	('Volodymyr-Volynskyi', 'Dnipro', 981, 70.90),
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
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE select_tables()									-- procedure to select all the tables
BEGIN
	SELECT * FROM driver;
	SELECT * FROM expenses;
	SELECT * FROM route;
	SELECT * FROM transportation;
	SELECT * FROM salary;
	SELECT * FROM Cost_Of_Transportation;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE delete_tables()									-- procedure to delete all the needed tables
BEGIN
	DROP TABLE IF EXISTS Cost_Of_Transportation;
	DROP TABLE IF EXISTS salary;
	DROP TABLE IF EXISTS transportation;
	DROP TABLE IF EXISTS route;
    DROP TABLE IF EXISTS expenses;
	DROP TABLE IF EXISTS driver;
END $$
DELIMITER ;


DROP PROCEDURE IF EXISTS create_tables;
DROP PROCEDURE IF EXISTS fill_values;
DROP PROCEDURE IF EXISTS select_tables;
DROP PROCEDURE IF EXISTS delete_tables;


DROP DATABASE IF EXISTS lab6;
# |-------------- -------------- -------------- -------------- -------------- --------------|
# |-------------- -------------- -------------- -------------- -------------- --------------|
DELIMITER $$
CREATE TRIGGER calculate_route_payment								-- trigger to calculate the value of payment to the driver for a specific route
BEFORE INSERT ON route
FOR EACH ROW
BEGIN
	SET @Distance = NEW.Distance;
    
	SET NEW.Payment = CASE											-- conditions for payment to the driver depending on the length of the route 
			WHEN @Distance > 900 THEN ROUND(@Distance * 2.3, 2)
			WHEN @Distance < 500 THEN ROUND(@Distance * 1.9, 2)
            ELSE ROUND(@Distance * 2.01, 2)
        END;
END $$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER calculate_route_expenses								-- trigger to calculate the cost of expenses via each route
BEFORE INSERT ON route
FOR EACH ROW FOLLOWS calculate_route_payment
BEGIN
    DECLARE isEU BOOLEAN;

    SET isEU = (CASE																						-- bool variable to define whether route is international
        WHEN (NEW.DepartureName IN ('Riga', 'Warsaw', 'TalliNn', 'Poznań')
            OR NEW.ArrivalName IN ('Riga', 'Warsaw', 'TalliNn', 'Poznań')) THEN true
        ELSE false
    END);

    SET @Fuel = (SELECT Sum FROM expenses WHERE Name = 'Fuel');												-- selecting fuel price
    SET @Supplies = (SELECT Sum FROM expenses WHERE Name = 'Supplies');										-- selecting supplies price
    SET @Permission = (SELECT Sum FROM expenses WHERE Name = 'Permission');									-- selecting border pass permission price

    -- 17 - fuel consumption by the bus, 0.4 - supplies per 1000 km
    SET @BasicExpenses = (((NEW.Distance * 17) / 100) * @Fuel) + (((NEW.Distance * 0.4) / 1000) * @Supplies); -- fuel + supplies
    SET @ExtraExpenses = IF(isEU = true, @Permission, 0);         											-- permission to pass the border

    SET NEW.Expenses = FORMAT((@BasicExpenses + @ExtraExpenses), 2);
END $$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER calculate_salary										-- trigger to calculate the salary of each driver per transportation
AFTER INSERT ON transportation
FOR EACH ROW
BEGIN
    DECLARE FirstDriverSalary DECIMAL(10, 2);
    DECLARE SecondDriverSalary DECIMAL(10, 2);

    SET @BonusValue = NEW.Bonus;															-- variable to define bonus value for specific route
	SET @PaymentValue = (																	-- variable to define basic payment value for route
		SELECT Payment FROM route
		WHERE ID = NEW.Route_ID 
        LIMIT 1);

    SET @ExperienceValue = (																-- variable to define first drivers experience (to calculate the experience bonus)
		SELECT Experience FROM driver
		WHERE ID = NEW.FirstDriver_ID
        LIMIT 1);
        
    SET FirstDriverSalary = @PaymentValue;

    IF @BonusValue IS NOT NULL THEN															-- if bonus value exists then count it
        SET FirstDriverSalary = FirstDriverSalary + (@PaymentValue * @BonusValue / 100);
    END IF;

    IF @ExperienceValue >= 10 THEN															-- allowance calculation depending on the drivers experience
        SET FirstDriverSalary = FirstDriverSalary + (@PaymentValue * 0.1); 					-- +10%
    ELSEIF @ExperienceValue >= 4 THEN
        SET FirstDriverSalary = FirstDriverSalary + (@PaymentValue * 0.05); 				-- +5%
    END IF;

    IF NEW.SecondDriver_ID IS NOT NULL THEN													-- if exists second driver, count its salary
        SET @ExperienceValue = (															-- define second drivers experience
			SELECT Experience FROM driver
            WHERE ID = NEW.SecondDriver_ID
            LIMIT 1);

        SET SecondDriverSalary = @PaymentValue;

        IF @BonusValue IS NOT NULL THEN														-- if bonus value exists then count it
            SET SecondDriverSalary = SecondDriverSalary + (@PaymentValue * @BonusValue / 100);
        END IF;

        IF @ExperienceValue >= 10 THEN														-- allowance calculation depending on the drivers experience
            SET SecondDriverSalary = SecondDriverSalary + (@PaymentValue * 0.1); -- +10%
        ELSEIF @ExperienceValue >= 4 THEN
            SET SecondDriverSalary = SecondDriverSalary + (@PaymentValue * 0.05); -- +5%
        END IF;
        
        SET FirstDriverSalary = FirstDriverSalary - (@PaymentValue * 0.3);					-- if its 2 drivers on the route then they get 30% less the route payment
        SET SecondDriverSalary = SecondDriverSalary - (@PaymentValue * 0.3);
    END IF;
    
    INSERT INTO salary (Transportation_ID, Driver_ID, TotalSalary)							-- inserting all the values into corresponding table 'salary'
    VALUES (NEW.ID, NEW.FirstDriver_ID, FirstDriverSalary);

    IF NEW.SecondDriver_ID IS NOT NULL THEN
        INSERT INTO salary (Transportation_ID, Driver_ID, TotalSalary)
        VALUES (NEW.ID, NEW.SecondDriver_ID, SecondDriverSalary);
    END IF;
END $$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER calculate_cost_of_transportation						-- trigger to calculate the overall cost of transportation for company
AFTER INSERT ON transportation
FOR EACH ROW FOLLOWS calculate_salary
BEGIN
    DECLARE Drivers_Salary DECIMAL(10, 2);													-- variable to save the drivers salary value
    DECLARE Route_Expenses DECIMAL(10, 2);													-- variable to save the route expenses value

    SET Route_Expenses = (																	-- defining route expenses for specific route
		SELECT Expenses FROM route
        WHERE ID = NEW.Route_ID 
        LIMIT 1);
        
	SET @First_Driver_Salary = (															-- getting the value of first drivers salary
		SELECT TotalSalary FROM salary AS s
        WHERE Transportation_ID = NEW.ID
        AND s.Driver_ID = NEW.FirstDriver_ID);

    SET @Second_Driver_Salary = (CASE														-- getting the value of second drivers salary, if it exists
		WHEN NEW.SecondDriver_ID IS NOT NULL THEN (
			SELECT TotalSalary FROM salary AS s
				WHERE Transportation_ID = NEW.ID
				AND s.Driver_ID = NEW.SecondDriver_ID)
		ELSE 0
		END);
    
    SET Drivers_Salary = @First_Driver_Salary + @Second_Driver_Salary;						-- calculating the value of drivers salaries
        
    INSERT INTO Cost_Of_Transportation (Transportation_ID, Drivers_Salary, Route_Expenses, Full_Cost)
    VALUES (NEW.ID, Drivers_Salary, Route_Expenses, (Drivers_Salary + Route_Expenses));
END $$
DELIMITER ;


DROP TRIGGER IF EXISTS calculate_route_payment;
DROP TRIGGER IF EXISTS calculate_route_expenses;
DROP TRIGGER IF EXISTS calculate_salary;
DROP TRIGGER IF EXISTS calculate_cost_of_transportation;
# |-------------- -------------- -------------- -------------- -------------- --------------|
# |-------------- -------------- -------------- -------------- -------------- --------------|
CREATE OR REPLACE VIEW transportation_view AS						-- view to help understanding the transportation table, get the specified information
SELECT t.ID AS ID,
        r.ID AS Route_ID,
        r.ArrivalName,
        r.DepartureName,
        t.ArrivalTime,
        t.DepartureTime,
		t.FirstDriver_ID,
		d.name,
        d.surname,
        COALESCE(t.SecondDriver_ID, 'missing') AS Partner
FROM transportation AS t
	INNER JOIN driver AS d ON d.ID = t.FirstDriver_ID
	INNER JOIN route AS r ON t.Route_ID = r.ID
ORDER BY t.ID;

CREATE OR REPLACE VIEW salary_view AS								-- view to help understanding the salary table, show the drivers information
SELECT s.ID AS ID,
        t.ID AS Transportation_ID,
		d.ID AS Driver_ID,
		d.name,
        d.surname,
        s.TotalSalary AS Salary
FROM salary AS s
	INNER JOIN transportation AS t ON t.ID = s.Transportation_ID
	INNER JOIN driver AS d ON d.ID = s.Driver_ID
ORDER BY s.ID;

CREATE OR REPLACE VIEW cost_of_transportation_view AS				-- view to help understanding the cost of transportation table
SELECT cot.ID AS ID,
		cot.Transportation_ID,
        t.Route_ID,
        r.Payment,
        t.FirstDriver_ID,
        t.SecondDriver_ID,
        t.Bonus,
        cot.Drivers_Salary,
        cot.Route_Expenses,
        cot.Full_Cost
FROM Cost_Of_Transportation AS cot
INNER JOIN transportation AS t ON cot.Transportation_ID = t.ID
INNER JOIN route AS r ON t.Route_ID= r.ID;

SELECT * FROM transportation_view;
SELECT * FROM salary_view;
SELECT * FROM cost_of_transportation_view;

DROP VIEW IF EXISTS transportation_view;
DROP VIEW IF EXISTS salary_view;
DROP VIEW IF EXISTS cost_of_transportation_view;
# -------------- -------------- -------------- RELATOINAL  ALGEBRA -------------- -------------- --------------
# -------------- -------------- -------------- |----- LAB6 ------| -------------- -------------- --------------

# |-------- ОБ'ЄДНАННЯ --------| 

SELECT Route_Expenses FROM Cost_Of_Transportation
	UNION 
    SELECT Drivers_Salary FROM Cost_Of_Transportation;

# |-------- ПЕРЕТИН --------| 

SELECT Name, Surname, Experience FROM driver
	WHERE (Name, Surname, Experience) IN (
		SELECT Name, Surname, Experience
		FROM transportation AS t
		INNER JOIN driver ON t.SecondDriver_ID = driver.ID
		WHERE t.SecondDriver_ID IS NOT NULL
	) 
	ORDER BY Name;
    
SELECT t.ID,
	FirstDriver_ID, 
    SecondDriver_ID, 
    d.ID AS Driver_ID, 
    Name, 
    Surname, 
    Experience, 
    DepartureTime 
    FROM transportation AS t
	INNER JOIN driver AS d ON t.SecondDriver_ID = d.ID 
    ORDER BY Name;

# |-------- РІЗНИЦЯ --------| 

SELECT *
FROM route AS r1
WHERE (ID, DepartureName, ArrivalName, Distance, Payment, Expenses) NOT IN (
    SELECT *
    FROM route AS r2
    WHERE Distance > 900 AND Expenses > (SELECT AVG(Expenses) FROM route WHERE Distance > 900));
    
SELECT t1.column_name
FROM table1 AS t1
WHERE NOT EXISTS (
    SELECT *
    FROM table2 AS t2
    WHERE NOT EXISTS (
        SELECT *
        FROM table3 AS t3
        WHERE t1.column_name = t3.column_name
          AND t2.column_name = t3.column_name
    )
);


# |-------- ДЕКАРТОВИЙ ДОБУТОК --------| 

DROP TABLE IF EXISTS available_cities;
SELECT * FROM available_cities;

SELECT * FROM available_cities 
    CROSS JOIN Expenses
    WHERE city IN('Riga', 'Warsaw', 'TalliNn', 'Poznań') 
    LIMIT 15;

# |-------- ВИБІРКА, СЕЛЕКЦІЯ --------| 

SELECT * FROM transportation 
	WHERE TIMEDIFF(ArrivalTime, DepartureTime) < TIME('12:00:00');

# |-------- ПРОЕКЦІЯ --------| 

SELECT DepartureName, ArrivalName, Payment, Expenses FROM route;

# |-------- З'ЄДНАННЯ --------| 

SELECT t.Route_ID,
	t.DepartureTime, 
	d.Name, 
    d.Surname,
	s.TotalSalary 
    FROM salary AS s
    INNER JOIN transportation AS t ON s.Transportation_ID = t.ID
    RIGHT JOIN driver AS d ON s.Driver_ID = d.ID;

# |-------- ДІЛЕННЯ --------| 

SELECT *, TRUNCATE((Route_Expenses / Full_Cost * 100), 2) AS Exp_to_FullCost
	FROM Cost_Of_Transportation AS c
	WHERE NOT EXISTS (
		SELECT *
        FROM salary
        WHERE (Route_Expenses  / Full_Cost * 100) > 10
);

# |-------- РОЗШИРЕННЯ --------| 

SELECT ID, 
	Name, 
    Surname, 
    Experience,
	(65 - Experience) AS To_Retirement FROM driver;

# |-------- ПЕРЕЙМЕНУВАННЯ --------| 

SELECT Route_Expenses ,
	Full_Cost, 
    TRUNCATE((Route_Expenses  / Full_Cost * 100), 2) AS 'Expenses_To_FullCost, %' 
    FROM Cost_Of_Transportation;

# |-------- ПІДБИТТЯ ПІДСУМКІВ --------| 

SELECT SUM(TotalSalary) AS TotalSalary, CASE 
	WHEN TotalSalary > (SELECT (AVG(TotalSalary) + MIN(TotalSalary)) FROM salary) THEN 'High'
    WHEN TotalSalary < (SELECT (AVG(TotalSalary) - MIN(TotalSalary)) FROM salary) THEN 'Low'
    ELSE 'Middle'
    END AS Payment_Value
	FROM salary
	GROUP BY Payment_Value
    ORDER BY TotalSalary DESC;

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
CREATE TABLE tempTable SELECT * FROM Cost_Of_Transportation; 
DROP TABLE tempTable;

SELECT * FROM tempTable;
SELECT * FROM Cost_Of_Transportation;
    
UPDATE tempTable
SET Drivers_Salary = 
  CASE
    WHEN Drivers_Salary  < (SELECT AVG(Full_Cost) FROM Cost_Of_Transportation) 
		THEN Drivers_Salary  + (Drivers_Salary  * 5 / 100)
    WHEN Drivers_Salary  >= (SELECT AVG(Full_Cost) FROM Cost_Of_Transportation)
		THEN Drivers_Salary  + (Drivers_Salary  * 2 / 100)
    ELSE Salary
  END;
    
DELETE FROM tempTable WHERE ID 
	IN (SELECT tempTable.ID FROM (
		SELECT t.ID, 
			IF (c.Full_Cost > (SELECT AVG(Full_Cost) FROM Cost_Of_Transportation), '1', '2') AS group_name
		FROM tempTable t
		JOIN Cost_Of_Transportation c ON t.ID = c.ID) AS subquery 
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