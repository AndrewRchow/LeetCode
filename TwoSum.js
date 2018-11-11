/*Given an array of integers, return indices of the two numbers such that they
add up to a specific target.

You may assume that each input would have exactly one solution, and you may
not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9, return [0, 1].
*/
var a = [2,7,11,15];
var b = 9;
var twoSum = function(nums, target) {
	let output = [];
	for(let i = 0; i<nums.length; i++){
		let pair = target - nums[i];
		let pairIndex = nums.indexOf(pair);
		if(pairIndex!=-1 && pairIndex!=i){
			output.push(i);
			output.push(nums.indexOf(pair));
			return output;
		}
	}    
};

console.log(twoSum(a,b));