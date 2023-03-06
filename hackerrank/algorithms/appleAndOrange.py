# https://www.hackerrank.com/challenges/apple-and-orange/problem

def countApplesAndOranges(s, t, a, b, apples, oranges):
    apples_in_range = 0    
    for i in apples:
        if a+i >= s and a+i <= t:
            apples_in_range = apples_in_range + 1
    print(apples_in_range)
    
    oranges_in_range = 0
    for i in oranges:
        if b+i >= s and b+i <= t:
            oranges_in_range = oranges_in_range + 1
    print(oranges_in_range)
    

s = 7
t = 11
a = 5
b = 15
apples = [-2, 2, 1]
oranges = [5, -6]
countApplesAndOranges(s, t, a, b, apples, oranges)
