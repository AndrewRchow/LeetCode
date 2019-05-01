/*Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21*/

var reverse = function(x) {
	let output;

	if(x<0){
		output = -x;
	}
    output=parseInt(x.toString().split('').reverse().join(''));
    if(x<0){
    	output = -output;
    }
    if(output<-2147483647 || output>2147483647){
		return 0;
	}
    return output;
};
console.log(reverse(-321));