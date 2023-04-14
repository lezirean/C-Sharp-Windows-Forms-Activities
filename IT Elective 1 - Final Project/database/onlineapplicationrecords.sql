-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 21, 2023 at 03:57 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `onlineapplicationrecords`
--

-- --------------------------------------------------------

--
-- Table structure for table `records`
--

CREATE TABLE `records` (
  `id` int(11) NOT NULL,
  `fullName` varchar(100) NOT NULL,
  `studentNumber` varchar(50) NOT NULL,
  `yearLevelAndCourse` varchar(250) NOT NULL,
  `purposeOfRequest` varchar(100) NOT NULL,
  `requestedDocuments` text NOT NULL,
  `certifications` text DEFAULT NULL,
  `notes` text DEFAULT NULL,
  `dateToday` date DEFAULT NULL,
  `receiptNumber` varchar(7) DEFAULT NULL,
  `receiptDate` varchar(20) DEFAULT NULL,
  `receiptImage` longblob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `records`
--

INSERT INTO `records` (`id`, `fullName`, `studentNumber`, `yearLevelAndCourse`, `purposeOfRequest`, `requestedDocuments`, `certifications`, `notes`, `dateToday`, `receiptNumber`, `receiptDate`, `receiptImage`) VALUES
(11, 'Ms. Martha Alegro Reyes', '2021-00987-TG-1', 'Second Year, Bachelor of Science in Mechanical Engineering', 'Scholarship', '1. Certification\r\n', '1. Grades\r\n', 'N/A', '2023-02-20', '1234567', '02-20-2023', 0x53797374656d2e427974655b5d),
(12, 'Mr. John Santos Martinez', '2019-00873-TG-1', 'Fifth Year, Bachelor of Science in Business Administration major in Human Resource Management', 'Employment - Local', '1. Transcript of Records\r\n', '1. Not Applicable\r\n', 'N/A', '2023-02-20', NULL, NULL, NULL),
(13, 'Ms. Pearl Cruz Sta. Ana', '2020-00897-TG-1', 'Second Year, Bachelor of Science in Mechanical Engineering', 'For Evaluation Purposes/Personal Copy', '1. Correction in Student Information System\r\n', '1. Not Applicable\r\n', 'N/A', '2023-02-20', '1234567', '02-20-2023', 0x53797374656d2e427974655b5d);
--
-- Indexes for dumped tables
--

--
-- Indexes for table `records`
--
ALTER TABLE `records`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `records`
--
ALTER TABLE `records`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
