namespace GildedRose.Console
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public static void UpdateItem(Item item)
        {
            var isBackstage = item.Name == "Backstage passes to a TAFKAL80ETC concert";
            var isBrie = item.Name == "Aged Brie";
            var isSulfuras = item.Name == "Sulfuras, Hand of Ragnaros";

            if (isBrie)
            {
                UpdateAgeingItem(item);
            }
            else if (isBackstage)
            {
                UpdateDesirableEventItem(item);
            }
            else if (isSulfuras)
            {
                UpdateLegendaryItem(item);
            }
            else
            {
                UpdatePerishableItem(item);
            }
        }

        private static void UpdateAgeingItem(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }

        private static void UpdateDesirableEventItem(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 11)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                if (item.SellIn < 6)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - item.Quality;
            }
        }

        private static void UpdateLegendaryItem(Item item)
        {
        }

        private static void UpdatePerishableItem(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
        }
    }
}