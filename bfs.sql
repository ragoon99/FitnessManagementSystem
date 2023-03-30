-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 27, 2023 at 02:52 PM
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
-- Database: `bfs`
--

-- --------------------------------------------------------

--
-- Table structure for table `admininfo`
--

CREATE TABLE `admininfo` (
  `id` bigint(255) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admininfo`
--

INSERT INTO `admininfo` (`id`, `email`, `password`) VALUES
(1, 'admin@gmail.com', 'admin'),
(2, 'sys@gmail.com', 'system');

-- --------------------------------------------------------

--
-- Table structure for table `client_billing`
--

CREATE TABLE `client_billing` (
  `billing_id` bigint(255) NOT NULL,
  `client_id` bigint(255) NOT NULL,
  `billing_date` date NOT NULL DEFAULT current_timestamp(),
  `total_cost` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `client_info`
--

CREATE TABLE `client_info` (
  `id` bigint(255) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `dob` date NOT NULL,
  `current_weight(kg)` double NOT NULL,
  `target_weight(kg)` double NOT NULL,
  `registration_date` date DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `client_info`
--

INSERT INTO `client_info` (`id`, `fname`, `lname`, `address`, `gender`, `dob`, `current_weight(kg)`, `target_weight(kg)`, `registration_date`) VALUES
(4, 'Tommy', 'Johnson', 'Atlanta', 'Male', '2000-11-26', 75, 70, NULL),
(5, 'Jimmy', 'Neutron', 'Metro', 'Male', '1996-03-08', 50.6, 60, NULL),
(6, 'Mike', 'Johnson', 'New York', 'Male', '1983-03-23', 86.3, 70, NULL),
(7, 'Tiffiny', 'Scarlet', 'Las Vegas', 'Female', '1973-03-09', 72.9, 60, NULL),
(8, 'Peter', 'Griffin', 'Townsville', 'Male', '1975-03-21', 95.8, 70, NULL),
(9, 'Louis', 'Griffin', 'Townsville', 'Female', '1976-03-09', 71.2, 55, NULL),
(14, 'Dipen', 'Bantawa', 'asda', 'Male', '2023-03-27', 55, 45, '2023-03-27');

-- --------------------------------------------------------

--
-- Table structure for table `client_optionalsubscriptions`
--

CREATE TABLE `client_optionalsubscriptions` (
  `plan_id` bigint(255) NOT NULL,
  `client_id` bigint(255) NOT NULL,
  `start_date` datetime NOT NULL DEFAULT current_timestamp(),
  `end_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `client_optionalsubscriptions`
--

INSERT INTO `client_optionalsubscriptions` (`plan_id`, `client_id`, `start_date`, `end_date`) VALUES
(1, 9, '2023-03-27 18:01:26', '2023-04-01');

-- --------------------------------------------------------

--
-- Table structure for table `client_subscriptions`
--

CREATE TABLE `client_subscriptions` (
  `plan_id` bigint(255) NOT NULL,
  `subscription_id` bigint(255) NOT NULL,
  `client_id` bigint(255) NOT NULL,
  `start_date` date NOT NULL DEFAULT current_timestamp(),
  `end_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `client_subscriptions`
--

INSERT INTO `client_subscriptions` (`plan_id`, `subscription_id`, `client_id`, `start_date`, `end_date`) VALUES
(1, 1, 5, '2023-03-27', '2023-04-01'),
(1, 3, 9, '2023-03-27', '0000-00-00'),
(1, 4, 9, '2023-03-27', '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `traningplan`
--

CREATE TABLE `traningplan` (
  `plan_id` bigint(255) NOT NULL,
  `plan_name` varchar(50) DEFAULT NULL,
  `session` int(11) DEFAULT NULL,
  `paymentType` varchar(50) DEFAULT NULL,
  `cost` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `traningplan`
--

INSERT INTO `traningplan` (`plan_id`, `plan_name`, `session`, `paymentType`, `cost`) VALUES
(1, 'Beginner', 2, 'Weekly', 1000),
(2, 'Intermediate', 3, 'Weekly', 2000),
(3, 'Elite', 5, 'Weekly', 3000);

-- --------------------------------------------------------

--
-- Table structure for table `traningplan_optional`
--

CREATE TABLE `traningplan_optional` (
  `plan_id` bigint(255) NOT NULL,
  `plan_name` varchar(50) NOT NULL,
  `cost` double DEFAULT NULL,
  `paymentType` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `traningplan_optional`
--

INSERT INTO `traningplan_optional` (`plan_id`, `plan_name`, `cost`, `paymentType`) VALUES
(1, 'Private Trainer', 500, 'Hourly'),
(2, 'Sauna', 1500, 'Session'),
(3, 'Swimming', 500, 'Session');

-- --------------------------------------------------------

--
-- Table structure for table `userinfo`
--

CREATE TABLE `userinfo` (
  `id` bigint(255) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `userinfo`
--

INSERT INTO `userinfo` (`id`, `email`, `password`) VALUES
(4, 'timmy@gmail.com', 'tim'),
(5, 'johnny@gmail.com', 'john'),
(8, 'pete@gmail.com', 'peter'),
(9, 'louis@gmail.com', 'louis'),
(0, 'asdasd', 'asd'),
(0, 'asdas', 'asdasd');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admininfo`
--
ALTER TABLE `admininfo`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `client_billing`
--
ALTER TABLE `client_billing`
  ADD PRIMARY KEY (`billing_id`),
  ADD KEY `client_id` (`client_id`);

--
-- Indexes for table `client_info`
--
ALTER TABLE `client_info`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `client_subscriptions`
--
ALTER TABLE `client_subscriptions`
  ADD PRIMARY KEY (`subscription_id`),
  ADD KEY `client_id` (`client_id`),
  ADD KEY `plan_id` (`plan_id`);

--
-- Indexes for table `traningplan`
--
ALTER TABLE `traningplan`
  ADD PRIMARY KEY (`plan_id`);

--
-- Indexes for table `traningplan_optional`
--
ALTER TABLE `traningplan_optional`
  ADD PRIMARY KEY (`plan_id`);

--
-- Indexes for table `userinfo`
--
ALTER TABLE `userinfo`
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admininfo`
--
ALTER TABLE `admininfo`
  MODIFY `id` bigint(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `client_billing`
--
ALTER TABLE `client_billing`
  MODIFY `billing_id` bigint(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `client_info`
--
ALTER TABLE `client_info`
  MODIFY `id` bigint(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `client_subscriptions`
--
ALTER TABLE `client_subscriptions`
  MODIFY `subscription_id` bigint(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `traningplan`
--
ALTER TABLE `traningplan`
  MODIFY `plan_id` bigint(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `traningplan_optional`
--
ALTER TABLE `traningplan_optional`
  MODIFY `plan_id` bigint(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `client_billing`
--
ALTER TABLE `client_billing`
  ADD CONSTRAINT `client_billing_ibfk_1` FOREIGN KEY (`client_id`) REFERENCES `client_info` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `client_subscriptions`
--
ALTER TABLE `client_subscriptions`
  ADD CONSTRAINT `client_subscriptions_ibfk_1` FOREIGN KEY (`client_id`) REFERENCES `client_info` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `client_subscriptions_ibfk_2` FOREIGN KEY (`plan_id`) REFERENCES `traningplan` (`plan_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
