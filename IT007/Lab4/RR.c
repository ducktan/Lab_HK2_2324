#include<stdlib.h>
#include<stdio.h>
#include<time.h>
typedef struct {
    int iPID;
    int iArrival;
    int iBurst;
    int iBurst_Remain;
    int iStart;
    int iFinish;
    int iWaiting;
    int iResponse;
    int iTaT;
}PCB;

void swap_Process(PCB *A, PCB *B){
    PCB temp = *A;
    *A = *B;
    *B = temp;
    return;
}

void init_Process_Arr(PCB P[], int n){
    for(int i=0; i<n; i++){
        printf("Process %d: \n", i+1);
        P[i].iPID = i+1;
        printf("Arrival: ");
        scanf("%d", &P[i].iArrival);
        printf("Burst: ");
        scanf("%d", &P[i].iBurst);
        P[i].iBurst_Remain = P[i].iBurst;
    }
    return;
}

void display_Arr(PCB P[], int n){
    for(int i=0; i<n; i++){
        printf("P%d ", P[i].iPID);
        printf("(%d, ", P[i].iArrival);
        printf("%d)\n", P[i].iBurst);
    }
    return;
}

void display_Queue(PCB P[], int n){
    for(int i=0; i<n; i++){
        printf("P%d ", P[i].iPID);
        printf("(%d, ", P[i].iArrival);
        printf("%d)\n", P[i].iBurst_Remain);
    }
    return;    
}

void push_Process(int *n, PCB P[], PCB Q){                  //Nạp 1 process vào hàng đợi, Nạp ở index = 0
    P[*n]=Q;
    *n = *n + 1;
    return;
}

void remove_Process(int *n, int index, PCB P[]){            //Xóa 1 process bất kì ở ô địa chỉ index và sắp xếp lại mảng
    for(int i=index; i<*n-1; i++){
        swap_Process(&P[i],&P[i+1]);
    }
    *n = *n - 1;
    return;
}

void shellSort(PCB arr[], int n) {                              //Sort theo iArrival
    for (int gap = n/2; gap > 0; gap /= 2) {
        for (int i = gap; i < n; i += 1) {
            PCB temp = arr[i];
            int j;
            for (j = i; j >= gap && arr[j - gap].iArrival > temp.iArrival; j -= gap)arr[j] = arr[j - gap];
            arr[j] = temp;
        }
    }
    return;
}

void DISPLAY_TERMINATED_ARR(int P_Terminated, PCB P[]){
    for(int i=0; i<P_Terminated; i++){
        printf("P%d: ", P[i].iPID);
        printf("Start: %d, ", P[i].iStart);
        printf("End: %d, ", P[i].iFinish);
        printf("Respone: %d, ", P[i].iResponse);
        printf("Waiting: %d, ", P[i].iWaiting);
        printf("Execution: %d\n", P[i].iTaT);
    }
    return;
}

void DISPLAY_GANTT_CHART(int Num_Of_Fragment, PCB P[]){
    for(int i=0; i<Num_Of_Fragment; i++){
        printf("P%d: ", P[i].iPID);
        printf("Start: %d, ", P[i].iStart);
        printf("End: %d, ", P[i].iFinish);
        printf("Remain: %d\n", P[i].iBurst_Remain);
    }
    return;
}

void MOVE_TO_END_OF_THE_LINE(int P_Ready, PCB ReadyQueue[]){
    PCB Temp = ReadyQueue[0];
    for(int i=0; i<P_Ready-1; i++){
        swap_Process(&ReadyQueue[i],&ReadyQueue[i+1]);
    }
    ReadyQueue[P_Ready-1]=Temp;
    return;
}
//CHU Y sua ham nay
void UPDATE_DATA_BEFORE_MOVE_TO_GANTT_CHART(PCB *P, int QT, int Num_Of_Fragment, PCB Gantt_Chart_Arr[]){
    //Nếu Gantt_Chart_Arr chưa có phần tử nào
    if(Num_Of_Fragment == 0){
        P->iStart = P->iArrival;
        if(P->iBurst_Remain > QT){
            P->iFinish = P->iStart + QT;
            P->iBurst_Remain = P->iBurst_Remain - QT;
        }
        else if(P->iBurst_Remain == QT){
            P->iFinish = P->iStart + QT;
            P->iBurst_Remain = 0;
        }
        else if(P->iBurst_Remain < QT){
            P->iFinish = P->iStart + P->iBurst_Remain;
            P->iBurst_Remain = 0;
        }
    }
    //Nếu Gantt_Chart_Arr đã có phần tử
    else if(Num_Of_Fragment>0){
        //START
        if(P->iArrival <= Gantt_Chart_Arr[Num_Of_Fragment-1].iFinish){          //Trường hợp Process đến trước khi hoàn thành xong
            P->iStart = Gantt_Chart_Arr[Num_Of_Fragment-1].iFinish;
        //BURST_REMAIN, FINISH
            if(P->iBurst_Remain > QT){
                P->iFinish = P->iStart + QT;
                P->iBurst_Remain = P->iBurst_Remain - QT;
            }
            else if(P->iBurst_Remain == QT){
                P->iFinish = P->iStart + QT;
                P->iBurst_Remain = 0;
            }
            else if(P->iBurst_Remain < QT){
                P->iFinish = P->iStart + P->iBurst_Remain;
                P->iBurst_Remain = 0;
            }
        }
        else{                                                   //Trường hợp đến sau khi hoàn thành xong
        //START
            P->iStart = P->iArrival;
        //BURST_REMAIN, FINISH
            if(P->iBurst_Remain > QT){
                P->iFinish = P->iStart + QT;
                P->iBurst_Remain = P->iBurst_Remain - QT;
            }
            else if(P->iBurst_Remain == QT){
                P->iFinish = P->iStart + QT;
                P->iBurst_Remain = 0;
            }
            else if(P->iBurst_Remain < QT){
                P->iFinish = P->iStart + P->iBurst_Remain;
                P->iBurst_Remain = 0;
            }
        }
    }

    return;
}

