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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.client: ~0 rows (approximately)
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` (`ID`, `Name`, `Mail`, `Deleted`, `CreatedAt`) VALUES
	(1, 'John Doe', 'john@example.com', 0, '2023-11-30 16:05:01'),
	(2, 'Jane Smith', 'jane@example.com', 0, '2023-11-30 16:05:01'),
	(3, 'Alice Johnson', 'alice@example.com', 0, '2023-11-30 16:05:01'),
	(4, 'Bob Williams', 'bob@example.com', 0, '2023-11-30 16:05:01'),
	(5, 'Eva Davis', 'eva@example.com', 0, '2023-11-30 16:05:01'),
	(6, 'Michael Brown', 'michael@example.com', 0, '2023-11-30 16:05:01'),
	(7, 'Olivia Garcia', 'olivia@example.com', 0, '2023-11-30 16:05:01'),
	(8, 'James Martinez', 'james@example.com', 0, '2023-11-30 16:05:01'),
	(9, 'Sophia Robinson', 'sophia@example.com', 0, '2023-11-30 16:05:01'),
	(10, 'Liam Lee', 'liam@example.com', 0, '2023-11-30 16:05:01'),
	(11, 'Emma Hernandez', 'emma@example.com', 0, '2023-11-30 16:05:01'),
	(12, 'Noah Wright', 'noah@example.com', 0, '2023-11-30 16:05:01'),
	(13, 'Ava Clark', 'ava@example.com', 0, '2023-11-30 16:05:01'),
	(14, 'Logan Hall', 'logan@example.com', 0, '2023-11-30 16:05:01'),
	(15, 'Grace Turner', 'grace@example.com', 0, '2023-11-30 16:05:01'),
	(16, 'Elijah Adams', 'elijah@example.com', 0, '2023-11-30 16:05:01'),
	(17, 'Mia Evans', 'mia@example.com', 0, '2023-11-30 16:05:01'),
	(18, 'Jackson Hill', 'jackson@example.com', 0, '2023-11-30 16:05:01'),
	(19, 'Avery Turner', 'avery@example.com', 0, '2023-11-30 16:05:01'),
	(20, 'Lily Bennett', 'lily@example.com', 0, '2023-11-30 16:05:01');
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
  `Deleted` tinyint(1) NOT NULL DEFAULT '0',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`) USING BTREE,
  KEY `ClientID` (`ClientID`) USING BTREE,
  KEY `TreatmentType` (`TreatmentType`) USING BTREE,
  CONSTRAINT `ClientID` FOREIGN KEY (`ClientID`) REFERENCES `client` (`ID`),
  CONSTRAINT `TreatmentType` FOREIGN KEY (`TreatmentType`) REFERENCES `treatment` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.reservation: ~0 rows (approximately)
/*!40000 ALTER TABLE `reservation` DISABLE KEYS */;
INSERT INTO `reservation` (`ID`, `CheckIn`, `CheckOut`, `NumPeople`, `ClientID`, `TreatmentType`, `Deleted`, `CreatedAt`) VALUES
	(1, '2023-01-01', '2023-01-10', 2, 1, 'Massage', 0, '2023-11-30 16:08:20'),
	(2, '2023-02-05', '2023-02-12', 3, 2, 'Facial', 0, '2023-11-30 16:08:20'),
	(3, '2023-03-10', '2023-03-15', 1, 3, 'Spa Package', 0, '2023-11-30 16:08:20'),
	(4, '2023-04-20', '2023-04-25', 2, 4, 'Sauna', 0, '2023-11-30 16:08:20'),
	(5, '2023-05-15', '2023-05-20', 4, 5, 'Massage', 0, '2023-11-30 16:08:20'),
	(6, '2023-06-01', '2023-06-07', 3, 6, 'Facial', 0, '2023-11-30 16:08:20'),
	(7, '2023-07-12', '2023-07-18', 2, 7, 'Spa Package', 0, '2023-11-30 16:08:20'),
	(8, '2023-08-25', '2023-09-01', 1, 8, 'Sauna', 0, '2023-11-30 16:08:20'),
	(9, '2023-09-10', '2023-09-18', 3, 9, 'Massage', 0, '2023-11-30 16:08:20'),
	(10, '2023-10-05', '2023-10-12', 4, 10, 'Facial', 0, '2023-11-30 16:08:20'),
	(11, '2023-11-15', '2023-11-22', 2, 11, 'Spa Package', 0, '2023-11-30 16:08:20'),
	(12, '2023-12-01', '2023-12-08', 1, 12, 'Sauna', 0, '2023-11-30 16:08:20'),
	(13, '2024-01-10', '2024-01-17', 3, 13, 'Massage', 0, '2023-11-30 16:08:20'),
	(14, '2024-02-20', '2024-02-27', 2, 14, 'Facial', 0, '2023-11-30 16:08:20'),
	(15, '2024-03-15', '2024-03-22', 1, 15, 'Spa Package', 0, '2023-11-30 16:08:20'),
	(16, '2024-04-10', '2024-04-17', 4, 16, 'Sauna', 0, '2023-11-30 16:08:20'),
	(17, '2024-05-05', '2024-05-12', 2, 17, 'Massage', 0, '2023-11-30 16:08:20'),
	(18, '2024-06-15', '2024-06-22', 3, 18, 'Facial', 0, '2023-11-30 16:08:20'),
	(19, '2024-07-10', '2024-07-17', 1, 19, 'Spa Package', 0, '2023-11-30 16:08:20'),
	(20, '2024-08-25', '2024-09-01', 2, 20, 'Sauna', 0, '2023-11-30 16:08:20');
