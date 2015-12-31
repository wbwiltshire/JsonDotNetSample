using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BaseObjectScenario
{
    class Program
    {
        private static JsonData<Language> languages { get; set; }
        private static JsonDataWithError<Favorites> favorites { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Running Base Object Scenario");
            Console.WriteLine();

            Initialize();

            //Test the serialization/deserialization
            //TestLanguage();
            TestFavorite();

            Console.WriteLine("Press <enter> key to continue...");
            Console.ReadLine();
        }

        #region Initialize
        //private static IList<Language> Initialize()
        private static void Initialize()
        {
            languages = new JsonData<Language>() {
                data = new List<Language>() {
                    new Language()
                    {
                        Id = 7,
                        Abbreviation = "en",
                        Name = "English",
                        EnglishName = "English"
                    },
                    new Language()
                    {
                        Id = 27,
                        Abbreviation = "zh",
                        Name = "cccccc",
                        EnglishName = "Chinese"
                    },
                    new Language()
                    {
                        Id = 8,
                        Abbreviation = "sv",
                        Name = "Svenska",
                        EnglishName = "Swedish"
                    }
                }
            };

            favorites = new JsonDataWithError<Favorites>()
            {
                errors = String.Empty,
                data = new Favorites() 
                {
                    Favs = new int[] { 1, 2, 99 }
                    //Favs = new List<Favorite>()
                    //{
                    //    new Favorite() { Id = 1 },
                    //    new Favorite() { Id = 2 },
                    //    new Favorite() { Id = 99 }
                    //}
                }
            };
        }

        #endregion

        #region TestLanguage
        private static void TestLanguage()
        {
            string objectString = String.Empty;

            objectString = JsonConvert.SerializeObject(languages, Formatting.Indented, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            Console.WriteLine(String.Format("ObjectString {0}", objectString));

            //Now test if we can deserialize it
            Console.WriteLine();

            var dlanguages = JsonConvert.DeserializeObject<JsonData<Language>>(objectString);
            Console.WriteLine("Languages:");
            Console.WriteLine(String.Format("{0}", dlanguages));
        }
        #endregion

        #region TestFavorite
        private static void TestFavorite()
        {
            string objectString = String.Empty;

            objectString = JsonConvert.SerializeObject(favorites, Formatting.Indented, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            Console.WriteLine(String.Format("ObjectString {0}", objectString));

            //Now test if we can deserialize it
            Console.WriteLine();

            var dFavorites = JsonConvert.DeserializeObject<JsonDataWithError<Favorites>>(objectString);
            Console.WriteLine("Favorites:");
            Console.WriteLine(String.Format("{0}", dFavorites));
        }
        #endregion
    }
}
