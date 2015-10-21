CREATE DATABASE  IF NOT EXISTS `pandid` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `pandid`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: pandid
-- ------------------------------------------------------
-- Server version	5.6.27-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `pipes`
--

DROP TABLE IF EXISTS `pipes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pipes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `norm` varchar(45) DEFAULT NULL,
  `inch` varchar(8) DEFAULT NULL,
  `dn` int(11) DEFAULT NULL,
  `outdia` double DEFAULT NULL,
  `wt` double DEFAULT NULL,
  `r` int(11) DEFAULT NULL,
  `intdia` double DEFAULT NULL,
  `absrough` double DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pipes`
--

LOCK TABLES `pipes` WRITE;
/*!40000 ALTER TABLE `pipes` DISABLE KEYS */;
INSERT INTO `pipes` VALUES (1,'C100','1/2',15,21.3,3.2,77,14.9,0.08),(2,'C100','3/4',20,26.9,3.2,80,20.5,0.08),(3,'C100','1',25,33.7,3.6,80,26.5,0.08),(4,'C100','1 1/4',32,42.4,2.6,77,37.2,0.08),(5,'C100S','1/2',15,21.3,3.2,77,14.9,0.04),(6,'C100S','3/4',20,26.9,3.2,80,20.5,0.04),(7,'C100S','1',25,33.7,3.6,80,26.5,0.04),(8,'C100S','1 1/4',32,42.4,2.6,77,37.2,0.04);
/*!40000 ALTER TABLE `pipes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-10-21 11:06:06
