using Newtonsoft.Json;

namespace Backend
{
    public class CharacterMapper
    {
        private int SafeInt(object value) => value == DBNull.Value ? 0 : Convert.ToInt32(value);
        private string SafeString(object value) => value == DBNull.Value ? null : value.ToString();
        private List<string> SafeList(object value) => value != DBNull.Value ? ParseList(value.ToString()) : new List<string>();


        /************************************************************************/
        /*MAIN METHODS*/
        /************************************************************************/

        // Converts raw database rows into a list of Character objects
        public List<Character> MapToCharacterClass(List<Dictionary<string, object>> dataDictionaryRows)
        {
            var characters = new List<Character>();

            foreach (var row in dataDictionaryRows)
            {
                try
                {
                    var character = new Character
                    {
                        CharacterID = SafeInt(row["CharacterID"]),
                        Name = SafeString(row["Name"]),
                        Sex = SafeString(row["Sex"]),
                        ClassID = SafeInt(row["ClassID"]),
                        RaceID = SafeInt(row["RaceID"]),
                        AbilityID = SafeInt(row["AbilityID"]),
                        SubclassID = SafeInt(row["SubclassID"]),
                        Equipment = ParseList(SafeString(row["Equipment"])),
                        Background = SafeString(row["Background"]),
                        Alignment = SafeString(row["Alignment"]),
                        Level = SafeInt(row["Level"]),
                        HP = SafeInt(row["HP"]),
                        MaxHP = SafeInt(row["MaxHP"]),
                        TempHP = SafeInt(row["TempHP"]),
                        Speed = SafeInt(row["Speed"]),
                        AC = SafeInt(row["AC"]),
                        InitiativeBonus = SafeInt(row["InitiativeBonus"]),
                        ExperiencePoints = SafeInt(row["ExperiencePoints"]),
                        FeaturesAndTraits = ParseList(SafeString(row["FeaturesAndTraits"])),
                        PassivePerception = SafeInt(row["PassivePerception"]),
                        PassiveInsight = SafeInt(row["PassiveInsight"]),
                        PassiveInvestigation = SafeInt(row["PassiveInvestigation"]),
                        PersonalityTraits = SafeString(row["PersonalityTraits"]),
                        Ideals = SafeString(row["Ideals"]),
                        Bonds = SafeString(row["Bonds"]),
                        Flaws = SafeString(row["Flaws"]),
                        CharacterAppearance = SafeString(row["CharacterAppearance"]),
                        AlliesAndOrganizations = SafeString(row["AlliesAndOrganizations"]),
                        CharacterBackstory = SafeString(row["CharacterBackstory"]),
                        AdditionalNotes = SafeString(row["AdditionalNotes"]),

                        Classes = MapClassData(row),
                        Race = MapRaceData(row),
                        AbilityScores = MapAbilityScores(row),
                        Subclass = MapSubclassData(row)
                    };

                    characters.Add(character);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"⚠️ Exception while mapping character row: {ex.Message}");
                }
            }

            return characters;
        }


        // Converts a Character object into a dictionary of Characters for database insertion
        public Dictionary<string, object> MapCharacterToDictionary(Character character)
        {
            // Preparing the character object for database insertion by flattening it into key-value pairs
            return new Dictionary<string, object>
            {
                { "@Name", character.Name ?? (object)DBNull.Value },
                { "@Sex", character.Sex ?? (object)DBNull.Value },
                { "@Level", character.Level },
                { "@HP", character.HP },
                { "@ExperiencePoints", character.ExperiencePoints },
                { "@MaxHP", character.MaxHP },
                { "@TempHP", character.TempHP },
                { "@Speed", character.Speed },
                { "@AC", character.AC },
                { "@Background", character.Background ?? (object)DBNull.Value },
                { "@Alignment", character.Alignment ?? (object)DBNull.Value },
                { "@ClassID", character.ClassID },
                { "@RaceID", character.RaceID },
                { "@AbilityID", character.AbilityID },
                { "@SubclassID", character.SubclassID },
                { "@FeaturesAndTraits", string.Join(";", character.FeaturesAndTraits) ?? (object)DBNull.Value },
                { "@PassivePerception", character.PassivePerception },
                { "@PassiveInsight", character.PassiveInsight },
                { "@PassiveInvestigation", character.PassiveInvestigation },
                { "@PersonalityTraits", character.PersonalityTraits ?? (object)DBNull.Value },
                { "@Ideals", character.Ideals ?? (object)DBNull.Value },
                { "@Bonds", character.Bonds ?? (object)DBNull.Value },
                { "@Flaws", character.Flaws ?? (object)DBNull.Value },
                { "@CharacterAppearance", character.CharacterAppearance ?? (object)DBNull.Value },
                { "@AlliesAndOrganizations", character.AlliesAndOrganizations ?? (object)DBNull.Value },
                { "@CharacterBackstory", character.CharacterBackstory ?? (object)DBNull.Value },
                { "@AdditionalNotes", character.AdditionalNotes ?? (object)DBNull.Value },
                { "@InitiativeBonus", character.InitiativeBonus },
                { "@HitDice", character.HitDice },
                { "@DeathSavesSuccess", character.DeathSavesSuccess },
                { "@DeathSavesFailure", character.DeathSavesFailure },
                { "@Equipment", string.Join(";", character.Equipment) ?? (object)DBNull.Value}
            };
        }

