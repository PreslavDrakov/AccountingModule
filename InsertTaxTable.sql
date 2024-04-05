DELETE FROM Tax;
SET IDENTITY_INSERT Tax ON;

INSERT INTO Tax (ID, Name, Description, Computation, IsActive, Type, Scope, Amount)
VALUES
    (1, 'ValueAddedTax', 'Description for Value Added Tax', 0, 1, 0, 0, 10.00),
    (2, 'SalesTax', 'Description for Sales Tax', 1, 1, 1, 1, 5.00),
    (3, 'IncomeTax', 'Description for Income Tax', 2, 0, 2, 0, 0.05),
    (4, 'ImportDuty', 'Description for Import Duty', 3, 1, 0, 1, 15.00),
    (5, 'ExciseTax', 'Description for Excise Tax', 0, 0, 1, 0, 0.10),
    (6, 'PropertyTax', 'Description for Property Tax', 1, 1, 2, 1, 20.00),
    (7, 'CorporateTax', 'Description for Corporate Tax', 2, 1, 0, 0, 0.02),
    (8, 'CustomsDuty', 'Description for Customs Duty', 3, 0, 1, 1, 8.00),
    (9, 'SinTax', 'Description for Sin Tax', 0, 1, 2, 0, 0.15),
    (10, 'CapitalGainsTax', 'Description for Capital Gains Tax', 1, 0, 0, 1, 12.00),
    (11, 'PayrollTax', 'Description for Payroll Tax', 2, 1, 1, 0, 0.07),
    (12, 'EstateTax', 'Description for Estate Tax', 3, 0, 2, 1, 25.00),
    (13, 'Tariff', 'Description for Tariff', 0, 1, 0, 0, 0.03),
    (14, 'ValueAddedTax', 'Description for Value Added Tax', 1, 0, 1, 1, 18.00),
    (15, 'UseTax', 'Description for Use Tax', 2, 0, 2, 0, 0.20),
    (16, 'TransferTax', 'Description for Transfer Tax', 3, 1, 0, 1, 30.00),
    (17, 'PollTax', 'Description for Poll Tax', 0, 0, 1, 0, 0.25),
    (18, 'CarbonTax', 'Description for Carbon Tax', 1, 1, 2, 1, 40.00),
    (19, 'ValueAddedTax', 'Description for Value Added Tax', 2, 1, 0, 0, 0.05),
    (20, 'SalesTax', 'Description for Sales Tax', 3, 0, 1, 1, 22.00);

SET IDENTITY_INSERT Tax OFF;
