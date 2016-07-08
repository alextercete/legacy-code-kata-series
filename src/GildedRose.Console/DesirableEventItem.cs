namespace GildedRose.Console
{
    public class DesirableEventItem : Item
    {
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