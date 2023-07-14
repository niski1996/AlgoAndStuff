function towerBuilder(nFloors) {
    const empty = " ";
    const full = "*"
    const arr = []
    for (let i=0; i<nFloors;i++){
      const tmp = empty.repeat(nFloors-i-1)+full.repeat(i*2+1)+empty.repeat(nFloors-i-1);
      arr.push(tmp);
      }
    return arr;
    }
  