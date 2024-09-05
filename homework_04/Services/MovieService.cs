using homework_04.Models;

namespace homework_04.Services
{
    public static class MovieService
    {
        private static int id = 1;
        private static List<Movie> Movies { get; set; }

        public static void Seed()
        {
            Movies = new List<Movie>()
            {
                new Movie()
                {
                    Id = id++,
                    Title = "Підбурювачі",
                    Poster = "https://uaserials.pro/posters/8929.jpg",
                    Director = "Даг Лайман",
                    Style = "Кримінал",
                    ShortDescription =
                        "Рорі та Коббі — несподівані спільники: батько, що зневірився, і колишній" +
                        "в'язень, які об'єдналися для пограбування. Коли все йде не за планом, вони, разом з" +
                        "несподіваним спільником, психотерапевтом Рорі, намагаються втекти від поліції та мстивого" +
                        "ватажка гангстерів.",
                    Sessions = new List<Session>()
                    {
                        new Session()
                        {
                            Id = 1,
                            Date = new DateTime(2024, 12, 13),
                            Time = new TimeOnly(17, 30)
                        },
                        new Session()
                        {
                            Id = 2,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(13, 20)
                        },
                        new Session()
                        {
                            Id = 3,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(17, 30)
                        },
                    }
                },
                new Movie()
                {
                    Id = id++,
                    Title = "Королівство планети мавп",
                    Poster = "https://uaserials.pro/posters/8871.jpg",
                    Director = "Вес Болл",
                    Style = "Фантастика",
                    ShortDescription =
                        "Мавпи — домінуючий вид, який гармонійно співіснує, а люди приречені на життя" +
                        "в тіні. Поки новий тиранічний мавпячий вождь будує свою імперію, одна молода мавпа вирушає" +
                        "у виснажливу подорож. Ця мандрівка змусить поставити під сумнів усе, що вона знала про" +
                        "минуле, і зробити вибір, який визначить майбутнє як мавп, так і людей.",
                    Sessions = new List<Session>()
                    {
                        new Session()
                        {
                            Id = 1,
                            Date = new DateTime(2024, 12, 13),
                            Time = new TimeOnly(17, 30)
                        },
                        new Session()
                        {
                            Id = 2,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(13, 20)
                        },
                        new Session()
                        {
                            Id = 3,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(17, 30)
                        },
                    }
                },
                new Movie()
                {
                    Id = id++,
                    Title = "Забери мене на місяць",
                    Poster = "https://uaserials.pro/posters/8983.jpg",
                    Director = "Грег Берланті",
                    Style = "Комедія",
                    ShortDescription =
                        "У 1961 році, на тлі досягнень Радянського Союзу в космічних перегонах," +
                        "президент США Джон Ф. Кеннеді оголошує на всю країну, що протягом цього десятиліття" +
                        "американська нація зможе відправити людину на Місяць. Так починається програма пілотованих" +
                        "польотів у космос «Аполлон», яка через дорожнечу та безліч аварій не користується" +
                        "підтримкою громадськості. НАСА наймає спеціаліста з маркетингу Келлі Джонс, щоб покращити" +
                        "суспільний імідж космічної програми, а також доручає їй зняти фальшиву висадку на Місяць на" +
                        "випадок, якщо справжній політ зазнає невдачі...",
                    Sessions = new List<Session>()
                    {
                        new Session()
                        {
                            Id = 1,
                            Date = new DateTime(2024, 12, 13),
                            Time = new TimeOnly(17, 30)
                        },
                        new Session()
                        {
                            Id = 2,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(13, 20)
                        },
                        new Session()
                        {
                            Id = 3,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(17, 30)
                        },
                    }
                },
                new Movie()
                {
                    Id = id++,
                    Title = "Казки на ніч",
                    Poster = "https://uaserials.pro/posters/8988.jpg",
                    Director = "Адам Шенкман",
                    Style = "Комедія",
                    ShortDescription =
                        "Якось увечері, залишившись придивитися за своїми племінниками, Скітер" +
                        "Бронсон розповідає казку на ніч, ще не підозрюючи, що вигадані персонажі почнуть оживати...",
                    Sessions = new List<Session>()
                    {
                        new Session()
                        {
                            Id = 1,
                            Date = new DateTime(2024, 12, 13),
                            Time = new TimeOnly(17, 30)
                        },
                        new Session()
                        {
                            Id = 2,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(13, 20)
                        },
                        new Session()
                        {
                            Id = 3,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(17, 30)
                        },
                    }
                },
                new Movie()
                {
                    Id = id++,
                    Title = "Каскадер",
                    Poster = "https://uaserials.pro/posters/8678.jpg",
                    Director = "Девід Літч",
                    Style = "Комедія",
                    ShortDescription =
                        "Після травми на зйомках каскадер Кольт Сіверс вже півтора року як пішов із професії, працює" +
                        "паркувальником і звинувачує себе за той невдалий трюк. Раптом йому дзвонить продюсерка та" +
                        "просить терміново прилетіти до Австралії, де його колишня дівчина-оператор Джоді знімає" +
                        "свій режисерський дебют, масштабну фантастику «Металшторм». Після приїзду з'ясовується, що" +
                        "Джоді бачити його не рада, а також справа ускладняться зникненням виконавця головної ролі —" +
                        "зірки бойовиків, у якого Кольт колись був дублером...",
                    Sessions = new List<Session>()
                    {
                        new Session()
                        {
                            Id = 1,
                            Date = new DateTime(2024, 12, 13),
                            Time = new TimeOnly(17, 30)
                        },
                        new Session()
                        {
                            Id = 2,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(13, 20)
                        },
                        new Session()
                        {
                            Id = 3,
                            Date = new DateTime(2024, 12, 16),
                            Time = new TimeOnly(17, 30)
                        },
                    }
                },
            };
        }

