#include<stdio.h>
#include<stdlib.h>
#include<time.h>
typedef struct {
    int iArrival, iBurst, iPID;
    int iResponse, iWaiting, iStart, iFinish, iTaT;
}PCB;

void INIT_ARR(int Num_Of_Process, PCB P[]){
    for(int i=0; i<Num_Of_Process; i++){
        P[i].iPID = i + 1;
        printf("Process %d: \n", i+1);
        printf("Arrival: ");
        scanf("%d", &P[i].iArrival);
        printf("Burst: ");
        scanf("%d", &P[i].iBurst);
    }
}

void PRINT_ARR(int Num_Of_Process, PCB P[]){
    for(int i=0; i<Num_Of_Process; i++){
        printf("P%d ", P[i].iPID);
        printf("(%d, ", P[i].iArrival);
        printf("%d)\n", P[i].iBurst);
    }
}

void swap(PCB *A, PCB *B){
    PCB Temp = *A;
    *A = *B;
    *B = Temp;
}

void quickSort_Arrival(PCB a[], int l, int r){
    PCB p=a[(l+r)/2]; ///p: la phan tu privot 
    int i=l, j=r;
    while(i<=j){
        while(a[i].iArrival < p.iArrival){
            i++;
        }
        while(a[j].iArrival > p.iArrival){
            j--;
        }
        if(i<=j){
            swap(&a[i],&a[j]);
            i++;
            j--;
        }
    }
    if(i<r){
        quickSort_Arrival(a,i,r);
    }
    if(l<j){
        quickSort_Arrival(a,l,j);
    }
}

void quickSort_Burst(PCB a[], int l, int r){
    PCB p=a[(l+r)/2]; ///p: la phan tu privot 
    int i=l, j=r;
    while(i<=j){
        while(a[i].iBurst<p.iBurst){
            i++;
        }
        while(a[j].iBurst>p.iBurst){
            j--;
        }
        if(i<=j){
            swap(&a[i],&a[j]);
            i++;
            j--;
        }
    }
    if(i<r){
        quickSort_Burst(a,i,r);
    }
    if(l<j){
        quickSort_Burst(a,l,j);
    }
}

void UPDATE_START(int P_Terminated, PCB Terminated_Arr[], PCB *Q, int *Time_line){
    if(P_Terminated == 0){
        Q->iStart = Q->iArrival;
    }
    else if(P_Terminated > 0){
        if(Q->iArrival <= Terminated_Arr[P_Terminated-1].iFinish){
            Q->iStart = Terminated_Arr[P_Terminated-1].iFinish;
        }
        else if(Q->iArrival > Terminated_Arr[P_Terminated-1].iFinish){
            Q->iStart = Q->iArrival;
        }
    }
    *Time_line = Q->iStart;
}

void PUSH_PROCESS(int *n, PCB P[], PCB Q){
    P[*n] = Q;
    *n = *n + 1;
}

void REMOVE_PROCESS(int *n, int index, PCB P[]){
    for(int i=index; i<*n-1; i++){
        swap(&P[i], &P[i+1]);
    }
    *n = *n - 1;
}

void PRINT_TERMINATED(int P_Terminated, PCB Terminated_Arr[]){
    for(int i=0; i<P_Terminated; i++){
        printf("P%d: ", Terminated_Arr[i].iPID);
        printf("Start: %d, ", Terminated_Arr[i].iStart);
        printf("Finish: %d\n", Terminated_Arr[i].iFinish);
    }
}

void CALCULATE_VAL(int n, PCB P[]){
    double AVR_WAITING = 0;
    double AVR_EXE = 0;
    double AVR_RESPONSE = 0;
    for(int i=0; i<n; i++){
        AVR_RESPONSE += (P[i].iStart - P[i].iArrival)*1.0;
        AVR_WAITING += (P[i].iStart - P[i].iArrival)*1.0;
        AVR_EXE += (P[i].iFinish - P[i].iArrival)*1.0;
    }
    printf("AVR Response: %f\n", AVR_RESPONSE/n);
    printf("AVR Waiting: %f\n", AVR_WAITING/n);
    printf("AVR TaT: %f\n", AVR_EXE/n);
}

void DRAW_GANTT(int Num_Of_Fragment, PCB Gantt[]){
    if(Gantt[0].iStart != 0){
        printf("{0}=");
        printf("{%d}=== ", Gantt[0].iStart);
        printf("P%d ===", Gantt[0].iPID);
    }
    else{
        printf("{%d}=== ", Gantt[0].iStart);
        printf("P%d ===", Gantt[0].iPID);
    }
    for(int i=1; i<Num_Of_Fragment; i++){
        if(i != Num_Of_Fragment-1){
            if(Gantt[i].iStart == Gantt[i-1].iFinish){
                printf("{%d}=== ", Gantt[i].iStart);
                printf("P%d ===", Gantt[i].iPID);
            }
            else if (Gantt[i-1].iFinish < Gantt[i].iStart){
                printf("{%d}=", Gantt[i-1].iFinish);
                printf("{%d}=== ", Gantt[i].iStart);
                printf("P%d ===", Gantt[i].iPID);
            }
        }
        else if (i == Num_Of_Fragment-1){
            if(Gantt[i].iStart == Gantt[i-1].iFinish){
                printf("{%d}=== ", Gantt[i].iStart);
                printf("P%d ===", Gantt[i].iPID);
                printf("{%d}", Gantt[i].iFinish);
            }
            else if(Gantt[i-1].iFinish < Gantt[i].iStart){
                printf("{%d}=", Gantt[i-1].iFinish);
                printf("{%d}=== ", Gantt[i].iStart);
                printf("P%d ===", Gantt[i].iPID);
                printf("{%d}", Gantt[i].iFinish);
            }
        }
    }
    printf("\n");
}

