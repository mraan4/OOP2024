package report2;

import java.util.Scanner;

interface Stack {

	int length(); 


	int capacity(); 


	String pop(); 


	boolean push(String val); 
}

class StackApp implements Stack {
	private int length, capacity;
	String[] arr;

	public StackApp(int n) {
		arr = new String[n];
		length = 0;
		capacity = n;
	}

	@Override
	public int length() {
		return length;
	}

	@Override
	public int capacity() {
		return capacity;
	}

	@Override
	public String pop() {
		return arr[--length];
	}

	@Override
	public boolean push(String val) {
		if (length == capacity) {
			System.out.println("스택이 꽉 차서 더 이상 넣을 수 없습니다!");
			return false;
		} else {
			arr[length++] = val;
			return true;
		}
	}
}

public class Ex5_9 {
	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		System.out.print("총 스택 저장 공간의 크기 입력 >> ");
		int n = sc.nextInt();

		StackApp app = new StackApp(n);

		while (true) {
			System.out.print("문자열 입력 >> ");
			String str = sc.next();
			if (str.equals("그만"))
				break;
			app.push(str);

		}
		
		System.out.print("스택에 저장된 모든 문자열 출력 : ");
		for (String a : app.arr) {
			System.out.print(a + " ");
		}
	}
}