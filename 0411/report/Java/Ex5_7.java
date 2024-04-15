package report2;

class Point3D extends Point {
	private int z;

	public Point3D(int x, int y, int z) {
		super(x, y);
		this.z = z;
	}
	
	public void moveUp() {
		this.z += 1;
	}
	public void moveDown() {
		this.z -= 1;
	}
	
	public void setXY(int x, int y) {
		super.move(x, y);
	}
	
	public void move(int x, int y, int z) {
		super.move(x, y);
		this.z = z;
	}
	
	@Override
	public String toString() {
		return "(" + getX() + "," + getY() + "," + z + ")의 점";
	}
}

public class Ex5_7 {

	public static void main(String[] args) {
		Point3D p = new Point3D(1,2,3);
		System.out.println("초기 점의 위치는 "+p.toString()+" 입니다.");
		p.moveUp();
		System.out.println("한 칸 위로 이동한 점은 "+p.toString()+" 입니다.");
		p.moveDown();
		System.out.println("한 칸 아래로 이동한 점은 "+p.toString()+" 입니다.");
		p.move(10, 10);
		System.out.println("x,y좌표가 이동한 점은 "+p.toString()+" 입니다.");
		p.move(100, 200, 300);
		System.out.println("x,y,z좌표가 이동한 점은 "+p.toString()+" 입니다.");
	}

}