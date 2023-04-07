// https://www.hackerrank.com/challenges/birthday-cake-candles/problem

class Result {

    public static int birthdayCakeCandles(List<Integer> candles) {
        int max = Collections.max(candles);   
        return Collections.frequency(candles,max);
    }

}