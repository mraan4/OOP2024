package report;

import java.util.Scanner;

public class Q6 {

	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
        
        int unit[]= {50000,10000,1000,100,10,1};
        
        System.out.println("금액을 입력하시오>>");
        int money=sc.nextInt();
        
        for(int i=0;i<unit.length;i++) {
            System.out.println(unit[i]+"원 짜리 : "+money/unit[i]+"개 ");
            money-=(money/unit[i])*unit[i];  
        }
        sc.close();
	}

}
