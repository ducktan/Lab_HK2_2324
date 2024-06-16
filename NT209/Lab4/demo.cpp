#include <iostream>
#include <string.h>
using namespace std; 

int main(){
    size_t v0; // ebx@2
    int result; // eax@3
    size_t v2; // eax@15
    size_t v3; // edx@16
    char v4[9]; // [sp+Ah] [bp-2Eh]@6
    char v5[10]; // [sp+13h] [bp-25h]@1
    
    char v7[5]; // [sp+27h] [bp-11h]@1
    unsigned int i; // [sp+2Ch] [bp-Ch]@4

    string s = "303501541";

    v7[0] = 102;
    v7[1] = 96;
    v7[2] = 108;
    v7[3] = 114;
    v7[4] = 90;

    for ( i = 0; (signed int)i <= 8; ++i )
    {
      if ( (signed int)i > 1 )
      {
        if ( (signed int)i > 3 )
          v4[i] = v7[i - 4];
        else
          v4[i] = s[i + 5];
      }
      else
      {
        v4[i] = s[i + 2];
      }
    }
    for ( i = 0; ; ++i )
    {
      v2 = 9;
      v5[i] = (s[i] + v4[i]) / 2;  
      if ( v2 <= i )
        break;
    }
    cout << v5; 
    return 0;
}