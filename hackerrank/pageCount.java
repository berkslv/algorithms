// https://www.hackerrank.com/challenges/drawing-book/problem

class Result {

    public static int pageCount(int n, int p) {
        int totalPageTurnCountFromStart = n / 2;
        int targetPageTurnCountFromStart = p / 2;
        int targetPageTurnCountFromEnd = totalPageTurnCountFromStart - targetPageTurnCountFromStart;
        
        return Math.min(targetPageTurnCountFromStart, targetPageTurnCountFromEnd);
    }

}