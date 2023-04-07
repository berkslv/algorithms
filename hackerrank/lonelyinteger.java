// https://www.hackerrank.com/challenges/lonely-integer/problem

import java.util.HashMap;
import java.util.List;

class Result {

    public static int lonelyinteger(List<Integer> a) {
        Integer result = 0;

        for (Integer item : a) {
            result = result ^ item;    
        }

        return result;
    }

}