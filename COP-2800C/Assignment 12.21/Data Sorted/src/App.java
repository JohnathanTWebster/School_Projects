import java.util.*;
import java.io.*;

public class App {

    public static void main(String[] args) throws Exception {
        // Create a file instance
        File file = new File("SortedStrings.txt");

        // Check if file exists
        if (!file.exists()) {
            System.out.println(file.getName() + " does not exist");
            System.exit(0);
        }

        System.out.println("File " + file.getName());
        boolean dataSorted = true;
        String string1 = "";
        String string2 = "";
        try (
                // Create input file
                Scanner input = new Scanner(file);) {
            // Read first string from file
            if (input.hasNext())
                string1 = input.next();

            while (input.hasNext() && dataSorted) {
                string2 = input.next();
                // Report if strings are out of order
                if (string1.compareTo(string2) > 0) {
                    System.out.println(
                            "The strings " + string1 + " and " + string2 +
                                    " are out of order");
                    dataSorted = false;
                }
                string1 = string2;
            }
        }

        // Display whether the strings in the files are stored in increasing order
        if (dataSorted) {
            System.out.println(
                    "The strings in the file are stored in increasing order");
        }
    }
}