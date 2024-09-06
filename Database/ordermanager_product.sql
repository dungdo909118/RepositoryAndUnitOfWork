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
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ProductID` int NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(100) NOT NULL,
  `Description` text,
  `Price` decimal(10,2) NOT NULL,
  `StockQuantity` int NOT NULL,
  `CreatedAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ProductID`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'Laptop','15-inch laptop with 8GB RAM and 256GB SSD',799.99,50,'2024-08-22 01:29:40'),(2,'Smartphone','Latest model with 128GB storage and 5G connectivity',499.99,150,'2024-08-22 01:29:40'),(3,'Wireless Mouse','Ergonomic wireless mouse with long battery life',29.99,200,'2024-08-22 01:29:40'),(4,'Headphones','Noise-cancelling over-ear headphones',149.99,75,'2024-08-22 01:29:40'),(5,'Monitor','27-inch 4K monitor with adjustable stand',349.99,30,'2024-08-22 01:29:40'),(6,'Keyboard','Mechanical keyboard with RGB backlighting',89.99,100,'2024-08-22 01:29:40'),(7,'Webcam','HD webcam with built-in microphone',59.99,80,'2024-08-22 01:29:40'),(8,'External Hard Drive','1TB external hard drive with USB 3.0',129.99,60,'2024-08-22 01:29:40'),(9,'Printer','All-in-one color printer with scanning and copying',199.99,40,'2024-08-22 01:29:40'),(10,'Tablet','10-inch tablet with Wi-Fi and 64GB storage',349.99,70,'2024-08-22 01:29:40'),(11,'Smartwatch','Fitness smartwatch with heart rate monitor',199.99,90,'2024-08-22 01:29:40'),(12,'Bluetooth Speaker','Portable Bluetooth speaker with high sound quality',89.99,150,'2024-08-22 01:29:40'),(13,'Router','Dual-band Wi-Fi router with high-speed internet',129.99,50,'2024-08-22 01:29:40'),(14,'USB Flash Drive','32GB USB flash drive',19.99,300,'2024-08-22 01:29:40'),(15,'Portable Charger','Power bank with 10000mAh capacity',29.99,120,'2024-08-22 01:29:40'),(16,'VR Headset','Virtual reality headset with immersive experience',299.99,40,'2024-08-22 01:29:40'),(17,'Smart Home Hub','Central hub for smart home devices',149.99,35,'2024-08-22 01:29:40'),(18,'Charging Cable','USB-C charging cable',14.99,200,'2024-08-22 01:29:40'),(19,'Laptop Stand','Adjustable laptop stand for ergonomic positioning',39.99,75,'2024-08-22 01:29:40');
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-06 15:54:34
