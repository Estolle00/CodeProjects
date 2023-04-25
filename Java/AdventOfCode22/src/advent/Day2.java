package advent;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class Day2 {
	
	//Define constants
	static final int LOSE     = 0;
	static final int DRAW     = 3;
	static final int WIN      = 6;
	static final int ROCK 	  = 1;
	static final int PAPER 	  = 2;
	static final int SCISSORS = 3;
	
	public int Problem1(File file) throws IOException{
		int totalScore = 0;
		String[] splitItem = new String[2];
		ArrayList<String> list = new ArrayList<String>();
		Scanner scanner = new Scanner(file);
		
		//Read file into list
		while(scanner.hasNextLine()) {
			list.add(scanner.nextLine());
		}
		scanner.close();
		
		for(String item : list) {
			splitItem = item.split(" ");
			
			//Determine Win, Loss, or Draw
			switch (splitItem[0]) {
				//Opponent Rock
				case "A": if(splitItem[1].equals("X")) {
					  totalScore += (DRAW + ROCK);
					} else if (splitItem[1].equals("Y")) {
					  totalScore += (WIN + PAPER);
					} else {
					  totalScore += (LOSE + SCISSORS);
					}
					break;
				
				//Opponent Paper
				case "B": if(splitItem[1].equals("X")) {
					  totalScore += (LOSE + ROCK);
				  	} else if (splitItem[1].equals("Y")) {
					  totalScore += (DRAW + PAPER);
				  	} else {
					  totalScore += (WIN + SCISSORS);
				  	}
				  break;
				  
				//Opponent Scissors
				case "C": if(splitItem[1].equals("X")) {
					  totalScore += (WIN + ROCK);
				  	} else if (splitItem[1].equals("Y")) {
					  totalScore += (LOSE + PAPER);
				  	} else {
					  totalScore += (DRAW + SCISSORS);
				  	}
				  break;			
			}
		}
		return totalScore;
	}

	public int Problem2(File file) throws IOException{
		int totalScore = 0;
		String[] splitItem = new String[2];
		ArrayList<String> list = new ArrayList<String>();
		Scanner scanner = new Scanner(file);
		
		//Read file into list
		while(scanner.hasNextLine()) {
			list.add(scanner.nextLine());
		}
		scanner.close();
		
		for(String item : list) {
			splitItem = item.split(" ");
			
			//Determine Win, Loss, or Draw
			switch (splitItem[0]) {
				//Opponent Rock
				case "A": if(splitItem[1].equals("X")) {
					  totalScore += (LOSE + SCISSORS);
					} else if (splitItem[1].equals("Y")) {
					  totalScore += (DRAW + ROCK);
					} else {
					  totalScore += (WIN + PAPER);
					}
					break;
				
				//Opponent Paper
				case "B": if(splitItem[1].equals("X")) {
					  totalScore += (LOSE + ROCK);
				  	} else if (splitItem[1].equals("Y")) {
					  totalScore += (DRAW + PAPER);
				  	} else {
					  totalScore += (WIN + SCISSORS);
				  	}
				  break;
				  
				//Opponent Scissors
				case "C": if(splitItem[1].equals("X")) {
					  totalScore += (LOSE + PAPER);
				  	} else if (splitItem[1].equals("Y")) {
					  totalScore += (DRAW + SCISSORS);
				  	} else {
					  totalScore += (WIN + ROCK);
				  	}
				  break;			
			}
		}
		return totalScore;
	}
}
