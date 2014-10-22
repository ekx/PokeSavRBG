using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokeSavRBG
{
    enum Pokemon
    {
        Rizeros = 0x01,
        Kangama = 0x02,
        Nidoranm = 0x03,
        Piepi = 0x04,
        Habitak = 0x05,
        Voltobal = 0x06,
        Nidoking = 0x07,
        Lahmus = 0x08,
        Bisaknosp = 0x09,
        Kokowei = 0x0A,
        Schlurp = 0x0B,
        Owei = 0x0C,
        Sleima = 0x0D,
        Gengar = 0x0E,
        Nidoranw = 0x0F,
        Nidoqueen = 0x10,
        Tragosso = 0x11,
        Rihorn = 0x12,
        Lapras = 0x13,
        Arkani = 0x14,
        Mew = 0x15,
        Garados = 0x16,
        Muschas = 0x17,
        Tentacha = 0x18,
        Nebulak = 0x19,
        Sichlor = 0x1A,
        Sterndu = 0x1B,
        Turtok = 0x1C,
        Pinsir = 0x1D,
        Tangela = 0x1E,
        Fukano = 0x21,
        Onix = 0x22,
        Ibitak = 0x23,
        Taubsi = 0x24,
        Flegmon = 0x25,
        Kadabra = 0x26,
        Georok = 0x27,
        Chaneira = 0x28,
        Maschok = 0x29,
        Pantimos = 0x2A,
        Kicklee = 0x2B,
        Nockchan = 0x2C,
        Arbok = 0x2D,
        Parasek = 0x2E,
        Enton = 0x2F,
        Traumato = 0x30,
        Geowaz = 0x31,
        Magmar = 0x33,
        Elektek = 0x35,
        Magneton = 0x36,
        Smogon = 0x37,
        Menki = 0x39,
        Jurob = 0x3A,
        Digda = 0x3B,
        Tauros = 0x3C,
        Porenta = 0x40,
        Bluzuk = 0x41,
        Dragoran = 0x42,
        Dodu = 0x46,
        Quaputzi = 0x47,
        Rossana = 0x48,
        Lavados = 0x49,
        Arktos = 0x4A,
        Zapdos = 0x4B,
        Ditto = 0x4C,
        Mauzi = 0x4D,
        Krabby = 0x4E,
        Vulpix = 0x52,
        Vulnona = 0x53,
        Pikachu = 0x54,
        Raichu = 0x55,
        Dratini = 0x58,
        Dragonir = 0x59,
        Kabuto = 0x5A,
        Kabutops = 0x5B,
        Seeper = 0x5C,
        Seemon = 0x5D,
        Sandan = 0x60,
        Sandamer = 0x61,
        Amonitas = 0x62,
        Amoroso = 0x63,
        Pummeluff = 0x64,
        Knuddeluff = 0x65,
        Evoli = 0x66,
        Flamara = 0x67,
        Blitza = 0x68,
        Aquana = 0x69,
        Machollo = 0x6A,
        Zubat = 0x6B,
        Rettan = 0x6C,
        Paras = 0x6D,
        Quapsel = 0x6E,
        Quappo = 0x6F,
        Hornliu = 0x70,
        Kokuna = 0x71,
        Bibor = 0x72,
        Dodri = 0x74,
        Rasaff = 0x75,
        Digdri = 0x76,
        Omot = 0x77,
        Jugong = 0x78,
        Raupy = 0x7B,
        Safcon = 0x7C,
        Smettbo = 0x7D,
        Machomei = 0x7E,
        Entoron = 0x80,
        Hypno = 0x81,
        Golbat = 0x82,
        Mewtu = 0x83,
        Relaxo = 0x84,
        Karpador = 0x85,
        Sleimok = 0x88,
        Kingler = 0x8A,
        Austos = 0x8B,
        Lektrobal = 0x8D,
        Pixi = 0x8E,
        Smogmog = 0x8F,
        Snobilikat = 0x90,
        Knogga = 0x91,
        Apollo = 0x93,
        Abra = 0x94,
        Simsala = 0x95,
        Tauboga = 0x96,
        Tauboss = 0x97,
        Starmie = 0x98,
        Bisasam = 0x99,
        Bisaflor = 0x9A,
        Tentoxa = 0x9B,
        Goldini = 0x9D,
        Golking = 0x9E,
        Ponita = 0xA3,
        Gallopa = 0xA4,
        Rattfratz = 0xA5,
        Rattikarl = 0xA6,
        Nidorino = 0xA7,
        Nidorina = 0xA8,
        Kleinstein = 0xA9,
        Porygon = 0xAA,
        Aerodactyl = 0xAB,
        Magnetilo = 0xAD,
        Glumanda = 0xB0,
        Schiggy = 0xB1,
        Glutexo = 0xB2,
        Schillok = 0xB3,
        Glurak = 0xB4,
        Myrapla = 0xB9,
        Duflor = 0xBA,
        Giflor = 0xBB,
        Knofensa = 0xBC,
        Ultrigaria = 0xBD,
        Sarzenia = 0xBE,
        Keines = 0x00,
        Ende = 0xFF
    }

    enum Status
    {
        GES = 0x00,
        SLF = 0x04,
        GIF = 0x08,
        BRN = 0x10,
        FRZ = 0x20,
        PAR = 0x40
    }

    enum Type
    {
        Normal = 0x00,
        Kampf = 0x01,
        Flug = 0x02,
        Gift = 0x03,
        Boden = 0x04,
        Gestein = 0x05,
        Käfer = 0x07,
        Geist = 0x08,
        Feuer = 0x14,
        Wasser = 0x15,
        Pflanze = 0x16,
        Elektro = 0x17,
        Psycho = 0x18,
        Eis = 0x19,
        Drache = 0x1A
    }

    enum Moves
    {
        Pfund = 0x01,
        Karateschlag = 0x02,
        Duplexhieb = 0x03,
        Kometenhieb = 0x04,
        Megahieb = 0x05,
        Zahltag = 0x06,
        Feuerschlag = 0x07,
        Eishieb = 0x08,
        Donnerschlag = 0x09,
        Kratzer = 0x0A,
        Klammer = 0x0B,
        Guillotine = 0x0C,
        Klingensturm = 0x0D,
        Schwerttanz = 0x0E,
        Zerschneider = 0x0F,
        Windstoß = 0x10,
        Flügelschlag = 0x11,
        Wirbelwind = 0x12,
        Fliegen = 0x13,
        Klammergriff = 0x14,
        Slam = 0x15,
        Rankenhieb = 0x16,
        Stampfer = 0x17,
        Doppelkick = 0x18,
        Megakick = 0x19,
        Sprungkick = 0x1A,
        Fegekick = 0x1B,
        Sandwirbel = 0x1C,
        Kopfnuss = 0x1D,
        Hornattacke = 0x1E,
        Furienschlag = 0x1F,
        Hornbohrer = 0x20,
        Tackle = 0x21,
        BodySlam = 0x22,
        Wickel = 0x23,
        Bodycheck = 0x24,
        Fuchtler = 0x25,
        Risikotackle = 0x26,
        Rutenschlag = 0x27,
        Giftstachel = 0x28,
        Duonadel = 0x29,
        Nadelrakete = 0x2A,
        Silberblick = 0x2B,
        Biss = 0x2C,
        Heuler = 0x2D,
        Brüller = 0x2E,
        Gesang = 0x2F,
        Superschall = 0x30,
        Ultraschall = 0x31,
        Aussetzer = 0x32,
        Säure = 0x33,
        Glut = 0x34,
        Flammenwurf = 0x35,
        Weißnebel = 0x36,
        Aquaknarre = 0x37,
        Hydropumpe = 0x38,
        Surfer = 0x39,
        Eisstrahl = 0x3A,
        Blizzard = 0x3B,
        Psystrahl = 0x3C,
        Blubbstrahl = 0x3D,
        Aurorastrahl = 0x3E,
        Hyperstrahl = 0x3F,
        Schnabel = 0x40,
        Bohrschnabel = 0x41,
        Überroller = 0x42,
        Fußkick = 0x43,
        Konter = 0x44,
        Geowurf = 0x45,
        Stärke = 0x46,
        Absorber = 0x47,
        Megasauger = 0x48,
        Egelsamen = 0x49,
        Wachstum = 0x4A,
        Rasierblatt = 0x4B,
        Solarstrahl = 0x4C,
        Giftpuder = 0x4D,
        Stachelspore = 0x4E,
        Schlafpuder = 0x4F,
        Blättertanz = 0x50,
        Fadenschuss = 0x51,
        Drachenwut = 0x52,
        Feuerwirbel = 0x53,
        Donnerschock = 0x54,
        Donnerblitz = 0x55,
        Donnerwelle = 0x56,
        Donner = 0x57,
        Steinwurf = 0x58,
        Erdbeben = 0x59,
        Geofissur = 0x5A,
        Schaufler = 0x5B,
        Toxin = 0x5C,
        Konfusion = 0x5D,
        Psychokinese = 0x5E,
        Hypnose = 0x5F,
        Meditation = 0x60,
        Agilität = 0x61,
        Ruckzuckhieb = 0x62,
        Raserei = 0x63,
        Teleport = 0x64,
        Nachtnebel = 0x65,
        Mimikry = 0x66,
        Kreideschrei = 0x67,
        Doppelteam = 0x68,
        Genesung = 0x69,
        Härtner = 0x6A,
        Komprimator = 0x6B,
        Rauchwolke = 0x6C,
        Konfustrahl = 0x6D,
        Panzerschutz = 0x6E,
        Einigler = 0x6F,
        Barriere = 0x70,
        Lichtschild = 0x71,
        Dunkelnebel = 0x72,
        Reflektor = 0x73,
        Energiefokus = 0x74,
        Geduld = 0x75,
        Metronom = 0x76,
        Spiegeltrick = 0x77,
        Finale = 0x78,
        Eierbombe = 0x79,
        Schlecker = 0x7A,
        Smog = 0x7B,
        Schlammbad = 0x7C,
        Knochenkeule = 0x7D,
        Feuersturm = 0x7E,
        Kaskade = 0x7F,
        Schnapper = 0x80,
        Sternschauer = 0x81,
        Schädelwummer = 0x82,
        Dornkanone = 0x83,
        Umklammerung = 0x84,
        Amnesie = 0x85,
        Psykraft = 0x86,
        Weichei = 0x87,
        Turmkick = 0x88,
        Giftblick = 0x89,
        Traumfresser = 0x8A,
        Giftwolke = 0x8B,
        Stakkato = 0x8C,
        Blutsauger = 0x8D,
        Todeskuss = 0x8E,
        Himmelsfeger = 0x8F,
        Wandler = 0x90,
        Blubber = 0x91,
        Irrschlag = 0x92,
        Pilzspore = 0x93,
        Blitz = 0x94,
        Psywelle = 0x95,
        Platscher = 0x96,
        Säurepanzer = 0x97,
        Krabbhammer = 0x98,
        Explosion = 0x99,
        Kratzfurie = 0x9A,
        Knochmerang = 0x9B,
        Erholung = 0x9C,
        Steinhagel = 0x9D,
        Hyperzahn = 0x9E,
        Schärfer = 0x9F,
        Umwandlung = 0xA0,
        Triplette = 0xA1,
        Superzahn = 0xA2,
        Schlitzer = 0xA3,
        Delegator = 0xA4,
        Verzweifler = 0xA5,
        Keiner = 0x00
    }

    enum Items
    {
        Meisterball = 0x01,
        Hyperball = 0x02,
        Superball = 0x03,
        Pokeball = 0x04,
        Karte = 0x05,
        Fahrrad = 0x06,
        Mondstein = 0x0A,
        Gegengift = 0x0B,
        Feuerheiler = 0x0C,
        Eisheiler = 0x0D,
        Aufwecker = 0x0E,
        ParaHeiler = 0x0F,
        TopGenesung = 0x10,
        TopTrank = 0x11,
        Hypertrank = 0x12,
        Supertrank = 0x13,
        Trank = 0x14,
        Fluchtseil = 0x1D,
        Schutz = 0x1E,
        Altbernstein = 0x1F,
        Feuerstein = 0x20,
        Donnerstein = 0x21,
        Wasserstein = 0x22,
        KPPlus = 0x23,
        Protein = 0x24,
        Eisen = 0x25,
        Carbon = 0x26,
        Kalzium = 0x27,
        Sonderbonbon = 0x28,
        Domfossil = 0x29,
        Helixfossil = 0x2A,
        Öffner = 0x2B,
        RadCoupon = 0x2D,
        XTreffer = 0x2E,
        Blattstein = 0x2F,
        Türöffner = 0x30,
        Nugget = 0x31,
        //APPlus = 0x32,
        Pokepuppe = 0x33,
        Hyperheiler = 0x34,
        Beleber = 0x35,
        TopBeleber = 0x36,
        Megablock = 0x37,
        Superschutz = 0x38,
        TopSchutz = 0x39,
        Angriffsplus = 0x3A,
        Tafelwasser = 0x3C,
        Sprudel = 0x3D,
        Limonade = 0x3E,
        Bootsticket = 0x3F,
        Goldzähne = 0x40,
        XAngriff = 0x41,
        XAbwehr = 0x42,
        XTempo = 0x43,
        XSpezial = 0x44,
        Münzkorb = 0x45,
        EichsPacket = 0x46,
        Detektor = 0x47,
        SilphScope = 0x48,
        Pokeflöte = 0x49,
        Liftöffner = 0x4A,
        EPTeiler = 0x4B,
        Angel = 0x4C,
        Profiangel = 0x4D,
        Superangel = 0x4E,
        APPlus = 0x4F,
        Äther = 0x50,
        TopÄther = 0x51,
        Elixier = 0x52,
        TopElixier = 0x52,
        VM01 = 0xC4,
        VM02 = 0xC5,
        VM03 = 0xC6,
        VM04 = 0xC7,
        VM05 = 0xC8,
        TM01 = 0xC9,
        TM02 = 0xCA,
        TM03 = 0xCB,
        TM04 = 0xCC,
        TM05 = 0xCD,
        TM06 = 0xCE,
        TM07 = 0xCF,
        TM08 = 0xD0,
        TM09 = 0xD1,
        TM10 = 0xD2,
        TM11 = 0xD3,
        TM12 = 0xD4,
        TM13 = 0xD5,
        TM14 = 0xD6,
        TM15 = 0xD7,
        TM16 = 0xD8,
        TM17 = 0xD9,
        TM18 = 0xDA,
        TM19 = 0xDB,
        TM20 = 0xDC,
        TM21 = 0xDD,
        TM22 = 0xDE,
        TM23 = 0xDF,
        TM24 = 0xE0,
        TM25 = 0xE1,
        TM26 = 0xE2,
        TM27 = 0xE3,
        TM28 = 0xE4,
        TM29 = 0xE5,
        TM30 = 0xE6,
        TM31 = 0xE7,
        TM32 = 0xE8,
        TM33 = 0xE9,
        TM34 = 0xEA,
        TM35 = 0xEB,
        TM36 = 0xEC,
        TM37 = 0xED,
        TM38 = 0xEE,
        TM39 = 0xEF,
        TM40 = 0xF0,
        TM41 = 0xF1,
        TM42 = 0xF2,
        TM43 = 0xF3,
        TM44 = 0xF4,
        TM45 = 0xF5,
        TM46 = 0xF6,
        TM47 = 0xF7,
        TM48 = 0xF8,
        TM49 = 0xF9,
        TM50 = 0xFA,
        Keines = 0x00,
        Ende = 0xFF
    }

    struct Offsets
    {
        public static int PartyHeader = 0x2F2C;

        public static int PartyPokemon1 = 0x2F34;
        public static int PartyPokemon2 = 0x2F60;
        public static int PartyPokemon3 = 0x2F8C;
        public static int PartyPokemon4 = 0x2FB8;
        public static int PartyPokemon5 = 0x2FE4;
        public static int PartyPokemon6 = 0x3010;

        public static int PartyPokemon1Trainer = 0x303C;
        public static int PartyPokemon2Trainer = 0x3047;
        public static int PartyPokemon3Trainer = 0x3052;
        public static int PartyPokemon4Trainer = 0x305D;
        public static int PartyPokemon5Trainer = 0x3068;
        public static int PartyPokemon6Trainer = 0x3073;

        public static int PartyPokemon1Nick = 0x307E;
        public static int PartyPokemon2Nick = 0x3089;
        public static int PartyPokemon3Nick = 0x3094;
        public static int PartyPokemon4Nick = 0x309F;
        public static int PartyPokemon5Nick = 0x30AA;
        public static int PartyPokemon6Nick = 0x30B5;
        
        public static int CurrentHP = 0x01;
        public static int LVL1 = 0x03;
        public static int Status = 0x04;
        public static int Typ1 = 0x05;
        public static int Typ2 = 0x06;
        public static int Move1 = 0x08;
        public static int Move2 = 0x09;
        public static int Move3 = 0x0A;
        public static int Move4 = 0x0B;
        public static int TrainerID = 0x0C;
        public static int Experience = 0x0E;
        public static int HPEV = 0x11;
        public static int ATTEV = 0x13;
        public static int DEFEV = 0x15;
        public static int SPDEV = 0x17;
        public static int SPCEV = 0x19;
        public static int ADIV = 0x1B;
        public static int SSIV = 0x1C;
        public static int PP1 = 0x1D;
        public static int PP2 = 0x1E;
        public static int PP3 = 0x1F;
        public static int PP4 = 0x20;
        public static int LVL2 = 0x21;
        public static int HP = 0x22;
        public static int ATT = 0x24;
        public static int DEF = 0x26;
        public static int SPD = 0x28;
        public static int SPC = 0x2A;
    }

    struct save
    {
        static public byte[] data;
    }

    class Conv
    {
        private static string pLetterToString(byte data)
        {
            switch (data)
            {
                case 0x4F:
                    return "=";
                case 0x57:
                    return "#";
                case 0x51:
                    return "*";
                case 0x52:
                    return "A1";
                case 0x53:
                    return "A2";
                case 0x54:
                    return "PK";
                case 0x55:
                    return "+";
                case 0x58:
                    return "$";
                case 0x7F:
                    return " ";
                case 0x80:
                    return "A";
                case 0x81:
                    return "B";
                case 0x82:
                    return "C";
                case 0x83:
                    return "D";
                case 0x84:
                    return "E";
                case 0x85:
                    return "F";
                case 0x86:
                    return "G";
                case 0x87:
                    return "H";
                case 0x88:
                    return "I";
                case 0x89:
                    return "J";
                case 0x8A:
                    return "K";
                case 0x8B:
                    return "L";
                case 0x8C:
                    return "M";
                case 0x8D:
                    return "N";
                case 0x8E:
                    return "O";
                case 0x8F:
                    return "P";
                case 0x90:
                    return "Q";
                case 0x91:
                    return "R";
                case 0x92:
                    return "S";
                case 0x93:
                    return "T";
                case 0x94:
                    return "U";
                case 0x95:
                    return "V";
                case 0x96:
                    return "W";
                case 0x97:
                    return "X";
                case 0x98:
                    return "Y";
                case 0x99:
                    return "Z";
                case 0x9C:
                    return ":";
                case 0xA0:
                    return "a";
                case 0xA1:
                    return "b";
                case 0xA2:
                    return "c";
                case 0xA3:
                    return "d";
                case 0xA4:
                    return "e";
                case 0xA5:
                    return "f";
                case 0xA6:
                    return "g";
                case 0xA7:
                    return "h";
                case 0xA8:
                    return "i";
                case 0xA9:
                    return "j";
                case 0xAA:
                    return "k";
                case 0xAB:
                    return "l";
                case 0xAC:
                    return "m";
                case 0xAD:
                    return "n";
                case 0xAE:
                    return "o";
                case 0xAF:
                    return "p";
                case 0xB0:
                    return "q";
                case 0xB1:
                    return "r";
                case 0xB2:
                    return "s";
                case 0xB3:
                    return "t";
                case 0xB4:
                    return "u";
                case 0xB5:
                    return "v";
                case 0xB6:
                    return "w";
                case 0xB7:
                    return "x";
                case 0xB8:
                    return "y";
                case 0xB9:
                    return "z";
                case 0xBA:
                    return ",";
                case 0xBC:
                    return "'l";
                case 0xBD:
                    return "'s";
                case 0xBE:
                    return "'t";
                case 0xBF:
                    return "'v";
                case 0xE0:
                    return "'";
                case 0xE1:
                    return "PK";
                case 0xE2:
                    return "MN";
                case 0xE3:
                    return "-";
                case 0xE4:
                    return "'r";
                case 0xE5:
                    return "'m";
                case 0xE6:
                    return "?";
                case 0xE7:
                    return "!";
                case 0xE8:
                    return ".";
                case 0xF4:
                    return ",";
                case 0xF6:
                    return "0";
                case 0xF7:
                    return "1";
                case 0xF8:
                    return "2";
                case 0xF9:
                    return "3";
                case 0xFA:
                    return "4";
                case 0xFB:
                    return "5";
                case 0xFC:
                    return "6";
                case 0xFD:
                    return "7";
                case 0xFE:
                    return "8";
                case 0xFF:
                    return "9";
                default:
                    return "";
            }
        }

        public static string pStringToString(int offset, int length)
        {
            string temp = "";

            for (int c = 0; c < length; c++)
            {
                temp += Conv.pLetterToString(save.data[offset + c]);
            }

            return temp;
        }

        private static byte stringToPLetter(char val)
        {
            switch (val)
            {
                case '=':
                    return 0x4F;
                case '#':
                    return 0x57;
                case '*':
                    return 0x51;
                /*case 0x52:
                   return "A1";
               case 0x53:
                   return "A2";
               case 0x54:
                   return "PK";*/
                case '+':
                    return 0x55;
                case '$':
                    return 0x58;
                case ' ':
                    return 0x7F;
                case 'A':
                    return 0x80;
                case 'B':
                    return 0x81;
                case 'C':
                    return 0x82;
                case 'D':
                    return 0x83;
                case 'E':
                    return 0x84;
                case 'F':
                    return 0x85;
                case 'G':
                    return 0x86;
                case 'H':
                    return 0x87;
                case 'I':
                    return 0x88;
                case 'J':
                    return 0x89;
                case 'K':
                    return 0x8A;
                case 'L':
                    return 0x8B;
                case 'M':
                    return 0x8C;
                case 'N':
                    return 0x8D;
                case 'O':
                    return 0x8E;
                case 'P':
                    return 0x8F;
                case 'Q':
                    return 0x90;
                case 'R':
                    return 0x91;
                case 'S':
                    return 0x92;
                case 'T':
                    return 0x93;
                case 'U':
                    return 0x94;
                case 'V':
                    return 0x95;
                case 'W':
                    return 0x96;
                case 'X':
                    return 0x97;
                case 'Y':
                    return 0x98;
                case 'Z':
                    return 0x99;
                case ':':
                    return 0x9C;
                case 'a':
                    return 0xA0;
                case 'b':
                    return 0xA1;
                case 'c':
                    return 0xA2;
                case 'd':
                    return 0xA3;
                case 'e':
                    return 0xA4;
                case 'f':
                    return 0xA5;
                case 'g':
                    return 0xA6;
                case 'h':
                    return 0xA7;
                case 'i':
                    return 0xA8;
                case 'j':
                    return 0xA9;
                case 'k':
                    return 0xAA;
                case 'l':
                    return 0xAB;
                case 'm':
                    return 0xAC;
                case 'n':
                    return 0xAD;
                case 'o':
                    return 0xAE;
                case 'p':
                    return 0xAF;
                case 'q':
                    return 0xB0;
                case 'r':
                    return 0xB1;
                case 's':
                    return 0xB2;
                case 't':
                    return 0xB3;
                case 'u':
                    return 0xB4;
                case 'v':
                    return 0xB5;
                case 'w':
                    return 0xB6;
                case 'x':
                    return 0xB7;
                case 'y':
                    return 0xB8;
                case 'z':
                    return 0xB9;
                /*case ',':
                    return 0xBA;
                case "'1":
                    return 0xBC;
                case "'s":
                    return 0xBD;
                case "'t":
                    return 0xBE;
                case "'v":
                    return 0xBF;*/
                case '\'':
                    return 0xE0;
                /*case "PK":
                    return 0xE1;
                case "MN":
                    return 0xE2;*/
                case '-':
                    return 0xE3;
                /*case "'r":
                    return 0xE4;
                case "'m":
                    return 0xE5;*/
                case '?':
                    return 0xE6;
                case '!':
                    return 0xE7;
                case '.':
                    return 0xE8;
                case ',':
                    return 0xF4;
                case '0':
                    return 0xF6;
                case '1':
                    return 0xF7;
                case '2':
                    return 0xF8;
                case '3':
                    return 0xF9;
                case '4':
                    return 0xFA;
                case '5':
                    return 0xFB;
                case '6':
                    return 0xFC;
                case '7':
                    return 0xFD;
                case '8':
                    return 0xFE;
                case '9':
                    return 0xFF;
                case '%':
                    return 0x50;
                default:
                    return 0x00;
            }
        }

        public static void stringToPString(string val, int offset, int length)
        {
            val = val.PadRight(length, '%');

            for (int c = 0; c < length; c++)
            {
                save.data[offset + c] = stringToPLetter(val[c]);
            }
        }
    }
}
