package report;

public class Q7 {

	public static void main(String[] args) {
		int arr[] = new int[10];
        
        for(int i=0; i<10; i++) {
            arr[i] = (int)(Math.random()*10+1);
        }
        System.out.print("랜덤한 정수들 : ");
        double sum = 0;
        for (int i=0; i<10; i++) {
            System.out.print(arr[i]+" ");
            sum += arr[i];
        }
        System.out.println("\n평균은 "+sum/10);
        

	}

}
