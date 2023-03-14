// https://www.hackerrank.com/challenges/flipping-bits/problem

class Result {

    public static long flippingBits(long n) {
        // Write your code here
            String bits = String.format("%32s", Long.toBinaryString(n)).replace(' ', '0');
    
            StringBuilder builder = new StringBuilder(bits);
            for (int i = 0; i < builder.length(); i++) {
                if (builder.charAt(i) == '0') {
                    builder.setCharAt(i, '1');
                } else if (builder.charAt(i) == '1') {
                    builder.setCharAt(i, '0');
                }
            }
            
            return Long.parseLong(builder.toString(), 2);
        }

}