// https://www.hackerrank.com/challenges/extra-long-factorials/problem?isFullScreen=true

import java.math.BigInteger;

class Result {

    public static void extraLongFactorials(int n) {
        BigInteger bigInteger = BigInteger.ONE;

        for (int i = n; i > 0; i--) {
            bigInteger = bigInteger.multiply(BigInteger.valueOf(i));
        }

        System.out.println(bigInteger);
    }

}