USE HotelDB;

-- 1. Write a query that returns a list of reservations that end in July 2023, including the name of the guest, the room number(s), and the reservation dates.

SELECT name, room_number, start_date, end_date FROM Reservation
JOIN Room ON Reservation.roomID = Room.roomID
WHERE MONTH(end_date) = 7 AND YEAR(end_date) = 2023;

-- 2. Write a query that returns a list of all reservations for rooms with a jacuzzi, displaying the guest's name, the room number, and the dates of the reservation.

SELECT name, room_number, start_date, end_date FROM Reservation
JOIN Room ON Reservation.roomID = Room.roomID
JOIN RoomAmenity ON Room.roomID = RoomAmenity.roomID AND RoomAmenity.amenityID = 2;

-- 3. Write a query that returns all the rooms reserved for a specific guest, including the guest's name, the room(s) reserved, the starting date of the reservation, and how many people were included in the reservation. (Choose a guest's name from the existing data.)

SELECT 	
	name,
    room_number,
    start_date,
    (adults + children) as total_people
FROM Reservation
INNER JOIN Room ON Reservation.roomID = Room.roomID 
WHERE Reservation.guestID = 1;

-- 4. Write a query that returns a list of rooms, reservation ID, and per-room cost for each reservation. The results should include all rooms, whether or not there is a reservation associated with the room.

SELECT room_number, reservationID, total_room_cost FROM Room
LEFT OUTER JOIN Reservation 
    ON Room.roomID = Reservation.roomID ;

-- 5. Write a query that returns all the rooms accommodating at least three guests and that are reserved on any date in April 2023.

SELECT * FROM Room
INNER JOIN Reservation ON Room.roomID = Reservation.roomID 
WHERE (adults + children) >= 3 AND MONTH(start_date) = 4 AND YEAR(start_date) = 2023;

-- 6. Write a query that returns a list of all guest names and the number of reservations per guest, sorted starting with the guest with the most reservations and then by the guest's last name.

SELECT 
SUBSTRING(Guest.name, CHARINDEX(' ',Guest.name) +1, LEN(Guest.name)) as LastName,
COUNT(reservation.reservationID) AS total_reservation
FROM Guest
INNER JOIN Reservation ON Guest.guestID = Reservation.guestID 
GROUP BY Reservation.guestId, Guest.name
ORDER BY total_reservation DESC;

-- 7. Write a query that displays the name, address, and phone number of a guest based on their phone number. (Choose a phone number from the existing data.)

SELECT name, address, phone FROM guest
WHERE phone = '(123) 456-7899';