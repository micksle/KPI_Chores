title lab4

.model	tiny

.code
	org 100h

body:   mov AH, 9
	mov DX, offset message
	int 21h
ret
	message db "Hello World!", 0Dh, 0Ah, '$'

end body