void calculate_form_Gantt_Chart(int Num_of_Process, int Num_of_Fragment, PCB Gantt[], PCB TerminatedArr[]){
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
                push_Process(&Frag_of_Process, Calculate_Arr, Gantt[j]);
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
    PCB TerminatedArray[10];
    PCB Gantt_Chart[100];

    int QUANTUM_TIME;
    int Num_of_Process, P_Remain;
    int P_Ready=0, P_Termiated=0, Num_Of_Fragment=0;
    do{
        printf("Nhap so luong process (n<=10): ");
        scanf("%d", &Num_of_Process);
    }while(Num_of_Process<=0 || Num_of_Process>10);
    
    P_Remain = Num_of_Process;
    //====================================
    int SELECT = 0;
    printf("Khởi tạo mảng Process tự động [0]\n");
    printf("Khởi tạo thủ công [1]\n");
    printf("Lựa chọn: \n");
    scanf("%d", &SELECT);
    if(SELECT == 1){
        //Khoi tao thu cong
        init_Process_Arr(Input, Num_of_Process);
    }
    else{
        //Khoi tao tu dong
        AUTO_INIT_PROCESS(Input, Num_of_Process);
    }
    //=====================================
    //Nhap gia tri Quantum Time
    do{
        printf("Nhap Quantum Time: ");
        scanf("%d", &QUANTUM_TIME);
    }while(QUANTUM_TIME<=0);
    //Sort gia tri trong Input
    shellSort(Input, Num_of_Process);                   //Sort lai mang
    //Xuat mang Input ra
    printf("-------------Input-----------\n");
    display_Arr(Input, Num_of_Process);
    //---------------------------------------
    do{   
        if(P_Ready==0 && P_Remain>0){
            push_Process(&P_Ready, ReadyQueue, Input[0]);
            remove_Process(&P_Remain, 0, Input);
        }
        //----------------------------------------------
        if(P_Ready>0){
            UPDATE_DATA_BEFORE_MOVE_TO_GANTT_CHART(&ReadyQueue[0], QUANTUM_TIME, Num_Of_Fragment, Gantt_Chart);
            //Kiem tra xem Gantt_Chart[Num_Of_Fragment-1] co trung PID voi Process duoc them vao khong
            if(Gantt_Chart[Num_Of_Fragment-1].iPID != ReadyQueue[0].iPID){
                push_Process(&Num_Of_Fragment, Gantt_Chart, ReadyQueue[0]);
            }
            else if(Gantt_Chart[Num_Of_Fragment-1].iPID == ReadyQueue[0].iPID){
                Gantt_Chart[Num_Of_Fragment-1].iFinish = ReadyQueue[0].iFinish;
                Gantt_Chart[Num_Of_Fragment-1].iBurst_Remain = ReadyQueue[0].iBurst_Remain;
            }
            //Neu ReadyQueue[0].Finish som hon thoi gian den cua cac Process chuan bi nap vao thi dua cac Process do vao truoc
            while(ReadyQueue[0].iFinish >= Input[0].iArrival && P_Remain>0){
                push_Process(&P_Ready, ReadyQueue, Input[0]);
                remove_Process(&P_Remain, 0, Input);
            }

            if(ReadyQueue[0].iBurst_Remain > 0){
                MOVE_TO_END_OF_THE_LINE(P_Ready, ReadyQueue);
            }
            else{
                push_Process(&P_Termiated, TerminatedArray, ReadyQueue[0]);
                remove_Process(&P_Ready, 0, ReadyQueue);
            }
        }
    }while(P_Termiated < Num_of_Process);
    calculate_form_Gantt_Chart(Num_of_Process, Num_Of_Fragment, Gantt_Chart, TerminatedArray);
    printf("------TerminatedArr---------\n");
    DISPLAY_TERMINATED_ARR(P_Termiated, TerminatedArray);
    printf("------GANTT CHART-----------\n");
    DISPLAY_GANTT_CHART(Num_Of_Fragment, Gantt_Chart);
    printf("-------------DRAW------------\n");
    DRAW_GANTT(Num_Of_Fragment, Gantt_Chart);
    printf("-----------AVR--------------\n");
    calculate_AVR_Val(P_Termiated, TerminatedArray);
}