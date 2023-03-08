def miniMaxSum(arr):
    arr.sort()
    less = sum(arr, -arr[-1])
    high = sum(arr, -arr[0])
    print(less, high)

arr = [1, 2, 3, 4, 5]
miniMaxSum(arr)
