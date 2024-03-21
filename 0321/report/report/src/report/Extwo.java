package report;

import java.util.Scanner;

public class Extwo {

	public static void main(String[] args) {
	
		Scanner scanner = new Scanner(System.in);
		System.out.print("2자리수 정수 입력(10~99)>>");
		int num = scanner.nextInt();
		if(num%10==num/10)
			System.out.print("YES! 10의 자리와 1의 자리가 같습니다.");
		else
			System.out.print("NO 10의 자리와 1의 자리가 다릅니다.");
		scanner.close();
	}

}
