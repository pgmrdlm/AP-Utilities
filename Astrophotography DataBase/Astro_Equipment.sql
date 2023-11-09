--
-- File generated with SQLiteStudio v3.4.4 on Tue Oct 31 13:27:57 2023
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Astro_Equipment
CREATE TABLE IF NOT EXISTS Astro_Equipment (
    AE_Equipment_Id   NUMERIC (2) PRIMARY KEY,
    Equipment_Type_id INTEGER     REFERENCES Astro_Equipment_Constants (Equipment_Type_Id) ON DELETE SET NULL
                                                                                           ON UPDATE NO ACTION
                                                                                           MATCH SIMPLE,
    AE_Equipment_Name TEXT (100) 
);

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                1,
                                1,
                                'Modified Canon T3i ASP-C'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                3,
                                10,
                                'ZWO 30mm f/4 Mini Guide Scope,'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                2,
                                2,
                                'ZWO ASI120MM-S 1.2 MP CMOS'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                7,
                                9,
                                'Canon 300mm F4.5'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                6,
                                9,
                                'Canon Lens:  EF 50mm'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                5,
                                9,
                                'Sigma Lens: EF 150-600mm'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                4,
                                3,
                                'Celestron Advanced GT'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                8,
                                8,
                                'Optolong Canon EOS-C L-Enhance Dual Narrowband Light Pollution Filter (H-Alpha and H-Beta/O-III)'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                9,
                                4,
                                'MSI Laptop - Windows 11 Home - 16g Memory - NIVIDA GeForce RTX 3060 Laptop GPU'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                10,
                                4,
                                'Lenova Laptop - Windows 10 Pro'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                12,
                                6,
                                'N.I.N.A. for Windows'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                11,
                                11,
                                'PHD2 for Windows'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                13,
                                7,
                                'Pixinsight for Windows'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                14,
                                7,
                                'Sirill for Windows'
                            );

INSERT INTO Astro_Equipment (
                                AE_Equipment_Id,
                                Equipment_Type_id,
                                AE_Equipment_Name
                            )
                            VALUES (
                                15,
                                8,
                                'No Filter'
                            );


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
