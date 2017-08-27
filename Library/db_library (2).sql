-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 22, 2017 at 05:15 AM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 7.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_library`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblattendance`
--

CREATE TABLE `tblattendance` (
  `Student_ID` int(11) NOT NULL,
  `Date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblauthors`
--

CREATE TABLE `tblauthors` (
  `Author_ID` int(11) NOT NULL,
  `Author_fName` varchar(30) NOT NULL,
  `Author_lName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblauthors`
--

INSERT INTO `tblauthors` (`Author_ID`, `Author_fName`, `Author_lName`) VALUES
(1, 'Author 1', 'Author 1 LNAME');

-- --------------------------------------------------------

--
-- Table structure for table `tblavailability`
--

CREATE TABLE `tblavailability` (
  `Book_ID` int(11) NOT NULL,
  `Quantity` int(4) NOT NULL,
  `Available_Books` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblavailability`
--

INSERT INTO `tblavailability` (`Book_ID`, `Quantity`, `Available_Books`) VALUES
(1, 5, 3);

-- --------------------------------------------------------

--
-- Table structure for table `tblbooks`
--

CREATE TABLE `tblbooks` (
  `Book_ID` int(11) NOT NULL,
  `Title` varchar(30) NOT NULL,
  `Author_ID` int(11) NOT NULL,
  `Year` int(4) NOT NULL,
  `No_Of_Pages` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Available_Books` int(11) NOT NULL,
  `Category_ID` int(11) NOT NULL,
  `Section_ID` int(11) NOT NULL,
  `Comments` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbooks`
--

INSERT INTO `tblbooks` (`Book_ID`, `Title`, `Author_ID`, `Year`, `No_Of_Pages`, `Quantity`, `Available_Books`, `Category_ID`, `Section_ID`, `Comments`) VALUES
(1, 'Tietl', 1, 1992, 300, 4, 4, 1, 1, 'no'),
(2, 'woaw', 1, 1923, 400, 4, 4, 1, 1, 'eh'),
(3, 'wow', 1, 1923, 405, 5, 5, 1, 1, 'eha');

-- --------------------------------------------------------

--
-- Table structure for table `tblbooksection`
--

CREATE TABLE `tblbooksection` (
  `Section_ID` int(11) NOT NULL,
  `Section` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbooksection`
--

INSERT INTO `tblbooksection` (`Section_ID`, `Section`) VALUES
(1, 'section 1');

-- --------------------------------------------------------

--
-- Table structure for table `tblborrowedbooks`
--

CREATE TABLE `tblborrowedbooks` (
  `ID` int(11) NOT NULL,
  `Book_ID` int(11) NOT NULL,
  `Student_ID` int(11) NOT NULL,
  `Date_Borrowed` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Date_Returned` datetime NOT NULL,
  `Date_Fined` datetime NOT NULL,
  `Fines` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblborrowedbooks`
--

INSERT INTO `tblborrowedbooks` (`ID`, `Book_ID`, `Student_ID`, `Date_Borrowed`, `Date_Returned`, `Date_Fined`, `Fines`) VALUES
(6, 1, 1, '2017-08-10 00:21:22', '2017-08-10 00:27:00', '2017-08-24 00:21:22', NULL),
(7, 1, 1, '2017-08-10 00:29:32', '2017-08-10 00:44:24', '2017-08-17 00:29:32', NULL),
(8, 1, 1, '2017-08-10 00:44:35', '2017-08-10 00:44:37', '2017-08-17 00:44:35', NULL),
(9, 1, 1, '2017-08-10 00:45:05', '2017-08-10 00:45:09', '2017-08-17 00:45:05', NULL),
(10, 1, 1, '2017-08-10 00:46:15', '2017-08-10 00:46:18', '2017-08-17 00:46:15', NULL),
(11, 3, 2, '2017-08-10 01:07:37', '2017-08-10 01:07:43', '2017-08-17 01:07:37', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tblcategories`
--

CREATE TABLE `tblcategories` (
  `Category_ID` int(11) NOT NULL,
  `Category` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcategories`
--

INSERT INTO `tblcategories` (`Category_ID`, `Category`) VALUES
(1, 'some category');

-- --------------------------------------------------------

--
-- Table structure for table `tblgrades`
--

CREATE TABLE `tblgrades` (
  `Grade_ID` int(11) NOT NULL,
  `Grade` int(3) DEFAULT NULL,
  `Student_Section` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblgrades`
--

INSERT INTO `tblgrades` (`Grade_ID`, `Grade`, `Student_Section`) VALUES
(1, 1, 'student section 1');

-- --------------------------------------------------------

--
-- Table structure for table `tbloverdue`
--

CREATE TABLE `tbloverdue` (
  `Book_ID` int(11) NOT NULL,
  `Student_ID` int(11) NOT NULL,
  `Fine` float NOT NULL,
  `Date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblstudents`
--

CREATE TABLE `tblstudents` (
  `Student_ID` int(10) NOT NULL,
  `Student_fName` varchar(40) NOT NULL,
  `Student_lName` varchar(30) NOT NULL,
  `Grade_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudents`
--

INSERT INTO `tblstudents` (`Student_ID`, `Student_fName`, `Student_lName`, `Grade_ID`) VALUES
(1, 'Yris', 'Lor', 1),
(2, 'Bob', 'Builder', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblattendance`
--
ALTER TABLE `tblattendance`
  ADD KEY `Student_ID` (`Student_ID`);

--
-- Indexes for table `tblauthors`
--
ALTER TABLE `tblauthors`
  ADD PRIMARY KEY (`Author_ID`);

--
-- Indexes for table `tblavailability`
--
ALTER TABLE `tblavailability`
  ADD KEY `fk_to_Book_ID` (`Book_ID`);

--
-- Indexes for table `tblbooks`
--
ALTER TABLE `tblbooks`
  ADD PRIMARY KEY (`Book_ID`),
  ADD KEY `fk_to_Author_ID` (`Author_ID`),
  ADD KEY `fk_to_Category_ID` (`Category_ID`),
  ADD KEY `fk_Section_ID` (`Section_ID`);

--
-- Indexes for table `tblbooksection`
--
ALTER TABLE `tblbooksection`
  ADD PRIMARY KEY (`Section_ID`);

--
-- Indexes for table `tblborrowedbooks`
--
ALTER TABLE `tblborrowedbooks`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_Student_ID` (`Student_ID`),
  ADD KEY `fk_Book_ID` (`Book_ID`);

--
-- Indexes for table `tblcategories`
--
ALTER TABLE `tblcategories`
  ADD PRIMARY KEY (`Category_ID`);

--
-- Indexes for table `tblgrades`
--
ALTER TABLE `tblgrades`
  ADD PRIMARY KEY (`Grade_ID`);

--
-- Indexes for table `tbloverdue`
--
ALTER TABLE `tbloverdue`
  ADD KEY `Student_ID` (`Student_ID`),
  ADD KEY `Book_ID` (`Book_ID`);

--
-- Indexes for table `tblstudents`
--
ALTER TABLE `tblstudents`
  ADD PRIMARY KEY (`Student_ID`),
  ADD KEY `fk_Grade_ID` (`Grade_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblauthors`
--
ALTER TABLE `tblauthors`
  MODIFY `Author_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tblbooks`
--
ALTER TABLE `tblbooks`
  MODIFY `Book_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tblbooksection`
--
ALTER TABLE `tblbooksection`
  MODIFY `Section_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tblborrowedbooks`
--
ALTER TABLE `tblborrowedbooks`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `tblcategories`
--
ALTER TABLE `tblcategories`
  MODIFY `Category_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tblgrades`
--
ALTER TABLE `tblgrades`
  MODIFY `Grade_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblattendance`
--
ALTER TABLE `tblattendance`
  ADD CONSTRAINT `tblattendance_ibfk_1` FOREIGN KEY (`Student_ID`) REFERENCES `tblstudents` (`Student_ID`);

--
-- Constraints for table `tblavailability`
--
ALTER TABLE `tblavailability`
  ADD CONSTRAINT `fk_to_Book_ID` FOREIGN KEY (`Book_ID`) REFERENCES `tblbooks` (`Book_ID`);

--
-- Constraints for table `tblbooks`
--
ALTER TABLE `tblbooks`
  ADD CONSTRAINT `fk_Section_ID` FOREIGN KEY (`Section_ID`) REFERENCES `tblbooksection` (`Section_ID`),
  ADD CONSTRAINT `fk_to_Author_ID` FOREIGN KEY (`Author_ID`) REFERENCES `tblauthors` (`Author_ID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_to_Category_ID` FOREIGN KEY (`Category_ID`) REFERENCES `tblcategories` (`Category_ID`);

--
-- Constraints for table `tblborrowedbooks`
--
ALTER TABLE `tblborrowedbooks`
  ADD CONSTRAINT `fk_Book_ID` FOREIGN KEY (`Book_ID`) REFERENCES `tblbooks` (`Book_ID`),
  ADD CONSTRAINT `fk_Student_ID` FOREIGN KEY (`Student_ID`) REFERENCES `tblstudents` (`Student_ID`);

--
-- Constraints for table `tbloverdue`
--
ALTER TABLE `tbloverdue`
  ADD CONSTRAINT `tbloverdue_ibfk_1` FOREIGN KEY (`Student_ID`) REFERENCES `tblstudents` (`Student_ID`),
  ADD CONSTRAINT `tbloverdue_ibfk_2` FOREIGN KEY (`Book_ID`) REFERENCES `tblbooks` (`Book_ID`);

--
-- Constraints for table `tblstudents`
--
ALTER TABLE `tblstudents`
  ADD CONSTRAINT `fk_Grade_ID` FOREIGN KEY (`Grade_ID`) REFERENCES `tblgrades` (`Grade_ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
