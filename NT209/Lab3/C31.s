.section .data
msg: 
    .string "Enter a number: "
output1: 
    .string "Khong giam dan"
output2: 
    .string "Giam dan"
.section .bss
    .lcomm input,10
.section .text
    .globl _start
_start:
    #In thông báo nhập số "Enter a number: "
    movl $4, %eax
    movl $1, %ebx
    movl $msg, %ecx
    movl $17, %edx
    int $0x80
    #Nhập số "input"
    movl $3, %eax
    movl $0, %ebx
    movl $input, %ecx
    movl $5, %edx
    int $0x80

    #Xử lí yêu cầu
    movl $0, %ecx #chỉ số i
    movl $input, %eax

    jmp .Test
.Loop:
    movb (%eax, %ecx), %bl #input[i]
    movl $0, %edx
    movl %ecx, %edx
    addl $1, %edx  #i+1
    movb (%eax, %edx), %bh #input[i+1]

    #if (input[i+1] >= input[i]) return False
    cmpb %bl, %bh
    jge .False
    #if i=5 goto test
    cmpl $5, %ecx
    je .Test
    incl %ecx

    #Điều kiện duy trì vòng lặp (i<4)
.Test:
    cmpl $4, %ecx
    jl .Loop

    #Trường hợp giảm dần
.True:
    movl $4, %eax
    movl $1, %ebx
    movl $output2, %ecx
    movl $9, %edx
    int $0x80
    jmp .Exit
    int $0x80

    #Trường hợp không giảm dần
.False:
    movl $4, %eax
    movl $1, %ebx
    movl $output1, %ecx
    movl $15, %edx
    int $0x80
    jmp .Exit
    int $0x80
    #Thoát chương trình
.Exit:
    movl $1, %eax
    int $0x80

