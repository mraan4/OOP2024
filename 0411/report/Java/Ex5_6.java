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

	public ColorPoint(int x, int y) {
		super(x, y);
	}
	
	public ColorPoint() {
		super(0,0);
		this.color = "Black";
	}

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

public class Ex5_6 {

	public static void main(String[] args) {

		ColorPoint zeroPoint = new ColorPoint();
		System.out.println("원점은 "+zeroPoint.toString()+"입니다.");
		ColorPoint cp = new ColorPoint(10,10);
		cp.setXY(5,5);
		cp.setColor("Red");
		System.out.println("새로 이동한 colorPoint는 "+cp.toString()+"입니다.");
	}
}
