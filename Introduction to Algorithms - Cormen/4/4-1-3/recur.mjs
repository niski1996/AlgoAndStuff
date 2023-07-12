
  
export const FindMaXSubArrRecur = (array, startIndex, endIndex,)=>{
    let downIndex = NaN;
    let upIndex = NaN;
    let sum = - Infinity;
    if(startIndex===endIndex){
        downIndex=startIndex;
        upIndex=endIndex;
        sum=array[downIndex]
        return {downIndex, upIndex, sum}
    }
    let leftArr = FindMaXSubArrRecur(
        array,
        startIndex,
        startIndex+ Math.floor((endIndex-startIndex)/2)
        );
    let righArr = FindMaXSubArrRecur(
        array, 
        startIndex+ Math.floor((endIndex-startIndex)/2)+1,
        endIndex
    );
    let centerArr = FindMaxSubArrOnTwo(
        array,
        startIndex,
        startIndex+ Math.floor((endIndex-startIndex)/2),
        startIndex+ Math.floor((endIndex-startIndex)/2)+1,
        endIndex
        )
        let val = leftArr>righArr?leftArr:righArr;
        return val>centerArr?val:centerArr;
        }


export const FindMaxSubArrOnTwo = (array, startLeft, endLeft, startRight, endRight)=>{
    let downIndex = endLeft;
    let upIndex = startRight;
    let sum = array[endLeft]+array[startRight];
    let tmpSum=sum;
    for(let i =startRight+1; i<endRight; i++){
        tmpSum+=array[i];
        if(tmpSum>sum){
            upIndex=i;
            sum=tmpSum;
        }

    }
    tmpSum=sum;
    for(let i =endLeft-1; i>=startLeft; i--){
        tmpSum+=array[i];
        if(tmpSum>sum){
            downIndex=i;
            sum=tmpSum;
        }

    }
    return{downIndex,upIndex,sum}
}
