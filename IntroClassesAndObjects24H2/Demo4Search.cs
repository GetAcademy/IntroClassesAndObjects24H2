using IntroClassesAndObjects24H2.Demo4;

namespace IntroClassesAndObjects24H2
{
    internal class Demo4Search
    {
        public static void Run()
        {
            /*
             let search = {
                text: 'terje',
                dates: {
                    includeFromAndTo: true,
                    from: {
                        day: 10,
                        month: 5,
                        year: 2023,
                    },
                    to: {
                        day: 10,
                        month: 5,
                        year: 2023,
                    },
                }
             }
             */

            var search = new Search
            {
                Text = "terje",
                Dates = new DateRange
                {
                    IncludeFromAndTo = true,
                    From = new Date
                    {
                        Day = 10,
                        Month = 5,
                        Year = 2023,
                    },
                    To = new Date
                    {
                        Day = 10,
                        Month = 5,
                        Year = 2023,
                    },
                }
            };
        }
    }
}
