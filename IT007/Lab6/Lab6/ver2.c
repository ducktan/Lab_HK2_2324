#include <stdio.h>

int OTP(int a[50], int frames[5], int pos, int frame, int n)

{

    int flag[5] = {0, 0, 0, 0, 0};
    int i = pos + 1;
    for (i; i < n; i++)
    {
        int t = 0;
        for (t = 0; t < frame; t++)
            if (frames[t] == a[i])
                flag[t] = 1;
        int count = 0;
        for (t = 0; t < frame; t++)
            if (flag[t] == 1)
                count++;
        if (count == frame)
        {
            int f = 0;
            for (f; f < frame; f++)
                if (frames[f] == a[i])
                    return f;
        }
        if (i == n - 1)
        {
            int i = 0;
            for (i; i < frame; i++)
                if (flag[i] == 0)
                    return i;
        }
    }
}

int IsExist(int a, int temp[50], int index)

{

    int i = 0;
    for (i; i < index; i++)
        if (a == temp[i])
            return 1; // true 1
    return 0;         // false 0
}

int LRU(int a[50], int frames[5], int pos, int frame, int n) {
    int i = pos - 1;
    for (i; i >= 0; i--) {
        // Kiểm tra xem a[i] có tồn tại trong frames[] không
        for (int j = 0; j < frame; j++) {
            if (a[i] == frames[j]) {
                return j; // Trả về vị trí của a[i] trong frames[]
            }
        }
        
        // Nếu a[i] không tồn tại trong frames[], thêm nó vào
        int least_used = 0;
        for (int j = 1; j < frame; j++) {
            if (frames[j] < frames[least_used]) {
                least_used = j;
            }
        }
        frames[least_used] = a[i];
    }
    
    return -1; // Không tìm thấy a[i] trong frames[]
}

int defaultRef(int a[50])
{
    int n;
    n = 20;
    int b[20] = {2, 2, 5, 2, 1, 3, 0, 3, 0, 0, 7};
    int i = 0;
    for (i; i < n; i++)
        a[i] = b[i];
    return n;
}

int keyRef(int a[50])

{

    int n;
    printf(" \nEnter the number of ref: \n");
    scanf("%d", &n);
    printf(" \nEnter the ref[]:  \n");
    int i = 0;
    for (i; i < n; i++)
        scanf("%d", &a[i]);
    return n;
}

int main()

{

    int i, j, n, a[50], frames[5], frame, k, available, count = 0;
    int input;
    printf("---- - Page Replacement algorithm---- -\n");
    printf("1. Default referenced sequence.\n");
    printf("2. Manual input sequence.\n");
    scanf("%d", &input);
    if (input == 1)
        n = defaultRef(a);
    if (input == 2)
        n = keyRef(a);
    printf("\nInput page frames: :\n");
    scanf("%d", &frame);
    int y = 0;
    for (y; y < frame; y++)
        frames[y] = -1; // Giả sử ban đầu các frame trống

    printf("------Page Replacement algorithm-----\n");
    printf("1. FIFO algorithm\n");
    printf("2. OPT algorithm\n");
    printf("3. LRU algorithm\n");
    int choose;
    scanf("%d", &choose);
    if (choose == 1)
        printf("---FIFO Page Replacement algorithm---\n");
    if (choose == 2)
        printf("------OTP Page Replacement algorithm-----\n");
    if (choose == 3)
        printf("------LRU Page Replacement algorithm-----\n");
    j = 0;
    printf("\t|Ref|\t|Frame");
    for (k = 0; k < frame - 1; k++)
        printf("\t");
    printf("|\n");
    for (i = 0; i < n; i++)
    {
        printf("\t|  %d  |\t", a[i]);
        available = 0; // trang không có sẵn
        for (k = 0; k < frame; k++)
            if (frames[k] == a[i]) // kiểm tra trang có sẵn
                available = 1; // trang có sẵn
        if (available == 0) // thay thế trang nếu không có sẵn
        {
            if (choose == 1)
            {
                frames[j] = a[i];
                j = (j + 1) % frame;
            }
            else if (choose == 2)
            {
                if (i < frame)
                {
                    frames[j] = a[i];
                    j++;
                }
                else
                    frames[OTP(a, frames, i, frame, n)] = a[i];
            }

            else if (choose == 3)
            {
                if (i < frame)
                {
                    frames[j] = a[i];
                    j++;
                }

                else
                    frames[LRU(a, frames, i, frame, n)] = a[i];
            }
            count++;
            printf("|");
            for (k = 0; k < frame; k++)
                printf("%d\t", frames[k]);
            printf("| F"); // Dấu hiệu nhận biết xảy ra lỗi trang
        }
        else
        {
            printf("|");
            for (k = 0; k < frame; k++)
                printf("%d\t", frames[k]);
            printf("|");
        }
        printf("\n");
    }
    printf("Number of Page Fault: %d\n", count);
    return 0;
}