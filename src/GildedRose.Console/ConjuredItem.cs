namespace GildedRose.Console
{
    public class ConjuredItem : Item
    {
        public override void Update()
        {
            DecreaseQuality();
            DecreaseQuality();
            DecreaseSellIn();
        }
    }
}