// The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

// Given two integers x and y, calculate the Hamming distance.

// Note:
// 0 ≤ x, y < 231.

// Example:

// Input: x = 1, y = 4

// Output: 2

// Explanation:
// 1   (0 0 0 1)
// 4   (0 1 0 0)
//        ↑   ↑

// The above arrows point to positions where the corresponding bits are different.

var hammingDistance = function(x, y) {
    var count = 0;
    var binX = x.toString(2);
    var binY = y.toString(2);
    var greaterValue = binX.length > binY.length ? binX : binY;
    var lesserValue = binX.length > binY.length ? binY : binX;
    var zeroDifference =  binX.length > binY.length ? binX.length - binY.length : binY.length - binX.length;
    
    for (let i = 0; i < zeroDifference; i++) {
        lesserValue = "0"+lesserValue;
    }

    for(let i = 0; i < greaterValue.length; i++){
        if(greaterValue[i]!=lesserValue[i]){
            count++;
        }
    }

    console.log(lesserValue);
    console.log(greaterValue);

    console.log(zeroDifference);
    
    console.log(count);
    return count;
};

hammingDistance(1,4);