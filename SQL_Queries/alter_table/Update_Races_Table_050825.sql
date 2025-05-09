-- ✅ 1. Drop unnecessary columns
ALTER TABLE Races
DROP COLUMN Languages;

ALTER TABLE Races
DROP COLUMN RacialFeatures;

-- ✅ 2. Rename Speed → RaceSpeed (SQL Server syntax)
EXEC sp_rename 'Races.Speed', 'RaceSpeed', 'COLUMN';

-- ✅ 3. Add new column for RaceCreatureType
ALTER TABLE Races
ADD RaceCreatureType NVARCHAR(50) NOT NULL DEFAULT 'Humanoid';