        public static List<Movie> GetAllMovies() => Movies;

        public static Movie GetMovieById(int id) => Movies.FirstOrDefault(movie => movie.Id == id)!;

        public static List<Movie> FindMovieByTitle(string searchValue)
        {
            string lowerSearchValue = searchValue.ToLower();

            IEnumerable<Movie> MovieEnumerable = Movies.FindAll(
                movie =>
                {
                    string title = movie.Title;
                    string lowerTitle = title.ToLower();

                    return lowerTitle.Contains(lowerSearchValue);
                }
            );

            return MovieEnumerable.ToList();
        }

        public static void AddMovie(Movie Movie)
        {
            Movie.Id = id++;

            Movies.Add(Movie);
        }

        public static int GetMovieIndex(int movieId) => Movies.FindIndex(movie => movie.Id == movieId);

        public static void UpdateMovie(Movie movie)
        {
            int id = movie.Id;
            int index = GetMovieIndex(id);

			Movies[index] = movie;
        }

        public static void DeleteMovieById(int id)
        {
            Movie movie = GetMovieById(id);

            Movies.Remove(movie);
        }

        public static void AddSession(int id, Session session)
        {
            Movie movie = GetMovieById(id);
            movie.Sessions.Add(session);

            UpdateMovie(movie);
        }

        public static Session GetSessionById(int movieId, int sessionId)
        {
            Movie movie = GetMovieById(movieId);
            Session session = movie.Sessions.Find(session => session.Id == sessionId)!;

            return session;
        }

        public static void DeleteSessionById(int movieId, int sessionId)
        {
            Session session = GetSessionById(movieId, sessionId);
            Movie movie = GetMovieById(movieId);
            
            movie.Sessions.Remove(session);
        }

        public static int GetSessionIndex(Movie movie, int sessionId)
        {
            return movie.Sessions.FindIndex(s => s.Id == sessionId);
		}

        public static void UpdateSession(int movieId, Session session)
        {
            Movie movie = GetMovieById(movieId);
            int sessionId = session.Id;
            int index = GetSessionIndex(movie, sessionId);
            
            movie.Sessions[index] = session;

            UpdateMovie(movie);
        }
    }
}