package report;
import java.util.Scanner;
public class ExFive {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.println("정수 3개를 입력>>");
		int l1=scanner.nextInt();
		int l2=scanner.nextInt();
		int l3=scanner.nextInt();
		if((l1+l2)<l3 || (l1+l3)<l2 || (l2+l3)<l1)
			System.out.println("삼각형을 만들 수 없습니다.");
		else
			System.out.println("삼각형이 됩니다.");
		scanner.close();

	}

}
