package classEx;

public class CircleTest1 {
	public int radius;
	public String name;
	
	public CircleTest1() {
		
	}
	public double getArea() {
		return 3.14*radius*radius;
	}
	public static void main(String[] args) {
		CircleTest1 pizza;
		pizza = new CircleTest1();
		pizza.radius = 10;
		pizza.name = "자바피자";
		double area = pizza.getArea();
		System.out.println(pizza.name + "의 면적은 " + area + "입니다.");
		
		CircleTest1 donut = new CircleTest1();
		donut.radius = 3;
		donut.name = "자바도넛";
		area = donut.getArea();
		System.out.println(donut.name + "의 면적은 " + area + "입니다.");
	}
}
