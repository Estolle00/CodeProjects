package advent;

import java.io.File;
import java.io.IOException;
import java.util.Scanner;
import java.util.ArrayList;

public class Day1 {
	

	
	public int Problem1(File file) throws IOException{

		int max = 0;
		int sum = 0;	
		ArrayList<String> elfList = new ArrayList<String>();
	    Scanner scanner = new Scanner(file);

	    while(scanner.hasNextLine()){
	    	elfList.add(scanner.nextLine());
	    }
		scanner.close();
	    
	    for(String line : elfList) {
	    	System.out.println(line);
	    	if (!isStringInt(line)) {
	    		
	    		if(max == 0) {
	    			max = sum;
	    		}

		    	if(sum >= max) {
		    		max = sum;
		    	} 
		    	
	    		sum = 0;
	    	}
		    	else {
		    		sum = sum + Integer.parseInt(line);
	    	        //System.out.println("Number: " + line + " Sum: " + sum + " Max: " + max);
		    	}      
	    	
	    }    
	    return max;
	}
	
	public boolean isStringInt(String s)
	{
	    try
	    {
	        Integer.parseInt(s);
	        return true;
	    } catch (NumberFormatException ex)
	    {
	        return false;
	    }
	}
	
	public int Problem2(File file) throws IOException{

		int max1 = 0;
		int max2 = 0;
		int max3 = 0;
		int sum = 0;	
		ArrayList<String> elfList = new ArrayList<String>();
	    Scanner scanner = new Scanner(file);

	    while(scanner.hasNextLine()){
	    	elfList.add(scanner.nextLine());
	    }
		scanner.close();
	    
	    for(String line : elfList) {
	    	System.out.println(line);
	    	if (!isStringInt(line)) {
	    		
	    		if(max1 == 0) {
	    			max1 = sum;
	    		}

		    	if(sum > max1) {
		    		max1 = sum;
		    	} else if (sum > max2) {
		    		max2 = sum;
		    	} else if (sum > max3) {
		    		max3 = sum;
		    	}
	    		sum = 0;
	    	}
		    	else {
		    		sum = sum + Integer.parseInt(line);
	    	        //System.out.println("Number: " + line + " Sum: " + sum + " Max: " + max);
		    	}      
	    	
	    }    
	    return max1 + max2 + max3;
	}
}
