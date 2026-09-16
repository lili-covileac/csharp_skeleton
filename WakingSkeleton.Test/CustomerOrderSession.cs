namespace WakingSkeleton.Test;

public class CustomerOrderSession
{
    private IProductStock _productStock;

    public CustomerOrderSession(IProductStock productStock)
    {
        _productStock = productStock;
    }

    public void AddItemsToOrder(int itemId, string itemDescription, int quantity)
    {
        _productStock.HoldStock(itemId, itemDescription, quantity);
    }
}