namespace GildedRose.Console
{
    public abstract class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

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
}