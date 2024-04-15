package report2;

abstract class Pairmap {
	protected String keyArray[];
	protected String valueArray[];
	abstract String get(String key);
	abstract void put(String key, String value);
	abstract String delete(String key);
	abstract int length();
}

class Dictionary extends Pairmap {
	private int item;
	
	public Dictionary(int n) {
		keyArray = new String[n];
		valueArray = new String[n];
		this.item = 0;
	}
	@Override
	public String get(String key) {
		for(int i=0; i<keyArray.length; i++) {
			if(key.equals(keyArray[i]))
				return keyArray[i];
		}
		return null;
	}
	@Override
	public void put(String key, String value) {
		for(int i=0; i<keyArray.length; i++) {
			if(key.equals(keyArray[i])) {
				keyArray[i] = key;
				valueArray[i] = value;
				return;
			}
		}
		keyArray[item] = key;
		valueArray[item] = value;
		item++;
	}
	@Override
	public String delete(String key) {
		for(int i=0; i<keyArray.length; i++) {
			if(key.equals(keyArray[i])) {
				String val = valueArray[i];
				keyArray[i] = null;
				valueArray[i] = null;
				return val;
			}
		}
		return null;
	}
	@Override
	public int length() {
		return item;
	}
}

public class Ex5_10 {
	public static void main(String[] args) {
		Dictionary dic = new Dictionary(10);
		dic.put("김둘리", "자바");
		dic.put("고길동", "파이썬");
		dic.put("고길동", "C++");
		System.out.println("고길동의 값은 "+dic.get("고길동"));
		System.out.println("김둘리의 값은 "+dic.get("김둘리"));
		dic.delete("김둘리");
		System.out.println("김둘리의 값은 "+dic.get("김둘리"));
	}
}