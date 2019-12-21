using System;
using System.Collections.Generic;

namespace Easy_csharp
{
    public static class DefangIPA
    {
        public static string Solution(string ips) {
            List<int> locations = new List<int>();
            for(var i =0; i<ips.Length; i++){
                if(ips[i] == '.'){
                    locations.Add(i);
                }
            }
            for(var j=locations.Count-1; j>=0; j--){
                ips = ips.Insert(locations[j]+1,"]");
                ips = ips.Insert(locations[j],"[");
            }
            
            return ips;
        }
    }
}
