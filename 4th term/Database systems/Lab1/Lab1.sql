CREATE DATABASE Lab1;
USE Lab1;

CREATE TABLE route (
route_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
route_Name VARCHAR(20) NOT NULL,
route_Distance DOUBLE CHECK(route_Distance>20) NOT NULL,
route_Price DOUBLE NOT NULL
);

INSERT INTO route (route_Name, route_Distance, route_Price) VALUES ('First route', 20.1, 70.7);
SELECT * FROM route;
