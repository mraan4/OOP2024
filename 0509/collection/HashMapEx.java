package collection;

import java.util.HashMap;
import java.util.Scanner;

public class HashMapEx {
	public static void main(String[] args) {
		HashMap<String, String> dic = new HashMap<String, String>();
		Scanner scanner = new Scanner(System.in);
		for(int i = 0; i < 4; i ++) {
			System.out.print("영어 단어 : ");
			String key = scanner.next();
			System.out.print(key +"에 대응하는 한글 : ");
			String value = scanner.next();
			dic.put(key, value);
		}
		System.out.println(dic.entrySet());
		System.out.println(dic.keySet());
		System.out.println(dic.values());
		while(true) {
			System.out.print("찾고 싶은 단어 : ");
			String eng = scanner.next();
			if(eng.equals("exit")) {
				System.out.println("종료합니다.");
				break;
			}
			String kor = dic.get(eng);
			if(kor==null) 
				System.out.println("찾는 단어가 없습니다.");
			else
				System.out.println("영어 단어 : " + eng + " => " + kor);
		}
		scanner.close();
	}
}
