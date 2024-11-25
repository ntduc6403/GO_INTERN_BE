Create Database GO_TEST
Use GO_TEST
GO

Create table Scores(
	sbd VARCHAR(50) PRIMARY KEY,
    toan FLOAT NULL,
    ngu_van FLOAT NULL,
    ngoai_ngu FLOAT NULL,
    vat_li FLOAT NULL,
    hoa_hoc FLOAT NULL,
    sinh_hoc FLOAT NULL,
    lich_su FLOAT NULL,
    dia_li FLOAT NULL,
    gdcd FLOAT NULL,
    ma_ngoai_ngu VARCHAR(50) NULL
);


-- Insert data
INSERT INTO Scores (sbd, toan, ngu_van, ngoai_ngu, vat_li, hoa_hoc, sinh_hoc, lich_su, dia_li, gdcd, ma_ngoai_ngu) VALUES
('01000001', 8.4, 6.75, 8.0, 6.0, 5.25, 5.0, NULL, NULL, NULL, 'N1'),
('01000002', 8.6, 8.5, 7.2, NULL, NULL, NULL, 7.25, 6.0, 8.0, 'N1'),
('01000003', 8.2, 8.75, 8.2, NULL, NULL, NULL, 7.25, 7.25, 8.75, 'N1'),
('01000004', 4.8, 8.5, 7.4, NULL, NULL, NULL, 7.0, 6.0, 7.5, 'N1'),
('01000005', 8.6, 9.0, 7.8, NULL, NULL, NULL, 9.0, 8.75, 8.5, 'N1'),
('01000006', 5.8, 8.75, 7.8, NULL, NULL, NULL, 7.75, 6.75, 7.5, 'N1'),
('01000007', 6.0, 7.5, NULL, NULL, NULL, NULL, 6.75, 7.0, 7.0, NULL),
('01000008', 8.2, 9.0, 9.0, NULL, NULL, NULL, 8.0, 8.25, 10.0, 'N1'),
('01000009', 8.2, 8.0, 8.6, 8.25, 4.25, NULL, 6.0, NULL, NULL, 'N1'),
('01000010', 7.4, 9.0, 9.6, NULL, NULL, NULL, 8.25, 6.5, 8.25, 'N1'),
('01000011', 7.2, 8.5, 9.0, 7.75, 6.75, NULL, 6.25, NULL, NULL, 'N1'),
('01000012', 8.2, 8.0, 8.2, NULL, NULL, NULL, 7.75, 9.5, 9.0, 'N1'),
('01000013', 5.2, 8.0, 8.6, NULL, NULL, NULL, 7.5, 5.75, 8.0, 'N1'),
('01000014', 7.6, 9.0, 7.4, NULL, NULL, NULL, 7.25, 7.5, 7.5, 'N1'),
('01000015', 7.6, 9.0, 7.6, NULL, NULL, NULL, 7.75, 8.5, 8.75, 'N1'),
('01000016', 6.0, 5.75, 6.8, NULL, NULL, NULL, 7.75, 7.0, 7.75, 'N1'),
('01000017', 7.0, 8.75, 7.8, 3.75, 7.5, NULL, 7.25, NULL, NULL, 'N1'),
('01000018', 8.2, 6.0, 9.0, 7.75, 6.75, NULL, 6.75, NULL, NULL, 'N1'),
('01000019', 2.8, 4.25, NULL, NULL, NULL, NULL, 5.75, 7.0, NULL, NULL),
('01000020', 7.6, 8.5, 9.2, NULL, NULL, NULL, 7.0, 8.0, 7.75, 'N1'),
('01000021', 8.4, 8.5, 8.6, 2.5, 8.75, NULL, 7.75, NULL, NULL, 'N1'),
('01000022', NULL, 4.25, NULL, NULL, NULL, NULL, 5.75, 6.25, NULL, NULL),
('01000023', 8.8, 9.25, 8.8, 8.5, 6.5, NULL, 7.0, NULL, NULL, 'N1'),
('01000024', 8.4, 9.5, 8.8, NULL, NULL, NULL, 7.25, 8.75, 8.25, 'N1'),
('01000025', 7.8, 9.25, 8.4, NULL, NULL, NULL, 7.0, 7.5, 7.75, 'N1'),
('01000026', 7.2, 8.25, NULL, 7.5, 8.75, 8.75, NULL, NULL, NULL, NULL),
('01000027', 8.2, 8.75, 8.0, 6.25, 9.0, NULL, 5.75, NULL, NULL, 'N1'),
('01000028', 8.8, 8.5, 9.0, NULL, NULL, NULL, 8.25, 8.5, 8.75, 'N1');



