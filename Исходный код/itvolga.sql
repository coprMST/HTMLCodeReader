create database HTMLCodeReader
go

use HTMLCodeReader
go

create table [Sessions](
[SessionID] int identity(1,1) primary key,
[Path] varchar(256) not null,
[Data source type] varchar(256) not null,
[Sorting type] varchar(256) not null,
[Datetime] smalldatetime not null
)
go

create table [StatsSession](
[SessionID] int foreign key references [Sessions]([SessionID]),
[Word] varchar(256) not null,
[Count] int not null
)
go