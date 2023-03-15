// https://www.hackerrank.com/challenges/sock-merchant/problem

class Result {

    public static int sockMerchant(int n, List<Integer> ar) {

        HashMap<Integer, Integer> hashMap = new HashMap<>();
        int pairs = 0;

        for (int i = 0; i < ar.size(); i++) {
            int key = ar.get(i);
            if (!hashMap.containsKey(key)) {
                hashMap.put(key, 1);
            } else {
                hashMap.put(key, hashMap.get(key)+1);
                
                if (hashMap.get(key) % 2 == 0 && hashMap.get(key) != 0) {
                    pairs++;
                    hashMap.put(key, 0);
                }
            }

        }

        return pairs;
    }

}