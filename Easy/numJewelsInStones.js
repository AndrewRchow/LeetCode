var test1 = "aA";
 var test2 = "aAAbbbb";

 var numJewelsInStones = function(J, S) {
    var count = 0;
    loop1:
    for (var i = 0; i<S.length; i++){
        loop2:
        for(var j = 0; j<J.length; j++){
            if(S[i]==J[j]){
                count++;
                break loop2;
            }
        }
    }
    
    return count;
};

console.log(numJewelsInStones(test1,test2));