package hello;

import java.util.Scanner;

public class OperTernary {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int i, j, result;
		String str;
		
		System.out.println("삼항(ternary) 연산자");
		System.out.println("(조건)?참:거짓");
		
		System.out.print("첫 번째 정수 : ");
		i = scanner.nextInt();
		System.out.print("두 번째 정수 : ");
		j = scanner.nextInt();
		
		System.out.println(i + " = " + i + ", j = " + j );
		result = (i > j)?10:20;
		System.out.println(result);
		str = (i > j)?"i가 큰 수":"j가 큰 수";
		System.out.println(str);
		
		
		scanner.close();
	}
}
