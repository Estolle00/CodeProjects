package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class TestProject {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		
		String input = "";
		boolean ageInvalid = true;
		int age = 0;
		boolean errorFlagged = false;
		BufferedReader consoleInput = new BufferedReader(new InputStreamReader(System.in));
		
		System.out.print("Please enter your name: ");
		input = consoleInput.readLine();
		
		System.out.print("\nHello, " + input + "! Please enter your age: ");
		while (ageInvalid) {
			errorFlagged = false;
			try {
				age = Integer.parseInt(consoleInput.readLine());
			} catch(NumberFormatException ex){
				System.out.print("That's not a number you fkn idiot. Try again: ");
				errorFlagged = true;
			}
			
			if (errorFlagged) {
				ageInvalid = true;
			} else {
				ageInvalid = false;
			}
			
		}
		
		System.out.println("\nYour age doubled is: " + String.valueOf(age*2) + "!");
		System.out.print("Press ENTER to close this window.");
		consoleInput.read();
		
		

	}

}
