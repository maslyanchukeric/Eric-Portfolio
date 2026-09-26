import java.time.LocalDateTime;
import java.util.Scanner;

public class InventoryMain 
{
    static Scanner input = new Scanner(System.in);
    static int itemCount = 0;
    static Product[] items = new Product[100];

    public static void main(String[] args) 
    {
        initArray();
        showMenu();
        displayItems(items);

        Product searchedProduct = Search(items);

        if (searchedProduct == null)
        {
            System.out.println("Item could not be found");
        }
        else
        {
            System.out.println("Item Located");
            System.out.println(searchedProduct.toString());
        }
    }

    public static void showMenu()
    {
        System.out.println("\n===== Product Management Menu =====");
        System.out.println("1. Add Clothing Product");
        System.out.println("2. Add Digital Product");
        System.out.println("3. Add Electronics Product");
        System.out.println("4. View All Products");
        System.out.println("5. Search Product");
        System.out.println("6. Adjust Quantity");
        System.out.println("7. Update Product Name");
        System.out.println("8. Update Product Price");
        System.out.println("9. Delete Product");
        System.out.println("10. Calculate Total Prices");
        System.out.println("11. Filter Minimum Threshold");
        System.out.println("12. Exit");
        System.out.print("Enter your choice: ");
    }

    public static void initArray()
    {
        for (int i = 0; i < items.length; i++)
        {
            items[i] = null;
        }
    }

    public static void displayItems(Product[] productToDisplay)
    {
        if (itemCount == 0)
        {
            System.out.println("No products available");
            return;
        }

        System.out.println("\n===== Product List =====");

        for (int i = 0; i < itemCount; i++)
        {
            System.out.println(productToDisplay[i]);
        }
    }

    public static Product Search(Product[] products)
    {
        System.out.print("Please enter product name to search: ");
        String searchItem = input.nextLine();

        for (int i = 0; i < itemCount; i++)
        {
            if (products[i] != null && products[i].getProductName().equalsIgnoreCase(searchItem))
            {
                return products[i];
            }
        }

        return null;
    }

    public static void adjustQuantity()
    {
        System.out.print("Enter a product name to adjust quantity: ");
        String searchItem = input.nextLine();

        for (int i = 0; i < itemCount; i++)
        {
            if (items[i] != null && items[i].getProductName().equalsIgnoreCase(searchItem))
            {
                System.out.print("Enter new quantity: ");
                int newQuantity = input.nextInt();
                input.nextLine();

                items[i].setQuantity(newQuantity);
                System.out.println("Quantity updated successfully.");
                return;
            }
        }

        System.out.println("Product not found.");
    }

    public static void updateProductPrice()
    {
        System.out.print("Enter product name to update price: ");
        String searchItem = input.nextLine();

        for (int i = 0; i < itemCount; i++)
        {
            if (items[i] != null && items[i].getProductName().equalsIgnoreCase(searchItem))
            {
                System.out.print("Enter new price: ");
                double newPrice = input.nextDouble();
                input.nextLine();

                items[i].setPrice(newPrice);
                System.out.println("Product price updated successfully.");
                return;
            }
        }

        System.out.println("Product not found.");
    }

    public static void changeProductName(Product[] products)
    {
        Product productToBeChanged = Search(products);

        if (productToBeChanged == null)
        {
            System.out.println("Product not found.");
            return;
        }

        System.out.print("Please enter new product name: ");
        String changedProduct = input.nextLine();
        productToBeChanged.setProductName(changedProduct);
        System.out.println("Product name updated successfully.");
    }

    public static Clothing createNewClothing(String productName, int productID, double price, int quantity,
                                             String description, int minThreshold, int size, String color, String material)
    {
        Clothing clothing = new Clothing();
        clothing.setProductName(productName);
        clothing.setPoductID(productID);
        clothing.setPrice(price);
        clothing.setQuantity(quantity);
        clothing.setDescription(description);
        clothing.setMinimumThreshold(minThreshold);
        clothing.setSize(size);
        clothing.setColor(color);
        clothing.setMaterial(material);
        return clothing;
    }

    public static Electronics createNewElectronic(String productName, int productID, double price, int quantity,
                                                  String description, int minThreshold, int warrantyPeriod, char rating)
    {
        Electronics electronic = new Electronics();
        electronic.setProductName(productName);
        electronic.setPoductID(productID);
        electronic.setPrice(price);
        electronic.setQuantity(quantity);
        electronic.setDescription(description);
        electronic.setMinimumThreshold(minThreshold);
        electronic.setWarrantyPeriod(warrantyPeriod);
        electronic.setRating(rating);
        return electronic;
    }

    public static Digital createNewDigital(String productName, int productID, double price, int quantity,
                                           String description, int minThreshold, String link, LocalDateTime expirationDate)
    {
        Digital digital = new Digital(link, expirationDate);
        digital.setProductName(productName);
        digital.setPoductID(productID);
        digital.setPrice(price);
        digital.setQuantity(quantity);
        digital.setDescription(description);
        digital.setMinimumThreshold(minThreshold);
        return digital;
    }

    public static void deleteProduct()
    {
        System.out.print("Enter product name to delete: ");
        String searchItem = input.nextLine();

        for (int i = 0; i < itemCount; i++)
        {
            if (items[i] != null && items[i].getProductName().equalsIgnoreCase(searchItem))
            {
                for (int j = i; j < itemCount - 1; j++)
                {
                    items[j] = items[j + 1];
                }

                items[itemCount - 1] = null;
                itemCount--;
                System.out.println("Product deleted successfully.");
                return;
            }
        }

        System.out.println("Product not found.");
    }

    public static void calculateTotalPrice()
    {
        double total = 0;

        for (int i = 0; i < itemCount; i++)
        {
            total += items[i].getprice() * items[i].quantity();
        }

        System.out.println("Total inventory value: $" + total);
    }

    public static void filterByMinimumThreshold()
    {
        System.out.println("\n===== Products Below Minimum Threshold =====");
        boolean found = false;

        for (int i = 0; i < itemCount; i++)
        {
            if (items[i].quantity() < items[i].minimumThreshold())
            {
                System.out.println(items[i]);
                found = true;
            }
        }

        if (!found)
        {
            System.out.println("No products below the minimum threshold.");
        }
    }

    public static Product[] SortByPriceAscending(Product[] unsortedProducts)
    {
        Product[] sortedProducts = unsortedProducts.clone();

        for (int maxIndex = itemCount - 1; maxIndex > 0; maxIndex--)
        {
            for (int i = 0; i < maxIndex; i++)
            {
                if (sortedProducts[i].getprice() > sortedProducts[i + 1].getprice())
                {
                    Product temp = sortedProducts[i];
                    sortedProducts[i] = sortedProducts[i + 1];
                    sortedProducts[i + 1] = temp;
                }
            }
        }

        return sortedProducts;
    }
}