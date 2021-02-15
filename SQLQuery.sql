
INSERT INTO Users(Id,FirstName,LastName,Email,Password) 
VALUES
       ('1','Ali','Aydın','aliaydin@gmail.com','12345'),
       ('2','Hamdi','Kuşçu','hamdikuscu@gmail.com','25648');

INSERT INTO Customers(Id,UserId,CompanyName)
VALUES
       ('1','1','Avis');

INSERT INTO Rentals(Id,CarId,CustomerId,RentDate,ReturnDate)
VALUES
       ('1','2','1','2020-04-10 16:25:20','2020-04-17 17:10:50')
       


      
