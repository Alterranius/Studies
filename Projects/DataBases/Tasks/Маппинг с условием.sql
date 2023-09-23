CREATE TABLE zps 
(
zp_id serial PRIMARY KEY,
zp real,
yzp int
);
/**/
INSERT INTO zps (zp, yzp)
VALUES
(10000, 35),
(15000, 72),
(13000, 76),
(14000, 78),
(1000, 1),
(100000, 15);
/**/
DROP FUNCTION correct_zp;
CREATE OR REPLACE FUNCTION correct_zp(in y int DEFAULT 70) RETURNS TABLE (zp real) AS 
$$
	UPDATE zps
	SET zp = (zp * 1.15)
	WHERE zps.yzp <= y;
--
	SELECT zp FROM zps
	WHERE zps.yzp <= y;


$$ LANGUAGE sql;
/**/
SELECT correct_zp();
--y=71
/*
все yzp из таблицы zps, которые меньше 71, будут увеличены на 15 процентов.
Те yzp, которые больше 71, не будут затронуты 
*/
/**/
SELECT * FROM zps;
SELECT * 
INTO zps_old
FROm zps;
SELECT * FROM zps_old;

SELECT zps_old.zp AS old_zp, zps_old.yzp AS old_yzp, zps.zp, zps.yzp, zps.zp_id
FROM zps
JOIN zps_old ON zps.zp_id = zps_old.zp_id
ORDER BY zps.zp_id;
