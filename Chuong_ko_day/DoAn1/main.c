#include"main.h"
#include"port.h"
#include"..\Lib\Delay.h"
#include"..\Lib\Lcd.h"

// Khai bao bien toan cuc 
unsigned char i = 0;
unsigned char num[12];

void main()
{
	// Khai bao bien chi su dung trong ham main 
	unsigned char cnt ;
	
	LCD_RW = 0 ;
	P0 = 0 ;
	P2_4 = 0 ;
	P2_5 = 0 ;
	P2_6 = 0 ;
	P2_7 = 0 ;


	// cau hinh ngat ngoai INT1 , INT0  
	IT1 = 1 ; // Cho phep ngat canh xuong INT1 
	EX1 = 1 ; // Cho phep ngat ngoai INT1 
	IT0 = 1 ; // Cho phep ngat canh xuong INT0
	EX0 = 1 ; // Cho phep ngat ngoai INT0
	PX0 = 1 ; // Gan muc uu tien cao cho ngat ngoai 0
	EA = 1 ; // Cho phep ngat toan cuc 


	// Khoi tao gia tri ban dau cho num[]
	for( cnt = 0 ; cnt < 12 ; cnt++ )
	{
		num[cnt] = 0 ; 
	}

	while(1)
	{
	Display(num[0]);
	Buz = 0 ;
	Delay_ms(1000); 
	Buz = 1 ;
	PCON |= 0x01 ; 
	} 
	return ; 

}

void ISR_EX1 (void) interrupt 0  // Chuong trinh phuc vu ngat EX0 
{
	unsigned char j = 0 ;
	while(num[j] != P2 )
	{
		if(i == j)
		{
			num[i] = P2 ; // co the optimize 
			i = i + 1 ;
			break ;
		}
		else
		{
			j = j + 1 ;
		}
	}	
	return ; 	
}

void ISR_EX0 (void) interrupt 2	 // Chuong trinh ngat phuc vu EX1 
{
	// Khoi tao bien
	unsigned char j , KiemTra = 0  ;
	Delay_ms(20);
	if(BTN == 0)
	{
		j = 0 ;
		while(num[j] != 0)
		{
			KiemTra = 1 ; 
			num[j] = num[j +1];
			j = j + 1 ;
			if(j == 11)
			{
				num[j] = 0 ;
				break ;  
			}
		}
		if(KiemTra == 1 )
		{
			i = i - 1 ; 
		}		
	}	
	return ; 
}