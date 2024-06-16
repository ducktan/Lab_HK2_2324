.section .data
thongbao: .string "Nhap chuoi khong qua 255 ky tu \n"

.section .bss
    .lcomm input, 255    # Tạo vùng nhớ có 255 ký tự để đọc vào

.section .text
    .globl _start
_start:
    # In thông báo nhập chuỗi
    movl $4, %eax       # Gọi hàm sys_write
    movl $1, %ebx       # In ra terminal
    movl $thongbao, %ecx   # Địa chỉ chuỗi thông báo
    movl $32, %edx      # Độ dài chuỗi cần in
    int $0x80           # Gọi hàm kernel

    # Người dùng nhập
    movl $3, %eax       # Gọi hàm sys_read
    movl $0, %ebx       # Nhập từ bàn phím
    mov $input, %ecx    # Địa chỉ chuỗi nhập
    movl $255, %edx      # Đọc 255 byte, bao gồm cả '\n'
    int $0x80           # Gọi hàm kernel

    # A = 65, Z = 90, a = 97, z = 122

    # Thực thi
    movl $0, %ecx       # int i = 0
    movl $input, %eax   # Địa chỉ của chuỗi nhập
    movb (%ecx,%eax), %bl   # ký tự đầu tiên của chuỗi
    cmp $0, %ecx        # nếu i = 0
    je .condition1      # nhảy đến ktra xem có in hoa không

.loop:
    incl %ecx           # tăng i
    cmp $255, %ecx      # kiểm tra i < 255
    jge .printResult    # nếu i >= 255, in kết quả
    movb (%ecx,%eax), %bl
    cmp $10, %bl        # ký tự là '\n'
    je .printResult     # nếu là '\n', in kết quả
    cmp $32, %bl        # ký tự là ' '
    je .condition       # nhảy đến ktra xem có in hoa không
    jmp .condition2

.condition:             # ky tu i+1 in hoa
    incl %ecx
    movb (%ecx,%eax), %bl
    jmp .condition1
    
.condition1:            # ktra có viết thường?
    cmp $97, %bl        # dk so sánh >= 'a'
    jl .loop
    cmp $122,%bl        # dk so sánh <='z'
    jle .upper
    jmp .loop           # Quay lại vòng lặp

.condition2:            # ktra có viết hoa?
    cmp $65, %bl        # dk so sánh >= 'A'
    jl .loop
    cmp $90, %bl        # dk so sánh <='Z'
    jle .lower
    jmp .loop           # Quay lại vòng lặp

.upper:
    sub $32,%bl         # Chuyển chữ hoa thành chữ thường
    movb %bl, (%ecx,%eax)   # Thay thế byte hiện tại trong chuỗi
    jmp .loop           # Quay lại vòng lặp

.lower:
    add $32,%bl         # Chuyển chữ thường thành chữ hoa
    movb %bl, (%ecx,%eax)   # Thay thế byte hiện tại trong chuỗi
    jmp .loop           # Quay lại vòng lặp

.printResult:
    # In kết quả
    movl $4, %eax       # Gọi hàm sys_write
    movl $1, %ebx       # In ra terminal
    movl $input, %ecx   # Địa chỉ của chuỗi nhập
    movl %ecx, %edx     # Độ dài của chuỗi
    int $0x80           # Gọi hàm kernel