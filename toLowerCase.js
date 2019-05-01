// implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.

 

// Example 1:

// Input: "Hello"
// Output: "hello"
// Example 2:

// Input: "here"
// Output: "here"
// Example 3:

// Input: "LOVELY"
// Output: "lovely"

var toLowerCase = function(str) {
     var result = ''
    
    for (var i = 0; i < str.length; i++) {
        var code = str.charCodeAt(i)
      
      if (code > 64 && code < 91) {
        result += String.fromCharCode(code + 32)
      } else {
        result += str[i]
      }
    }
    
    return result
};

