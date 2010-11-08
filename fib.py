import sys

def fib(n, acc1, acc2):
  return (acc1 if n < 2 else fib(n-1, acc1 + acc2, acc1))

if __name__=="__main__":
  print fib(int(sys.argv[1]), 1, 1)
