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
                MyTextObjects = new TextObject[]
                {
                    new TextObject
                    {
                        Text = "Terje",
                        Col = 10,
                        Row = 3
                    },
                    new TextObject
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
