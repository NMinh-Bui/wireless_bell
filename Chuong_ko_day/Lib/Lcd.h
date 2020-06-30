#ifndef _LCD_H_
#define _LCD_H_

void Lcd_Cmd(unsigned char cmd) ; 

void Lcd_Chr_Cp(char c) ;

void Lcd_Out_Cp(char *str) ; 

void Display(unsigned char SoBan);

#endif