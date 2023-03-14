// https://www.hackerrank.com/challenges/diagonal-difference/problem

class Result {

    public static int diagonalDifference(List<List<Integer>> arr) {
        Integer left = 0;
        Integer right = 0;

        for (int i = 0; i < arr.size(); i++) {
            left += arr.get(i).get(i);
            right += arr.get(i).get(arr.size() - 1 - i);
        }   

        return Math.abs(left - right);
    }

}