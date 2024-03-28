package hello;

import java.util.Scanner;

public class LeapYear {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int year;
		for(;;) {
			System.out.print("년도를 입력하세요(종료는 0) : ");
			year = scanner.nextInt();
			if(year == 0)
				break;
			// 4의 배수이고 100의 배수는 아니고 400의 배수이면 윤년
			if( year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
				System.out.println(year + "년도는 윤년(leap year)입니다.");
			else
				System.out.println(year + "년도는 평년(common year)입니다.");
		}
		scanner.close();
	}
}
