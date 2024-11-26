namespace BootstrapBlazorServerEditForm.Data;

public class Product
{
    public static int Id = 1;
    public string ProductId { get; set; } = Id.ToString();
    public string ProductName { get; set; } = "Product_" + Id++;
    public int Price { get; set; } = new Random().Next(10, 10000);
    public bool IsSale { get; set; }
    public int PriceSale {  get; set; }


    public SaleType SaleType { get; set; }
    public string TypeDescription1 { get; set; } = "Description Type 1";
    public string TypeDescription2 { get; set; } = "Description Type 2";
    public string TypeDescription3 { get; set; } = "Description Type 3";
}

public enum SaleType
{
    Type1,
    Type2,
    Type3
}
