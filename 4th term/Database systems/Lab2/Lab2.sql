CREATE DATABASE Lab2;
USE Lab2;

CREATE TABLE transportation (
ID INT NOT NULL AUTO_INCREMENT,
Route VARCHAR(40) NOT NULL,
Driver VARCHAR(10) NOT NULL,
Departure DATETIME DEFAULT(current_timestamp()),
Arrival DATETIME DEFAULT(current_timestamp()),
Premium DOUBLE DEFAULT(0) CHECK (Premium < 1),

PRIMARY KEY (`ID`)
);

CREATE TABLE route (
ID INT NOT NULL AUTO_INCREMENT,
DepartureName VARCHAR(20) NOT NULL,
ArrivalName VARCHAR(20) NOT NULL,
Distance DOUBLE NOT NULL,
Payment DOUBLE NOT NULL,

CHECK (Distance > 0 AND Payment > 0),
PRIMARY KEY (`ID`)
);

CREATE TABLE driver (
ID INT NOT NULL AUTO_INCREMENT,
Name VARCHAR(10) NOT NULL,
Surname VARCHAR(10) NOT NULL,
Lastname VARCHAR(10),
Experience DOUBLE NOT NULL,

CHECK (Experience > 0),
#PRIMARY KEY (`ID`)
PRIMARY KEY (Name, Surname, Lastname)
);

CREATE TABLE payment (
ID INT NOT NULL AUTO_INCREMENT,
Route INT NOT NULL,
Experience INT NOT NULL,
Amount INT NOT NULL,

CHECK (Amount > 0),
PRIMARY KEY (`ID`)
);

# -------------- -------------- -------------- DATABASE MANAGEMENT -------------- -------------- --------------
# -------------- -------------- -------------- |-------- --------| -------------- -------------- --------------
SELECT * FROM route;
SELECT * FROM driver;
SELECT * FROM transportation;

DROP TABLE route;
DROP TABLE driver;
DROP TABLE transportation;

# -------------- -------------- -------------- FILLING IN DATABASE -------------- -------------- --------------
# -------------- -------------- -------------- |-------- --------| -------------- -------------- --------------
INSERT INTO route (DepartureName, ArrivalName, Distance, Payment) VALUES ('Kyiv', 'Lviv', 541, 1349);
INSERT INTO route (DepartureName, ArrivalName, Distance, Payment) VALUES ('Kyiv', 'Dnipro', 485, 1149);
INSERT INTO route (DepartureName, ArrivalName, Distance, Payment) VALUES ('Kyiv', 'Odessa', 475, 1099);
INSERT INTO route (DepartureName, ArrivalName, Distance, Payment) VALUES ('Kyiv', 'Kharkiv', 489, 1099);
INSERT INTO route (DepartureName, ArrivalName, Distance, Payment) VALUES ('Dnipro', 'Kharkiv', 218, 699);
INSERT INTO route (DepartureName, ArrivalName, Distance, Payment) VALUES ('Dnipro', 'Kherson', 329, 899);
INSERT INTO route (DepartureName, ArrivalName, Distance, Payment) VALUES ('Dnipro', 'Zaporizhzhia', 85.1, 349);
INSERT INTO route (DepartureName, ArrivalName, Distance, Payment) VALUES ('Kherson', 'Crimea', 255, 799);
INSERT INTO route (DepartureName, ArrivalName, Distance, Payment) VALUES ('Zaporizhzhia', 'Mariupol', 227, 499);

INSERT INTO driver (Name, Surname, Lastname, Experience) VALUES ('Driver', '1', '', 1);
INSERT INTO driver (Name, Surname, Lastname, Experience) VALUES ('Driver', '2', '_', 2.2);
INSERT INTO driver (Name, Surname, Lastname, Experience) VALUES ('Driver', '3', '', 3);
INSERT INTO driver (Name, Surname, Lastname, Experience) VALUES ('Driver', '4', '', 4.4);
INSERT INTO driver (Name, Surname, Lastname, Experience) VALUES ('Driver', '5', '', 5.5);
INSERT INTO driver (Name, Surname, Lastname, Experience) VALUES ('Driver', '6', '_', 6);

INSERT INTO transportation (Route, Driver, Departure, Arrival, Premium) VALUES ('Kyiv-Lviv', 'Driver 1', current_timestamp(), '2023-03-16 19:05:23', .15);
INSERT INTO transportation (Route, Driver, Departure, Arrival, Premium) VALUES ('Kyiv-Lviv', 'Driver 3', current_timestamp(), '2023-03-16 19:05:23', .15);
INSERT INTO transportation (Route, Driver, Departure, Arrival) VALUES ('Kyiv-Dnipro', 'Driver 2', '2023-03-15 13:17:17', '2023-03-16 8:07:03');
INSERT INTO transportation (Route, Driver, Departure, Arrival) VALUES ('Dnipro-Kharkiv', 'Driver 6', '2023-03-13 22:17:42', '2023-03-14 04:06:51');
INSERT INTO transportation (Route, Driver, Departure, Arrival) VALUES ('Kyiv-Kharkiv', 'Driver 4', '2023-03-13 13:11:02', '2023-03-13 23:15:23');
INSERT INTO transportation (Route, Driver, Departure, Arrival) VALUES ('Zaporizhzhia-Mariupol', 'Driver 5', current_timestamp(), '2023-03-18 14:22:53');
INSERT INTO transportation (Route, Driver, Departure, Arrival) VALUES ('Dnipro-Kherson', 'Driver 5', '2023-03-17 14:48:59', '2023-03-17 19:33:07');
INSERT INTO transportation (Route, Driver, Departure, Arrival, Premium) VALUES ('Dnipro-Zaporizhzhia', 'Driver 2', '2023-03-15 07:08:10', '2023-03-15 16:25:31', .10);
INSERT INTO transportation (Route, Driver, Departure, Arrival) VALUES ('Kherson-Crimea', 'Driver 3', '2023-04-16 16:34:27', '2023-04-16 21:17:07');
INSERT INTO transportation (Route, Driver, Departure, Arrival) VALUES ('Kyiv-Odessa', 'Driver 1', '2023-03-15 15:09:26', '2023-03-15 11:05:34');
