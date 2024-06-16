.section .data
notify:
	.string "Nhap so nguyen x:"
noti_len = . -notify

.section .bss
	.lcomm res, 2 #res
	.lcomm num_str, 2 #2byte + null
	.lcomm test, 1
.section .text
	.globl _start
_start: 
	#notification
	movl $4, %eax #sys_write
	movl $1, %ebx #std_out
	movl $notify, %ecx #address
	movl $noti_len, %edx #len
	int $0x80 #call kernel
	
	#import 
	movl $3, %eax #sys_read
	movl $0, %ebx #std_in
	movl $num_str, %ecx #add
	movl $2, %edx #len
	int $0x80 #call kernel
	
	
	#convert string to int
	movl $num_str, %esi #move num_str --> esi
	
		
	mov (%esi), %ebx  
	sub $48, %ebx #-48: str --> num
	mov 1(%esi), %ecx 
	sub $48, %ecx #str --> num
	
	#process
	imull $10, %ebx #hang chuc * 10
	addl %ecx, %ebx #ebx = ebx + ecx (chuc + donvi)
	
	andl $0x1, %ebx  
	# ebx & 0x1 (Neu le: duoi = 1 --> AND = 1; neu chan: duoi = 0; AND = 0)
	
	xorl $0x1, %ebx
	#XOR: 0x1 (dao nguoc lai theo dung yeu cau de bai)
    	
    	
    	#convert to string
    	movl %ebx, res
    	movb $0, res + 1
    	addb $48, res
    	
    	#print
    	movl $4, %eax
    	movl $1, %ebx
    	movl $res, %ecx
    	movl $2, %edx 
    	int $0x80
	
	
	#close
	movl $1, %eax
	int $0x80
	
	

	

	
