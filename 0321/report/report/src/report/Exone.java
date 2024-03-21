package report;

import java.util.Scanner;

public class Exone {

	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		System.out.print("원화를 입력하세요(단위 원) >> ");
		int won = scanner.nextInt();
		double result = won/1100;
		System.out.println(won+"원은 "+"$"+ result+"입니다." );
		
		scanner.close();
	}

}
