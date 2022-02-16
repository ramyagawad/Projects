CREATE DATABASE HotelDB;
USE HotelDB;

CREATE TABLE Guest (
    guestID INT PRIMARY KEY identity(1,1),
    [name] VARCHAR (50) NOT NULL,
    [address] VARCHAR (100) NOT NULL,
    city VARCHAR (50) NOT NULL,
    [state] VARCHAR (100) NOT NULL,
    zip VARCHAR (50) NOT NULL,
    phone VARCHAR (25) NOT NULL
);


CREATE TABLE Amenity (
	amenityID INT PRIMARY KEY identity(1,1),
    description VARCHAR(50) NOT NULL
);

CREATE TABLE RoomType (
	room_typeID INT PRIMARY KEY identity(1,1),
    description VARCHAR(50) NOT NULL
);

CREATE DATABASE HotelDB;
USE HotelDB;

CREATE TABLE Room (
	roomID INT PRIMARY KEY identity(1,1),
    room_number INT NOT NULL,
    ada_accessible VARCHAR(5) NOT NULL,
    standard_occupancy INT NOT NULL,
    maximun_occupancy INT NOT NULL,
    base_price FLOAT NOT NULL,
    extra_person FLOAT,
    room_typeID INT NOT NULL
);

CREATE TABLE Reservation (
    reservationID INT PRIMARY KEY identity(1,1),
    [name] VARCHAR(50) NOT NULL,
    adults INT NOT NULL,
    children INT NOT NULL,
	start_date DATETIME NOT NULL,
    end_date DATETIME NOT NULL,
    total_room_cost FLOAT NOT NULL,
    roomID INT NOT NULL,
    guestID INT NOT NULL,
        FOREIGN KEY (roomID) 
        REFERENCES Room(roomID),
        FOREIGN KEY (guestID) 
        REFERENCES Guest(guestID)
);

CREATE TABLE RoomAmenity (
	roomID INT NOT NULL,
    amenityID INT NOT NULL,
    PRIMARY KEY (roomID, amenityID),
    FOREIGN KEY (roomID)
		REFERENCES Room(roomID),
	FOREIGN KEY  (amenityID)
		REFERENCES Amenity(amenityID)
);