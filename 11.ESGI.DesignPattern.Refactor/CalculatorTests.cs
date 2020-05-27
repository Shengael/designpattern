﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace _11.ESGI.DesignPattern.Refactor
{
    public class CalculatorTests
    {
        [Fact]
        public void GoldenMaster()
        {
            var dump = "+5 Dexterity Vest, 10, 20 - Aged Brie, 2, 0 - Elixir of the Mongoose, 5, 7 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 15, 20 - Backstage passes to a TAFKAL80ETC concert, 10, 49 - Backstage passes to a TAFKAL80ETC concert, 5, 49 - +5 Dexterity Vest, 9, 19 - Aged Brie, 1, 1 - Elixir of the Mongoose, 4, 6 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 14, 21 - Backstage passes to a TAFKAL80ETC concert, 9, 50 - Backstage passes to a TAFKAL80ETC concert, 4, 50 - +5 Dexterity Vest, 8, 18 - Aged Brie, 0, 2 - Elixir of the Mongoose, 3, 5 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 13, 22 - Backstage passes to a TAFKAL80ETC concert, 8, 50 - Backstage passes to a TAFKAL80ETC concert, 3, 50 - +5 Dexterity Vest, 7, 17 - Aged Brie, -1, 4 - Elixir of the Mongoose, 2, 4 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 12, 23 - Backstage passes to a TAFKAL80ETC concert, 7, 50 - Backstage passes to a TAFKAL80ETC concert, 2, 50 - +5 Dexterity Vest, 6, 16 - Aged Brie, -2, 6 - Elixir of the Mongoose, 1, 3 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 11, 24 - Backstage passes to a TAFKAL80ETC concert, 6, 50 - Backstage passes to a TAFKAL80ETC concert, 1, 50 - +5 Dexterity Vest, 5, 15 - Aged Brie, -3, 8 - Elixir of the Mongoose, 0, 2 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 10, 25 - Backstage passes to a TAFKAL80ETC concert, 5, 50 - Backstage passes to a TAFKAL80ETC concert, 0, 50 - +5 Dexterity Vest, 4, 14 - Aged Brie, -4, 10 - Elixir of the Mongoose, -1, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 9, 27 - Backstage passes to a TAFKAL80ETC concert, 4, 50 - Backstage passes to a TAFKAL80ETC concert, -1, 0 - +5 Dexterity Vest, 3, 13 - Aged Brie, -5, 12 - Elixir of the Mongoose, -2, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 8, 29 - Backstage passes to a TAFKAL80ETC concert, 3, 50 - Backstage passes to a TAFKAL80ETC concert, -2, 0 - +5 Dexterity Vest, 2, 12 - Aged Brie, -6, 14 - Elixir of the Mongoose, -3, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 7, 31 - Backstage passes to a TAFKAL80ETC concert, 2, 50 - Backstage passes to a TAFKAL80ETC concert, -3, 0 - +5 Dexterity Vest, 1, 11 - Aged Brie, -7, 16 - Elixir of the Mongoose, -4, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 6, 33 - Backstage passes to a TAFKAL80ETC concert, 1, 50 - Backstage passes to a TAFKAL80ETC concert, -4, 0 - +5 Dexterity Vest, 0, 10 - Aged Brie, -8, 18 - Elixir of the Mongoose, -5, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 5, 35 - Backstage passes to a TAFKAL80ETC concert, 0, 50 - Backstage passes to a TAFKAL80ETC concert, -5, 0 - +5 Dexterity Vest, -1, 8 - Aged Brie, -9, 20 - Elixir of the Mongoose, -6, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 4, 38 - Backstage passes to a TAFKAL80ETC concert, -1, 0 - Backstage passes to a TAFKAL80ETC concert, -6, 0 - +5 Dexterity Vest, -2, 6 - Aged Brie, -10, 22 - Elixir of the Mongoose, -7, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 3, 41 - Backstage passes to a TAFKAL80ETC concert, -2, 0 - Backstage passes to a TAFKAL80ETC concert, -7, 0 - +5 Dexterity Vest, -3, 4 - Aged Brie, -11, 24 - Elixir of the Mongoose, -8, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 2, 44 - Backstage passes to a TAFKAL80ETC concert, -3, 0 - Backstage passes to a TAFKAL80ETC concert, -8, 0 - +5 Dexterity Vest, -4, 2 - Aged Brie, -12, 26 - Elixir of the Mongoose, -9, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 1, 47 - Backstage passes to a TAFKAL80ETC concert, -4, 0 - Backstage passes to a TAFKAL80ETC concert, -9, 0 - +5 Dexterity Vest, -5, 0 - Aged Brie, -13, 28 - Elixir of the Mongoose, -10, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, 0, 50 - Backstage passes to a TAFKAL80ETC concert, -5, 0 - Backstage passes to a TAFKAL80ETC concert, -10, 0 - +5 Dexterity Vest, -6, 0 - Aged Brie, -14, 30 - Elixir of the Mongoose, -11, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -1, 0 - Backstage passes to a TAFKAL80ETC concert, -6, 0 - Backstage passes to a TAFKAL80ETC concert, -11, 0 - +5 Dexterity Vest, -7, 0 - Aged Brie, -15, 32 - Elixir of the Mongoose, -12, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -2, 0 - Backstage passes to a TAFKAL80ETC concert, -7, 0 - Backstage passes to a TAFKAL80ETC concert, -12, 0 - +5 Dexterity Vest, -8, 0 - Aged Brie, -16, 34 - Elixir of the Mongoose, -13, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -3, 0 - Backstage passes to a TAFKAL80ETC concert, -8, 0 - Backstage passes to a TAFKAL80ETC concert, -13, 0 - +5 Dexterity Vest, -9, 0 - Aged Brie, -17, 36 - Elixir of the Mongoose, -14, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -4, 0 - Backstage passes to a TAFKAL80ETC concert, -9, 0 - Backstage passes to a TAFKAL80ETC concert, -14, 0 - +5 Dexterity Vest, -10, 0 - Aged Brie, -18, 38 - Elixir of the Mongoose, -15, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -5, 0 - Backstage passes to a TAFKAL80ETC concert, -10, 0 - Backstage passes to a TAFKAL80ETC concert, -15, 0 - +5 Dexterity Vest, -11, 0 - Aged Brie, -19, 40 - Elixir of the Mongoose, -16, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -6, 0 - Backstage passes to a TAFKAL80ETC concert, -11, 0 - Backstage passes to a TAFKAL80ETC concert, -16, 0 - +5 Dexterity Vest, -12, 0 - Aged Brie, -20, 42 - Elixir of the Mongoose, -17, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -7, 0 - Backstage passes to a TAFKAL80ETC concert, -12, 0 - Backstage passes to a TAFKAL80ETC concert, -17, 0 - +5 Dexterity Vest, -13, 0 - Aged Brie, -21, 44 - Elixir of the Mongoose, -18, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -8, 0 - Backstage passes to a TAFKAL80ETC concert, -13, 0 - Backstage passes to a TAFKAL80ETC concert, -18, 0 - +5 Dexterity Vest, -14, 0 - Aged Brie, -22, 46 - Elixir of the Mongoose, -19, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -9, 0 - Backstage passes to a TAFKAL80ETC concert, -14, 0 - Backstage passes to a TAFKAL80ETC concert, -19, 0 - +5 Dexterity Vest, -15, 0 - Aged Brie, -23, 48 - Elixir of the Mongoose, -20, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -10, 0 - Backstage passes to a TAFKAL80ETC concert, -15, 0 - Backstage passes to a TAFKAL80ETC concert, -20, 0 - +5 Dexterity Vest, -16, 0 - Aged Brie, -24, 50 - Elixir of the Mongoose, -21, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -11, 0 - Backstage passes to a TAFKAL80ETC concert, -16, 0 - Backstage passes to a TAFKAL80ETC concert, -21, 0 - +5 Dexterity Vest, -17, 0 - Aged Brie, -25, 50 - Elixir of the Mongoose, -22, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -12, 0 - Backstage passes to a TAFKAL80ETC concert, -17, 0 - Backstage passes to a TAFKAL80ETC concert, -22, 0 - +5 Dexterity Vest, -18, 0 - Aged Brie, -26, 50 - Elixir of the Mongoose, -23, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -13, 0 - Backstage passes to a TAFKAL80ETC concert, -18, 0 - Backstage passes to a TAFKAL80ETC concert, -23, 0 - +5 Dexterity Vest, -19, 0 - Aged Brie, -27, 50 - Elixir of the Mongoose, -24, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -14, 0 - Backstage passes to a TAFKAL80ETC concert, -19, 0 - Backstage passes to a TAFKAL80ETC concert, -24, 0 - +5 Dexterity Vest, -20, 0 - Aged Brie, -28, 50 - Elixir of the Mongoose, -25, 0 - Sulfuras, Hand of Ragnaros, 0, 80 - Sulfuras, Hand of Ragnaros, -1, 80 - Backstage passes to a TAFKAL80ETC concert, -15, 0 - Backstage passes to a TAFKAL80ETC concert, -20, 0 - Backstage passes to a TAFKAL80ETC concert, -25, 0 - ";

            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
            };

            var app = new Calculator(Items);

            var output = "";

            for (var i = 0; i < 31; i++)
            {
                for (var j = 0; j < Items.Count; j++)
                {
                    output += Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality + " - ";
                }
                app.UpdateQuality();
            }

            Assert.Equal(dump, output);
        }
    }
}
