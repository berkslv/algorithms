// https://www.hackerrank.com/challenges/time-conversion/problem
import java.time.LocalTime;

class Result {

    public static String timeConversion(String s) {
        // Write your code here
        Integer hour = Integer.parseInt(s.substring(0, 2));
        Integer minute = Integer.parseInt(s.substring(3, 5));
        Integer second = Integer.parseInt(s.substring(6, 8));
        String type = s.substring(8, 10);
        LocalTime time = LocalTime.of(hour, minute, second);

        if (type.equals("AM") && hour == 12) {
            time = time.plusHours(-12);
        } else if (type.equals("PM") && ( hour < 12 && hour >= 1 )) {
            time = time.plusHours(12);
        }

        return time.toString();
    }

}