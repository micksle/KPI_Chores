title lab3

.model small

text segment
	assume CS:text, DS:data 

body:   mov AX, data
	mov DS, AX
	mov AH, 09h
	mov DX, offset mesg
	int 21h
	mov AH, 4Ch
	mov Al, 0
	int 21h
text ends

data segment
	message db "trying to solve the lab $"
data ends 

end body