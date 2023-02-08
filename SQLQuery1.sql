CREATE TABLE [dbo].[Customer] (
    [cid]         INT           IDENTITY (1, 1) NOT NULL,
    [cname]       VARCHAR (250) NOT NULL,
    [mobile]      BIGINT        NOT NULL,
    [nationality] VARCHAR (50)  NOT NULL,
    [gender]      VARCHAR (50)  NOT NULL,
    [dob]         VARCHAR (50)  NOT NULL,
    [cnic]        VARCHAR (50)  NOT NULL,
    [address]     VARCHAR (50)  NOT NULL,
    [checkin]     VARCHAR (50)  NOT NULL,
    [checkout]    VARCHAR (50)  NOT NULL,
    [chekout]     VARCHAR (50)  DEFAULT ('No') NOT NULL,
    [roomid]      INT           NOT NULL,
    FOREIGN KEY ([roomid]) REFERENCES [dbo].[room] ([roomid])
);