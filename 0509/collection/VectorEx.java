package collection;

import java.util.Vector;

public class VectorEx {
	public static void main(String[] args) {
		Vector<Integer> v = new Vector<Integer>();
		v.add(5);
		v.add(4);
		v.add(-1);
		v.add(2, 100);
		System.out.println("백터 내의 요소 객체 수 : " + v.size());
		System.out.println("백터의 현재 용량 : " + v.capacity());
		for (int i = 0; i < v.size(); i++) {
			int n = v.get(i);
			System.out.print(n + "  ");
		}
		int sum = 0;
		for (int i = 0; i < v.size(); i++) {
			int n = v.elementAt(i);
			sum+=n;
		}
		System.out.println("백터에있는 값들의 합 : " + sum);
	}
}
