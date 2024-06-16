 puts("\n[*] Phase 5\n-Hint: No hint is also a hint :)");
  s = (char *)read_line();
  phase5(s);

  size_t __cdecl phase5(char *s)
{
  size_t result; // eax@1
  int v2; // [sp+8h] [bp-10h]@3
  signed int i; // [sp+Ch] [bp-Ch]@3

  result = strlen(s);
  if ( result != 6 )
    explode_bomb();
  v2 = 0;
  for ( i = 0; i <= 5; ++i )
  {
    result = array_3852[s[i] & 0xF];
    v2 += result;
  }
  if ( v2 != 48 )
    explode_bomb();
  return result;
}