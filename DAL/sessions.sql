-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: localhost
-- Thời gian đã tạo: Th8 30, 2024 lúc 09:51 AM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `NoiThat`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sessions`
--

CREATE TABLE `sessions` (
  `id` varchar(255) NOT NULL,
  `user_id` bigint(20) UNSIGNED DEFAULT NULL,
  `ip_address` varchar(45) DEFAULT NULL,
  `user_agent` text DEFAULT NULL,
  `payload` longtext NOT NULL,
  `last_activity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `sessions`
--

INSERT INTO `sessions` (`id`, `user_id`, `ip_address`, `user_agent`, `payload`, `last_activity`) VALUES
('YIExJHsomJoxBXJ13LzyIZIxEQgDAhqaBSBwPVV9', 5, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/128.0.0.0 Safari/537.36', 'YToxMDp7czo2OiJfdG9rZW4iO3M6NDA6ImJ1QzNVbEhNWE4wcVpJTE9NN1k2Y2R4eEVCeE9pc09TeGFETEk4Uk0iO3M6NjoiX2ZsYXNoIjthOjI6e3M6Mzoib2xkIjthOjA6e31zOjM6Im5ldyI7YTowOnt9fXM6OToiX3ByZXZpb3VzIjthOjE6e3M6MzoidXJsIjtzOjM5OiJodHRwOi8vcXVhbmx5bm9pdGhhdC52bi9hZG1pbi9hdHRyaWJ1dGUiO31zOjUwOiJsb2dpbl93ZWJfNTliYTM2YWRkYzJiMmY5NDAxNTgwZjAxNGM3ZjU4ZWE0ZTMwOTg5ZCI7aTo1O3M6NDM6InByb2R1Y3RfZjUyODc2NGQ2MjRkYjEyOWIzMmMyMWZiY2EwY2I4ZDZfMjciO2k6MTcyNDkwNTEzMztzOjQ6ImNhcnQiO2E6MDp7fXM6NDM6InByb2R1Y3RfZjUyODc2NGQ2MjRkYjEyOWIzMmMyMWZiY2EwY2I4ZDZfMjkiO2k6MTcyNDkwNTk5OTtzOjQzOiJwcm9kdWN0X2Y1Mjg3NjRkNjI0ZGIxMjliMzJjMjFmYmNhMGNiOGQ2XzMzIjtpOjE3MjQ5MDY1MzI7czo0MzoicHJvZHVjdF9mNTI4NzY0ZDYyNGRiMTI5YjMyYzIxZmJjYTBjYjhkNl8xMyI7aToxNzI0OTA2NTQwO3M6NTM6ImxvZ2luX2FkbWluc181OWJhMzZhZGRjMmIyZjk0MDE1ODBmMDE0YzdmNThlYTRlMzA5ODlkIjtpOjE7fQ==', 1724913211),
('5FwAI4LRQBk4Okb6DEl5e6RAIIRID82PHp5QM6Fz', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/128.0.0.0 Safari/537.36', 'YTo0OntzOjY6Il90b2tlbiI7czo0MDoiRERrcndSaFdUMHBvQjRyWFl0SkV2eFh4Z1J0bXhxVFgxdEQzMlQwSiI7czo2OiJfZmxhc2giO2E6Mjp7czozOiJvbGQiO2E6MDp7fXM6MzoibmV3IjthOjA6e319czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6NDA6Imh0dHA6Ly9xdWFubHlub2l0aGF0LnZuL2FkbWluL2F0dHJpYnV0ZXMiO31zOjUzOiJsb2dpbl9hZG1pbnNfNTliYTM2YWRkYzJiMmY5NDAxNTgwZjAxNGM3ZjU4ZWE0ZTMwOTg5ZCI7aToxO30=', 1724942731),
('stASZDRqr9bLBWLrY24LcYKFvohGybPhrSDIMdvk', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/128.0.0.0 Safari/537.36', 'YTo0OntzOjY6Il90b2tlbiI7czo0MDoieXR4Yzh2SHZld2thVUg4cDNUVUxLamZ6RUx2TFBTelhPd1kySUFzMiI7czo2OiJfZmxhc2giO2E6Mjp7czozOiJvbGQiO2E6MDp7fXM6MzoibmV3IjthOjA6e319czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6NzI6Imh0dHA6Ly9xdWFubHlub2l0aGF0LnZuL3Nhbi1waGFtL3NvZmEtZ2l1b25nLXRob25nLW1pbmgtdGF5LXZhdC1zZi01Ny0xNCI7fXM6NDM6InByb2R1Y3RfZjUyODc2NGQ2MjRkYjEyOWIzMmMyMWZiY2EwY2I4ZDZfMTQiO2k6MTcyNDk4MDI2NTt9', 1724980266),
('I4DqG6zJkrT9IiUOVJgSiEDXYgoHXCTzu6BV7lo3', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/128.0.0.0 Safari/537.36', 'YTozOntzOjY6Il90b2tlbiI7czo0MDoiNHg3VE5ONnpSY2pVRHNDOEhmZWhnMU50ZmZya21BbGpERE1KNU9zeCI7czo2OiJfZmxhc2giO2E6Mjp7czozOiJvbGQiO2E6MDp7fXM6MzoibmV3IjthOjA6e319czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6NDY6Imh0dHA6Ly9xdWFubHlub2l0aGF0LnZuL3Nhbi1waGFtP2s9R2glRTElQkElQkYiO319', 1725004233);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;