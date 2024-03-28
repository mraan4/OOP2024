package hello;

public class ContinueExample {
	public static void main(String[] args) {
		int sum = 0;
//		for(int i = 1;i<=100;i++) {
//			sum += i;
//		}
		for(int i = 1;i<=100;i++) {
			if(i%7==0)
				sum += i;
		}
		System.out.println("1부터 100까지의 수 중에 7의 배수들의 합은 " +sum + "입니다.");
		sum = 0;
//		for(int i = 1;i<=100;i++) {
//			if(i%7 == 0)
//				continue;
//			sum += i;
//		}
		int i = 1;
		while(i<=100) {
			if(i%7==0) {
				i++;
				continue;
			}
			sum += i;
			i++;
		}
		
		System.out.println("1부터 100까지의 수 중에 7의 배수를 제외한 수들의 합은 " +sum + "입니다.");
	}
}
