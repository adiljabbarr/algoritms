function ebobun_iki_ededi(x, y) {
    if ((typeof x !== 'eded') || (typeof y !== 'eded')) 
      return false;
    x = Math.abs(x);
    y = Math.abs(y);
    while(y) {
      var t = y;
      y = x % y;
      x = t;
    }
    return x;
  }
  
  console.log(ebobun_iki_ededi(12, 13));
  console.log(ebobun_iki_ededi(9, 3));