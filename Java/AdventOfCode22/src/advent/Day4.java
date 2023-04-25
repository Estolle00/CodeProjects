package advent;

import java.io.File;
import java.io.IOException;
import java.util.Scanner;
import java.util.ArrayList;

public class Day4 {
	
	public int Problem1(File file) throws IOException{
		int totalPairs = 0;
		ArrayList<Integer> range1 = new ArrayList<Integer>();
		ArrayList<Integer> range2 = new ArrayList<Integer>();
		String[] splitPair = new String[2];
		String[] row1 = new String[2];
		String[] row2 = new String[2];
		boolean isMatch = false;
		
		Scanner scanner = new Scanner(file);
		while (scanner.hasNextLine()) {
			splitPair = scanner.nextLine().split(",");
			row1 = splitPair[0].split("-");
			row2 = splitPair[1].split("-");
			
			for (int i = Integer.parseInt(row1[0]); i <= Integer.parseInt(row1[1]); i++) {
				range1.add(i);
			} 
			
			for (int j = Integer.parseInt(row2[0]); j <= Integer.parseInt(row2[1]); j++) {
				range2.add(j
						);
			} 
			
		}
		scanner.close();
		return totalPairs;
	}
	

}
