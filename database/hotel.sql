-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.1.0 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for hotel
DROP DATABASE IF EXISTS `hotel`;
CREATE DATABASE IF NOT EXISTS `hotel` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `hotel`;

-- Dumping structure for table hotel.client
DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Mail` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Deleted` tinyint(1) NOT NULL DEFAULT '0',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.client: ~22 rows (approximately)
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` (`ID`, `Name`, `Mail`, `Deleted`, `CreatedAt`) VALUES
	(1, 'John Doe', 'john.doe@example.com', 0, '2024-01-09 18:30:26'),
	(2, 'Jane Smith', 'jane.smith@example.com', 0, '2024-01-09 18:30:26'),
	(3, 'Michael Johnson', 'michael.johnson@example.com', 0, '2024-01-09 18:30:26'),
	(4, 'Emily Davis', 'emily.davis@example.com', 0, '2024-01-09 18:30:26'),
	(5, 'Robert Miller', 'robert.miller@example.com', 0, '2024-01-09 18:30:26'),
	(6, 'Sophia Wilson', 'sophia.wilson@example.com', 0, '2024-01-09 18:30:26'),
	(7, 'Matthew Brown', 'matthew.brown@example.com', 0, '2024-01-09 18:30:26'),
	(8, 'Olivia Moore', 'olivia.moore@example.com', 0, '2024-01-09 18:30:26'),
	(9, 'Daniel Lee', 'daniel.lee@example.com', 0, '2024-01-09 18:30:26'),
	(10, 'Ava Harris', 'ava.harris@example.com', 0, '2024-01-09 18:30:26'),
	(11, 'William Taylor', 'william.taylor@example.com', 0, '2024-01-09 18:30:26'),
	(12, 'Emma Anderson', 'emma.anderson@example.com', 0, '2024-01-09 18:30:26'),
	(13, 'James White', 'james.white@example.com', 0, '2024-01-09 18:30:26'),
	(14, 'Isabella Martin', 'isabella.martin@example.com', 0, '2024-01-09 18:30:26'),
	(15, 'Benjamin Thompson', 'benjamin.thompson@example.com', 0, '2024-01-09 18:30:26'),
	(16, 'Mia Garcia', 'mia.garcia@example.com', 0, '2024-01-09 18:30:26'),
	(17, 'Elijah Martinez', 'elijah.martinez@example.com', 0, '2024-01-09 18:30:26'),
	(18, 'Avery Robinson', 'avery.robinson@example.com', 0, '2024-01-09 18:30:26'),
	(19, 'Charlotte Clark', 'charlotte.clark@example.com', 0, '2024-01-09 18:30:26'),
	(20, 'Liam Hall', 'liam.hall@example.com', 0, '2024-01-09 18:30:26'),
	(21, 'Joe Mama', 'joe.mama@example.com', 0, '2024-01-09 20:37:06'),
	(22, 'Candice', 'candice@example.com', 0, '2024-01-09 20:37:46');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;

-- Dumping structure for table hotel.reservation
DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `CheckIn` date NOT NULL,
  `CheckOut` date NOT NULL,
  `NumPeople` int NOT NULL DEFAULT '0',
  `ClientID` int NOT NULL,
  `TreatmentType` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `RoomNum` int NOT NULL DEFAULT '0',
  `Deleted` tinyint(1) NOT NULL DEFAULT '0',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`) USING BTREE,
  KEY `ClientID` (`ClientID`) USING BTREE,
  KEY `TreatmentType` (`TreatmentType`) USING BTREE,
  CONSTRAINT `ClientID` FOREIGN KEY (`ClientID`) REFERENCES `client` (`ID`),
  CONSTRAINT `TreatmentType` FOREIGN KEY (`TreatmentType`) REFERENCES `treatment` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.reservation: ~30 rows (approximately)
