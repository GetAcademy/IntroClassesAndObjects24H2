using IntroClassesAndObjects24H2.Demo1;

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
            var textObject1 = new Label
            {
                Text = "Terje",
                Col = 10,
                Row = 3
            };
            var textObject2 = new Label
            {
                Text = "Per",
                Col = 3,
                Row = 10
            };
            var myTextObjects = new Label[]
            {
                textObject1,
                textObject2,
            };

            var myTextObjectsB = new Label[]
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
            };
        }
    }
}
