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
**Endpoint:** `GET /characters`  
**Description:** Retrieve a list of all D&D characters.  
**Response Example:**  
```json
[
  {
    "CharacterID": 15,
    "Name": "Garrett Wyrmcaller",
    "Sex": "Male",
    "Level": 5,
    "Race": {
      "RaceName": "Human",
      "Speed": 30,
      "Languages": ["Common"],
      "RacialFeatures": ["Versatility"]
    },
    "Classes": {
      "ClassName": "Ranger",
      "HitDie": "d10",
      "SkillChoices": ["Survival", "Nature"]
    },
    "AbilityScores": {
      "Strength": 13,
      "Dexterity": 18,
      "Constitution": 12
    }
  }
]
```

### 2. **Get a Single Character**
**Endpoint:** `GET /characters/{id}`  
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

"...": "Other class-related properties omitted for brevity"
}
```
### 3. **Create a New Character**
**Endpoint:** `POST /characters`  
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

### 4. **Update an Existing Character**
**Endpoint:** `PATCH /characters/{id}`
**Description:** Does a partial update to an existing character by sending the updated data in the request body.  
**Request Example:**  
```json
{
  "HP": "25",
  "Speed": "15"
}
```
**Response Example:**
```json
Character 15 updated successfully!
```

### 5. **Delete an Existing Character**
**Endpoint:** `DELETE /characters/{id}`
**Description:** Removes an exisiting Character from the  DB.  
**Request Example:**  
```json
{
  "CharacterId": "15"
}
```
**Response Example:**
```json
{
  "Message": "Character deleted"
}
```

## 🧙‍♂️ Notes
- Reference data like Races, Classes, and Subclasses must be pre-seeded in the DB. Characters reference them by ID.
- POST automatically inserts the related AbilityScores, then ties them back via foreign key.
- PATCH supports any number of partial fields for basic character fields (like HP, XP, name, etc).

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
