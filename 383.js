/**
 * 383. Ransom Note
 * Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
 * 
 * Author:  Ethan LaRocca
 * Purpose: Testing ground for leetcode challenge.
 * Date:    11/30/22 (MM/DD/YY)
 * 
 **/

var ransomNote = "caca";
var magazine = "aabc";
var canConstruct = function(ransomNote, magazine) {
    let found = false; // boolean for if letter is found, currently not found
    for (let i = 0; i < ransomNote.length; i++) { // iterate through ransomeNote string
        found = false; // found is false at the beginning of each loop
        for (let j = 0; j < magazine.length; j++) { // iterate through magazine string
            if (ransomNote[i] === magazine[j]) { // if ransomNote[iteration value] is equal to magazine[jiteration value]
                found = true; // found a letter
                let magazineArray = magazine.split(''); // convert string to array
                magazineArray.splice(j, 1); // splice found letter from array
                magazine = magazineArray.join(''); // convert back to string
                break
            }
        }
        if (found == false) { // iterated through J and found nothing
            console.log("Magazine did not contain all the letters. False.");
            return false
        }
    } // iterated through all of I and J and found them all
    console.log("Magazine contained all the letters. True.")
    return true
};
console.log(canConstruct(ransomNote, magazine))