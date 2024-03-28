package hello;

import java.util.Scanner;

public class ArrayExample02 {
	public static void main(String[] args) {
		int intArray[] = new int[5];
		int sum = 0;
		Scanner scanner = new Scanner(System.in);
		
		for (int i = 0; i < intArray.length; i++) {
			System.out.print("intArray[" + i + "] = ");
			intArray[i] = scanner.nextInt();
		}
		for(int num : intArray)
			sum += num;
		
		System.out.println("배열의 합 = " + sum + ", 평균 = " + (double)sum/intArray.length + "입니다.");
		
		scanner.close();
	}
}
