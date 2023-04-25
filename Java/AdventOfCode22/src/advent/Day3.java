package advent;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class Day3 {

	
	
	public int Problem1(File file) throws IOException{
		int sum = 0;
		int mid = 0;
		String contentsA = "";
		String contentsB = "";
		ArrayList<String> list = new ArrayList<String>();
		
		Scanner scanner = new Scanner(file);
		while (scanner.hasNextLine()) {
			list.add(scanner.nextLine());
		}
		scanner.close();
		
		for (String pack : list) {
			mid = pack.length()/2;
			contentsA = pack.substring(0, mid);
			contentsB = pack.substring(mid, pack.length());
			System.out.println("1: " + contentsA + " 2: " + contentsB + " Mid: " + mid);
			
			for (char letter : contentsA.toCharArray()) {
				if (contentsB.indexOf(letter) != -1) {
					System.out.println(letter);
					sum += GetLetterScore(letter);
					break;
				}
			}
		}		
		return sum;
	}
	
	public int Problem2(File file) throws IOException{
		int sum = 0;
		int count = 0;
		String[] group = new String[3];
		ArrayList<String> list = new ArrayList<String>();
		
		Scanner scanner = new Scanner(file);
		while (scanner.hasNextLine()) {
			list.add(scanner.nextLine());
		}
		scanner.close();
		
		for (String pack : list) {
			group[count] = pack;
			if (count == 2) {
				for (char letter : group[0].toCharArray()) {
					if (group[1].indexOf(letter) != -1) {
						if (group[2].indexOf(letter) != -1) {
							sum += GetLetterScore(letter);
							count = 0;
							break;
						}
					}
				}
				count = 0;
			} else {
				count++;
			}
		}		
		return sum;
	}
	
	public static int GetLetterScore(char letter) {
		int value = 0;
		
		switch (letter) {
			case 'a': value = 1; break;
			case 'b': value = 2; break;
			case 'c': value = 3; break;
			case 'd': value = 4; break;
			case 'e': value = 5; break;
			case 'f': value = 6; break;
			case 'g': value = 7; break;
			case 'h': value = 8; break;
			case 'i': value = 9; break;
			case 'j': value = 10; break;
			case 'k': value = 11; break;
			case 'l': value = 12; break;
			case 'm': value = 13; break;
			case 'n': value = 14; break;
			case 'o': value = 15; break;
			case 'p': value = 16; break;
			case 'q': value = 17; break;
			case 'r': value = 18; break;
			case 's': value = 19; break;
			case 't': value = 20; break;
			case 'u': value = 21; break;
			case 'v': value = 22; break;
			case 'w': value = 23; break;
			case 'x': value = 24; break;
			case 'y': value = 25; break;
			case 'z': value = 26; break;
			case 'A': value = 27; break;
			case 'B': value = 28; break;
			case 'C': value = 29; break;
			case 'D': value = 30; break;
			case 'E': value = 31; break;
			case 'F': value = 32; break;
			case 'G': value = 33; break;
			case 'H': value = 34; break;
			case 'I': value = 35; break;
			case 'J': value = 36; break;
			case 'K': value = 37; break;
			case 'L': value = 38; break;
			case 'M': value = 39; break;
			case 'N': value = 40; break;
			case 'O': value = 41; break;
			case 'P': value = 42; break;
			case 'Q': value = 43; break;
			case 'R': value = 44; break;
			case 'S': value = 45; break;
			case 'T': value = 46; break;
			case 'U': value = 47; break;
			case 'V': value = 48; break;
			case 'W': value = 49; break;
			case 'X': value = 50; break;
			case 'Y': value = 51; break;
			case 'Z': value = 52; break;			
		}
		return value;
		
	}
}
