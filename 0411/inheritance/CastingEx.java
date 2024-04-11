package inheritance;

public class CastingEx {
	public static void main(String[] args) {
		// 정수 byte, short, int, long
		// 실수 float, double
		// 논리 boolean
		// 문자 char
		// 크기 byte < short < int < long < float < double
		int i = 1;
		long l = 2;
		
		l = i;		// 큰 = 작은 	묵시적으로(자동으로) 캐스팅 됨, i가 long형으로 변경되어 l에 할당
		System.out.println("i = " + i + ", l = " + l);
		
		i = 1;
		l = 2;
		//i = l; //에러 왜냐하면  작은 = 큰		작은 곳에 큰 값을 넣을 수 없음
		
		i = (int) l; 		// 8바이트 long l을 4바이트로 캐스팅(변경)해서 4바이트 i에 할당 
		System.out.println("i = " + i + ", l = " + l);
		
	}
}
