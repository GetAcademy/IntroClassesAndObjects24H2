namespace IntroClassesAndObjects24H2
{
    internal class Demo2Array
    {
        public static void Run()
        {
            /*
                let myTextObjects = [            
                    {
                        text: 'Terje',
                        col: 10,
                        row: 3,
                    },
                    {
                       text: 'Per',
                       col: 3,
                       row: 10,
                    },
                ];
             */
            var textObject1 = new TextObject
            {
                Text = "Terje",
                Col = 10,
                Row = 3
            };
            var textObject2 = new TextObject
            {
                Text = "Per",
                Col = 3,
                Row = 10
            };
            var myTextObjects = new TextObject[]
            {
                textObject1,
                textObject2,
            };

            var myTextObjectsB = new TextObject[]
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
            };
        }
    }
}
