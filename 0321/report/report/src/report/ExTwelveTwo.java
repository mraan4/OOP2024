package report;

import java.util.Scanner;

public class ExTwelveTwo {

	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		System.out.print("연산>>");
		int p1 = scanner.nextInt();
		String op = scanner.next();
		int p2 = scanner.nextInt();
		
		switch(op)
		{
		case "+":
			System.out.print(p1+""+op+""+p2+"의 계산 결과는 "+(p1+p2));
			break;
		case "-":
			System.out.print(p1+""+op+""+p2+"의 계산 결과는 "+(p1-p2));
			break;
		case "*":
			System.out.print(p1+""+op+""+p2+"의 계산 결과는 "+(p1*p2));
			break;
		case "/":
			if(p2==0)
			{
				System.out.print("0으로 나눌 수 없습니다.");
				break;
			}
			System.out.print(p1+""+op+""+p2+"의 계산 결과는 "+(p1/p2));
			break;
		}
		
		scanner.close();
	}

}
