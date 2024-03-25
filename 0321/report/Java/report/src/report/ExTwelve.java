package report;

import java.util.Scanner;

public class ExTwelve {

	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		System.out.print("연산>>");
		int p1 = scanner.nextInt();
		String op = scanner.next();
		int p2 = scanner.nextInt();
		int result=0;
		if(op.equals("+"))
			result=p1+p2;
		else if(op.equals("-"))
			result=p1-p2;
		else if(op.equals("*"))
			result=p1*p2;
		else if(op.equals("/")) {
			if(p2==0) {
				System.out.print("0으로 나눌 수 없습니다.");
				scanner.close();
				return;
			}
			else
				result=p1/p2;
			}
		else {
			System.out.print("사칙연산이 아닙니다.");
			scanner.close();
			return;
		}
		System.out.println(p1+op+p2+"의 계산 결과는 "+result);
		scanner.close();
	}

}
