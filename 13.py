# 13. Roman to Integer.
# Given a roman numeral, convert it to an integer.
#
# Python:   3.10.7
# Author:   Ethan LaRocca
# Purpose:  Testing ground for leetcode challenge.
# Date:     11/28/22 (MM/DD/YY)

# Variables to test:
#s = "III"      # Output should be "3"     // I = 1
#s = "LVIII"    # Output should be "58"    // L = 50, V = 5, I = 1
#s = "LXXIV"    # Output should be "74"    // L = 50, X = 10, X = 10, I = 1, X = 5
#s = "XCIX"     # Output should be "99"    // [X - C] = [10 - 100], [I - X] = [1 - 10]
s = "MCMXCIV"  # Output should be "1994"  // M = 1000, CM = (100 - 1000), XC = (10 - 100) and IV = (1 - 5)

def romanToInt(s):
    romanDict = { "I":1, "V":5, "X":10, "L":50, "C":100, "D":500, "M":1000 } # dictionary with KVP for Roman Numeral : Number value
    sum = 0 # varialbe used for iteration sum
    i = 0 # iteration count
    while i < len(s): # while iteration is less than the length of s
        if len(s) > i+1: # if the length of string is greater than iteration + 1 / if the length of the string is in-bounds
            # ex.: if X[10] < C[100]:
            if romanDict[s[i]] < romanDict[s[i+1]]:
                # ex.: sum = sum + (C[100] - X[10])
                sum += romanDict[s[i+1]] - romanDict[s[i]] 
                i += 2 # add 2 to iteration counter, a check to skip
                continue # check again
        sum += romanDict[s[i]] # add all sums together
        i += 1 # add 1 to iteration counter
    print("Sum: " + str(sum)) 
romanToInt(s)
