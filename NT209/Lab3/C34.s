.section .data
thongbao: .string "Nhap cccd \n"
ketqua1: .string "Chua den tuoi lao dong\n"
ketqua2: .string "Trong do tuoi lao dong\n"
ketqua3: .string "Het tuoi lao dong\n"

.section .bss
    .lcomm input, 13    # Tạo vùng nhớ có 13 ký tự để đọc vào (bao gồm cả ký tự kết thúc chuỗi)
    .lcomm res, 4

.section .text
    .globl _start
_start:
    # In thông báo nhập chuỗi
    movl $4, %eax       # Gọi hàm sys_write
    movl $1, %ebx       # In ra terminal
    movl $thongbao, %ecx   # Địa chỉ chuỗi thông báo
    movl $11, %edx      # Độ dài chuỗi cần in
    int $0x80           # Gọi hàm kernel

    # Người dùng nhập
    movl $3, %eax       # Gọi hàm sys_read
    movl $0, %ebx       # Nhập từ bàn phím
    mov $input, %ecx    # Địa chỉ chuỗi nhập
    movl $13, %edx      # Đọc 13 byte (bao gồm cả ký tự kết thúc chuỗi)
    int $0x80           # Gọi hàm kernel

    # Xử lí byte 5, 6
    # 0, 1: 1900 - 1999
    # 2, 3: 2000 - 2099
    movl $input, %eax   # Địa chỉ của chuỗi nhập
    movb 4(%eax), %cl   # ký tự thứ 5 của chuỗi
    movb 5(%eax), %bl   # ký tự thứ 6 của chuỗi

    sub $48,%cl         # Chuyển ký tự thứ 5 sang số
    sub $48,%bl         # Chuyển ký tự thứ 6 sang số

    movzbl %cl, %ecx    # Mở rộng giá trị 8-bit trong %cl thành 32-bit trong %ecx
    imul $10, %ecx      # Nhân giá trị với 10
    addl %ebx,%ecx      # Cộng ký tự 5 với ký tự 6

    # So sánh ký tự thứ 4 để xác định năm sinh
    cmpb $'1', 3(%eax)
    jle .nam1900
    jmp .nam2000
    

.nam1900:
    addl $1900, %ecx    # Năm 1900 - 1999
    jmp .calculate_age

.nam2000:
    addl $2000, %ecx    # Năm 2000 - 2099
    jmp .calculate_age

.calculate_age:
    # Tính tuổi
    movl $2024, %edx    # %edx = 2024 (năm hiện tại)
    subl %ecx, %edx     # %edx = năm hiện tại - năm sinh

    # In kết quả dựa trên tuổi
    cmpl $15, %edx      # So sánh với 15
    jl .printKetqua1   # Nếu lớn hơn hoặc bằng 15
    cmpl $60, %edx      # So sánh với 60
    jl .printKetqua2   # Nếu lớn hơn hoặc bằng 60
    jmp .printKetqua3   # Còn lại in kết quả 2

.printKetqua1:
    # In kết quả
   

    # In kết quả
    movl $4, %eax       # Gọi hàm sys_write
    movl $1, %ebx       # In ra terminal
    movl $ketqua1, %ecx # Địa chỉ của chuỗi kết quả
    movl $23, %edx      # Độ dài của chuỗi
    int $0x80           # Gọi hàm kernel
    jmp .exit

.printKetqua2:
    # In kết quả
    movl $4, %eax       # Gọi hàm sys_write
    movl $1, %ebx       # In ra terminal
    movl $ketqua2, %ecx # Địa chỉ của chuỗi kết quả
    movl $23, %edx      # Độ dài của chuỗi
    int $0x80           # Gọi hàm kernel
    jmp .exit

.printKetqua3:
    # In kết quả
    movl $4, %eax       # Gọi hàm sys_write
    movl $1, %ebx       # In ra terminal
    movl $ketqua3, %ecx # Địa chỉ của chuỗi kết quả
    movl $18, %edx      # Độ dài của chuỗi
    int $0x80           # Gọi hàm kernel
    jmp .exit

.exit:
    movl $1, %eax # system call number (sys_exit)
	int $0x80 # call kernel