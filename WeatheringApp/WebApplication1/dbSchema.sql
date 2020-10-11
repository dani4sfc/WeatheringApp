-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.5.5-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para weatheringapp
CREATE DATABASE IF NOT EXISTS `weatheringapp` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_general_ci */;
USE `weatheringapp`;

-- Volcando estructura para tabla weatheringapp.logs
CREATE TABLE IF NOT EXISTS `logs` (
  `Id` int(11) NOT NULL,
  `Date` datetime NOT NULL,
  `LogMessage` varchar(150) COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- La exportación de datos fue deseleccionada.

-- Volcando estructura para tabla weatheringapp.users
CREATE TABLE IF NOT EXISTS `users` (
  `Id` int(11) NOT NULL,
  `Name` varchar(50) COLLATE latin1_general_ci NOT NULL DEFAULT '',
  `Surname` varchar(50) COLLATE latin1_general_ci NOT NULL DEFAULT '',
  `Address` varchar(50) COLLATE latin1_general_ci NOT NULL DEFAULT '',
  `Email` varchar(50) COLLATE latin1_general_ci NOT NULL DEFAULT '',
  `Password` varchar(50) COLLATE latin1_general_ci NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- La exportación de datos fue deseleccionada.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
