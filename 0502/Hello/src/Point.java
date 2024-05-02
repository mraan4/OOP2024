
public class Point {
	private int x,y;
	
	public Point(int x, int y) {
		super();
		this.x = x;
		this.y = y;
	}

	@Override
	public boolean equals(Object obj) {
		Point p = (Point)obj;
		if(x == p.x && y == p.y)
			return true;
		else
			return false;
		// TODO Auto-generated method stub
	}
	public static void main(String[] args) {
		Point a = new Point(2, 3);
		Point b = new Point(2, 3);
		Point c = a;
		if(a == b)
			System.out.println("a == b");
		if(a == c)
			System.out.println("a == c");
		if(a.equals(b))
			System.out.println("a == b");
		if(a.equals(c))
			System.out.println("a == c");
	}
	
	
	
}
