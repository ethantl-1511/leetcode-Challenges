# 2108. Find First Palindromic String in the Array || https://leetcode.com/problems/find-first-palindromic-string-in-the-array/
# Given an array of strings words, return the first palindromic string in the array. If there is no such string, return an empty string "".
#
# Python:   3.10.7
# Author:   Ethan LaRocca
# Purpose:  Testing ground for leetcode challenge
# Date:     11/24/22 (MM/DD/YY)

words = ["abc","car","ada","racecar","cool"] # array list given by leetcode
 
def firstPalindrome(words): # function
    for i in words:         # iterate through the list
        if i[::-1] == i:    # if the reverse of iteration is == to iteration
            return i        # return the first iteration
    return ""
            
print(firstPalindrome(words)) #calling function and printing it
