package hello;

import java.util.Scanner;

public class OperRelative {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int i, j;
		
		System.out.print("첫 번째 정수 입력 : ");
		i = scanner.nextInt();
		System.out.print("두 번째 정수 입력 : ");
		j = scanner.nextInt();
		
		System.out.println("관계 연산자(비교연산자)");
		System.out.println("두 수를 비교하여 논리값을 내어주는 연산자");
		System.out.println(i + " > " + j + " => " + (i > j));
		System.out.println(i + " < " + j + " => " + (i < j));
		System.out.println(i + " >= " + j + " => " + (i >= j));
		System.out.println(i + " <= " + j + " => " + (i <= j));
		System.out.println(i + " == " + j + " => " + (i == j));
		System.out.println(i + " != " + j + " => " + (i != j));
		
		
		scanner.close();
	}
}
