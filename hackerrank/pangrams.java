import java.util.HashSet;

// https://www.hackerrank.com/challenges/pangrams/problem

class Result {

    // HashMap solution
    public static String pangrams(String s) {
        HashMap<Character, Integer> map = new HashMap<Character, Integer>();
        List<Character> initilizer = List.of('a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z');
        for (Character letter : initilizer) {
            map.put(letter, 0);
        }
        initilizer = null;

        for (int i = 0; i < s.length(); i++) {
            Character item = s.charAt(i);
            map.put(Character.toLowerCase(item), 1);
        }
        
        if (map.containsValue(0)) {
            return "not pangram";
        }
        
        return "pangram";
    }

    // HashSet solution
    public static String pangramsHashSet(String s) {
        HashSet set = new HashSet<Character>();

        for (int i = 0; i < s.length(); i++) {
            Character item = s.charAt(i);
            if (Character.isLetter(item)) {
                set.add(Character.toLowerCase(item));
            }
        }

        if (set.size() == 26) {
            return "pangram";
        }

        return "not pangram";
    }


}
