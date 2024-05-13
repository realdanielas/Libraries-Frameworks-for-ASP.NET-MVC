-- Crear la tabla Ventas
CREATE TABLE Ventas (
    Id INT PRIMARY KEY,
    Fecha DATE,
    Monto DECIMAL(10, 2)
);

-- Insertar datos de ejemplo en la tabla Ventas
INSERT INTO Ventas (Id, Fecha, Monto) VALUES
(1, '2024-01-01', 1500),
(2, '2024-01-02', 150),
(3, '2024-01-03', 1590),
(4, '2024-01-04', 250),
(5, '2024-01-05', 300),
(6, '2024-02-14', 800),
(7, '2024-05-05', 1500),
(8, '2024-08-03', 2000),
(9, '2024-09-20', 2500),
(10, '2024-11-22', 3000);

SELECT * FROM Ventas;

UPDATE Ventas SET Fecha='2023-01-15' WHERE Id=1;
UPDATE Ventas SET Fecha='2023-02-15' WHERE Id=2;
UPDATE Ventas SET Fecha='2023-03-15' WHERE Id=3;
UPDATE Ventas SET Fecha='2023-04-15' WHERE Id=4;
UPDATE Ventas SET Fecha='2023-05-15' WHERE Id=5;
UPDATE Ventas SET Fecha='2023-06-15' WHERE Id=6;
UPDATE Ventas SET Fecha='2023-07-15' WHERE Id=7;
UPDATE Ventas SET Fecha='2023-08-15' WHERE Id=8;
UPDATE Ventas SET Fecha='2023-09-15' WHERE Id=9;
UPDATE Ventas SET Fecha='2023-10-15' WHERE Id=10;

INSERT INTO Ventas (Id, Fecha, Monto) VALUES
(11, '2023-11-15', 3500),
(12, '2023-12-15', 4000),
(13, '2024-01-15', 2000),
(14, '2024-02-15', 800),
(15, '2024-03-15', 1000),
(16, '2024-04-15', 800),
(17, '2024-05-15', 1500),
(18, '2024-06-15', 2000),
(19, '2024-07-15', 3500),
(20, '2024-08-15', 4000);