        // Converts the AbilityScore object into a dictionary of ability scores for database insertion
        public Dictionary<string, object> MapAbilityScoresToDictionary(AbilityScores abilityScores)
        {
            return new Dictionary<string, object>
            {
                { "@Strength", abilityScores.Strength },
                { "@Dexterity", abilityScores.Dexterity },
                { "@Constitution", abilityScores.Constitution },
                { "@Intelligence", abilityScores.Intelligence },
                { "@Wisdom", abilityScores.Wisdom },
                { "@Charisma", abilityScores.Charisma }
            };
        }

        /************************************************************************/
        /*HELPERS*/
        /************************************************************************/

        // Maps raw database rows to an AbilityScores object
        private AbilityScores MapAbilityScores(Dictionary<string, object> row)
        {
            return new AbilityScores
            {
                AbilityID = row.ContainsKey("AbilityID") ? SafeInt(row["AbilityID"]) : 0,
                CharacterID = row.ContainsKey("CharacterID") ? SafeInt(row["CharacterID"]) : 0,
                Strength = row.ContainsKey("Strength") ? SafeInt(row["Strength"]) : 0,
                Dexterity = row.ContainsKey("Dexterity") ? SafeInt(row["Dexterity"]) : 0,
                Constitution = row.ContainsKey("Constitution") ? SafeInt(row["Constitution"]) : 0,
                Intelligence = row.ContainsKey("Intelligence") ? SafeInt(row["Intelligence"]) : 0,
                Wisdom = row.ContainsKey("Wisdom") ? SafeInt(row["Wisdom"]) : 0,
                Charisma = row.ContainsKey("Charisma") ? SafeInt(row["Charisma"]) : 0
            };
        }

        // Maps raw database rows to a Classes object
        private Classes MapClassData(Dictionary<string, object> row)
        {
            return new Classes
            {
                ClassID = row.ContainsKey("ClassID") ? SafeInt(row["ClassID"]) : 0,
                ClassName = row.ContainsKey("ClassName") ? SafeString(row["ClassName"]) : null,
                HitDie = row.ContainsKey("HitDie") ? SafeString(row["HitDie"]) : null,
                PrimaryAbility = row.ContainsKey("PrimaryAbility") ? SafeString(row["PrimaryAbility"]) : null,
                SavingThrows = row.ContainsKey("SavingThrows") ? SafeList(row["SavingThrows"]) : new List<string>(),
                SkillChoices = row.ContainsKey("SkillChoices") ? SafeList(row["SkillChoices"]) : new List<string>(),
                ClassFeatures = row.ContainsKey("ClassFeatures") ? SafeList(row["ClassFeatures"]) : new List<string>(),
                ArmorProficiencies = row.ContainsKey("ArmorProficiencies") ? SafeList(row["ArmorProficiencies"]) : new List<string>(),
                WeaponProficiencies = row.ContainsKey("WeaponProficiencies") ? SafeList(row["WeaponProficiencies"]) : new List<string>(),
                ToolProficiencies = row.ContainsKey("ToolProficiencies") ? SafeList(row["ToolProficiencies"]) : new List<string>(),
                SpellcastingAbilityModifier = row.ContainsKey("SpellcastingAbilityModifier") ? SafeInt(row["SpellcastingAbilityModifier"]) : 0
            };
        }


