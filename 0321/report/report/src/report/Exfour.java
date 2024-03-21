package report;
import java.util.Scanner;
public class Exfour {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int a,b,c;
		System.out.println("정수 3개 입력>>");
		a=scanner.nextInt();
		b=scanner.nextInt();
		c=scanner.nextInt();
		if(a<b && b<c) {System.out.print("중간 값은"+b+"입니다.");}
		if(b<a && a<c) {System.out.print("중간 값은"+a+"입니다.");}
		else {System.out.print("중간 값은"+c+"입니다.");}
		
		scanner.close();
	}

}
