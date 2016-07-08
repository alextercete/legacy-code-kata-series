namespace GildedRose.Console
{
    public abstract class Item
    {
        string Name { get; set; }

        int SellIn { get; set; }

        int Quality { get; set; }

        public abstract void Update();

        protected bool HasPassedSellByDate()
        {
            return this.SellIn < 0;
        }

        protected void IncreaseQuality()
        {
            if (this.Quality < 50)
            {
                this.Quality = this.Quality + 1;
            }
        }

        protected void DecreaseSellIn()
        {
            this.SellIn = this.SellIn - 1;
        }

        protected void DecreaseQuality()
        {
            if (this.Quality > 0)
            {
                this.Quality = this.Quality - 1;
            }
        }
    }

    public class AgeingItem : Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override void Update()
        {
            IncreaseQuality();
            DecreaseSellIn();

            if (HasPassedSellByDate())
            {
                IncreaseQuality();
            }
        }
    }

    public class DesirableEventItem : Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override void Update()
        {
            // Tickets are more valuable when an event is closer
            if (this.SellIn <= 10)
            {
                IncreaseQuality();
            }

            // They increase in value much more the closer we are to the event
            if (this.SellIn <= 5)
            {
                IncreaseQuality();
            }

            IncreaseQuality();
            DecreaseSellIn();

            if (HasPassedSellByDate())
            {
                this.Quality = 0;
            }
        }
    }

    public class LegendaryItem : Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override void Update()
        {

        }
    }

    public class ConjuredItem : Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override void Update()
        {
            DecreaseQuality();
            DecreaseQuality();
            DecreaseSellIn();
        }
    }

    public class PerishableItem : Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override void Update()
        {
            DecreaseQuality();
            DecreaseSellIn();

            if (HasPassedSellByDate())
            {
                DecreaseQuality();
            }
        }
    }
}