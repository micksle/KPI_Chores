# Database systems
![MySQL](https://img.shields.io/badge/mysql-%2300f.svg?style=for-the-badge&logo=mysql&logoColor=white) <br><br>
Proffesors:
- Lecturer: Szeged Iryna Vasylivna <br>
- Practitioner: Bespala Olga Mykolayivna <br>

The discipline consists of `6 labouratory works (Lr)` and `2 modular control work (Kr)`. Control works were performed in Google documents, so they are not presented in this folder, but all other works are represented

----

During the course a database system for **`cargo transportations`** was developed, the final product was also improved after the end of the course in order to keep the system stable and functional. The final product consists of the following:
1. 6 tables to store all the necessary information
2. Foreign key constraints to eliminate data mismatches and bring the database to the 3rd normal form (3NF)
3. 4 procedures that play a huge role in the user experience, as they almost automaticly execute a large number of commands, such as creating all tables or inserting its values
4. With the help of triggers, the system can automaticly calculate and fill in almost half of the information in the tables, such as salary or transporation costs
5. Added 3 views to make information in tables more understandable and easier to use
6. Created a proper Use-case diagram

## Overall database information
The database system for the subject area **`cargo transportations`** consists of the following tables:
1. Driver
2. Route
3. Expenses
4. Transportation
5. Salary
6. Cost_Of_Transportation<br>
All the tables inlcude the corresponding data, with all the necessary variables<br>
Below is the ER-diagram that represents the structure of the developed database system with its connections
![DB structure]() 

An example of a filled database is shown below
![Table values]()

The developed Use-case diagram is as follows: 
![Use case]()
---

## Triggers information
Triggers were added to automate the system and to get rid of incorrect manual tables filling

### 1. Calculate_route_payment
Trigger to calculate the value of payment to the driver for a specific route<br>
Easy to understand trigger that counts payment value based on the recieve infromation about route length. The formula is quite easy:<br>
```
if Distance > 900 THEN price = Distance * 2.3
else if Distance < 500 THEN price = Distance * 1.9
else price = Distance * 2.01
```

### 2. Calculate_route_expenses
Trigger to calculate the value of expenses for each route<br>
The trigger determines the cost of expenses the route consists with, including the price of fuel, supplies, and whether the route is international or not, and therefore whether it needs to pay for a pass permission or not.<br>
After receiving all the infromation, the trigger calculates the cost and inserts it into the corresponding column **`Expenses`**

### 3. Calculate_salary
Trigger to calculate the salary of each driver per transportation<br>
The trigger retrieves information about route payment, number of drivers, their experience and transportation bonus, and calculates the salary for each driver based on its values<br>
The calculation logic is next:
- if there is a bonus on the transportation, it is added to the amount of payment 
- if a driver has 4 years of driving experience, he recieves a 5% allowance to the cost of payment for the route
- if a driver has 10 years of driving experience, he recieves a 10% allowance to the cost of payment for the route
- if there were 2 drivers per one transportation (the route was too long), then they both receive a 30% less than the route payment, but all the other bonuses and allowances are still summed up


### 4. Calculate_cost_of_transportation
Trigger to calculate the overall cost of transportation for company<br>
This trigger calculates the route expenses and driver salaries (taking into account whether there were two of them or only one), then evaluates total sum and inserts all this information into the appropriate columns of the Cost_Of_Transportation table

## Procedures information
Procedures were added in order to make it easier to create and fill the database, as it was a big routine during the course<br>

### 1. Create_tables
The procedure creates all 6 tables which are taking part in the database. Each table has it\`s own number of values, filled with primary keys, checks, default and NOT-NULL values restrictions, as well as foreign keys constraints

### 2. Fill_values
The procedure fills in information in tables that are not filled in when triggers are executed. These tables include **`Driver`**, **`Expenses`**, **`Transportation`** and partly **`Route`**

### 3. Select_tables
The procedure performs a selection of all database tables with the `SELECT * FROM table_name` query

### 4. Delete_tables
The procedure performs a deletion of all database tables with the `DROP TABLE IF EXISTS table_name` query