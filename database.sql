CREATE DATABASE TicketVendingMachine;
GO

USE TicketVendingMachine;
GO
CREATE TABLE Destinations (
    DestinationID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    IsActive BIT DEFAULT 1
);

-- Sample data
INSERT INTO Destinations (Name) VALUES
('City A'), ('City B'), ('City C');
