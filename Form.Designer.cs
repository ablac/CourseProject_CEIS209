﻿namespace Swoger_CourseProject_Part1
{
    partial class VideoManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.TextBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.allSongsButton = new System.Windows.Forms.Button();
            this.songListLabel = new System.Windows.Forms.Label();
            this.songList = new System.Windows.Forms.ListBox();
            this.titelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.clearSong = new System.Windows.Forms.Button();
            this.yearText = new System.Windows.Forms.TextBox();
            this.genreText = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addButton.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(122, 451);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(195, 78);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(117, 208);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(66, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // titleText
            // 
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(214, 201);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(335, 35);
            this.titleText.TabIndex = 0;
            // 
            // artistText
            // 
            this.artistText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistText.Location = new System.Drawing.Point(214, 242);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(335, 35);
            this.artistText.TabIndex = 1;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.artistLabel.Location = new System.Drawing.Point(117, 249);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(72, 29);
            this.artistLabel.TabIndex = 3;
            this.artistLabel.Text = "Artist";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(117, 331);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(68, 29);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Year";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.genreLabel.Location = new System.Drawing.Point(117, 290);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(85, 29);
            this.genreLabel.TabIndex = 5;
            this.genreLabel.Text = "Genre";
            // 
            // urlText
            // 
            this.urlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlText.Location = new System.Drawing.Point(214, 365);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(335, 35);
            this.urlText.TabIndex = 4;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(117, 372);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(63, 29);
            this.urlLabel.TabIndex = 9;
            this.urlLabel.Text = "URL";
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(636, 451);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(583, 352);
            this.outputText.TabIndex = 999;
            this.outputText.TabStop = false;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.detailsLabel.Location = new System.Drawing.Point(631, 419);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(94, 29);
            this.detailsLabel.TabIndex = 15;
            this.detailsLabel.Text = "Details";
            // 
            // allSongsButton
            // 
            this.allSongsButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.allSongsButton.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allSongsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allSongsButton.Location = new System.Drawing.Point(354, 451);
            this.allSongsButton.Name = "allSongsButton";
            this.allSongsButton.Size = new System.Drawing.Size(195, 78);
            this.allSongsButton.TabIndex = 6;
            this.allSongsButton.Text = "Show All Songs";
            this.allSongsButton.UseVisualStyleBackColor = false;
            this.allSongsButton.Click += new System.EventHandler(this.allSongsButton_Click);
            // 
            // songListLabel
            // 
            this.songListLabel.AutoSize = true;
            this.songListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.songListLabel.Location = new System.Drawing.Point(631, 50);
            this.songListLabel.Name = "songListLabel";
            this.songListLabel.Size = new System.Drawing.Size(122, 29);
            this.songListLabel.TabIndex = 17;
            this.songListLabel.Text = "Song List";
            // 
            // songList
            // 
            this.songList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 29;
            this.songList.Location = new System.Drawing.Point(636, 82);
            this.songList.Name = "songList";
            this.songList.Size = new System.Drawing.Size(583, 323);
            this.songList.TabIndex = 998;
            this.songList.TabStop = false;
            // 
            // titelName
            // 
            this.titelName.AutoSize = true;
            this.titelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelName.Location = new System.Drawing.Point(122, 50);
            this.titelName.Name = "titelName";
            this.titelName.Size = new System.Drawing.Size(493, 46);
            this.titelName.TabIndex = 997;
            this.titelName.Text = "CEIS 209 Video Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 996;
            this.label1.Text = "by Keith Swoger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 37);
            this.label2.TabIndex = 995;
            this.label2.Text = "November 2021";
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.findButton.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold);
            this.findButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findButton.Location = new System.Drawing.Point(122, 568);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(195, 78);
            this.findButton.TabIndex = 7;
            this.findButton.Text = "Find Song";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // clearSong
            // 
            this.clearSong.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearSong.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold);
            this.clearSong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearSong.Location = new System.Drawing.Point(354, 568);
            this.clearSong.Name = "clearSong";
            this.clearSong.Size = new System.Drawing.Size(195, 78);
            this.clearSong.TabIndex = 8;
            this.clearSong.Text = "Clear";
            this.clearSong.UseVisualStyleBackColor = false;
            this.clearSong.Click += new System.EventHandler(this.clearSong_Click);
            // 
            // yearText
            // 
            this.yearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearText.Location = new System.Drawing.Point(214, 324);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(335, 35);
            this.yearText.TabIndex = 3;
            // 
            // genreText
            // 
            this.genreText.AutoCompleteCustomSource.AddRange(new string[] {
            "2 Tone",
            "2-Step",
            "2-Tone",
            "4-Beat",
            "4×4",
            "8bit",
            "Acappella",
            "Acid Breaks",
            "Acid House",
            "Acid Jazz",
            "Acid Rock",
            "Acid Techno",
            "Acid Trance",
            "Acousmatic Music",
            "Acoustic Blues",
            "Adult Alternative",
            "Adult Contemporary",
            "Adult-Oriented Rock",
            "Africa",
            "African Blues",
            "African Heavy Metal",
            "African Hip Hop",
            "Afro Punk",
            "Afro-Beat",
            "Afro-Pop",
            "Aggrotech",
            "Alternative",
            "Alternative Country",
            "Alternative Dance",
            "Alternative Folk",
            "Alternative Rap",
            "Alternative Rock",
            "Alternativo",
            "Alternativo & Rock Latino",
            "Ambient",
            "Ambient Dub",
            "Ambient House",
            "Ambient Techno",
            "American Folk Revival",
            "American Traditional Rock",
            "Americana",
            "Anatolian Rock",
            "Anime",
            "Anison",
            "Anti-Folk",
            "Apala",
            "Arab Pop",
            "Arena Rock",
            "Argentine tango",
            "Art Punk",
            "Art Rock",
            "Asia",
            "Asian Underground",
            "Australia",
            "Australian Country",
            "Austropop",
            "Avant-Garde",
            "Avant-Garde Jazz",
            "Avantgarde Metal",
            "Axé",
            "Bachata",
            "Background",
            "Backstep",
            "Baggy",
            "Baila",
            "Baithak Gana",
            "Bakersfield Sound",
            "Baladas y Boleros",
            "Balearic Beat",
            "Balkan Pop",
            "Ballet",
            "Baltimore Club",
            "Barbershop",
            "Baroque",
            "Bassline",
            "Bebop",
            "Benga",
            "Berlin School",
            "Bhangra",
            "Bhojpuri",
            "Big Band",
            "Big Beat",
            "Bikutsi",
            "Bitpop",
            "Black Metal",
            "Blue Note",
            "Bluegrass",
            "Blues",
            "Blues Country",
            "Blues Rock",
            "Blues Shouter",
            "Blues-Rock",
            "Bolero",
            "Bongo Flava",
            "Boogie",
            "Bop",
            "Bossa Nova",
            "Bounce",
            "Bouncy House",
            "Bouncy Techno",
            "Brazilian",
            "Brazilian Rock",
            "Breakbeat",
            "Breakbeat Hardcore",
            "Breakcore",
            "Brega",
            "Brick City Club",
            "British Blues",
            "British Folk Revival",
            "British Invasion",
            "Britpop",
            "Britpunk",
            "Broken Beat",
            "Brostep",
            "Bubblegum Dance",
            "Bubblegum Pop",
            "C-Pop",
            "CCM",
            "Cajun",
            "Cajun Fiddle Tunes",
            "Calypso",
            "Canadian Blues",
            "Cantata",
            "Cantique",
            "Cantopop",
            "Cape Jazz",
            "Caribbean",
            "Carnatic",
            "Celtic",
            "Celtic Folk",
            "Chamber Music",
            "Chamber Pop",
            "Chanson",
            "Chant",
            "Chanukah",
            "Chap Hop",
            "Chicago Blues",
            "Chicago Hip Hop",
            "Chicago House",
            "Chicano",
            "Chicha",
            "Children’s Music",
            "Chill Out",
            "Chillstep",
            "Chillwave",
            "Chimurenga",
            "Chiptune",
            "Choral",
            "Choro",
            "Christian",
            "Christian & Gospel",
            "Christian Country",
            "Christian Hip Hop",
            "Christian Metal",
            "Christian Pop",
            "Christian Rap",
            "Christian Rock",
            "Christmas",
            "Christmas: Children’s",
            "Christmas: Classic",
            "Christmas: Classical",
            "Christmas: Comedy",
            "Christmas: Jazz",
            "Christmas: Modern",
            "Christmas: Pop",
            "Christmas: R&B",
            "Christmas: Religious",
            "Christmas: Rock",
            "Chutney",
            "Chutney Soca",
            "Classic",
            "Classic Blues",
            "Classic Christian",
            "Classic Country",
            "Classic Female Blues",
            "Classic Trance",
            "Classical",
            "Classical Crossover",
            "Close Harmony",
            "Club",
            "Club Dance",
            "Cock Rock",
            "Coldwave",
            "College Rock",
            "Comedy",
            "Commercial",
            "Compas",
            "Computer Music",
            "Concerto",
            "Concerto Grosso",
            "Conjunto",
            "Conjunto Progressive",
            "Conscious Hip Hop",
            "Contemporary Bluegrass",
            "Contemporary Blues",
            "Contemporary Celtic",
            "Contemporary Classical",
            "Contemporary Country",
            "Contemporary Folk",
            "Contemporary Gospel",
            "Contemporary Jazz",
            "Contemporary Latin",
            "Contemporary R&B",
            "Contemporary Singer",
            "Cool",
            "Country",
            "Country Blues",
            "Country Gospel",
            "Country Pop",
            "Country Rap",
            "Country Rock",
            "Country Soul",
            "Country-Rap",
            "Coupé-Décalé",
            "Cowboy",
            "Cowpunk",
            "Criolla",
            "Crossover",
            "Crossover Jazz",
            "Crossover Thrash",
            "Crunk",
            "Crunkcore",
            "Crust Punk (thx Haug)",
            "Cumbia",
            "Cumbia Rap",
            "Cybergrind",
            "Dance",
            "Dance Pop",
            "Dance-Punk",
            "Dance-Rock",
            "Dance-pop",
            "Dancehall",
            "Dangdut",
            "Dansband",
            "Dark Ambient",
            "Dark Blues",
            "Dark Electro",
            "Dark Psytrance",
            "Dark Wave",
            "Darkcore",
            "Darkside Jungle",
            "Darkstep",
            "Death Industrial",
            "Death Metal",
            "Deathcore",
            "Deep House",
            "Delta Blues",
            "Detroit Blues",
            "Detroit Hip Hop",
            "Detroit Techno",
            "Digital Hardcore",
            "Dirty South",
            "Disco",
            "Disco House",
            "Disney",
            "Diva House",
            "Dixieland",
            "Djent",
            "Doo Wop",
            "Doo-wop",
            "Doom Blues",
            "Doom Metal",
            "Doomcore",
            "Downtempo",
            "Dream House",
            "Dream Pop",
            "Dream Trance",
            "Drinking Songs",
            "Drone",
            "Drone Music",
            "Drum & Bass",
            "Drum\'n\'bass",
            "Drumfunk",
            "Drumstep",
            "Dub",
            "Dub Music",
            "Dubstep",
            "Dubstyle",
            "Dubtronica",
            "Dutch House",
            "EDM",
            "Early Music",
            "East Coast",
            "Easter",
            "Easy Listening",
            "Electric Blues",
            "Electro",
            "Electro Backbeat",
            "Electro House",
            "Electro Pop",
            "Electro-Grime",
            "Electro-Industrial",
            "Electro-swing",
            "Electroacoustic",
            "Electroacoustic Improvisation",
            "Electroclash",
            "Electronic",
            "Electronic Art Music",
            "Electronic Body Music",
            "Electronic Dance Music",
            "Electronic Rock",
            "Electronica",
            "Electronicore",
            "Electropop",
            "Electropunk",
            "Electroswing",
            "Elevator",
            "Emo",
            "EmoCore",
            "Emotional Hardcore",
            "Enka",
            "Environmental",
            "Ethereal Wave",
            "Ethio-jazz",
            "Ethnic Electronica",
            "Eurobeat",
            "Eurodance",
            "Europe",
            "Europop",
            "Exercise",
            "Experimental Rock",
            "Expressionist",
            "Fann At-Tanbura",
            "Field Recording",
            "Fijiri",
            "Filk Music",
            "Filmi",
            "Fitness",
            "Fitness & Workout",
            "Flamenco",
            "Florida Breaks",
            "Folk Blues",
            "Folk Metal",
            "Folk Music",
            "Folk Punk",
            "Folk-Rock",
            "Folktronica",
            "Foreign Cinema",
            "Forró",
            "France",
            "Franco-Country",
            "Freak Folk",
            "Free Jazz",
            "Free Tekno",
            "Freestyle House",
            "Freestyle Music",
            "Freestyle Rap",
            "French House",
            "French Pop",
            "Frevo",
            "Fuji Music",
            "Full on",
            "Funk",
            "Funk Carioca",
            "Funky House",
            "Furniture",
            "Fusion",
            "Future Garage)",
            "Futurepop",
            "G-Funk",
            "Gabber",
            "Game Boy",
            "Gangsta Rap",
            "Garage",
            "Genge",
            "German Folk",
            "German Pop",
            "Ghetto House",
            "Ghettotech",
            "Glam Metal",
            "Glam Rock",
            "Glitch",
            "Glitch Hop",
            "Glitch Pop",
            "Goa Trance",
            "Golden Age",
            "Gospel",
            "Gospel Blues",
            "Goth",
            "Gothic Metal",
            "Gothic Rock",
            "Gregorian Chant",
            "Grime",
            "Grind Core",
            "Grindcore",
            "Groove Metal",
            "Grunge",
            "Gulf and Western",
            "Gypsy Jazz",
            "Hair Metal",
            "Halloween",
            "Happy Hardcore",
            "Hard Bop",
            "Hard Dance",
            "Hard Nrg",
            "Hard Rock",
            "Hard Trance",
            "Hardbag",
            "Hardcore",
            "Hardcore Hip Hop",
            "Hardcore Punk",
            "Hardcore Rap",
            "Hardstep",
            "Hardstyle",
            "Harmonica Blues",
            "Hawaii",
            "Healing",
            "Heavy Metal",
            "Hellbilly Music",
            "Hi-NRG",
            "High Classical",
            "Highlife",
            "Hill Country Blues",
            "Hindustani",
            "Hip House",
            "Hip Pop",
            "Hip-Hop",
            "Hiplife",
            "Hokum Blues",
            "Holiday",
            "Holiday: Other",
            "Hong Kong English Pop",
            "Honky Tonk",
            "Horrorcore",
            "House",
            "Huayno",
            "Hyphy",
            "IDM/Experimental",
            "Idm",
            "Illbient",
            "Impressionist",
            "Indian Ghazal",
            "Indian Pop",
            "Indie Folk",
            "Indie Pop",
            "Indie Rock",
            "Indietronica",
            "Industrial",
            "Industrial Folk",
            "Industrial Hip Hop",
            "Industrial Metal",
            "Industrial Rock",
            "Inspirational",
            "Instrumental",
            "Instrumental Country",
            "Instrumental Hip Hop",
            "Intelligent Drum and Bass",
            "Iranian Pop",
            "Isicathamiya",
            "Isolationism",
            "Italo Dance",
            "Italo House",
            "J-Pop",
            "J-Punk",
            "J-Rock",
            "J-Ska",
            "J-Synth",
            "Jackin House",
            "Jam Bands",
            "Jangle Pop",
            "Japan",
            "Japanese House",
            "Japanese Pop",
            "Japanoise",
            "Jazz",
            "Jazz Blues",
            "Jazz Rap",
            "Jazz-Funk",
            "Jingles",
            "Jit",
            "Jump Blues",
            "Jump-Up",
            "Jumpstyle",
            "Jungle",
            "Jùjú",
            "K-Pop",
            "Kansas City Blues",
            "Kapuka",
            "Karaoke",
            "Kawaii Metal",
            "Kayokyoku",
            "Kayōkyoku",
            "Khaliji",
            "Kizomba",
            "Klezmer",
            "Korean Pop",
            "Kuduro",
            "Kwaito",
            "Kwela",
            "Lambada",
            "Laptronica",
            "Latin",
            "Latin Ballad",
            "Latin House",
            "Latin Jazz",
            "Latin Pop",
            "Latin Rap",
            "Lavani",
            "Laïkó",
            "Levenslied",
            "Liquid Dub",
            "Liquid Funk",
            "Live Coding",
            "Live Electronics",
            "Liwa",
            "Lo-fi",
            "Louisiana Blues",
            "Louisiana Swamp Pop",
            "Lounge",
            "Love Song",
            "Lovers Rock",
            "Low Bap",
            "Lowercase",
            "Lubbock Sound",
            "Luk Krung",
            "Luk Thung",
            "Lullabies",
            "Lyrical Hip Hop",
            "Madchester",
            "Mafioso Rap",
            "Mainstream Jazz",
            "Makina",
            "Makossa",
            "Maloya",
            "Mambo",
            "Mandopop",
            "Manila Sound",
            "Maracatu",
            "March",
            "Mariachi",
            "Marrabenta",
            "Mass Requiem",
            "Math Metal",
            "Math Rock",
            "Mathcore",
            "Mbalax",
            "Mbaqanga",
            "Mbube",
            "Medieval",
            "Meditation",
            "Memphis Blues",
            "Merengue",
            "Merengue Típico",
            "Merenrap",
            "Metal",
            "Metal Core",
            "Metalcore",
            "Mexican Pop",
            "Middle East",
            "Middle of the Road",
            "Midwest Hip Hop",
            "Minimal",
            "Minimal House",
            "Minimalism",
            "Modal Jazz",
            "Modern Blues",
            "Modern Classical",
            "Modern Composition",
            "Modern Metal",
            "Modern Soul",
            "Moombahton",
            "Morlam",
            "Morna",
            "Motorpop",
            "Motown",
            "Motswako",
            "Movie Soundtrack",
            "Museve",
            "Musicals",
            "Musique Concrète",
            "Méringue",
            "Música Popular Brasileira",
            "Música Sertaneja",
            "NY Blues",
            "Nashville Sound",
            "Nature",
            "Nederpop",
            "Neo-Soul",
            "Neoclassical Metal",
            "Neofolk",
            "Neotraditional Country",
            "Nerdcore",
            "Neue Deutsche Härte",
            "Neurofunk",
            "New Acoustic",
            "New Age",
            "New Beat",
            "New Jack Swing",
            "New Jersey Hip Hop",
            "New Mex",
            "New Orlean Blues",
            "New Rave",
            "New Romanticism",
            "New School Hip Hop",
            "New Wave",
            "New Wave Of British Heavy Metal",
            "Nintendocore",
            "Noise",
            "Noise Rock",
            "Nortec",
            "North America",
            "Northern Soul",
            "Novelty",
            "Nu Jazz",
            "Nu Metal",
            "Nu Skool Breaks",
            "Nuevo Flamenco",
            "Ode",
            "Old School Rap",
            "Oldschool Jungle",
            "Onkyokei",
            "Opera",
            "Oratorio",
            "Orchestral",
            "Orchestral Pop",
            "Orchestral Uplifting",
            "Organum",
            "Original Score",
            "Outlaw Country",
            "Pagan Metal",
            "Pagode",
            "Palm-Wine",
            "Parody Music",
            "Piano Blues",
            "Piedmont Blues",
            "Pinoy Pop",
            "Piphat",
            "Pirate Metal",
            "Polka",
            "Pop",
            "Pop Latino",
            "Pop Punk",
            "Pop Rap",
            "Pop Sunda",
            "Pop/Rock",
            "Popera",
            "Portuguese fado",
            "Post Hardcore",
            "Post Metal",
            "Post Punk",
            "Post-Disco",
            "Power Electronics",
            "Power Metal",
            "Power Noise",
            "Power Pop",
            "Praise",
            "Praise & Worship",
            "Prog-Rock",
            "Progressive",
            "Progressive Bluegrass",
            "Progressive Breaks",
            "Progressive Drum & Bass",
            "Progressive Folk",
            "Progressive House",
            "Progressive Metal",
            "Progressive Rock",
            "Progressive Techno",
            "Psybreaks",
            "Psychedelic",
            "Psychedelic Folk",
            "Psychedelic Pop",
            "Psychedelic Soul",
            "Psychobilly",
            "Psyprog",
            "Punk",
            "Punk Blues",
            "Punkabilly",
            "Punta",
            "Punta Rock",
            "Qawwali",
            "Quiet Storm",
            "R&B",
            "Ragga",
            "Ragga Jungle",
            "Raggacore",
            "Raggamuffin",
            "Ragini",
            "Ragtime",
            "Ragtime Blues",
            "Raison",
            "Ranchera",
            "Rap",
            "Rave Music",
            "Raíces",
            "Raï",
            "Reactionary Bluegrass",
            "Red Dirt",
            "Reggae",
            "Reggae 110",
            "Reggae Bultrón",
            "Reggae Fusion",
            "Reggae en Español",
            "Reggaeton y Hip-Hop",
            "Regional Mexicano",
            "Regstep",
            "Relaxation",
            "Renaissance",
            "Rhythm Blues",
            "Rock",
            "Rock & Roll",
            "Rock Latino",
            "Rockabilly",
            "Rocksteady",
            "Romantic",
            "Romantic Flow",
            "Roots Reggae",
            "Roots Rock",
            "Russian Pop",
            "Sakara",
            "Salsa y Tropical",
            "Samba",
            "Samba Rock",
            "Sambass",
            "Sawt",
            "Schlager",
            "Schranz",
            "Scouse House",
            "Sega",
            "Seggae",
            "Semba",
            "Sertanejo",
            "Shoegaze",
            "Sing-Along",
            "Singer",
            "Ska",
            "Skweee",
            "Sludge",
            "Smooth Jazz",
            "Soca",
            "Soft Rock",
            "Son",
            "Sonata",
            "SongWriter",
            "Sophisti-Pop",
            "Soukous",
            "Soul",
            "Soul Blues",
            "Sound Art",
            "Soundscape Composition",
            "Soundtrack",
            "South",
            "South Africa",
            "South America",
            "Southeast Asia",
            "Southern Gospel",
            "Southern Rock",
            "Southern Soul",
            "Space Age Pop",
            "Space House",
            "Space Rock",
            "Spanish Flamenco",
            "Spanish Reggae",
            "Spazzcore",
            "Speed Garage",
            "Speed Metal",
            "Speedcore",
            "Spoken Word",
            "St. Louis Blues",
            "St. Louis Hip Hop",
            "Stand-up Comedy",
            "Standards",
            "Steampunk",
            "Stoner Metal",
            "Stories",
            "String Quartet",
            "Sung Poetry",
            "Sunshine Pop",
            "Suomisaundi",
            "Surf",
            "Surf Pop",
            "Swamp Blues",
            "Swing",
            "Swing House",
            "Symphonic",
            "Symphonic Metal",
            "Symphony",
            "Synthcore",
            "Synthpop",
            "Synthpunk",
            "TV Soundtrack",
            "TV Themes",
            "Taarab",
            "Taiwanese Pop",
            "Tape Music",
            "Tech HouseTribal House",
            "Tech Trance",
            "Technical Death Metal",
            "Techno",
            "Techno-Dnb",
            "Techno-Folk",
            "Technopop",
            "Techstep",
            "Tecno Brega",
            "Tecnobrega",
            "Teen Pop",
            "Tejano",
            "Terrorcore",
            "Tex-Mex",
            "Texas Blues",
            "Texas County",
            "Thai Pop",
            "Thanksgiving",
            "Third Stream",
            "Thrash Metal",
            "Timba",
            "Time Lord Rock",
            "Toytown Techno",
            "Trad Jazz",
            "Traditional Bluegrass",
            "Traditional Celtic",
            "Traditional Country",
            "Traditional Folk",
            "Traditional Gospel",
            "Traditional Pop",
            "Traditional Pop Music",
            "Trance",
            "Trap",
            "Travel",
            "Trip Hop",
            "Trip-hop",
            "Tropicalia",
            "Truck-Driving Country",
            "Turbofolk",
            "Turkish Pop",
            "Turntablism",
            "Twin Cities Hip Hop",
            "Twoubadou",
            "UK Garage",
            "UK Hard House",
            "US Garage",
            "Uk Hardcore",
            "Underground Rap",
            "Uplifting Trance",
            "Urban Blues",
            "Urban Cowboy",
            "Vandeville",
            "Vaudeville",
            "Video Game Music",
            "Viking Metal",
            "Vispop",
            "Vocal",
            "Vocal House",
            "Vocal Jazz",
            "Vocal Pop",
            "Vocal Trance",
            "Warship",
            "Wedding Music",
            "West Coast Blues",
            "West Coast Rap",
            "Western",
            "Western Swing",
            "Witch House",
            "Wonky Pop",
            "Workout",
            "World",
            "Worldbeat",
            "Yorkshire Bleeps and Bass",
            "Zouglou",
            "Zouk",
            "Zouk-Lambada",
            "Zydeco"});
            this.genreText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.genreText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.genreText.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genreText.FormattingEnabled = true;
            this.genreText.Location = new System.Drawing.Point(214, 282);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(335, 36);
            this.genreText.TabIndex = 2;
            // 
            // VideoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 849);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.clearSong);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titelName);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.songListLabel);
            this.Controls.Add(this.allSongsButton);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addButton);
            this.Name = "VideoManager";
            this.Text = "Video Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Button allSongsButton;
        private System.Windows.Forms.Label songListLabel;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Label titelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button clearSong;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.ComboBox genreText;
    }
}
