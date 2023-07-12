export const FindMaXSubArrForce = (array)=>{
let downIndex = NaN;
let upIndex = NaN;
let sum = - Infinity;
for(let i =0; i<array.length;i++){
    if(array[i]>sum){
        sum=array[i];
        downIndex= i;
        upIndex=i;
    }
    let tmpSum = array[i];
    for(let k=i+1; k<array.length; k++){
        tmpSum+=array[k];
        if(sum<tmpSum){
            sum=tmpSum
            downIndex= i;
            upIndex=k;
        }

    }
}
const val ={downIndex,upIndex,sum};
return val;
}


