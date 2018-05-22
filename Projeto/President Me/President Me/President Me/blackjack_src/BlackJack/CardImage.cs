/*
 * Copyright (C) 2007 Coolsoft Company. All rights reserved.
 * Read licence.txt
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace BlackJack
{
    public enum CardSymbol 
    {
        Spade,
        Club,
        Hart,
        Diamond
    }

    class CardImage
    {
        static public Image LoadCardImage(int card, CardSymbol symbol)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cards");
            filePath = Path.Combine(filePath, ((int)symbol).ToString() + "kar" + card + ".gif");

            if (!File.Exists(filePath))
                return null;

            return Image.FromFile(filePath);
        }

        public static readonly int CARD_HEIGHT = 96;
        public static readonly int CARD_WIDTH = 71;
    }
}
