package hello;

public class Hello {
	public static int sum(int n, int m) {
		return n + m;
	}
	public static void main(String[] args) {
		int i = 20;
		final int J = 123;
		int s;
		char a = '?';
		String str = "STR";
		
		s = sum(i, 10);
		System.out.println(a);
		System.out.println("Hello");
		System.out.println(s);
		System.out.println(J);
		System.out.println(str);
	}
}
