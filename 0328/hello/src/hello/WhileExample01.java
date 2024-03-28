package hello;

import java.util.Scanner;

public class WhileExample01 {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int count = 0;
		int sum = 0;
		int number;
		
		System.out.print("정수입력(종료: -1) :");
		number = scanner.nextInt();
//		while(number != -1) {
//			sum += number;
//			count++;
//			number = scanner.nextInt();
//		}
		for(;number != -1;) {
			sum += number;
			count++;
			number = scanner.nextInt();
		}
		if(count == 0)
			System.out.println("입력된 값이 없습니다.");
		else {
			System.out.print("입력된 수의 개수는 " + count + "이고 ");
			System.out.println("평균은 " + (double)sum / count + "입니다.");
		}
		scanner.close();
	}
}
