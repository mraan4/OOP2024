package hello;

import java.util.Scanner;

public class OperatorPrePost {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int number, result;

		System.out.print("정수 입력 : ");
		number = scanner.nextInt();
		number = number + 1;
		System.out.println("i = " + number);
		++number;
		System.out.println("i = " + number);
		number++;
		System.out.println("i = " + number);
		number += 1;
		System.out.println("i = " + number);
		
		number = 6;
		result = ++number;
		System.out.println("i = " + number + ", j = " + result);
		
		number = 6;
		result = number++;
		System.out.println("i = " + number + ", j = " + result);
		
		scanner.close();
	}

}
