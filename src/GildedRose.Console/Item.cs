namespace GildedRose.Console
{
    public interface Item
    {
        string Name { get; set; }

        int SellIn { get; set; }

        int Quality { get; set; }

        void Update();
    }

    public class AgeingItem : Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
        {
            IncreaseQuality();
            DecreaseSellIn();

            if (HasPassedSellByDate())
            {
                IncreaseQuality();
            }
        }

        private bool HasPassedSellByDate()
        {
            return this.SellIn < 0;
        }

        private void IncreaseQuality()
        {
            if (this.Quality < 50)
            {
                this.Quality = this.Quality + 1;
            }
        }

        private void DecreaseSellIn()
        {
            this.SellIn = this.SellIn - 1;
        }
    }

    public class DesirableEventItem : Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
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

        private bool HasPassedSellByDate()
        {
            return this.SellIn < 0;
        }

        private void IncreaseQuality()
        {
            if (this.Quality < 50)
            {
                this.Quality = this.Quality + 1;
            }
        }

        private void DecreaseSellIn()
        {
            this.SellIn = this.SellIn - 1;
        }
    }

    public class LegendaryItem : Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
        {

        }
    }

    public class ConjuredItem : Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
        {
            DecreaseQuality();
            DecreaseQuality();
            DecreaseSellIn();
        }

        private void DecreaseSellIn()
        {
            this.SellIn = this.SellIn - 1;
        }

        private void DecreaseQuality()
        {
            if (this.Quality > 0)
            {
                this.Quality = this.Quality - 1;
            }
        }
    }

    public class PerishableItem : Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
        {
            DecreaseQuality();
            DecreaseSellIn();

            if (HasPassedSellByDate())
            {
                DecreaseQuality();
            }
        }

        private bool HasPassedSellByDate()
        {
            return this.SellIn < 0;
        }

        private void DecreaseSellIn()
        {
            this.SellIn = this.SellIn - 1;
        }

        private void DecreaseQuality()
        {
            if (this.Quality > 0)
            {
                this.Quality = this.Quality - 1;
            }
        }
    }
}