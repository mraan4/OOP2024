package classEx;

public class ReferencePassing {
	public static void increase(CircleConst m) {
		m.radius = m.radius + 10;
	}
	public static void main(String[] args) {
		CircleConst pizza = new CircleConst();
		
		pizza.radius = 10;
		
		increase(pizza);
		
		System.out.println(pizza.radius);
	}
}
