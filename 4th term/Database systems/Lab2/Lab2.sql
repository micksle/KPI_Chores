CREATE DATABASE lab2;
USE lab2;

CREATE TABLE driver (
ID INT NOT NULL AUTO_INCREMENT,
Name VARCHAR(10) NOT NULL,
Surname VARCHAR(10) NOT NULL,
Lastname VARCHAR(10),
Experience DOUBLE NOT NULL,

CHECK (Experience > 0 AND Experience < 45 AND LENGTH(Name) > 1 AND LENGTH(Surname) >= 1),
PRIMARY KEY (ID)
);

CREATE TABLE route (
ID INT NOT NULL AUTO_INCREMENT,
Path INT NOT NULL,
Distance DOUBLE NOT NULL,
Payment DECIMAL(8,2) NOT NULL, 

CHECK (Distance > 0 AND Payment > 0),
PRIMARY KEY (ID),
CONSTRAINT pathCONST FOREIGN KEY (Path) REFERENCES path(ID)
);

CREATE TABLE path (
ID INT NOT NULL AUTO_INCREMENT,
DepartureName VARCHAR(20) NOT NULL,
ArrivalName VARCHAR(20) NOT NULL,

CHECK (LENGTH(DepartureName) > 2 AND LENGTH (ArrivalName) > 2),
PRIMARY KEY (ID)
);

CREATE TABLE trasnportation (
ID INT NOT NULL AUTO_INCREMENT,
Route INT NOT NULL,
FirstDriver INT NOT NULL,
SecondDriver INT,
DepartureTime DATETIME DEFAULT(current_timestamp()),
ArrivalTime DATETIME DEFAULT(current_timestamp()),
Bonus DECIMAL(4, 2),

PRIMARY KEY (`ID`),
CHECK (DepartureTime <= ArrivalTime AND Bonus <=  100),
CONSTRAINT routeCONST FOREIGN KEY (Route) REFERENCES route(ID),
CONSTRAINT firstDriverCONST FOREIGN KEY (FirstDriver) REFERENCES driver(ID),
CONSTRAINT secondDriverCONST FOREIGN KEY (SecondDriver) REFERENCES driver(ID)
);

CREATE TABLE salary (
ID INT NOT NULL AUTO_INCREMENT,
DriversPayment DECIMAL(8,2) NOT NULL,
Route INT NOT NULL,
Experience DOUBLE NOT NULL DEFAULT(1),
SecondDriver BOOLEAN NOT NULL,

PRIMARY KEY (ID),
CONSTRAINT PaymentRouteCONST FOREIGN KEY (Route) REFERENCES route(ID),
CONSTRAINT DriverExperienceCONST FOREIGN KEY (Experience) REFERENCES driver(ID)
);

CREATE TABLE costOfTrasnportation (
ID INT NOT NULL AUTO_INCREMENT,
TrasnportationCost DECIMAL(8,2) NOT NULL,
DriversPayment INT NOT NULL,

PRIMARY KEY (ID),
CONSTRAINT salaryCONST FOREIGN KEY (DriversPayment) REFERENCES salary(ID)
);

# -------------- -------------- -------------- DATABASE MANAGEMENT -------------- -------------- --------------
# -------------- -------------- -------------- |-------- --------| -------------- -------------- --------------
SELECT * FROM driver;
SELECT * FROM route;
SELECT * FROM path;
SELECT * FROM salary;
SELECT * FROM costOfTrasnportation;
SELECT * FROM trasnportation;

DROP TABLE IF EXISTS  driver;
DROP TABLE IF EXISTS  route;
DROP TABLE IF EXISTS  path;
DROP TABLE IF EXISTS  salary;
DROP TABLE IF EXISTS  costOfTrasnportation;
DROP TABLE IF EXISTS  trasnportation;

CREATE INDEX DriversExperience ON driver(Experience);
#ALTER TABLE driver DROP INDEX DriversExperience;

DROP DATABASE lab2;
# -------------- -------------- -------------- FILLING IN DATABASE -------------- -------------- --------------
# -------------- -------------- -------------- |-------- --------| -------------- -------------- --------------
INSERT INTO driver (Name, Surname, Lastname, Experience) VALUES
('Driver', '1', '', 1),
('Driver', '2', 'Vodiy', 2.2),
('Driver', '3', 'Vairuotoj', 3.3),
('Driver', '4', 'Vodiyev', 4.4),
('Driver', '5', '', 5),
('Driver', '6', 'Kierowca', 6),
('Driver', '7', '', 7.7),
('Driver', '8', '', 8);


INSERT INTO route (Path, Distance, Payment) VALUES
(1, 541, 1090.30),
(2, 652, 1340.0),
(3, 1050, 2080.30),
(4, 485, 1120.90),
(5, 744, 1580.60),
(6, 839, 1600.0),
(7, 1571, 2980.40),
(8, 314, 899.90),
(9, 681, 1470.0),
(10, 1321, 2400.80),
(12, 618, 1360.20),
(11, 463, 999),
(13, 98.2, 450.99);


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
('Berdyansk','Genichesk');


INSERT INTO salary (Route, DriversPayment, Experience, SecondDriver) VALUES
(1, 1090.30, 1, false),
(2, 1340.0, 2, false),
(3, 2080.30, 3, true),
(4, 1120.90, 4, false),
(5, 1580.60, 5, false),
(6, 1600.0, 6, false);


INSERT INTO costOfTrasnportation (TrasnportationCost, DriversPayment) VALUES
(1240.9, 1),
(1308.10, 1),
(1490.8, 3);


INSERT INTO trasnportation (Route, FirstDriver, DepartureTime, ArrivalTime) VALUES
(1, 1,'2023-03-13 22:17:42', '2023-03-14 04:06:51'),
(2, 2, current_timestamp(), '2023-03-18 14:22:53'),
(4, 3, current_timestamp(), '2023-03-16 19:05:23'),
(5, 6, '2023-03-15 13:17:17', '2023-03-16 8:07:03'),
(9, 5, '2023-03-13 13:11:02', '2023-03-13 23:15:23'),
(11, 7, current_timestamp(), '2023-03-16 19:05:23'),
(13, 4, '2023-03-15 07:08:10', '2023-03-15 16:25:31');

INSERT INTO trasnportation (Route, FirstDriver, DepartureTime, ArrivalTime, Bonus) VALUES
(6, 4, '2023-02-13 22:17:42', '2023-02-14 04:06:51', 9.4),
(8, 8, current_timestamp(), '2023-03-18 14:22:53', 3.6);

INSERT INTO trasnportation (Route, FirstDriver, SecondDriver, DepartureTime, ArrivalTime) VALUES
(3, 1, 2, '2023-03-15 13:17:17', '2023-03-16 8:07:03'),
(10, 3, 8, '2023-03-15 07:08:10', '2023-03-15 16:25:31'),
(7, 3, 1, '2023-04-16 16:34:27', '2023-04-16 21:17:07'),
(12, 5, 6, '2023-03-15 15:09:26', '2023-03-15 19:05:34');
