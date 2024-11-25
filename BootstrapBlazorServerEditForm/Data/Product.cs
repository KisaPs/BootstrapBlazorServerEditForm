namespace BootstrapBlazorServerEditForm.Data;

public class Product
{
    public static int Id = 1;
    public string ProductId { get; set; } = Id.ToString();
    public string ProductName { get; set; } = "Product_" + Id++;
    public int Price { get; set; } = new Random().Next(10, 10000);
    public bool IsSale { get; set; }
    public int PriceSale {  get; set; }
}
