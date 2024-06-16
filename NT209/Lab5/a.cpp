#include <iostream>
using namespace std;
// namespace std;


int func4(int a1, int a2)
{
  int result; // eax@2
  int v3; // ebx@5

  if ( a1 > 0 )
  {
    if ( a1 == 1 )
    {
      result = a2;
    }
    else
    {
      v3 = func4(a1 - 1, a2) + a2;
      result = v3 + func4(a1 - 2, a2);
    }
  }
  else
  {
    result = 0;
  }
  return result;
}

int main(){
    cout << "2: func4(7, 2) = " << func4(7,2) << endl;
    cout << "3: func4(7, 3) = " << func4(7,3) << endl;
    cout << "4: func4(7, 4) = " << func4(7,4) << endl;
    return 0;
}