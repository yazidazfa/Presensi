-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 02, 2024 at 01:50 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `presensi`
--

-- --------------------------------------------------------

--
-- Table structure for table `event`
--

CREATE TABLE `event` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) DEFAULT NULL,
  `assignedID` int(255) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `tempat` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `event`
--

INSERT INTO `event` (`id`, `nama`, `assignedID`, `tanggal`, `tempat`) VALUES
(21, 'Bukber', 19, '2023-12-24', 'joglo'),
(22, 'mukbang', 22, '2023-12-26', 'lapangan'),
(24, 'mubes', 19, '2023-12-20', 'ruang rapata');

-- --------------------------------------------------------

--
-- Table structure for table `kehadiran`
--

CREATE TABLE `kehadiran` (
  `id` int(11) NOT NULL,
  `userID` int(11) DEFAULT NULL,
  `eventID` int(11) DEFAULT NULL,
  `status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kehadiran`
--

INSERT INTO `kehadiran` (`id`, `userID`, `eventID`, `status`) VALUES
(19, 16, 21, 'Hadir'),
(20, 19, 21, 'Hadir'),
(21, 20, 21, 'Bolos'),
(22, 16, 22, 'Hadir'),
(23, 19, 22, 'Bolos'),
(24, 20, 22, 'Hadir'),
(25, 22, 22, 'Izin'),
(31, 16, 24, 'Hadir'),
(32, 19, 24, ''),
(33, 20, 24, 'Izin'),
(34, 22, 24, ''),
(35, 26, 24, 'Hadir');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `tier` varchar(255) NOT NULL,
  `salt` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `name`, `password`, `tier`, `salt`) VALUES
(16, 'admin', 'IIxYe6uPXBx7hGAI1xA8qHqAEmgbrrXbshsmD7EpW7Y=', '1', 'Xyn2Vv9E+BDx1X486+SABv0K749A7HqW2NCcmDh3DIk='),
(19, 'operator', '4D20YUTmhhcrid+5fRwrVfCPL+TGUwNvYUheddFYssQ=', '2', 'emgUsDvkYulxlFsYnsgkHiEs3keSL4Q+GlZkJKKt1g0='),
(20, 'participant', 'XZimGbxOOXdUBl3cY6IziwjHx4+br25GFVdPA8mQEBk=', '3', 'yawcJlohYGV9SxX0W+MaWvjKRFvHwSn+2va1sa2HJBc='),
(22, 'operator2', 'akijq0fRGzIC8AmjjzzedYj6mGEg5vc6wClf7WJZjyw=', '2', 'rewENi7zY48et9+9miP5Yf9oICaHdzR2FklCyQ2ISJs='),
(26, 'bambi', 'xUEjeYwo59W4+gM+nSjS2ec2cpIZtjcA5fzJCGFP4pA=', '3', 'dVww2kLiGW+v1YVqjqWL2wWwicOXuNzuqKO9OaAmLhY=');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `kehadiran`
--
ALTER TABLE `kehadiran`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `event`
--
ALTER TABLE `event`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `kehadiran`
--
ALTER TABLE `kehadiran`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
