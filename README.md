# Project-fiveE

**Project-fiveE** is a simple RESTful API designed to manage characters for Dungeons & Dragons campaigns. It provides endpoints for retrieving and creating character data, making it easy to integrate with a front-end application or use as a standalone tool for managing your D&D sessions.

---

## Features
- Retrieve a list of all characters.
- Get detailed information about a specific character.
- Create new characters by sending their details in a POST request.

---

## API Routes

### 1. **Get All Characters**
**Endpoint:** `GET /api/characters`  
**Description:** Retrieve a list of all D&D characters.  
**Response Example:**  
```json
[
  {
    "CharacterID": 1,
    "Name": "Arthas",
    "Sex": "Male",
    "ClassID": 1,
    "Classes": {
      "ClassId": 1,
      "ClassName": "Fighter",
      "HitDie": "d10",
      "PrimaryAbility": "Strength",
      "SavingThrows": [
        "Strength",
        "Constitution"
      ],
      "SkillChoices": [
        "Athletics",
        "Survival"
      ],
      "ClassFeatures": [
        "Second Wind",
        "Action Surge"
      ]
    },
    "RaceID": 1,
    "Race": {
      "RaceId": 1,
      "RaceName": "Human",
      "RaceSize": "Medium",
      "Speed": 30,
      "AbilityScoreBonuses": {
        "Strength": 1,
        "Dexterity": 1
      },
      "Languages": [
        "Common"
      ],
      "RacialFeatures": [
        "Versatility"
      ]
    },
    "AbilityID": 1,
    "AbilityScores": {
      "AbilityId": 1,
      "CharacterID": 1,
      "Strength": 15,
      "Dexterity": 12,
      "Constitution": 14,
      "Intelligence": 10,
      "Wisdom": 13,
      "Charisma": 8
    },
    "Skills": [],
    "Proficiencies": [],
    "Equipment": [],
    "Background": "Soldier",
    "Alignment": "Lawful Good",
    "Level": 1,
    "HP": 12,
    "XP": 0,
    "MaxHP": 12,
    "Speed": 30,
    "AC": 18
  }
]
```

### 2. **Get a Single Character**
**Endpoint:** `GET /api/characters/{id}`  
**Description:** Retrieve detailed information about a single character by their ID.  
**Response Example:**  
```json
{
  "CharacterID": 1,
  "Name": "Arthas",
  "Sex": "Male",
  "ClassID": 1,
  "Classes": {
    "ClassId": 1,
    "ClassName": "Fighter",
    "HitDie": "d10",
    "PrimaryAbility": "Strength",
 // Rest of Character Data
}
```
### 3. **Create a New Character**
**Endpoint:** `POST /api/characters`  
**Description:** Create a new character by sending their data in the request body.  
**Request Example:**  
```json
{
  "Name": "Lyra Silverleaf",
  "ClassID": 2,
  "RaceID": 3,
  "AbilityScores": {
    "Strength": 8,
    "Dexterity": 14,
    "Constitution": 12,
    "Intelligence": 18,
    "Wisdom": 10,
    "Charisma": 16
  },
  "Background": "Sage",
  "Alignment": "Neutral Good",
  "Level": 1
}
```
**Response Example:**  
```json
{
  "CharacterID": 2,
  "Message": "Character created successfully"
}
```

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
