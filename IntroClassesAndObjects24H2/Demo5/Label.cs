namespace IntroClassesAndObjects24H2.Demo5
{
    class Label
    {
        public string Text;
        public int Col;
        public int Row;
        public int ColSpeed;
        public int RowSpeed;
        public ConsoleColor Color;

        public Label()
        {
        }

        public Label(string text, int col, int row, int colSpeed, int rowSpeed, ConsoleColor color)
        {
            Text = text;
            Col = col;  
            Row = row;
            ColSpeed = colSpeed;
            RowSpeed = rowSpeed;
            Color = color;
        }

        public void Show()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(Col, Row);
            Console.Write(Text);
        }

        public void Move()
        {
            Col += ColSpeed;
            Row += RowSpeed;
        }
    }
}