/*!40000 ALTER TABLE `reservation` DISABLE KEYS */;
INSERT INTO `reservation` (`ID`, `CheckIn`, `CheckOut`, `NumPeople`, `ClientID`, `TreatmentType`, `RoomNum`, `Deleted`, `CreatedAt`) VALUES
	(152, '2024-02-01', '2024-02-05', 2, 1, 'Half Board', 101, 0, '2024-01-09 19:32:09'),
	(153, '2024-02-10', '2024-02-15', 3, 2, 'Full Board', 105, 0, '2024-01-09 19:32:09'),
	(154, '2024-03-05', '2024-03-10', 1, 3, 'Bed and Breakfast', 110, 0, '2024-01-09 19:32:09'),
	(155, '2024-04-01', '2024-04-07', 2, 4, 'All-Inclusive', 201, 0, '2024-01-09 19:32:09'),
	(156, '2024-04-15', '2024-04-20', 2, 5, 'Room Only', 205, 0, '2024-01-09 19:32:09'),
	(157, '2024-05-02', '2024-05-08', 4, 6, 'Breakfast Buffet', 206, 0, '2024-01-09 19:32:09'),
	(158, '2024-06-01', '2024-06-07', 2, 7, 'Lunch Buffet', 207, 0, '2024-01-09 19:32:09'),
	(159, '2024-06-15', '2024-06-20', 3, 8, 'Dinner Buffet', 208, 0, '2024-01-09 19:32:09'),
	(160, '2024-07-01', '2024-07-05', 1, 9, 'Afternoon Tea', 209, 0, '2024-01-09 19:32:09'),
	(161, '2024-11-20', '2024-11-25', 1, 7, 'Room Only', 201, 0, '2024-01-09 19:32:38'),
	(162, '2024-12-01', '2024-12-05', 2, 8, 'Breakfast Buffet', 205, 0, '2024-01-09 19:32:38'),
	(163, '2024-12-10', '2024-12-15', 3, 9, 'Dinner Buffet', 210, 0, '2024-01-09 19:32:38'),
	(164, '2025-01-01', '2025-01-07', 2, 10, 'Half Board', 101, 0, '2024-01-09 19:32:38'),
	(165, '2025-02-02', '2025-02-08', 1, 2, 'Bed and Breakfast', 110, 0, '2024-01-09 19:32:38'),
	(166, '2025-02-20', '2025-02-25', 2, 3, 'All-Inclusive', 201, 0, '2024-01-09 19:32:38'),
	(167, '2025-03-01', '2025-03-07', 2, 4, 'Room Only', 205, 0, '2024-01-09 19:32:38'),
	(168, '2025-03-15', '2025-03-20', 4, 5, 'Breakfast Buffet', 206, 0, '2024-01-09 19:32:38'),
	(169, '2025-04-01', '2025-04-07', 2, 6, 'Lunch Buffet', 207, 0, '2024-01-09 19:32:38'),
	(170, '2025-04-15', '2025-04-20', 3, 7, 'Dinner Buffet', 208, 0, '2024-01-09 19:32:38'),
	(171, '2025-05-02', '2025-05-08', 1, 8, 'Afternoon Tea', 209, 0, '2024-01-09 19:32:38'),
	(172, '2025-08-01', '2025-08-07', 2, 3, 'Room Only', 205, 0, '2024-01-09 19:33:13'),
	(173, '2025-09-20', '2025-09-25', 1, 6, 'Room Only', 201, 0, '2024-01-09 19:33:13'),
	(174, '2024-01-11', '2024-01-14', 1, 3, 'Chef Special', 105, 0, '2024-01-09 19:35:22'),
	(175, '2024-01-18', '2024-01-20', 5, 8, 'Full Board', 109, 0, '2024-01-09 19:37:51'),
	(176, '2024-01-17', '2024-01-19', 2, 4, 'Room Only', 104, 0, '2024-01-09 19:40:43'),
	(177, '2024-01-09', '2024-01-16', 6, 15, 'Dinner Buffet', 109, 1, '2024-01-09 19:41:45'),
	(178, '2024-01-09', '2024-01-18', 2, 20, 'Breakfast Buffet', 108, 0, '2024-01-09 19:44:26'),
	(179, '2024-01-16', '2024-01-19', 3, 21, 'Full Board', 208, 0, '2024-01-09 20:45:37'),
	(180, '2024-01-10', '2024-01-14', 5, 9, 'Full Board', 209, 0, '2024-01-09 20:46:29'),
	(181, '2023-12-26', '2024-01-31', 1, 21, 'All-Inclusive', 101, 0, '2024-01-09 20:55:27');
/*!40000 ALTER TABLE `reservation` ENABLE KEYS */;

