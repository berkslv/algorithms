// https://www.hackerrank.com/challenges/plus-minus/problem
import java.util.Collections;
import java.util.List;

class Result {

    public static void plusMinus(List<Integer> arr) {
        Collections.sort(arr);

        Float positive = 0f;
        Float negative = 0f;
        Float zero = 0f;

        for (int i = 0; i < arr.size(); i++) {
            if (arr.get(i) > 0) {
                positive++;
            } else if (arr.get(i) < 0) {
                negative++;
            } else if (arr.get(i) == 0) {
                zero++;
            }
        }

        System.out.println(positive / arr.size());
        System.out.println(negative / arr.size());
        System.out.println(zero / arr.size());
    }

}