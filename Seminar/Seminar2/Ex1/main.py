import random as r //импорт модуля


number = random.randint(10, 100) //number = r.randint(10, 100)
print(f"number: {number}")
x = number // 10
y = number % 10
 
if x >y:
    print(x) 
else:
   print(y)


