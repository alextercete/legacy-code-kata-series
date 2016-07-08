namespace GildedRose.Console
{
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
}