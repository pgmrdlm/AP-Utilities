--
-- File generated with SQLiteStudio v3.4.4 on Tue Oct 31 13:29:08 2023
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Moon_Illumination
CREATE TABLE IF NOT EXISTS Moon_Illumination (
    MI_CCYYMMDD             TEXT (8),
    MI_Illumination_Percent TEXT (5),
    PRIMARY KEY (
        MI_CCYYMMDD
    )
    ON CONFLICT ROLLBACK
);

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230101',
                                  '0.72'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230102',
                                  '0.8'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230103',
                                  '0.88'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230104',
                                  '0.93'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230105',
                                  '0.97'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230106',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230107',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230108',
                                  '0.98'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230109',
                                  '0.95'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230110',
                                  '0.91'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230111',
                                  '0.85'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230112',
                                  '0.77'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230113',
                                  '0.69'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230114',
                                  '0.59'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230115',
                                  '0.49'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230116',
                                  '0.38'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230117',
                                  '0.28'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230118',
                                  '0.19'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230119',
                                  '0.11'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230120',
                                  '0.04'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230121',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230122',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230123',
                                  '0.03'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230124',
                                  '0.08'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230125',
                                  '0.16'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230126',
                                  '0.25'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230127',
                                  '0.35'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230128',
                                  '0.46'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230129',
                                  '0.56'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230130',
                                  '0.66'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230201',
                                  '0.82'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230202',
                                  '0.89'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230203',
                                  '0.94'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230204',
                                  '0.98'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230205',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230206',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230207',
                                  '0.98'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230208',
                                  '0.95'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230209',
                                  '0.89'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230210',
                                  '0.83'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230211',
                                  '0.75'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230212',
                                  '0.65'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230213',
                                  '0.55'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230214',
                                  '0.44'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230215',
                                  '0.33'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230216',
                                  '0.23'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230217',
                                  '0.14'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230218',
                                  '0.07'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230219',
                                  '0.02'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230220',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230221',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230222',
                                  '0.05'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230223',
                                  '0.12'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230224',
                                  '0.2'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230225',
                                  '0.29'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230226',
                                  '0.39'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230227',
                                  '0.49'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230228',
                                  '0.59'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230229',
                                  '----'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230230',
                                  '----'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230231',
                                  '----'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230301',
                                  '0.68'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230302',
                                  '0.76'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230303',
                                  '0.84'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230304',
                                  '0.9'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230305',
                                  '0.95'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230306',
                                  '0.98'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230307',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230308',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230309',
                                  '0.97'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230310',
                                  '0.93'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230311',
                                  '0.87'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230312',
                                  '0.79'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230313',
                                  '0.7'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230314',
                                  '0.6'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230315',
                                  '0.49'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230316',
                                  '0.38'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230317',
                                  '0.27'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230318',
                                  '0.17'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230319',
                                  '0.09'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230320',
                                  '0.03'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230321',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230322',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230323',
                                  '0.03'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230324',
                                  '0.08'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230325',
                                  '0.15'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230326',
                                  '0.23'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230327',
                                  '0.32'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230328',
                                  '0.41'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230329',
                                  '0.51'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230330',
                                  '0.61'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230331',
                                  '0.7'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230401',
                                  '0.78'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230402',
                                  '0.85'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230403',
                                  '0.91'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230404',
                                  '0.96'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230405',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230406',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230407',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230408',
                                  '0.96'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230409',
                                  '0.9'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230410',
                                  '0.83'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230411',
                                  '0.74'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230412',
                                  '0.63'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230413',
                                  '0.52'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230414',
                                  '0.41'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230415',
                                  '0.3'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230416',
                                  '0.2'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230417',
                                  '0.11'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230418',
                                  '0.05'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230419',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230420',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230421',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230422',
                                  '0.05'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230423',
                                  '0.1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230424',
                                  '0.17'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230425',
                                  '0.25'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230426',
                                  '0.34'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230427',
                                  '0.44'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230428',
                                  '0.53'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230429',
                                  '0.63'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230430',
                                  '0.71'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230431',
                                  '----'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230501',
                                  '0.8'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230502',
                                  '0.87'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230503',
                                  '0.93'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230504',
                                  '0.97'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230505',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230506',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230507',
                                  '0.97'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230508',
                                  '0.92'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230509',
                                  '0.85'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230510',
                                  '0.76'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230511',
                                  '0.66'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230512',
                                  '0.55'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230513',
                                  '0.43'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230514',
                                  '0.32'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230515',
                                  '0.22'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230516',
                                  '0.13'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230517',
                                  '0.07'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230518',
                                  '0.02'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230519',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230520',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230521',
                                  '0.03'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230522',
                                  '0.07'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230523',
                                  '0.13'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230524',
                                  '0.2'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230525',
                                  '0.28'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230526',
                                  '0.37'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230527',
                                  '0.46'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230528',
                                  '0.56'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230529',
                                  '0.65'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230530',
                                  '0.74'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230531',
                                  '0.82'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230601',
                                  '0.9'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230602',
                                  '0.95'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230603',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230604',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230605',
                                  '0.98'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230606',
                                  '0.94'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230607',
                                  '0.87'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230608',
                                  '0.79'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230609',
                                  '0.68'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230610',
                                  '0.57'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230611',
                                  '0.46'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230612',
                                  '0.35'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230613',
                                  '0.25'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230614',
                                  '0.16'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230615',
                                  '0.09'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230616',
                                  '0.04'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230617',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230618',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230619',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230620',
                                  '0.04'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230621',
                                  '0.09'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230622',
                                  '0.15'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230623',
                                  '0.22'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230624',
                                  '0.3'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230625',
                                  '0.39'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230626',
                                  '0.49'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230627',
                                  '0.59'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230628',
                                  '0.69'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230629',
                                  '0.78'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230630',
                                  '0.86'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230631',
                                  '----'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230701',
                                  '0.93'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230702',
                                  '0.98'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230703',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230704',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230705',
                                  '0.95'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230706',
                                  '0.89'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230707',
                                  '0.81'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230708',
                                  '0.71'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230709',
                                  '0.6'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230710',
                                  '0.49'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230711',
                                  '0.38'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230712',
                                  '0.28'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230713',
                                  '0.19'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230714',
                                  '0.12'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230715',
                                  '0.06'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230716',
                                  '0.02'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230717',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230718',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230719',
                                  '0.02'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230720',
                                  '0.06'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230721',
                                  '0.11'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230722',
                                  '0.17'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230723',
                                  '0.25'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230724',
                                  '0.33'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230725',
                                  '0.43'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230726',
                                  '0.53'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230727',
                                  '0.63'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230728',
                                  '0.73'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230729',
                                  '0.83'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230730',
                                  '0.9'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230731',
                                  '0.96'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230801',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230802',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230803',
                                  '0.97'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230804',
                                  '0.91'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230805',
                                  '0.83'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230806',
                                  '0.74'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230807',
                                  '0.63'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230808',
                                  '0.53'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230809',
                                  '0.42'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230810',
                                  '0.32'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230811',
                                  '0.23'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230812',
                                  '0.16'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230813',
                                  '0.09'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230814',
                                  '0.05'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230815',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230816',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230817',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230818',
                                  '0.03'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230819',
                                  '0.07'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230820',
                                  '0.13'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230821',
                                  '0.2'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230822',
                                  '0.28'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230823',
                                  '0.38'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230824',
                                  '0.48'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230825',
                                  '0.59'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230826',
                                  '0.69'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230827',
                                  '0.79'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230828',
                                  '0.88'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230829',
                                  '0.95'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230830',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230831',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230901',
                                  '0.98'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230902',
                                  '0.93'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230903',
                                  '0.86'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230904',
                                  '0.78'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230905',
                                  '0.68'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230906',
                                  '0.58'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230907',
                                  '0.47'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230908',
                                  '0.37'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230909',
                                  '0.28'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230910',
                                  '0.2'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230911',
                                  '0.13'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230912',
                                  '0.07'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230913',
                                  '0.03'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230914',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230915',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230916',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230917',
                                  '0.04'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230918',
                                  '0.09'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230919',
                                  '0.16'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230920',
                                  '0.24'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230921',
                                  '0.33'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230922',
                                  '0.44'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230923',
                                  '0.54'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230924',
                                  '0.66'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230925',
                                  '0.76'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230926',
                                  '0.85'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230927',
                                  '0.93'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230928',
                                  '0.98'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230929',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230930',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20230931',
                                  '----'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231001',
                                  '0.96'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231002',
                                  '0.9'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231003',
                                  '0.82'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231004',
                                  '0.73'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231005',
                                  '0.64'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231006',
                                  '0.54'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231007',
                                  '0.44'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231008',
                                  '0.35'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231009',
                                  '0.26'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231010',
                                  '0.18'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231011',
                                  '0.11'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231012',
                                  '0.06'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231013',
                                  '0.02'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231014',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231015',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231016',
                                  '0.02'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231017',
                                  '0.06'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231018',
                                  '0.12'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231019',
                                  '0.2'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231020',
                                  '0.29'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231021',
                                  '0.4'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231022',
                                  '0.51'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231023',
                                  '0.62'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231024',
                                  '0.73'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231025',
                                  '0.83'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231026',
                                  '0.91'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231027',
                                  '0.96'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231028',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231029',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231030',
                                  '0.98'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231031',
                                  '0.93'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231101',
                                  '0.87'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231102',
                                  '0.79'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231103',
                                  '0.7'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231104',
                                  '0.61'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231105',
                                  '0.52'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231106',
                                  '0.42'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231107',
                                  '0.33'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231108',
                                  '0.24'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231109',
                                  '0.17'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231110',
                                  '0.1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231111',
                                  '0.05'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231112',
                                  '0.02'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231113',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231114',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231115',
                                  '0.04'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231116',
                                  '0.09'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231117',
                                  '0.17'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231118',
                                  '0.26'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231119',
                                  '0.36'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231120',
                                  '0.47'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231121',
                                  '0.59'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231122',
                                  '0.7'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231123',
                                  '0.8'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231124',
                                  '0.88'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231125',
                                  '0.94'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231126',
                                  '0.98'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231127',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231128',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231129',
                                  '0.96'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231130',
                                  '0.91'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231131',
                                  '----'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231201',
                                  '0.85'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231202',
                                  '0.77'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231203',
                                  '0.69'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231204',
                                  '0.6'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231205',
                                  '0.5'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231206',
                                  '0.41'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231207',
                                  '0.32'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231208',
                                  '0.23'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231209',
                                  '0.15'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231210',
                                  '0.09'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231211',
                                  '0.04'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231212',
                                  '0.01'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231213',
                                  '0'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231214',
                                  '0.02'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231215',
                                  '0.07'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231216',
                                  '0.13'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231217',
                                  '0.22'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231218',
                                  '0.33'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231219',
                                  '0.44'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231220',
                                  '0.55'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231221',
                                  '0.66'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231222',
                                  '0.76'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231223',
                                  '0.85'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231224',
                                  '0.91'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231225',
                                  '0.96'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231226',
                                  '0.99'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231227',
                                  '1'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231228',
                                  '0.98'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231229',
                                  '0.95'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231230',
                                  '0.9'
                              );

INSERT INTO Moon_Illumination (
                                  MI_CCYYMMDD,
                                  MI_Illumination_Percent
                              )
                              VALUES (
                                  '20231231',
                                  '0.84'
                              );


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
