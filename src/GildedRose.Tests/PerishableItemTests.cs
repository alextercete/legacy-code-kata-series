using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests
{
    public class PerishableItemTests
    {
        [Test]
        public void StandardItemShouldLowerQualityAndSellInByOne()
        {
            var item = new PerishableItem { Name = "+5 Dexterity V333est", SellIn = 3, Quality = 6 };

            item.Update();

            Assert.AreEqual(5, item.Quality);
            Assert.AreEqual(2, item.SellIn);
        }

        [Test]
        public void StandardItemShouldLowerQualityTwiceAsFastWhenSellInIsNegative()
        {
            var item = new PerishableItem { Name = "+5 Dexterity Vest", SellIn = -2, Quality = 6 };

            item.Update();

            Assert.AreEqual(4, item.Quality);
            Assert.AreEqual(-3, item.SellIn);
        }

        [Test]
        public void StandardItemShouldLowerQualityTwiceAsFastWhenSellInIsZero()
        {
            var item = new PerishableItem { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 6 };

            item.Update();

            Assert.AreEqual(4, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }

        [Test]
        public void StandardItemQualityIsNeverNegative()
        {
            var item = new PerishableItem { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 0 };

            item.Update();
        
            Assert.AreEqual(0, item.Quality);
            Assert.AreEqual(9, item.SellIn);
        }
    }
}
