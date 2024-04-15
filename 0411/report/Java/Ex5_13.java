package report2;

interface Shape {
	final double PI = 3.14;

	void draw();

	double getArea(); 


	default public void redraw() { 
		System.out.println("=== 다시 그립니다. ===");
		draw();
	}
}

class Circle implements Shape {
	private int radius;

	public Circle(int radius) {
		this.radius = radius;
	}

	public void draw() {
		System.out.println("=== 도형을 그립니다. ===");
		System.out.println("반지름이 " + radius + "인 원입니다.");
	}

	public double getArea() {
		return radius * radius * PI;
	}
}

public class Ex5_13 {
	public static void main(String[] args) {
		Shape dongle = new Circle(10);
		dongle.draw();
		System.out.println("면적은 " + dongle.getArea());
	}
}
