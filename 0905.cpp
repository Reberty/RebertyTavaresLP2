#include <stdio.h>
#define TA  10010
int main(void)
{
	int n;
	int mult[TA];
	
	scanf("%d", &n);
	for(int i=0; i<n; i++)
		scanf("%d", &mult[i]);

	for (int i = 0; i < n/2 ; i++)
	{
		printf("%d\n", mult[i]*mult[n-1-i]);
	}
	if (n%2==!0)
	{
		printf("%d\n", mult[n/2]);
	}


	return 0;
}