void AUTO_INIT_PROCESS(PCB P[], int n){
    srand(time(0));
    for(int i = 0; i < n; i++){
        P[i].iPID = i+1;
        P[i].iArrival = rand() % 21;
        P[i].iBurst = rand() % 11 + 2;
    }
}

void SORT_ARRIVAL(int n, PCB P[]){
    for(int j = 0; j < n; j++){
        for(int i = 0; i < n-1; i++){
            if(P[i].iBurst == P[i+1].iBurst && P[i].iArrival > P[i+1].iArrival){
                swap(&P[i], &P[i+1]);
            }
            else{
                continue;
            }
        }
    }
    
}

int main(){
    PCB Input[10];
    PCB ReadyQueue[10];
    PCB Terminated_Arr[10];

    int Num_Of_Process, P_Ready = 0, P_Terminated = 0;
    printf("Nhap so luong Process: ");
    scanf("%d", &Num_Of_Process);

    int P_Remain = Num_Of_Process;
    int SELECT = 0;
    printf("Khởi tạo mảng Process tự động [0]\n");
    printf("Khởi tạo thủ công [1]\n");
    printf("Lựa chọn: \n");
    scanf("%d", &SELECT);    

    if(SELECT == 1){
        INIT_ARR(Num_Of_Process, Input);
    }
    else{
        AUTO_INIT_PROCESS(Input, Num_Of_Process);
    }

//
    printf("------------Input-----------\n");
    PRINT_ARR(Num_Of_Process, Input);
    quickSort_Arrival(Input, 0, Num_Of_Process-1);
//

    int Time_line = 0;
    PUSH_PROCESS(&P_Ready, ReadyQueue, Input[0]);
    REMOVE_PROCESS(&P_Remain, 0, Input);
    //Cap nhat Time_line luc nay se bang thoi gian Arrival cua Process dau tien nap vao
    Time_line = ReadyQueue[0].iArrival;
    //Khi nao cac chuong trinh chua duoc xu li xong thi thuat toan van chay
    while(P_Terminated < Num_Of_Process){
        //Neu Time_line lon hon Arrival cua cac Process trong Input thi nap no vao ReadyQueue
        while(Time_line >= Input[0].iArrival && P_Remain > 0){  
            PUSH_PROCESS(&P_Ready, ReadyQueue, Input[0]);
            REMOVE_PROCESS(&P_Remain, 0, Input);
            quickSort_Burst(ReadyQueue, 0, P_Ready - 1);
            SORT_ARRIVAL(P_Ready, ReadyQueue);    //Việc làm này để đảm bảo sau khi sort các Process có cùng Burst thì cái nào đến trước làm trước
        }
        //Kiem tra neu sau vong nay khong co Process nao trong ReadyQueue nhung Input con thi nap Process vao
        if(P_Ready == 0){
            while(Time_line <= Input[0].iArrival && P_Remain > 0){
                PUSH_PROCESS(&P_Ready, ReadyQueue, Input[0]);
                REMOVE_PROCESS(&P_Remain, 0, Input);
                Time_line = ReadyQueue[P_Remain - 1].iArrival;
                quickSort_Burst(ReadyQueue, 0, P_Ready - 1);
                SORT_ARRIVAL(P_Ready, ReadyQueue);     //Việc làm này để đảm bảo sau khi sort các Process có cùng Burst thì cái nào đến trước làm trước

            }
        }
        //Cap nhat iStart cho Process
        UPDATE_START(P_Terminated, Terminated_Arr, &ReadyQueue[0], &Time_line);
        //Sau vong nay chac chan phai co Process de xu li
        if(P_Ready > 0){
            //Cap nhat iFinish
            ReadyQueue[0].iFinish = ReadyQueue[0].iStart + ReadyQueue[0].iBurst;
            //Dua vao Terminated_Arr
            PUSH_PROCESS(&P_Terminated, Terminated_Arr, ReadyQueue[0]);
            //Remove khoi ReadyQueue
            REMOVE_PROCESS(&P_Ready, 0, ReadyQueue);
            //Cap nhat Time_line
            Time_line = Terminated_Arr[P_Terminated - 1].iFinish;
        }
    }

    printf("--------------TERMINATED-----------\n");
    PRINT_TERMINATED(P_Terminated, Terminated_Arr);
    printf("==============GANTT==============\n");
    DRAW_GANTT(P_Terminated, Terminated_Arr);
    printf("--------------AVR------------\n");
    CALCULATE_VAL(P_Terminated, Terminated_Arr);
    return 0;
}