-- Dumping structure for table hotel.room
DROP TABLE IF EXISTS `room`;
CREATE TABLE IF NOT EXISTS `room` (
  `Number` int NOT NULL,
  `MaxPeople` int NOT NULL DEFAULT '1',
  `TypeId` int DEFAULT NULL,
  `Deleted` tinyint(1) NOT NULL DEFAULT '0',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Number`) USING BTREE,
  KEY `TypeId` (`TypeId`) USING BTREE,
  CONSTRAINT `TypeId` FOREIGN KEY (`TypeId`) REFERENCES `room_type` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.room: ~23 rows (approximately)
/*!40000 ALTER TABLE `room` DISABLE KEYS */;
INSERT INTO `room` (`Number`, `MaxPeople`, `TypeId`, `Deleted`, `CreatedAt`) VALUES
	(101, 2, 1, 0, '2024-01-09 19:16:12'),
	(102, 2, 2, 0, '2024-01-09 19:16:12'),
	(103, 3, 3, 0, '2024-01-09 19:16:12'),
	(104, 4, 4, 0, '2024-01-09 19:16:12'),
	(105, 2, 5, 0, '2024-01-09 19:16:12'),
	(106, 4, 6, 0, '2024-01-09 19:16:12'),
	(107, 2, 7, 0, '2024-01-09 19:16:12'),
	(108, 3, 8, 0, '2024-01-09 19:16:12'),
	(109, 9, 2, 0, '2024-01-09 19:16:12'),
	(110, 3, 10, 0, '2024-01-09 19:16:12'),
	(111, 12, 21, 0, '2024-01-09 19:43:53'),
	(201, 2, 1, 0, '2024-01-09 19:16:12'),
	(202, 2, 2, 0, '2024-01-09 19:16:12'),
	(203, 3, 3, 0, '2024-01-09 19:16:12'),
	(204, 4, 4, 0, '2024-01-09 19:16:12'),
	(205, 2, 5, 0, '2024-01-09 19:16:12'),
	(206, 4, 6, 0, '2024-01-09 19:16:12'),
	(207, 2, 7, 0, '2024-01-09 19:16:12'),
	(208, 3, 8, 0, '2024-01-09 19:16:12'),
	(209, 9, 2, 0, '2024-01-09 19:16:12'),
	(210, 3, 10, 0, '2024-01-09 19:16:12'),
	(211, 23, 21, 0, '2024-01-09 20:38:47'),
	(212, 12, 7, 0, '2024-01-09 20:52:42');
/*!40000 ALTER TABLE `room` ENABLE KEYS */;

-- Dumping structure for table hotel.room_reservation
DROP TABLE IF EXISTS `room_reservation`;
CREATE TABLE IF NOT EXISTS `room_reservation` (
  `ReservationId` int NOT NULL DEFAULT '0',
  `RoomNumber` int NOT NULL DEFAULT '0',
  `Deleted` tinyint(1) NOT NULL DEFAULT '0',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ReservationId`,`RoomNumber`),
  KEY `RoomNumber` (`RoomNumber`),
  CONSTRAINT `ReservationId` FOREIGN KEY (`ReservationId`) REFERENCES `reservation` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.room_reservation: ~0 rows (approximately)
/*!40000 ALTER TABLE `room_reservation` DISABLE KEYS */;
/*!40000 ALTER TABLE `room_reservation` ENABLE KEYS */;

-- Dumping structure for table hotel.room_service
DROP TABLE IF EXISTS `room_service`;
CREATE TABLE IF NOT EXISTS `room_service` (
  `RoomNumber` int NOT NULL,
  `ServiceID` int NOT NULL,
  `Deleted` tinyint(1) NOT NULL DEFAULT '0',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`RoomNumber`,`ServiceID`),
  KEY `ServiceId` (`ServiceID`),
  CONSTRAINT `RoomNumber` FOREIGN KEY (`RoomNumber`) REFERENCES `room` (`Number`),
  CONSTRAINT `ServiceId` FOREIGN KEY (`ServiceID`) REFERENCES `service` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.room_service: ~42 rows (approximately)
