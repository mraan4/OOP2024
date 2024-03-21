package hello;

import java.util.Scanner;

public class OperLogical {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		boolean i, j;
		
		System.out.print("첫 번째 논리값 입력 : ");
		i = scanner.nextBoolean();
		System.out.print("두 번째 논리값 입력 : ");
		j = scanner.nextBoolean();
		
		System.out.println("비트연산자");
		System.out.println("논리값을 연산하여 논리값을 내어줌");
		System.out.println(" ! " + i + " => " + (!i));
		System.out.println(i + " && " + j + " => " + (i && j));
		System.out.println(i + " || " + j + " => " + (i || j));
			
		scanner.close();
	}
}
