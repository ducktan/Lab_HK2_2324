#include<stdio.h>
#include<stdlib.h>
#include<time.h>
typedef struct{
    int iPID, iArrival, iBurst, iBurst_Remain;
    int iStart, iFinish, iWaiting, iResponse, iTaT;
}PCB;

void swap(PCB *A, PCB *B){
    PCB Temp = *A;
    *A = *B;
    *B = Temp;
}

void init_arr(int n, PCB P[]){
    for(int i=0; i<n; i++){
        printf("Process %d: \n", i+1);
        P[i].iPID = i + 1;
        printf("Arrival: ");
        scanf("%d", &P[i].iArrival);
        printf("Burst: ");
        scanf("%d", &P[i].iBurst);
        //==============================
        P[i].iBurst_Remain = P[i].iBurst;
        P[i].iStart = 0;
        P[i].iFinish = 0;
        P[i].iWaiting = 0;
        P[i].iResponse = 0;
        P[i].iTaT = 0;
    }
}

void PRINT_ARR(int n, PCB P[]){
    for(int i=0; i<n && n>0; i++){
        printf("P%d ", P[i].iPID);
        printf("(%d, ", P[i].iArrival);
        printf("%d)\n", P[i].iBurst);
    }
}

void PRINT_TERMINATED(int n, PCB P[]){
    for(int i=0; i<n && n>0; i++){
        printf("P%d: ", P[i].iPID);
        printf("Arrival: %d, ", P[i].iArrival);
        printf("Burst: %d, ", P[i].iBurst);
        printf("Start: %d, ", P[i].iStart);
        printf("Finish: %d, ", P[i].iFinish);
        printf("Response: %d, ", P[i].iResponse);
        printf("Waiting: %d, ", P[i].iWaiting);
        printf("TaT: %d\n", P[i].iTaT);
    }
}

void PRINT_QUEUE(int n, PCB P[]){
    for(int i=0; i<n && n>0; i++){
        printf("P%d: ", P[i].iPID);
        printf("Burst Remain: %d\n", P[i].iBurst_Remain);
    }
}

