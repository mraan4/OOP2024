package report;
import java.util.Scanner;
public class ExNine {
	
	public static void main(String[] args) {
		
			Scanner scanner = new Scanner(System.in);
			System.out.print("원의 중심과 반지름 입력:");
			double rx = scanner.nextDouble();
			double ry = scanner.nextDouble();
			double r = scanner.nextDouble();
			System.out.print("점 입력>>");
			double x = scanner.nextDouble();
			double y = scanner.nextDouble();
			
			double dis = Math.sqrt((((rx-x)*(rx-x))+((ry-y)*(ry-y))));
			if(dis<=r)
					System.out.print("점"+x+","+y+"은"+"원 안에 있습니다.");
			else
					System.out.print("점"+x+","+y+"은"+"원 밖에 있습니다.");
		
		scanner.close();
		}
}
