package com.company;

import java.io.File;
import java.io.FileNotFoundException;
import java.sql.Array;
import java.util.ArrayList;
import java.util.Scanner;

public class Day1 {

    static void Question1() throws FileNotFoundException {
        int currentNum;
        int prevNum;
        int increaseCount = 0;

        File inFile = new File("Inputs/1_1.txt");
        Scanner scanner = new Scanner(inFile);
        prevNum = scanner.nextInt();
        System.out.println("Initial Number: " + prevNum + "\n");

        while (scanner.hasNext()) {
            currentNum = scanner.nextInt();

            if (currentNum > prevNum) {
                increaseCount++;
            }
            prevNum = currentNum;
        }
        scanner.close();
        System.out.println("Number of increases: " + (increaseCount));

    }



    static void Question2() throws FileNotFoundException {

        File inFile = new File("Inputs/1_1.txt");
        Scanner scanner = new Scanner(inFile);

        int count = 0;
        int[] currentWindow = { scanner.nextInt(), scanner.nextInt(), scanner.nextInt() };
        while (scanner.hasNextInt()) {
            int next = scanner.nextInt();
            if (next > currentWindow[0]) {
                count++;
            }
            currentWindow[0] = currentWindow[1];
            currentWindow[1] = currentWindow[2];
            currentWindow[2] = next;
        }
        System.out.println(count);
    }
}
