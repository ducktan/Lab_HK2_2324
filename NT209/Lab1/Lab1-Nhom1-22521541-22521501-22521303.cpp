#include <iostream>
#include <stdio.h>

using namespace std;
// hàm biểu diễn 1 số dưới dạng nhị phân 32 bit
void PrintBits(unsigned int x)
{
    int i;
    for (i = 8 * sizeof(x) - 1; i >= 0; i--)
    {
        (x & (1 << i)) ? putchar('1') : putchar('0');
    }
    printf("\n");
}
// Hàm biểu diễn 1 số dưới dạng nhị phân 32 bit (chỉ lấy 8 bit thấp)
void PrintBitsOfByte(unsigned int x)
{
    int i;
    for (i = 7; i >= 0; i--)
    {
        (x & (1 << i)) ? putchar('1') : putchar('0');
    }
    printf("\n");
}

// PHẦN 1
// 1.1. Sử dụng DeMorgan tính x. ~(~x & ~y) = x + y;
int bitOr(int x, int y)
{
    return ~(~x & ~y);
}

// 1.2 Tính -x mà không dùng toán tử -
// Giải thích: ta chuyển đổi số nguyên x sang dạng bù 1 bằng việc dùng phép NOT,
// sau đó cộng cho 1 ta được số bù 2 chỉnh là biểu diễn số âm của số x.

int negative(int x)
{
    return ~x + 1;
}

// 1.3 Trả về ký tự hex thứ n của x (Các ký tự được đánh thứ tự từ 0 đến 7)
// Giải thích: dịch vị trí ký tự cần lấy ra phía bên phải nhất.
// Ví dụ: 0x12345678 ta cần lấy ký tự 2 "6" thì ta dịch 6 về cuối cùng
// Độ dời shift = 2 * 4 (hay n << 2)
// Dịch bit x: x >> shift
// Thực hiện AND với mask 0xF (hay 1111)

int getHexcha(int x, int n)
{
    return (x >> (n << 2)) & 0xF;
}

// 1.4: Lật byte thứ n của số nguyên x
// Giải thích: Tạo 1 mask bằng cách lấy 0xFF (11111111) cho dịch trái 8*n bit (0 <= n <= 3)
// Thực hiện phép XOR để lật bit
int flipByte(int x, int n)
{
    return x ^ (0xFF << (n << 3));
}

// 1.5: Tính x/2^n (Hay x * 2^-n) nhưng do n < 0 ==> x * 2^n (n > 0) --> dịch trái n bit

// Nâng cao: 
int divpw2(int x, int n)
{
    int neg_n = (~n + 1);	// lấy số đối của n

	int temp = (n >> 31) & 1;  // Lấy bit dấu của số n
	temp = (temp ^ 1) & ((n | ((~n + 1) >> 31)));
    // Kiểm tra n có phải số dương không. Nếu đúng, temp = 1; ngược lại, temp = 0;
    
	int sign = ~temp + 1;	// 1 --> -1 : sign 32 bit 1
    
    // Lấy số đối của temp. Nếu temp = 1, sign là 32 bit 1; ngược lại, sign là 32 bit 0 dưới dạng binary

	int shiftRight = sign & n;	

	int shiftLeft = ~sign & neg_n;	
   

	return (x << shiftLeft) >> shiftRight; 
    
}
// 2.1: Sử dụng phép XOR kiểm tra x và y có giống nhau hay không. 
int isEqual(int x, int y)
{
    return !(x ^ y);
}

// 2.2: Bội của 16 đều có 4 bit cuối là 0000 --> 0x0. Sử dụng mask: 0xF để lấy 4 bit cuối của x 
int is16x(int x)
{
    return !(x & 0xF);
}

// 2.3
int isPositive(int x)
{
    int sign_x = (x >> 31) & 1;
    int neg_x = ~x + 1;
    return (sign_x ^ 1) & (x | (neg_x >> 31));
}

// 2.4
int isGE2n(int x, int n)
{
    int neg_n = ~(1 << n) + 1;
    return !((x + neg_n) >> 31);
}

// 2.5 Tìm max

int max(int x, int y) {
    int diff = x - y;
    int sign = (diff >> 31) & 1; // Lấy bit dấu của hiệu giữa x và y
    int mask = sign << 31 >> 31; // Tạo mask từ bit dấu

    // Trả về số lớn nhất, tùy thuộc vào bit dấu của hiệu
    return (x & ~mask) | (y & mask);
}









int main()
{
    int score = 0;
    printf("Your evaluation result:");
    printf("\n1.1 bitOr");
    if (bitOr(3, -9) == (3 | -9))
    {
        printf("\tPass.");
        score += 1;
    }
    else
        printf("\tFailed.");

    printf("\n1.2 negative");
    if (negative(0) == 0 && negative(9) == -9 && negative(-5) == 5)
    {
        printf("\tPass.");
        score += 1;
    }
    else
        printf("\tFailed.");

    // 1.3
    printf("\n1.3 getHexcha");
    if (getHexcha(26, 0) == 0xa && getHexcha(0x11223344, 1) == 0x4)
    {
        printf("\tPass.");
        score += 2;
    }
    else
        printf("\tFailed.");

    printf("\n1.4 flipByte");
    if (flipByte(10, 0) == 245 && flipByte(0, 1) == 65280 && flipByte(0x5501, 1) == 0xaa01)
    {
        printf("\tPass.");
        score += 3;
    }
    else
        printf("\tFailed.");
    // 1.5
    printf("\n1.5 divpw2");
    if (divpw2(10, -1) == 20 && divpw2(15, -2) == 60 && divpw2(2, -4) == 32)
    {
        if (divpw2(10, 1) == 5 && divpw2(50, 2) == 12)
        {
            printf("\tAdvanced Pass.");
            score += 4;
        }
        else
        {
            printf("\tPass.");
            score += 3;
        }
    }
    else
        printf("\tFailed.");

    printf("\n2.1 isEqual");
    if (isEqual(4, 2) == 0 && isEqual(-4, -4) == 1 && isEqual(0, 10) == 0)
    {
        printf("\tPass.");
        score += 2;
    }
    else
        printf("\tFailed.");

    // 2.2
    printf("\n2.2 is16x");
    if (is16x(16) == 1 && is16x(23) == 0 && is16x(0) == 1)
    {
        printf("\tPass.");
        score += 2;
    }
    else
        printf("\tFailed.");

    printf("\n2.3 isPositive");
    if (isPositive(5) == 1 && isPositive(-5) == 0 && isPositive(0) == 0)
    {
        printf("\tPass.");
        score += 3;
    }
    else
        printf("\tFailed.");

    // 2.4
    printf("\n2.4 isGE2n");
    if (isGE2n(12, 4) == 0 && isGE2n(8, 3) == 1 && isGE2n(15, 2) == 1)
    {
        printf("\tPass.");
        score += 3;
    }
    else
        printf("\tFailed.");

    printf("\n--- FINAL RESULT ---");
    printf("\nScore: %.1f", (float)score / 2);
    if (score < 5)
        printf("\nTrouble when solving these problems? Contact your instructor to get some hints :)");
    else
    {
        if (score < 8)
            printf("\nNice work. But try harder.");
        else
        {
            if (score >= 10)
                printf("\nExcellent. We found a master in bit-wise operations :D");
            else
                printf("\nYou're almost there. Think more carefully in failed problems.");
        }
    }

    printf("\n\n\n");
}