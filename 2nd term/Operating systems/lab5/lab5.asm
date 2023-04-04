title lab5 Kalinin

.model small

data segment
	initial db "initial string:$"
	final   db "final string:$"
	string  db "minzdrav poperedzhaie palinnia shkidlyve dlia zdorovia mozhe vyklykaty zakhvoriuvannia na rak"
	part1   db 32 dup(?)			; ініціалізуємо необхідну кількість байт під частини речення, що
	part2   db 40 dup(?)			; буде посунуто
	newLine db 0dh,0ah, '$'
data ends

code segment
	assume CS:code, DS:data			; співставляємо необхідні частини коду
begin:
	mov AX, data				; заносимо адресу сегменту даних у регістр DS
	mov DS, AX
	mov ES, AX				; та в ES для переміщення рядкових адних


	mov AH, 09h				; виведення відступу зверху
	lea DX, newLine 
	int 21h					; функція переривання


	mov AH, 09h				; вивід супровідньої інформації щодо речення
	lea DX, initial
	int 21h
	
	mov AH, 09h
	lea DX, newLine 
	int 21h


	CLD 					; інструкція для обробки рядка зліва направо
	mov CX, 32				; довжина рядка, який буде скопійовано
	lea SI, string + 22 			; завантажуємо адресу рядка джерела
	lea DI, part1 				; в задану адресу рядка приймальника
	REP MOVSB				; переміщуємо (копіюємо) необхідну кількість разів

	mov CX, 40				
	lea SI, string + 55 			
	lea DI, part2 				
	REP MOVSB				


  	mov AH, 40h 				; другий вірант виведенян рядка на екран
  	mov BX, 01h 				; положення дескриптора для виведення повідомлення на екран
  	mov CX, 5dh 				; довжина рядка, що виводиться
  	lea DX, string 				; виводимо початкове речення, адресуючись на початок речення
  	int 21h

	mov AH, 09h
	lea DX, newLine 
	int 21h


	mov CX, 32				; копіюємо необхідні частини в кінцеве речення
	lea SI, part1
	lea DI, string+23 
	REP MOVSB 

	mov CX, 40
	lea SI, part2
	lea DI, string+57 
	REP MOVSB 		


	mov string, "M"				; розставляємо необхідні розділові знаки, змінюємо літери
 	mov string + 21, ":"
  	mov string + 22, '"'
	mov string + 23, "P"
	mov string + 55, ","
	mov string + 56, " "
	mov string + 95, '"'
	mov string + 96, "."


	mov AH, 09h
	lea DX, newLine 
	int 21h

	mov AH, 09h 				; вивід супровідньої інформації щодо речення
	lea DX, final
 	int 21h

	mov AH, 09h
	lea DX, newLine 
	int 21h


	mov AH, 40h 				; вивід зміненого речення
	mov BX, 01h 
	mov CX, 61h 
	lea DX, string
	int 21h

	mov AH, 09h
	lea DX, newLine 
	int 21h


	mov AH, 4ch 				; передаємо код успішного завершення роботи програми
	mov AL, 0
	int 21h 
code ends

end begin
