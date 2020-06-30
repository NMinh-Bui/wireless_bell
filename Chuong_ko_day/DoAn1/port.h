#ifndef _PORT_H
#define _PORT_H

sbit LCD_RS = P0^0;
sbit LCD_EN = P0^2;
sbit LCD_RW = P0^1;
sbit BTN = P3^2 ;
sbit Buz = P0^7 ;
#define LCD_DATA P1

#endif