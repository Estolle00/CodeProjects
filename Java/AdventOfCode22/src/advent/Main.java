package advent;

import java.io.File;
import java.io.IOException;

public class Main {

	public static void main(String[] args) throws IOException {
		String inputFilePath = "Inputs\\4.txt";
		File file = new File(inputFilePath);
		Day4 dayObj = new Day4();
		
		
		System.out.println("Solution 1: " + dayObj.Problem1(file));
		//System.out.println("Solution 2: " + dayObj.Problem2(file));
		

	}

}
