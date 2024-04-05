SET IDENTITY_INSERT Product ON;

INSERT INTO Product (ID, Name, Type, SalesPrice, CostPrice, CanBeSold, CanBePurchased, CustomerTaxesID, VendorTaxesID)
VALUES 
(1, 'Product 1', 0, 10.00, 5.00, 1, 1, 1, 2),
(2, 'Product 2', 1, 15.00, 7.50, 1, 1, 2, 3),
(3, 'Product 3', 0, 20.00, 10.00, 1, 1, 3, 4),
(4, 'Product 4', 1, 25.00, 12.50, 1, 1, 4, 5),
(5, 'Product 5', 0, 30.00, 15.00, 1, 1, 5, 1);

SET IDENTITY_INSERT Product OFF;
