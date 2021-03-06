-- phpMyAdmin SQL Dump
-- version 4.5.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 01, 2017 at 12:33 AM
-- Server version: 5.7.9
-- PHP Version: 5.6.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tickedoffvet`
--

-- --------------------------------------------------------

--
-- Table structure for table `booking`
--

DROP TABLE IF EXISTS `booking`;
CREATE TABLE IF NOT EXISTS `booking` (
  `bookingID` int(11) NOT NULL,
  `petID` int(11) DEFAULT NULL,
  `staffID` int(11) DEFAULT NULL,
  `bookingDateTime` datetime DEFAULT NULL,
  `symptoms` text,
  `treatments` text,
  `notes` text,
  PRIMARY KEY (`bookingID`),
  KEY `petID` (`petID`),
  KEY `staffID` (`staffID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `booking`
--

INSERT INTO `booking` (`bookingID`, `petID`, `staffID`, `bookingDateTime`, `symptoms`, `treatments`, `notes`) VALUES
(1, 84, 5, '2012-09-29 13:30:00', 'hair loss', 'give a "good boy"', ''),
(2, 84, 2, '2011-03-26 15:45:00', 'excessive tiredness', 'meditation', 'See again in 2 months'),
(3, 97, 5, '2011-04-03 12:30:00', '', 'Routine vaccination', ''),
(4, 34, 5, '2011-05-09 12:00:00', 'fleas', 'drugs', 'See again in 6 months'),
(5, 49, 5, '2012-10-11 15:00:00', 'excessive thirstiness', 'hydrotherapy', 'See again in 2 weeks'),
(6, 80, 2, '2011-04-22 14:45:00', 'uncontrollable peeing', 'hydrotherapy', 'See again in 6 months'),
(7, 61, 3, '2012-05-10 12:15:00', '', 'Routine vaccination', 'See again in 1 month'),
(8, 75, 2, '2012-07-03 10:15:00', 'limping', 'meditation', 'See again in 4 weeks'),
(9, 88, 2, '2012-05-13 16:00:00', 'diarrhoea', 'give a "good boy"', 'See again in 2 weeks'),
(10, 21, 3, '2011-04-21 09:15:00', '', 'Routine vaccination', 'See again in 2 weeks'),
(11, 54, 3, '2011-11-28 13:30:00', 'vomiting', 'acupuncture', 'See again in 2 months'),
(12, 89, 3, '2011-12-16 11:45:00', '', 'Routine vaccination', ''),
(13, 82, 2, '2011-06-05 12:15:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(14, 48, 3, '2012-10-24 09:30:00', 'poor eyesight, inappropriate defecation', 'bandage application', ''),
(15, 81, 3, '2012-02-03 12:30:00', 'deafness', 'hypnotherapy', 'See again in 4 weeks'),
(16, 51, 5, '2012-08-26 13:00:00', 'poor eyesight', 'medicinal bath', 'See again in 3 months'),
(17, 95, 3, '2011-05-09 12:15:00', 'limping', 'tooth clean', 'See again in 12 months'),
(18, 56, 5, '2012-03-14 09:15:00', 'excessive tiredness', 'electric shock therapy', 'See again in 1 month'),
(19, 85, 3, '2012-03-18 16:00:00', '', 'Routine vaccination', 'See again in 3 months'),
(20, 57, 3, '2012-07-14 13:00:00', 'anxiety', 'non-invasive surgery', 'See again in 1 month'),
(21, 25, 2, '2011-01-13 11:15:00', '', 'Routine vaccination', 'See again in 12 months'),
(22, 85, 5, '2012-05-15 15:45:00', 'constipation, deafness', 'tooth clean', 'See again in 4 weeks'),
(23, 72, 3, '2011-10-15 11:30:00', '', 'Routine vaccination', 'See again in 12 months'),
(24, 95, 5, '2012-04-21 16:30:00', 'bottom scraping, deafness', 'massage', 'See again in 12 months'),
(25, 28, 5, '2012-05-13 13:00:00', '', 'Routine vaccination', 'See again in 3 months'),
(26, 49, 2, '2011-08-18 09:30:00', 'hair loss', 'a good corking', ''),
(27, 102, 5, '2012-04-30 17:00:00', 'other parasites', 'suture', 'See again in 3 months'),
(28, 110, 2, '2012-12-11 14:00:00', 'other parasites', 'electric shock therapy', 'See again in 12 months'),
(29, 9, 3, '2011-06-15 12:30:00', 'wheezing', 'stitches', ''),
(30, 70, 3, '2012-06-17 12:45:00', '', 'Routine vaccination', 'See again in 3 months'),
(31, 98, 5, '2012-10-29 09:00:00', '', 'Routine vaccination', ''),
(32, 58, 5, '2011-11-27 09:30:00', '', 'Routine vaccination', 'See again in 2 months'),
(33, 92, 5, '2011-02-18 12:00:00', 'obesity', 'hydrotherapy', ''),
(34, 26, 3, '2012-05-02 13:30:00', 'poor eyesight, joint stiffness', 'wallet massage', 'See again in 1 month'),
(35, 86, 2, '2011-12-24 09:15:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(36, 92, 5, '2012-12-26 14:45:00', 'sneezing', 'tooth clean', ''),
(37, 73, 3, '2012-04-19 09:30:00', '', 'Routine vaccination', ''),
(38, 85, 5, '2011-12-08 14:30:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(39, 106, 5, '2011-03-27 17:00:00', '', 'Routine vaccination', ''),
(40, 107, 5, '2012-10-23 10:15:00', '', 'Routine vaccination', ''),
(41, 88, 3, '2013-01-21 14:00:00', '', 'Routine vaccination', ''),
(42, 77, 2, '2012-04-23 10:15:00', '', 'Routine vaccination', ''),
(43, 105, 5, '2012-08-11 09:00:00', 'sneezing', 'meditation', 'See again in 3 months'),
(44, 98, 3, '2011-06-19 11:15:00', 'vomiting', 'give a "good boy"', 'See again in 12 months'),
(45, 106, 5, '2012-07-23 13:30:00', '', 'Routine vaccination', ''),
(46, 51, 3, '2011-06-07 11:15:00', 'poor eyesight', 'hypnotherapy', ''),
(47, 106, 3, '2011-11-06 10:00:00', '', 'Routine vaccination', 'See again in 2 weeks'),
(48, 52, 3, '2011-12-24 14:00:00', '', 'Routine vaccination', 'See again in 2 weeks'),
(49, 101, 2, '2011-09-21 15:45:00', 'poor eyesight, other parasites', 'invasive surgery', 'See again in 1 month'),
(50, 41, 2, '2012-07-01 13:00:00', 'obesity, constipation, fleas', 'medicinal bath', 'See again in 12 months'),
(51, 60, 2, '2012-09-03 16:00:00', '', 'Routine vaccination', ''),
(52, 88, 3, '2011-06-30 09:15:00', '', 'Routine vaccination', 'See again in 2 weeks'),
(53, 14, 3, '2012-08-25 12:45:00', 'limping, inappropriate defecation', 'invasive surgery', ''),
(54, 15, 5, '2011-11-25 14:30:00', 'vomiting, crying', 'invasive surgery', 'See again in 4 weeks'),
(55, 86, 5, '2012-08-01 12:30:00', '', 'Routine vaccination', ''),
(56, 19, 5, '2012-01-12 10:30:00', '', 'Routine vaccination', 'See again in 1 month'),
(57, 2, 2, '2011-04-02 14:15:00', 'sore paw', 'give a "good boy"', ''),
(58, 69, 2, '2011-12-18 14:45:00', 'diarrhoea', 'emetic procedure', 'See again in 1 month'),
(59, 77, 2, '2011-02-18 16:30:00', '', 'Routine vaccination', 'See again in 6 months'),
(60, 23, 2, '2012-04-05 13:00:00', '', 'Routine vaccination', 'See again in 3 months'),
(61, 53, 3, '2011-01-06 14:15:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(62, 77, 3, '2012-05-12 11:30:00', 'anxiety', 'tooth extraction', 'See again in 4 weeks'),
(63, 58, 5, '2012-02-20 09:30:00', 'excessive thirstiness, constipation', 'suture', ''),
(64, 3, 3, '2012-12-30 10:45:00', 'flatulence', 'electric shock therapy', 'See again in 4 weeks'),
(65, 32, 2, '2012-04-09 17:00:00', 'obesity', 'cuddles', 'See again in 3 months'),
(66, 43, 2, '2012-11-30 13:15:00', '', 'Routine vaccination', ''),
(67, 16, 2, '2011-09-03 12:00:00', 'limping', 'cuddles', 'See again in 3 months'),
(68, 73, 5, '2011-04-25 13:00:00', '', 'Routine vaccination', ''),
(69, 104, 3, '2012-10-30 10:30:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(70, 72, 5, '2012-11-16 13:00:00', 'crying', 'meditation', 'See again in 6 months'),
(71, 81, 5, '2012-06-26 13:00:00', '', 'Routine vaccination', ''),
(72, 7, 2, '2012-06-26 13:00:00', '', 'Routine vaccination', ''),
(73, 75, 5, '2012-11-29 10:15:00', '', 'Routine vaccination', 'See again in 3 months'),
(74, 68, 2, '2011-05-28 12:45:00', '', 'Routine vaccination', 'See again in 2 weeks'),
(75, 78, 3, '2012-03-03 11:45:00', 'joint stiffness', 'cuddles', 'See again in 12 months'),
(76, 1, 5, '2012-10-01 11:30:00', 'crying', 'a good corking', 'See again in 1 month'),
(77, 7, 5, '2011-06-09 13:30:00', '', 'Routine vaccination', 'See again in 1 month'),
(78, 13, 2, '2011-09-02 14:15:00', 'diarrhoea, anxiety', 'give a "good boy"', 'See again in 2 months'),
(79, 110, 5, '2011-08-28 16:15:00', 'limping', 'psychotherapy', 'See again in 12 months'),
(80, 60, 5, '2012-08-19 10:00:00', '', 'Routine vaccination', 'See again in 1 month'),
(81, 2, 3, '2012-05-28 09:30:00', '', 'Routine vaccination', 'See again in 1 month'),
(82, 105, 3, '2011-08-25 15:15:00', '', 'Routine vaccination', 'See again in 2 weeks'),
(83, 38, 2, '2011-01-28 14:30:00', 'sore paw', 'saw pore', ''),
(84, 58, 2, '2012-01-28 14:45:00', '', 'Routine vaccination', ''),
(85, 104, 3, '2012-09-11 12:45:00', '', 'Routine vaccination', 'See again in 3 months'),
(86, 49, 3, '2012-03-08 16:45:00', '', 'Routine vaccination', 'See again in 3 months'),
(87, 41, 2, '2012-07-23 14:30:00', 'obesity, inappropriate defecation', 'suture', ''),
(88, 107, 3, '2012-01-30 14:30:00', 'sneezing', 'massage', 'See again in 6 months'),
(89, 52, 5, '2012-02-01 09:45:00', 'hair loss, ticks', 'emetic procedure', ''),
(90, 24, 2, '2011-06-25 11:30:00', '', 'Routine vaccination', ''),
(91, 78, 3, '2012-05-30 15:45:00', 'other parasites', 'electric shock therapy', ''),
(92, 33, 3, '2012-05-27 11:45:00', 'sore paw, crying', 'acupuncture', ''),
(93, 55, 3, '2011-10-21 16:30:00', 'obesity', 'massage', ''),
(94, 97, 3, '2012-09-29 12:45:00', 'anxiety', 'tooth extraction', 'See again in 1 month'),
(95, 17, 2, '2012-09-09 16:00:00', 'constipation, flatulence', 'tooth extraction', 'See again in 4 weeks'),
(96, 14, 5, '2011-11-22 12:15:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(97, 87, 2, '2011-12-20 17:00:00', 'limping', 'suture', ''),
(98, 107, 3, '2011-03-15 12:00:00', 'deafness', 'tooth extraction', 'See again in 12 months'),
(99, 83, 5, '2011-04-30 12:00:00', '', 'Routine vaccination', ''),
(100, 21, 3, '2012-05-16 14:15:00', '', 'Routine vaccination', ''),
(101, 98, 5, '2012-03-03 11:30:00', '', 'Routine vaccination', ''),
(102, 52, 5, '2011-07-04 17:00:00', 'crying', 'non-invasive surgery', ''),
(103, 26, 5, '2012-05-24 16:45:00', '', 'Routine vaccination', ''),
(104, 89, 3, '2013-01-16 16:00:00', '', 'Routine vaccination', 'See again in 6 months'),
(105, 60, 2, '2011-11-29 12:45:00', 'fleas', 'suture', ''),
(106, 91, 2, '2011-08-21 10:15:00', '', 'Routine vaccination', 'See again in 6 months'),
(107, 39, 2, '2012-10-05 12:45:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(108, 26, 5, '2011-04-08 12:45:00', 'vomiting, other parasites', 'bandage application', 'See again in 6 months'),
(109, 73, 3, '2011-01-16 15:15:00', 'other parasites', 'psychotherapy', 'See again in 4 weeks'),
(110, 30, 2, '2012-08-09 09:30:00', '', 'Routine vaccination', ''),
(111, 108, 3, '2011-09-18 17:00:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(112, 105, 2, '2011-05-22 09:30:00', '', 'Routine vaccination', 'See again in 2 weeks'),
(113, 13, 3, '2012-12-10 16:00:00', '', 'Routine vaccination', 'See again in 2 months'),
(114, 29, 5, '2011-07-28 11:15:00', '', 'Routine vaccination', ''),
(115, 17, 5, '2011-06-13 09:00:00', '', 'Routine vaccination', 'See again in 2 weeks'),
(116, 23, 2, '2012-01-29 11:00:00', 'anxiety', 'invasive surgery', 'See again in 4 weeks'),
(117, 91, 5, '2012-06-25 13:30:00', 'joint stiffness', 'tooth clean', ''),
(118, 110, 2, '2012-02-11 13:00:00', 'constipation', 'stitches', 'See again in 12 months'),
(119, 48, 2, '2012-04-14 10:45:00', 'hair loss', 'tooth clean', ''),
(120, 28, 3, '2011-02-12 12:15:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(121, 56, 2, '2011-11-12 15:00:00', '', 'Routine vaccination', ''),
(122, 65, 3, '2012-08-30 15:30:00', '', 'Routine vaccination', 'See again in 12 months'),
(123, 103, 2, '2011-09-01 11:30:00', '', 'Routine vaccination', ''),
(124, 65, 5, '2011-04-10 09:45:00', '', 'Routine vaccination', ''),
(125, 61, 5, '2012-07-03 15:30:00', '', 'Routine vaccination', ''),
(126, 62, 3, '2011-07-18 10:15:00', 'excessive thirstiness', 'stitches', ''),
(127, 36, 2, '2011-02-22 14:00:00', 'sore paw, sneezing', 'invasive surgery', 'See again in 12 months'),
(128, 41, 2, '2012-03-03 15:45:00', 'constipation', 'electric shock therapy', ''),
(129, 9, 3, '2013-01-24 11:15:00', 'fleas', 'psychotherapy', 'See again in 2 weeks'),
(130, 107, 2, '2011-02-20 11:00:00', '', 'Routine vaccination', 'See again in 3 months'),
(131, 8, 2, '2011-08-04 16:45:00', 'joint stiffness', 'non-invasive surgery', 'See again in 1 month'),
(132, 3, 3, '2011-12-23 10:30:00', '', 'Routine vaccination', ''),
(133, 69, 3, '2012-04-14 12:30:00', '', 'Routine vaccination', 'See again in 2 months'),
(134, 94, 3, '2012-10-12 13:45:00', '', 'Routine vaccination', 'See again in 2 weeks'),
(135, 26, 3, '2011-10-24 09:15:00', '', 'Routine vaccination', ''),
(136, 19, 2, '2012-08-29 11:30:00', 'joint stiffness', 'give a "good boy"', 'See again in 2 weeks'),
(137, 39, 3, '2012-08-14 09:45:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(138, 86, 5, '2012-04-27 14:45:00', '', 'Routine vaccination', 'See again in 6 months'),
(139, 53, 3, '2011-08-28 12:30:00', '', 'Routine vaccination', ''),
(140, 47, 3, '2012-10-20 16:15:00', 'excessive thirstiness', 'acupuncture', 'See again in 3 months'),
(141, 47, 2, '2012-08-31 12:45:00', '', 'Routine vaccination', ''),
(142, 67, 5, '2011-10-21 14:45:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(143, 61, 5, '2012-02-29 12:45:00', 'inappropriate defecation', 'a good corking', ''),
(144, 28, 2, '2012-03-29 11:15:00', 'fleas', 'acupuncture', 'See again in 1 month'),
(145, 2, 3, '2012-04-19 15:00:00', 'excessive tiredness', 'hydrotherapy', ''),
(146, 81, 2, '2011-08-31 16:15:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(147, 26, 5, '2013-01-16 11:45:00', '', 'Routine vaccination', ''),
(148, 58, 2, '2012-05-04 09:00:00', '', 'Routine vaccination', ''),
(149, 69, 5, '2011-05-27 12:00:00', '', 'Routine vaccination', ''),
(150, 25, 3, '2012-01-31 14:15:00', 'anxiety, sneezing', 'wallet massage', 'See again in 2 weeks'),
(151, 35, 3, '2012-05-17 09:15:00', 'other parasites', 'hydrotherapy', ''),
(152, 67, 5, '2011-03-31 14:15:00', 'wheezing, fleas', 'hydrotherapy', ''),
(153, 94, 3, '2012-11-18 16:30:00', 'deafness', 'a good corking', ''),
(154, 10, 3, '2012-06-07 15:00:00', 'excessive thirstiness, fleas', 'non-invasive surgery', ''),
(155, 41, 5, '2013-01-29 13:15:00', 'sneezing', 'bandage application', 'See again in 12 months'),
(156, 67, 2, '2011-12-14 14:15:00', 'bottom scraping', 'medicinal bath', 'See again in 3 months'),
(157, 6, 2, '2011-10-28 10:00:00', '', 'Routine vaccination', 'See again in 1 month'),
(158, 53, 5, '2012-11-17 09:15:00', '', 'Routine vaccination', ''),
(159, 16, 2, '2012-05-18 13:45:00', 'anxiety', 'enema', ''),
(160, 58, 3, '2013-01-08 09:30:00', 'bottom scraping', 'meditation', ''),
(161, 15, 5, '2012-11-30 13:00:00', '', 'Routine vaccination', 'See again in 6 months'),
(162, 70, 3, '2012-04-08 15:15:00', '', 'Routine vaccination', ''),
(163, 89, 5, '2012-04-26 15:30:00', '', 'Routine vaccination', ''),
(164, 12, 3, '2012-12-28 13:45:00', 'sneezing', 'cuddles', ''),
(165, 10, 2, '2012-05-23 11:45:00', '', 'Routine vaccination', 'See again in 6 months'),
(166, 110, 3, '2011-09-08 13:00:00', 'diarrhoea', 'non-invasive surgery', 'See again in 3 months'),
(167, 85, 2, '2012-05-06 09:15:00', 'poor eyesight', 'hypnotherapy', 'See again in 4 weeks'),
(168, 70, 2, '2012-07-23 16:45:00', '', 'Routine vaccination', 'See again in 12 months'),
(169, 83, 2, '2012-05-30 16:45:00', '', 'Routine vaccination', 'See again in 2 weeks'),
(170, 41, 2, '2012-10-11 09:00:00', 'sneezing', 'hydrotherapy', 'See again in 2 months'),
(171, 41, 2, '2012-08-26 15:15:00', 'diarrhoea, joint stiffness', 'electric shock therapy', 'See again in 3 months'),
(172, 30, 5, '2011-03-27 15:15:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(173, 91, 3, '2012-05-26 09:15:00', '', 'Routine vaccination', 'See again in 12 months'),
(174, 66, 5, '2011-08-18 09:00:00', 'excessive thirstiness, uncontrollable peeing, flatulence', 'massage', ''),
(175, 27, 5, '2011-08-05 11:15:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(176, 96, 3, '2011-09-08 12:00:00', '', 'Routine vaccination', 'See again in 2 months'),
(177, 107, 2, '2012-05-12 13:15:00', 'deafness', 'stitches', ''),
(178, 27, 2, '2011-09-25 11:30:00', 'joint stiffness', 'stitches', 'See again in 3 months'),
(179, 36, 3, '2012-05-22 10:00:00', 'limping', 'hydrotherapy', 'See again in 4 weeks'),
(180, 9, 2, '2013-01-23 14:00:00', '', 'Routine vaccination', ''),
(181, 94, 3, '2011-09-12 16:30:00', '', 'Routine vaccination', 'See again in 2 months'),
(182, 67, 3, '2011-06-06 14:30:00', 'deafness', 'hydrotherapy', 'See again in 1 month'),
(183, 91, 5, '2011-01-19 13:00:00', 'uncontrollable peeing', 'cuddles', ''),
(184, 9, 2, '2012-01-25 13:30:00', '', 'Routine vaccination', ''),
(185, 3, 3, '2011-03-24 12:30:00', '', 'Routine vaccination', ''),
(186, 31, 5, '2012-04-23 10:30:00', '', 'Routine vaccination', ''),
(187, 97, 5, '2011-05-24 13:00:00', '', 'Routine vaccination', ''),
(188, 98, 2, '2011-02-21 12:45:00', '', 'Routine vaccination', ''),
(189, 95, 5, '2012-11-11 09:00:00', '', 'Routine vaccination', ''),
(190, 71, 5, '2012-10-15 11:30:00', '', 'Routine vaccination', ''),
(191, 74, 2, '2012-02-28 12:45:00', 'vomiting', 'drugs', ''),
(192, 16, 5, '2011-01-30 13:00:00', 'flatulence', 'cuddles', 'See again in 2 months'),
(193, 88, 5, '2012-08-01 14:00:00', '', 'Routine vaccination', 'See again in 4 weeks'),
(194, 86, 5, '2011-06-18 12:15:00', '', 'Routine vaccination', ''),
(195, 22, 3, '2011-05-18 14:00:00', '', 'Routine vaccination', ''),
(196, 20, 3, '2011-11-07 10:30:00', '', 'Routine vaccination', ''),
(197, 78, 2, '2011-10-18 10:15:00', '', 'Routine vaccination', ''),
(198, 10, 2, '2012-10-09 13:15:00', '', 'Routine vaccination', ''),
(199, 89, 3, '2012-07-04 16:00:00', 'hair loss', 'invasive surgery', '');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
CREATE TABLE IF NOT EXISTS `customer` (
  `customerID` int(11) NOT NULL,
  `title` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `firstName` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `lastName` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `gender` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `email` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `phone1` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `phone2` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `street1` varchar(150) CHARACTER SET utf8 DEFAULT NULL,
  `street2` varchar(150) CHARACTER SET utf8 DEFAULT NULL,
  `suburb` varchar(80) CHARACTER SET utf8 DEFAULT NULL,
  `state` varchar(3) CHARACTER SET utf8 DEFAULT NULL,
  `postcode` varchar(4) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`customerID`),
  KEY `state` (`state`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`customerID`, `title`, `firstName`, `lastName`, `gender`, `DOB`, `email`, `phone1`, `phone2`, `street1`, `street2`, `suburb`, `state`, `postcode`) VALUES
(1, 'Ms', 'Cara', 'Rojas', 'F', '1977-08-26', 'crojas375@tpg.com.au', '(02) 4778 5452', '0424 677 626', '', '181 ONEY CIRCLE ', 'YELLOW ROCK', 'NSW', '2527'),
(2, 'Sir', 'Isiah', 'Duke', 'M', '1954-06-27', 'isiah.duke@optusnet.com.au', '(02) 4239 9759', '0416 858 673', '', '118 CAMEO COURT ', 'DONALD CREEK', 'NSW', '2350'),
(3, 'Miss', 'Queen', 'Howe', 'F', '1985-03-18', 'queen.howe@tpg.com.au', '(02) 4779 1377', '0432 168 361', '', '25 MULDROW STREET ', 'MILVALE', 'NSW', '2594'),
(4, 'Ms', 'Gale', 'Newman', 'F', '1965-09-12', 'gale.newman@gmail.com', '(02) 4545 2446', '0427 624 396', '', '51 PLATINUM CIRCLE ', 'DULGUIGAN', 'NSW', '2484'),
(5, 'Mrs', 'Martha', 'Woodard', 'F', '1953-03-20', 'martha.woodard@iinet.com.au', '(02) 4285 2551', '0421 784 818', '', '174 TIMBERWOLF CIRCLE ', 'ENFIELD SOUTH', 'NSW', '2133'),
(6, 'Mr', 'Rick', 'Prince', 'M', '1990-07-11', 'r.prince@hotmail.com', '(02) 4582 6459', '0434 525 675', '', '26/198 GOLDEN HILLS LANE ', 'PAMBULA BEACH', 'NSW', '2549'),
(7, 'Mr', 'Mack', 'Carson', 'M', '1967-09-26', 'mack@yahoo.com.au', '(02) 4382 2455', '0418 296 447', '', '141 ALDREN CIRCLE ', 'BROULEE', 'NSW', '2537'),
(8, 'Mr', 'Willie', 'Burnett', 'M', '1941-07-07', 'pryo_tick_killer@gmail.com', '(02) 4379 3727', '0415 157 696', '', '122 MARINO DRIVE ', 'BLAIR ATHOL', 'NSW', '2560'),
(9, 'Mr', 'Isidro', 'Williams', 'M', '1987-11-03', 'iwilliams72@hotmail.com', '(02) 4345 9845', '0403 675 211', '', '60 KRONOS DRIVE ', 'DRAKE VILLAGE', 'NSW', '2469'),
(10, 'Mr', 'Leonard', 'Bernard', 'M', '1935-06-28', 'l.bernard@gmail.com', '(02) 4253 4363', '0427 436 435', '', '124 CARAVELLE DRIVE ', 'EAST GRESFORD', 'NSW', '2311'),
(11, 'Miss', 'Marianne', 'Cannon', 'F', '1987-02-09', 'm.cannon@bigpond.com', '(02) 4727 2575', '0414 762 792', '', '14 LIMESTONE CIRCLE ', 'ERINA', 'NSW', '2250'),
(12, 'Mr', 'Cory', 'Horn', 'M', '1957-11-10', 'c.horn@bigpond.com', '(02) 4962 5235', '0425 211 128', '', '9/142 HELEN DRIVE ', 'MOGENDOURA', 'NSW', '2537'),
(13, 'Miss', 'Maricela', 'Floyd', 'F', '1937-12-08', 'maricela@bigpond.com', '(02) 4284 9532', '0416 435 744', 'Unit 8 Level 1', '125 OLD BIRCHWOOD LOOP ROAD ', 'KOOTINGAL', 'NSW', '2352'),
(14, 'Dr', 'Josue', 'Potter', 'M', '1945-01-20', 'jpotter151@mirkwoodproductions.com.au', '(02) 4348 6658', '0423 623 244', 'Unit 8 Level 3', '14 PARKSIDE DRIVE ', 'GUNDAROO', 'NSW', '2620'),
(15, 'Ms', 'Ellen', 'Grant', 'F', '1974-04-06', 'egrant146@hotmail.com', '(02) 4614 3278', '0425 632 382', '', '12/191 REVILLA CIRCLE ', 'VALLA BEACH', 'NSW', '2448'),
(16, 'Mr', 'Salvatore', 'Pitts', 'M', '1960-07-25', 's.pitts@bigpond.net.au', '(02) 4174 4745', '0428 464 261', 'Unit 16 Level 1', '157 AVION STREET ', 'ILARWILL', 'NSW', '2463'),
(17, 'Ms', 'Carmella', 'Brady', 'F', '1946-07-04', 'carmella@hotmail.com', '(02) 4677 1948', '0412 246 842', '', '28/176 WHISPERING SPRUCE CIRCLE ', 'MUNDONGO', 'NSW', '2720'),
(18, 'Mr', 'Hiram', 'Tanner', 'M', '1982-03-30', 'hiram.tanner@iinet.com.au', '(02) 4676 2444', '0418 127 993', '', '24 MEYER STREET ', 'BODALLA', 'NSW', '2545'),
(19, 'Mr', 'Marco', 'Burke', 'M', '1950-02-26', 'marco.burke@iinet.com.au', '(02) 4558 5587', '0417 227 826', '', '128 BIRCHWOOD SPUR ROAD ', 'TYALGUM', 'NSW', '2484'),
(20, 'Mr', 'Adolfo', 'Gonzales', 'M', '1967-11-12', 'adolfo.gonzales@hotmail.com', '(02) 4617 2812', '0403 682 237', '', '10 HIGHLAND STREET ', 'ETTRICK', 'NSW', '2474'),
(21, 'Mrs', 'Vanessa', 'Jacobs', 'F', '1941-12-04', 'vanessa.jacobs@hotmail.com', '(02) 4388 8786', '0428 377 178', '', '170 KAHILTNA DRIVE ', 'LONG POINT', 'NSW', '2564'),
(22, 'Ms', 'Henrietta', 'Brown', 'F', '1958-01-22', 'hbrown192@tpg.com.au', '(02) 4313 5228', '0434 684 748', '', '89 ROSALIND LOOP ', 'BLACKTOWN WESTPOINT', 'NSW', '2148'),
(23, 'Mr', 'Johnathan', 'Ballard', 'M', '1971-05-21', 'johnathan.ballard@gmail.com', '(02) 4968 1825', '0418 926 372', 'Unit 3 Level 3', '148 HIALEAH DRIVE ', 'EASTWOOD', 'NSW', '2122'),
(24, 'Ms', 'Dollie', 'Austin', 'F', '1956-10-02', 'daustin471@optusnet.com.au', '(02) 4817 6738', '0428 898 385', '', '101 TOPHAND TRAILER COURT ', 'GWYNNEVILLE', 'NSW', '2500'),
(25, 'Dr', 'Roger', 'Mercer', 'M', '1980-09-27', 'roger@gmail.com', '(02) 4419 7515', '0422 727 842', '', '117 BYERS LANE ', 'ISABELLA PLAINS', 'NSW', '2905'),
(26, 'Mr', 'Antwan', 'Griffith', 'M', '1977-07-20', 'antwan.griffith@iinet.com.au', '(02) 4768 8366', '0431 857 258', '', '24 MOUNTAIN ROAD ', 'TARALGA', 'NSW', '2580'),
(27, 'Ms', 'Susanne', 'Banks', 'F', '1970-12-07', 's.banks@hotmail.com', '(02) 4212 7193', '0414 371 863', '', '103 WATERFRONT LANE ', 'LINDENDALE', 'NSW', '2480'),
(28, 'Mr', 'Alvaro', 'Gilbert', 'M', '1974-11-27', 'a.gilbert@bigpond.com', '(02) 4753 7226', '0416 459 566', '', '173 NEW LONDON COURT ', 'BOWEN MOUNTAIN', 'NSW', '2753'),
(29, 'Ms', 'Georgette', 'Mcdaniel', 'F', '1950-04-04', 'gmcdaniel97@bigpond.com', '(02) 4573 9265', '0402 723 437', '', '146 SAINT JAMES STREET ', 'PEMULWUY', 'NSW', '2145'),
(30, 'Ms', 'Alyson', 'Mcfadden', 'F', '1992-03-14', 'alyson.mcfadden@gmail.com', '(02) 4688 2332', '0428 752 252', '', '90 MYRTLE DRIVE ', 'QUANDIALLA', 'NSW', '2721'),
(31, 'Mr', 'Devin', 'Reese', 'M', '1992-06-14', 'devin.reese@gmail.com', '(02) 4457 3637', '0405 132 526', '', '99 SHIVALIK DRIVE ', 'COURABYRA', 'NSW', '2653'),
(32, 'Mr', 'Phil', 'Guerra', 'M', '1960-12-08', 'p.guerra@bigpond.net.au', '(02) 4557 3267', '0415 897 433', '', '80 BLUEGRASS CIRCLE ', 'DUNMORE', 'NSW', '2529'),
(33, 'Mr', 'Angelo', 'Kelly', 'M', '1982-05-13', 'a.kelly@gmail.com', '(02) 4253 4263', '0427 436 435', '', '164 BLACK BEAR CIRCLE ', 'ROYAL EXCHANGE', 'NSW', '1225'),
(34, 'Ms', 'Lola', 'Trevino', 'F', '1972-01-10', 'lola@bigpond.net.au', '(02) 4383 8368', '0426 587 382', '', '12/182 ESSEX PARK DRIVE ', 'CAMBEWARRA', 'NSW', '2540'),
(35, 'Mr', 'Travis', 'Mcgee', 'M', '1952-09-03', 'travis@bigpond.net.au', '(02) 4474 9381', '0415 498 889', '', '184 SHELTIE AVENUE ', 'SCHEYVILLE', 'NSW', '2756'),
(36, 'Mrs', 'Abigail', 'Lowery', 'F', '1971-03-27', 'alowery499@gmail.com', '(02) 4184 8532', '0433 293 422', '', '33 EGLOFF DRIVE ', 'OATLANDS', 'NSW', '2117'),
(37, 'Miss', 'Goldie', 'Flores', 'F', '1962-11-19', 'goldie.flores@bigpond.com', '(02) 4178 4218', '0413 625 668', '', '83 MILE HI WAY ', 'MASCOT', 'NSW', '1460'),
(38, 'Miss', 'Erin', 'Beasley', 'F', '1957-11-02', 'erin@bigpond.com', '(02) 4714 7217', '0416 666 434', '', '10/134 SOUTH AIRPARK DRIVE ', 'BURRA', 'NSW', '2620'),
(39, 'Ms', 'Natalie', 'Fields', 'F', '1963-05-21', 'n.fields@gmail.com', '(02) 4932 7558', '0415 794 642', '', '31 BRUDNE ROAD ', 'ALLAWAH', 'NSW', '2218'),
(40, 'Ms', 'Peggy', 'Bennett', 'F', '1956-10-07', 'p.bennett@hotmail.com', '(02) 4484 6587', '0416 298 257', '', '103 ANTLER LANE ', 'ROYAL EXCHANGE', 'NSW', '1225'),
(41, 'Mr', 'Alphonse', 'Griffin', 'M', '1960-09-26', 'a.griffin@tyasa.com.au', '(02) 4945 6492', '0412 378 957', '', '6/5 LAKE GEORGE DRIVE ', 'MONA VALE', 'NSW', '1660'),
(42, 'Miss', 'Phyllis', 'Spencer', 'F', '1981-08-05', 'phyllis.spencer@hotmail.com', '(02) 4641 2512', '0413 937 734', '', '88 DONALD PLACE ', 'BELIMBLA PARK', 'NSW', '2570'),
(43, 'Miss', 'Beth', 'Keith', 'F', '1983-12-28', 'b.keith@yahoo.com.au', '(02) 4932 5253', '0415 571 455', '', '192 DANE COURT ', 'WOOLI', 'NSW', '2462'),
(44, 'Mrs', 'Traci', 'Haynes', 'F', '1941-04-25', 'traci.haynes@hotmail.com', '(02) 4129 6555', '0423 458 446', '', '16 PATRICIA LANE ', 'BANKSTOWN SQUARE', 'NSW', '2200'),
(45, 'Mr', 'Darrin', 'Cannon', 'M', '1942-02-19', 'dcannon307@optusnet.com.au', '(02) 4476 4785', '0423 389 372', '', '189 BARROW STREET ', 'INGLEBURN', 'NSW', '2565'),
(46, 'Ms', 'Melinda', 'Snow', 'F', '1945-06-12', 'melinda@hotmail.com', '(02) 4447 5677', '0433 377 849', '', '111 WHITEHALL ROAD ', 'TWEED HEADS WEST', 'NSW', '2485'),
(47, 'Mrs', 'Ophelia', 'Wilkins', 'F', '1957-06-11', 'owilkins269@iinet.com.au', '(02) 4554 5323', '0424 144 547', '', '54 SPECKING AVENUE ', 'GROGAN', 'NSW', '2666'),
(48, 'Mr', 'Willie', 'Nukeit', 'M', '1959-09-06', '15_seconds_on_high@gmail.com', '(02) 4468 5531', '0429 352 523', '', '13/42 SKY CIRCLE ', 'RAYMOND TERRACE EAST', 'NSW', '2324'),
(49, 'Mrs', 'Dorthy', 'Harrington', 'F', '1972-08-31', 'd.harrington@bigpond.net.au', '(02) 4734 3568', '0413 566 257', '', '107 STANLEY DRIVE ', 'CROWTHER', 'NSW', '2803'),
(50, 'Mr', 'Dewayne', 'Mccormick', 'M', '1979-10-14', 'dewayne@bigpond.com', '(02) 4128 6846', '0429 128 465', '', '88 CAMPBELL AIRSTRIP ROAD ', 'WEST CHATSWOOD', 'NSW', '1515'),
(51, 'Mr', 'Ronny', 'Lancaster', 'M', '1974-09-28', 'r.lancaster@bigpond.com', '(02) 4482 8625', '0424 931 262', '', '172 CALAMITY COURT ', 'MONGARLOWE', 'NSW', '2622'),
(52, 'Mr', 'Glen', 'Cameron', 'M', '1963-10-31', 'gcameron341@hotmail.com', '(02) 4682 5867', '0412 774 781', '', '191 SPRUCE RUN CIRCLE ', 'WALLABI POINT', 'NSW', '2430'),
(53, 'Ms', 'Cristina', 'Vance', 'F', '1956-07-20', 'cristina@gmail.com', '(02) 4349 3356', '0425 932 855', '', '199 KATRINA CIRCLE ', 'MIRRABOOKA', 'NSW', '2264'),
(54, 'Miss', 'Tasha', 'Hancock', 'F', '1944-08-21', 'thancock215@hotmail.com', '(02) 4492 4838', '0416 278 728', '', '103 PORTAGE DRIVE ', 'PALMDALE', 'NSW', '2258'),
(55, 'Mr', 'Willie', 'Baggitt', 'M', '1978-08-22', 'listen_for_the_pop@gmail.com', '(02) 4234 8734', '0432 564 188', '', '104 KITZBUHEL ROAD ', 'RAPPVILLE', 'NSW', '2469'),
(56, 'Mrs', 'Patricia', 'Bean', 'F', '1942-09-29', 'patricia.bean@mirkwoodproductions.com.au', '(02) 4728 9738', '0414 183 182', '', '176 CAMELOT DRIVE ', 'SMITHS CREEK', 'NSW', '2474'),
(57, 'Mr', 'Normand', 'Mcmahon', 'M', '1948-11-10', 'normand.mcmahon@hotmail.com', '(02) 4847 4724', '0402 943 746', 'Unit 12 Level 1', '143 GREATLAND DRIVE ', 'CENTRAL MANGROVE', 'NSW', '2250'),
(58, 'Ms', 'Clarice', 'Riddle', 'F', '1982-09-25', 'clarice.riddle@gmail.com', '(02) 4838 5745', '0432 854 445', '', '4 WOODSTOCK CIRCLE ', 'SPLITTERS CREEK', 'NSW', '2640'),
(59, 'Mr', 'Scott', 'Watkins', 'M', '1948-01-26', 's.watkins@yahoo.com.au', '(02) 4675 1628', '0425 976 817', '', '163 GALLOWAY LOOP ', 'SOUTHGATE', 'NSW', '2460'),
(60, 'Prof', 'Sonja', 'Carr', 'F', '1949-11-23', 'sonja.carr@hotmail.com', '(02) 4464 5976', '0428 837 333', '', '10 TIDEVIEW DRIVE ', 'OLD GUILDFORD', 'NSW', '2161'),
(61, 'Mr', 'Rolando', 'Gamble', 'M', '1981-11-29', 'rolando.gamble@gmail.com', '(02) 4247 2542', '0429 991 767', '', '18/172 ED STREET ', 'CARINGBAH', 'NSW', '1495'),
(62, 'Mr', 'Rocky', 'Petersen', 'M', '1940-03-20', 'rocky@optusnet.com.au', '(02) 4687 5225', '0402 461 317', '', '115 CAPE NOBLE CIRCLE ', 'KIAMA DOWNS', 'NSW', '2533'),
(63, 'Mr', 'Hiram', 'Middleton', 'M', '1979-02-07', 'hmiddleton22@tpg.com.au', '(02) 4513 2558', '0417 657 247', '', '90 DEWEY CIRCLE ', 'BEROWRA WATERS', 'NSW', '2082'),
(64, 'Miss', 'Valarie', 'Elliott', 'F', '1989-04-12', 'v.elliott@gmail.com', '(02) 4779 7455', '0426 234 822', '', '2 BOYSEN BERRY PLACE ', 'POINT PIPER', 'NSW', '2027'),
(65, 'Mr', 'Toby', 'Booth', 'M', '1968-05-09', 'toby@mirkwoodproductions.com.au', '(02) 4672 6719', '0428 448 138', '', '182 HASTINGS LANE ', 'WILLIAMSDALE', 'NSW', '2620'),
(66, 'Prof', 'Hunter', 'Obrien', 'M', '1956-04-12', 'hobrien364@gmail.com', '(02) 4273 8232', '0416 922 476', '', '186 GARNET STREET ', 'WEETANGERA', 'NSW', '2614'),
(67, 'Mr', 'Kurt', 'Compton', 'M', '1993-07-02', 'k.compton@hotmail.com', '(02) 4988 8967', '0404 883 918', '', '166 GOLD CIRCLE ', 'WHITE CLIFFS', 'NSW', '2836'),
(68, 'Mr', 'Luciano', 'Hodge', 'M', '1965-06-01', 'luciano@mirkwoodproductions.com.au', '(02) 4934 2288', '0415 736 372', '', '22 MISTY SPRINGS COURT ', 'BLAIRMOUNT', 'NSW', '2559'),
(69, 'Mr', 'Randy', 'Gonzalez', 'M', '1938-01-12', 'randy.gonzalez@tpg.com.au', '(02) 4456 6722', '0426 738 474', 'Unit 3 Level 2', '48 PASO PLACE ', 'BUNGAWALBIN', 'NSW', '2469'),
(70, 'Mr', 'Monroe', 'Wilson', 'M', '1945-02-24', 'monroe.wilson@mirkwoodproductions.com.au', '(02) 4664 3495', '0415 665 952', '', '118 MOUNTAINMAN LOOP ', 'WEST WYALONG', 'NSW', '2671'),
(71, 'Miss', 'Simone', 'Collier', 'F', '1940-02-09', 'simone.collier@hotmail.com', '(02) 4966 4262', '0416 364 486', '', '5/144 ROSEMONT DRIVE ', 'NORTH BALGOWLAH', 'NSW', '2093'),
(72, 'Ms', 'Alisha', 'Vaughan', 'F', '1945-08-27', 'alisha@gmail.com', '(02) 4324 5722', '0415 514 624', '', '87 GLENN NB OFF S BIRCHWOOD LOOP RAMP ', 'PACIFIC PALMS', 'NSW', '2428'),
(73, 'Mr', 'Willie', 'Tweezeit', 'M', '1984-07-15', 'grab_life_by_the_head@gmail.com', '(02) 4772 2315', '0426 412 512', '', '80 HOSKEN STREET ', 'MACQUARIE PARK', 'NSW', '2113'),
(74, 'Mr', 'Louie', 'Lindsay', 'M', '1980-07-26', 'l.lindsay@gmail.com', '(02) 4663 8289', '0419 324 483', '', '185 HILLCREST DRIVE ', 'LISMORE', 'NSW', '2480'),
(75, 'Miss', 'Bettie', 'Mathis', 'F', '1951-03-14', 'bettie.mathis@mirkwoodproductions.com.au', '(02) 4794 3885', '0431 296 777', '', '69 CHAPEL DRIVE ', 'HUMULA', 'NSW', '2652'),
(76, 'Dr', 'Kay', 'Blake', 'F', '1961-06-19', 'k.blake@hotmail.com', '(02) 4677 6243', '0436 616 698', '', '24 BRIDGER PLACE ', 'WARIALDA RAIL', 'NSW', '2402');

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
CREATE TABLE IF NOT EXISTS `inventory` (
  `itemID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Primary Key',
  `itemName` varchar(100) DEFAULT NULL COMMENT 'Name of inventory item',
  `itemDescription` varchar(200) DEFAULT NULL COMMENT 'Description of item',
  `numberOnHand` varchar(100) DEFAULT NULL COMMENT 'Number stored',
  `numberOnOrder` varchar(100) DEFAULT NULL COMMENT 'Number on order is a positive number',
  PRIMARY KEY (`itemID`)
) ENGINE=MyISAM AUTO_INCREMENT=40 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`itemID`, `itemName`, `itemDescription`, `numberOnHand`, `numberOnOrder`) VALUES
(1, 'Bandage scissors', 'Universal Scissors are multi-purpose scissors, good for bandaging. Stainless steel, 14cm in length.', '4', '0'),
(2, 'Coflex bandage', 'CoFlex ? is a cohesive flexible bandage manufactured for bovine hoof trimmers that can also be used as a lightweight wound dressing. CoFlex does not stick to skin or hair, and provides consistent comp', '17', '20'),
(3, 'Cotton wool roll', 'Smith and Nephew Cotton Wool Roll is a cellulose fibre/cotton blend dressing of surgical absorbent quality for wound management, bandaging and first aid.', '13', '50'),
(4, 'Elastoplast roll', 'Value pack of 12 - Super adhesive bandages. Veterinary Elastoplast is an elastic adhesive bandage.', '5', '25'),
(5, 'Jelonet', 'Jelonet* is a paraffin gauze dressing 36 pieces of 10x10cm Features Soft paraffin base Sterile leno weave.', '29', '0'),
(6, 'Pill popper tablet applicator', 'Holds the tablet for you, making it easier to give your dog or cat tablets. You depress the plunger to administer the dose.', '38', '25'),
(7, 'Rip-Rap heavy bandage', 'Heavy duty self-adhesive bandage - the ''King Gee'' of cohesive bandages. Ideal for use on large animals.4.5m long, 5cm wide.', '3', '20'),
(8, 'Sharps container', '1.4L sharps disposable container. Please refer to local legislation regarding disposal of used containers.', '0', '0'),
(9, 'Stethoscope', 'Basic dual headed stethoscope', '4', '0'),
(10, 'Swabs guaze', 'Guaze for wounds. 5cm wide.', '102', '0'),
(11, 'Syringe (10ml)', '10ml Centre Fit Luer Slip steril syringe.', '15', '10'),
(12, 'Epsom salt', 'Also known as magnesium sulphate. Feed grade', '10', '0'),
(13, 'Veterinary Gamgee', 'Highly-absorant hospital-grade cotton wool encased in a low-adherent, tubular non-woven cover.', '5', '0'),
(14, 'Tick-approved microwave bags', 'Zip-lock bags that are designed specifically for tick destruction.', '318', '100'),
(15, 'Wrap it bandage', 'Cohesive non-woven bandage. 1.8m unstretched and 4.5m stretched.', '24', '0'),
(16, 'Bunny bubble bath', 'Gently cleans and conditions coats of rabbits and guinea pigs. Tearless formulation suitable for every day use.', '20', '0'),
(17, 'Cylap RCD - Rabbit Vaccine', 'Control of rabbit calicivirus disease. Vaccinate at 10 - 12 weeks then yearly. Give 1ml subcutaneously.', '8', '0'),
(18, 'Fidos bubble bath', 'Fido''s Bunny Bath Shampoo and Cond in 1 is a mild soap free formulation especially suitable for the delicate skins of rabbits, guinea pigs and other furry pets. Your pet''s coat is left clean and lustr', '3', '0'),
(19, 'Biolac animal rearing teats - T1', 'Fake teats for assisting with the rearing of animals. Teatlicious.', '4', '2'),
(20, 'Biolac animal rearing teats - T2', 'Fake teats for assisting with the rearing of animals. Teatlicious.', '3', '2'),
(21, 'Biolac animal rearing teats - T3', 'Fake teats for assisting with the rearing of animals. Teatlicious.', '12', '0'),
(22, 'Biolac animal rearing teats - T4', 'Fake teats for assisting with the rearing of animals. Teatlicious.', '6', '0'),
(23, 'Pet nursing bottle', 'A bottle?', '0', '0'),
(24, 'Dentipet finger toothbrush', 'For the cleaning of animals'' teeth using one''s finger.', '2', '24'),
(25, 'PetLife QuickFit Muzzle', 'The PetLife Quick Fit Muzzle is a fantastic standard dog muzzle. It even has a brilliant adjustable velcro strap, so you know it''ll fit properly. There''s a mesh part under the chin too for better vent', '2', '0'),
(26, 'Beta-Cel', 'Electrolyte mixture for replacement therapy for racing greyhounds.', '0', '10'),
(27, 'Equivit Enduramex', 'Endura-Max Plus Electrolyte Paste is a buffered oral electrolyte supplement designed specifically for endurance horses.', '0', '2'),
(28, 'Thundershirt for cats', 'A shirt that provids general well-balanced pressure resulting in a calm animal.', '12', '0'),
(29, 'Thundershirt for dogs', 'A shirt that provids general well-balanced pressure resulting in a calm animal.', '3', '10'),
(30, 'Thundershirt for ferrets', 'A shirt that provids general well-balanced pressure resulting in a calm animal.', '8', '10'),
(31, 'Thundershirt for fish', 'A shirt that provids general well-balanced pressure resulting in a calm animal.', '1', '10'),
(32, 'Thundershirt for goats', 'A shirt that provids general well-balanced pressure resulting in a calm animal.', '0', '10'),
(33, 'Thundershirt for slugs', 'A shirt that provids general well-balanced pressure resulting in a calm animal.', '0', '100'),
(34, 'Permoxin', 'Antiparasitic wash', '123', '50'),
(35, 'Advantage for dogs', 'Advantage flea and tick solution.', '184', '0'),
(36, 'Advantage for cats', 'Advantage flea and tick solution.', '172', '0'),
(37, 'Advantage for fish', 'Advantage flea and tick solution.', '12', '0'),
(38, 'Advantage for ferrets', 'Advantage flea and tick solution.', '62', '0'),
(39, 'Advantage for goats', 'Advantage flea and tick solution.', '21', '10');

-- --------------------------------------------------------

--
-- Table structure for table `pet`
--

DROP TABLE IF EXISTS `pet`;
CREATE TABLE IF NOT EXISTS `pet` (
  `petID` int(11) NOT NULL AUTO_INCREMENT,
  `petName` varchar(80) CHARACTER SET utf8 DEFAULT NULL,
  `species` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `breed` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `gender` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `weight` float DEFAULT NULL,
  `customerID` int(11) DEFAULT NULL,
  PRIMARY KEY (`petID`),
  KEY `customerID` (`customerID`)
) ENGINE=InnoDB AUTO_INCREMENT=113 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pet`
--

INSERT INTO `pet` (`petID`, `petName`, `species`, `breed`, `DOB`, `gender`, `weight`, `customerID`) VALUES
(1, 'Nkala', 'Cat', 'DLH', '2011-04-13', 'F', 3.6, 53),
(2, 'Charlie', 'Cat', 'Burmese', '2002-03-16', 'M', 4.3, 33),
(3, 'Darky', 'Cat', 'DSH', '2010-12-20', 'M', 6.8, 18),
(4, 'Kitty', 'Cat', 'DSH', '2008-01-22', 'M', 7.5, 63),
(5, 'Stripey', 'Cat', 'DSH', '1999-04-14', 'M', 6.9, 33),
(6, 'Happy', 'Cat', 'Persian', '2012-04-12', 'M', 8.1, 19),
(7, 'Bichel', 'Cat', 'DSH', '2004-12-29', 'M', 3, 13),
(8, 'Trouble', 'Cat', 'DLH', '1998-12-12', 'M', 6.7, 67),
(9, 'Rupert', 'Cat', 'DSH', '2002-08-10', 'M', 5.4, 66),
(10, 'Lucky', 'Cat', 'Siamese', '2005-05-03', 'M', 7.4, 36),
(11, 'Jemima', 'Cat', 'DSH', '2006-07-18', 'F', 7.2, 69),
(12, 'Nathan', 'Cat', 'DSH', '2005-08-05', 'M', 6.1, 7),
(13, 'Harold', 'Cat', 'DSH', '2012-06-12', 'M', 5.8, 7),
(14, 'Tabitha', 'Cat', 'Persian', '2006-08-29', 'F', 4.3, 37),
(15, 'Diggeden', 'Cat', 'DSH', '2003-04-20', 'M', 6.8, 54),
(16, 'Tigger', 'Cat', 'Burmese', '2008-11-06', 'M', 5.7, 7),
(17, 'Sadza', 'Cat', 'DSH', '2011-10-01', 'M', 5.9, 31),
(18, 'Gravy', 'Cat', 'DSH', '2001-06-10', 'M', 3.9, 18),
(19, 'Phoebe', 'Cat', 'Persian', '2007-06-24', 'F', 7.2, 73),
(20, 'Meow-Meow', 'Cat', 'DSH', '2004-12-09', 'F', 4.4, 60),
(21, 'Puffles', 'Cat', 'Siamese', '2008-05-31', 'F', 3.9, 70),
(22, 'Splat', 'Cat', 'Persian', '2006-06-09', 'F', 7.8, 34),
(23, 'Paw Thing', 'Cat', 'DSH', '2009-05-24', 'F', 3.4, 30),
(24, 'Verushka', 'Cat', 'Russian Blue', '1998-11-28', 'F', 5.1, 68),
(25, 'Gobbles', 'Cat', 'DSH', '2006-03-24', 'M', 3.6, 39),
(26, 'Fat Fred', 'Cat', 'DSH', '2006-08-02', 'M', 5.5, 58),
(27, 'Blimpie', 'Cat', 'Burmese', '2000-03-22', 'M', 7.5, 16),
(28, 'Fred', 'Cat', 'Siamese', '2001-03-03', 'M', 4.2, 27),
(29, 'Frankie', 'Cat', 'DSH', '2009-05-19', 'M', 7.1, 55),
(30, 'Sooty', 'Cat', 'DLH', '2004-10-02', 'M', 7, 67),
(31, 'Geeves', 'Cat', 'DLH', '2006-12-06', 'M', 6.9, 70),
(32, 'Miranda', 'Cat', 'DSH', '2005-05-20', 'F', 7.8, 25),
(33, 'Cazza', 'Cat', 'DLH', '2011-04-15', 'F', 6.2, 36),
(34, 'Abby', 'Cat', 'Munchkin', '1999-02-10', 'F', 7.4, 40),
(35, 'Whiskers', 'Cat', 'DSH', '2000-04-05', 'M', 3.1, 37),
(36, 'Boopie', 'Cat', 'Ragdoll', '2010-03-26', 'M', 8.1, 42),
(37, 'Cleo', 'Cat', 'Birman', '2000-02-17', 'M', 8.8, 59),
(38, 'Nick', 'Cat', 'Birman', '2009-12-10', 'M', 7.7, 1),
(39, 'Ziggy', 'Dog', 'Kelpie', '2012-05-08', 'M', 4.3, 31),
(40, 'Bazza', 'Dog', 'Kelpie', '2006-10-23', 'M', 11.6, 3),
(41, 'Bindi', 'Dog', 'Australian Terrier', '2007-02-10', 'M', 12.9, 23),
(42, 'Butch', 'Dog', 'Boxer', '2001-01-18', 'M', 10.5, 46),
(43, 'Mitzi', 'Dog', 'Maltese Terrier', '2006-02-28', 'F', 18.6, 65),
(44, 'Rusty', 'Dog', 'Red Setter', '2009-04-01', 'M', 11.4, 51),
(45, 'Pippa', 'Dog', 'Whippet', '2008-04-16', 'F', 7.9, 75),
(46, 'Top', 'Dog', 'Labrador', '2011-05-20', 'F', 4, 50),
(47, 'Red', 'Dog', 'King Charles spaniel', '2012-09-27', 'M', 10.1, 16),
(48, 'Blue', 'Dog', 'Maltese Poodle', '2001-05-19', 'M', 8.9, 2),
(49, 'Jarrad', 'Dog', 'Jack Russell', '2007-05-23', 'M', 17.9, 20),
(50, 'Amigo', 'Dog', 'Maltese Poodle', '2000-04-25', 'M', 15.9, 42),
(51, 'Bonkers', 'Dog', 'Dachshund', '2012-01-26', 'M', 4, 68),
(52, 'Bongo', 'Dog', 'Labrador', '2001-11-02', 'M', 11.5, 30),
(53, 'Crazy Horse', 'Dog', 'Maltese Poodle', '2001-03-26', 'M', 17.8, 60),
(54, 'Wooffles', 'Dog', 'King Charles spaniel', '2006-03-21', 'F', 3.2, 36),
(55, 'Darling', 'Dog', 'Afghan Hound', '2001-09-27', 'F', 9.6, 29),
(56, 'Precious', 'Dog', 'Pekinese', '2006-05-02', 'F', 19.1, 21),
(57, 'Zog', 'Dog', 'Border Collie', '2012-10-21', 'F', 15.5, 22),
(58, 'Max', 'Dog', 'Labrador', '2009-11-03', 'M', 11.4, 3),
(59, 'Dingo', 'Dog', 'Poodle', '2000-06-28', 'M', 14.3, 54),
(60, 'Wolf', 'Dog', 'Labrador', '2006-10-21', 'M', 16.6, 42),
(61, 'Slobberchops', 'Dog', 'Boxer', '2009-12-28', 'M', 3.4, 36),
(62, 'Thief', 'Dog', 'Border Collie', '2008-10-27', 'M', 7.6, 2),
(63, 'Buttsniffer', 'Dog', 'Labradoodle', '2006-06-04', 'M', 11.8, 68),
(64, 'Ferdy', 'Dog', 'Maltese Poodle', '1998-07-25', 'M', 9, 16),
(65, 'Ursula', 'Dog', 'Labrador', '2000-06-13', 'F', 6.3, 7),
(66, 'Bella', 'Dog', 'Pomeranian', '2005-08-29', 'F', 10.3, 64),
(67, 'Gerda', 'Dog', 'Labrador', '2007-07-23', 'F', 16, 11),
(68, 'Sammy', 'Dog', 'Border Collie', '2003-08-14', 'M', 16.8, 44),
(69, 'Chuck', 'Dog', 'King Charles spaniel', '2002-12-14', 'M', 13.5, 2),
(70, 'Burglar', 'Ferret', '', '2004-09-30', 'F', 11.4, 70),
(71, 'Mike', 'Ferret', 'Cinammon Ferret', '2012-10-13', 'M', 7.8, 12),
(72, 'Nerdwood', 'Ferret', 'Cinammon Ferret', '2005-02-09', 'M', 18.7, 73),
(73, 'Frederico', 'Ferret', '', '1998-07-13', 'M', 4.5, 70),
(74, 'Felix', 'Ferret', '', '2011-11-08', 'M', 18.3, 23),
(75, 'Trapper', 'Ferret', '', '2011-06-18', 'F', 11.2, 71),
(76, 'Sneaky Whiskers', 'Ferret', 'Butterscotch Ferret', '2008-08-20', 'F', 4.4, 15),
(77, 'Greg', 'Snake', 'Eel Snake', '2009-10-06', 'M', 6.6, 75),
(78, 'Woodie', 'Snake', 'Python', '2010-01-30', 'M', 11.9, 36),
(79, 'Jools', 'Snake', 'Brown Snake', '2007-09-10', 'F', 16.3, 57),
(80, 'Suzie', 'Snake', 'Black Snake', '2011-06-14', 'F', 15.7, 44),
(81, 'Stretch', 'Snake', 'Python', '2010-05-20', 'F', 8.9, 6),
(82, 'Thermal', 'Koala', '', '2009-09-06', 'M', 18.2, 32),
(83, 'Matt', 'Goat', '', '2012-03-01', 'M', 16.5, 62),
(84, 'Moose', 'Goat', '', '2011-08-25', 'F', 13.5, 75),
(85, 'Garry', 'Goat', '', '2011-01-19', 'M', 11.8, 36),
(86, 'Peter', 'Rabbit ', '', '2008-08-20', 'M', 9.1, 39),
(87, 'Hopper', 'Rabbit ', '', '2012-07-16', 'F', 7.8, 50),
(88, 'Thunder', 'Rabbit ', 'Angora', '2011-01-29', 'F', 7.1, 14),
(89, 'Breedz', 'Rabbit ', '', '2012-09-18', 'M', 5.8, 47),
(90, 'Sunflower', 'Rabbit ', '', '2007-04-10', 'F', 3.3, 51),
(91, 'Mug', 'Rabbit ', '', '2010-12-26', 'F', 6.6, 65),
(92, 'Midnight', 'Mouse', '', '2008-05-21', 'M', 0, 10),
(93, 'Hashimoto', 'Mouse', '', '2008-07-27', 'M', 0, 66),
(94, 'Claudette', 'Mouse', '', '2008-05-31', 'F', 0, 14),
(95, 'Toffee', 'Guinea Pig', '', '2010-05-25', 'F', 0, 18),
(96, 'Fudge', 'Guinea Pig', '', '2012-01-06', 'F', 0, 29),
(97, 'Caramel', 'Guinea Pig', '', '2012-01-31', 'F', 0, 58),
(98, 'Dollar', 'Guinea Pig', '', '2010-03-16', 'F', 0, 3),
(99, 'Patches', 'Guinea Pig', '', '2011-09-08', 'M', 0, 12),
(100, 'Splodge', 'Guinea Pig', '', '2010-07-09', 'M', 0, 1),
(101, 'Nibbles', 'Rat', '', '2008-06-01', 'M', 0, 35),
(102, 'Twitch', 'Rat', '', '2007-11-22', 'F', 0, 73),
(103, 'Chomper', 'Rat', '', '2008-03-24', 'F', 0, 75),
(104, 'Buck', 'Rat', '', '2012-11-13', 'M', 0, 54),
(105, 'Seal', 'Guinea Pig', '', '2011-07-16', 'M', 0, 67),
(106, 'Lisa', 'Guinea Pig', '', '2007-04-25', 'F', 0, 46),
(107, 'Percy', 'Rat', '', '2010-06-14', 'M', 0, 53),
(108, 'Hannah', 'Rat', '', '2007-09-04', 'F', 0, 67),
(109, 'Lurch', 'Rat', '', '2010-03-09', 'F', 0, 46),
(110, 'Teacher', 'Tortoise', '', '2011-03-31', 'M', 11, 58),
(111, 'kale', 'Dog', 'shepherd', '2017-02-28', 'M', 5.5, 1),
(112, 'setey', 'Rabbit ', NULL, '2014-06-18', 'F', 2.5, 76);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
CREATE TABLE IF NOT EXISTS `staff` (
  `staffID` int(11) NOT NULL,
  `title` varchar(10) CHARACTER SET utf8 DEFAULT NULL,
  `firstName` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `lastName` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `gender` varchar(1) CHARACTER SET utf8 DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `email` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `phone1` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `phone2` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `street1` varchar(150) CHARACTER SET utf8 DEFAULT NULL,
  `street2` varchar(150) CHARACTER SET utf8 DEFAULT NULL,
  `suburb` varchar(80) CHARACTER SET utf8 DEFAULT NULL,
  `state` varchar(3) CHARACTER SET utf8 DEFAULT NULL,
  `postcode` varchar(4) CHARACTER SET utf8 DEFAULT NULL,
  `position` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`staffID`),
  KEY `state` (`state`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staffID`, `title`, `firstName`, `lastName`, `gender`, `DOB`, `email`, `phone1`, `phone2`, `street1`, `street2`, `suburb`, `state`, `postcode`, `position`) VALUES
(1, 'Mr', 'Keith', 'Cabrade', 'M', '1973-02-13', 'keith@tickedoff.com.au', '(02) 9912 8192', '0401 982 389', '', '10 Cracked Rd', 'Avalon', 'NSW', '2107', 'Manager'),
(2, 'Ms', 'Savannah', 'Chartreux', 'F', '1966-07-01', 'savannah@tickedoff.com.au', '(02) 8863 4123', '0411 786 344', 'Unit 1', '19 Serval St', 'Mona Vale', 'NSW', '2103', 'Vet'),
(3, 'Dr', 'Peter', 'Pug', 'M', '1965-11-13', 'peter@tickedoff.com.au', '', '0401 298 128', '', '80 Panther Pl', 'Morisset', 'NSW', '2264', 'Vet'),
(4, 'Mrs', 'Gail', 'Cavia', 'F', '1972-12-12', 'gail@tickedoff.com.au', '(02) 9317 1278', '0401 829 998', '', '123 Porcellus Rd', 'Newport', 'NSW', '2106', 'Office Assistant'),
(5, 'Mrs', 'Greta', 'Mustela', 'F', '1970-03-12', 'greta@tickedoff.com.au', '', '0411 238 812', '', '10 Polecat St', 'Turramurra', 'NSW', '2074', 'Vet');

-- --------------------------------------------------------

--
-- Table structure for table `state`
--

DROP TABLE IF EXISTS `state`;
CREATE TABLE IF NOT EXISTS `state` (
  `state` varchar(3) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`state`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `state`
--

INSERT INTO `state` (`state`) VALUES
('ACT'),
('NSW'),
('NT'),
('QLD'),
('SA'),
('TAS'),
('VIC'),
('WA');

-- --------------------------------------------------------

--
-- Table structure for table `stay`
--

DROP TABLE IF EXISTS `stay`;
CREATE TABLE IF NOT EXISTS `stay` (
  `stayID` int(11) NOT NULL,
  `stayStartDate` date DEFAULT NULL,
  `stayEndDate` date DEFAULT NULL,
  `petID` int(11) DEFAULT NULL,
  `stayCost` decimal(19,4) DEFAULT NULL,
  PRIMARY KEY (`stayID`),
  KEY `petID` (`petID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stay`
--

INSERT INTO `stay` (`stayID`, `stayStartDate`, `stayEndDate`, `petID`, `stayCost`) VALUES
(1, '2013-01-01', '2013-01-03', 56, '682.5000'),
(2, '2013-01-01', '2013-01-05', 97, '121.5000'),
(3, '2013-01-01', '2013-01-08', 12, '222.0000'),
(4, '2013-01-02', '2013-01-10', 84, '126.0000'),
(5, '2013-01-02', '2013-01-05', 56, '655.5000'),
(6, '2013-01-02', '2013-01-05', 24, '729.0000'),
(7, '2013-01-02', '2013-01-06', 103, '327.0000'),
(8, '2013-01-02', '2013-01-11', 36, '274.5000'),
(9, '2013-01-03', '2013-01-04', 18, '658.5000'),
(10, '2013-01-03', '2013-01-06', 8, '292.5000'),
(11, '2013-01-03', '2013-01-05', 70, '640.5000'),
(12, '2013-01-03', '2013-01-06', 45, '684.0000'),
(13, '2013-01-03', '2013-01-06', 66, '553.5000'),
(14, '2013-01-03', '2013-01-06', 33, '253.5000'),
(15, '2013-01-03', '2013-01-07', 64, '252.0000'),
(16, '2013-01-03', '2013-01-09', 21, '87.0000'),
(17, '2013-01-03', '2013-01-14', 62, '522.0000'),
(18, '2013-01-04', '2013-01-06', 41, '666.0000'),
(19, '2013-01-04', '2013-01-07', 41, '324.0000'),
(20, '2013-01-04', '2013-01-08', 7, '579.0000'),
(21, '2013-01-04', '2013-01-14', 86, '612.0000'),
(22, '2013-01-04', '2013-01-15', 24, '676.5000'),
(23, '2013-01-05', '2013-01-06', 105, '84.0000'),
(24, '2013-01-05', '2013-01-06', 97, '183.0000'),
(25, '2013-01-05', '2013-01-07', 48, '166.5000'),
(26, '2013-01-05', '2013-01-07', 45, '123.0000'),
(27, '2013-01-05', '2013-01-08', 29, '571.5000'),
(28, '2013-01-05', '2013-01-09', 46, '156.0000'),
(29, '2013-01-05', '2013-01-12', 77, '666.0000'),
(30, '2013-01-05', '2013-01-17', 50, '103.5000'),
(31, '2013-01-06', '2013-01-07', 71, '630.0000'),
(32, '2013-01-06', '2013-01-08', 102, '630.0000'),
(33, '2013-01-06', '2013-01-10', 19, '535.5000'),
(34, '2013-01-06', '2013-01-10', 106, '556.5000'),
(35, '2013-01-06', '2013-01-10', 8, '703.5000'),
(36, '2013-01-07', '2013-01-08', 8, '417.0000'),
(37, '2013-01-07', '2013-01-08', 85, '555.0000'),
(38, '2013-01-07', '2013-01-09', 92, '388.5000'),
(39, '2013-01-07', '2013-01-11', 61, '36.0000'),
(40, '2013-01-07', '2013-01-12', 9, '327.0000'),
(41, '2013-01-07', '2013-01-15', 41, '681.0000'),
(42, '2013-01-08', '2013-01-10', 38, '424.5000'),
(43, '2013-01-08', '2013-01-11', 110, '228.0000'),
(44, '2013-01-08', '2013-01-12', 105, '658.5000'),
(45, '2013-01-08', '2013-01-16', 61, '262.5000'),
(46, '2013-01-09', '2013-01-10', 58, '304.5000'),
(47, '2013-01-09', '2013-01-10', 88, '43.5000'),
(48, '2013-01-09', '2013-01-10', 55, '373.5000'),
(49, '2013-01-09', '2013-01-10', 106, '103.5000'),
(50, '2013-01-09', '2013-01-11', 76, '573.0000'),
(51, '2013-01-09', '2013-01-11', 48, '592.5000'),
(52, '2013-01-09', '2013-01-13', 92, '319.5000'),
(53, '2013-01-10', '2013-01-12', 109, '634.5000'),
(54, '2013-01-10', '2013-01-12', 22, '213.0000'),
(55, '2013-01-10', '2013-01-13', 69, '373.5000'),
(56, '2013-01-10', '2013-01-13', 12, '96.0000'),
(57, '2013-01-10', '2013-01-14', 53, '373.5000'),
(58, '2013-01-10', '2013-01-16', 51, '666.0000'),
(59, '2013-01-10', '2013-01-21', 110, '550.5000'),
(60, '2013-01-11', '2013-01-13', 86, '108.0000'),
(61, '2013-01-11', '2013-01-14', 14, '484.5000'),
(62, '2013-01-11', '2013-01-14', 85, '295.5000'),
(63, '2013-01-11', '2013-01-17', 84, '636.0000'),
(64, '2013-01-11', '2013-01-21', 33, '138.0000'),
(65, '2013-01-11', '2013-01-23', 93, '297.0000'),
(66, '2013-01-11', '2013-01-24', 99, '177.0000'),
(67, '2013-01-12', '2013-01-13', 86, '201.0000'),
(68, '2013-01-12', '2013-01-13', 12, '657.0000'),
(69, '2013-01-12', '2013-01-13', 81, '678.0000'),
(70, '2013-01-12', '2013-01-14', 91, '270.0000'),
(71, '2013-01-12', '2013-01-15', 52, '307.5000'),
(72, '2013-01-12', '2013-01-18', 17, '621.0000'),
(73, '2013-01-13', '2013-01-14', 67, '694.5000'),
(74, '2013-01-13', '2013-01-15', 62, '571.5000'),
(75, '2013-01-13', '2013-01-15', 67, '537.0000'),
(76, '2013-01-13', '2013-01-15', 59, '292.5000'),
(77, '2013-01-13', '2013-01-17', 47, '214.5000'),
(78, '2013-01-13', '2013-01-17', 45, '444.0000'),
(79, '2013-01-13', '2013-01-17', 72, '442.5000'),
(80, '2013-01-13', '2013-01-25', 17, '535.5000'),
(81, '2013-01-14', '2013-01-17', 75, '445.5000'),
(82, '2013-01-14', '2013-01-17', 108, '535.5000'),
(83, '2013-01-14', '2013-01-18', 93, '559.5000'),
(84, '2013-01-14', '2013-01-24', 82, '160.5000'),
(85, '2013-01-14', '2013-01-27', 98, '456.0000'),
(86, '2013-01-15', '2013-01-18', 66, '633.0000'),
(87, '2013-01-15', '2013-01-18', 15, '409.5000'),
(88, '2013-01-15', '2013-01-18', 63, '604.5000'),
(89, '2013-01-15', '2013-01-19', 7, '568.5000'),
(90, '2013-01-16', '2013-01-17', 66, '193.5000'),
(91, '2013-01-16', '2013-01-17', 100, '204.0000'),
(92, '2013-01-16', '2013-01-17', 76, '631.5000'),
(93, '2013-01-16', '2013-01-17', 45, '304.5000'),
(94, '2013-01-16', '2013-01-17', 92, '247.5000'),
(95, '2013-01-16', '2013-01-18', 98, '660.0000'),
(96, '2013-01-16', '2013-01-18', 20, '283.5000'),
(97, '2013-01-16', '2013-01-19', 43, '619.5000'),
(98, '2013-01-16', '2013-01-19', 90, '226.5000'),
(99, '2013-01-16', '2013-01-20', 91, '667.5000'),
(100, '2013-01-16', '2013-01-29', 94, '678.0000'),
(101, '2013-01-17', '2013-01-19', 105, '708.0000'),
(102, '2013-01-17', '2013-01-19', 57, '735.0000'),
(103, '2013-01-17', '2013-01-21', 55, '600.0000'),
(104, '2013-01-17', '2013-01-30', 103, '190.5000'),
(105, '2013-01-18', '2013-01-19', 10, '61.5000'),
(106, '2013-01-18', '2013-01-19', 72, '369.0000'),
(107, '2013-01-18', '2013-01-20', 67, '693.0000'),
(108, '2013-01-18', '2013-01-21', 84, '693.0000'),
(109, '2013-01-18', '2013-01-22', 78, '198.0000'),
(110, '2013-01-18', '2013-01-22', 42, '61.5000'),
(111, '2013-01-18', '2013-01-22', 66, '724.5000'),
(112, '2013-01-18', '2013-01-22', 26, '517.5000'),
(113, '2013-01-18', '2013-01-25', 43, '606.0000'),
(114, '2013-01-19', '2013-01-20', 109, '736.5000'),
(115, '2013-01-19', '2013-01-22', 7, '453.0000'),
(116, '2013-01-19', '2013-01-23', 50, '699.0000'),
(117, '2013-01-19', '2013-01-30', 64, '627.0000'),
(118, '2013-01-20', '2013-01-21', 76, '487.5000'),
(119, '2013-01-20', '2013-01-21', 42, '45.0000'),
(120, '2013-01-20', '2013-01-23', 6, '163.5000'),
(121, '2013-01-20', '2013-01-23', 63, '726.0000'),
(122, '2013-01-20', '2013-01-26', 68, '705.0000'),
(123, '2013-01-20', '2013-01-28', 40, '175.5000'),
(124, '2013-01-20', '2013-01-29', 108, '34.5000'),
(125, '2013-01-20', '2013-02-01', 15, '274.5000'),
(126, '2013-01-21', '2013-01-23', 11, '126.0000'),
(127, '2013-01-21', '2013-01-25', 39, '450.0000'),
(128, '2013-01-21', '2013-01-25', 33, '390.0000'),
(129, '2013-01-21', '2013-01-25', 49, '735.0000'),
(130, '2013-01-21', '2013-01-25', 78, '238.5000'),
(131, '2013-01-21', '2013-01-25', 46, '631.5000'),
(132, '2013-01-21', '2013-01-29', 98, '151.5000'),
(133, '2013-01-21', '2013-02-04', 30, '135.0000'),
(134, '2013-01-22', '2013-01-23', 49, '505.5000'),
(135, '2013-01-22', '2013-01-25', 102, '114.0000'),
(136, '2013-01-22', '2013-01-25', 30, '175.5000'),
(137, '2013-01-22', '2013-02-01', 36, '573.0000'),
(138, '2013-01-22', '2013-02-01', 29, '424.5000'),
(139, '2013-01-22', '2013-02-02', 23, '628.5000'),
(140, '2013-01-22', '2013-02-04', 25, '582.0000'),
(141, '2013-01-23', '2013-01-24', 29, '475.5000'),
(142, '2013-01-23', '2013-01-25', 8, '571.5000'),
(143, '2013-01-23', '2013-01-25', 39, '253.5000'),
(144, '2013-01-23', '2013-01-27', 102, '204.0000'),
(145, '2013-01-24', '2013-01-25', 84, '547.5000'),
(146, '2013-01-24', '2013-01-26', 83, '727.5000'),
(147, '2013-01-24', '2013-01-27', 75, '540.0000'),
(148, '2013-01-24', '2013-01-27', 23, '604.5000'),
(149, '2013-01-24', '2013-01-28', 19, '507.0000'),
(150, '2013-01-24', '2013-01-28', 3, '166.5000'),
(151, '2013-01-24', '2013-01-30', 2, '442.5000'),
(152, '2013-01-25', '2013-01-26', 61, '130.5000'),
(153, '2013-01-25', '2013-01-26', 88, '255.0000'),
(154, '2013-01-25', '2013-01-28', 109, '748.5000'),
(155, '2013-01-25', '2013-01-28', 104, '66.0000'),
(156, '2013-01-26', '2013-01-27', 54, '496.5000'),
(157, '2013-01-26', '2013-01-27', 24, '655.5000'),
(158, '2013-01-26', '2013-01-27', 37, '366.0000'),
(159, '2013-01-26', '2013-01-27', 91, '198.0000'),
(160, '2013-01-26', '2013-01-28', 23, '411.0000'),
(161, '2013-01-26', '2013-01-28', 50, '660.0000'),
(162, '2013-01-26', '2013-01-28', 110, '426.0000'),
(163, '2013-01-26', '2013-01-29', 28, '91.5000'),
(164, '2013-01-26', '2013-01-29', 82, '531.0000'),
(165, '2013-01-26', '2013-01-29', 63, '640.5000'),
(166, '2013-01-26', '2013-01-30', 21, '223.5000'),
(167, '2013-01-26', '2013-01-31', 56, '534.0000'),
(168, '2013-01-26', '2013-02-01', 75, '369.0000'),
(169, '2013-01-26', '2013-02-06', 14, '643.5000'),
(170, '2013-01-27', '2013-01-29', 55, '238.5000'),
(171, '2013-01-27', '2013-01-30', 69, '195.0000'),
(172, '2013-01-27', '2013-01-31', 2, '361.5000'),
(173, '2013-01-27', '2013-01-31', 54, '211.5000'),
(174, '2013-01-28', '2013-01-29', 90, '298.5000'),
(175, '2013-01-28', '2013-01-30', 39, '111.0000'),
(176, '2013-01-28', '2013-01-31', 15, '604.5000'),
(177, '2013-01-28', '2013-02-02', 43, '739.5000'),
(178, '2013-01-28', '2013-02-10', 47, '138.0000'),
(179, '2013-01-28', '2013-02-11', 29, '414.0000'),
(180, '2013-01-29', '2013-01-30', 62, '82.5000'),
(181, '2013-01-29', '2013-01-30', 63, '174.0000'),
(182, '2013-01-29', '2013-01-31', 4, '712.5000'),
(183, '2013-01-29', '2013-02-01', 19, '435.0000'),
(184, '2013-01-29', '2013-02-01', 87, '630.0000'),
(185, '2013-01-29', '2013-02-02', 27, '486.0000'),
(186, '2013-01-29', '2013-02-06', 45, '265.5000'),
(187, '2013-01-29', '2013-02-09', 29, '169.5000'),
(188, '2013-01-30', '2013-01-31', 30, '355.5000'),
(189, '2013-01-30', '2013-02-01', 106, '397.5000'),
(190, '2013-01-30', '2013-02-02', 44, '618.0000'),
(191, '2013-01-30', '2013-02-03', 22, '327.0000'),
(192, '2013-01-30', '2013-02-03', 75, '261.0000'),
(193, '2013-01-30', '2013-02-03', 27, '484.5000'),
(194, '2013-01-30', '2013-02-03', 10, '391.5000'),
(195, '2013-01-30', '2013-02-06', 105, '157.5000'),
(196, '2013-01-30', '2013-02-06', 80, '456.0000'),
(197, '2013-01-31', '2013-02-01', 76, '661.5000'),
(198, '2013-01-31', '2013-02-01', 31, '549.0000'),
(199, '2013-01-31', '2013-02-04', 44, '657.0000'),
(200, '2013-01-31', '2013-02-07', 68, '85.5000');

-- --------------------------------------------------------

--
-- Stand-in structure for view `staypet`
--
DROP VIEW IF EXISTS `staypet`;
CREATE TABLE IF NOT EXISTS `staypet` (
`species` varchar(50)
,`duration` bigint(10)
,`stayCost` decimal(19,4)
);

-- --------------------------------------------------------

--
-- Structure for view `staypet`
--
DROP TABLE IF EXISTS `staypet`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `staypet`  AS  select `pet`.`species` AS `species`,(`stay`.`stayEndDate` - `stay`.`stayStartDate`) AS `duration`,`stay`.`stayCost` AS `stayCost` from (`pet` join `stay` on((`pet`.`petID` = `stay`.`petID`))) ;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `booking`
--
ALTER TABLE `booking`
  ADD CONSTRAINT `booking_ibfk_1` FOREIGN KEY (`petID`) REFERENCES `pet` (`petID`),
  ADD CONSTRAINT `booking_ibfk_2` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`);

--
-- Constraints for table `customer`
--
ALTER TABLE `customer`
  ADD CONSTRAINT `customer_ibfk_1` FOREIGN KEY (`state`) REFERENCES `state` (`state`);

--
-- Constraints for table `pet`
--
ALTER TABLE `pet`
  ADD CONSTRAINT `pet_ibfk_1` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`);

--
-- Constraints for table `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`state`) REFERENCES `state` (`state`);

--
-- Constraints for table `stay`
--
ALTER TABLE `stay`
  ADD CONSTRAINT `stay_ibfk_1` FOREIGN KEY (`petID`) REFERENCES `pet` (`petID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
