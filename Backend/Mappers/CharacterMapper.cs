﻿using Newtonsoft.Json;

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
            var raceMapper = new RaceMapper(); // Handles Race + CharacterRaceSelection mapping
            var classMapper = new ClassMapper(); // Handles Class + CharacterClassSelection mapping

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
                        AC = SafeInt(row["AC"]),
                        InitiativeBonus = SafeInt(row["InitiativeBonus"]),
                        ExperiencePoints = SafeInt(row["ExperiencePoints"]),
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

                        // Linked objects
                        Subclass = MapSubclassData(row),
                        AbilityScores = MapAbilityScores(row),
                        Spells = new List<Spell>(),

                        // Race Mappings (static + assigned + selected)
                        Race = raceMapper.MapRaceData(row),
                        CharacterRaceSelection = raceMapper.MapCharacterRaceSelection(row),

                        Classes = classMapper.MapClassData(row),
                        CharacterClassSelection = classMapper.MapCharacterClassSelection(row)
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
                { "@AC", character.AC },
                { "@Background", character.Background ?? (object)DBNull.Value },
                { "@Alignment", character.Alignment ?? (object)DBNull.Value },
                { "@ClassID", character.ClassID },
                { "@RaceID", character.RaceID },
                { "@AbilityID", character.AbilityID },
                { "@SubclassID", character.SubclassID },
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

        // Maps a list of spells and character IDs to a dictionary for database insertion
        public List<Dictionary<string, object>> MapCharacterSpellsToDictionary(int characterID, List<Spell> spells)
        {
            return spells.Select(spell => new Dictionary<string, object>
            {
                { "@CharacterID", characterID },
                { "@SpellID", spell.SpellID  }
            }).ToList();
        }

        // Maps a list of subclass and character IDs as well as specific subclass properties to a dictionary for database insertion
        public Dictionary<string, object> MapCharacterSubclassToDictionary(Character character)
        {
            return new Dictionary<string, object>
            {
                { "@CharacterID", character.CharacterID },
                { "@SubclassID", character.SubclassID },

                { "@BonusProficiencies",
                    character.Subclass?.BonusProficiencies != null
                        ? string.Join(",", character.Subclass.BonusProficiencies)
                        : (object)DBNull.Value
                },

                { "@BonusSpells",
                    character.Subclass?.BonusSpells != null
                        ? string.Join(",", character.Subclass.BonusSpells)
                        : (object)DBNull.Value
                }
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


        // Maps raw database rows to a Subclass object
        public Subclass MapSubclassData(Dictionary<string, object> row)
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
        public List<Spell> MapSpellsData(List<Dictionary<string, object>> rows)
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
