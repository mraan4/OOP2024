package report;

import java.util.Scanner;

public class OpenChallenge {
	public static void main(String[] args) {
		 Scanner sc = new Scanner(System.in);
	        
	        while(true) {
	            System.out.println("수를 결정하였습니다. 맞추어 보세요\n0~99");
	            int i = 1;
	            int num = (int)(Math.random()*100);   
	            System.out.println(num);
	            
	            while(true) {
	                System.out.print(i+ ">>");
	                int user = sc.nextInt();
	                
	                if(user > num) {
	                    System.out.println("더 낮게.");
	                }
	                else if(user < num) {
	                    System.out.println("더 높게.");
	                }else {
	                    System.out.println("맞았습니다.");
	                    System.out.println("다시하시겠습니까(y/n)>>");
	                    String ans = sc.next();
	                    if(ans.contentEquals("y")) {
	                        break;
	                    }else if(ans.contentEquals("n")) {
	                        System.exit(0);    
	                    }
	                }
	            }
	            sc.close();
	        }
	}
}
