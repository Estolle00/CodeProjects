package com.company;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Scanner;

public class Main {

    public String[][] initializeAddressBook() {
        string[][] adr;
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
    public HashMap<String, HashMap<String, Object>> convertToMap(String[][]) {
        // Convert to map for faster search
        for (int i =0; i < addressBook.length; i++) {
            //Load innermost map with street number and city + state string
            innerNumMap.put(addressBook[i][1], addressBook[i][2] + ", " + addressBook[i][3]);
            //Loud outermost map with street name + inner map object
            nameMap.Put(addressBook[i][0], innerNumMap);
        }
        return nameMap;
    }

    public static void main(String[] args {
        //Initializing variables
        string[][] addressBook = initializeAddressBook();
        HashMap<String, HashMap<String, HashMap<String, Object>> addressMap = convertToMap(addressBook);
        Scanner inputObj = new Scanner(System.in);
        ArrayList<String> returnList = new ArrayList<String>();
        String name = "";
        String number = "";
        String city = "";
        String state = "";

        System.out.println("Search for any of the following: street name, number, city, or state.");
        System.out.print("Street name: ");
        name = inputObj.nextLine();
        System.out.print("Street number: ");
        number = inputObj.nextLine();
        System.out.print("City: ");
        city = inputObj.nextLine();
        System.out.print("State: ");
        state = inputObj.nextLine();

        //Search by name if provided
        if (!equals(name, "")) {
            for (String adrName :addressMap.keySet()) {
                if (adrName = name) {
                    returnList.add(addressBook.get(name) + " " + name + " " + )
                }
            }
        }
        System.out.println("");

    }
}
