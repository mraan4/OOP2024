package hello;

public class ForExample01 {
	public static void main(String[] args) {
		int i=1, sum=0;
// 		1부터 100까지의 합
//		for (i = 1, sum = 0; i <= 100; i++) {
//			sum += i; // sum = sum + i;
//		}
//		1부터 100까지의 수 중에 짝수들의 합		
		//		for(;i<=100;i++) {
		//			if(i%2 ==0)
		//				sum += i;
//		}
//		1부터 100까지의 수 중에 홀수들의 합		
//				for(;i<=100;i++) {
//					if(i%2 ==1)
//						sum += i;
//				}
//		1부터 100까지의 수 중에 홀수들의 합
//				for(i=1;i<=100;i+=2) {
//						sum += i;
//				}
//		1부터 100까지의 수 중에 짝수들의 합
//				for(i=0;i<=100;i+=2) {
//						sum += i;
//				}
//		for(i=7; 1<= 100; i+=7)
//			sum += i;
		for(i=1; i<=100; i++)
			if(i%7==0)
				sum += 1;
		
		System.out.println("i = " + i + ", sum = " + sum);
	}
}
