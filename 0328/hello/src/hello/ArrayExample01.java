package hello;

import java.util.Scanner;

public class ArrayExample01 {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int intArray[] = new int[5];
//		int max = -2147483648;
//		int min = 2147483647;
		int max=0, min=0;
//		System.out.println("배열의 첫번째 요소 입력 : ");
//		intArray[0] = scanner.nextInt();
//		min = max = intArray[0];
		
		System.out.print("정수 5개 입력 : ");
		for (int i = 0; i < intArray.length; i++) {
			intArray[i] = scanner.nextInt();
			if(i==0) {
				max = intArray[0];
				min = intArray[0];
			}
			else {	
			if(intArray[i] > max)
				max = intArray[i];
			if(intArray[i] < min)
				min = intArray[i];
			}
		}
		System.out.println("입력한 5개의 정수 중에 최대값 = " + max + " 이고, 최소값 = " + min + " 입니다.");
		
		scanner.close();
	}
}
