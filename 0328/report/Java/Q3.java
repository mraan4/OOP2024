package report;

import java.util.Scanner;

public class Q3 {
	public static void main(String[] args) {
		 Scanner sc=new Scanner(System.in);
	        System.out.print("정수를 입력하시오>>");
	        int n=sc.nextInt();
	        int t=n;
	        for(int i=0;i<n;i++) {
	            for(int j=0;j<t;j++) {
	                System.out.print("*");
	                
	            }
	            t--;
	                System.out.println();
	                
	    }
	        sc.close();
	}
}