/*!40000 ALTER TABLE `room_service` DISABLE KEYS */;
INSERT INTO `room_service` (`RoomNumber`, `ServiceID`, `Deleted`, `CreatedAt`) VALUES
	(101, 1, 0, '2024-01-09 19:18:28'),
	(102, 3, 0, '2024-01-09 19:18:28'),
	(103, 5, 0, '2024-01-09 19:18:28'),
	(104, 7, 0, '2024-01-09 19:18:28'),
	(105, 9, 0, '2024-01-09 19:18:28'),
	(106, 11, 0, '2024-01-09 19:18:28'),
	(107, 13, 0, '2024-01-09 19:18:28'),
	(108, 15, 0, '2024-01-09 19:18:28'),
	(109, 17, 0, '2024-01-09 19:18:28'),
	(110, 19, 0, '2024-01-09 19:18:28'),
	(111, 1, 0, '2024-01-09 19:43:53'),
	(111, 2, 0, '2024-01-09 19:43:53'),
	(111, 3, 0, '2024-01-09 19:43:53'),
	(111, 4, 0, '2024-01-09 19:43:53'),
	(111, 8, 0, '2024-01-09 19:43:53'),
	(201, 2, 0, '2024-01-09 19:18:28'),
	(202, 4, 0, '2024-01-09 19:18:28'),
	(203, 6, 0, '2024-01-09 19:18:28'),
	(204, 8, 0, '2024-01-09 19:18:28'),
	(205, 10, 0, '2024-01-09 19:18:28'),
	(206, 12, 0, '2024-01-09 19:18:28'),
	(207, 14, 0, '2024-01-09 19:18:28'),
	(208, 16, 0, '2024-01-09 19:18:28'),
	(209, 18, 0, '2024-01-09 19:18:28'),
	(210, 20, 0, '2024-01-09 19:18:28'),
	(211, 1, 0, '2024-01-09 20:38:47'),
	(211, 2, 0, '2024-01-09 20:38:47'),
	(211, 3, 0, '2024-01-09 20:38:47'),
	(211, 4, 0, '2024-01-09 20:38:47'),
	(211, 5, 0, '2024-01-09 20:38:47'),
	(211, 6, 0, '2024-01-09 20:38:47'),
	(211, 7, 0, '2024-01-09 20:38:47'),
	(211, 8, 0, '2024-01-09 20:38:47'),
	(211, 9, 0, '2024-01-09 20:38:47'),
	(211, 10, 0, '2024-01-09 20:38:47'),
	(211, 11, 0, '2024-01-09 20:38:47'),
	(211, 12, 0, '2024-01-09 20:38:47'),
	(211, 13, 0, '2024-01-09 20:38:47'),
	(211, 14, 0, '2024-01-09 20:38:47'),
	(211, 15, 0, '2024-01-09 20:38:47'),
	(211, 16, 0, '2024-01-09 20:38:47'),
	(211, 17, 0, '2024-01-09 20:38:47');
/*!40000 ALTER TABLE `room_service` ENABLE KEYS */;

-- Dumping structure for table hotel.room_type
DROP TABLE IF EXISTS `room_type`;
CREATE TABLE IF NOT EXISTS `room_type` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Price` decimal(11,2) NOT NULL,
  `Deleted` tinyint(1) NOT NULL DEFAULT '0',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.room_type: ~21 rows (approximately)
/*!40000 ALTER TABLE `room_type` DISABLE KEYS */;
INSERT INTO `room_type` (`ID`, `Name`, `Price`, `Deleted`, `CreatedAt`) VALUES
	(1, 'Standard Single', 75.00, 0, '2024-01-09 18:30:26'),
	(2, 'Standard Double', 100.00, 0, '2024-01-09 18:30:26'),
	(3, 'Deluxe Single', 120.00, 0, '2024-01-09 18:30:26'),
	(4, 'Deluxe Double', 150.00, 0, '2024-01-09 18:30:26'),
	(5, 'Executive Suite', 200.00, 0, '2024-01-09 18:30:26'),
	(6, 'Family Room', 180.00, 0, '2024-01-09 18:30:26'),
	(7, 'Presidential Suite', 300.00, 0, '2024-01-09 18:30:26'),
	(8, 'Honeymoon Suite', 250.00, 0, '2024-01-09 18:30:26'),
	(9, 'Ocean View Room', 180.00, 0, '2024-01-09 18:30:26'),
	(10, 'Mountain View Room', 160.00, 0, '2024-01-09 18:30:26'),
	(11, 'Business Class Room', 190.00, 0, '2024-01-09 18:30:26'),
	(12, 'Pet-Friendly Room', 110.00, 0, '2024-01-09 18:30:26'),
	(13, 'Accessible Room', 100.00, 0, '2024-01-09 18:30:26'),
	(14, 'Luxury Penthouse', 350.00, 0, '2024-01-09 18:30:26'),
	(15, 'Vintage Suite', 220.00, 0, '2024-01-09 18:30:26'),
	(16, 'Garden View Room', 140.00, 0, '2024-01-09 18:30:26'),
	(17, 'Romantic Getaway Suite', 280.00, 0, '2024-01-09 18:30:26'),
	(18, 'City View Room', 160.00, 0, '2024-01-09 18:30:26'),
	(19, 'Art Deco Room', 130.00, 0, '2024-01-09 18:30:26'),
	(20, 'Eco-Friendly Room', 90.00, 0, '2024-01-09 18:30:26'),
	(21, 'Attic', 2000.00, 0, '2024-01-09 19:43:13');
/*!40000 ALTER TABLE `room_type` ENABLE KEYS */;

-- Dumping structure for table hotel.service
DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Price` decimal(11,2) DEFAULT NULL,
  `Deleted` tinyint(1) NOT NULL DEFAULT '0',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.service: ~20 rows (approximately)