        // Maps raw database rows to a Race object
        private Race MapRaceData(Dictionary<string, object> row)
        {
            return new Race
            {
                RaceID = row.ContainsKey("RaceID") ? SafeInt(row["RaceID"]) : 0,
                RaceName = row.ContainsKey("RaceName") ? SafeString(row["RaceName"]) : null,
                RaceSize = row.ContainsKey("RaceSize") ? SafeString(row["RaceSize"]) : null,
                Speed = row.ContainsKey("RaceSpeed") ? SafeInt(row["RaceSpeed"]) : 0,
                AbilityScoreBonuses = row.ContainsKey("AbilityScoreBonuses") ? MapAbilityScoreBonuses(SafeString(row["AbilityScoreBonuses"])) : new List<string>(),
                Languages = row.ContainsKey("Languages") ? SafeList(row["Languages"]) : new List<string>(),
                RacialFeatures = row.ContainsKey("RacialFeatures") ? SafeList(row["RacialFeatures"]) : new List<string>(),
                RacialProficiencies = row.ContainsKey("RacialProficiencies") ? SafeList(row["RacialProficiencies"]) : new List<string>(),
                Darkvision = row.ContainsKey("Darkvision") ? SafeInt(row["Darkvision"]) : 0
            };
        }


        // Maps raw database rows to a Subclass object
        private Subclass MapSubclassData(Dictionary<string, object> row)
        {
            return new Subclass
            {
                SubclassID = row.ContainsKey("SubclassID") ? SafeInt(row["SubclassID"]) : 0,
                SubclassName = row.ContainsKey("SubclassName") ? SafeString(row["SubclassName"]) : null,
                ClassID = row.ContainsKey("ClassID") ? SafeInt(row["ClassID"]) : 0,
                SubclassFeatures = row.ContainsKey("SubclassFeatures") ? SafeList(row["SubclassFeatures"]) : new List<string>(),
                EntryLevel = row.ContainsKey("EntryLevel") ? SafeInt(row["EntryLevel"]) : 3,
                BonusProficiencies = row.ContainsKey("BonusProficiencies") ? SafeList(row["BonusProficiencies"]) : new List<string>(),
                BonusSpells = row.ContainsKey("BonusSpells") ? SafeList(row["BonusSpells"]) : new List<string>()
            };
        }

        // Maps Spells raw database rows to Character object
        private List<Spell> MapSpellsData(List<Dictionary<string, object>> rows)
        {
            var spells = new List<Spell>();

            foreach (var row in rows)
            {
                spells.Add(new Spell
                {
                    SpellID = SafeInt(row["SpellID"]),
                    Name = SafeString(row["Name"]),
                    Level = SafeInt(row["Level"]),
                    School = SafeString(row["School"]),
                    CastingTime = SafeString(row["CastingTime"]),
                    Range = SafeString(row["Range"]),
                    Components = MapList(SafeString(row["Components"]), ';'),
                    Duration = SafeString(row["Duration"]),
                    Description = SafeString(row["Description"]),
                    IsRitual = row["IsRitual"] != DBNull.Value && (bool)row["IsRitual"],
                    RequiresConcentration = row["RequiresConcentration"] != DBNull.Value && (bool)row["RequiresConcentration"],
                    Classes = MapList(SafeString(row["Classes"]), ';')
                });
            }

            return spells;
        }



        // Lists out the bonuses a race would get in a sting made to look like an object
        private List<string> MapAbilityScoreBonuses(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                return new List<string>();

            var bonuses = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
            return bonuses.Select(kv => $"{kv.Key}: {kv.Value}").ToList();
        }

        // Converts a delimited string into a list of strings
        private List<string> MapList(string rawData, char delimiter)
        {
            if (string.IsNullOrWhiteSpace(rawData))
                return new List<string>();

            return rawData.Split(delimiter).Select(item => item.Trim()).ToList();
        }

        // Parses a comma-separated string into a list of trimmed strings
        private List<string> ParseList(string listData)
        {
            // Assuming listData is a comma-separated string like "Skill1,Skill2,Skill3"
            return string.IsNullOrWhiteSpace(listData)
                ? new List<string>()
                : listData.Split(',').Select(item => item.Trim()).ToList();
        }

    }
}
