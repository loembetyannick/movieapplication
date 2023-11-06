﻿using MovieAPI.Models;

namespace MovieAPI.Helper
{
    public class MovieGenerator
    {
        public IEnumerable<Movie>? _movies;
        public MovieGenerator()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie(1, "15/12/2021", "Spider-Man: No Way Home", "Peter Parker is unmasked and no longer able to separate his normal life from the high-stakes of being a super-hero. When he asks for help from Doctor Strange the stakes become even more dangerous, forcing him to discover what it truly means to be Spider-Man.", 5083.954, 8940, 8.3, "en", "Action, Adventure, Science Fiction", "https://image.tmdb.org/t/p/original/1g0dhYtq4irTY1GPXvft6k4YLjm.jpg"),
                new Movie(2, "01/03/2022", "The Batman", "In his second year of fighting crime, Batman uncovers corruption in Gotham City that connects to his own family while facing a serial killer known as the Riddler.", 3827.658, 1151, 8.1, "en", "Crime, Mystery, Thriller", "https://image.tmdb.org/t/p/original/74xTEgt7R36Fpooo50r9T25onhq.jpg"),
                new Movie(3, "25/02/2022", "No Exit", "Stranded at a rest stop in the mountains during a blizzard, a recovering addict discovers a kidnapped child hidden in a car belonging to one of the people inside the building which sets her on a terrifying struggle to identify who among them is the kidnapper.", 2618.087, 122, 6.3, "en", "Thriller", "https://image.tmdb.org/t/p/original/vDHsLnOWKlPGmWs0kGfuhNF4w5l.jpg"),
                new Movie(4, "24/11/2021", "Encanto", "The tale of an extraordinary family, the Madrigals, who live hidden in the mountains of Colombia, in a magical house, in a vibrant town, in a wondrous, charmed place called an Encanto. The magic of the Encanto has blessed every child in the family with a unique gift from super strength to the power to heal—every child except one, Mirabel. But when she discovers that the magic surrounding the Encanto is in danger, Mirabel decides that she, the only ordinary Madrigal, might just be her exceptional family's last hope.", 2402.201, 5076, 7.7, "en", "Animation, Comedy, Family, Fantasy", "https://image.tmdb.org/t/p/original/4j0PNHkMr5ax3IA8tjtxcmPU3QT.jpg"),
                new Movie(5, "22/12/2021", "The King's Man", "As a collection of history's worst tyrants and criminal masterminds gather to plot a war to wipe out millions, one man must race against time to stop them.", 1895.511, 1793, 7, "en", "Action, Adventure, Thriller, War", "https://image.tmdb.org/t/p/original/aq4Pwv5Xeuvj6HZKtxyd23e6bE9.jpg"),
                new Movie(6, "07/01/2022", "The Commando", "An elite DEA agent returns home after a failed mission when his family makes an unexpected discovery in their house – a stash of money worth $3 million. They soon face the danger and threat of a newly released criminal and his crew, who will do whatever it takes to retrieve the money, including kidnap the agent’s daughters. Stakes are high and lives are at risk in this head-to-head battle as the agent stops at nothing to protect his family against the money-hungry criminals.", 1750.484, 33, 6.6, "en", "Action, Crime, Thriller", "https://image.tmdb.org/t/p/original/pSh8MyYu5CmfyWEHzv8FEARH2zq.jpg"),
                new Movie(7, "12/01/2022", "Scream", "Twenty-five years after a streak of brutal murders shocked the quiet town of Woodsboro, a new killer has donned the Ghostface mask and begins targeting a group of teenagers to resurrect secrets from the town’s deadly past.", 1675.161, 821, 6.8, "en", "Horror, Mystery, Thriller", "https://image.tmdb.org/t/p/original/kZNHR1upJKF3eTzdgl5V8s8a4C3.jpg"),
                new Movie(8, "10/02/2022", "Kimi", "A tech worker with agoraphobia discovers recorded evidence of a violent crime but is met with resistance when she tries to report it. Seeking justice, she must do the thing she fears the most: she must leave her apartment.", 1601.782, 206, 6.3, "en", "Thriller", "https://image.tmdb.org/t/p/original/okNgwtxIWzGsNlR3GsOS0i0Qgbn.jpg"),
                new Movie(9, "17/02/2022", "Fistful of Vengeance", "A revenge mission becomes a fight to save the world from an ancient threat when superpowered assassin Kai tracks a killer to Bangkok.", 1594.013, 114, 5.3, "en", "Action, Crime, Fantasy", "https://image.tmdb.org/t/p/original/3cccEF9QZgV9bLWyupJO41HSrOV.jpg"),
                new Movie(10, "03/11/2021", "Eternals", "The Eternals are a team of ancient aliens who have been living on Earth in secret for thousands of years. When an unexpected tragedy forces them out of the shadows, they are forced to reunite against mankind’s most ancient enemy, the Deviants.", 1537.406, 4726, 7.2, "en", "Science Fiction", "https://image.tmdb.org/t/p/original/zByhtBvX99ZiCQhac1sh9d9r6nb.jpg"),
                new Movie(11, "18/02/2022", "Pursuit", "Detective Breslin crosses paths with Calloway, a ruthless hacker desperate to find his wife, who has been kidnapped by a drug cartel. When Calloway escapes police custody, Breslin joins forces with a no-nonsense female cop to reclaim his prisoner. But is Calloway’s crime-boss father somehow involved in this explosive situation?", 1500.523, 16, 5.9, "en", "Action, Crime, Thriller", "https://image.tmdb.org/t/p/original/wYihSXWYqN8Ejsdut2P1P0o97N0.jpg"),
                new Movie(12, "06/08/2021", "My Hero Academia: World Heroes' Mission", "A mysterious group called Humarize strongly believes in the Quirk Singularity Doomsday theory which states that when quirks get mixed further in with future generations, that power will bring forth the end of humanity. In order to save everyone, the Pro-Heroes around the world ask UA Academy heroes-in-training to assist them and form a world-class selected hero team. It is up to the heroes to save the world and the future of heroes in what is the most dangerous crisis to take place yet in My Hero Academia.", 1485.064, 100, 7.3, "ja", "Animation, Action, Fantasy, Adventure", "https://image.tmdb.org/t/p/original/4NUzcKtYPKkfTwKsLjwNt8nRIXV.jpg"),
                new Movie(13, "25/02/2022", "Restless", "After going to extremes to cover up an accident, a corrupt cop's life spirals out of control when he starts receiving threats from a mysterious witness.", 1468.377, 107, 5.9, "fr", "Action, Thriller, Crime", "https://image.tmdb.org/t/p/original/aw4GGsRwhQtyLsjzC7dsAahfCDY.jpg"),
                new Movie(14, "02/12/2021", "Nightmare Alley", "An ambitious carnival man with a talent for manipulating people with a few well-chosen words hooks up with a female psychiatrist who is even more dangerous than he is.", 1455.144, 952, 7.1, "en", "Crime, Drama, Thriller", "https://image.tmdb.org/t/p/original/680klE0dIreQQOyWKFgNnCAJtws.jpg"),
                new Movie(15, "28/01/2022", "The Ice Age Adventures of Buck Wild", "The fearless one-eyed weasel Buck teams up with mischievous possum brothers Crash & Eddie as they head off on a new adventure into Buck's home: The Dinosaur World.", 1431.307, 737, 7.1, "en", "Animation, Comedy, Adventure, Family", "https://image.tmdb.org/t/p/original/zzXFM4FKDG7l1ufrAkwQYv2xvnh.jpg"),
                new Movie(16, "25/02/2022", "Hotel Transylvania: Transformania", "When Van Helsing's mysterious invention, the 'Monsterfication Ray,' goes haywire, Drac and his monster pals are all transformed into humans, and Johnny becomes a monster. In their new mismatched bodies, Drac and Johnny must team up and race across the globe to find a cure before it's too late, and before they drive each other crazy.", 1373.778, 288, 7, "en", "Animation, Family, Fantasy, Comedy, Adventure", "https://image.tmdb.org/t/p/original/teCy1egGQa0y8ULJvlrDHQKnxBL.jpg"),
                new Movie(17, "18/02/2022", "Texas Chainsaw Massacre", "In this sequel, influencers looking to breathe new life into a Texas ghost town encounter Leatherface, an infamous killer who wears a mask of human skin.", 1312.79, 521, 5.1, "en", "Horror", "https://image.tmdb.org/t/p/original/meRIRfADEGVo65xgPO6eZvJ0CRG.jpg"),
                new Movie(18, "28/01/2022", "The Requin", "A couple on a romantic getaway find themselves stranded at sea when a tropical storm sweeps away their villa. In order to survive, they are forced to fight the elements, while sharks circle below.", 1252.317, 65, 4.6, "en", "Thriller", "https://image.tmdb.org/t/p/original/i0z8g2VRZP3dhVvvSMilbOZMKqR.jpg"),
                new Movie(19, "04/02/2022", "Looop Lapeta", "When her boyfriend loses a mobster's cash, Savi races against the clock to save the day — if only she can break out of a curious cycle of dead ends.", 1240.946, 31, 6, "hi", "Action, Comedy, Crime", "https://image.tmdb.org/t/p/original/onGdT8sYi89drvSJyEJnft97rOq.jpg"),
            };
            _movies = movies;
        }

    }
}