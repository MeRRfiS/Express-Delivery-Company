-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: expressdeliverycompany
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `city`
--

DROP TABLE IF EXISTS `city`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `city` (
  `city_id` tinyint NOT NULL,
  `city_name` varchar(20) NOT NULL,
  PRIMARY KEY (`city_id`),
  UNIQUE KEY `city_name` (`city_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `city`
--

LOCK TABLES `city` WRITE;
/*!40000 ALTER TABLE `city` DISABLE KEYS */;
INSERT INTO `city` VALUES (4,'Дніпро'),(1,'Київ'),(3,'Львів'),(5,'Одеса'),(2,'Харків');
/*!40000 ALTER TABLE `city` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client_`
--

DROP TABLE IF EXISTS `client_`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client_` (
  `client_id` int NOT NULL AUTO_INCREMENT,
  `client_pasport` varchar(9) NOT NULL,
  `client_first_name` varchar(30) NOT NULL,
  `client_last_name` varchar(15) NOT NULL,
  `client_adress` varchar(100) NOT NULL,
  `client_tel` varchar(10) NOT NULL,
  PRIMARY KEY (`client_id`),
  UNIQUE KEY `client_pasport` (`client_pasport`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client_`
--

LOCK TABLES `client_` WRITE;
/*!40000 ALTER TABLE `client_` DISABLE KEYS */;
INSERT INTO `client_` VALUES (1,'МК 123456','Валентина Олексіївна','Іванченко','місто Львів, пров. Тараса Шевченка, 19','0633830224'),(2,'ЕК 327605','Діана Євгенівна','Кравченко','місто Дніпро, просп. Тараса Шевченка, 83','0997629823'),(3,'ПР 053253','Микита Борисович','Дмитренко','місто Київ, пл. Космонавта Попова, 48','0967325838'),(4,'ЛІ 204531','Володимир Євгенович','Дмитренко','місто Київ, просп. Пацаєва, 28','0509212280'),(5,'ГН 973107','Валерія Йосипівна','Шевченко','місто Одеса, вул. Генерала Жадова, 85','0967586666'),(6,'ПР 945634','Єгор Ігорович','Мухін','місто Харків, вул. Валентинівська, 26а','0996184264');
/*!40000 ALTER TABLE `client_` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department` (
  `department_id` tinyint NOT NULL AUTO_INCREMENT,
  `department_number` tinyint NOT NULL,
  `department_adress` varchar(100) NOT NULL,
  `department_city_id` tinyint NOT NULL,
  PRIMARY KEY (`department_id`),
  UNIQUE KEY `department_adress` (`department_adress`),
  KEY `department__ibfk_1_idx` (`department_city_id`),
  CONSTRAINT `department__ibfk_1` FOREIGN KEY (`department_city_id`) REFERENCES `city` (`city_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,12,'Вулиця Академіка Павлова, 134/16 A, 61000',2),(2,39,'Волгоградська пл, вулиця Мілютенка, 11A, 02156',1),(3,8,'Дніпровська набережна, 17ж, 02217',4),(4,12,'Проспект В\'ячеслава Чорновола, 16д, 79000',3),(5,24,'вулиця Ільфа та Петрова, 63/1, 65000',5);
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `employee_id` int NOT NULL AUTO_INCREMENT,
  `employee_department_id` tinyint NOT NULL,
  `employee_first_name` varchar(30) NOT NULL,
  `employee_last_name` varchar(30) NOT NULL,
  `employee_tel` varchar(10) NOT NULL,
  `employee_post_id` tinyint(1) NOT NULL,
  `employee_login` varchar(10) NOT NULL,
  `employee_password` varchar(6) NOT NULL,
  PRIMARY KEY (`employee_id`),
  UNIQUE KEY `employee_login` (`employee_login`),
  UNIQUE KEY `employee_password` (`employee_password`),
  KEY `employee_department_id` (`employee_department_id`),
  KEY `employee_post_id` (`employee_post_id`),
  CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`employee_department_id`) REFERENCES `department` (`department_id`),
  CONSTRAINT `employee_ibfk_2` FOREIGN KEY (`employee_post_id`) REFERENCES `post` (`post_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,1,'Ігор Ігорович','Ільїв','0998765432',4,'ІІ_1_AAAAA','qWeeRt'),(2,2,'Людмила Іванівна','Броварчук','0937264221',2,'ЛБ_2_AAAAB','yJ37YA'),(3,4,'Руслан Сергійович','Середа','0930108794',1,'РС_4_AAAAC','9rypTP'),(4,5,'Bіктор Борисович','Васильєв','0670227401',1,'ВВ_2_AAAAD','7TKUy9'),(5,3,'Валерія Анатоліївна','Крамарчук','0635150809',1,'ВК_3_AAAAE','X7CLVa'),(6,1,'Алла Йосипівна','Шевчук','0673882272',1,'АШ_1_AAAAF','mU3cYi'),(7,1,'Артур Йосипович','Таращук','0679412260',3,'АТ_3_AAAAH','HljlkF');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kind_delivery`
--

DROP TABLE IF EXISTS `kind_delivery`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kind_delivery` (
  `kind_delivery_id` tinyint(1) NOT NULL AUTO_INCREMENT,
  `kind_delivery_name` varchar(20) NOT NULL,
  PRIMARY KEY (`kind_delivery_id`),
  UNIQUE KEY `kind_delivery_name` (`kind_delivery_name`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kind_delivery`
--

LOCK TABLES `kind_delivery` WRITE;
/*!40000 ALTER TABLE `kind_delivery` DISABLE KEYS */;
INSERT INTO `kind_delivery` VALUES (2,'Експресс'),(1,'Звичайна'),(3,'Супер експресс');
/*!40000 ALTER TABLE `kind_delivery` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kind_package`
--

DROP TABLE IF EXISTS `kind_package`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kind_package` (
  `kind_package_id` tinyint NOT NULL AUTO_INCREMENT,
  `kind_package_name` varchar(30) NOT NULL,
  PRIMARY KEY (`kind_package_id`),
  UNIQUE KEY `kind_package_name` (`kind_package_name`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kind_package`
--

LOCK TABLES `kind_package` WRITE;
/*!40000 ALTER TABLE `kind_package` DISABLE KEYS */;
INSERT INTO `kind_package` VALUES (14,'Дерев’яний контейнер'),(1,'Звичайна'),(13,'Картон'),(5,'Коробка А1'),(6,'Коробка А2'),(7,'Коробка В1'),(8,'Коробка В2'),(9,'Коробка С1'),(10,'Коробка С2'),(11,'Коробка С3'),(12,'Піддон'),(4,'Палетування без піддону'),(2,'Сейф-пакет'),(3,'Ящик для автоскла');
/*!40000 ALTER TABLE `kind_package` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_`
--

DROP TABLE IF EXISTS `order_`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_` (
  `order_id` int NOT NULL AUTO_INCREMENT,
  `order_weight` float NOT NULL,
  `order_fragility` enum('Так','Ні') NOT NULL,
  `order_kind_package_id` tinyint NOT NULL,
  `order_date` date NOT NULL,
  `order_date_end` date NOT NULL,
  `order_fine` varchar(8) DEFAULT NULL,
  `order_date_receiving` date NOT NULL,
  `order_client_id` int DEFAULT NULL,
  `order_employee_id` int NOT NULL,
  `order_kind_delivery_id` tinyint(1) NOT NULL,
  `order_department_number` tinyint NOT NULL,
  `order_name_recipient` varchar(100) NOT NULL,
  `order_city_id` tinyint NOT NULL,
  `order_place` enum('У місті відправника','В Дорозі','У місті отримання','Отримано') NOT NULL,
  `order_price` varchar(9) NOT NULL,
  `order_return` enum('Так','Ні') NOT NULL,
  `order_tel_recipient` varchar(10) NOT NULL,
  `order_name_client` varchar(100) DEFAULT NULL,
  `order_tel_client` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`order_id`),
  KEY `order_kind_package_id` (`order_kind_package_id`),
  KEY `order_employee_id` (`order_employee_id`),
  KEY `order_kind_delivery_id` (`order_kind_delivery_id`),
  KEY `order__ibfk_2` (`order_client_id`),
  KEY `order_ibfk_5_idx` (`order_city_id`),
  CONSTRAINT `order__ibfk_1` FOREIGN KEY (`order_kind_package_id`) REFERENCES `kind_package` (`kind_package_id`),
  CONSTRAINT `order__ibfk_2` FOREIGN KEY (`order_client_id`) REFERENCES `client_` (`client_id`),
  CONSTRAINT `order__ibfk_3` FOREIGN KEY (`order_employee_id`) REFERENCES `employee` (`employee_id`),
  CONSTRAINT `order__ibfk_4` FOREIGN KEY (`order_kind_delivery_id`) REFERENCES `kind_delivery` (`kind_delivery_id`),
  CONSTRAINT `order_ibfk_5` FOREIGN KEY (`order_city_id`) REFERENCES `city` (`city_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_`
--

LOCK TABLES `order_` WRITE;
/*!40000 ALTER TABLE `order_` DISABLE KEYS */;
INSERT INTO `order_` VALUES (1,5.55,'Ні',1,'2021-03-28','2021-03-31',NULL,'2021-03-31',2,5,1,8,'Крамаренко Bсеволод Валентинович',4,'В Дорозі','40 грн','Ні','0994612954',NULL,NULL),(2,10,'Ні',8,'2021-03-01','2021-03-10',NULL,'2021-03-03',1,3,2,24,'Кирил Володимирович Середа',5,'Отримано','90 грн','Ні','0931911467',NULL,NULL),(3,5,'Так',1,'2021-02-01','2021-02-05',NULL,'2021-02-05',3,6,1,12,'Захарчук Софія Євгенівна',2,'Отримано','63 грн','Так','0932002171',NULL,NULL),(4,25,'Ні',14,'2021-03-28','2021-03-31',NULL,'2021-03-29',4,6,3,12,'Середа Микола Олексійович',3,'Отримано','125 грн','Так','0507333569',NULL,NULL),(5,2.35,'Так',3,'2021-03-01','2021-03-07',NULL,'2021-03-03',5,4,1,39,'Василенко Віталій Петрович',1,'Отримано','70 грн','Ні','0671991590',NULL,NULL),(6,2,'Ні',2,'2021-04-09','2021-04-14',NULL,'2021-04-11',6,5,2,12,'Валерія Йосипівна Шевченко',2,'У місті відправника','85 грн','Так','0967586666',NULL,NULL),(8,5,'Ні',1,'2021-05-03','2021-05-07','10 грн','2021-05-05',NULL,4,1,39,'asdfgh fghcvjmb',1,'У місті отримання','80 грн','Так','0987654321','qwert qerwythj','1234567890'),(9,2,'Ні',1,'2021-05-05','2021-05-08',NULL,'2021-05-08',NULL,3,1,39,'Егор Мухінf',1,'У місті отримання','40 грн','Ні','0996184264','Оксана Ахмедзянова','0990247140');
/*!40000 ALTER TABLE `order_` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `post`
--

DROP TABLE IF EXISTS `post`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `post` (
  `post_id` tinyint(1) NOT NULL AUTO_INCREMENT,
  `post_name` varchar(30) NOT NULL,
  PRIMARY KEY (`post_id`),
  UNIQUE KEY `post_name_UNIQUE` (`post_name`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `post`
--

LOCK TABLES `post` WRITE;
/*!40000 ALTER TABLE `post` DISABLE KEYS */;
INSERT INTO `post` VALUES (2,'Адміністратор відділення'),(4,'Директор компанії'),(3,'Директор областної філії'),(1,'Касир');
/*!40000 ALTER TABLE `post` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `receipt`
--

DROP TABLE IF EXISTS `receipt`;
/*!50001 DROP VIEW IF EXISTS `receipt`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `receipt` AS SELECT 
 1 AS `id`,
 1 AS `client_full_name`,
 1 AS `recipient_full_name`,
 1 AS `employeet_full_name`,
 1 AS `department_adress`,
 1 AS `date_get`,
 1 AS `date_receiving`,
 1 AS `date_storage`,
 1 AS `weight`,
 1 AS `kind_delivery`,
 1 AS `kind_package`,
 1 AS `fragility`,
 1 AS `return_doc`,
 1 AS `price`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `receipt`
--

/*!50001 DROP VIEW IF EXISTS `receipt`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `receipt` AS select `order_`.`order_id` AS `id`,ifnull((select concat(`client_`.`client_first_name`,' ',`client_`.`client_last_name`) from `client_` where (`client_`.`client_id` = `order_`.`order_client_id`)),`order_`.`order_name_client`) AS `client_full_name`,`order_`.`order_name_recipient` AS `recipient_full_name`,(select concat(`employee`.`employee_first_name`,' ',`employee`.`employee_last_name`) from `employee` where (`employee`.`employee_id` = `order_`.`order_employee_id`)) AS `employeet_full_name`,(select `department`.`department_adress` from `department` where ((`department`.`department_number` = `order_`.`order_department_number`) and (`department`.`department_city_id` = `order_`.`order_city_id`))) AS `department_adress`,`order_`.`order_date` AS `date_get`,`order_`.`order_date_receiving` AS `date_receiving`,`order_`.`order_date_end` AS `date_storage`,concat(`order_`.`order_weight`,' ','кг') AS `weight`,(select `kind_delivery`.`kind_delivery_name` from `kind_delivery` where (`kind_delivery`.`kind_delivery_id` = `order_`.`order_kind_delivery_id`)) AS `kind_delivery`,(select `kind_package`.`kind_package_name` from `kind_package` where (`kind_package`.`kind_package_id` = `order_`.`order_kind_package_id`)) AS `kind_package`,`order_`.`order_fragility` AS `fragility`,`order_`.`order_return` AS `return_doc`,`order_`.`order_price` AS `price` from `order_` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-08 11:43:11
