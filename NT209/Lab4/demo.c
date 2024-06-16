int userpass()
{
  size_t v0; // ebx@2
  int result; // eax@3
  size_t v2; // eax@15
  size_t v3; // edx@16
  char v4[9]; // [sp+Ah] [bp-2Eh]@6
  char v5[10]; // [sp+13h] [bp-25h]@1
  char s[10]; // [sp+1Dh] [bp-1Bh]@1
  char v7[5]; // [sp+27h] [bp-11h]@1
  unsigned int i; // [sp+2Ch] [bp-Ch]@4

  v7[0] = 102;
  v7[1] = 96;
  v7[2] = 108;
  v7[3] = 114;
  v7[4] = 90;
  getchar();
  puts("Enter your username:");
  __isoc99_scanf("%[^\n]", s);
  getchar();
  puts("Enter your password:");
  __isoc99_scanf("%[^\n]", v5);
  printf("Your input username: %s and password: %s\n", s, v5);
  if ( strlen(s) == 9 && (v0 = strlen(s), v0 == strlen(v5)) )
  {
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
      v2 = strlen(s);
      if ( v2 <= i || (s[i] + v4[i]) / 2 != v5[i] )
        break;
    }
    v3 = strlen(s);
    if ( v3 == i )
      result = success_3();
    else
      result = failed();
  }
  else
  {
    result = failed();
  }
  return result;
}