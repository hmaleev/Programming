#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>

int main(void)
{
	
	FILE *fileRead,*fileWrite;
	char inputFile[512],outputFile[512];
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int symbol=32;
	
	printf("Choose input file:\n\n");
	scanf("%s",inputFile);

	printf("\nChoose output file:\n\n");
	scanf("%s",outputFile);

	if ((fileRead=fopen(inputFile,"r"))==NULL)
	{
		printf("This file doesn't exist! ");
		exit(1);
	}
	if ((fileWrite=fopen(outputFile,"w"))==NULL)
	{
		printf("This file can't be created! ");
		exit(1);
	}
	for(;;)
	{
	//	putchar(symbol);
		symbol=fgetc(fileRead);
		if(symbol==EOF) break;
		
		if (symbol>=176 & symbol<=191)
		{
			symbol+=48;

		}
		
		fputc(symbol,fileWrite);
	}
	fclose(fileRead);
	printf("Done!\n");
	return 0;
}