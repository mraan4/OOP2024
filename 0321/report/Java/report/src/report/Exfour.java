package report;
import java.util.Scanner;
public class Exfour {

	public static void main(String[] args) {
		System.out.println("정수 3개 입력>>");
		Scanner scanner = new Scanner(System.in);
		int num1 = scanner.nextInt();
        int num2 = scanner.nextInt();
        int num3 = scanner.nextInt();
        if(num1 < num2){
            if(num2 < num3){
                System.out.print("중간 값은"+num2+"입니다.");
            }
            else{
                System.out.print("중간 값은"+num3+"입니다.");
            }
        }
        else{
            if(num1 < num3){
                System.out.print("중간 값은"+num1+"입니다.");
            }
            else{
                System.out.print("중간 값은"+num3+"입니다.");
            }
        }
        
		scanner.close();
	}

}
