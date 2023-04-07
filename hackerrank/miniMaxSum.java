// https://www.hackerrank.com/challenges/mini-max-sum/problem

import java.util.Collection;
import java.util.List;

class Result {

    public static void miniMaxSum(List<Integer> arr) {
        Collections.sort(arr);
        Long min = 0L;
        Long max = 0L;

        for (int i = 0; i < arr.size(); i++) {
            Integer item = arr.get(i);
            if (i >= 0 && i <= 3) {
                max += item;
            }

            if (i >= 1 && i <= 4) {
                min += item;
            }
        }
        
        System.out.println(max + " " + min);
    }

}