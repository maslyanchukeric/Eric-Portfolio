import java.util.*;

public class Eggs {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        int eggAmount;
        int dozenEggs;
        int looseEggs;
        double dozenEggPrice = 3.25;
        double looseEggPrice = 0.45;
        double totalPrice;

        System.out.println("Enter amount of eggs you want to order");
        eggAmount = input.nextInt();

        dozenEggs = eggAmount / 12;
        looseEggs = eggAmount % 12;

        totalPrice = (dozenEggs * dozenEggPrice) + (looseEggs * looseEggPrice);

        System.out.println("You ordered: " + eggAmount +" eggs." + " Thats " + dozenEggs + " dozen at " + 
        dozenEggPrice + " and " + looseEggs + " loose eggs at " + looseEggPrice + " each for a total of " + totalPrice + "$");

    }
}
