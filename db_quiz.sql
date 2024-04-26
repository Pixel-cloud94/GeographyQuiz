-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 04. Feb 2024 um 22:50
-- Server-Version: 10.4.32-MariaDB
-- PHP-Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `db_quiz`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `continent`
--

CREATE TABLE `continent` (
  `continent_id` int(11) NOT NULL,
  `continent_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `continent`
--

INSERT INTO `continent` (`continent_id`, `continent_name`) VALUES
(1, 'Africa'),
(2, 'Antarctica'),
(3, 'Asia'),
(4, 'Europe'),
(5, 'North America'),
(6, 'Australia'),
(7, 'South America');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `country`
--

CREATE TABLE `country` (
  `country_id` int(11) NOT NULL,
  `country_name` varchar(70) NOT NULL,
  `country_capital` varchar(70) NOT NULL,
  `continent_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `country`
--

INSERT INTO `country` (`country_id`, `country_name`, `country_capital`, `continent_id`) VALUES
(1, 'Afghanistan', 'Kabul', 1),
(2, 'Albania', 'Tirana', 4),
(3, 'Algeria', 'Algiers', 1),
(4, 'AmericanSamoa', 'Pago Pago', 5),
(5, 'Andorra', 'Andorra la Vella', 4),
(6, 'Angola', 'Luanda', 1),
(7, 'Anguilla', 'The Valley', 5),
(9, 'AntiguaandBarbuda', 'Saint John\'s', 5),
(10, 'Argentina', 'Buenos Aires', 7),
(11, 'Armenia', 'Yerevan', 3),
(12, 'Aruba', 'Oranjestad', 5),
(13, 'Australia', 'Canberra', 6),
(14, 'Austria', 'Vienna', 4),
(15, 'Azerbaijan', 'Baku', 3),
(16, 'Bahamas', 'Nassau', 5),
(17, 'Bahrain', 'Manama', 3),
(18, 'Bangladesh', 'Dhaka', 3),
(19, 'Barbados', 'Bridgetown', 5),
(20, 'Belarus', 'Minsk', 3),
(21, 'Belgium', 'Brussels', 4),
(22, 'Belize', 'Belmopan', 5),
(23, 'Benin', 'Porto-Novo', 1),
(24, 'Bermuda', 'Hamilton', 5),
(25, 'Bhutan', 'Thimphu', 3),
(26, 'Bolivia', 'La Paz', 7),
(27, 'BosniaandHerzegovina', 'Sarajevo', 4),
(28, 'Botswana', 'Gaborone', 1),
(29, 'Brazil', 'Brasília', 7),
(30, 'BritishIndianOceanTerritory', 'Diego Garcia', 5),
(31, 'Brunei', 'Bandar Seri Begawan', 3),
(32, 'Bulgaria', 'Sofia', 4),
(33, 'BurkinaFaso', 'Ouagadougou', 1),
(34, 'Burundi', 'Bujumbura', 1),
(35, 'Cambodia', 'Phnom Penh', 3),
(36, 'Cameroon', 'Yaoundé', 1),
(37, 'Canada', 'Ottawa', 5),
(38, 'CapeVerde', 'Praia', 1),
(39, 'CaymanIslands', 'George Town', 5),
(40, 'CentralAfricanRepublic', 'Bangui', 1),
(41, 'Chad', 'N\'Djamena', 1),
(42, 'Chile', 'Santiago', 7),
(43, 'China', 'Beijing', 3),
(44, 'ChristmasIsland', 'Flying Fish Cove', 5),
(45, 'CocosIslands', 'West Island', 5),
(46, 'Colombia', 'Bogotá', 7),
(47, 'Comoros', 'Moroni', 1),
(48, 'Congo', 'Brazzaville', 1),
(49, 'Congo, the Democratic Republic of the', 'Kinshasa', 1),
(50, 'CookIslands', 'Avarua', 5),
(51, 'CostaRica', 'San José', 7),
(52, 'Côted\'Ivoire', 'Yamoussoukro', 1),
(53, 'Croatia', 'Zagreb', 4),
(54, 'Cuba', 'Havana', 5),
(55, 'Cyprus', 'Nicosia', 4),
(56, 'CzechRepublic', 'Prague', 4),
(57, 'Denmark', 'Copenhagen', 4),
(58, 'Djibouti', 'Djibouti', 1),
(59, 'Dominica', 'Roseau', 5),
(60, 'DominicanRepublic', 'Santo Domingo', 5),
(61, 'Ecuador', 'Quito', 7),
(62, 'Egypt', 'Cairo', 1),
(63, 'ElSalvador', 'San Salvador', 7),
(64, 'Equatorial Guinea', 'Malabo', 1),
(65, 'Eritrea', 'Asmara', 1),
(66, 'Estonia', 'Tallinn', 4),
(67, 'Ethiopia', 'Addis Ababa', 1),
(68, 'FalklandIslands', 'Stanley', 5),
(69, 'FaroeIslands', 'Tórshavn', 4),
(70, 'Fiji', 'Suva', 5),
(71, 'Finland', 'Helsinki', 4),
(72, 'France', 'Paris', 4),
(73, 'FrenchGuiana', 'Cayenne', 5),
(74, 'FrenchPolynesia', 'Papeete', 6),
(75, 'FrenchSouthernTerritories', 'Port-aux-Français', 6),
(76, 'Gabon', 'Libreville', 1),
(77, 'Gambia', 'Banjul', 1),
(78, 'Georgia', 'Tbilisi', 3),
(79, 'Germany', 'Berlin', 4),
(80, 'Ghana', 'Accra', 1),
(81, 'Gibraltar', 'Gibraltar', 4),
(82, 'Greece', 'Athens', 4),
(83, 'Greenland', 'Nuuk', 4),
(84, 'Grenada', 'St. George\'s', 5),
(85, 'Guadeloupe', 'Basse-Terre', 5),
(86, 'Guam', 'Agaña', 5),
(87, 'Guatemala', 'Guatemala City', 5),
(88, 'Guinea', 'Conakry', 1),
(89, 'GuineaBissau', 'Bissau', 1),
(90, 'Guyana', 'Georgetown', 5),
(91, 'Haiti', 'Port-au-Prince', 5),
(92, 'Heard Island and McDonald Islands', '', 4),
(93, 'VaticanSate', 'Vatican City', 4),
(94, 'Honduras', 'Tegucigalpa', 5),
(95, 'Hong Kong', 'Victoria', 5),
(96, 'Hungary', 'Budapest', 4),
(97, 'Iceland', 'Reykjavik', 4),
(98, 'India', 'New Delhi', 3),
(99, 'Indonesia', 'Jakarta', 3),
(100, 'Iran', 'Tehran', 3),
(101, 'Iraq', 'Baghdad', 3),
(102, 'Ireland', 'Dublin', 4),
(103, 'Israel', 'Jerusalem', 3),
(104, 'Italy', 'Rome', 4),
(105, 'Jamaica', 'Kingston', 5),
(106, 'Japan', 'Tokyo', 3),
(107, 'Jordan', 'Amman', 3),
(108, 'Kazakhstan', 'Astana', 3),
(109, 'Kenya', 'Nairobi', 1),
(110, 'Kiribati', 'South Tarawa', 6),
(111, 'NorthKorea', 'Pyongyang', 3),
(112, 'Korea, Republic of', 'Seoul', 3),
(113, 'Kuwait', 'Kuwait City', 3),
(114, 'Kyrgyzstan', 'Bishkek', 3),
(115, 'Laos', 'Vientiane', 3),
(116, 'Latvia', 'Riga', 4),
(117, 'Lebanon', 'Beirut', 3),
(118, 'Lesotho', 'Maseru', 1),
(119, 'Liberia', 'Monrovia', 1),
(120, 'Libyan Arab Jamahiriya', 'Tripoli', 1),
(121, 'Liechtenstein', 'Vaduz', 4),
(122, 'Lithuania', 'Vilnius', 4),
(123, 'Luxembourg', 'Luxembourg', 4),
(124, 'Macao', 'Macao', 3),
(125, 'NorthMacedonia', 'Skopje', 4),
(126, 'Madagascar', 'Antananarivo', 1),
(127, 'Malawi', 'Lilongwe', 1),
(128, 'Malaysia', 'Kuala Lumpur', 3),
(129, 'Maldives', 'Malé', 3),
(130, 'Mali', 'Bamako', 1),
(131, 'Malta', 'Valletta', 4),
(132, 'Marshall Islands', 'Majuro', 6),
(133, 'Martinique', 'Fort-de-France', 5),
(134, 'Mauritania', 'Nouakchott', 1),
(135, 'Mauritius', 'Port Louis', 1),
(136, 'Mayotte', 'Mamoudzou', 1),
(137, 'Mexico', 'Mexico City', 5),
(138, 'Micronesia', 'Palikir', 6),
(139, 'Moldova, Republic of', 'Chișinău', 4),
(140, 'Monaco', 'Monaco', 4),
(141, 'Mongolia', 'Ulan Bator', 3),
(142, 'Montenegro', 'Podgorica', 4),
(143, 'Montserrat', 'Plymouth', 5),
(144, 'Morocco', 'Rabat', 1),
(145, 'Mozambique', 'Maputo', 1),
(146, 'Myanmar', 'Naypyidaw', 3),
(147, 'Namibia', 'Windhoek', 1),
(148, 'Nauru', 'Yaren District', 6),
(149, 'Nepal', 'Kathmandu', 3),
(150, 'Netherlands', 'Amsterdam', 4),
(151, 'Netherlands Antilles', 'Willemstad', 5),
(152, 'NewCaledonia', 'Nouméa', 6),
(153, 'NewZealand', 'Wellington', 6),
(154, 'Nicaragua', 'Managua', 5),
(155, 'Niger', 'Niamey', 1),
(156, 'Nigeria', 'Abuja', 1),
(157, 'Niue', 'Alofi', 6),
(158, 'NorfolkIsland', 'Kingston', 6),
(159, 'NorthernMarianaIslands', 'Saipan', 6),
(160, 'Norway', 'Oslo', 4),
(161, 'Oman', 'Muscat', 3),
(162, 'Pakistan', 'Islamabad', 3),
(163, 'Palau', 'Melekeok', 6),
(164, 'Palestine', 'East Jerusalem', 3),
(165, 'Panama', 'Panama City', 5),
(166, 'PapuaNewGuinea', 'Port Moresby', 6),
(167, 'Paraguay', 'Asunción', 5),
(168, 'Peru', 'Lima', 5),
(169, 'Philippines', 'Manila', 3),
(170, 'Pitcairn', 'Adamstown', 6),
(171, 'Poland', 'Warsaw', 4),
(172, 'Portugal', 'Lisbon', 4),
(173, 'Puerto Rico', 'San Juan', 5),
(174, 'Qatar', 'Doha', 3),
(175, 'Reunion', 'Saint-Denis', 1),
(176, 'Romania', 'Bucharest', 4),
(177, 'RussianFederation', 'Moscow', 4),
(178, 'Rwanda', 'Kigali', 1),
(179, 'SaintKittsandNevis', 'Basseterre', 5),
(180, 'SaintLucia', 'Castries', 5),
(181, 'SaintVincentandtheGrenadines', 'Kingstown', 5),
(182, 'Samoa', 'Apia', 6),
(183, 'SanMarino', 'San Marino', 4),
(184, 'SaoTomeandPrincipe', 'São Tomé', 1),
(185, 'SaudiArabia', 'Riyadh', 3),
(186, 'Senegal', 'Dakar', 1),
(187, 'SerbiaandMontenegro', 'Belgrade', 4),
(188, 'Seychelles', 'Victoria', 1),
(189, 'SierraLeone', 'Freetown', 1),
(190, 'Singapore', 'Singapore', 3),
(191, 'Slovakia', 'Bratislava', 4),
(192, 'Slovenia', 'Ljubljana', 4),
(193, 'SolomonIslands', 'Honiara', 6),
(194, 'Somalia', 'Mogadishu', 1),
(195, 'South Africa', 'Pretoria', 1),
(196, 'South Georgia and the South Sandwich Islands', 'Grytviken', 7),
(197, 'Spain', 'Madrid', 4),
(198, 'SriLanka', 'Sri Jayawardenepura Kotte', 3),
(199, 'Sudan', 'Khartoum', 1),
(200, 'Suriname', 'Paramaribo', 5),
(201, 'Sweden', 'Stockholm', 4),
(202, 'Switzerland', 'Bern', 4),
(203, 'Syria', 'Damascus', 4),
(204, 'Taiwan', 'Beijing', 3),
(205, 'Tajikistan', 'Dushanbe', 3),
(206, 'Tanzania', 'Dodoma', 1),
(207, 'Thailand', 'Bangkok', 3),
(208, 'Togo', 'Lomé', 1),
(209, 'Tokelau', '', 5),
(210, 'Tonga', 'Nuku\'alofa', 5),
(211, 'TrinidadandTobago', 'Port of Spain', 5),
(212, 'Tunisia', 'Tunis', 1),
(213, 'Turkey', 'Ankara', 4),
(214, 'Turkmenistan', 'Ashgabat', 3),
(215, 'TurksandCaicos Islands', 'Cockburn Town', 5),
(216, 'Tuvalu', '', 5),
(217, 'Uganda', 'Kampala', 1),
(218, 'Ukraine', 'Kiev', 4),
(219, 'UnitedArabEmirates', 'Abu Dhabi', 3),
(220, 'UnitedKingdom', 'London', 4),
(221, 'USA', 'Washington, D.C.', 5),
(222, 'United States Minor Outlying Islands', '', 5),
(223, 'Uruguay', 'Montevideo', 5),
(224, 'Uzbekistan', 'Tashkent', 3),
(225, 'Vanuatu', 'Port Vila', 5),
(226, 'Venezuela', 'Caracas', 5),
(227, 'Vietnam', 'Hanoi', 3),
(228, 'BritishVirginIslands', 'Road Town', 5),
(229, 'VirginIslands', 'Charlotte Amalie', 5),
(230, 'WallisandFutuna', 'Mata-Utu', 5),
(231, 'WesternSahara', 'El Aaiún', 1),
(232, 'Yemen', 'Sana\'a', 3),
(233, 'Zambia', 'Lusaka', 1),
(234, 'Zimbabwe', 'Harare', 1);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `highscore`
--

CREATE TABLE `highscore` (
  `user_id` int(11) DEFAULT NULL,
  `points` int(11) DEFAULT NULL,
  `date` date NOT NULL DEFAULT curdate()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `highscore`
--

INSERT INTO `highscore` (`user_id`, `points`, `date`) VALUES
(4, 3, '2024-02-04'),
(4, 1, '2024-02-04'),
(4, 5, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 5, '2024-02-04'),
(4, 6, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 1, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 7, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 8, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 1, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 5, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 0, '2024-02-04'),
(4, 6, '2024-02-04'),
(4, 6, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 6, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 8, '2024-02-04'),
(4, 6, '2024-02-04'),
(4, 6, '2024-02-04'),
(4, 7, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 1, '2024-02-04'),
(4, 6, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 5, '2024-02-04'),
(4, 6, '2024-02-04'),
(4, 5, '2024-02-04'),
(4, 5, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 7, '2024-02-04'),
(4, 6, '2024-02-04'),
(4, 1, '2024-02-04'),
(4, 5, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 7, '2024-02-04'),
(4, 1, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 9, '2024-02-04'),
(4, 6, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 5, '2024-02-04'),
(4, 5, '2024-02-04'),
(4, 5, '2024-02-04'),
(4, 2, '2024-02-04'),
(4, 3, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 7, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 5, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 4, '2024-02-04'),
(4, 2, '2024-02-04');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `password`
--

CREATE TABLE `password` (
  `user_id` int(11) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `password`
--

INSERT INTO `password` (`user_id`, `password`) VALUES
(3, '123456'),
(4, '$2a$11$dvbcgKotE3sH158OUH7UpOVmdWlPlxshz3kxoW/ivXHKPOvazud36'),
(5, '$2a$11$6MRVoYXWx6uS.c2elMC2w.8cjU6kJdPuWpRb2PJmDoiMuuL59p3zq'),
(6, '$2a$11$aebr0dx64jfZDqxc02Ovp.J4QE/gzospRB3w3nDdPjfDOH/3zxy8y'),
(7, '$2a$11$9H7Yn2DxyZQ0Qe.HE3.EZeNhwH5HYbmK2g5XJUqCr/29OP/kxr47m'),
(8, '$2a$11$1pfgwKSX29obcPFOIBB6Y.nJ/w18cDjk8cUyaxHgt9qmEomr72G.G'),
(9, '$2a$11$6i8bjdh26Fu0loJz/qHJRugvtZqxFUwMt50sa9ZVZ4aZpAGD1T5rK'),
(10, '$2a$11$0IPSaYcHLpHJ2EaANHnD9.Ya.lyrsSAojEGb3U7dMoapZHOATLdMm'),
(11, '$2a$11$kD4CITxJckQ3168Hh8jrH.MOSmBQyp0e66xNopH6zfHDgB1lVvtkm'),
(12, '$2a$11$6P.2Li2OpcmOUpboPaUwRenSG9Oi6ZmHG/0FcyqRB92S4Mrtupz4S'),
(13, '$2a$11$R4J3PxLiHfs2349HFFbnROyBV/9RJIvJIVrEvSFfCFZV2vOxcjEua');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `user_name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `user`
--

INSERT INTO `user` (`user_id`, `user_name`) VALUES
(3, 'Tim01'),
(4, 'Tim02'),
(5, 'tim04'),
(6, ''),
(7, ''),
(8, ''),
(9, ''),
(10, ''),
(11, ''),
(12, ''),
(13, 'timo1');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `continent`
--
ALTER TABLE `continent`
  ADD PRIMARY KEY (`continent_id`);

--
-- Indizes für die Tabelle `country`
--
ALTER TABLE `country`
  ADD PRIMARY KEY (`country_id`);

--
-- Indizes für die Tabelle `highscore`
--
ALTER TABLE `highscore`
  ADD KEY `user_id` (`user_id`);

--
-- Indizes für die Tabelle `password`
--
ALTER TABLE `password`
  ADD KEY `user_id` (`user_id`);

--
-- Indizes für die Tabelle `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `highscore`
--
ALTER TABLE `highscore`
  ADD CONSTRAINT `highscore_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`);

--
-- Constraints der Tabelle `password`
--
ALTER TABLE `password`
  ADD CONSTRAINT `password_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
