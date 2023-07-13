const roundRgb=(color)=>{
    if(color<0){
      return 0;
    }
    else if (color>255){
      return 255;
    }
    else return color;
  }
  
  function rgb(r, g, b){
    r=roundRgb(r);
    g=roundRgb(g);
    b=roundRgb(b);
    StringBuild =(r<15?"0":"")+r.toString(16).toUpperCase() //15, bo to kod
      +(g<15?"0":"")+g.toString(16).toUpperCase() 
      +(b<15?"0":"")+b.toString(16).toUpperCase();//+ ma wyższy priorytet niż ?


    return StringBuild
  }
  