package hello;

import java.util.Scanner;

public class OperArithmetic {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int i, j;
		
		System.out.print("첫 번째 정수 입력 : ");
		i = scanner.nextInt();
		System.out.print("두 번째 정수 입력 : ");
		j = scanner.nextInt();
		
		System.out.println("산술 연산자");
		System.out.println(i + " * " + j + " = " + (i * j));
		System.out.println(i + " / " + j + " = " + ((double)i / j));
		System.out.println(i + " % " + j + " = " + (i % j));
		System.out.println(i + " + " + j + " = " + (i + j));
		System.out.println(i + " - " + j + " = " + (i - j));
		scanner.close();
	}
}
