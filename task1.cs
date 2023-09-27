int a,b,c;
      a=1;
      b=17;
      c=12;
      int d=0;
      if(a%5==0)
      {
      d+=a;
      }
      if(b%5==0)
      {
      d+=b;
      }
      if(c%5==0)
      {
      d+=c;
      }
      if(d!=0)
      {
      Console.WriteLine("d = " +d);  
      }
      else 
      {
      Console.WriteLine("5-e bolunen eded yoxdur");
      }