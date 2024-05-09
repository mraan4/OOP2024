package collection;

public class Sample {
	public static void main(String[] args) {
		int i, j, k, l, m;
		int [] arr = new int[5];
		i = 1;
		j = 2;
		k = 3;
		l = 4;
		m = 5;
		System.out.printf("%d %d %d %d %d\n", i, j, k, l, m);
		System.out.println();
		for (int n = 0; n < arr.length; n++) {
			arr[n] = n + 1;
		}

		for (int n = 0; n < arr.length; n++) {
			System.out.print(arr[n] + " ");
		}
	}
}
