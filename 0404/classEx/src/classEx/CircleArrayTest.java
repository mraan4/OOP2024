package classEx;

class CircleArray{
	int radius;
	public CircleArray(int radius) {
		this.radius = radius;
	}
	public double getArea() {
		return 3.14 * radius * radius;
	}
}
public class CircleArrayTest {
	public static void main(String[] args) {
		CircleArray [] c = new CircleArray[5]; // CircleArray로 만든 객체의 주소를 담는 변수 5개 생성
											   // new 배열 생성		
		for (int i = 0; i < c.length; i++) {
			c[i] = new CircleArray(i); 		   // new - 객체 생성
		}
		for (int i = 0; i < c.length; i++) {
			System.out.println(c[i].getArea());
		}
	}
}