// https://www.hackerrank.com/challenges/grading/problem

class Result {

    public static List<Integer> gradingStudents(List<Integer> grades) {
        List<Integer> result = new ArrayList<>();
        for (int grade : grades) {
            result.add(evaluate(grade));
        }
        return result;
    }

    public static int evaluate(int grade) {
        if (grade < 38) {
            return grade;
        }

        int nextMultipleOfFive = (grade / 5 + 1) * 5;
        if (nextMultipleOfFive - grade < 3) {
            return nextMultipleOfFive;
        }
        
        return grade;
    }

}