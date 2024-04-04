package classEx;

public class CircleConst {
	int radius;
	String name;

	public CircleConst() {
		radius = 5;
		name = "";
	}
	
	public CircleConst(int radius, String name) {
		this.radius = radius;
		this.name = name;
	}

	public double getArea() {
		return 3.14 * radius * radius;
	}
	public static void main(String[] args) {
		CircleConst pizza = new CircleConst(10, "자바피자");
		System.out.println(pizza.name + "의 면적은 " + pizza.getArea() + "입니다.");
		
		CircleConst donut = new CircleConst();
		donut.name = "자바도넛";
		System.out.println(donut.name + "의 면적은 " + donut.getArea() + "입니다.");
	}
}
