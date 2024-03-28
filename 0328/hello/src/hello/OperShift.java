package hello;

import java.util.Scanner;

public class OperShift {
	public static void main(String[] args) {
		
		int number = 8;
		
		System.out.println("시프트(shift) 연산자");
		System.out.println(number + " << " + 1 + " = " + (number << 1));
		System.out.println(number + " << " + 2 + " = " + (number << 2));
		System.out.println(number + " << " + 3 + " = " + (number << 3));
		System.out.println(number + " >> " + 1 + " = " + (number >> 1));
		System.out.println(number + " >> " + 2 + " = " + (number >> 2));
		System.out.println(number + " >> " + 3 + " = " + (number >> 3));
		
		number = -8;		
		System.out.println(number + " << " + 1 + " = " + (number << 1));
		System.out.println(number + " << " + 2 + " = " + (number << 2));
		System.out.println(number + " << " + 3 + " = " + (number << 3));
		System.out.println("오른쪽 시프트 최상위비트로 채움");
		System.out.println(number + " >> " + 1 + " = " + (number >> 1));
		System.out.println(number + " >> " + 2 + " = " + (number >> 2));
		System.out.println(number + " >> " + 3 + " = " + (number >> 3));
		System.out.println("오른쪽으로 시프트하지만 최상위비트를 0으로채움");
		System.out.println(number + " >>> " + 1 + " = " + (number >>> 1));
		System.out.println(number + " >>> " + 2 + " = " + (number >>> 2));
		System.out.println(number + " >>> " + 3 + " = " + (number >>> 3));
	}	
}
