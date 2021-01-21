USE [AIRPORT]

CREATE TABLE [TYPE](
[ID]				INT PRIMARY KEY IDENTITY(0,1)				NOT NULL,
[TYPE]				NVARCHAR(30)								NOT NULL
)

CREATE TABLE [PLANE](
[ID]				INT PRIMARY KEY IDENTITY(0,1)                NOT NULL,
[PLACE]				NVARCHAR(30)                                 NOT NULL,
[SPEED]				INT                                          NOT NULL,
[IDTYPE]			INT CONSTRAINT FK_PLANE_IDTYPE_TYPE_ID FOREIGN KEY REFERENCES [TYPE] ([ID])	NOT NULL
)

CREATE TABLE [PATH](
[ID]				INT PRIMARY KEY IDENTITY(0,1)				NOT NULL,
[DISTANCE]			INT											NOT NULL,
[DEPARTURE]			NVARCHAR(30)								NOT NULL,
[DESTINATION]		NVARCHAR(30)								NOT NULL,
[IDTYPE]			INT CONSTRAINT FK_PATH_IDTYPE_TYPE_ID FOREIGN KEY REFERENCES [TYPE] ([ID]) NOT NULL
)

CREATE TABLE [DATE](
[ID]				INT PRIMARY KEY IDENTITY(0,1)				NOT NULL,
[DEPARTUREDATE]		DATETIME									NOT NULL,
[DESTINATIONDATE]	DATETIME									NOT NULL,
[IDPATH]			INT CONSTRAINT FK_DATE_IDPATH_PATH_ID FOREIGN KEY REFERENCES [PATH] ([ID]) NOT NULL

)

CREATE TABLE [TICKETS](
[ID]				INT PRIMARY KEY IDENTITY(0,1)				NOT NULL,
[SELLTICKETS]		INT											NOT NULL,
[IDPATH]			INT CONSTRAINT FK_TICKETS_IDPATH_PATH_ID FOREIGN KEY REFERENCES [PATH] ([ID]) NOT NULL
)