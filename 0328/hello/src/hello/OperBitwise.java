package hello;

import java.util.Scanner;

public class OperBitwise {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int i, j;
		
		System.out.print("첫 번째 정수 입력 : ");
		i = scanner.nextInt();
		System.out.print("두 번째 정수 입력 : ");
		j = scanner.nextInt();
		
		System.out.println("비트연산자");
		System.out.println("두 수의 비트들을 연산함");
		System.out.println(" ~ " + i + " => " + (~i));
		System.out.println(i + " & " + j + " => " + (i & j));
		System.out.println(i + " | " + j + " => " + (i | j));
		System.out.println(i + " ^ " + j + " => " + (i ^ j));
	
			
		scanner.close();
	}
}
