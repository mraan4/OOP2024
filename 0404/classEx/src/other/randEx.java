package other;

public class randEx {
	public static void main(String[] args) {
		System.out.println(Math.abs(-5));
		System.out.println(Math.sqrt(4.0));
		for(int i = 0; i < 6; i++)
			System.out.print((int)(Math.random() * 45 + 1) + " ");
		System.out.println();
	}
}
