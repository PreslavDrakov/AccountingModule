
DELETE FROM Product;
DELETE FROM Tax;
SET IDENTITY_INSERT Tax ON;

INSERT INTO Tax (ID, Name, Description, ComputationValue, IsActive, TypeValue, ScopeValue, Amount)
VALUES
    (1, 'Value', 'Tax levied on the value added to a product or service at each stage of production or distribution.', 0, 1, 0, 0, 10.00),
    (2, 'Sales', 'Tax imposed on the sale of goods and services and is collected by the retailer.', 1, 1, 1, 1, 5.00),
    (3, 'Income', 'Tax levied on the earnings of individuals and businesses.', 2, 0, 2, 0, 0.05),
    (4, 'Import', 'Tax imposed on goods imported into a country.', 3, 1, 0, 1, 15.00),
    (5, 'Excise', 'Tax on certain goods produced or manufactured domestically.', 0, 0, 1, 0, 0.10),
    (6, 'Property', 'Tax levied on property, usually based on the value of the property.', 1, 1, 2, 1, 20.00),
    (7, 'Corporate', 'Tax levied on the profits of a corporation.', 2, 1, 0, 0, 0.02),
    (8, 'Customs', 'Tax imposed on goods when transported across international borders.', 3, 0, 1, 1, 8.00),
    (9, 'Sin', 'Tax on products that are deemed harmful to society.', 0, 1, 2, 0, 0.15),
    (10, 'Capital', 'Tax on the profit from the sale of an asset.', 1, 0, 0, 1, 12.00),
    (11, 'Payroll', 'Tax withheld from employees wages by employers.', 2, 1, 1, 0, 0.07),
    (12, 'Estate', 'Tax imposed on the transfer of the estate of a deceased person.', 3, 0, 2, 1, 25.00),
    (13, 'Tariff', 'Tax on imported goods.', 0, 1, 0, 0, 0.03),
    (14, 'Transport', 'Tax imposed on the transfer of property, including real estate, securities, and other assets.', 1, 0, 1, 1, 18.00),
    (15, 'Use', 'Tax on the storage, use, or consumption of goods or services.', 2, 0, 2, 0, 0.20),
    (16, 'Transfer', 'Tax levied on the transfer of property, such as real estate.', 3, 1, 0, 1, 30.00),
    (17, 'Poll', 'Tax levied as a fixed sum on every liable individual.', 0, 0, 1, 0, 0.25),
    (18, 'Carbon', 'Tax on the carbon content of fuels.', 1, 1, 2, 1, 40.00),
    (19, 'DDS', 'Tax levied on the value added to goods and services.', 2, 1, 0, 0, 0.05),
    (20, 'Sales', 'Tax imposed on the sale of goods and services.', 3, 0, 1, 1, 22.00);

SET IDENTITY_INSERT Tax OFF;
SET IDENTITY_INSERT Product ON;

INSERT INTO Product (ID, Name, TypeValue, SalesPrice, CostPrice, CanBeSold, CanBePurchased, CustomerTaxesID, VendorTaxesID)
VALUES 
(1, 'Invoice', 0, 10.00, 5.00, 1, 1, 1, 2),
(2, 'Ledger', 1, 15.00, 7.50, 1, 1, 2, 3),
(3, 'Payroll', 0, 20.00, 10.00, 1, 1, 3, 4),
(4, 'Balance Sheet', 1, 25.00, 12.50, 1, 1, 4, 5),
(5, 'Financial Statement', 0, 30.00, 15.00, 1, 1, 5, 1),
(6,'Payment Note', 0, 5.00, 2.50, 1, 1, 1, 2),
(7,'Document Printing', 1, 8.00, 4.00, 1, 1, 2, 3),
(8,'Consulting Services', 0, 50.00, 30.00, 1, 1, 3, 4),
(9,'Accounting Services', 1, 100.00, 70.00, 1, 1, 4, 5),
(10,'IT Equipment', 0, 500.00, 350.00, 1, 1, 5, 1),
(11,'Office Furniture', 1, 800.00, 600.00, 1, 1, 1, 2),
(12,'Office Supplies', 0, 50.00, 40.00, 1, 1, 2, 3),
(13,'Advertising Materials', 1, 200.00, 150.00, 1, 1, 3, 4),
(14,'Employee Training', 0, 300.00, 250.00, 1, 1, 4, 5),
(15,'Web Design Services', 1, 600.00, 500.00, 1, 1, 5, 1),
(16,'Software Program', 0, 1000.00, 800.00, 1, 1, 1, 2),
(17,'Hosting Services', 1, 200.00, 150.00, 1, 1, 2, 3),
(18,'Technical Support', 0, 80.00, 60.00, 1, 1, 3, 4),
(19,'Investment Stocks', 1, 1500.00, 1200.00, 1, 1, 4, 5),
(20,'Goods Delivery', 0, 20.00, 10.00, 1, 1, 5, 1);

SET IDENTITY_INSERT Product OFF;
