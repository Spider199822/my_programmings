
#include <iostream>
#include <cstdlib>
using namespace std;

int main()
{
	long long a,b,c,d,i=0,n,sum=0;
	cin>>n;
	cin>>a;
	cin>>b;
	cin>>c;
    if(n>b)
	{
		n%=b;
		i++;
		n+=c;
		i++;
		
	
	}
	if(n==a)
	{
		cout<<i;
		
	
	}
	if(n==b)
		cout<<i;
		
	
//_getch();
return 0;
}