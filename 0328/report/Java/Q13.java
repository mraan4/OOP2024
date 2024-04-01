package report;

public class Q13 {

	public static void main(String[] args) {
		for(int i=0; i<100; i++) {
            int cnt = 0;
            
            if(i%10==3 || i%10==6|| i%10==9) {
                cnt +=1;
            }
            if(i/10 ==3 || i/10 == 6 || i/10 == 9) {
                cnt+=1;
            }
            
            if(cnt == 1) {
                System.out.println(i+ " 박수 짝");
            }else if(cnt == 2) {
                System.out.println(i+ " 박수 짝짝");
            }
        }
 
	}

}
