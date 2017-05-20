/*
 * 8. a. Write a program that calculates and displays the conversion of EUR57 into 20's, 10's, 5's, and 1 's.
 *  Create a separate method to do the calculation and display. Pass 57 as a variable to this method.
 *   Save the program as Ex0308.java b. In the Ex0308.java program,
 *    alter the value of the variable that holds the amount of money.
 *  Run the program and confirm that the amount of each denomination calculates correctly. 
 */

import java.util.Scanner;

public class moneyCalculator {
	public static void main(String[] args) {
		Scanner myScanner = new Scanner(System.in);
		System.out.println("Enter number : ");
		int number = myScanner.nextInt();
		total(number);
	}
	public static int total(int numIn){

		int twenties = numIn / 20;      
		int modOfTwentie = numIn % 20;	

		int tens = modOfTwentie /10;	
		int modOfTen = modOfTwentie % 10;		

		int fives = modOfTen / 5;
		int modOfFives = modOfTen % 5;

		int ones = modOfFives /1;
		int modOfOnes = ones % 1;

		System.out.println("In the number " + numIn);
		System.out.println("number of 20's  " + twenties);
		System.out.println("number of 10's  " + tens);
		System.out.println("number of 5's   " + fives);
		System.out.println("number of 1's   " + ones);
		return 1;
	}

}
