package hello;

public class OperAssign {
	public static void main(String[] args) {
		int i, j, result;
		
		i = 1;
		j = 2;
		
		System.out.println("할당 연산자");
		i = i + 1;
		System.out.println(i);
		i += 1;
		System.out.println(i);
		j = j + i; //j += i;
		System.out.println(j);
		
		// 산술연산자(*, /, %, +, -)
		// 시프트 연산자(<<, >>, >>>)
		// 비트 연산자(&, |, ^)
		j *= i; j /= i; j %= i;
		j <<= i;
		j &= i;
	}
}
