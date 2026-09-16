namespace WakingSkeleton.Test;

public interface IProductStock
{
    void HoldStock(int itemId, string itemDescription, int quantity);
}