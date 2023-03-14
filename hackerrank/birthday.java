// https://www.hackerrank.com/challenges/the-birthday-bar/problem

class Result {


    public static int birthday(List<Integer> s, int d, int m) {
        int sum = 0;
        int result = 0;
        
        for (int i = 0; i <= s.size()-m; i++) {
            for (int j = i; j < m+i; j++) {
                sum += s.get(j);
                System.out.println("j: " + j);
            }
            if (sum == d) {
                result += 1;   
            }
            sum = 0;
        }
        
        return result;
    }

}