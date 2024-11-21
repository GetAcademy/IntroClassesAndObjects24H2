using IntroClassesAndObjects24H2.Demo1;
using IntroClassesAndObjects24H2.Demo3;

namespace IntroClassesAndObjects24H2
{
    internal class Demo3Model
    {
        public static void Run()
        {
            /* 
              const model = {
                 myApp: {
                    loggedInUser: 'terje',
                    currentPage: 'main',
                    number: 7,
                 },
                 counter: 5,
                 myTextObjects: [
                    {
                       text: 'Terje',
                       col: 10,
                       row: 3,
                    },
                    {
                       text: 'Torje',
                       col: 3,
                       row: 10,
                    },
                ];
              };
            */

            var model = new Model
            {
                MyApp = new App
                {
                    LoggedInUser = "Terje",
                    CurrentPage = "main",
                    Number = 7,
                },
                Counter = 5,
                MyTextObjects = new Label[]
                {
                    new Label
                    {
                        Text = "Terje",
                        Col = 10,
                        Row = 3
                    },
                    new Label
                    {
                        Text = "Per",
                        Col = 3,
                        Row = 10
                    },
                }
            };
        }
    }
}
