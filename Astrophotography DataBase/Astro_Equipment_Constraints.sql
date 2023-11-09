--
-- File generated with SQLiteStudio v3.4.4 on Tue Oct 31 13:28:31 2023
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Astro_Equipment_Constants
CREATE TABLE IF NOT EXISTS Astro_Equipment_Constants (
    Equipment_Type_Id       INTEGER NOT NULL
                                    UNIQUE,
    AEC_Equipment_Type_Desc TEXT    UNIQUE,
    PRIMARY KEY (
        Equipment_Type_Id AUTOINCREMENT
    )
);

INSERT INTO Astro_Equipment_Constants (
                                          Equipment_Type_Id,
                                          AEC_Equipment_Type_Desc
                                      )
                                      VALUES (
                                          1,
                                          'Image Camera'
                                      );

INSERT INTO Astro_Equipment_Constants (
                                          Equipment_Type_Id,
                                          AEC_Equipment_Type_Desc
                                      )
                                      VALUES (
                                          2,
                                          'Guide Camera'
                                      );

INSERT INTO Astro_Equipment_Constants (
                                          Equipment_Type_Id,
                                          AEC_Equipment_Type_Desc
                                      )
                                      VALUES (
                                          3,
                                          'Telescope Mount'
                                      );

INSERT INTO Astro_Equipment_Constants (
                                          Equipment_Type_Id,
                                          AEC_Equipment_Type_Desc
                                      )
                                      VALUES (
                                          4,
                                          'Image Caputure Computer'
                                      );

INSERT INTO Astro_Equipment_Constants (
                                          Equipment_Type_Id,
                                          AEC_Equipment_Type_Desc
                                      )
                                      VALUES (
                                          5,
                                          'Image Edit Computer'
                                      );

INSERT INTO Astro_Equipment_Constants (
                                          Equipment_Type_Id,
                                          AEC_Equipment_Type_Desc
                                      )
                                      VALUES (
                                          6,
                                          'Image Capture Software'
                                      );

INSERT INTO Astro_Equipment_Constants (
                                          Equipment_Type_Id,
                                          AEC_Equipment_Type_Desc
                                      )
                                      VALUES (
                                          7,
                                          'Image Edit Software'
                                      );

INSERT INTO Astro_Equipment_Constants (
                                          Equipment_Type_Id,
                                          AEC_Equipment_Type_Desc
                                      )
                                      VALUES (
                                          8,
                                          'Image Camera Filter'
                                      );

INSERT INTO Astro_Equipment_Constants (
                                          Equipment_Type_Id,
                                          AEC_Equipment_Type_Desc
                                      )
                                      VALUES (
                                          9,
                                          'Image Telescope or Camera Lens'
                                      );

INSERT INTO Astro_Equipment_Constants (
                                          Equipment_Type_Id,
                                          AEC_Equipment_Type_Desc
                                      )
                                      VALUES (
                                          10,
                                          'Guide Telescope'
                                      );

INSERT INTO Astro_Equipment_Constants (
                                          Equipment_Type_Id,
                                          AEC_Equipment_Type_Desc
                                      )
                                      VALUES (
                                          11,
                                          'Guide Software'
                                      );


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
