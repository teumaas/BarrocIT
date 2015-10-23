CREATE TABLE [dbo].[tbl_customers] (
    [CustomerID]        INT           NOT NULL,
    [CustomerName]      NVARCHAR (50) NOT NULL,
    [Adress1]           NVARCHAR (25) NOT NULL,
    [Adress2]           NVARCHAR (25) NULL,
    [City1]             NVARCHAR (25) NOT NULL,
    [City2]             NVARCHAR (25) NULL,
    [PhoneNum1]         NVARCHAR (13) NOT NULL,
    [PhoneNum2]         NVARCHAR (13) NULL,
    [ZipCode1]          NVARCHAR (6)  NOT NULL,
    [ZipCode2]          NVARCHAR (6)  NULL,
    [FaxNum]            NVARCHAR (13) NULL,
    [ContactPerson]     NVARCHAR (25) NOT NULL,
    [Email]             NVARCHAR (25) NOT NULL,
    [BankNum]           NVARCHAR (20) NOT NULL,
    [CreditWorthy]      BIT           NOT NULL,
    [BKRCheck]          BIT           NOT NULL,
    [PotentialCustomer] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

CREATE TABLE [dbo].[tbl_projects] (
    [ProjectID]          INT           NOT NULL,
    [CustomerID]         INT           NOT NULL,
    [ProjectName]        NVARCHAR (25) NOT NULL,
    [ProjectStatus]      BIT           NOT NULL,
    [ProjectPrice]       INT           NOT NULL,
    [ProjectLimit]       INT           NOT NULL,
    [MaintenanceContact] BIT           NOT NULL,
    CONSTRAINT [FK_tbl_customers1] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[tbl_customers] ([CustomerID]),
	PRIMARY KEY CLUSTERED ([ProjectID] ASC)
);

CREATE TABLE [dbo].[tbl_invoices] (
    [InvoiceID]       INT           NOT NULL,
	[CustomerID]      INT           NOT NULL,
	[ProjectID]       INT           NOT NULL,
    [InvoiceData]     DATETIME      NOT NULL,
    [InvoicePaid]     BIT           NOT NULL,
    [InvoiceSent]     BIT           NOT NULL,
    [InvoiceStatus]   BIT           NOT NULL,
    [InvoiceTerms]    NVARCHAR (25) NOT NULL,
    [LastContactDate] DATETIME      NOT NULL,
    [LedgerAccNum]    NVARCHAR (25) NOT NULL,
    [TaxCode]         NVARCHAR (25) NOT NULL,
	CONSTRAINT [FK_tbl_customers3] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[tbl_customers] ([CustomerID]),
	CONSTRAINT [FK_tbl_projects] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[tbl_projects] ([ProjectID]),
    PRIMARY KEY CLUSTERED ([InvoiceID] ASC)
);

CREATE TABLE [dbo].[tbl_appointments] (
    [AppointmentID]       INT           NOT NULL,
    [CustomerID]          INT           NOT NULL,
    [AppointmentSubject]  NVARCHAR (50) NOT NULL,
    [AppointmentDate]     DATE          NOT NULL,
    [AppointmentLocation] NVARCHAR (25) NOT NULL,
    [AppointmentAdress]   NVARCHAR (25) NOT NULL,
    [AppointmentTime]     DATETIME      NOT NULL,
	CONSTRAINT [FK_tbl_customers2] FOREIGN KEY ([CustomerID]) REFERENCES [tbl_customers]([CustomerID]),
	PRIMARY KEY CLUSTERED ([AppointmentID] ASC)
);

CREATE TABLE [dbo].[tbl_users] (
    [UserID]   INT           NOT NULL,
    [Username] NVARCHAR (15) NOT NULL,
    [Password] NVARCHAR (25) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);