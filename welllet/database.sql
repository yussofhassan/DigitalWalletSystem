CREATE TABLE Users
(
    UserID INT PRIMARY KEY IDENTITY,

    FullName NVARCHAR(100) NOT NULL,

    PhoneNumber NVARCHAR(11) NOT NULL,

    Password NVARCHAR(100) NOT NULL,

    Balance DECIMAL(10,2) NOT NULL,

    Gender NVARCHAR(10) NOT NULL,

    BirthDate DATE NOT NULL
);

CREATE TABLE Transactions
(
    TransactionID INT PRIMARY KEY IDENTITY,

    SenderID INT NULL,

    ReceiverID INT NOT NULL,

    Amount DECIMAL(10,2) NOT NULL,

    TransactionType NVARCHAR(50) NOT NULL,

    TransactionDate DATETIME NOT NULL
);