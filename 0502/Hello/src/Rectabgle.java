import java.awt.Rectangle;

public class Rectabgle {
	private int height, width;
	public void Rectangle(int height, int width) {
		this.height = height;
		this.width = width;
	}
	@Override
	public boolean equals(Object obj) {
		int area = height * width;
		Rectangle r = (Rectangle)obj;
		int rarea = r.width * r.height;
	
	if(area == rarea)
		return true;
	else
		return false;
	}
	public static void main(String[] args) {
		Rectangle r1 = new Rectangle(4, 5);
		Rectangle r2 = new Rectangle(5, 4);
		if(r1.equals(r2))
			System.out.println("두 사각형의 면적은 같습니다.");
	}

}
