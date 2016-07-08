namespace GildedRose.Console
{
    public class PerishableItem : Item
    {
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