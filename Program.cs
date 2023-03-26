
using System;
using static System.Console;

Clear();

string [] array = {"2rsdr1",  "htd", "sd512", "htd", "sq1", "532", "532", "dgss", "rwq5125", "sf", "gfr", "wqqfq" , "1w2", "wqqfq", "xyz"};
WriteLine($"[{String.Join(", ", array)}]");


int k=0;
int size = 0;

for (int i=0; i<array.Length;i++){
  if (array[i].Length<4){
    size= size+1;
  }

}
WriteLine (array.Length);
string [] res = new string [size];
 for (int n =0; n<array.Length;n++){
  if (array[n].Length<4){
    res[k]=array[n];
    k++;
  }
}

WriteLine($"Массив строк длина элементов которых меньше, либо равна трем имеет длину {size} и равен [{String.Join(", ", res)}]");



// string [] array = {"3yz", "h3", "xy", "2rsdr1", "sd512", "sq1","532"};
// WriteLine($"[{String.Join(", ", array)}]");
// WriteLine(array.Length);

// WriteLine(array[1].Length);
// int k=0;
// string [] res = new string [array.Length];
// for (int i=0; i<array.Length;i++){
//   if (array[i].Length<=3){
//      res[k]=array[i];
//   }
//   i++;}

// WriteLine($"Массив строк длина элементов которых меньше, либо равна трем имеет длину и равен [{String.Join(", ", res)}]");


// string [] array = {"xyz", "htd", "xy", "2rsdr1", "sd512", "sq1","532", "532", "dgss", "rwq5125", "sf", "wqqfq", "gfr", "1w2", "wqqfq"};
// WriteLine($"[{String.Join(", ", array)}]");
// WriteLine(array[1].Length);

// string res = string.Empty;
// for (int i=0; i<array.Length;i++){
//   if (array[i].Length<4){
//      res+=array[i] ;
//   }
//   i++;}

// WriteLine($"Массив строк длина элементов которых меньше, либо равна трем имеет длину и равен [{String.Join(" ", res)}]");