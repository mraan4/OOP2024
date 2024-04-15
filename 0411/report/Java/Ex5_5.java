package report2;

class Point {
	private int x,y;
	
	public Point(int x, int y) {
		this.x = x;
		this.y = y;
	}

	public int getX() {
		return x;
	}

	public void setX(int x) {
		this.x = x;
	}

	public int getY() {
		return y;
	}

	public void setY(int y) {
		this.y = y;
	}
	protected void move(int x, int y) {
		this.x = x;
		this.y = y;
	}
}

class ColorPoint extends Point {
	private String color;

	public ColorPoint(int x, int y, String color) {
		super(x, y);
		this.color = color;
	}
	public void setXY(int x, int y) {
		super.move(x, y);
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	@Override
	public String toString() {
		return getColor() + "색의 , (" + getX() + "," + getY() + ")의 점";
	}
}

public class Ex5_5 {

	public static void main(String[] args) {
		ColorPoint cp = new ColorPoint(5, 5, "Yellow");
		String str1 = cp.toString();
		System.out.println("처음 정의된 colorPoint는 "+str1+"입니다.");
		cp.setXY(10,20);
		cp.setColor("Red");
		String str2 = cp.toString();
		System.out.println("이동한 colorPoint는 "+str2+"입니다.");
	}
}
