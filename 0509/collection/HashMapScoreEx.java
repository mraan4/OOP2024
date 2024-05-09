package collection;

import java.util.HashMap;
import java.util.Iterator;
import java.util.Set;

public class HashMapScoreEx {
	public static void main(String[] args) {
		HashMap<String, Integer> javaScore = new HashMap<String, Integer>();
		javaScore.put("김성동", 99);
		javaScore.put("이성동", 92);
		javaScore.put("박성동", 91);
		javaScore.put("정성동", 90);
		javaScore.put("홍성동", 88);
		
		System.out.println("HashMap element 개수 " + javaScore.size());
		Set<String> keys = javaScore.keySet();
		Iterator<String> it = keys.iterator();
		while(it.hasNext()) {
			String name = it.next();
			int score = javaScore.get(name);
			System.out.println(name + " : " + score);
		}
	}
}
