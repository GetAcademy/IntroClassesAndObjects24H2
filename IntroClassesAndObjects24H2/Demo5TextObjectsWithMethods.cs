using IntroClassesAndObjects24H2.Demo5;

namespace IntroClassesAndObjects24H2
{
    internal class Demo5TextObjectsWithMethods
    {
        public static void Run()
        {
            var labelX = new Label();
            var labels = new Label[]
            {
                new Label("Terje", 10, 3, 1, 0, ConsoleColor.Blue),
                new Label("Per", 3, 10, 0, 1, ConsoleColor.Red),
                new Label("Pål", 5, 5, 2, 1, ConsoleColor.Yellow),
            };

            while (true)
            {
                Console.Clear();
                foreach (var label in labels)
                {
                    label.Show();
                    label.Move();
                }
                Thread.Sleep(500);
            }

            Console.ResetColor();
            Console.SetCursorPosition(1, 15);
        }
        public static void OldRun()
        {
            var myTextObjects = new Label[]
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

            foreach (var textObject in myTextObjects)
            {
                Console.SetCursorPosition(textObject.Col, textObject.Row);
                Console.Write(textObject.Text);
            }
        }
    }
}
