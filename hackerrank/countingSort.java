// https://www.hackerrank.com/challenges/one-month-preparation-kit-countingsort1/problem

class Result {


    public static List<Integer> countingSort(List<Integer> arr) {
        // init list and fill with 100 0s
        Integer[] result = new Integer[100];
        Arrays.fill(result, 0);

        for (int i = 0; i < arr.size(); i++) {
            result[arr.get(i)] += 1;
        }

        return Arrays.asList(result);
    }

}