package classEx;

import java.util.Scanner;

//class Rectangle{
//	int width, height;
//	int getArea() {
//		return width * height;
//	}
//}
//
//public class RectangleTest {
//	int width, height;
//	int getArea() {
//		return width * height;
//	}
//	public static void main(String[] args) {
//		Scanner scanner = new Scanner(System.in);
//		Rectangle rect = new Rectangle();
//		
//		System.out.print("width = ");
//		rect.width = scanner.nextInt();
//		System.out.print("height = ");
//		rect.height = scanner.nextInt();
//		
//		System.out.println("사각형의 면적은 " + rect.getArea() + "입니다.");
//		scanner.close();
//	}
//}

public class RectangleTest {
	int width, height;
	int getArea() {
		return width * height;
	}
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		RectangleTest rect = new RectangleTest();
		
		System.out.print("width = ");
		rect.width = scanner.nextInt();
		System.out.print("height = ");
		rect.height = scanner.nextInt();
		
		System.out.println("사각형의 면적은 " + rect.getArea() + "입니다.");
		scanner.close();
	}
}
