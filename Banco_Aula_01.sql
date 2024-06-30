-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.6.21 - MySQL Community Server (GPL)
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura do banco de dados para aula_01
CREATE DATABASE IF NOT EXISTS `aula_01` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `aula_01`;


-- Copiando estrutura para tabela aula_01.parcelas
CREATE TABLE IF NOT EXISTS `parcelas` (
  `cod_parcela` int(11) NOT NULL AUTO_INCREMENT,
  `parcela` int(11) DEFAULT NULL,
  `data_parcela` date DEFAULT NULL,
  `valor_parcela` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`cod_parcela`)
) ENGINE=InnoDB AUTO_INCREMENT=82 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela aula_01.parcelas: ~22 rows (aproximadamente)
DELETE FROM `parcelas`;
/*!40000 ALTER TABLE `parcelas` DISABLE KEYS */;
INSERT INTO `parcelas` (`cod_parcela`, `parcela`, `data_parcela`, `valor_parcela`) VALUES
	(37, 1, '1111-11-13', 0.00),
	(38, 0, '0001-01-01', 0.00),
	(39, 1, '1111-11-13', 0.00),
	(40, 1, '1111-11-13', 0.00),
	(41, 2, '1111-12-11', 0.00),
	(42, 0, '0001-01-01', 0.00),
	(43, 1, '2017-01-02', 1100.00),
	(44, 2, '2017-01-31', 1100.00),
	(45, 3, '2017-03-02', 1100.00),
	(46, 4, '2017-04-03', 1100.00),
	(69, 1, '2017-02-02', 300.00),
	(70, 2, '2017-03-06', 300.00),
	(71, 3, '2017-04-03', 300.00),
	(72, 4, '2017-05-03', 300.00),
	(73, 5, '2017-06-02', 300.00),
	(74, 1, '2017-03-27', 1133.33),
	(75, 2, '2017-04-24', 1133.33),
	(76, 3, '2017-05-24', 1133.33),
	(77, 1, '2017-03-01', 718.00),
	(78, 2, '2017-03-31', 718.00),
	(79, 3, '2017-05-01', 718.00),
	(80, 4, '2017-05-30', 718.00),
	(81, 5, '2017-06-29', 718.00);
/*!40000 ALTER TABLE `parcelas` ENABLE KEYS */;


-- Copiando estrutura para tabela aula_01.produto
CREATE TABLE IF NOT EXISTS `produto` (
  `cod_produto` int(11) NOT NULL AUTO_INCREMENT,
  `produto` varchar(50) DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`cod_produto`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela aula_01.produto: ~5 rows (aproximadamente)
DELETE FROM `produto`;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` (`cod_produto`, `produto`, `valor`) VALUES
	(1, 'carro', 15000.00),
	(2, 'Moto', 3500.00),
	(3, 'Bicicleta', 450.00),
	(4, 'Bicicleta', 450.00),
	(5, 'Cachorro', 54.00),
	(6, 'Gato', 65.23);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
