//A. Номера домов (пример: 4,2 = 2. 8,5 = 3)
/*
Васе необходимо как можно скорее добраться до дома номер a. 
Он заезжает с начала улицы и двигается на автомобиле по ней до дома номер a. 
Чтобы доехать от начала улицы до домов с номерами 1 и n, он тратит ровно 1 секунду. 
На то, чтобы проехать расстояние между двумя соседними домами, он также тратит ровно одну секунду. 
Вася может припарковаться с любой стороны дороги, поэтому расстояние от начала улицы до домов, 
стоящих друг напротив друга, следует считать одинаковым.
Перед вами стоит задача: найти минимальное время, по истечении которого Вася сможет добраться до дома с номером a.

Входные данные
В первой строке входных данных содержатся два целых числа n и a (1 ≤ a ≤ n ≤ 100 000) — количество домов 
на улице и номер дома, до которого нужно доехать Васе, соответственно. Гарантируется, что число n чётно.

Выходные данные
Выведите единственное целое число — минимальное время, за которое Вася сможет добраться от начала улицы 
до дома с номером a.
*/

int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int n = num[0];
int a = num[1];

int[] streetLeft = new int[n/2];
int[] streetRight = new int[n/2];
int house = 1;

for(int i = 0; i < n / 2; i++)
{	
	streetLeft[i] = house;
	streetRight[i] = n - house + 1;
	house = house + 2;
}

for(int i = 0; i<n/2; i++)
{
	if(a == streetLeft[i] || a == streetRight[i])
		Console.WriteLine(i+1);	
}
