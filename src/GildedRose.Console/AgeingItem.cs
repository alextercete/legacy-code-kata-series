namespace GildedRose.Console
{
    public class AgeingItem : Item
    {
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
}