package com.company;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Day2 {

    static void Question1() throws FileNotFoundException {

        File inFile = new File("Inputs/2_1.txt");
        Scanner scanner = new Scanner(inFile);
        int xPos = 0;
        int yPos = 0;

        while(scanner.hasNext()) {
            String[] line = scanner.nextLine().split(" ", 2);
            if (line[0].equals("forward")) {
                xPos += Integer.parseInt(line[1]);
            } else {
                if(line[0].equals("down")) {
                    yPos += Integer.parseInt(line[1]);
                } else {
                    yPos -= Integer.parseInt(line[1]);
                }
            }
        }
        scanner.close();

        System.out.println("Total distance traveled: " + (xPos * yPos));
    }



    static void Question2() throws FileNotFoundException {

        File inFile = new File("Inputs/2_1.txt");
        Scanner scanner = new Scanner(inFile);
        int xPos = 0;
        int yPos = 0;
        int aim = 0;

        while(scanner.hasNext()) {
            String[] line = scanner.nextLine().split(" ", 2);
            if (line[0].equals("forward")) {
                xPos += Integer.parseInt(line[1]);
                yPos = yPos + (aim * Integer.parseInt(line[1]));
            } else {
                if(line[0].equals("down")) {
                    aim += Integer.parseInt(line[1]);
                } else {
                    aim -= Integer.parseInt(line[1]);
                }
            }
        }
        scanner.close();

        System.out.println("Total distance traveled: " + (xPos * yPos));

    }
}
