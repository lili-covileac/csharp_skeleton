namespace WakingSkeleton.Test;
using Moq;

[TestFixture]
public class Tests
{

    [Test]
    public void AddingItemToOrderUpdatesStockWhenStockAvailable()
    {
        Mock<IProductStock> productStock = new Mock<IProductStock>();
        var customerOrderSession = new CustomerOrderSession(productStock.Object);
        customerOrderSession.AddItemsToOrder(327, "Ibanez Tube Screamer", 1);
        productStock.Verify(productStock => productStock.HoldStock(327, "Ibanez Tube Screamer", 1), Times.Once);
    }
}