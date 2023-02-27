CREATE DATABASE Lab1;
USE Lab1;

CREATE TABLE route (
route_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
route_Name VARCHAR(20) NOT NULL,
route_Distance DOUBLE CHECK(route_Distance>20) NOT NULL,
route_Price DOUBLE NOT NULL
);

INSERT INTO route (route_Name, route_Distance, route_Price) VALUES ('First route', 20.1, 70.7);
INSERT INTO route (route_Name, route_Distance, route_Price) VALUES ('Second route', 32.3, 86.2);
LOAD DATA LOCAL INFILE 'C:\\ProgramData\\MySQL\\MySQL Server 8.0\\Uploads\\Lab1.txt' INTO TABLE route;

SET SQL_SAFE_UPDATES = 0;
UPDATE route SET route_Name='New fourth path', route_Distance = 3.8 WHERE route_id=4;
DELETE FROM route WHERE route_id=3;
DELETE FROM route WHERE route_id>=2;

ALTER TABLE route ADD route_complexity VARCHAR(20) primary key;
UPDATE route SET route_Distance = 23.8 WHERE route_id=1;
UPDATE route SET route_Price =0 WHERE route_id=1;

DROP TABLE route;
DROP DATABASE Lab1;
SELECT * FROM route;
