package hello;

import java.util.Scanner;

public class ScannerEx {

	public static void main(String[] args) {
		// 이름, 도시, 나이, 체중, 독신여부
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("이름 : ");
		String name = scanner.next();
		System.out.println("이름은 " + name + "입니다.");
		
		System.out.print("도시 : ");
		String city = scanner.next();
		System.out.println("도시는 " + city + "입니다.");
		
		System.out.print("나이 : ");
		int age = scanner.nextInt();
		System.out.println("나이는 " + age + "입니다.");
		
		System.out.print("체중 : ");
		double weight = scanner.nextDouble();
		System.out.println("체중은 " + weight + "입니다.");
		
		System.out.print("독신여부(true or false) : ");
		boolean single = scanner.nextBoolean();
		System.out.println("독신여부는 " + single + "입니다.");
		
		scanner.close();
	}

}