/*!40000 ALTER TABLE `reservation` ENABLE KEYS */;

-- Dumping structure for table hotel.room
DROP TABLE IF EXISTS `room`;
CREATE TABLE IF NOT EXISTS `room` (
  `Number` int NOT NULL AUTO_INCREMENT,
  `MaxPeople` int NOT NULL DEFAULT '1',
  `TypeId` int DEFAULT NULL,
  `Deleted` tinyint(1) NOT NULL DEFAULT '0',
  `CreatedAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Number`) USING BTREE,
  KEY `TypeId` (`TypeId`) USING BTREE,
  CONSTRAINT `TypeId` FOREIGN KEY (`TypeId`) REFERENCES `room_type` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.room: ~0 rows (approximately)
/*!40000 ALTER TABLE `room` DISABLE KEYS */;
INSERT INTO `room` (`Number`, `MaxPeople`, `TypeId`, `Deleted`, `CreatedAt`) VALUES
	(1, 2, 1, 0, '2023-11-30 16:06:59'),
	(2, 4, 2, 0, '2023-11-30 16:06:59'),
	(3, 3, 1, 0, '2023-11-30 16:06:59'),
	(4, 2, 3, 0, '2023-11-30 16:06:59'),
	(5, 4, 2, 0, '2023-11-30 16:06:59'),
	(6, 2, 1, 0, '2023-11-30 16:06:59'),
	(7, 3, 2, 0, '2023-11-30 16:06:59'),
	(8, 1, 3, 0, '2023-11-30 16:06:59'),
	(9, 3, 1, 0, '2023-11-30 16:06:59'),
	(10, 2, 2, 0, '2023-11-30 16:06:59'),
	(11, 4, 3, 0, '2023-11-30 16:06:59'),
	(12, 2, 1, 0, '2023-11-30 16:06:59'),
	(13, 3, 2, 0, '2023-11-30 16:06:59'),
	(14, 1, 3, 0, '2023-11-30 16:06:59'),
	(15, 3, 1, 0, '2023-11-30 16:06:59'),
	(16, 2, 2, 0, '2023-11-30 16:06:59'),
	(17, 4, 3, 0, '2023-11-30 16:06:59'),
	(18, 2, 1, 0, '2023-11-30 16:06:59'),
	(19, 3, 2, 0, '2023-11-30 16:06:59'),
	(20, 1, 3, 0, '2023-11-30 16:06:59');
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
  CONSTRAINT `ReservationId` FOREIGN KEY (`ReservationId`) REFERENCES `reservation` (`ID`),
  CONSTRAINT `RoomNumber` FOREIGN KEY (`RoomNumber`) REFERENCES `room` (`Number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.room_reservation: ~2 rows (approximately)
/*!40000 ALTER TABLE `room_reservation` DISABLE KEYS */;
INSERT INTO `room_reservation` (`ReservationId`, `RoomNumber`, `Deleted`, `CreatedAt`) VALUES
	(1, 1, 0, '2023-11-30 16:08:34'),
	(2, 1, 0, '2023-11-30 16:08:34'),
	(3, 2, 0, '2023-11-30 16:08:34'),
	(4, 2, 0, '2023-11-30 16:08:34'),
	(5, 3, 0, '2023-11-30 16:08:34'),
	(6, 3, 0, '2023-11-30 16:08:34'),
	(7, 4, 0, '2023-11-30 16:08:34'),
	(8, 4, 0, '2023-11-30 16:08:34'),
	(9, 5, 0, '2023-11-30 16:08:34'),
	(11, 5, 0, '2023-11-30 16:08:34'),
	(12, 6, 0, '2023-11-30 16:08:34'),
	(13, 6, 0, '2023-11-30 16:08:34'),
	(14, 7, 0, '2023-11-30 16:08:34'),
	(15, 7, 0, '2023-11-30 16:08:34'),
	(16, 8, 0, '2023-11-30 16:08:34'),
	(17, 8, 0, '2023-11-30 16:08:34'),
	(18, 9, 0, '2023-11-30 16:08:34'),
	(19, 9, 0, '2023-11-30 16:08:34'),
	(20, 10, 0, '2023-11-30 16:08:34');
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
  CONSTRAINT `RoomNumberRoomService` FOREIGN KEY (`RoomNumber`) REFERENCES `room` (`Number`),
  CONSTRAINT `ServiceId` FOREIGN KEY (`ServiceID`) REFERENCES `service` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.room_service: ~2 rows (approximately)
/*!40000 ALTER TABLE `room_service` DISABLE KEYS */;
INSERT INTO `room_service` (`RoomNumber`, `ServiceID`, `Deleted`, `CreatedAt`) VALUES
	(1, 4, 0, '2023-11-30 16:09:27'),
	(2, 4, 0, '2023-11-30 16:09:27'),
	(2, 5, 0, '2023-11-30 16:09:27'),
	(2, 6, 0, '2023-11-30 16:09:27'),
	(3, 5, 0, '2023-11-30 16:09:27'),
	(3, 6, 0, '2023-11-30 16:09:27'),
	(4, 7, 0, '2023-11-30 16:09:27'),
	(4, 8, 0, '2023-11-30 16:09:27'),
	(5, 9, 0, '2023-11-30 16:09:27'),
	(6, 10, 0, '2023-11-30 16:09:27'),
	(6, 11, 0, '2023-11-30 16:09:27'),
	(7, 12, 0, '2023-11-30 16:09:27'),
	(7, 13, 0, '2023-11-30 16:09:27'),
	(8, 14, 0, '2023-11-30 16:09:27'),
	(8, 15, 0, '2023-11-30 16:09:27'),
	(9, 16, 0, '2023-11-30 16:09:27'),
	(9, 17, 0, '2023-11-30 16:09:27'),
	(10, 18, 0, '2023-11-30 16:09:27'),
	(11, 19, 0, '2023-11-30 16:09:27'),
	(12, 20, 0, '2023-11-30 16:09:27');
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
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.room_type: ~3 rows (approximately)
/*!40000 ALTER TABLE `room_type` DISABLE KEYS */;
INSERT INTO `room_type` (`ID`, `Name`, `Price`, `Deleted`, `CreatedAt`) VALUES
	(1, 'Surplus', 10.00, 0, '2023-11-30 15:59:04'),
	(2, 'Bungalow', 1000.00, 0, '2023-11-30 15:59:29'),
	(3, 'ChaletWinter', 20.00, 0, '2023-11-30 15:59:46'),
	(4, 'Single', 100.00, 0, '2023-11-30 11:54:19'),
	(5, 'Double', 150.00, 0, '2023-11-30 11:54:19'),
	(6, 'Suite', 200.00, 0, '2023-11-30 11:54:19'),
	(7, 'Deluxe', 250.00, 0, '2023-11-30 11:54:19'),
	(8, 'Standard', 120.00, 0, '2023-11-30 11:54:19'),
	(9, 'Executive', 180.00, 0, '2023-11-30 11:54:19'),
	(10, 'Family', 220.00, 0, '2023-11-30 11:54:19'),
	(11, 'VIP', 300.00, 0, '2023-11-30 11:54:19'),
	(12, 'Ocean View', 280.00, 0, '2023-11-30 11:54:19'),
	(13, 'Presidential', 500.00, 0, '2023-11-30 11:54:19'),
	(14, 'Penthouse', 450.00, 0, '2023-11-30 11:54:19'),
	(15, 'Business Suite', 400.00, 0, '2023-11-30 11:54:19'),
	(16, 'Honeymoon', 320.00, 0, '2023-11-30 11:54:19'),
	(17, 'Mountain View', 260.00, 0, '2023-11-30 11:54:19'),
	(18, 'Garden View', 230.00, 0, '2023-11-30 11:54:19'),
	(19, 'City View', 200.00, 0, '2023-11-30 11:54:19'),
	(20, 'Poolside', 180.00, 0, '2023-11-30 11:54:19'),
	(21, 'Cottage', 150.00, 0, '2023-11-30 11:54:19'),
	(22, 'Chalet', 120.00, 0, '2023-11-30 11:54:19'),
	(23, 'Cabin', 100.00, 0, '2023-11-30 11:54:19');
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
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table hotel.service: ~2 rows (approximately)
/*!40000 ALTER TABLE `service` DISABLE KEYS */;
INSERT INTO `service` (`ID`, `Name`, `Price`, `Deleted`, `CreatedAt`) VALUES
	(4, 'Breakfast', 10.00, 0, '2023-11-30 11:55:48'),
	(5, 'Wi-Fi', 5.00, 0, '2023-11-30 11:55:48'),
	(6, 'Parking', 8.00, 0, '2023-11-30 11:55:48'),
	(7, 'Room Cleaning', 15.00, 0, '2023-11-30 11:55:48'),
	(8, 'Late Checkout', 20.00, 0, '2023-11-30 11:55:48'),
	(9, 'Mini Bar', 12.00, 0, '2023-11-30 11:55:48'),
	(10, 'Airport Shuttle', 25.00, 0, '2023-11-30 11:55:48'),
	(11, 'Laundry', 18.00, 0, '2023-11-30 11:55:48'),
	(12, 'Gym Access', 10.00, 0, '2023-11-30 11:55:48'),
	(13, 'Spa Access', 30.00, 0, '2023-11-30 11:55:48'),
	(14, 'Concierge Service', 15.00, 0, '2023-11-30 11:55:48'),
	(15, 'Business Center', 20.00, 0, '2023-11-30 11:55:48'),
	(16, 'Pet Friendly', 25.00, 0, '2023-11-30 11:55:48'),
	(17, 'Bike Rental', 8.00, 0, '2023-11-30 11:55:48'),
	(18, 'Swimming Pool Access', 15.00, 0, '2023-11-30 11:55:48'),
	(19, 'Conference Room', 50.00, 0, '2023-11-30 11:55:48'),
	(20, 'Private Chef', 100.00, 0, '2023-11-30 11:55:48'),
	(21, 'In-Room Dining', 18.00, 0, '2023-11-30 11:55:48'),
	(22, 'Car Rental', 30.00, 0, '2023-11-30 11:55:48'),
	(23, 'Event Planning', 50.00, 0, '2023-11-30 11:55:48');
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

-- Dumping data for table hotel.treatment: ~2 rows (approximately)
/*!40000 ALTER TABLE `treatment` DISABLE KEYS */;
INSERT INTO `treatment` (`Name`, `Price`, `Deleted`, `CreatedAt`) VALUES
	('Aromatherapy', 35.00, 0, '2023-11-30 11:55:48'),
	('Body Scrub', 30.00, 0, '2023-11-30 11:55:48'),
	('Coloring', 40.00, 0, '2023-11-30 11:55:48'),
	('Couples Massage', 100.00, 0, '2023-11-30 11:55:48'),
	('Deep Tissue Massage', 55.00, 0, '2023-11-30 11:55:48'),
	('Detox Wrap', 30.00, 0, '2023-11-30 11:55:48'),
	('Facial', 40.00, 0, '2023-11-30 11:55:48'),
	('Haircut', 18.00, 0, '2023-11-30 11:55:48'),
	('Hot Stone Massage', 60.00, 0, '2023-11-30 11:55:48'),
	('Makeup Application', 25.00, 0, '2023-11-30 11:55:48'),
	('Manicure', 20.00, 0, '2023-11-30 11:55:48'),
	('Massage', 50.00, 0, '2023-11-30 11:55:48'),
	('Meditation Class', 15.00, 0, '2023-11-30 11:55:48'),
	('Pedicure', 25.00, 0, '2023-11-30 11:55:48'),
	('Reiki Healing', 45.00, 0, '2023-11-30 11:55:48'),
	('Sauna', 25.00, 0, '2023-11-30 11:55:48'),
	('Spa Package', 120.00, 0, '2023-11-30 11:55:48'),
	('Threading', 12.00, 0, '2023-11-30 11:55:48'),
	('Waxing', 15.00, 0, '2023-11-30 11:55:48'),
	('Yoga Session', 20.00, 0, '2023-11-30 11:55:48');
/*!40000 ALTER TABLE `treatment` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
