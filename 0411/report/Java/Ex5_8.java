package report2;

class PositivePoint extends Point {
	public PositivePoint() {super(0,0);}
	
	public PositivePoint(int x, int y) {
		super(x,y);

		if(x<0) {
			if(y<0) {super.move(0, 0);}
			else {super.move(0, y);}
		}
		else if(y<0) {super.move(x, 0);}
		else {super.move(x, y);}
	}
	
	@Override
	public void move(int x, int y) {
		if(x>=0&&y>=0) {super.move(x, y);}
		else {}
	}

	@Override
	public String toString() {
		return "(" + getX() + "," + getY() + ")의 점";
	}
}

public class Ex5_8 {

	public static void main(String[] args) {
		PositivePoint p = new PositivePoint();
		p.move(10, 10);
		System.out.println(p.toString()+"입니다.");

		PositivePoint p1 = new PositivePoint(-5,5);

		System.out.println(p1.toString()+"입니다.");

		PositivePoint p2 = new PositivePoint(-10,-10);

		System.out.println(p2.toString()+"입니다.");
	}
}