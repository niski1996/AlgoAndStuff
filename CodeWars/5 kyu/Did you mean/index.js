function Dictionary(words) {
    this.words = words;
  }
  
  Dictionary.prototype.findMostSimilar = function(term) {
    const objArr = this.words.map(word=>LevenshteinDistance(word, term));
    console.log(objArr)
    return this.words[objArr.indexOf(Math.min(...objArr))]
   
  }
  
  const LevenshteinDistance = (w1, w2) => {
    const levArr = [];
    for (let i = 0; i <= w1.length; i++) {
      levArr[i] = [];
      for (let k = 0; k <= w2.length; k++) {
        if (k === 0) {
          levArr[i][k] = i;
        } else if (i === 0) {
          levArr[i][k] = k;
        } else {
          levArr[i][k] = Math.min(
            levArr[i - 1][k] + 1,
            levArr[i][k - 1] + 1,
            levArr[i - 1][k - 1] + (w1[i - 1] !== w2[k - 1] ? 1 : 0)
          );
        }
      }
    }
    return levArr[w1.length][w2.length];
  };