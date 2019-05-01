/*Given a string, find the length of the longest substring without repeating characters.

Example 1:

Input: "abcabcbb"
Output: 3 
Explanation: The answer is "abc", with the length of 3. 
Example 2:

Input: "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3. 
             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.*/
var a = "abcabcbb";
var lengthOfLongestSubstring = function(s) {
	let maxCounter = 0;
    for(let i = 0; i<s.length; i++){
    	let letters = [];
    	let counter = 0;
    	for(let j = i; j<s.length; j++) {
    		if(letters.indexOf(s[j])==-1){
    			letters.push(s[j]);
    			counter++;
    			if(counter > maxCounter){
    				maxCounter = counter;
    			}

    		} else {
    			break;
    		}
    	}
    }
    return maxCounter;
};

console.log(lengthOfLongestSubstring(a));