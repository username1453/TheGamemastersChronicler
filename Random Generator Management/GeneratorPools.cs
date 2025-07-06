using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGamemastersChronicler.Random_Generator_Management
{
    internal class GeneratorPools
    {
        public static readonly List<string> GivenNames = new List<string>
      {
            "James", "Robert", "John", "Michael", "William", "David", "Richard", "Joseph",
            "Thomas", "Charles", "Christopher", "Daniel", "Matthew", "Anthony", "Mark",
            "Donald", "Steven", "Paul", "Andrew", "Joshua", "Kenneth", "Kevin", "Brian",
            "George", "Edward", "Ronald", "Timothy", "Jason", "Jeffrey", "Ryan", "Jacob",
            "Gary", "Nicholas", "Eric", "Jonathan", "Stephen", "Larry", "Justin", "Scott",
            "Brandon", "Benjamin", "Samuel", "Gregory", "Frank", "Alexander", "Raymond",
            "Patrick", "Jack", "Dennis", "Jerry", "Tyler", "Aaron", "Jose", "Adam", "Henry",
            "Nathan", "Douglas", "Zachary", "Peter", "Kyle", "Walter", "Ethan", "Jeremy",
            "Harold", "Keith", "Christian", "Roger", "Noah", "Gerald", "Carl", "Terry",
            "Sean", "Austin", "Arthur", "Lawrence", "Jesse", "Dylan", "Bryan", "Joe",
            "Jordan", "Billy", "Bruce", "Albert", "Willie", "Gabriel", "Logan", "Alan",
            "Juan", "Wayne", "Roy", "Ralph", "Randy", "Eugene", "Vincent", "Russell",
            "Elijah", "Louis", "Bobby", "Philip", "Johnny", "Mary", "Patricia", "Jennifer",
            "Linda", "Elizabeth", "Barbara", "Susan", "Jessica", "Sarah", "Karen", "Nancy",
            "Lisa", "Betty", "Margaret", "Sandra", "Ashley", "Kimberly", "Emily", "Donna",
            "Michelle", "Dorothy", "Carol", "Amanda", "Melissa", "Deborah", "Stephanie",
            "Rebecca", "Sharon", "Laura", "Cynthia", "Kathleen", "Amy", "Shirley", "Angela",
            "Helen", "Anna", "Brenda", "Pamela", "Nicole", "Emma", "Samantha", "Katherine",
            "Christine", "Debra", "Rachel", "Catherine", "Carolyn", "Janet", "Ruth", "Maria",
            "Heather", "Diane", "Virginia", "Julie", "Joyce", "Victoria", "Olivia", "Kelly",
            "Christina", "Lauren", "Joan", "Evelyn", "Judith", "Megan", "Cheryl", "Andrea",
            "Hannah", "Martha", "Jacqueline", "Frances", "Gloria", "Ann", "Teresa", "Kathryn",
            "Sara", "Janice", "Jean", "Alice", "Madison", "Doris", "Abigail", "Julia", "Judy",
            "Grace", "Denise", "Amber", "Marilyn", "Beverly", "Danielle", "Theresa", "Sophia",
            "Marie", "Diana", "Brittany", "Natalie", "Isabella", "Charlotte", "Rose", "Alexis",
            "Kayla", "Fāng", "Wěi", "Xiùyīng", "Nà", "Mǐn", "Jìng", "Lì", "Qiáng", "Lěi", "Jūn",
            "Yáng", "Yǒng", "Yàn", "Jié", "Juān", "Tāo", "Haruto", "Minato", "Haruki", "Sōta",
            "Yūto", "Riku", "Yuito", "Honoka", "Akari", "Himari", "Mei", "Ema", "Yui", "Mio",
            "Musa", "Ibrahim", "Abubakar", "Sani", "Abdullahi", "Mohammed", "Sunday", "Umar",
            "Emmanuel", "Adamu", "Usman", "Blessing", "Aliyu", "Aisha", "Muhammed", "Muhammad",
            "Fatima", "Mary", "Esther", "Yusuf", "Ali", "Samuel", "Aminu", "Grace", "Joseph",
            "Hassan", "Amina", "Haruna", "Salisu", "Peter", "Bello", "Garba", "Zainab", "Maryam",
            "Joy", "Victoria", "Kabiru", "Elizabeth", "Isa", "Hadiza", "Idris", "Mercy", "Isah",
            "Yahaya", "Hauwa", "David", "Daniel", "Ngozi", "Yakubu"
        };

        public static readonly List<string> Surnames = new List<string>
        {
            "Devi", "Yang", "Huang", "Singh", "Wu", "Kumar", "Xu", "Ali", "Zhao", "Zhou",
            "Nguyen", "Li", "Ahmed", "Khatun", "da Silva", "Tang", "Mohamed", "Garcia", "Smith",
            "Johnson", "Williams", "Brown", "Jones", "Leightenheimer", "Miller", "Davis",
            "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson",
            "Thomas", "Taylor", "Moore", "Jackson", "Martin", "Lee", "Perez", "Thompson",
            "White", "Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson", "Walker",
            "Young", "Allen", "King", "Wright", "Scott", "Torres", "Roberts", "Hill", "Flores",
            "Green", "Adams", "Nelson", "Baker", "Hall", "Rivera", "Campbell", "Mitchell",
            "Carter", "Patel", "Tanaka", "Watanabe", "Takahashi", "Yamamoto", "Dauda", "Sheriff",
            "Usman", "Anifowose", "Afegbua", "Yakubu", "Musa", "Okoh", "Kure", "Ekpeyong",
            "Ahmed", "Olarewaju", "Mustapha", "Yusuf", "John", "Momoh", "Shehu", "Ali",
            "Ndubuisi", "Yohanna", "Dalhatu", "Anyawu", "Amaechi", "Sani", "Lamido", "Babaji",
            "Obi", "Adeyemi", "Umar", "Bitrus", "Zamani", "Ugor", "Yaro", "Madden", "Wiley",
            "Iovino"
        };

        public static readonly List<string> Species = new List<string>
        {
            "Terran", "Terran", "Terran", "Terran", "Terran", "Terran", "Terran", "Terran",
            "Vilani", "Vilani", "Vilani", "Vilani",
            "Vegan", "Other",
            "Uplifted Ape", "Dolphin", "Orca", "Ursa",
            "Uplifted Ape", "Dolphin", "Ursa",
            "Uplifted Ape", "Dolphin"
        };

        public static readonly List<string> Profession = new List<string>
        {
            "Spaceship mechanic",
            "Xenobiologist",
            "Explorer",
            "Augmentation shopkeep",
            "Algae Farmer",
            "Professor of Cryogenic Studies",
            "Android Recycling Technician",
            "Space Traffic Controller",
            "Starship Salesperson",
            "Hover Taxi Driver",
            "Hologram/VR Programer",
            "Gene Splicer",
            "Cybernetics Repair Technician",
            "Xenoarchaeologist",
            "Microgravity Agriculture Consultant",
            "Deep Space Mining Equipment Operator",
            "Alien Language Translator",
            "Organ Cloning Doctor",
            "FTL Trailblazer",
            "Terraforming Coordinator",
            "Moisture Farmer",
            "Bounty Hunter",
            "Marine", "Marine", "Marine", "Marine", "Marine", "Marine", "Marine", "Marine",
            "Soldier", "Soldier", "Soldier", "Soldier", "Soldier", "Soldier", "Soldier", "Soldier",
            "Soldier", "Soldier", "Soldier", "Soldier",
            "Local Politician", "Local Politician", "Local Politician", "Local Politician",
            "Local Politician", "Local Politician",
            "Terran Governor/Nobility", "Terran Governor/Nobility", "Terran Governor/Nobility",
            "Sailor", "Sailor", "Sailor", "Sailor", "Sailor", "Sailor", "Sailor", "Sailor", "Sailor",
            "Admiral", "Admiral", "Admiral",
            "General", "General", "General",
            "Academic", "Academic", "Academic",
            "Prospector",
            "Merchant", "Merchant", "Merchant", "Merchant", "Merchant", "Merchant", "Merchant",
            "Merchant", "Merchant", "Merchant", "Merchant", "Merchant", "Merchant", "Merchant",
            "Diplomat",
            "Doctor", "Doctor", "Doctor",
            "Flier", "Flier",
            "Barbarian", "Barbarian",
            "Scout", "Scout", "Scout",
            "Rogue", "Rogue", "Rogue",
            "Criminal", "Criminal", "Criminal",
            "Pirate", "Pirate", "Pirate"
        };

        public static readonly List<string> Personality = new List<string>
        {
            "Always bored", "Angry drunk", "Annoyingly Cryptic", "Avant-garde", "Bigoted", "Bloody-Minded",
            "Boastful", "Bookworm", "Bossy", "Bully", "Calculating", "Can-do attitude", "Chatterbox", "Chirpy",
            "Collects small animals", "Compulsive Liar", "Condescending", "Conniving", "Conspiracy theorist", "Creep",
            "Decadent", "Ditz", "Egomaniac", "Exquisite dresser", "Extravagant", "Fanatically loyal", "Fast-talker",
            "Femme Fatale", "Fiercely ambitious", "Fits of melancholy", "Flamboyant", "Folksy Wisdom", "Gossip",
            "Hard-boiled", "Hears voices", "Hillbilly", "Hothead", "Hypochondriac", "Iconoclast", "Idealistic",
            "Illiterate", "Incredibly persistent", "Insightful observer", "Into crystals", "Jack of all Trades",
            "Jerk", "Klutz", "Knows everybody", "Life of the party", "Love-struck", "Mad genius", "Magnetic Personality",
            "Manic", "Master Orator", "Militantly Vegan", "Misanthrope", "Miser", "Mopey", "Naïve", "Nerd",
            "No-nonsense", "Obsessive", "Old Fart", "Overeducated", "Paranoid", "Perfect Manners", "Pouty",
            "Power-hungry", "Prickly", "Proselytizer", "Ruthless", "Sadist", "Self-destructive", "Self-important",
            "Self-pitying", "Senile", "Serene", "Shameless Flirt", "Slacker", "Slimy", "Slovenly", "Snarky", "Snitch",
            "Snob", "Social butterfly", "Sophist", "Spacey", "Terrible memory", "Thick", "Toady", "Totally unreliable",
            "Twitchy", "Vain", "Vengeful", "Village idiot", "Well-Travelled", "Whiner", "Wild Child", "Wisecracking",
            "World-weary"
        };

        public static readonly List<string> Voice = new List<string>
        {
            "authoritative", "caring", "cheery", "conversational", "casual", "enthusiastic", "firm", "formal",
            "frank", "friendly", "hesitant", "humorous", "informative", "irreverent", "matter-of-fact", "nostalgic",
            "passionate", "playful", "professional", "respectful", "serious", "sympathetic", "upbeat", "arrogant",
            "disdainful", "haughty", "lofty", "lordly", "patronizing", "pedantic", "pompous", "pontificating",
            "pretentious", "self-important", "smarty-pants", "smug", "snobby", "snooty", "superior", "austere",
            "croaky", "dry", "forceful", "grating", "growly", "hateful", "hokey", "insincere", "nasally", "sarcastic",
            "snarky", "snarly", "sullen", "unapologetic", "wavering", "whiny", "breaking", "brittle", "coarse",
            "flat", "gravelly", "gruff", "guttural", "high pitched", "hoarse", "husky", "low pitched", "mellow",
            "monotone", "plaintive", "raspy", "resonant", "rough", "scratchy", "squeaky", "stilted", "strong",
            "trembling", "boisterous", "booming", "screeching", "feeble", "loud", "lowered", "penetrating", "quiet",
            "raucous", "ringing", "shrill", "soft-spoken", "strident", "varied", "weak", "whisper", "bright",
            "captivating", "comforting", "deep", "ethereal", "feathery", "hypnotic", "lilting", "mesmerizing",
            "modulated", "musical", "provocative", "regal", "romantic", "smoky", "soothing", "sweet"
        };

        public static readonly List<string> trvlSkill = new List<string>
        { "Guns", "Blades", "Brawling", "Pilot", "Comms", "Admin", "Frwd Obs", "Navigation", "Gunnery", "Broker", "Carouse",
            "Gambling", "Jack of All Trades", "Ships Boat", "Vehicles", "Vacc Suit", "Medical", "Computer", "Engineering",
            "Mechanical", "Streetwise", "Electronics", "Leader", "Tactics", "Forgery", "Steward", "Bribery", "Demolitions",
            "Recon", "Heavy Weapons", "Gravitics", "Aircraft", "Watercraft", "Liaison", "Trader" 
        };

        // You can later add:
        // public static readonly List<string> AlienSpeciesNames = new List<string> { ... };
    }
}
