#include<stdio.h>

int main() {

int a; 
int b;
float carpim;

printf("bir sayi giriniz:\n");
scanf("%d",&a); 
printf("bir sayi giriniz:\n");
scanf("%d",&b);

carpim=a*b;

printf("iki sayinin carpimi %2.f",carpim);

return 0;

}
