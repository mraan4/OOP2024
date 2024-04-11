package instance;

class Shape{
	public Shape next;
	public Shape() { next = null;}
	public void draw() {
		System.out.println("Shape");
	}
}
class Line extends Shape{
	public void draw() {
		System.out.println("Line");
	}
}
class Rect extends Shape{
	public void draw() {
		System.out.println("Rect");
	}
}
class Circle extends Shape{
	public void draw() {
		System.out.println("Circle");
	}
}
public class MethodOverridingEx {
	public static void main(String[] args) {
		Shape shape = new Shape();
		shape.draw();
		Line line = new Line();
		line.draw();
		Rect rect = new Rect();
		rect.draw();
		Circle circle = new Circle();
		circle.draw();
		Shape s1 = new Line();
		s1.draw();
		Shape s2 = new Circle();
		s2.draw();
	}
}
