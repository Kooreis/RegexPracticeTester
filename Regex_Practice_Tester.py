import re

def main():
    while True:
        regex = input("Enter your regex: ")
        test_string = input("Enter a string to test: ")

        match = re.search(regex, test_string)

        if match:
            print("Match found: ", match.group())
        else:
            print("No match found.")

        cont = input("Continue? (y/n): ")
        if cont.lower() != 'y':
            break

if __name__ == "__main__":
    main()