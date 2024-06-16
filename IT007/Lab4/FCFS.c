#include<stdio.h>
#include<stdlib.h>

#define SORT_BY_ARRIVAL 0
#define SORT_BY_PID 1
#define SORT_BY_BURST 2

typedef struct{
    int iPID;
    int iArrival, iBurst;
    int iStart, iFinish, iWaiting, iResponse, iTaT;
} PCB;

void inputProcess(int n, PCB P[]){
    for(int i=0; i<n; i++){
        printf("P%d (Arrival, Burst): \n", i+1);
        P[i].iPID = i+1;                    //Lấy tạm PID làm số hiệu Process
        printf("Arrival: ");
        scanf("%d", &P[i].iArrival);
        printf("Burst: ");
        scanf("%d", &P[i].iBurst);
    }
}

void printProcess(int n, PCB P[]){
    for(int i=0; i<n && n>0; i++){
        printf("P%d ", P[i].iPID);
        printf("(%d,", P[i].iArrival);
        printf(" %d)\n", P[i].iBurst);
    }
}

void pushProcess(int *n, PCB P[], PCB Q){
    P[*n] = Q;
    *n = *n + 1;
}

void removeProcess(int *n, int index, PCB P[]){
    if(n>0){
        for(int i=index; i<*n-1; i++){
            PCB Temp = P[i];
            P[i] = P[i+1];
            P[i+1] = Temp;
        }
        *n = *n - 1;
    }
}

int swapProcess(PCB *P, PCB *Q){
    PCB Temp = *P;
    *P = *Q;
    *Q = Temp;
}

int partition(PCB P[], int low, int high, int iCriteria);

void quickSort(PCB a[], int l, int r, int iCriteria){
    PCB p=a[(l+r)/2]; ///p: la phan tu privot 
    int i=l, j=r;
    if(iCriteria == 0){
        while(i<=j){
            while(a[i].iArrival<p.iArrival){
                i++;
            }
            while(a[j].iArrival>p.iArrival){
                j--;
            }
            if(i<=j){
                swapProcess(&a[i],&a[j]);
                i++;
                j--;
            }
        }
    }
    else if(iCriteria == 1){
        while(i<=j){
            while(a[i].iPID<p.iPID){
                i++;
            }
            while(a[j].iPID>p.iPID){
                j--;
            }
            if(i<=j){
                swapProcess(&a[i],&a[j]);
                i++;
                j--;
            }
        }
    }
    else if(iCriteria == 2){
        while(i<=j){
            while(a[i].iBurst<p.iBurst){
                i++;
            }
            while(a[j].iBurst>p.iBurst){
                j--;
            }
            if(i<=j){
                swapProcess(&a[i],&a[j]);
                i++;
                j--;
            }
        }
    }
    if(i<r){
        quickSort(a,i,r, iCriteria);
    }
    if(l<j){
        quickSort(a,l,j, iCriteria);
    }
}

void calculateAWT(int n, PCB P[]){
    if(n>0)
    {
        double sum=0;
        for(int i=0; i<n; i++){
            sum = sum + P[i].iWaiting*1.000;
        }
        printf("Average WT: %f\n", sum/n);
    }
}
//======================================
void calculateATaT(int n, PCB P[]){
    if(n>0){
        double sum=0;
        for(int i=0; i<n; i++){
            sum = sum + P[i].iTaT*1.000;
        }
        printf("Average TaT: %f\n", sum/n);
    }
}