void PRINT_GANTT_CHART(int n, PCB P[]){
    for(int i=0; i<n && n>0; i++){
        printf("P%d: ", P[i].iPID);
        printf("Start: %d, ", P[i].iStart);
        printf("Finish: %d, ", P[i].iFinish);
        printf("Burst Remain: %d\n", P[i].iBurst_Remain);
    }
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

void quickSort_Arrival(PCB a[], int l, int r){
    PCB p=a[(l+r)/2]; ///p: la phan tu privot 
    int i=l, j=r;
    while(i<=j){
        while(a[i].iArrival<p.iArrival){
            i++;
        }
        while(a[j].iArrival>p.iArrival){
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

void quickSort_BurstRemain(PCB a[], int l, int r){
    PCB p=a[(l+r)/2]; ///p: la phan tu privot 
    int i=l, j=r;
    while(i<=j){
        while(a[i].iBurst_Remain<p.iBurst_Remain){
            i++;
        }
        while(a[j].iBurst_Remain>p.iBurst_Remain){
            j--;
        }
        if(i<=j){
            swap(&a[i],&a[j]);
            i++;
            j--;
        }
    }
    if(i<r){
        quickSort_BurstRemain(a,i,r);
    }
    if(l<j){
        quickSort_BurstRemain(a,l,j);
    }
}

void UPDATE_START(int Num_Of_Fragment, PCB Gantt[], PCB *P, int *Time_line){
    if(Num_Of_Fragment == 0){
        P->iStart = P->iArrival;
    }
    else{
        if(P->iArrival <= Gantt[Num_Of_Fragment-1].iFinish){
            P->iStart = Gantt[Num_Of_Fragment-1].iFinish;
        }
        else if(P->iArrival > Gantt[Num_Of_Fragment-1].iFinish){
            P->iStart = P->iArrival;
        }
    }
    *Time_line = P->iStart;
}

void calculate_form_Gantt_Chart(int Num_of_Fragment, PCB Gantt[], int Num_of_Process, PCB TerminatedArr[]){
    PCB Calculate_Arr[100];
    for(int i=0; i<Num_of_Process; i++){
        int Start = 0;
        int Frag_of_Process=0;
        int Response=0;
        int Waiting=0;
        int Exe=0;
        //Nhet cac manh cua 1 Process vao 1 arr
        for(int j=0; j<Num_of_Fragment; j++){
            if(Gantt[j].iPID == i+1){
                PUSH_PROCESS(&Frag_of_Process, Calculate_Arr, Gantt[j]);
            }
        }
        //Tinh toan
        for(int j=0; j<Frag_of_Process; j++){
            if(j==0){
                Start = Calculate_Arr[0].iStart;
                Response = Calculate_Arr[0].iStart - Calculate_Arr[0].iArrival;
                Waiting = Calculate_Arr[j].iStart - Calculate_Arr[j].iArrival;      //Thoi gian doi lan dau
                Exe = Calculate_Arr[Frag_of_Process-1].iFinish - Calculate_Arr[0].iArrival; 
            }
            else{
                Waiting += Calculate_Arr[j].iStart - Calculate_Arr[j-1].iFinish;
            }
        }
        //--------GAN GIA TRI VAO TERMINATED_ARR
        for(int j=0; j<Num_of_Process; j++){
            if(TerminatedArr[j].iPID == i+1){
                TerminatedArr[j].iStart = Start;
                TerminatedArr[j].iResponse = Response;
                TerminatedArr[j].iWaiting = Waiting;
                TerminatedArr[j].iTaT = Exe;
            }
        }
    }
    return;
}

void SORT_ARRIVAL(int n, PCB P[]){
    for(int i=0; i<n; i++){
        for(int j=0; j<n-1; j++)
        if(P[j].iBurst_Remain == P[j+1].iBurst_Remain && P[j].iArrival > P[j+1].iArrival){
            swap(&P[j], &P[j+1]);
        }
        else continue;
    }
}

void calculate_AVR_Val(int P_Terminated, PCB P[]){
    double AVR_RESPONSE=0;
    double AVR_WAITING=0;
    double AVR_EXECUTION=0;
    for(int i=0; i<P_Terminated; i++){
        AVR_RESPONSE += P[i].iResponse*1.00;
        AVR_WAITING +=P[i].iWaiting*1.00;
        AVR_EXECUTION +=P[i].iTaT*1.00;
    }
    printf("AVR_Response: %f\n", AVR_RESPONSE/P_Terminated);
    printf("AVR_Waiting: %f\n", AVR_WAITING/P_Terminated);
    printf("AVR_TaT: %f\n", AVR_EXECUTION/P_Terminated);
    return;
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
        P[i].iBurst_Remain = P[i].iBurst;
    }
}

int main(){
    PCB Input[10];
    PCB ReadyQueue[10];
    PCB Terminated_Arr[10];
    PCB Gantt[50];

    int Num_Of_Process, Num_Of_Fragment = 0, P_Ready = 0, P_Terminated = 0;
    printf("Nhap so luong Process: ");
    scanf("%d", &Num_Of_Process);

    int P_Remain = Num_Of_Process;

    int SELECT = 0;
    printf("Khởi tạo mảng Process tự động [0]\n");
    printf("Khởi tạo thủ công [1]\n");
    printf("Lựa chọn: \n");
    scanf("%d", &SELECT);
    
    if(SELECT == 1){
        init_arr(Num_Of_Process, Input);
    }
    else{
        AUTO_INIT_PROCESS(Input, Num_Of_Process);
    }

    printf("-------Input---------\n");
    PRINT_ARR(P_Remain, Input);
    quickSort_Arrival(Input, 0, P_Remain-1);
    int Time_line = 0;
    //----------------------------------------
    PUSH_PROCESS(&P_Ready, ReadyQueue, Input[0]);
    REMOVE_PROCESS(&P_Remain, 0, Input);
    Time_line = ReadyQueue[0].iArrival;
    //----------------------------------------
    while(P_Terminated < Num_Of_Process){   
        //Co Interrupt_Flag xay ra khi trong qua trinh thuc thi co Process khac chen ngang
        int Interrupt_Flag = 0;
        //Them may cai Process co cung Arrival time vao ReadyQueue
        while(Time_line >= Input[0].iArrival && P_Remain >0){
            PUSH_PROCESS(&P_Ready, ReadyQueue, Input[0]);
            REMOVE_PROCESS(&P_Remain, 0, Input);
            quickSort_BurstRemain(ReadyQueue, 0, P_Ready-1);
            //Sort lai theo arrival de dam bao 2 Process co cung Burst_Remain thi Process den truoc duoc uu tien
            SORT_ARRIVAL(P_Ready, ReadyQueue);
        }
        //Neu Time_line do van chua co Process nao den va ReadyQueue dang trong thi nap Process vao
        if(Time_line < Input[0].iArrival && P_Ready == 0 && P_Remain > 0){
            PUSH_PROCESS(&P_Ready, ReadyQueue, Input[0]);
            REMOVE_PROCESS(&P_Remain, 0, Input);
        }
        //Cap nhat iStart cho ReadyQueue[0]
        UPDATE_START(Num_Of_Fragment, Gantt, &ReadyQueue[0], &Time_line);
        //Xu li ReadyQueue[0], KIEM TRA trong Input xem co Process nao den khi ReadyQueue[0] dang lam viec khong               
        for(int i=0; i<P_Remain && P_Remain>0; i++){     //Ham kiem tra nay co van de o dau do
            //Co Process den trong khi ReadyQueue[0] chua hoan thanh xong    
            if(Input[i].iArrival <= (ReadyQueue[0].iStart + ReadyQueue[0].iBurst_Remain)){
                //Kiem tra xem iBurst_Remain cua no co be hon iBurst_Remain cua ReadyQueue[0] tai thoi diem no den khong
                if(Input[i].iBurst_Remain < (ReadyQueue[0].iBurst_Remain - Input[i].iArrival + ReadyQueue[0].iStart)){
                    //Interrupt xay ra
                    Interrupt_Flag = 1;
                    //Cap nhat Burst_Remain
                    ReadyQueue[0].iBurst_Remain = ReadyQueue[0].iBurst_Remain - Input[i].iArrival + ReadyQueue[0].iStart;
                    //Cap nhat Finish
                    ReadyQueue[0].iFinish = Input[i].iArrival;
                    //Cap nhat Time_line
                    Time_line = ReadyQueue[0].iFinish;
                    
                    //KIEM TRA TRUOC KHI DUA VAO GANTT
                    if(Gantt[Num_Of_Fragment-1].iPID != ReadyQueue[0].iPID){
                        //Di chuyen Fragment nay vao Gantt
                        PUSH_PROCESS(&Num_Of_Fragment, Gantt, ReadyQueue[0]);
                    }   //Mat khac chi cap nhat gia tri Finish cho Gantt nay
                    else if(Gantt[Num_Of_Fragment-1].iPID == ReadyQueue[0].iPID){      
                        Gantt[Num_Of_Fragment-1].iFinish = ReadyQueue[0].iFinish;
                    }

                    //Push Process gay Interrupt nay vao ReadyQueue
                    PUSH_PROCESS(&P_Ready, ReadyQueue, Input[i]);
                    //Xoa Process nay khoi Input
                    REMOVE_PROCESS(&P_Remain, i, Input);
                    //Sort lai ReadyQueue
                    quickSort_BurstRemain(ReadyQueue, 0, P_Ready-1);
                    //Sort lai uu tien Process den truoc neu cung Burst_Remain
                    SORT_ARRIVAL(P_Ready, ReadyQueue);
                    //Cap nhat iSTART cho ReadyQueue[0], cap nhat luon Time_line
                    UPDATE_START(Num_Of_Fragment, Gantt, &ReadyQueue[0], &Time_line);
                }
            }
        }
        //Neu co Interrupt_Flag khong bat len tuc la tien doan truoc khong co Process nao chen ngang trong qua trinh lam viec thi moi thuc hien xu li buoc nay
        if(Interrupt_Flag == 0){
            //Xu li hoan toan ReayQueue[0]    
            ReadyQueue[0].iFinish = ReadyQueue[0].iStart + ReadyQueue[0].iBurst_Remain;
            ReadyQueue[0].iBurst_Remain = 0;
            //Nhet ReadyQueue[0] vao Gantt
            PUSH_PROCESS(&Num_Of_Fragment, Gantt, ReadyQueue[0]);
            //Nhet ReadyQueue[0] vao Terminated_Arr
            PUSH_PROCESS(&P_Terminated, Terminated_Arr, ReadyQueue[0]);
            //Xoa ReadyQueue[0] khoi ReadyQueue
            REMOVE_PROCESS(&P_Ready, 0, ReadyQueue);
            //Sort lai ReadyQueue
            quickSort_BurstRemain(ReadyQueue, 0, P_Ready-1);
            //Sort lai theo iArrival
            SORT_ARRIVAL(P_Ready, ReadyQueue);
            //Cap nhat ReadyQueue[0] moi cung nhu Time_line
            UPDATE_START(Num_Of_Fragment, Gantt, &ReadyQueue[0], &Time_line);
        }
    }
    calculate_form_Gantt_Chart(Num_Of_Fragment, Gantt, Num_Of_Fragment, Terminated_Arr);
    printf("--------------TERMIATED ARR----------\n");
    PRINT_TERMINATED(P_Terminated, Terminated_Arr);
    printf("--------------GANTT CHART------\n");
    PRINT_GANTT_CHART(Num_Of_Fragment, Gantt);
    //Draw Gantt
    DRAW_GANTT(Num_Of_Fragment, Gantt);
    printf("-----------AVR VAL--------------\n");
    calculate_AVR_Val(P_Terminated, Terminated_Arr);
}