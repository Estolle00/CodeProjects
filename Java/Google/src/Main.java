import java.util.ArrayList;
import java.util.HashMap;
import java.util.Scanner;

public class Main {

    public static String[][] initializeAddressBook() {
        String[][] adr = new String [5][4];
        adr[0][0] = "5151";
        adr[0][1] = "Sycamore Dr";
        adr[0][2] = "Pleasant Hill";
        adr[0][3] = "IA";

        adr[1][0] = "2963";
        adr[1][1] = "Village Ct";
        adr[1][2] = "Chanhassen";
        adr[1][3] = "MN";

        adr[2][0] = "3642";
        adr[2][1] = "Girard Ave N";
        adr[2][2] = "Minneapolis";
        adr[2][3] = "MN";

        adr[3][0] = "1234";
        adr[3][1] = "Borden Dr";
        adr[3][2] = "Fort Worth";
        adr[3][3] = "TX";

        adr[4][0] = "607";
        adr[4][1] = "Locust St";
        adr[4][2] = "Davenport";
        adr[4][3] = "IA";

        return adr;
    }
    public static String[][] initializeQueries() {
        String[][] adr = new String [5][4];
        adr[0][0] = "";
        adr[0][1] = "Sycamore Dr";
        adr[0][2] = "";
        adr[0][3] = "";

        adr[1][0] = "";
        adr[1][1] = "";
        adr[1][2] = "";
        adr[1][3] = "MN";

        adr[2][0] = "6855";
        adr[2][1] = "Washington St";
        adr[2][2] = "Fridley";
        adr[2][3] = "MN";

        adr[3][0] = "";
        adr[3][1] = "";
        adr[3][2] = "Fort Worth";
        adr[3][3] = "TX";

        adr[4][0] = "";
        adr[4][1] = "Locust St";
        adr[4][2] = "Davenport";
        adr[4][3] = "IA";

        return adr;
    }

    public static HashMap<String, HashMap<String, String>> convertToMap(String[][] addressBook) {
        HashMap<String, HashMap<String, String>> nameMap = new HashMap<String, HashMap<String, String>>();
        HashMap<String, String> innerNumMap = new HashMap<String, String>();
        // Convert to map for faster search
        for (int i =0; i < addressBook.length; i++) {
            //Load innermost map with street number and city + state string
            innerNumMap.put(addressBook[i][1], addressBook[i][2] + ", " + addressBook[i][3]);
            //Loud outermost map with street name + inner map object
            nameMap.put(addressBook[i][0], innerNumMap);
        }
        return nameMap;
    }

    public static void main(String[] args) {
        //Initializing variables
        String[][] addressBook = initializeAddressBook();
        String[][] queries = initializeQueries();
        HashMap<String, HashMap<String, String>> addressMap = convertToMap(addressBook);

        for(int i = 0; i < queries.length; i++) {
            System.out.println("Search # " + i  + ":");
            System.out.println("Street number - " + queries[i][0] + "   Street name - " + queries[i][1] + "   City - " + queries[i][2] + "   State- "
                    + queries[i][3]);
            //Check street name first
            for (String name : addressMap.keySet()) {
                System.out.println(name);
                if ((queries[i][0] != "") && (queries[i][0] == name)) {
                    System.out.println("Address match: " + addressBook[i][0] + " " + addressBook[i][1] + " " + addressBook[i][2] + " "
                            + addressBook[i][3]);
                } else if (queries[i][2] == String.valueOf(addressMap.get(name))) {
                    System.out.println("Address match: " + addressBook[i][0] + " " + addressBook[i][1] + " " + addressBook[i][2] + " "
                            + addressBook[i][3]);
                }

            }
        }


    }
}
