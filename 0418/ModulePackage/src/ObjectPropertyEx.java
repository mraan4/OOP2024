class Point{
	public int x, y;
	public Point(int x, int y) {
		this.x = x;
		this.y = y;
	}
}
class Rect{
	public int width, height;
	public Rect(int width, int height) {
		this.width = width;
		this.height = height;
	}
}
public class ObjectPropertyEx {
	static void assignValue(int x, int y) {
		// x = 1, y = 2
		System.out.println("x = " + x + ", y = " + y);
	}
	static void print(Object obj) {
		// obj = p	업캐스팅, 	왼쪽에 부모 = 오른쪽 자식
		System.out.println(obj.getClass().getName());
		System.out.println(obj.hashCode());
		System.out.println(obj.toString());
		System.out.println(obj);
		//	다운캐스팅, 왼쪽에 자식 = 오른쪽에 부모
		Point subp;
		Rect rect;
		if(obj instanceof Point) {
			subp = (Point)obj;
		System.out.println("포인터 객체의 x = " + subp.x + ", 포인터 객체의 y = " + subp.y);
		}
		if(obj instanceof Rect) {
			rect = (Rect)obj;
			System.out.println("사각형의 너비 = " + rect.width + ", 사각형의 높이 = " + rect.height);
		}
	}
	
	public static void main(String[] args) {
		assignValue(1, 2);
		Point p = new Point(2, 3);
		print(p);
		Rect r = new Rect(5, 6);
		print(r);				
	}
}
