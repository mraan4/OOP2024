package classEx;

public class CircleTestTwoTest {
	public static void main(String[] args) {
		CircleClass pizza;
		pizza = new CircleClass();
		pizza.radius = 10;
		pizza.name = "자바피자";
		double area = pizza.getArea();
		System.out.println(pizza.name + "의 면적은 " + area + "입니다.");
		
		CircleClass donut = new CircleClass();
		donut = new CircleClass();
		donut.radius = 3;
		donut.name = "자바도넛";
		area = donut.getArea();
		System.out.println(donut.name + "의 면적은 " + area + "입니다.");
	}
}
