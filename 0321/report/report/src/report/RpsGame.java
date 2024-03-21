package report;

import java.util.Scanner;

public class RpsGame {

	public static void main(String[] args) {
		System.out.println("가위바위보 게임입니다. 가위, 바위, 보 중에서 입력하세요");
		Scanner scanner = new Scanner(System.in);
		
		System.out.print("철수 >> ");
		String player1 = scanner.next();
		
		System.out.print("영희 >> ");
		String player2 = scanner.next();
		
		if(player1.equals("가위")) {
			if(player2.contentEquals("가위")) {
				System.out.println("비겼습니다.");
			}else if(player2.contentEquals("바위")) {
				System.out.println("영희가 이겼습니다.");
			}else if(player2.contentEquals("보")) {
				System.out.println("철수가 이겼습니다.");
			}else {
				System.out.println("가위 바위 보 중에 입력하세요.");
			}
		}
		else if(player1.equals("바위")) {
			if(player2.contentEquals("가위")) {
				System.out.println("철수가 이겼습니다..");
			}else if(player2.contentEquals("바위")) {
				System.out.println("비겼습니다.");
			}else if(player2.contentEquals("보")) {
				System.out.println("영희가 이겼습니다.");
			}else {
				System.out.println("가위 바위 보 중에 입력하세요.");
			}
		}
		else if(player1.equals("보")) {
			if(player2.contentEquals("가위")) {
				System.out.println("영희가 이겼습니다..");
			}else if(player2.contentEquals("바위")) {
				System.out.println("철수가 이겼습니다.");
			}else if(player2.contentEquals("보")) {
				System.out.println("비겼습니다.");
			}else {
				System.out.println("가위 바위 보 중에 입력하세요.");
			}
		}
		else {
			System.out.println("가위 바위 보 중에 입력하세요");
		}
	}

}
