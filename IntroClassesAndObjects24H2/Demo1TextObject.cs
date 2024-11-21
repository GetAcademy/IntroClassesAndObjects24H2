﻿namespace IntroClassesAndObjects24H2
{
    internal class Demo1TextObject
    {
        public static void Run()
        {
            /*
                Syntaks A:
                let myTextObject = {};
                myTextObject.text = 'Terje';
                myTextObject.col = 10;
                myTextObject.row = 3,
             */

            var myTextObjectA = new TextObject();
            myTextObjectA.Text = "Terje";
            myTextObjectA.Col = 10;
            myTextObjectA.Row = 3;

            /*
                Syntaks B:
                let myTextObject = {
                    text: 'Terje',
                    col: 10,
                    row: 3,
                }
             */

            var myTextObjectB = new TextObject
            {
                Text = "Terje",
                Col = 10,
                Row = 3
            };
        }
    }
}