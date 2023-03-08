# https://www.hackerrank.com/challenges/staircase/

import re

def staircase(n):
    s = " "*n
    for i in range(1, n+1):
        replaced = " "*i 
        print(re.sub(replaced+"$","#"*i,s))

n = 6
staircase(n)