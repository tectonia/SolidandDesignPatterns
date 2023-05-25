class Singleton:
    __instance = None
    __counter = 0
    def __new__(cls):
        if cls.__instance == None:
            cls.__instance = super().__new__(cls)
        return cls.__instance
    def __init__(self):
        Singleton.__counter += 1
        print("Counter Value " + str(Singleton.__counter))
    def print_details(self, message):
        print(message)

# Test 
obj1 = Singleton()
obj1.print_details("Object 1")

obj2 = Singleton()
obj2.print_details("Object 2")