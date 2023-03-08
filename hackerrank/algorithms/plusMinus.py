# https://www.hackerrank.com/challenges/plus-minus/

def plusMinus(arr):
    arr.sort()

    negative_count = 0
    zero_count = 0
    positive_count = 0
    length = len(arr)

    for _, item in enumerate(arr):
        if item < 0:
            negative_count += 1
        elif item == 0:
            zero_count += 1
        elif item > 0:
            positive_count += 1
    
    print(positive_count / length)
    print(negative_count / length)
    print(zero_count / length)

arr = [-4, 3, -9, 0, 4, 1]
plusMinus(arr)