package other;

public class MethodSample {
	// 메소드 오버로딩
	// parameter의 타입, 개수, 순서가 다르면 같은 이름의 메소드를 허용하는 것
	public static int getSum(int i, int j) {
		return i + j;
	}
	public static int getSum(int i, int j, int k) {
		return i + j + k;
	}
	public static double getSum(double i, double j) {
		return i + j;
	}
	public static double getSum(double i, int j) {
		return i + j;
	}
	public static double getSum(int i, double j) {
		return i + j;
	}
	public static void main(String[] args) {
		System.out.println(getSum(1, 2));
		System.out.println(getSum(1, 2, 3));
		System.out.println(getSum(1.0, 2.0));
		System.out.println(getSum(1.0, 2));
		System.out.println(getSum(1, 2.0));
	}
}
