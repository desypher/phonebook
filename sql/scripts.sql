IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Phonebook' and xtype='U')
    CREATE TABLE Phonebook (
		ID int IDENTITY(1,1) PRIMARY KEY,
        Name varchar(64) NOT NULL,
		PhoneNumber varchar(20) NOT NULL UNIQUE

    )
GO