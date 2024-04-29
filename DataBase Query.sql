create database RailwaysProject
use RailwaysProject

create table Users(
	Email nvarchar(50) primary key not null,
	Username varchar(50),
	password varchar(MAX),
	salt DATETIME,
	Admin bit
)

create table UserProfiles(
	Email nvarchar(50),
	constraint Em foreign key(Email) references Users(Email),
	Picture varbinary(MAX),
	Firstname varchar(MAX),
	Lastname varchar(MAX),
	Sex varchar(MAX)
)

create table Tracks(
	Track_ID int identity(1,1) primary key not null, 
	Train varchar(MAX),
	Departure varchar(MAX),
	Arrival varchar(MAX),
	Departure_Time DATETIME,
	Arrival_Time DATETIME,
	Capacity int,
	remaining_seats int
)

create table Tickets(
	Ticket_ID int identity(1,1) primary key not null,
	Tr_ID int,
	constraint TID foreign key (Tr_ID) references Tracks(Track_ID),
	cost float,
	Holder_Firstname varchar(MAX),
	Holder_Lastname varchar(MAX),
	Seat_Num int,
	specifics varchar(MAX)
)


