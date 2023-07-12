import {FindMaXSubArrForce} from './force.mjs'
import {FindMaXSubArrRecur,FindMaxSubArrOnTwo} from './recur.mjs'

let arr = [1,4,-6,90,-101,90,-1,2,3,4,5,2,-9,-3,8,-22]
arr= [...arr,...arr,-200,3,4,1,3,-4,21,-89,21,78,90,-31,100]
arr=[...arr,...arr,...arr,...arr,...arr,...arr,...arr,]
arr=[...arr,...arr,...arr,...arr,...arr,...arr,...arr,]
console.log(arr)
const start1 = performance.now();
console.log(FindMaXSubArrRecur(arr,0,arr.length));
const end1 = performance.now();
console.log(end1-start1);
const start2 = performance.now();
console.log(FindMaXSubArrForce(arr));
const end2 = performance.now();
console.log(end2-start2);