.section .data
msg:
	.string "NT209UIT"
msg_len = . -msg

.section .bss
	.lcomm output, 2 #msg_len --> output
	
.section .text
	.globl _start
_start:
	movl $msg_len, output 
	addl $47, output #Number --> char (-1: NULL)
	 
	movl $4, %eax #sys_write
	movl $1, %ebx #std_out
	movl $output, %ecx #address of output
	movl $2, %edx #length
	int $0x80 #call kernel
	


	movl $1, %eax # system call number (sys_exit)
	int $0x80 # call kernel



