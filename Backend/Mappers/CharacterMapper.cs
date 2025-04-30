using Newtonsoft.Json;

namespace Backend
{
    public class CharacterMapper
    {
        private int SafeInt(object value)
        {
            return value == DBNull.Value ? 0 : Convert.ToInt32(value);
        }
        private string SafeString(object value)
        {
            return value == DBNull.Value ? null : value.ToString();
        }
        private List<string> SafeList(object val) => val != DBNull.Value ? ParseList(val.ToString()) : new List<string>();

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
                        SpellsKnown = ParseList(SafeString(row["SpellsKnown"])),
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
                { "@SpellsKnown", string.Join(";", character.SpellsKnown) ?? (object)DBNull.Value },
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

        // Converts the Subclass object into a dictionary of subclass data for database insertion
        public Dictionary<string, object> MapSubclassToDictionary(Subclass subclass)
        {
            return new Dictionary<string, object>
            {
                { "@SubclassID", subclass.SubclassID },
                { "@SubclassName", subclass.SubclassName ?? (object)DBNull.Value },
                { "@ClassID", subclass.ClassID },
                { "@SubclassFeatures", string.Join(";", subclass.SubclassFeatures) ?? (object)DBNull.Value },
                { "@EntryLevel", subclass.EntryLevel },
                { "@BonusProficiencies", string.Join(";", subclass.BonusProficiencies) ?? (object)DBNull.Value },
                { "@BonusSpells", string.Join(";", subclass.BonusSpells) ?? (object)DBNull.Value }
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
                ClassID = row.ContainsKey("ClassID") ? Convert.ToInt32(row["ClassID"]) : 0,
                ClassName = row.ContainsKey("ClassName") ? row["ClassName"].ToString() : null,
                HitDie = row.ContainsKey("HitDie") ? row["HitDie"].ToString() : null,
                PrimaryAbility = row.ContainsKey("PrimaryAbility") ? row["PrimaryAbility"].ToString() : null,
                SavingThrows = row.ContainsKey("SavingThrows") ? MapList(row["SavingThrows"].ToString(), ',') : new List<string>(),
                SkillChoices = row.ContainsKey("SkillChoices") ? MapList(row["SkillChoices"].ToString(), ';') : new List<string>(),
                ClassFeatures = row.ContainsKey("ClassFeatures") ? MapList(row["ClassFeatures"].ToString(), ';') : new List<string>(),
                ArmorProficiencies = row.ContainsKey("ArmorProficiencies") ? MapList(row["ArmorProficiencies"].ToString(), ';') : new List<string>(),
                WeaponProficiencies = row.ContainsKey("WeaponProficiencies") ? MapList(row["WeaponProficiencies"].ToString(), ';') : new List<string>(),
                ToolProficiencies = row.ContainsKey("ToolProficiencies") ? MapList(row["ToolProficiencies"].ToString(), ';') : new List<string>(),
                SpellcastingAbilityModifier = row.ContainsKey("SpellcastingAbilityModifier") ? Convert.ToInt32(row["SpellcastingAbilityModifier"]) : 0
            };
        }

        // Maps raw database rows to a Race object
        private Race MapRaceData(Dictionary<string, object> row)
        {
            return new Race
            {
                RaceID = row.ContainsKey("RaceID") ? Convert.ToInt32(row["RaceID"]) : 0,
                RaceName = row.ContainsKey("RaceName") ? row["RaceName"].ToString() : null,
                RaceSize = row.ContainsKey("RaceSize") ? row["RaceSize"].ToString() : null,
                Speed = row.ContainsKey("RaceSpeed") ? Convert.ToInt32(row["RaceSpeed"]) : 0,
                AbilityScoreBonuses = row.ContainsKey("AbilityScoreBonuses") ? MapAbilityScoreBonuses(row["AbilityScoreBonuses"].ToString()) : new List<string>(),
                Languages = row.ContainsKey("Languages") ? MapList(row["Languages"].ToString(), ';') : new List<string>(),
                RacialFeatures = row.ContainsKey("RacialFeatures") ? MapList(row["RacialFeatures"].ToString(), ';') : new List<string>(),
                RacialProficiencies = row.ContainsKey("RacialProficiencies") ? MapList(row["RacialProficiencies"].ToString(), ';') : new List<string>(),
                Darkvision = row.ContainsKey("Darkvision") ? Convert.ToInt32(row["Darkvision"]) : 0
            };
        }

        private Subclass MapSubclassData(Dictionary<string, object> row)
        {
            return new Subclass
            {
                SubclassID = row.ContainsKey("SubclassID") ? Convert.ToInt32(row["SubclassID"]) : 0,
                SubclassName = row.ContainsKey("SubclassName") ? row["SubclassName"].ToString() : null,
                ClassID = row.ContainsKey("ClassID") ? Convert.ToInt32(row["ClassID"]) : 0,
                SubclassFeatures = row.ContainsKey("SubclassFeatures") ? MapList(row["SubclassFeatures"].ToString(), ';') : new List<string>(),
                EntryLevel = row.ContainsKey("EntryLevel") ? Convert.ToInt32(row["EntryLevel"]) : 3,
                BonusProficiencies = row.ContainsKey("BonusProficiencies") ? MapList(row["BonusProficiencies"].ToString(), ';') : new List<string>(),
                BonusSpells = row.ContainsKey("BonusSpells") ? MapList(row["BonusSpells"].ToString(), ';') : new List<string>()
            };
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