//======================================
void exportGanttChart(int n, PCB P[]){
    if(P[0].iStart != 0){
        printf("{0}=");
        printf("{%d}=== ", P[0].iStart);
        printf("P%d ===", P[0].iPID);
    }
    else{
        printf("{%d}=== ", P[0].iStart);
        printf("P%d ===", P[0].iPID);
    }
    for(int i=1; i<n; i++){
        if(i != n-1){
            if(P[i].iStart == P[i-1].iFinish){
                printf("{%d}=== ", P[i].iStart);
                printf("P%d ===", P[i].iPID);
            }
            else if (P[i-1].iFinish < P[i].iStart){
                printf("{%d}=", P[i-1].iFinish);
                printf("{%d}=== ", P[i].iStart);
                printf("P%d ===", P[i].iPID);
            }
        }
        else if (i == n-1){
            if(P[i].iStart == P[i-1].iFinish){
                printf("{%d}=== ", P[i].iStart);
                printf("P%d ===", P[i].iPID);
                printf("{%d}", P[i].iFinish);
            }
            else if(P[i-1].iFinish < P[i].iStart){
                printf("{%d}=", P[i-1].iFinish);
                printf("{%d}=== ", P[i].iStart);
                printf("P%d ===", P[i].iPID);
                printf("{%d}", P[i].iFinish);
            }
        }
    }
    printf("\n");
}
//======================================
int main(){
    PCB Input[10];              //Khởi tạo mảng input có kích thước là 10
    PCB ReadyQueue[10];
    PCB TerminatedArray[10];

    int iNumberOfProcess, iRemain, iReady = 0, iTerminated = 0;
    printf("Please input number of Process: ");
    scanf("%d", &iNumberOfProcess);
    
    iRemain = iNumberOfProcess; 

    inputProcess(iNumberOfProcess,Input);
    quickSort(Input, 0, iNumberOfProcess-1,SORT_BY_ARRIVAL);
    pushProcess(&iReady, ReadyQueue, Input[0]);
    removeProcess(&iRemain, 0, Input);

    ReadyQueue[0].iStart = ReadyQueue[0].iArrival;
    ReadyQueue[0].iFinish = ReadyQueue[0].iStart + ReadyQueue[0].iBurst;     //Thoi gian hoan thanh du doan = Start + Burst
    ReadyQueue[0].iResponse = ReadyQueue[0].iStart - ReadyQueue[0].iArrival;
    ReadyQueue[0].iWaiting = ReadyQueue[0].iResponse;
    ReadyQueue[0].iTaT = ReadyQueue[0].iFinish - ReadyQueue[0].iArrival;     //Thoi gian thuc thi xong process = 

    printf("\nReady Queue: \n");
    printProcess(1, ReadyQueue);  

    while(iTerminated < iNumberOfProcess){              //Nếu số lượng Process Terminated < Số lượng Process tạo ra thì lặp
        while(iRemain > 0){                             //Nếu số lượng Process còn lại trong Input > 0 thì lặp
            if(Input[0].iArrival<=ReadyQueue[0].iFinish){       //Nếu Input[0].iArrival <= ReadyQueue[0].iFinish thì xử lí
                pushProcess(&iReady, ReadyQueue, Input[0]);     //
                removeProcess(&iRemain, 0, Input);
                continue;
            }
            else break;
        }
        if(iReady>0){
            pushProcess(&iTerminated,TerminatedArray,ReadyQueue[0]);
            removeProcess(&iReady, 0, ReadyQueue);
            ReadyQueue[0].iStart = TerminatedArray[iTerminated - 1].iFinish;
            ReadyQueue[0].iFinish = ReadyQueue[0].iStart + ReadyQueue[0].iBurst;
            ReadyQueue[0].iResponse = ReadyQueue[0].iStart - ReadyQueue[0].iArrival;
            ReadyQueue[0].iWaiting = ReadyQueue[0].iResponse;
            ReadyQueue[0].iTaT = ReadyQueue[0].iFinish - ReadyQueue[0].iArrival;
        }
    }
    printf("\n===== FCFS Scheduling =====\n");
    exportGanttChart(iTerminated,TerminatedArray);
    quickSort(TerminatedArray, 0, iTerminated - 1, SORT_BY_PID);
    calculateAWT(iTerminated, TerminatedArray);
    calculateATaT(iTerminated, TerminatedArray);
}
