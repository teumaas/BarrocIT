CREATE TABLE [dbo].[tbl_customers] (
    [CustomerID]        INT           NOT NULL,
    [CustomerName]      NVARCHAR (50) NOT NULL,
	[Company]      		NVARCHAR (50) NULL,
    [Adress1]           NVARCHAR (50) NOT NULL,
    [Adress2]           NVARCHAR (50) NULL,
    [City1]             NVARCHAR (50) NOT NULL,
    [City2]             NVARCHAR (50) NULL,
    [PhoneNum1]         NVARCHAR (12) NOT NULL,
    [PhoneNum2]         NVARCHAR (12) NULL,
    [ZipCode1]          NVARCHAR (6)  NOT NULL,
    [ZipCode2]          NVARCHAR (6)  NULL,
    [FaxNum]            NVARCHAR (12) NULL,
    [ContactPerson]     NVARCHAR (50) NOT NULL,
    [Email]             NVARCHAR (50) NOT NULL,
    [BankNum]           NVARCHAR (20) NOT NULL,
    [CreditWorthy]      BIT           NOT NULL,
    [BKRCheck]          BIT           NOT NULL,
    [PotentialCustomer] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

CREATE TABLE [dbo].[tbl_projects] (
    [ProjectID]          INT           NOT NULL,
    [CustomerID]         INT           NOT NULL,
    [ProjectName]        NVARCHAR (50) NOT NULL,
    [ProjectStatus]      BIT           NOT NULL,
    [ProjectPrice]       INT           NOT NULL,
    [ProjectLimit]       INT           NOT NULL,
    [MaintenanceContact] BIT           NOT NULL,
    CONSTRAINT [FK_tbl_customers1] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[tbl_customers] ([CustomerID]),
	PRIMARY KEY CLUSTERED ([ProjectID] ASC)
);

CREATE TABLE [dbo].[tbl_invoices] (
    [InvoiceID]       INT           IDENTITY (1, 1) NOT NULL,
    [CustomerID]      INT           NOT NULL,
    [ProjectID]       INT           NOT NULL,
    [InvoiceDate]     DATE          NOT NULL,
    [InvoicePaid]     BIT           NOT NULL,
    [InvoiceSent]     BIT           NOT NULL,
    [InvoiceStatus]   BIT           NOT NULL,
    [InvoiceTerms]    NVARCHAR (50) NOT NULL,
    [LastContactDate] DATE          NOT NULL,
    [LedgerAccNum]    NVARCHAR (12) NOT NULL,
    [TaxCode]         NVARCHAR (12) NOT NULL,
    PRIMARY KEY CLUSTERED ([InvoiceID] ASC),
    CONSTRAINT [FK_tbl_projects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tbl_projects] ([ProjectID]),
    CONSTRAINT [FK_tbl_customers3] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[tbl_customers] ([CustomerID])
);

CREATE TABLE [dbo].[tbl_appointments] (
    [AppointmentID]            INT           IDENTITY (1, 1) NOT NULL,
    [CustomerID]               INT           NOT NULL,
    [AppointmentSubject]       NVARCHAR (50) NOT NULL,
    [AppointmentDate]          DATETIME      NOT NULL,
    [AppointmentLocation]      NVARCHAR (50) NOT NULL,
    [AppointmentAdress]        NVARCHAR (50) NOT NULL,
    [AppointmentAdressZipCode] NVARCHAR (6)  NOT NULL,
    [AppointmentTime]          DATETIME (7)  NOT NULL,
    PRIMARY KEY CLUSTERED ([AppointmentID] ASC),
    CONSTRAINT [FK_tbl_customers2] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[tbl_customers] ([CustomerID])
);

CREATE TABLE [dbo].[tbl_users] (
    [UserID]   INT  IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (15) NOT NULL,
    [Password] NVARCHAR (25) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);