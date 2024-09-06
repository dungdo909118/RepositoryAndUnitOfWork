CREATE DATABASE  IF NOT EXISTS `ordermanager` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `ordermanager`;
-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ordermanager
-- ------------------------------------------------------
-- Server version	8.0.38

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `CustomerID` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `City` varchar(50) DEFAULT NULL,
  `State` varchar(50) DEFAULT NULL,
  `PostalCode` varchar(20) DEFAULT NULL,
  `Country` varchar(50) DEFAULT NULL,
  `CreatedAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`CustomerID`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'John','Doe','john.doe@example.com','123-456-7890','123 Elm St','Springfield','IL','62701','USA','2024-08-22 01:29:07'),(2,'Jane','Smith','jane.smith@example.com','234-567-8901','456 Oak St','Springfield','IL','62702','USA','2024-08-22 01:29:07'),(3,'Alice','Johnson','alice.johnson@example.com','345-678-9012','789 Pine St','Springfield','IL','62703','USA','2024-08-22 01:29:07'),(4,'Bob','Brown','bob.brown@example.com','456-789-0123','101 Maple St','Springfield','IL','62704','USA','2024-08-22 01:29:07'),(5,'Carol','Williams','carol.williams@example.com','567-890-1234','202 Birch St','Springfield','IL','62705','USA','2024-08-22 01:29:07'),(6,'David','Lee','david.lee@example.com','678-901-2345','303 Cedar St','Springfield','IL','62706','USA','2024-08-22 01:29:07'),(7,'Emily','Davis','emily.davis@example.com','789-012-3456','404 Elm St','Springfield','IL','62707','USA','2024-08-22 01:29:07'),(8,'Frank','Wilson','frank.wilson@example.com','890-123-4567','505 Oak St','Springfield','IL','62708','USA','2024-08-22 01:29:07'),(9,'Grace','Moore','grace.moore@example.com','901-234-5678','606 Pine St','Springfield','IL','62709','USA','2024-08-22 01:29:07'),(10,'Henry','Taylor','henry.taylor@example.com','012-345-6789','707 Maple St','Springfield','IL','62710','USA','2024-08-22 01:29:07'),(11,'Ivy','Anderson','ivy.anderson@example.com','123-456-7891','808 Birch St','Springfield','IL','62711','USA','2024-08-22 01:29:07'),(12,'Jack','Thomas','jack.thomas@example.com','234-567-8902','909 Cedar St','Springfield','IL','62712','USA','2024-08-22 01:29:07'),(13,'Kara','Jackson','kara.jackson@example.com','345-678-9013','1010 Elm St','Springfield','IL','62713','USA','2024-08-22 01:29:07'),(14,'Liam','White','liam.white@example.com','456-789-0124','1111 Oak St','Springfield','IL','62714','USA','2024-08-22 01:29:07'),(15,'Mia','Harris','mia.harris@example.com','567-890-1235','1212 Pine St','Springfield','IL','62715','USA','2024-08-22 01:29:07'),(16,'Noah','Martin','noah.martin@example.com','678-901-2346','1313 Maple St','Springfield','IL','62716','USA','2024-08-22 01:29:07'),(17,'Olivia','Thompson','olivia.thompson@example.com','789-012-3457','1414 Birch St','Springfield','IL','62717','USA','2024-08-22 01:29:07'),(18,'Paul','Garcia','paul.garcia@example.com','890-123-4568','1515 Cedar St','Springfield','IL','62718','USA','2024-08-22 01:29:07'),(19,'Quinn','Martinez','quinn.martinez@example.com','901-234-5679','1616 Elm St','Springfield','IL','62719','USA','2024-08-22 01:29:07'),(20,'Riley','Robinson','riley.robinson@example.com','012-345-6780','1717 Oak St','Springfield','IL','62720','USA','2024-08-22 01:29:07');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-06 15:54:33
