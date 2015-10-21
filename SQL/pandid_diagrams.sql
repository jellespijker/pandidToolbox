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
-- Table structure for table `diagrams`
--

DROP TABLE IF EXISTS `diagrams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diagrams` (
  `id` int(11) NOT NULL,
  `name` varchar(256) DEFAULT NULL COMMENT 'The name of the diagram',
  `type` varchar(50) DEFAULT NULL COMMENT 'The type of the diagram',
  `useincalcsheet` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='P&ID toolbox all available diagrams';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagrams`
--

LOCK TABLES `diagrams` WRITE;
/*!40000 ALTER TABLE `diagrams` DISABLE KEYS */;
INSERT INTO `diagrams` VALUES (0,'acetylene and oxygen','gas',0),(1,'anti-heeling','water',1),(2,'ballast','water',1),(3,'bilge','water',1),(4,'black water','water',1),(5,'brine','slurry',0),(6,'electric cable pipes','none',0),(7,'cement','slurry',0),(8,'central heating','water',0),(9,'chilled water','water',0),(10,'CO2','gas',0),(11,'control air','gas',1),(12,'control air (fireflaps, SOS valves and remote operated valves)','gas',1),(13,'deaeration and sounding','gas',1),(14,'degassing','gas',1),(15,'diving installation','none',0),(16,'draught measuring','none',0),(17,'dredge pipelines','none',0),(18,'driptray and drains','sludge',0),(19,'exhaust gas','none',0);
/*!40000 ALTER TABLE `diagrams` ENABLE KEYS */;
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
