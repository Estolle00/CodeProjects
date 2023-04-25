package com.company;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;

public class Day4 {
    static void Question1() throws FileNotFoundException {
        File inFile = new File("Inputs/4_1.txt");
        Scanner scanner = new Scanner(inFile);
        ArrayList<Integer> bingoNumbers =  new ArrayList<>();
        int[][] arrScore;
        int[][] arrBingoCard = new int[5][5];


        while (scanner.hasNextInt()) {
            bingoNumbers.add(scanner.nextInt());
        }

        while (Scanner.hasNextInt()) {

        }
        scanner.close();






    }
}

