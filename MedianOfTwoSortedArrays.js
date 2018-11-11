/*There are two sorted arrays nums1 and nums2 of size m and n respectively.

Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).

You may assume nums1 and nums2 cannot be both empty.

Example 1:

nums1 = [1, 3]
nums2 = [2]

The median is 2.0
Example 2:

nums1 = [1, 2]
nums2 = [3, 4]

The median is (2 + 3)/2 = 2.5*/

var findMedianSortedArrays = function(nums1, nums2) {
    for(let i = 0; i<nums2.length; i++){
    	nums1.push(nums2[i]);
    }
    nums1.sort(function(a,b){return a-b});
    let median;
    if(nums1.length%2==0){
    	let center = nums1.length/2;
    	median = (nums1[center]+nums1[center-1])/2;
    } else {
    	let center = nums1.length/2-0.5;
    	median = nums1[center];
    }
    return median;
};
console.log(findMedianSortedArrays([1,2],[3,4]));


