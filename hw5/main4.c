#include <stdio.h>

int main() {
    int i = 12345;
    int tmp1 = 0, tmp2 = 0;
    int count1 = 0, count2 = 0;
    while (i >= 10000)
    {
        i-=10000;
        tmp1+=10000;
    }
    while (i >= 1000)
    {
        i-=1000;
        count1++;
    }
    while (i >= 10)
    {
        i-=10;
        tmp2+=10;
    }
    while (i > 0)
    {
        i--;
        count2++;
    }
    printf("%d", count1 + tmp2 + count2*1000 + tmp1);
    return 0;
}
