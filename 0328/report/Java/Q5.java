package report;

import java.util.Scanner;

public class Q5 {

	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
        
        int myArr[];
        myArr=new int[10];
        System.out.println("양의 정수 10개를 입력하시오>>");
        for(int i=0;i<myArr.length;i++) {
            myArr[i]=sc.nextInt();
        }
        System.out.print("3의 배수는: ");
        for(int j=0;j<myArr.length;j++) {
            if(myArr[j]%3==0)
                System.out.print(myArr[j]+" ");
        }
        
        sc.close();

	}

}
