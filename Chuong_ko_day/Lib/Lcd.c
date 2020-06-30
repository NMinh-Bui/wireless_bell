#include"main.h"
#include"port.h"
#include"..\Lib\Delay.h"

void Lcd_Cmd(unsigned char cmd)
{
	P2_2 = 1 ; 
	LCD_RS = 0;
	LCD_DATA = cmd;
	LCD_EN = 0;
	Delay_ms(10);
	LCD_EN = 1;

	if(cmd<=0x02)
	{
	 	Delay_ms(2);
	}
	else
	{
	 	Delay_ms(1);
	}
}

void Lcd_Chr_Cp(char c)		// Current Position
{
	P2_2 = 1 ;  
 	LCD_RS = 1;
	LCD_DATA = c;
	LCD_EN = 0;
	Delay_ms(10);
	LCD_EN = 1;
	Delay_ms(1);
}

void Lcd_Out_Cp(char *str)
{
 	unsigned char i = 0;
	while(str[i]!=0)
	{
	 	Lcd_Chr_Cp(str[i]);
		i++;
	}
}

void Display(unsigned char SoBan)
{
	// Bat hien thi tat con tro 
	Lcd_Cmd(0x0C);

	// Xoa toan bo noi dung tren LCD
	Lcd_Cmd(0x01);

	// Hien thi chuoi "Ban So X " 
	Lcd_Out_Cp("Ban So ");	   
	Lcd_Chr_Cp(SoBan / 10 + 48 )	;
	Lcd_Chr_Cp(SoBan % 10 + 48 )	;		
}

