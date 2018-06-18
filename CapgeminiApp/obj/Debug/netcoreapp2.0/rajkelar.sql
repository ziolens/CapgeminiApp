IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Customers] (
    [ID] uniqueidentifier NOT NULL,
    [Address] nvarchar(max) NULL,
    [Name] nvarchar(max) NULL,
    [Surname] nvarchar(max) NULL,
    [TelephoneNumber] nvarchar(max) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([ID])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180614194930_InitialCreate', N'2.1.0-rtm-30799');

GO

