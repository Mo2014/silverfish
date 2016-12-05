﻿namespace HREngine.Bots
{

    public enum GAME_TAGs
    {
        TAG_SCRIPT_DATA_NUM_1 = 2,
        TAG_SCRIPT_DATA_NUM_2 = 3,
        TAG_SCRIPT_DATA_ENT_1 = 4,
        TAG_SCRIPT_DATA_ENT_2 = 5,
        MISSION_EVENT = 6,
        TIMEOUT = 7,
        TURN_START = 8,
        TURN_TIMER_SLUSH = 9,
        PREMIUM = 12,
        GOLD_REWARD_STATE = 13,
        PLAYSTATE = 17,
        LAST_AFFECTED_BY = 18,
        STEP = 19,
        TURN = 20,
        FATIGUE = 22,
        CURRENT_PLAYER = 23,
        FIRST_PLAYER = 24,
        RESOURCES_USED = 25,
        RESOURCES = 26,
        HERO_ENTITY = 27,
        MAXHANDSIZE = 28,
        STARTHANDSIZE = 29,
        PLAYER_ID = 30,
        TEAM_ID = 31,
        TRIGGER_VISUAL = 32,
        RECENTLY_ARRIVED = 33,
        PROTECTING = 34,
        PROTECTED = 35,
        DEFENDING = 36,
        PROPOSED_DEFENDER = 37,
        ATTACKING = 38,
        PROPOSED_ATTACKER = 39,
        ATTACHED = 40,
        EXHAUSTED = 43,
        DAMAGE = 44,
        HEALTH = 45,
        ATK = 47,
        COST = 48,
        ZONE = 49,
        CONTROLLER = 50,
        OWNER = 51,
        DEFINITION = 52,
        ENTITY_ID = 53,
        HISTORY_PROXY = 54,
        COPY_DEATHRATTLE = 55,
        ELITE = 114,
        MAXRESOURCES = 176,
        CARD_SET = 183,
        CARDTEXT_INHAND = 184,
        CARDNAME = 185,
        CARD_ID = 186,
        DURABILITY = 187,
        SILENCED = 188,
        WINDFURY = 189,
        TAUNT = 190,
        STEALTH = 191,
        SPELLPOWER = 192,
        DIVINE_SHIELD = 194,
        CHARGE = 197,
        NEXT_STEP = 198,
        CLASS = 199,
        CARDRACE = 200,
        FACTION = 201,
        CARDTYPE = 202,
        RARITY = 203,
        STATE = 204,
        SUMMONED = 205,
        FREEZE = 208,
        ENRAGED = 212,
        OVERLOAD = 215,
        LOYALTY = 216,
        DEATHRATTLE = 217,
        BATTLECRY = 218,
        SECRET = 219,
        COMBO = 220,
        CANT_HEAL = 221,
        CANT_DAMAGE = 222,
        CANT_SET_ASIDE = 223,
        CANT_REMOVE_FROM_GAME = 224,
        CANT_READY = 225,
        CANT_ATTACK = 227,
        CANT_DISCARD = 230,
        CANT_PLAY = 231,
        CANT_DRAW = 232,
        CANT_BE_HEALED = 239,
        IMMUNE = 240,
        CANT_BE_SET_ASIDE = 241,
        CANT_BE_REMOVED_FROM_GAME = 242,
        CANT_BE_READIED = 243,
        CANT_BE_ATTACKED = 245,
        CANT_BE_TARGETED = 246,
        CANT_BE_DESTROYED = 247,
        CANT_BE_SUMMONING_SICK = 253,
        FROZEN = 260,
        JUST_PLAYED = 261,
        LINKED_ENTITY = 262,
        ZONE_POSITION = 263,
        CANT_BE_FROZEN = 264,
        COMBO_ACTIVE = 266,
        CARD_TARGET = 267,
        NUM_CARDS_PLAYED_THIS_TURN = 269,
        CANT_BE_TARGETED_BY_OPPONENTS = 270,
        NUM_TURNS_IN_PLAY = 271,
        NUM_TURNS_LEFT = 272,
        CURRENT_SPELLPOWER = 291,
        ARMOR = 292,
        MORPH = 293,
        IS_MORPHED = 294,
        TEMP_RESOURCES = 295,
        OVERLOAD_OWED = 296,
        NUM_ATTACKS_THIS_TURN = 297,
        NEXT_ALLY_BUFF = 302,
        MAGNET = 303,
        FIRST_CARD_PLAYED_THIS_TURN = 304,
        MULLIGAN_STATE = 305,
        TAUNT_READY = 306,
        STEALTH_READY = 307,
        CHARGE_READY = 308,
        CANT_BE_TARGETED_BY_SPELLS = 311,
        SHOULDEXITCOMBAT = 312,
        CREATOR = 313,
        CANT_BE_SILENCED = 314,
        PARENT_CARD = 316,
        NUM_MINIONS_PLAYED_THIS_TURN = 317,
        PREDAMAGE = 318,
        COLLECTIBLE = 321,
        TARGETING_ARROW_TEXT = 325,
        ENCHANTMENT_BIRTH_VISUAL = 330,
        ENCHANTMENT_IDLE_VISUAL = 331,
        CANT_BE_TARGETED_BY_HERO_POWERS = 332,
        HEALTH_MINIMUM = 337,
        TAG_ONE_TURN_EFFECT = 338,
        SILENCE = 339,
        COUNTER = 340,
        ARTISTNAME = 342,
        HAND_REVEALED = 348,
        ADJACENT_BUFF = 350,
        FLAVORTEXT = 351,
        FORCED_PLAY = 352,
        LOW_HEALTH_THRESHOLD = 353,
        SPELLPOWER_DOUBLE = 356,
        HEALING_DOUBLE = 357,
        NUM_OPTIONS_PLAYED_THIS_TURN = 358,
        TO_BE_DESTROYED = 360,
        AURA = 362,
        POISONOUS = 363,
        HOW_TO_EARN = 364,
        HOW_TO_EARN_GOLDEN = 365,
        HERO_POWER_DOUBLE = 366,
        AI_MUST_PLAY = 367,
        NUM_MINIONS_PLAYER_KILLED_THIS_TURN = 368,
        NUM_MINIONS_KILLED_THIS_TURN = 369,
        AFFECTED_BY_SPELL_POWER = 370,
        EXTRA_DEATHRATTLES = 371,
        START_WITH_1_HEALTH = 372,
        IMMUNE_WHILE_ATTACKING = 373,
        MULTIPLY_HERO_DAMAGE = 374,
        MULTIPLY_BUFF_VALUE = 375,
        CUSTOM_KEYWORD_EFFECT = 376,
        TOPDECK = 377,
        CANT_BE_TARGETED_BY_BATTLECRIES = 379,
        HERO_POWER = 380,
        DEATHRATTLE_RETURN_ZONE = 382,
        STEADY_SHOT_CAN_TARGET = 383,
        DISPLAYED_CREATOR = 385,
        POWERED_UP = 386,
        SPARE_PART = 388,
        FORGETFUL = 389,
        CAN_SUMMON_MAXPLUSONE_MINION = 390,
        OBFUSCATED = 391,
        BURNING = 392,
        OVERLOAD_LOCKED = 393,
        NUM_TIMES_HERO_POWER_USED_THIS_GAME = 394,
        CURRENT_HEROPOWER_DAMAGE_BONUS = 395,
        HEROPOWER_DAMAGE = 396,
        LAST_CARD_PLAYED = 397,
        NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_TURN = 398,
        NUM_CARDS_DRAWN_THIS_TURN = 399,
        AI_ONE_SHOT_KILL = 400,
        EVIL_GLOW = 401,
        HIDE_STATS = 402,
        INSPIRE = 403,
        RECEIVES_DOUBLE_SPELLDAMAGE_BONUS = 404,
        HEROPOWER_ADDITIONAL_ACTIVATIONS = 405,
        HEROPOWER_ACTIVATIONS_THIS_TURN = 406,
        REVEALED = 410,
        NUM_FRIENDLY_MINIONS_THAT_DIED_THIS_GAME = 412,
        CANNOT_ATTACK_HEROES = 413,
        LOCK_AND_LOAD = 414,
        DISCOVER = 415,
        SHADOWFORM = 416,
        NUM_FRIENDLY_MINIONS_THAT_ATTACKED_THIS_TURN = 417,
        NUM_RESOURCES_SPENT_THIS_GAME = 418,
        CHOOSE_BOTH = 419,
        ELECTRIC_CHARGE_LEVEL = 420,
        HEAVILY_ARMORED = 421,
        DONT_SHOW_IMMUNE = 422,
        RITUAL = 424,
        PREHEALING = 425,
        APPEAR_FUNCTIONALLY_DEAD = 426,
        OVERLOAD_THIS_GAME = 427,
        SPELLS_COST_HEALTH = 431,
        HISTORY_PROXY_NO_BIG_CARD = 432,
        PROXY_CTHUN = 434,
        TRANSFORMED_FROM_CARD = 435,
        CTHUN = 436,
        CAST_RANDOM_SPELLS = 437,
        SHIFTING = 438,
        JADE_GOLEM = 441,
        EMBRACE_THE_SHADOW = 442,
        CHOOSE_ONE = 443,
        EXTRA_ATTACKS_THIS_TURN = 444,
        SEEN_CTHUN = 445,
        MINION_TYPE_REFERENCE = 447,
        UNTOUCHABLE = 448,
        RED_MANA_CRYSTALS = 449,
        SCORE_LABELID_1 = 450,
        SCORE_VALUE_1 = 451,
        SCORE_LABELID_2 = 452,
        SCORE_VALUE_2 = 453,
        SCORE_LABELID_3 = 454,
        SCORE_VALUE_3 = 455,
        CANT_BE_FATIGUED = 456,
        AUTOATTACK = 457,
        ARMS_DEALING = 458,
        TAG_LAST_KNOWN_COST_IN_HAND = 466,
        DEFINING_ENCHANTMENT = 469,
        FINISH_ATTACK_SPELL_ON_DAMAGE = 470,
        KAZAKUS_POTION_POWER_1 = 471,
        KAZAKUS_POTION_POWER_2 = 472,
        MODIFY_DEFINITION_ATTACK = 473,
        MODIFY_DEFINITION_HEALTH = 474,
        MODIFY_DEFINITION_COST = 475,
        MULTIPLE_CLASSES = 476,
        ALL_TARGETS_RANDOM = 477,
        MULTI_CLASS_GROUP = 480,
        CARD_COSTS_HEALTH = 481,
        GRIMY_GOONS = 482,
        JADE_LOTUS = 483,
        KABAL = 484,
        ADDITIONAL_PLAY_REQS_1 = 515,
        ADDITIONAL_PLAY_REQS_2 = 516,
    }

    public enum TAG_ZONE
    {
        INVALID,
        PLAY,
        DECK,
        HAND,
        GRAVEYARD,
        REMOVEDFROMGAME,
        SETASIDE,
        SECRET
    }

    public enum TAG_CLASS
    {
        INVALID,
        ALL,
        DEATHKNIGHT,
        DRUID,
        HUNTER,
        MAGE,
        PALADIN,
        PRIEST,
        ROGUE,
        SHAMAN,
        WARLOCK,
        WARRIOR,
        DREAM

    }

    public enum TAG_RACE
    {
        INVALID = 0,
        BLOODELF = 1,
        DRAENEI = 2,
        DWARF = 3,
        GNOME = 4,
        GOBLIN = 5,
        HUMAN = 6,
        NIGHTELF = 7,
        ORC = 8,
        TAUREN = 9,
        TROLL = 10,
        UNDEAD = 11,
        WORGEN = 12,
        GOBLIN2 = 13,
        MURLOC = 14,
        DEMON = 15,
        SCOURGE = 16,
        MECHANICAL = 17,
        ELEMENTAL = 18,
        OGRE = 19,
        PET = 20,
        TOTEM = 21,
        NERUBIAN = 22,
        PIRATE = 23,
        DRAGON = 24
    }
    
    public enum TAG_CARDTYPE
    {
        INVALID = 0,
        GAME = 1,
        PLAYER = 2,
        HERO = 3,
        MINION = 4,
        SPELL = 5,
        ENCHANTMENT = 6,
        WEAPON = 7,
        ITEM = 8,
        TOKEN = 9,
        HERO_POWER = 10,
    }

    public enum TAG_CARD_SET
    {
        INVALID = 0,
        TEST_TEMPORARY = 1,
        CORE = 2,
        EXPERT1 = 3,
        REWARD = 4,
        MISSIONS = 5,
        DEMO = 6,
        NONE = 7,
        CHEAT = 8,
        BLANK = 9,
        DEBUG_SP = 10,
        PROMO = 11,
        FP1 = 12,
        PE1 = 13,
        BRM = 14,
        TGT = 15,
        CREDITS = 16,
        HERO_SKINS = 17,
        TB = 18,
        SLUSH = 19,
        LOE = 20,
        OG = 21,
        OG_RESERVE = 22,
    }

    public enum TAG_RARITY
    {
        INVALID = 0,
        COMMON = 1,
        FREE = 2,
        RARE = 3,
        EPIC = 4,
        LEGENDARY = 5,
    }

   
}