// https://www.hackerrank.com/challenges/sparse-arrays/problem
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

class Result {

    public static List<Integer> matchingStrings(List<String> strings, List<String> queries) {
        Integer[] result = new Integer[queries.size()];
        Arrays.fill(result, 0);

        for (int i = 0; i < queries.size(); i++) {
            for (int j = 0; j < strings.size(); j++) {
                if (queries.get(i).equals(strings.get(j))) {
                    result[i] = result[i] + 1;
                }

            }
        }


        return Arrays.asList(result);
    }

}