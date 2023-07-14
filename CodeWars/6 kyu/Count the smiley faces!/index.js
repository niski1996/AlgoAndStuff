function countSmileys(arr) {
    return arr.reduce(smile,0);
    
  };
  const smile =(acc,cur)=> {
      if(!(cur[0]===';'||cur[0]===":")){
        return acc;
      }
      else if(cur.length===3){
            if(!(cur[1]==='-'||cur[1]==="~")){

                return acc;
                }

            }

    return acc+((cur[cur.length - 1]===')'||cur[cur.length - 1]==='D')?1:0);
      }

console.log(countSmileys([':D',':~)',';~D',':)']  ));