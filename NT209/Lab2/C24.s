.section .data
noti:
	.string "Nhap chuoi: \n"
noti_len = . - noti	

.section .bss
	.lcomm text, 6 #str + null
	.lcomm rtext, 5
	
.section .text
	.globl _start
_start: 
	movl $4, %eax #sys_write
	movl $1, %ebx #std_out
	movl $noti, %ecx #address
	movl $noti_len, %edx #len
	int $0x80  #call kernel
	
	movl $3, %eax #sys_read
	movl $0, %ebx #std_in
	movl $text, %ecx #address
	movl $5, %edx  #len
	int $0x80 #call kernel
	
	
	movl $text, %eax 
	
	mov 0(%eax), %dl
	mov 1(%eax), %dh
	mov 2(%eax), %cl 
	mov 3(%eax), %ch 
	mov 4(%eax), %r8w
	
	movl $rtext, %ebx 
	mov %r8w, 0(%ebx) 
	mov %ch, 1(%ebx)
	mov %cl, 2(%ebx)
	mov %dh, 3(%ebx)
	mov %dl, 4(%ebx) 
	
	movl $4, %eax
	movl $1, %ebx
	movl $rtext, %ecx
	movl $5, %edx
	int $0x80

	
	movl $1, %eax
	int $0x80
	