/*!40000 ALTER TABLE `service` DISABLE KEYS */;
INSERT INTO `service` (`ID`, `Name`, `Price`, `Deleted`, `CreatedAt`) VALUES
	(1, 'Room Cleaning', 25.00, 0, '2024-01-09 18:30:26'),
	(2, 'Breakfast', 15.00, 0, '2024-01-09 18:30:26'),
	(3, 'Wi-Fi Access', 10.00, 0, '2024-01-09 18:30:26'),
	(4, 'Airport Shuttle', 30.00, 0, '2024-01-09 18:30:26'),
	(5, 'Laundry Service', 20.00, 0, '2024-01-09 18:30:26'),
	(6, 'Spa Treatment', 50.00, 0, '2024-01-09 18:30:26'),
	(7, 'Room Service - Dinner', 35.00, 0, '2024-01-09 18:30:26'),
	(8, 'Parking Service', 15.00, 0, '2024-01-09 18:30:26'),
	(9, 'Fitness Center Access', 10.00, 0, '2024-01-09 18:30:26'),
	(10, 'Conference Room Rental', 40.00, 0, '2024-01-09 18:30:26'),
	(11, 'Late Check-Out', 20.00, 0, '2024-01-09 18:30:26'),
	(12, 'Mini Bar Restocking', 18.00, 0, '2024-01-09 18:30:26'),
	(13, 'Pet Friendly Service', 25.00, 0, '2024-01-09 18:30:26'),
	(14, 'Pool Access', 15.00, 0, '2024-01-09 18:30:26'),
	(15, 'In-Room Movies', 12.00, 0, '2024-01-09 18:30:26'),
	(16, 'Business Center Services', 18.00, 0, '2024-01-09 18:30:26'),
	(17, 'Babysitting Service', 30.00, 0, '2024-01-09 18:30:26'),
	(18, 'Daily Newspaper Delivery', 8.00, 0, '2024-01-09 18:30:26'),
	(19, 'Concierge Assistance', 15.00, 0, '2024-01-09 18:30:26'),
	(20, 'Turndown Service', 22.00, 0, '2024-01-09 18:30:26');
/*!40000 ALTER TABLE `service` ENABLE KEYS */;

-- Dumping structure for table hotel.treatment
DROP TABLE IF EXISTS `treatment`;
CREATE TABLE IF NOT EXISTS `treatment` (
  `Name` varchar(50) NOT NULL,
  `Price` decimal(11,2) NOT NULL DEFAULT '0.00',
  `Deleted` tinyint(1) NOT NULL DEFAULT '0',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.treatment: ~10 rows (approximately)
/*!40000 ALTER TABLE `treatment` DISABLE KEYS */;
INSERT INTO `treatment` (`Name`, `Price`, `Deleted`, `CreatedAt`) VALUES
	('Afternoon Tea', 12.00, 0, '2024-01-09 18:33:13'),
	('All-Inclusive', 80.00, 0, '2024-01-09 18:33:13'),
	('Bed and Breakfast', 30.00, 0, '2024-01-09 18:33:13'),
	('Breakfast Buffet', 15.00, 0, '2024-01-09 18:33:13'),
	('Chef Special', 50.00, 0, '2024-01-09 18:33:13'),
	('Dinner Buffet', 35.00, 0, '2024-01-09 18:33:13'),
	('Full Board', 60.00, 0, '2024-01-09 18:33:13'),
	('Half Board', 40.00, 0, '2024-01-09 18:33:13'),
	('Lunch Buffet', 25.00, 0, '2024-01-09 18:33:13'),
	('Room Only', 20.00, 0, '2024-01-09 18:33:13');
/*!40000 ALTER TABLE `treatment` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
