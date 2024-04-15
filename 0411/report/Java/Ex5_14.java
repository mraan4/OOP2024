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

class Oval implements Shape {
	private int width, height;

	public Oval(int width, int height) {
		this.width = width;
		this.height = height;
	}

	public void draw() {
		System.out.println("=== 도형을 그립니다. ===");
		System.out.println("가로 "+width+", 세로 " + height + "에 내접하는 타원입니다.");
	}

	public double getArea() {
		return width * height * PI;
	}
}

class Rect implements Shape {
	private int width, height;

	public Rect(int width, int height) {
		this.width = width;
		this.height = height;
	}

	public void draw() {
		System.out.println("=== 도형을 그립니다. ===");
		System.out.println("가로 "+width+", 세로 " + height + "인 사각형입니다.");
	}

	public double getArea() {
		return width * height;
	}
}
public class Ex5_14 {

	public static void main(String[] args) {
		Shape [] list = new Shape[3];
		list[0] = new Circle(10);
		list[1] = new Oval(20,30);
		list[2] = new Rect(10,40);
		
		for(Shape a : list) {
			a.draw(); 
			System.out.println("면적은 "+a.getArea());
		}
	}
}