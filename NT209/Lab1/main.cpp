#include <iostream>
#include <limits.h>
using namespace std;

int max(int x, int y)
{
    int neg_y = ~y + 1;
    int mask = x >> 31;
    int abs = (x + neg_y ^ mask) + (~mask + 1);
    return (x + y + abs) >> 1; // x+y
}

main()
{
    // int x = -5;
    // int y = 3;
    // cout << max(x, y);
    // cout << max(121, 0);
    cout << max(214748364732, -214748364731);
}